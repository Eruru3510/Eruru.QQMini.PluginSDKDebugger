using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Eruru.Json;
using Eruru.QQMini.PluginSDKHelper;
using QQMini.PluginSDK.Core;
using QQMini.PluginSDK.Core.Model;

namespace Eruru.QQMini.PluginSDKDebugger {

	public partial class QMDebuggerForm : Form {

		readonly string ConfigFilePath = "Eruru.QQMini.PluginSDKDebugger Config.json";
		readonly JsonConfig JsonConfig = new JsonConfig () {
			Compress = false,
			IgnoreDefaultValue = true
		};

		Type PluginBaseType;
		object PluginBaseInstance;
		MethodInfo OnReceiveGroupMessage;
		MethodInfo OnReceiveGroupTempMessage;
		MethodInfo OnReceiveFriendMessage;
		MethodInfo OnOpenSettingMenu;
		Config Config = new Config ();
		string RawDllFilePath;
		long MessageNumber;
		int MessageId {

			get {
				if (_MessageId < int.MaxValue) {
					_MessageId = 0;
					MessageNumber++;
				} else {
					_MessageId++;
				}
				return _MessageId;
			}

		}
		int _MessageId;

		public QMDebuggerForm (string rawDllFilePath) {
			if (rawDllFilePath is null) {
				throw new ArgumentNullException (nameof (rawDllFilePath));
			}
			InitializeComponent ();
			RawDllFilePath = rawDllFilePath;
		}

		private void Form1_Load (object sender, EventArgs e) {
			LoadConfig ();
			Assembly pluginAssembly = Assembly.LoadFrom (new FileInfo (RawDllFilePath).FullName);
			PluginBaseType = null;
			Type qmHelperApiType = null;
			QMHelperApi.IsDebugMode = true;
			foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies ()) {
				foreach (Type type in assembly.GetTypes ()) {
					if (type == typeof (QMHelperApi)) {
						qmHelperApiType = type;
					}
					if (type.BaseType == typeof (PluginBase)) {
						PluginBaseType = type;
						break;
					}
				}
			}
			qmHelperApiType.GetField (nameof (QMHelperApi.OnSend)).SetValue (null, new Action<string> (Program_OnSend));
			qmHelperApiType.GetField (nameof (QMHelperApi.OnDebug)).SetValue (null, new Action<string> (Program_OnDebug));
			OnReceiveGroupMessage = PluginBaseType.GetMethod (nameof (PluginBase.OnReceiveGroupMessage));
			OnReceiveGroupTempMessage = PluginBaseType.GetMethod (nameof (PluginBase.OnReceiveGroupTempMessage));
			OnReceiveFriendMessage = PluginBaseType.GetMethod (nameof (PluginBase.OnReceiveFriendMessage));
			OnOpenSettingMenu = PluginBaseType.GetMethod (nameof (PluginBase.OnOpenSettingMenu));
			PluginBaseInstance = Activator.CreateInstance (PluginBaseType);
			PluginBaseType.GetMethod (nameof (PluginBase.OnInitialize)).Invoke (PluginBaseInstance, null);
		}

		private void Program_OnSend (string message) {
			Output ($"[收到消息]：{message}");
		}

		private void Program_OnDebug (string text) {
			Output ($"[调试输出]：{text}");
		}

		private void TextBox_Message_KeyUp (object sender, KeyEventArgs e) {
			if (!e.Control && e.KeyCode == Keys.Enter) {
				e.Handled = true;
				Button_Send.PerformClick ();
			}
		}

		private void Button_Send_Click (object sender, EventArgs e) {
			string text = TextBox_Message.Text.TrimEnd ();
			TextBox_Message.Clear ();
			if (string.IsNullOrWhiteSpace (text)) {
				return;
			}
			Output ($"[发送消息]：{text}");
			long.TryParse (TextBox_RobotQQ.Text, out long robotQQ);
			long.TryParse (TextBox_Group.Text, out long group);
			long.TryParse (TextBox_QQ.Text, out long qq);
			switch (ComboBox_MessageType.SelectedItem) {
				case "群":
					OnReceiveGroupMessage.Invoke (PluginBaseInstance, new object[] { new QMGroupMessageEventArgs (
						(int)QMEventTypes.GroupMessage,
						(int)QMGroupMessageEventSubTypes.Group,
						robotQQ,
						group,
						qq,
						MessageNumber,
						MessageId,
						Marshal.StringToHGlobalAnsi (text)
					) });
					break;
				case "群临时":
					OnReceiveGroupTempMessage.Invoke (PluginBaseInstance, new object[] { new QMGroupPrivateMessageEventArgs (
						(int)QMEventTypes.GroupMessage,
						(int)QMPrivateMessageEventSubTypes.GroupTemp,
						robotQQ,
						group,
						qq,
						MessageNumber,
						MessageId,
						Marshal.StringToHGlobalAnsi (text)
					) });
					break;
				case "好友":
					OnReceiveFriendMessage.Invoke (PluginBaseInstance, new object[] { new QMPrivateMessageEventArgs (
						(int)QMEventTypes.GroupMessage,
						(int)QMPrivateMessageEventSubTypes.Friend,
						robotQQ,
						group,
						qq,
						MessageNumber,
						MessageId,
						Marshal.StringToHGlobalAnsi (text)
					) });
					break;
			}
		}

		private void Button_OpenWindow_Click (object sender, EventArgs e) {
			OnOpenSettingMenu.Invoke (PluginBaseInstance, null);
		}

		private void Form1_FormClosed (object sender, FormClosedEventArgs e) {
			SaveConfig ();
			PluginBaseType.GetMethod (nameof (PluginBase.OnUninitialize)).Invoke (PluginBaseInstance, null);
		}

		void LoadConfig () {
			if (File.Exists (ConfigFilePath)) {
				Config = JsonConvert.DeserializeFile (ConfigFilePath, Config, JsonConfig);
			}
			if (Config.MessageType < 0) {
				Config.MessageType = 0;
			} else if (Config.MessageType >= ComboBox_MessageType.Items.Count) {
				Config.MessageType = ComboBox_MessageType.Items.Count - 1;
			}
			ComboBox_MessageType.SelectedIndex = Config.MessageType;
			TextBox_RobotQQ.Text = Config.RobotQQ.ToString ();
			TextBox_Group.Text = Config.Group.ToString ();
			TextBox_QQ.Text = Config.QQ.ToString ();
		}

		void SaveConfig () {
			Config.MessageType = ComboBox_MessageType.SelectedIndex;
			long.TryParse (TextBox_RobotQQ.Text, out long result);
			Config.RobotQQ = result;
			long.TryParse (TextBox_Group.Text, out result);
			Config.Group = result;
			long.TryParse (TextBox_QQ.Text, out result);
			Config.QQ = result;
			JsonConvert.Serialize (Config, ConfigFilePath);
		}

		void Output (string message) {
			Invoke (new Action (() => {
				if (TextBox_Output.TextLength != 0) {
					TextBox_Output.AppendText (Environment.NewLine);
				}
				TextBox_Output.AppendText ($"[{DateTime.Now}] ");
				TextBox_Output.AppendText (message);
				TextBox_Output.ScrollToCaret ();
			}));
		}

	}

	class Config {

		public int MessageType = 0;
		public long RobotQQ = 100000000;
		public long Group = 987654321;
		public long QQ = 123456789;

	}

}
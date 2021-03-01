using System;
using System.IO;
using System.Windows.Forms;

namespace Eruru.QQMini.PluginSDKDebugger {

	public static class QMDebugger {

		public static bool IsDebugConfigure { get; set; }

		[STAThread]
		public static void Start (string rawDllFilePath) {
			if (rawDllFilePath is null) {
				throw new ArgumentNullException (nameof (rawDllFilePath));
			}
			if (!File.Exists (rawDllFilePath)) {
				throw new Exception ($"文件{rawDllFilePath}不存在，是否已编译插件项目？，或此项目与插件项目在同一个解决方案内？，或者请手动指定路径");
			}
			FileInfo fileInfo = new FileInfo (rawDllFilePath);
			foreach (FileInfo current in new DirectoryInfo ($@"{fileInfo.DirectoryName}\Bin").GetFiles ()) {
				File.Copy (current.FullName, current.Name, true);
			}
			Application.EnableVisualStyles ();
			Application.SetCompatibleTextRenderingDefault (false);
			Application.Run (new QMDebuggerForm (rawDllFilePath));
		}
		public static void StartByRelative (string packageId) {
			if (packageId is null) {
				throw new ArgumentNullException (nameof (packageId));
			}
			Start ($@"..\..\..\{packageId}\bin\{(IsDebugConfigure ? "Debug" : "Release")}\{packageId}\{packageId}.dll");
		}

	}

}
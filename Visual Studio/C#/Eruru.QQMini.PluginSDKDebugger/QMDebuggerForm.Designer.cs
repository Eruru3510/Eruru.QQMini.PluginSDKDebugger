
namespace Eruru.QQMini.PluginSDKDebugger {
	partial class QMDebuggerForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent () {
			this.TextBox_Output = new System.Windows.Forms.TextBox ();
			this.ComboBox_MessageType = new System.Windows.Forms.ComboBox ();
			this.TextBox_Group = new System.Windows.Forms.TextBox ();
			this.TextBox_QQ = new System.Windows.Forms.TextBox ();
			this.TextBox_Message = new System.Windows.Forms.TextBox ();
			this.Button_Send = new System.Windows.Forms.Button ();
			this.Button_OpenWindow = new System.Windows.Forms.Button ();
			this.label1 = new System.Windows.Forms.Label ();
			this.label2 = new System.Windows.Forms.Label ();
			this.label3 = new System.Windows.Forms.Label ();
			this.TextBox_RobotQQ = new System.Windows.Forms.TextBox ();
			this.label4 = new System.Windows.Forms.Label ();
			this.SuspendLayout ();
			// 
			// TextBox_Output
			// 
			this.TextBox_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.TextBox_Output.Font = new System.Drawing.Font ("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBox_Output.Location = new System.Drawing.Point (5, 5);
			this.TextBox_Output.Multiline = true;
			this.TextBox_Output.Name = "TextBox_Output";
			this.TextBox_Output.ReadOnly = true;
			this.TextBox_Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TextBox_Output.Size = new System.Drawing.Size (974, 480);
			this.TextBox_Output.TabIndex = 5;
			this.TextBox_Output.WordWrap = false;
			// 
			// ComboBox_MessageType
			// 
			this.ComboBox_MessageType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ComboBox_MessageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox_MessageType.FormattingEnabled = true;
			this.ComboBox_MessageType.Items.AddRange (new object[] {
			"群",
			"群临时",
			"好友"});
			this.ComboBox_MessageType.Location = new System.Drawing.Point (65, 490);
			this.ComboBox_MessageType.Name = "ComboBox_MessageType";
			this.ComboBox_MessageType.Size = new System.Drawing.Size (120, 20);
			this.ComboBox_MessageType.TabIndex = 2;
			// 
			// TextBox_Group
			// 
			this.TextBox_Group.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.TextBox_Group.Location = new System.Drawing.Point (380, 490);
			this.TextBox_Group.Name = "TextBox_Group";
			this.TextBox_Group.Size = new System.Drawing.Size (100, 21);
			this.TextBox_Group.TabIndex = 3;
			this.TextBox_Group.Text = "987654321";
			// 
			// TextBox_QQ
			// 
			this.TextBox_QQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.TextBox_QQ.Location = new System.Drawing.Point (510, 490);
			this.TextBox_QQ.Name = "TextBox_QQ";
			this.TextBox_QQ.Size = new System.Drawing.Size (100, 21);
			this.TextBox_QQ.TabIndex = 4;
			this.TextBox_QQ.Text = "123456789";
			// 
			// TextBox_Message
			// 
			this.TextBox_Message.AcceptsTab = true;
			this.TextBox_Message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.TextBox_Message.Location = new System.Drawing.Point (5, 515);
			this.TextBox_Message.Multiline = true;
			this.TextBox_Message.Name = "TextBox_Message";
			this.TextBox_Message.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TextBox_Message.Size = new System.Drawing.Size (870, 100);
			this.TextBox_Message.TabIndex = 0;
			this.TextBox_Message.WordWrap = false;
			this.TextBox_Message.KeyUp += new System.Windows.Forms.KeyEventHandler (this.TextBox_Message_KeyUp);
			// 
			// Button_Send
			// 
			this.Button_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Button_Send.Location = new System.Drawing.Point (880, 595);
			this.Button_Send.Name = "Button_Send";
			this.Button_Send.Size = new System.Drawing.Size (100, 23);
			this.Button_Send.TabIndex = 1;
			this.Button_Send.Text = "发送消息";
			this.Button_Send.UseVisualStyleBackColor = true;
			this.Button_Send.Click += new System.EventHandler (this.Button_Send_Click);
			// 
			// Button_OpenWindow
			// 
			this.Button_OpenWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Button_OpenWindow.Location = new System.Drawing.Point (880, 515);
			this.Button_OpenWindow.Name = "Button_OpenWindow";
			this.Button_OpenWindow.Size = new System.Drawing.Size (100, 23);
			this.Button_OpenWindow.TabIndex = 6;
			this.Button_OpenWindow.Text = "设置窗口";
			this.Button_OpenWindow.UseVisualStyleBackColor = true;
			this.Button_OpenWindow.Click += new System.EventHandler (this.Button_OpenWindow_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.Location = new System.Drawing.Point (5, 490);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size (100, 20);
			this.label1.TabIndex = 7;
			this.label1.Text = "消息类型：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.Location = new System.Drawing.Point (355, 490);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size (100, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "群：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.Location = new System.Drawing.Point (485, 490);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size (100, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "QQ：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TextBox_RobotQQ
			// 
			this.TextBox_RobotQQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.TextBox_RobotQQ.Location = new System.Drawing.Point (250, 490);
			this.TextBox_RobotQQ.Name = "TextBox_RobotQQ";
			this.TextBox_RobotQQ.Size = new System.Drawing.Size (100, 21);
			this.TextBox_RobotQQ.TabIndex = 10;
			this.TextBox_RobotQQ.Text = "100000000";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.Location = new System.Drawing.Point (190, 490);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size (100, 20);
			this.label4.TabIndex = 11;
			this.label4.Text = "机器人QQ：";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// QMDebuggerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size (984, 621);
			this.Controls.Add (this.TextBox_RobotQQ);
			this.Controls.Add (this.label4);
			this.Controls.Add (this.Button_OpenWindow);
			this.Controls.Add (this.Button_Send);
			this.Controls.Add (this.TextBox_Message);
			this.Controls.Add (this.TextBox_QQ);
			this.Controls.Add (this.TextBox_Group);
			this.Controls.Add (this.ComboBox_MessageType);
			this.Controls.Add (this.TextBox_Output);
			this.Controls.Add (this.label1);
			this.Controls.Add (this.label2);
			this.Controls.Add (this.label3);
			this.Name = "QMDebuggerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler (this.Form1_FormClosed);
			this.Load += new System.EventHandler (this.Form1_Load);
			this.ResumeLayout (false);
			this.PerformLayout ();

		}

		#endregion

		private System.Windows.Forms.TextBox TextBox_Output;
		private System.Windows.Forms.ComboBox ComboBox_MessageType;
		private System.Windows.Forms.TextBox TextBox_Group;
		private System.Windows.Forms.TextBox TextBox_QQ;
		private System.Windows.Forms.TextBox TextBox_Message;
		private System.Windows.Forms.Button Button_Send;
		private System.Windows.Forms.Button Button_OpenWindow;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TextBox_RobotQQ;
		private System.Windows.Forms.Label label4;
	}
}
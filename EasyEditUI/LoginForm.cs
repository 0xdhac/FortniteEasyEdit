using System;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.Diagnostics;

namespace EasyEditUI
{
	public partial class LoginForm : Form
	{
		private string loginUrl = "http://oxdmacro.site.nfoservers.com/login.php";

		public LoginForm()
		{
			InitializeComponent();
			UsernameTextbox.Select();
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			PasswordTextbox.KeyDown += (sender, args) =>
			{
				if (args.KeyCode == Keys.Return)
				{
					LoginButton.PerformClick();
				}
			};

			UsernameTextbox.KeyDown += (sender, args) =>
			{
				if (args.KeyCode == Keys.Return)
				{
					LoginButton.PerformClick();
				}
			};
		}

		private string AttemptLogin(string username, string password)
		{
			var reqparm = new System.Collections.Specialized.NameValueCollection();
			Program.webClient.QueryString.Add("user", username);
			Program.webClient.QueryString.Add("pass", password);
			var data = Program.webClient.UploadValues(loginUrl, "POST", Program.webClient.QueryString);

			var responseString = UnicodeEncoding.UTF8.GetString(data);
			return responseString;
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
#if !NOVERIFY
			if (UsernameTextbox.TextLength > 0 && PasswordTextbox.TextLength > 0)
			{
				LoginButton.Enabled = false;
				string response = AttemptLogin(UsernameTextbox.Text, PasswordTextbox.Text);
				if (response == "SUCCESS:LOGGED_IN")
				{
					Hide();
					Hotkey.CreateKeyboardMap();
					Hotkey.InitConfig();

					Hotkey.m_CheckForegroundThread = new Thread(Hotkey.CheckForegroundT);
					Hotkey.m_UpdateLastKeysThread  = new Thread(Hotkey.UpdateLastKeysT);
					Hotkey.m_EditThread            = new Thread(Hotkey.EditT);
					Hotkey.m_WallReplaceThread     = new Thread(Hotkey.WallReplaceT);
					Hotkey.m_CrouchThread          = new Thread(Hotkey.CrouchT);
			
					Hotkey.m_CheckForegroundThread.IsBackground = true;
					Hotkey.m_UpdateLastKeysThread.IsBackground  = true;
					Hotkey.m_EditThread.IsBackground            = true;
					Hotkey.m_WallReplaceThread.IsBackground     = true;
					Hotkey.m_CrouchThread.IsBackground          = true;

					Hotkey.m_CheckForegroundThread.Start();
					Hotkey.m_UpdateLastKeysThread.Start();
					Hotkey.m_EditThread.Start();
					Hotkey.m_WallReplaceThread.Start();
					Hotkey.m_CrouchThread.Start();
					new Form1().Show();
				}
				LoginButton.Enabled = true;
			}
#endif

			#if NOVERIFY
			Hide();
			Hotkey.CreateKeyboardMap();
			Hotkey.InitConfig();

			Hotkey.m_CheckForegroundThread = new Thread(Hotkey.CheckForegroundT);
			Hotkey.m_UpdateLastKeysThread = new Thread(Hotkey.UpdateLastKeysT);
			Hotkey.m_EditThread = new Thread(Hotkey.EditT);
			Hotkey.m_WallReplaceThread = new Thread(Hotkey.WallReplaceT);
			Hotkey.m_CrouchThread = new Thread(Hotkey.CrouchT);

			Hotkey.m_CheckForegroundThread.IsBackground = true;
			Hotkey.m_UpdateLastKeysThread.IsBackground = true;
			Hotkey.m_EditThread.IsBackground = true;
			Hotkey.m_WallReplaceThread.IsBackground = true;
			Hotkey.m_CrouchThread.IsBackground = true;

			Hotkey.m_CheckForegroundThread.Start();
			Hotkey.m_UpdateLastKeysThread.Start();
			Hotkey.m_EditThread.Start();
			Hotkey.m_WallReplaceThread.Start();
			Hotkey.m_CrouchThread.Start();
			new Form1().Show();
			#endif
		}
	}
}

using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;

namespace EasyEditUI
{
	public partial class LoginForm : Form
	{
		private string url = "http://localhost/phplearning/login.php";

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
			using (WebClient client = new WebClient())
			{
				var reqparm = new System.Collections.Specialized.NameValueCollection();
				client.QueryString.Add("user", username);
				client.QueryString.Add("pass", password);
				var data = client.UploadValues(url, "POST", client.QueryString);

				// data here is optional, in case we recieve any string data back from the POST request.
				var responseString = UnicodeEncoding.UTF8.GetString(data);
				return responseString;
			}
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			
			if(UsernameTextbox.TextLength > 0 && PasswordTextbox.TextLength > 0)
			{
				LoginButton.Enabled = false;
				string response = AttemptLogin(UsernameTextbox.Text, PasswordTextbox.Text);
				if(response == "SUCCESS:LOGGED_IN")
				{
					Hide();
					Hotkey.CreateKeyboardMap();
					Hotkey.InitConfig();

					Hotkey.m_CheckForegroundThread	= new Thread(Hotkey.CheckForegroundT);
					Hotkey.m_UpdateLastKeysThread	= new Thread(Hotkey.UpdateLastKeysT);
					Hotkey.m_EditThread				= new Thread(Hotkey.EditT);
					Hotkey.m_WallReplaceThread		= new Thread(Hotkey.WallReplaceT);
					Hotkey.m_CrouchThread			= new Thread(Hotkey.CrouchT);

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
				}

				LoginButton.Enabled = true;
			}
		}
	}
}

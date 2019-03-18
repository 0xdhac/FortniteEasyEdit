using System;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using System.Collections.Generic;

using System.Text;

namespace EasyEditUI
{
	public partial class Form1 : Form
	{
		public ToolTip m_ToolTip;
		public List<BindElement> m_BindList;

		public Form1()
		{
			InitializeComponent();
			FormClosing += Form1_Closing;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Application.Exit();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			m_ToolTip = new ToolTip(components);
			DrawBinds();

			#if !NOVERIFY
			new Thread(ValidateSelfThread).Start();
			#endif
		}

		private void DrawBinds()
		{
			m_BindList = new List<BindElement>();
			StringBuilder sbname        = new StringBuilder(32);
			StringBuilder sbdisplayName = new StringBuilder(32);
			StringBuilder sbdescription = new StringBuilder(256);

			for (int i = 0; i < Hotkey.GetBindCount(); i++)
			{
				int vkCode = Hotkey.GetBind(i, sbname, sbdisplayName, sbdescription);

				string name        = sbname.ToString();
				string displayName = sbdisplayName.ToString();
				string description = sbdescription.ToString();

				m_BindList.Add(new BindElement(this, name, displayName, description, vkCode, new Point(10, i * 25 + 10)));
			}

			ClientSize = new Size(318, m_BindList.Count * 25 + 10);
		}

		private void ValidateSelfThread()
		{
			if (ValidateSelf() != "SUCCESS")
			{
				Application.Exit();
			}
		}

		private static string ValidateSelf()
		{
			string validateUrl = "http://oxdmacro.site.nfoservers.com/validate.php";
			string sHash = Program.GetExecutingFileHash();

			Program.webClient.QueryString.Clear();
			Program.webClient.QueryString.Add("hash", sHash);
			var data = Program.webClient.UploadValues(validateUrl, "POST", Program.webClient.QueryString);
			return Encoding.UTF8.GetString(data);
		}
	}

	public class BindElement
	{
		public Label m_BindLabel;
		public TextBox m_BindTextBox;
		public Button m_BindButton;
		public string m_BindName;
		public int m_vkCode;
		public Form1 m_Parent;

		public BindElement(Form1 parent, string name, string label, string description, int vkCode, Point p)
		{
			m_BindName = name;
			m_Parent = parent;

			// Set up label
			m_BindLabel          = new Label();
			m_BindLabel.AutoSize = true;
			m_BindLabel.Location = new Point(p.X, p.Y);
			m_BindLabel.Name     = name + "Label";
			m_BindLabel.Size     = new Size(86, 13);
			m_BindLabel.TabIndex = 2;
			if (description.Length > 0)
			{
				label += " (?)";
				parent.m_ToolTip.SetToolTip(m_BindLabel, description);
			}
			m_BindLabel.Text = label;

			// Set up textbox
			m_BindTextBox           = new TextBox();
			m_BindTextBox.BackColor = SystemColors.ButtonHighlight;
			m_BindTextBox.Location  = new Point(p.X + 120, p.Y - 2);
			m_BindTextBox.Name      = name + "TextBox";
			m_BindTextBox.ReadOnly  = true;
			m_BindTextBox.Size      = new Size(100, 20);
			m_BindTextBox.TabIndex  = 0;
			m_BindTextBox.TextAlign = HorizontalAlignment.Center;
			m_BindTextBox.Text      = Hotkey.GetHotkeyName(vkCode);

			// Set up button
			m_BindButton                         = new Button();
			m_BindButton.Font                    = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			m_BindButton.Location                = new Point(p.X + 226, p.Y - 2);
			m_BindButton.Name                    = name + "Button";
			m_BindButton.Size                    = new Size(75, 21);
			m_BindButton.TabIndex                = 1;
			m_BindButton.Text                    = "Change";
			m_BindButton.UseVisualStyleBackColor = true;
			m_BindButton.Click += new EventHandler(BindButton_Click);

			// Add to parent form
			parent.Controls.Add(m_BindLabel);
			parent.Controls.Add(m_BindTextBox);
			parent.Controls.Add(m_BindButton);
		}

		private void BindButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this);
		}
	}


}

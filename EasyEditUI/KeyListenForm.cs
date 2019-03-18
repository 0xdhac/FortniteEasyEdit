using System.Windows.Forms;

namespace EasyEditUI
{
	public partial class KeyListenForm : Form
	{
		BindElement m_BindElement;

		public KeyListenForm(BindElement b)
		{
			m_BindElement = b;
			InitializeComponent();
			KeyDown           += KeyListenForm_KeyPress;
			label1.KeyDown    += KeyListenForm_KeyPress;
			label2.KeyDown    += KeyListenForm_KeyPress;
			MouseDown         += KeyListenForm_MouseDown;
			label1.MouseDown  += KeyListenForm_MouseDown;
			label2.MouseDown  += KeyListenForm_MouseDown;
			MouseWheel        += KeyListenForm_MouseDown;
			label1.MouseWheel += KeyListenForm_MouseDown;
			label2.MouseWheel += KeyListenForm_MouseDown;

			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			ShowDialog();
		}

		public void KeyListenForm_KeyPress(object sender, KeyEventArgs e)
		{
			int index;
			int vK;

			if(e.Shift)
			{
				vK    = 0xa0;
				index = Hotkey.GetHotkeyIndex(vK);
			}
			else if(e.Alt)
			{
				vK    = 0xa4;
				index = Hotkey.GetHotkeyIndex(vK);
			}
			else if(e.Control)
			{
				vK    = 0xa2;
				index = Hotkey.GetHotkeyIndex(vK);
			}
			else
			{
				vK    = e.KeyValue;
				index = Hotkey.GetHotkeyIndex(e.KeyValue);	
			}

			if (index == -1)
				return;

			m_BindElement.m_BindTextBox.Text = Hotkey.GetHotkeyNameFromIndex(index);

			string str = m_BindElement.m_BindName + char.MinValue;
			byte[] bytes = System.Text.Encoding.ASCII.GetBytes(str);
			Hotkey.SetBind(bytes, vK);

			Close();
		}

		private void KeyListenForm_MouseDown(object sender, MouseEventArgs e)
		{
			int index = 0;
			int vK;
			if (e.Button == MouseButtons.XButton1)
			{
				vK = 0x5;
			}
			else if(e.Button == MouseButtons.XButton2)
			{
				vK = 0x6;
			}
			else if(e.Button == MouseButtons.Left)
			{
				vK = 0x1;
			}
			else if(e.Button == MouseButtons.Right)
			{
				vK = 0x2;
			}
			else if(e.Delta > 0)
			{
				vK = 0xff;
			}
			else if(e.Delta < 0)
			{
				vK = 0xfe;
			}
			else
			{
				return;
			}

			m_BindElement.m_BindTextBox.Text = Hotkey.GetHotkeyNameFromIndex(Hotkey.GetHotkeyIndex(vK));

			string str = m_BindElement.m_BindName + char.MinValue;
			byte[] bytes = System.Text.Encoding.ASCII.GetBytes(str);
			Hotkey.SetBind(bytes, vK);

			Close();
		}
	}
}

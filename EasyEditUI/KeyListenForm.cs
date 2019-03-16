using System.Windows.Forms;

namespace EasyEditUI
{
	public partial class KeyListenForm : Form
	{
		TextBox m_textBox;
		Form1 m_Parent;

		public KeyListenForm(Form1 f, TextBox t)
		{
			m_textBox = t;
			m_Parent = f;
			InitializeComponent();
			KeyDown   += KeyListenForm_KeyPress;
			MouseDown += KeyListenForm_MouseDown;
			MouseWheel += KeyListenForm_MouseDown;
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

			m_textBox.Text = Hotkey.GetHotkeyNameFromIndex(index);

			if (m_textBox == m_Parent.FakeEditKeyBox)
			{
				Hotkey.SetFakeEditHotkey(vK);
			}
			else if(m_textBox == m_Parent.RealEditKeyBox)
			{
				Hotkey.SetRealEditHotkey(vK);
			}
			else if (m_textBox == m_Parent.WallRetakeKeyBox)
			{
				Hotkey.SetWallRetakeHotkey(vK);
			}
			else if (m_textBox == m_Parent.ShotgunKeyBox)
			{
				Hotkey.SetShotgunHotkey(vK);
			}
			else if (m_textBox == m_Parent.WallKeyBox)
			{
				Hotkey.SetBuildHotkey((int)Hotkey.BuildType.Build_Wall, vK);
			}
			else if (m_textBox == m_Parent.FloorKeyBox)
			{
				Hotkey.SetBuildHotkey((int)Hotkey.BuildType.Build_Floor, vK);
			}
			else if (m_textBox == m_Parent.StairKeyBox)
			{
				Hotkey.SetBuildHotkey((int)Hotkey.BuildType.Build_Stair, vK);
			}
			else if (m_textBox == m_Parent.ConeKeyBox)
			{
				Hotkey.SetBuildHotkey((int)Hotkey.BuildType.Build_Cone, vK);
			}
			else if (m_textBox == m_Parent.PickaxeKeyBox)
			{
				Hotkey.SetWeaponHotkey(0, vK);
			}
			else if (m_textBox == m_Parent.Weapon1KeyBox)
			{
				Hotkey.SetWeaponHotkey(1, vK);
			}
			else if (m_textBox == m_Parent.Weapon2KeyBox)
			{
				Hotkey.SetWeaponHotkey(2, vK);
			}
			else if (m_textBox == m_Parent.Weapon3KeyBox)
			{
				Hotkey.SetWeaponHotkey(3, vK);
			}
			else if (m_textBox == m_Parent.Weapon4KeyBox)
			{
				Hotkey.SetWeaponHotkey(4, vK);
			}
			else if (m_textBox == m_Parent.Weapon5KeyBox)
			{
				Hotkey.SetWeaponHotkey(5, vK);
			}
			else if (m_textBox == m_Parent.FakeCrouchKeyBox)
			{
				Hotkey.SetFakeCrouchHotkey(vK);
			}
			else if (m_textBox == m_Parent.RealCrouchKeyBox)
			{
				Hotkey.SetRealCrouchHotkey(vK);
			}
			else if(m_textBox == m_Parent.UseKeyBox)
			{
				Hotkey.SetUseHotkey(vK);
			}

			Close();
		}

		private void KeyListenForm_MouseDown(object sender, MouseEventArgs e)
		{
			int index = 0;
			int vK;
			if (e.Button == MouseButtons.XButton1)
			{
				vK = 0x5;
				index = Hotkey.GetHotkeyIndex(0x5);
			}
			else if(e.Button == MouseButtons.XButton2)
			{
				vK = 0x6;
				index = Hotkey.GetHotkeyIndex(0x6);
			}
			else if(e.Delta > 0)
			{
				vK = 0xff;
				index = Hotkey.GetHotkeyIndex(0xff);
			}
			else if(e.Delta < 0)
			{
				vK = 0xfe;
				index = Hotkey.GetHotkeyIndex(0xfe);
			}
			else
			{
				return;
			}

			m_textBox.Text = Hotkey.GetHotkeyNameFromIndex(index);

			if (m_textBox == m_Parent.FakeEditKeyBox)
			{
				Hotkey.SetFakeEditHotkey(vK);
			}
			else if (m_textBox == m_Parent.RealEditKeyBox)
			{
				Hotkey.SetRealEditHotkey(vK);
			}
			else if (m_textBox == m_Parent.WallRetakeKeyBox)
			{
				Hotkey.SetWallRetakeHotkey(vK);
			}
			else if (m_textBox == m_Parent.ShotgunKeyBox)
			{
				Hotkey.SetShotgunHotkey(vK);
			}
			else if (m_textBox == m_Parent.WallKeyBox)
			{
				Hotkey.SetBuildHotkey((int)Hotkey.BuildType.Build_Wall, vK);
			}
			else if (m_textBox == m_Parent.FloorKeyBox)
			{
				Hotkey.SetBuildHotkey((int)Hotkey.BuildType.Build_Floor, vK);
			}
			else if (m_textBox == m_Parent.StairKeyBox)
			{
				Hotkey.SetBuildHotkey((int)Hotkey.BuildType.Build_Stair, vK);
			}
			else if (m_textBox == m_Parent.ConeKeyBox)
			{
				Hotkey.SetBuildHotkey((int)Hotkey.BuildType.Build_Cone, vK);
			}
			else if (m_textBox == m_Parent.PickaxeKeyBox)
			{
				Hotkey.SetWeaponHotkey(0, vK);
			}
			else if (m_textBox == m_Parent.Weapon1KeyBox)
			{
				Hotkey.SetWeaponHotkey(1, vK);
			}
			else if (m_textBox == m_Parent.Weapon2KeyBox)
			{
				Hotkey.SetWeaponHotkey(2, vK);
			}
			else if (m_textBox == m_Parent.Weapon3KeyBox)
			{
				Hotkey.SetWeaponHotkey(3, vK);
			}
			else if (m_textBox == m_Parent.Weapon4KeyBox)
			{
				Hotkey.SetWeaponHotkey(4, vK);
			}
			else if (m_textBox == m_Parent.Weapon5KeyBox)
			{
				Hotkey.SetWeaponHotkey(5, vK);
			}
			else if (m_textBox == m_Parent.FakeCrouchKeyBox)
			{
				Hotkey.SetFakeCrouchHotkey(vK);
			}
			else if (m_textBox == m_Parent.RealCrouchKeyBox)
			{
				Hotkey.SetRealCrouchHotkey(vK);
			}
			else if (m_textBox == m_Parent.UseKeyBox)
			{
				Hotkey.SetUseHotkey(vK);
			}

			Close();
		}
	}
}

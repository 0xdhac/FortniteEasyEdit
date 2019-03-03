using System;
using System.Windows.Forms;

namespace EasyEditUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			FormClosing += Form1_Closing;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Select();
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Application.Exit();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			FakeEditKeyButton.Click		+= new System.EventHandler(FakeEditKeyButton_Click);
			RealEditKeyButton.Click		+= new System.EventHandler(RealEditKeyButton_Click);
			WallRetakeKeyButton.Click	+= new System.EventHandler(WallRetakeKeyButton_Click);
			ShotgunKeyButton.Click		+= new System.EventHandler(ShotgunKeyButton_Click);
			WallKeyButton.Click			+= new System.EventHandler(WallKeyButton_Click);
			FloorKeyButton.Click		+= new System.EventHandler(FloorKeyButton_Click);
			StairKeyButton.Click		+= new System.EventHandler(StairKeyButton_Click);
			ConeKeyButton.Click			+= new System.EventHandler(ConeKeyButton_Click);
			PickaxeKeyButton.Click		+= new System.EventHandler(PickaxeKeyButton_Click);
			Weapon1KeyButton.Click		+= new System.EventHandler(Weapon1KeyButton_Click);
			Weapon2KeyButton.Click		+= new System.EventHandler(Weapon2KeyButton_Click);
			Weapon3KeyButton.Click		+= new System.EventHandler(Weapon3KeyButton_Click);
			Weapon4KeyButton.Click		+= new System.EventHandler(Weapon4KeyButton_Click);
			Weapon5KeyButton.Click		+= new System.EventHandler(Weapon5KeyButton_Click);
			RealCrouchKeyButton.Click	+= new System.EventHandler(RealCrouchButton_Click);
			FakeCrouchKeyButton.Click	+= new System.EventHandler(FakeCrouchButton_Click);
			UseKeyButton.Click			+= new System.EventHandler(UseKeyButton_Click);

			FakeEditKeyBox.Text   = Hotkey.GetHotkeyName(Hotkey.GetFakeEditHotkey());
			RealEditKeyBox.Text   = Hotkey.GetHotkeyName(Hotkey.GetRealEditHotkey());
			FakeCrouchKeyBox.Text = Hotkey.GetHotkeyName(Hotkey.GetFakeCrouchHotkey());
			RealCrouchKeyBox.Text = Hotkey.GetHotkeyName(Hotkey.GetRealCrouchHotkey());
			WallRetakeKeyBox.Text = Hotkey.GetHotkeyName(Hotkey.GetWallRetakeHotkey());
			ShotgunKeyBox.Text    = Hotkey.GetHotkeyName(Hotkey.GetShotgunHotkey());
			WallKeyBox.Text       = Hotkey.GetHotkeyName(Hotkey.GetBuildHotkey((int)Hotkey.BuildType.Build_Wall));
			FloorKeyBox.Text      = Hotkey.GetHotkeyName(Hotkey.GetBuildHotkey((int)Hotkey.BuildType.Build_Floor));
			StairKeyBox.Text      = Hotkey.GetHotkeyName(Hotkey.GetBuildHotkey((int)Hotkey.BuildType.Build_Stair));
			ConeKeyBox.Text       = Hotkey.GetHotkeyName(Hotkey.GetBuildHotkey((int)Hotkey.BuildType.Build_Cone));
			PickaxeKeyBox.Text    = Hotkey.GetHotkeyName(Hotkey.GetWeaponHotkey(0));
			Weapon1KeyBox.Text    = Hotkey.GetHotkeyName(Hotkey.GetWeaponHotkey(1));
			Weapon2KeyBox.Text    = Hotkey.GetHotkeyName(Hotkey.GetWeaponHotkey(2));
			Weapon3KeyBox.Text    = Hotkey.GetHotkeyName(Hotkey.GetWeaponHotkey(3));
			Weapon4KeyBox.Text    = Hotkey.GetHotkeyName(Hotkey.GetWeaponHotkey(4));
			Weapon5KeyBox.Text    = Hotkey.GetHotkeyName(Hotkey.GetWeaponHotkey(5));
			UseKeyBox.Text        = Hotkey.GetHotkeyName(Hotkey.GetUseHotkey());
		}

		private void RealCrouchButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, RealCrouchKeyBox);
		}

		private void FakeCrouchButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, FakeCrouchKeyBox);
		}

		private void UseKeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, UseKeyBox);
		}

		private void FakeEditKeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, FakeEditKeyBox);
		}

		private void RealEditKeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, RealEditKeyBox);
		}

		private void WallRetakeKeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, WallRetakeKeyBox);
		}

		private void ShotgunKeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, ShotgunKeyBox);
		}

		private void WallKeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, WallKeyBox);
		}

		private void FloorKeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, FloorKeyBox);
		}

		private void StairKeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, StairKeyBox);
		}

		private void ConeKeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, ConeKeyBox);
		}

		private void PickaxeKeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, PickaxeKeyBox);
		}

		private void Weapon1KeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, Weapon1KeyBox);
		}

		private void Weapon2KeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, Weapon2KeyBox);
		}

		private void Weapon3KeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, Weapon3KeyBox);
		}

		private void Weapon4KeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, Weapon4KeyBox);
		}

		private void Weapon5KeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, Weapon5KeyBox);
		}
	}
}

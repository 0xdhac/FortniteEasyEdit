using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EasyEditUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.FakeEditKeyBox.Text   = Hotkey.GetHotkeyName(Hotkey.GetFakeEditHotkey());
			this.RealEditKeyBox.Text   = Hotkey.GetHotkeyName(Hotkey.GetRealEditHotkey());
			this.FakeCrouchKeyBox.Text = Hotkey.GetHotkeyName(Hotkey.GetFakeCrouchHotkey());
			this.RealCrouchKeyBox.Text = Hotkey.GetHotkeyName(Hotkey.GetRealCrouchHotkey());
			this.DoorShotKeyBox.Text   = Hotkey.GetHotkeyName(Hotkey.GetDoorShotHotkey());
			this.WallRetakeKeyBox.Text = Hotkey.GetHotkeyName(Hotkey.GetWallRetakeHotkey());
			this.ShotgunKeyBox.Text    = Hotkey.GetHotkeyName(Hotkey.GetShotgunHotkey());
			this.WallKeyBox.Text       = Hotkey.GetHotkeyName(Hotkey.GetBuildHotkey((int)Hotkey.BuildType.Build_Wall));
			this.FloorKeyBox.Text      = Hotkey.GetHotkeyName(Hotkey.GetBuildHotkey((int)Hotkey.BuildType.Build_Floor));
			this.StairKeyBox.Text      = Hotkey.GetHotkeyName(Hotkey.GetBuildHotkey((int)Hotkey.BuildType.Build_Stair));
			this.ConeKeyBox.Text       = Hotkey.GetHotkeyName(Hotkey.GetBuildHotkey((int)Hotkey.BuildType.Build_Cone));
			this.PickaxeKeyBox.Text    = Hotkey.GetHotkeyName(Hotkey.GetWeaponHotkey(0));
			this.Weapon1KeyBox.Text    = Hotkey.GetHotkeyName(Hotkey.GetWeaponHotkey(1));
			this.Weapon2KeyBox.Text    = Hotkey.GetHotkeyName(Hotkey.GetWeaponHotkey(2));
			this.Weapon3KeyBox.Text    = Hotkey.GetHotkeyName(Hotkey.GetWeaponHotkey(3));
			this.Weapon4KeyBox.Text    = Hotkey.GetHotkeyName(Hotkey.GetWeaponHotkey(4));
			this.Weapon5KeyBox.Text    = Hotkey.GetHotkeyName(Hotkey.GetWeaponHotkey(5));
		}

		private void FakeEditKeyButton_Click(object sender, EventArgs e)
		{
			KeyListenForm f = new KeyListenForm(this, this.FakeEditKeyBox);
		}

		private void RealEditKeyButton_Click(object sender, EventArgs e)
		{
			KeyListenForm f = new KeyListenForm(this, this.RealEditKeyBox);
		}

		private void WallRetakeKeyButton_Click(object sender, EventArgs e)
		{
			KeyListenForm f = new KeyListenForm(this, this.WallRetakeKeyBox);
		}

		private void ShotgunKeyButton_Click(object sender, EventArgs e)
		{
			KeyListenForm f = new KeyListenForm(this, this.ShotgunKeyBox);
		}

		private void WallKeyButton_Click(object sender, EventArgs e)
		{
			KeyListenForm f = new KeyListenForm(this, this.WallKeyBox);
		}

		private void FloorKeyButton_Click(object sender, EventArgs e)
		{
			KeyListenForm f = new KeyListenForm(this, this.FloorKeyBox);
		}

		private void StairKeyButton_Click(object sender, EventArgs e)
		{
			KeyListenForm f = new KeyListenForm(this, this.StairKeyBox);
		}

		private void ConeKeyButton_Click(object sender, EventArgs e)
		{
			KeyListenForm f = new KeyListenForm(this, this.ConeKeyBox);
		}

		private void PickaxeKeyButton_Click(object sender, EventArgs e)
		{
			KeyListenForm f = new KeyListenForm(this, this.PickaxeKeyBox);
		}

		private void Weapon1KeyButton_Click(object sender, EventArgs e)
		{
			KeyListenForm f = new KeyListenForm(this, this.Weapon1KeyBox);
		}

		private void Weapon2KeyButton_Click(object sender, EventArgs e)
		{
			KeyListenForm f = new KeyListenForm(this, this.Weapon2KeyBox);
		}

		private void Weapon3KeyButton_Click(object sender, EventArgs e)
		{
			KeyListenForm f = new KeyListenForm(this, this.Weapon3KeyBox);
		}

		private void Weapon4KeyButton_Click(object sender, EventArgs e)
		{
			KeyListenForm f = new KeyListenForm(this, this.Weapon4KeyBox);
		}

		private void Weapon5KeyButton_Click(object sender, EventArgs e)
		{
			KeyListenForm f = new KeyListenForm(this, this.Weapon5KeyBox);
		}
	}
}

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
			this.FakeEditKeyButton.Click	+= new System.EventHandler(this.FakeEditKeyButton_Click);
			this.RealEditKeyButton.Click	+= new System.EventHandler(this.RealEditKeyButton_Click);
			this.WallRetakeKeyButton.Click	+= new System.EventHandler(this.WallRetakeKeyButton_Click);
			this.ShotgunKeyButton.Click		+= new System.EventHandler(this.ShotgunKeyButton_Click);
			this.WallKeyButton.Click		+= new System.EventHandler(this.WallKeyButton_Click);
			this.FloorKeyButton.Click		+= new System.EventHandler(this.FloorKeyButton_Click);
			this.StairKeyButton.Click		+= new System.EventHandler(this.StairKeyButton_Click);
			this.ConeKeyButton.Click		+= new System.EventHandler(this.ConeKeyButton_Click);
			this.PickaxeKeyButton.Click		+= new System.EventHandler(this.PickaxeKeyButton_Click);
			this.Weapon1KeyButton.Click		+= new System.EventHandler(this.Weapon1KeyButton_Click);
			this.Weapon2KeyButton.Click		+= new System.EventHandler(this.Weapon2KeyButton_Click);
			this.Weapon3KeyButton.Click		+= new System.EventHandler(this.Weapon3KeyButton_Click);
			this.Weapon4KeyButton.Click		+= new System.EventHandler(this.Weapon4KeyButton_Click);
			this.Weapon5KeyButton.Click		+= new System.EventHandler(this.Weapon5KeyButton_Click);
			this.DoorShotButton.Click		+= new System.EventHandler(this.DoorShotButton_Click);
			this.RealCrouchKeyButton.Click	+= new System.EventHandler(this.RealCrouchButton_Click);
			this.FakeCrouchKeyButton.Click	+= new System.EventHandler(this.FakeCrouchButton_Click);
			this.UseKeyButton.Click			+= new System.EventHandler(this.UseKeyButton_Click);

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
			this.UseKeyBox.Text        = Hotkey.GetHotkeyName(Hotkey.GetUseHotkey());
		}

		private void DoorShotButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, this.DoorShotKeyBox);
		}

		private void RealCrouchButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, this.RealCrouchKeyBox);
		}

		private void FakeCrouchButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, this.FakeCrouchKeyBox);
		}

		private void UseKeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, this.UseKeyBox);
		}

		private void FakeEditKeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, this.FakeEditKeyBox);
		}

		private void RealEditKeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, this.RealEditKeyBox);
		}

		private void WallRetakeKeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, this.WallRetakeKeyBox);
		}

		private void ShotgunKeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, this.ShotgunKeyBox);
		}

		private void WallKeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, this.WallKeyBox);
		}

		private void FloorKeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, this.FloorKeyBox);
		}

		private void StairKeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, this.StairKeyBox);
		}

		private void ConeKeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, this.ConeKeyBox);
		}

		private void PickaxeKeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, this.PickaxeKeyBox);
		}

		private void Weapon1KeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, this.Weapon1KeyBox);
		}

		private void Weapon2KeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, this.Weapon2KeyBox);
		}

		private void Weapon3KeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, this.Weapon3KeyBox);
		}

		private void Weapon4KeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, this.Weapon4KeyBox);
		}

		private void Weapon5KeyButton_Click(object sender, EventArgs e)
		{
			new KeyListenForm(this, this.Weapon5KeyBox);
		}
	}
}

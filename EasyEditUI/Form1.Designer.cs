using System.Collections.Generic;

namespace EasyEditUI
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.FakeEditKeyBox = new System.Windows.Forms.TextBox();
			this.FakeEditKeyButton = new System.Windows.Forms.Button();
			this.FakeEditKeyLabel = new System.Windows.Forms.Label();
			this.RealEditKeyLabel = new System.Windows.Forms.Label();
			this.WallRetakeKeyLabel = new System.Windows.Forms.Label();
			this.ShotgunKeyLabel = new System.Windows.Forms.Label();
			this.DoorShotLabel = new System.Windows.Forms.Label();
			this.RealCrouchKeyLabel = new System.Windows.Forms.Label();
			this.FakeCrouchKeyLabel = new System.Windows.Forms.Label();
			this.RealEditKeyButton = new System.Windows.Forms.Button();
			this.RealEditKeyBox = new System.Windows.Forms.TextBox();
			this.WallRetakeKeyButton = new System.Windows.Forms.Button();
			this.WallRetakeKeyBox = new System.Windows.Forms.TextBox();
			this.ShotgunKeyButton = new System.Windows.Forms.Button();
			this.ShotgunKeyBox = new System.Windows.Forms.TextBox();
			this.WallButtonLabel = new System.Windows.Forms.Label();
			this.WallKeyButton = new System.Windows.Forms.Button();
			this.WallKeyBox = new System.Windows.Forms.TextBox();
			this.FloorButtonLabel = new System.Windows.Forms.Label();
			this.FloorKeyButton = new System.Windows.Forms.Button();
			this.FloorKeyBox = new System.Windows.Forms.TextBox();
			this.StairButtonLabel = new System.Windows.Forms.Label();
			this.StairKeyButton = new System.Windows.Forms.Button();
			this.StairKeyBox = new System.Windows.Forms.TextBox();
			this.ConeButtonLabel = new System.Windows.Forms.Label();
			this.ConeKeyButton = new System.Windows.Forms.Button();
			this.ConeKeyBox = new System.Windows.Forms.TextBox();
			this.PickaxeButtonLabel = new System.Windows.Forms.Label();
			this.PickaxeKeyButton = new System.Windows.Forms.Button();
			this.PickaxeKeyBox = new System.Windows.Forms.TextBox();
			this.Weapon1Label = new System.Windows.Forms.Label();
			this.Weapon1KeyButton = new System.Windows.Forms.Button();
			this.Weapon1KeyBox = new System.Windows.Forms.TextBox();
			this.Weapon2Label = new System.Windows.Forms.Label();
			this.Weapon2KeyButton = new System.Windows.Forms.Button();
			this.Weapon2KeyBox = new System.Windows.Forms.TextBox();
			this.Weapon3Label = new System.Windows.Forms.Label();
			this.Weapon3KeyButton = new System.Windows.Forms.Button();
			this.Weapon3KeyBox = new System.Windows.Forms.TextBox();
			this.Weapon4Label = new System.Windows.Forms.Label();
			this.Weapon4KeyButton = new System.Windows.Forms.Button();
			this.Weapon4KeyBox = new System.Windows.Forms.TextBox();
			this.Weapon5Label = new System.Windows.Forms.Label();
			this.Weapon5KeyButton = new System.Windows.Forms.Button();
			this.Weapon5KeyBox = new System.Windows.Forms.TextBox();
			this.DoorShotButton = new System.Windows.Forms.Button();
			this.DoorShotKeyBox = new System.Windows.Forms.TextBox();
			this.RealCrouchKeyButton = new System.Windows.Forms.Button();
			this.RealCrouchKeyBox = new System.Windows.Forms.TextBox();
			this.FakeCrouchKeyButton = new System.Windows.Forms.Button();
			this.FakeCrouchKeyBox = new System.Windows.Forms.TextBox();
			this.UseKeyLabel = new System.Windows.Forms.Label();
			this.UseKeyButton = new System.Windows.Forms.Button();
			this.UseKeyBox = new System.Windows.Forms.TextBox();
			this.FormTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// FakeEditKeyBox
			// 
			this.FakeEditKeyBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.FakeEditKeyBox.Location = new System.Drawing.Point(113, 6);
			this.FakeEditKeyBox.Name = "FakeEditKeyBox";
			this.FakeEditKeyBox.ReadOnly = true;
			this.FakeEditKeyBox.Size = new System.Drawing.Size(100, 20);
			this.FakeEditKeyBox.TabIndex = 0;
			this.FakeEditKeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FakeEditKeyButton
			// 
			this.FakeEditKeyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FakeEditKeyButton.Location = new System.Drawing.Point(219, 6);
			this.FakeEditKeyButton.Name = "FakeEditKeyButton";
			this.FakeEditKeyButton.Size = new System.Drawing.Size(75, 21);
			this.FakeEditKeyButton.TabIndex = 1;
			this.FakeEditKeyButton.Text = "Change";
			this.FakeEditKeyButton.UseVisualStyleBackColor = true;
			// 
			// FakeEditKeyLabel
			// 
			this.FakeEditKeyLabel.AutoSize = true;
			this.FakeEditKeyLabel.Location = new System.Drawing.Point(21, 9);
			this.FakeEditKeyLabel.Name = "FakeEditKeyLabel";
			this.FakeEditKeyLabel.Size = new System.Drawing.Size(86, 13);
			this.FakeEditKeyLabel.TabIndex = 2;
			this.FakeEditKeyLabel.Text = "Fake edit key (?)";
			this.FormTooltip.SetToolTip(this.FakeEditKeyLabel, "The button you physically press to start an edit.");
			// 
			// RealEditKeyLabel
			// 
			this.RealEditKeyLabel.AutoSize = true;
			this.RealEditKeyLabel.Location = new System.Drawing.Point(23, 36);
			this.RealEditKeyLabel.Name = "RealEditKeyLabel";
			this.RealEditKeyLabel.Size = new System.Drawing.Size(84, 13);
			this.RealEditKeyLabel.TabIndex = 5;
			this.RealEditKeyLabel.Text = "Real edit key (?)";
			this.FormTooltip.SetToolTip(this.RealEditKeyLabel, "The button that is actually bound to edit structures in your game settings.");
			// 
			// WallRetakeKeyLabel
			// 
			this.WallRetakeKeyLabel.AutoSize = true;
			this.WallRetakeKeyLabel.Location = new System.Drawing.Point(11, 141);
			this.WallRetakeKeyLabel.Name = "WallRetakeKeyLabel";
			this.WallRetakeKeyLabel.Size = new System.Drawing.Size(96, 13);
			this.WallRetakeKeyLabel.TabIndex = 8;
			this.WallRetakeKeyLabel.Text = "Wall retake key (?)";
			this.FormTooltip.SetToolTip(this.WallRetakeKeyLabel, "This button is used to replace an enemy\'s wall by attacking it and quickly replac" +
        "ing it. Good with any hitscan weapons that do a lot of structure damage per bull" +
        "et.");
			// 
			// ShotgunKeyLabel
			// 
			this.ShotgunKeyLabel.AutoSize = true;
			this.ShotgunKeyLabel.Location = new System.Drawing.Point(25, 193);
			this.ShotgunKeyLabel.Name = "ShotgunKeyLabel";
			this.ShotgunKeyLabel.Size = new System.Drawing.Size(82, 13);
			this.ShotgunKeyLabel.TabIndex = 11;
			this.ShotgunKeyLabel.Text = "Shotgun key (?)";
			this.FormTooltip.SetToolTip(this.ShotgunKeyLabel, "The macro will press this button when you finish editing a structure.");
			// 
			// DoorShotLabel
			// 
			this.DoorShotLabel.AutoSize = true;
			this.DoorShotLabel.Location = new System.Drawing.Point(6, 114);
			this.DoorShotLabel.Name = "DoorShotLabel";
			this.DoorShotLabel.Size = new System.Drawing.Size(101, 13);
			this.DoorShotLabel.TabIndex = 50;
			this.DoorShotLabel.Text = "Door shot button (?)";
			this.FormTooltip.SetToolTip(this.DoorShotLabel, "When this button is pressed, the macro will open the door you\'re looking at and s" +
        "hoot immediately.");
			// 
			// RealCrouchKeyLabel
			// 
			this.RealCrouchKeyLabel.AutoSize = true;
			this.RealCrouchKeyLabel.Location = new System.Drawing.Point(7, 87);
			this.RealCrouchKeyLabel.Name = "RealCrouchKeyLabel";
			this.RealCrouchKeyLabel.Size = new System.Drawing.Size(100, 13);
			this.RealCrouchKeyLabel.TabIndex = 47;
			this.RealCrouchKeyLabel.Text = "Real crouch key (?)";
			this.FormTooltip.SetToolTip(this.RealCrouchKeyLabel, "The button that is actually bound to crouch in-game. Make sure you have this set " +
        "for \'Crouch while editing\' and \'Crouch while building\' in the game settings as w" +
        "ell.");
			// 
			// FakeCrouchKeyLabel
			// 
			this.FakeCrouchKeyLabel.AutoSize = true;
			this.FakeCrouchKeyLabel.Location = new System.Drawing.Point(5, 61);
			this.FakeCrouchKeyLabel.Name = "FakeCrouchKeyLabel";
			this.FakeCrouchKeyLabel.Size = new System.Drawing.Size(102, 13);
			this.FakeCrouchKeyLabel.TabIndex = 44;
			this.FakeCrouchKeyLabel.Text = "Fake crouch key (?)";
			this.FormTooltip.SetToolTip(this.FakeCrouchKeyLabel, "This button is for having Hold to crouch instead of Toggle crouch. This is the bu" +
        "tton you will physically press to crouch.");
			// 
			// RealEditKeyButton
			// 
			this.RealEditKeyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RealEditKeyButton.Location = new System.Drawing.Point(219, 32);
			this.RealEditKeyButton.Name = "RealEditKeyButton";
			this.RealEditKeyButton.Size = new System.Drawing.Size(75, 21);
			this.RealEditKeyButton.TabIndex = 4;
			this.RealEditKeyButton.Text = "Change";
			this.RealEditKeyButton.UseVisualStyleBackColor = true;
			// 
			// RealEditKeyBox
			// 
			this.RealEditKeyBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.RealEditKeyBox.Location = new System.Drawing.Point(113, 32);
			this.RealEditKeyBox.Name = "RealEditKeyBox";
			this.RealEditKeyBox.ReadOnly = true;
			this.RealEditKeyBox.Size = new System.Drawing.Size(100, 20);
			this.RealEditKeyBox.TabIndex = 3;
			this.RealEditKeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// WallRetakeKeyButton
			// 
			this.WallRetakeKeyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WallRetakeKeyButton.Location = new System.Drawing.Point(219, 137);
			this.WallRetakeKeyButton.Name = "WallRetakeKeyButton";
			this.WallRetakeKeyButton.Size = new System.Drawing.Size(75, 21);
			this.WallRetakeKeyButton.TabIndex = 7;
			this.WallRetakeKeyButton.Text = "Change";
			this.WallRetakeKeyButton.UseVisualStyleBackColor = true;
			// 
			// WallRetakeKeyBox
			// 
			this.WallRetakeKeyBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.WallRetakeKeyBox.Location = new System.Drawing.Point(113, 137);
			this.WallRetakeKeyBox.Name = "WallRetakeKeyBox";
			this.WallRetakeKeyBox.ReadOnly = true;
			this.WallRetakeKeyBox.Size = new System.Drawing.Size(100, 20);
			this.WallRetakeKeyBox.TabIndex = 6;
			this.WallRetakeKeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ShotgunKeyButton
			// 
			this.ShotgunKeyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ShotgunKeyButton.Location = new System.Drawing.Point(219, 189);
			this.ShotgunKeyButton.Name = "ShotgunKeyButton";
			this.ShotgunKeyButton.Size = new System.Drawing.Size(75, 21);
			this.ShotgunKeyButton.TabIndex = 10;
			this.ShotgunKeyButton.Text = "Change";
			this.ShotgunKeyButton.UseVisualStyleBackColor = true;
			// 
			// ShotgunKeyBox
			// 
			this.ShotgunKeyBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ShotgunKeyBox.Location = new System.Drawing.Point(113, 189);
			this.ShotgunKeyBox.Name = "ShotgunKeyBox";
			this.ShotgunKeyBox.ReadOnly = true;
			this.ShotgunKeyBox.Size = new System.Drawing.Size(100, 20);
			this.ShotgunKeyBox.TabIndex = 9;
			this.ShotgunKeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// WallButtonLabel
			// 
			this.WallButtonLabel.AutoSize = true;
			this.WallButtonLabel.Location = new System.Drawing.Point(59, 219);
			this.WallButtonLabel.Name = "WallButtonLabel";
			this.WallButtonLabel.Size = new System.Drawing.Size(48, 13);
			this.WallButtonLabel.TabIndex = 14;
			this.WallButtonLabel.Text = "Wall key";
			// 
			// WallKeyButton
			// 
			this.WallKeyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WallKeyButton.Location = new System.Drawing.Point(219, 215);
			this.WallKeyButton.Name = "WallKeyButton";
			this.WallKeyButton.Size = new System.Drawing.Size(75, 21);
			this.WallKeyButton.TabIndex = 13;
			this.WallKeyButton.Text = "Change";
			this.WallKeyButton.UseVisualStyleBackColor = true;
			// 
			// WallKeyBox
			// 
			this.WallKeyBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.WallKeyBox.Location = new System.Drawing.Point(113, 215);
			this.WallKeyBox.Name = "WallKeyBox";
			this.WallKeyBox.ReadOnly = true;
			this.WallKeyBox.Size = new System.Drawing.Size(100, 20);
			this.WallKeyBox.TabIndex = 12;
			this.WallKeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FloorButtonLabel
			// 
			this.FloorButtonLabel.AutoSize = true;
			this.FloorButtonLabel.Location = new System.Drawing.Point(57, 245);
			this.FloorButtonLabel.Name = "FloorButtonLabel";
			this.FloorButtonLabel.Size = new System.Drawing.Size(50, 13);
			this.FloorButtonLabel.TabIndex = 17;
			this.FloorButtonLabel.Text = "Floor key";
			// 
			// FloorKeyButton
			// 
			this.FloorKeyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FloorKeyButton.Location = new System.Drawing.Point(219, 241);
			this.FloorKeyButton.Name = "FloorKeyButton";
			this.FloorKeyButton.Size = new System.Drawing.Size(75, 21);
			this.FloorKeyButton.TabIndex = 16;
			this.FloorKeyButton.Text = "Change";
			this.FloorKeyButton.UseVisualStyleBackColor = true;
			// 
			// FloorKeyBox
			// 
			this.FloorKeyBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.FloorKeyBox.Location = new System.Drawing.Point(113, 241);
			this.FloorKeyBox.Name = "FloorKeyBox";
			this.FloorKeyBox.ReadOnly = true;
			this.FloorKeyBox.Size = new System.Drawing.Size(100, 20);
			this.FloorKeyBox.TabIndex = 15;
			this.FloorKeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// StairButtonLabel
			// 
			this.StairButtonLabel.AutoSize = true;
			this.StairButtonLabel.Location = new System.Drawing.Point(59, 271);
			this.StairButtonLabel.Name = "StairButtonLabel";
			this.StairButtonLabel.Size = new System.Drawing.Size(48, 13);
			this.StairButtonLabel.TabIndex = 20;
			this.StairButtonLabel.Text = "Stair key";
			// 
			// StairKeyButton
			// 
			this.StairKeyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StairKeyButton.Location = new System.Drawing.Point(219, 267);
			this.StairKeyButton.Name = "StairKeyButton";
			this.StairKeyButton.Size = new System.Drawing.Size(75, 21);
			this.StairKeyButton.TabIndex = 19;
			this.StairKeyButton.Text = "Change";
			this.StairKeyButton.UseVisualStyleBackColor = true;
			// 
			// StairKeyBox
			// 
			this.StairKeyBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.StairKeyBox.Location = new System.Drawing.Point(113, 267);
			this.StairKeyBox.Name = "StairKeyBox";
			this.StairKeyBox.ReadOnly = true;
			this.StairKeyBox.Size = new System.Drawing.Size(100, 20);
			this.StairKeyBox.TabIndex = 18;
			this.StairKeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ConeButtonLabel
			// 
			this.ConeButtonLabel.AutoSize = true;
			this.ConeButtonLabel.Location = new System.Drawing.Point(55, 297);
			this.ConeButtonLabel.Name = "ConeButtonLabel";
			this.ConeButtonLabel.Size = new System.Drawing.Size(52, 13);
			this.ConeButtonLabel.TabIndex = 23;
			this.ConeButtonLabel.Text = "Cone key";
			// 
			// ConeKeyButton
			// 
			this.ConeKeyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ConeKeyButton.Location = new System.Drawing.Point(219, 293);
			this.ConeKeyButton.Name = "ConeKeyButton";
			this.ConeKeyButton.Size = new System.Drawing.Size(75, 21);
			this.ConeKeyButton.TabIndex = 22;
			this.ConeKeyButton.Text = "Change";
			this.ConeKeyButton.UseVisualStyleBackColor = true;
			// 
			// ConeKeyBox
			// 
			this.ConeKeyBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ConeKeyBox.Location = new System.Drawing.Point(113, 293);
			this.ConeKeyBox.Name = "ConeKeyBox";
			this.ConeKeyBox.ReadOnly = true;
			this.ConeKeyBox.Size = new System.Drawing.Size(100, 20);
			this.ConeKeyBox.TabIndex = 21;
			this.ConeKeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// PickaxeButtonLabel
			// 
			this.PickaxeButtonLabel.AutoSize = true;
			this.PickaxeButtonLabel.Location = new System.Drawing.Point(42, 322);
			this.PickaxeButtonLabel.Name = "PickaxeButtonLabel";
			this.PickaxeButtonLabel.Size = new System.Drawing.Size(65, 13);
			this.PickaxeButtonLabel.TabIndex = 26;
			this.PickaxeButtonLabel.Text = "Pickaxe key";
			// 
			// PickaxeKeyButton
			// 
			this.PickaxeKeyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PickaxeKeyButton.Location = new System.Drawing.Point(219, 319);
			this.PickaxeKeyButton.Name = "PickaxeKeyButton";
			this.PickaxeKeyButton.Size = new System.Drawing.Size(75, 21);
			this.PickaxeKeyButton.TabIndex = 25;
			this.PickaxeKeyButton.Text = "Change";
			this.PickaxeKeyButton.UseVisualStyleBackColor = true;
			// 
			// PickaxeKeyBox
			// 
			this.PickaxeKeyBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.PickaxeKeyBox.Location = new System.Drawing.Point(113, 319);
			this.PickaxeKeyBox.Name = "PickaxeKeyBox";
			this.PickaxeKeyBox.ReadOnly = true;
			this.PickaxeKeyBox.Size = new System.Drawing.Size(100, 20);
			this.PickaxeKeyBox.TabIndex = 24;
			this.PickaxeKeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Weapon1Label
			// 
			this.Weapon1Label.AutoSize = true;
			this.Weapon1Label.Location = new System.Drawing.Point(30, 348);
			this.Weapon1Label.Name = "Weapon1Label";
			this.Weapon1Label.Size = new System.Drawing.Size(77, 13);
			this.Weapon1Label.TabIndex = 29;
			this.Weapon1Label.Text = "Weapon 1 key";
			// 
			// Weapon1KeyButton
			// 
			this.Weapon1KeyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Weapon1KeyButton.Location = new System.Drawing.Point(219, 345);
			this.Weapon1KeyButton.Name = "Weapon1KeyButton";
			this.Weapon1KeyButton.Size = new System.Drawing.Size(75, 21);
			this.Weapon1KeyButton.TabIndex = 28;
			this.Weapon1KeyButton.Text = "Change";
			this.Weapon1KeyButton.UseVisualStyleBackColor = true;
			// 
			// Weapon1KeyBox
			// 
			this.Weapon1KeyBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Weapon1KeyBox.Location = new System.Drawing.Point(113, 345);
			this.Weapon1KeyBox.Name = "Weapon1KeyBox";
			this.Weapon1KeyBox.ReadOnly = true;
			this.Weapon1KeyBox.Size = new System.Drawing.Size(100, 20);
			this.Weapon1KeyBox.TabIndex = 27;
			this.Weapon1KeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Weapon2Label
			// 
			this.Weapon2Label.AutoSize = true;
			this.Weapon2Label.Location = new System.Drawing.Point(30, 375);
			this.Weapon2Label.Name = "Weapon2Label";
			this.Weapon2Label.Size = new System.Drawing.Size(77, 13);
			this.Weapon2Label.TabIndex = 32;
			this.Weapon2Label.Text = "Weapon 2 key";
			// 
			// Weapon2KeyButton
			// 
			this.Weapon2KeyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Weapon2KeyButton.Location = new System.Drawing.Point(219, 371);
			this.Weapon2KeyButton.Name = "Weapon2KeyButton";
			this.Weapon2KeyButton.Size = new System.Drawing.Size(75, 21);
			this.Weapon2KeyButton.TabIndex = 31;
			this.Weapon2KeyButton.Text = "Change";
			this.Weapon2KeyButton.UseVisualStyleBackColor = true;
			// 
			// Weapon2KeyBox
			// 
			this.Weapon2KeyBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Weapon2KeyBox.Location = new System.Drawing.Point(113, 371);
			this.Weapon2KeyBox.Name = "Weapon2KeyBox";
			this.Weapon2KeyBox.ReadOnly = true;
			this.Weapon2KeyBox.Size = new System.Drawing.Size(100, 20);
			this.Weapon2KeyBox.TabIndex = 30;
			this.Weapon2KeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Weapon3Label
			// 
			this.Weapon3Label.AutoSize = true;
			this.Weapon3Label.Location = new System.Drawing.Point(30, 401);
			this.Weapon3Label.Name = "Weapon3Label";
			this.Weapon3Label.Size = new System.Drawing.Size(77, 13);
			this.Weapon3Label.TabIndex = 35;
			this.Weapon3Label.Text = "Weapon 3 key";
			// 
			// Weapon3KeyButton
			// 
			this.Weapon3KeyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Weapon3KeyButton.Location = new System.Drawing.Point(219, 397);
			this.Weapon3KeyButton.Name = "Weapon3KeyButton";
			this.Weapon3KeyButton.Size = new System.Drawing.Size(75, 21);
			this.Weapon3KeyButton.TabIndex = 34;
			this.Weapon3KeyButton.Text = "Change";
			this.Weapon3KeyButton.UseVisualStyleBackColor = true;
			// 
			// Weapon3KeyBox
			// 
			this.Weapon3KeyBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Weapon3KeyBox.Location = new System.Drawing.Point(113, 397);
			this.Weapon3KeyBox.Name = "Weapon3KeyBox";
			this.Weapon3KeyBox.ReadOnly = true;
			this.Weapon3KeyBox.Size = new System.Drawing.Size(100, 20);
			this.Weapon3KeyBox.TabIndex = 33;
			this.Weapon3KeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Weapon4Label
			// 
			this.Weapon4Label.AutoSize = true;
			this.Weapon4Label.Location = new System.Drawing.Point(30, 427);
			this.Weapon4Label.Name = "Weapon4Label";
			this.Weapon4Label.Size = new System.Drawing.Size(77, 13);
			this.Weapon4Label.TabIndex = 38;
			this.Weapon4Label.Text = "Weapon 4 key";
			// 
			// Weapon4KeyButton
			// 
			this.Weapon4KeyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Weapon4KeyButton.Location = new System.Drawing.Point(219, 423);
			this.Weapon4KeyButton.Name = "Weapon4KeyButton";
			this.Weapon4KeyButton.Size = new System.Drawing.Size(75, 21);
			this.Weapon4KeyButton.TabIndex = 37;
			this.Weapon4KeyButton.Text = "Change";
			this.Weapon4KeyButton.UseVisualStyleBackColor = true;
			// 
			// Weapon4KeyBox
			// 
			this.Weapon4KeyBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Weapon4KeyBox.Location = new System.Drawing.Point(113, 423);
			this.Weapon4KeyBox.Name = "Weapon4KeyBox";
			this.Weapon4KeyBox.ReadOnly = true;
			this.Weapon4KeyBox.Size = new System.Drawing.Size(100, 20);
			this.Weapon4KeyBox.TabIndex = 36;
			this.Weapon4KeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Weapon5Label
			// 
			this.Weapon5Label.AutoSize = true;
			this.Weapon5Label.Location = new System.Drawing.Point(30, 453);
			this.Weapon5Label.Name = "Weapon5Label";
			this.Weapon5Label.Size = new System.Drawing.Size(77, 13);
			this.Weapon5Label.TabIndex = 41;
			this.Weapon5Label.Text = "Weapon 5 key";
			// 
			// Weapon5KeyButton
			// 
			this.Weapon5KeyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Weapon5KeyButton.Location = new System.Drawing.Point(219, 449);
			this.Weapon5KeyButton.Name = "Weapon5KeyButton";
			this.Weapon5KeyButton.Size = new System.Drawing.Size(75, 21);
			this.Weapon5KeyButton.TabIndex = 40;
			this.Weapon5KeyButton.Text = "Change";
			this.Weapon5KeyButton.UseVisualStyleBackColor = true;
			// 
			// Weapon5KeyBox
			// 
			this.Weapon5KeyBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Weapon5KeyBox.Location = new System.Drawing.Point(113, 449);
			this.Weapon5KeyBox.Name = "Weapon5KeyBox";
			this.Weapon5KeyBox.ReadOnly = true;
			this.Weapon5KeyBox.Size = new System.Drawing.Size(100, 20);
			this.Weapon5KeyBox.TabIndex = 39;
			this.Weapon5KeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// DoorShotButton
			// 
			this.DoorShotButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DoorShotButton.Location = new System.Drawing.Point(219, 110);
			this.DoorShotButton.Name = "DoorShotButton";
			this.DoorShotButton.Size = new System.Drawing.Size(75, 21);
			this.DoorShotButton.TabIndex = 49;
			this.DoorShotButton.Text = "Change";
			this.DoorShotButton.UseVisualStyleBackColor = true;
			// 
			// DoorShotKeyBox
			// 
			this.DoorShotKeyBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.DoorShotKeyBox.Location = new System.Drawing.Point(113, 110);
			this.DoorShotKeyBox.Name = "DoorShotKeyBox";
			this.DoorShotKeyBox.ReadOnly = true;
			this.DoorShotKeyBox.Size = new System.Drawing.Size(100, 20);
			this.DoorShotKeyBox.TabIndex = 48;
			this.DoorShotKeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// RealCrouchKeyButton
			// 
			this.RealCrouchKeyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RealCrouchKeyButton.Location = new System.Drawing.Point(219, 84);
			this.RealCrouchKeyButton.Name = "RealCrouchKeyButton";
			this.RealCrouchKeyButton.Size = new System.Drawing.Size(75, 21);
			this.RealCrouchKeyButton.TabIndex = 46;
			this.RealCrouchKeyButton.Text = "Change";
			this.RealCrouchKeyButton.UseVisualStyleBackColor = true;
			// 
			// RealCrouchKeyBox
			// 
			this.RealCrouchKeyBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.RealCrouchKeyBox.Location = new System.Drawing.Point(113, 84);
			this.RealCrouchKeyBox.Name = "RealCrouchKeyBox";
			this.RealCrouchKeyBox.ReadOnly = true;
			this.RealCrouchKeyBox.Size = new System.Drawing.Size(100, 20);
			this.RealCrouchKeyBox.TabIndex = 45;
			this.RealCrouchKeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FakeCrouchKeyButton
			// 
			this.FakeCrouchKeyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FakeCrouchKeyButton.Location = new System.Drawing.Point(219, 58);
			this.FakeCrouchKeyButton.Name = "FakeCrouchKeyButton";
			this.FakeCrouchKeyButton.Size = new System.Drawing.Size(75, 21);
			this.FakeCrouchKeyButton.TabIndex = 43;
			this.FakeCrouchKeyButton.Text = "Change";
			this.FakeCrouchKeyButton.UseVisualStyleBackColor = true;
			// 
			// FakeCrouchKeyBox
			// 
			this.FakeCrouchKeyBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.FakeCrouchKeyBox.Location = new System.Drawing.Point(113, 58);
			this.FakeCrouchKeyBox.Name = "FakeCrouchKeyBox";
			this.FakeCrouchKeyBox.ReadOnly = true;
			this.FakeCrouchKeyBox.Size = new System.Drawing.Size(100, 20);
			this.FakeCrouchKeyBox.TabIndex = 42;
			this.FakeCrouchKeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// UseKeyLabel
			// 
			this.UseKeyLabel.AutoSize = true;
			this.UseKeyLabel.Location = new System.Drawing.Point(61, 167);
			this.UseKeyLabel.Name = "UseKeyLabel";
			this.UseKeyLabel.Size = new System.Drawing.Size(46, 13);
			this.UseKeyLabel.TabIndex = 53;
			this.UseKeyLabel.Text = "Use key";
			// 
			// UseKeyButton
			// 
			this.UseKeyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UseKeyButton.Location = new System.Drawing.Point(219, 163);
			this.UseKeyButton.Name = "UseKeyButton";
			this.UseKeyButton.Size = new System.Drawing.Size(75, 21);
			this.UseKeyButton.TabIndex = 52;
			this.UseKeyButton.Text = "Change";
			this.UseKeyButton.UseVisualStyleBackColor = true;
			// 
			// UseKeyBox
			// 
			this.UseKeyBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.UseKeyBox.Location = new System.Drawing.Point(113, 163);
			this.UseKeyBox.Name = "UseKeyBox";
			this.UseKeyBox.ReadOnly = true;
			this.UseKeyBox.Size = new System.Drawing.Size(100, 20);
			this.UseKeyBox.TabIndex = 51;
			this.UseKeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FormTooltip
			// 
			this.FormTooltip.IsBalloon = true;
			this.FormTooltip.ShowAlways = true;
			this.FormTooltip.StripAmpersands = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(304, 474);
			this.Controls.Add(this.UseKeyLabel);
			this.Controls.Add(this.UseKeyButton);
			this.Controls.Add(this.UseKeyBox);
			this.Controls.Add(this.DoorShotLabel);
			this.Controls.Add(this.DoorShotButton);
			this.Controls.Add(this.DoorShotKeyBox);
			this.Controls.Add(this.RealCrouchKeyLabel);
			this.Controls.Add(this.RealCrouchKeyButton);
			this.Controls.Add(this.RealCrouchKeyBox);
			this.Controls.Add(this.FakeCrouchKeyLabel);
			this.Controls.Add(this.FakeCrouchKeyButton);
			this.Controls.Add(this.FakeCrouchKeyBox);
			this.Controls.Add(this.Weapon5Label);
			this.Controls.Add(this.Weapon5KeyButton);
			this.Controls.Add(this.Weapon5KeyBox);
			this.Controls.Add(this.Weapon4Label);
			this.Controls.Add(this.Weapon4KeyButton);
			this.Controls.Add(this.Weapon4KeyBox);
			this.Controls.Add(this.Weapon3Label);
			this.Controls.Add(this.Weapon3KeyButton);
			this.Controls.Add(this.Weapon3KeyBox);
			this.Controls.Add(this.Weapon2Label);
			this.Controls.Add(this.Weapon2KeyButton);
			this.Controls.Add(this.Weapon2KeyBox);
			this.Controls.Add(this.Weapon1Label);
			this.Controls.Add(this.Weapon1KeyButton);
			this.Controls.Add(this.Weapon1KeyBox);
			this.Controls.Add(this.PickaxeButtonLabel);
			this.Controls.Add(this.PickaxeKeyButton);
			this.Controls.Add(this.PickaxeKeyBox);
			this.Controls.Add(this.ConeButtonLabel);
			this.Controls.Add(this.ConeKeyButton);
			this.Controls.Add(this.ConeKeyBox);
			this.Controls.Add(this.StairButtonLabel);
			this.Controls.Add(this.StairKeyButton);
			this.Controls.Add(this.StairKeyBox);
			this.Controls.Add(this.FloorButtonLabel);
			this.Controls.Add(this.FloorKeyButton);
			this.Controls.Add(this.FloorKeyBox);
			this.Controls.Add(this.WallButtonLabel);
			this.Controls.Add(this.WallKeyButton);
			this.Controls.Add(this.WallKeyBox);
			this.Controls.Add(this.ShotgunKeyLabel);
			this.Controls.Add(this.ShotgunKeyButton);
			this.Controls.Add(this.ShotgunKeyBox);
			this.Controls.Add(this.WallRetakeKeyLabel);
			this.Controls.Add(this.WallRetakeKeyButton);
			this.Controls.Add(this.WallRetakeKeyBox);
			this.Controls.Add(this.RealEditKeyLabel);
			this.Controls.Add(this.RealEditKeyButton);
			this.Controls.Add(this.RealEditKeyBox);
			this.Controls.Add(this.FakeEditKeyLabel);
			this.Controls.Add(this.FakeEditKeyButton);
			this.Controls.Add(this.FakeEditKeyBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(320, 513);
			this.MinimumSize = new System.Drawing.Size(320, 513);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox FakeEditKeyBox;
		private System.Windows.Forms.Button FakeEditKeyButton;
		private System.Windows.Forms.Label FakeEditKeyLabel;
		private System.Windows.Forms.Label RealEditKeyLabel;
		private System.Windows.Forms.Button RealEditKeyButton;
		public System.Windows.Forms.TextBox RealEditKeyBox;
		private System.Windows.Forms.Label WallRetakeKeyLabel;
		private System.Windows.Forms.Button WallRetakeKeyButton;
		public System.Windows.Forms.TextBox WallRetakeKeyBox;
		private System.Windows.Forms.Label ShotgunKeyLabel;
		private System.Windows.Forms.Button ShotgunKeyButton;
		public System.Windows.Forms.TextBox ShotgunKeyBox;
		private System.Windows.Forms.Label WallButtonLabel;
		private System.Windows.Forms.Button WallKeyButton;
		public System.Windows.Forms.TextBox WallKeyBox;
		private System.Windows.Forms.Label FloorButtonLabel;
		private System.Windows.Forms.Button FloorKeyButton;
		public System.Windows.Forms.TextBox FloorKeyBox;
		private System.Windows.Forms.Label StairButtonLabel;
		private System.Windows.Forms.Button StairKeyButton;
		public System.Windows.Forms.TextBox StairKeyBox;
		private System.Windows.Forms.Label ConeButtonLabel;
		private System.Windows.Forms.Button ConeKeyButton;
		public System.Windows.Forms.TextBox ConeKeyBox;
		private System.Windows.Forms.Label PickaxeButtonLabel;
		private System.Windows.Forms.Button PickaxeKeyButton;
		public System.Windows.Forms.TextBox PickaxeKeyBox;
		private System.Windows.Forms.Label Weapon1Label;
		private System.Windows.Forms.Button Weapon1KeyButton;
		public System.Windows.Forms.TextBox Weapon1KeyBox;
		private System.Windows.Forms.Label Weapon2Label;
		private System.Windows.Forms.Button Weapon2KeyButton;
		public System.Windows.Forms.TextBox Weapon2KeyBox;
		private System.Windows.Forms.Label Weapon3Label;
		private System.Windows.Forms.Button Weapon3KeyButton;
		public System.Windows.Forms.TextBox Weapon3KeyBox;
		private System.Windows.Forms.Label Weapon4Label;
		private System.Windows.Forms.Button Weapon4KeyButton;
		public System.Windows.Forms.TextBox Weapon4KeyBox;
		private System.Windows.Forms.Label Weapon5Label;
		private System.Windows.Forms.Button Weapon5KeyButton;
		public System.Windows.Forms.TextBox Weapon5KeyBox;
		private System.Windows.Forms.Label DoorShotLabel;
		private System.Windows.Forms.Button DoorShotButton;
		public System.Windows.Forms.TextBox DoorShotKeyBox;
		private System.Windows.Forms.Label RealCrouchKeyLabel;
		private System.Windows.Forms.Button RealCrouchKeyButton;
		public System.Windows.Forms.TextBox RealCrouchKeyBox;
		private System.Windows.Forms.Label FakeCrouchKeyLabel;
		private System.Windows.Forms.Button FakeCrouchKeyButton;
		public System.Windows.Forms.TextBox FakeCrouchKeyBox;
		private System.Windows.Forms.Label UseKeyLabel;
		private System.Windows.Forms.Button UseKeyButton;
		public System.Windows.Forms.TextBox UseKeyBox;
		private System.Windows.Forms.ToolTip FormTooltip;
	}
}


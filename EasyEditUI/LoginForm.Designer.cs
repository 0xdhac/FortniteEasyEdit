namespace EasyEditUI
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.LoginButton = new System.Windows.Forms.Button();
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.UsernameTextbox = new System.Windows.Forms.TextBox();
			this.PasswordTextbox = new System.Windows.Forms.TextBox();
			this.AuthorLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// LoginButton
			// 
			this.LoginButton.Location = new System.Drawing.Point(87, 81);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(75, 23);
			this.LoginButton.TabIndex = 0;
			this.LoginButton.Text = "Login";
			this.LoginButton.UseVisualStyleBackColor = true;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.AutoSize = true;
			this.UsernameLabel.Location = new System.Drawing.Point(45, 32);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
			this.UsernameLabel.TabIndex = 1;
			this.UsernameLabel.Text = "Username";
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Location = new System.Drawing.Point(47, 58);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
			this.PasswordLabel.TabIndex = 2;
			this.PasswordLabel.Text = "Password";
			// 
			// UsernameTextbox
			// 
			this.UsernameTextbox.Location = new System.Drawing.Point(105, 29);
			this.UsernameTextbox.Name = "UsernameTextbox";
			this.UsernameTextbox.Size = new System.Drawing.Size(100, 20);
			this.UsernameTextbox.TabIndex = 3;
			// 
			// PasswordTextbox
			// 
			this.PasswordTextbox.Location = new System.Drawing.Point(105, 55);
			this.PasswordTextbox.Name = "PasswordTextbox";
			this.PasswordTextbox.PasswordChar = '•';
			this.PasswordTextbox.Size = new System.Drawing.Size(100, 20);
			this.PasswordTextbox.TabIndex = 4;
			this.PasswordTextbox.UseSystemPasswordChar = true;
			// 
			// AuthorLabel
			// 
			this.AuthorLabel.AutoSize = true;
			this.AuthorLabel.Location = new System.Drawing.Point(45, 107);
			this.AuthorLabel.Name = "AuthorLabel";
			this.AuthorLabel.Size = new System.Drawing.Size(165, 13);
			this.AuthorLabel.TabIndex = 5;
			this.AuthorLabel.Text = "Created by 0xD#0057 on Discord";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(250, 154);
			this.Controls.Add(this.AuthorLabel);
			this.Controls.Add(this.PasswordTextbox);
			this.Controls.Add(this.UsernameTextbox);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.UsernameLabel);
			this.Controls.Add(this.LoginButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.Label UsernameLabel;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.TextBox UsernameTextbox;
		private System.Windows.Forms.TextBox PasswordTextbox;
		private System.Windows.Forms.Label AuthorLabel;
	}
}
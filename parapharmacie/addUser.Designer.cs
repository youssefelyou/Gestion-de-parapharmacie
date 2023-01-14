namespace parapharmacie
{
    partial class addUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addUser));
            this.label1 = new System.Windows.Forms.Label();
            this.role = new Guna.UI2.WinForms.Guna2ComboBox();
            this.passtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.agetxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.NomTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ajouter Utilisateur";
            // 
            // role
            // 
            this.role.BackColor = System.Drawing.Color.Transparent;
            this.role.BorderColor = System.Drawing.Color.Black;
            this.role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.role.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.role.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.role.ItemHeight = 30;
            this.role.Items.AddRange(new object[] {
            "ADMIN",
            "USER"});
            this.role.Location = new System.Drawing.Point(323, 139);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(174, 36);
            this.role.TabIndex = 25;
            // 
            // passtxt
            // 
            this.passtxt.BorderColor = System.Drawing.Color.Black;
            this.passtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passtxt.DefaultText = "";
            this.passtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.passtxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.ForeColor = System.Drawing.Color.Black;
            this.passtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.passtxt.Location = new System.Drawing.Point(323, 75);
            this.passtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '●';
            this.passtxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.passtxt.PlaceholderText = "password";
            this.passtxt.SelectedText = "";
            this.passtxt.Size = new System.Drawing.Size(174, 33);
            this.passtxt.TabIndex = 24;
            this.passtxt.UseSystemPasswordChar = true;
            // 
            // agetxt
            // 
            this.agetxt.BorderColor = System.Drawing.Color.Black;
            this.agetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.agetxt.DefaultText = "";
            this.agetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.agetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.agetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.agetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.agetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.agetxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agetxt.ForeColor = System.Drawing.Color.Black;
            this.agetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.agetxt.Location = new System.Drawing.Point(45, 207);
            this.agetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agetxt.Name = "agetxt";
            this.agetxt.PasswordChar = '\0';
            this.agetxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.agetxt.PlaceholderText = "age";
            this.agetxt.SelectedText = "";
            this.agetxt.Size = new System.Drawing.Size(174, 33);
            this.agetxt.TabIndex = 23;
            // 
            // usernametxt
            // 
            this.usernametxt.BorderColor = System.Drawing.Color.Black;
            this.usernametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernametxt.DefaultText = "";
            this.usernametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.usernametxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.ForeColor = System.Drawing.Color.Black;
            this.usernametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.usernametxt.Location = new System.Drawing.Point(45, 142);
            this.usernametxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.PasswordChar = '\0';
            this.usernametxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.usernametxt.PlaceholderText = "username";
            this.usernametxt.SelectedText = "";
            this.usernametxt.Size = new System.Drawing.Size(174, 33);
            this.usernametxt.TabIndex = 22;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(342, 207);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(128, 33);
            this.guna2Button1.TabIndex = 21;
            this.guna2Button1.Text = "Ajouter";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // NomTxt
            // 
            this.NomTxt.BorderColor = System.Drawing.Color.Black;
            this.NomTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NomTxt.DefaultText = "";
            this.NomTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NomTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NomTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NomTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NomTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.NomTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomTxt.ForeColor = System.Drawing.Color.Black;
            this.NomTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.NomTxt.Location = new System.Drawing.Point(45, 75);
            this.NomTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NomTxt.Name = "NomTxt";
            this.NomTxt.PasswordChar = '\0';
            this.NomTxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.NomTxt.PlaceholderText = "Nom Complet";
            this.NomTxt.SelectedText = "";
            this.NomTxt.Size = new System.Drawing.Size(174, 33);
            this.NomTxt.TabIndex = 20;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(588, 3);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 26;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.Click += new System.EventHandler(this.guna2PictureBox3_Click);
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 315);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.role);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.agetxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.NomTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addUser";
            this.Text = "addUser";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox role;
        private Guna.UI2.WinForms.Guna2TextBox passtxt;
        private Guna.UI2.WinForms.Guna2TextBox agetxt;
        private Guna.UI2.WinForms.Guna2TextBox usernametxt;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox NomTxt;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
    }
}
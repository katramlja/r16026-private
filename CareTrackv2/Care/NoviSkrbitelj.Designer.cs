namespace Care
{
    partial class NoviSkrbitelj
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NazivLozinka = new System.Windows.Forms.Label();
            this.UnosLozinka = new System.Windows.Forms.TextBox();
            this.NazivKorisnickoIme = new System.Windows.Forms.Label();
            this.UnosKorisnickoIme = new System.Windows.Forms.TextBox();
            this.Obriši = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Admin = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Spremi = new System.Windows.Forms.Button();
            this.Izlaz = new System.Windows.Forms.Button();
            this.OIB = new System.Windows.Forms.Label();
            this.UnosOIB = new System.Windows.Forms.TextBox();
            this.NazivPrezime = new System.Windows.Forms.Label();
            this.UnosPrezime = new System.Windows.Forms.TextBox();
            this.NazivIme = new System.Windows.Forms.Label();
            this.UnosIme = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NazivLozinka);
            this.groupBox1.Controls.Add(this.UnosLozinka);
            this.groupBox1.Controls.Add(this.NazivKorisnickoIme);
            this.groupBox1.Controls.Add(this.UnosKorisnickoIme);
            this.groupBox1.Controls.Add(this.Obriši);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.Spremi);
            this.groupBox1.Controls.Add(this.Izlaz);
            this.groupBox1.Controls.Add(this.OIB);
            this.groupBox1.Controls.Add(this.UnosOIB);
            this.groupBox1.Controls.Add(this.NazivPrezime);
            this.groupBox1.Controls.Add(this.UnosPrezime);
            this.groupBox1.Controls.Add(this.NazivIme);
            this.groupBox1.Controls.Add(this.UnosIme);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 362);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osobni podaci";
            // 
            // NazivLozinka
            // 
            this.NazivLozinka.AutoSize = true;
            this.NazivLozinka.BackColor = System.Drawing.SystemColors.Window;
            this.NazivLozinka.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NazivLozinka.Location = new System.Drawing.Point(22, 228);
            this.NazivLozinka.Name = "NazivLozinka";
            this.NazivLozinka.Size = new System.Drawing.Size(60, 18);
            this.NazivLozinka.TabIndex = 53;
            this.NazivLozinka.Text = "Lozinka";
            this.NazivLozinka.Click += new System.EventHandler(this.NazivLozinka_Click);
            // 
            // UnosLozinka
            // 
            this.UnosLozinka.Location = new System.Drawing.Point(16, 225);
            this.UnosLozinka.MaxLength = 11;
            this.UnosLozinka.Name = "UnosLozinka";
            this.UnosLozinka.Size = new System.Drawing.Size(259, 24);
            this.UnosLozinka.TabIndex = 52;
            this.UnosLozinka.TextChanged += new System.EventHandler(this.UnosLozinka_TextChanged);
            // 
            // NazivKorisnickoIme
            // 
            this.NazivKorisnickoIme.AutoSize = true;
            this.NazivKorisnickoIme.BackColor = System.Drawing.SystemColors.Window;
            this.NazivKorisnickoIme.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NazivKorisnickoIme.Location = new System.Drawing.Point(22, 190);
            this.NazivKorisnickoIme.Name = "NazivKorisnickoIme";
            this.NazivKorisnickoIme.Size = new System.Drawing.Size(107, 18);
            this.NazivKorisnickoIme.TabIndex = 51;
            this.NazivKorisnickoIme.Text = "Korisničko ime";
            this.NazivKorisnickoIme.Click += new System.EventHandler(this.NazivKorisnickoIme_Click);
            // 
            // UnosKorisnickoIme
            // 
            this.UnosKorisnickoIme.Location = new System.Drawing.Point(16, 187);
            this.UnosKorisnickoIme.MaxLength = 11;
            this.UnosKorisnickoIme.Name = "UnosKorisnickoIme";
            this.UnosKorisnickoIme.Size = new System.Drawing.Size(259, 24);
            this.UnosKorisnickoIme.TabIndex = 50;
            this.UnosKorisnickoIme.TextChanged += new System.EventHandler(this.UnosKorisnickoIme_TextChanged);
            // 
            // Obriši
            // 
            this.Obriši.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Obriši.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Obriši.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Obriši.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Obriši.Location = new System.Drawing.Point(16, 306);
            this.Obriši.Name = "Obriši";
            this.Obriši.Size = new System.Drawing.Size(122, 45);
            this.Obriši.TabIndex = 37;
            this.Obriši.Text = "Obriši";
            this.Obriši.UseVisualStyleBackColor = false;
            this.Obriši.Click += new System.EventHandler(this.Obriši_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Admin);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(16, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 28);
            this.panel1.TabIndex = 11;
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.BackColor = System.Drawing.SystemColors.Window;
            this.Admin.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Admin.Location = new System.Drawing.Point(3, 2);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(95, 18);
            this.Admin.TabIndex = 15;
            this.Admin.Text = "Administrator";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.SystemColors.Window;
            this.radioButton1.Location = new System.Drawing.Point(128, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 22);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Da";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.SystemColors.Window;
            this.radioButton2.Location = new System.Drawing.Point(179, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 22);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ne";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // Spremi
            // 
            this.Spremi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Spremi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Spremi.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Spremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Spremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Spremi.Location = new System.Drawing.Point(16, 255);
            this.Spremi.Name = "Spremi";
            this.Spremi.Size = new System.Drawing.Size(259, 45);
            this.Spremi.TabIndex = 36;
            this.Spremi.Text = "Spremi";
            this.Spremi.UseVisualStyleBackColor = false;
            this.Spremi.Click += new System.EventHandler(this.Spremi_Click);
            // 
            // Izlaz
            // 
            this.Izlaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Izlaz.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Izlaz.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Izlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Izlaz.Location = new System.Drawing.Point(144, 306);
            this.Izlaz.Name = "Izlaz";
            this.Izlaz.Size = new System.Drawing.Size(131, 45);
            this.Izlaz.TabIndex = 35;
            this.Izlaz.Text = "Izlaz";
            this.Izlaz.UseVisualStyleBackColor = false;
            this.Izlaz.Click += new System.EventHandler(this.Izlaz_Click);
            // 
            // OIB
            // 
            this.OIB.AutoSize = true;
            this.OIB.BackColor = System.Drawing.SystemColors.Window;
            this.OIB.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.OIB.Location = new System.Drawing.Point(24, 116);
            this.OIB.Name = "OIB";
            this.OIB.Size = new System.Drawing.Size(33, 18);
            this.OIB.TabIndex = 13;
            this.OIB.Text = "OIB";
            this.OIB.Click += new System.EventHandler(this.OIB_Click);
            // 
            // UnosOIB
            // 
            this.UnosOIB.Location = new System.Drawing.Point(16, 113);
            this.UnosOIB.MaxLength = 11;
            this.UnosOIB.Name = "UnosOIB";
            this.UnosOIB.Size = new System.Drawing.Size(259, 24);
            this.UnosOIB.TabIndex = 12;
            this.UnosOIB.Click += new System.EventHandler(this.UnosOIB_Click);
            this.UnosOIB.TextChanged += new System.EventHandler(this.UnosOIB_TextChanged_1);
            this.UnosOIB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnosOIB_KeyPress);
            // 
            // NazivPrezime
            // 
            this.NazivPrezime.AutoSize = true;
            this.NazivPrezime.BackColor = System.Drawing.SystemColors.Window;
            this.NazivPrezime.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NazivPrezime.Location = new System.Drawing.Point(22, 79);
            this.NazivPrezime.Name = "NazivPrezime";
            this.NazivPrezime.Size = new System.Drawing.Size(63, 18);
            this.NazivPrezime.TabIndex = 11;
            this.NazivPrezime.Text = "Prezime";
            this.NazivPrezime.Click += new System.EventHandler(this.NazivPrezime_Click);
            // 
            // UnosPrezime
            // 
            this.UnosPrezime.Location = new System.Drawing.Point(16, 76);
            this.UnosPrezime.Name = "UnosPrezime";
            this.UnosPrezime.Size = new System.Drawing.Size(259, 24);
            this.UnosPrezime.TabIndex = 10;
            this.UnosPrezime.Click += new System.EventHandler(this.UnosPrezime_Click);
            this.UnosPrezime.TextChanged += new System.EventHandler(this.UnosPrezime_TextChanged_1);
            // 
            // NazivIme
            // 
            this.NazivIme.AutoSize = true;
            this.NazivIme.BackColor = System.Drawing.SystemColors.Window;
            this.NazivIme.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NazivIme.Location = new System.Drawing.Point(22, 40);
            this.NazivIme.Name = "NazivIme";
            this.NazivIme.Size = new System.Drawing.Size(32, 18);
            this.NazivIme.TabIndex = 9;
            this.NazivIme.Text = "Ime";
            this.NazivIme.Click += new System.EventHandler(this.NazivIme_Click);
            // 
            // UnosIme
            // 
            this.UnosIme.Location = new System.Drawing.Point(16, 37);
            this.UnosIme.Name = "UnosIme";
            this.UnosIme.Size = new System.Drawing.Size(259, 24);
            this.UnosIme.TabIndex = 0;
            this.UnosIme.Click += new System.EventHandler(this.UnosIme_Click);
            this.UnosIme.TextChanged += new System.EventHandler(this.UnosIme_TextChanged);
            // 
            // NoviSkrbitelj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(321, 386);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NoviSkrbitelj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos skrbitelja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label OIB;
        private System.Windows.Forms.TextBox UnosOIB;
        private System.Windows.Forms.Label NazivPrezime;
        private System.Windows.Forms.TextBox UnosPrezime;
        private System.Windows.Forms.Label NazivIme;
        private System.Windows.Forms.TextBox UnosIme;
        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NazivLozinka;
        private System.Windows.Forms.TextBox UnosLozinka;
        private System.Windows.Forms.Label NazivKorisnickoIme;
        private System.Windows.Forms.TextBox UnosKorisnickoIme;
        private System.Windows.Forms.Button Obriši;
        private System.Windows.Forms.Button Spremi;
        private System.Windows.Forms.Button Izlaz;
    }
}
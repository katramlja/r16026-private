namespace Care
{
    partial class Prijava
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
            this.Lozinka = new System.Windows.Forms.TextBox();
            this.PrijaviSe = new System.Windows.Forms.Button();
            this.Ime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NazivIme = new System.Windows.Forms.Label();
            this.NazivLozinka = new System.Windows.Forms.Label();
            this.Pogreska = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lozinka
            // 
            this.Lozinka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lozinka.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Lozinka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lozinka.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lozinka.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Lozinka.Location = new System.Drawing.Point(153, 159);
            this.Lozinka.MaxLength = 50;
            this.Lozinka.Name = "Lozinka";
            this.Lozinka.Size = new System.Drawing.Size(400, 31);
            this.Lozinka.TabIndex = 2;
            this.Lozinka.UseSystemPasswordChar = true;
            this.Lozinka.WordWrap = false;
            this.Lozinka.TextChanged += new System.EventHandler(this.Lozinka_TextChanged);
            // 
            // PrijaviSe
            // 
            this.PrijaviSe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrijaviSe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PrijaviSe.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PrijaviSe.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.PrijaviSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrijaviSe.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrijaviSe.Location = new System.Drawing.Point(153, 223);
            this.PrijaviSe.Name = "PrijaviSe";
            this.PrijaviSe.Size = new System.Drawing.Size(400, 50);
            this.PrijaviSe.TabIndex = 0;
            this.PrijaviSe.Text = "&Prijavi se";
            this.PrijaviSe.UseVisualStyleBackColor = false;
            this.PrijaviSe.Click += new System.EventHandler(this.PrijaviSe_Click);
            // 
            // Ime
            // 
            this.Ime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ime.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Ime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ime.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Ime.Location = new System.Drawing.Point(153, 122);
            this.Ime.MaxLength = 50;
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(400, 31);
            this.Ime.TabIndex = 1;
            this.Ime.WordWrap = false;
            this.Ime.TextChanged += new System.EventHandler(this.Ime_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(267, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prijava";
            // 
            // NazivIme
            // 
            this.NazivIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NazivIme.AutoSize = true;
            this.NazivIme.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.NazivIme.CausesValidation = false;
            this.NazivIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazivIme.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NazivIme.Location = new System.Drawing.Point(158, 130);
            this.NazivIme.Name = "NazivIme";
            this.NazivIme.Size = new System.Drawing.Size(95, 16);
            this.NazivIme.TabIndex = 4;
            this.NazivIme.Text = "Korisničko ime";
            this.NazivIme.Click += new System.EventHandler(this.ImeLabel_Click);
            // 
            // NazivLozinka
            // 
            this.NazivLozinka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NazivLozinka.AutoSize = true;
            this.NazivLozinka.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.NazivLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazivLozinka.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NazivLozinka.Location = new System.Drawing.Point(158, 167);
            this.NazivLozinka.Name = "NazivLozinka";
            this.NazivLozinka.Size = new System.Drawing.Size(54, 16);
            this.NazivLozinka.TabIndex = 5;
            this.NazivLozinka.Text = "Lozinka";
            this.NazivLozinka.Click += new System.EventHandler(this.LozinkaLabel_Click);
            // 
            // Pogreska
            // 
            this.Pogreska.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pogreska.AutoSize = true;
            this.Pogreska.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pogreska.ForeColor = System.Drawing.Color.Red;
            this.Pogreska.Location = new System.Drawing.Point(247, 197);
            this.Pogreska.Name = "Pogreska";
            this.Pogreska.Size = new System.Drawing.Size(216, 16);
            this.Pogreska.TabIndex = 6;
            this.Pogreska.Text = "Pogrešno korisničko ime ili lozinka!";
            this.Pogreska.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pogreska.Visible = false;
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(704, 378);
            this.Controls.Add(this.Pogreska);
            this.Controls.Add(this.NazivLozinka);
            this.Controls.Add(this.NazivIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.PrijaviSe);
            this.Controls.Add(this.Lozinka);
            this.Name = "Prijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CareTrack";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Lozinka;
        private System.Windows.Forms.Button PrijaviSe;
        private System.Windows.Forms.TextBox Ime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NazivIme;
        private System.Windows.Forms.Label NazivLozinka;
        private System.Windows.Forms.Label Pogreska;
    }
}


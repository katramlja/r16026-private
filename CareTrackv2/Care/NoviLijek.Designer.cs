namespace Care
{
    partial class NoviLijek
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
            this.UnosNazivLijeka = new System.Windows.Forms.TextBox();
            this.NazivNazivLijeka = new System.Windows.Forms.Label();
            this.NazivOpisIPrimjena = new System.Windows.Forms.Label();
            this.UnosOpisPrimjena = new System.Windows.Forms.TextBox();
            this.NazivProizvodac = new System.Windows.Forms.Label();
            this.UnosProizvodac = new System.Windows.Forms.TextBox();
            this.Izlaz = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UnosNazivLijeka
            // 
            this.UnosNazivLijeka.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.UnosNazivLijeka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnosNazivLijeka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UnosNazivLijeka.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UnosNazivLijeka.Location = new System.Drawing.Point(12, 12);
            this.UnosNazivLijeka.MaxLength = 50;
            this.UnosNazivLijeka.Multiline = true;
            this.UnosNazivLijeka.Name = "UnosNazivLijeka";
            this.UnosNazivLijeka.Size = new System.Drawing.Size(389, 80);
            this.UnosNazivLijeka.TabIndex = 8;
            this.UnosNazivLijeka.WordWrap = false;
            this.UnosNazivLijeka.TextChanged += new System.EventHandler(this.UnosNazivLijeka_TextChanged);
            // 
            // NazivNazivLijeka
            // 
            this.NazivNazivLijeka.AutoSize = true;
            this.NazivNazivLijeka.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.NazivNazivLijeka.CausesValidation = false;
            this.NazivNazivLijeka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazivNazivLijeka.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NazivNazivLijeka.Location = new System.Drawing.Point(20, 18);
            this.NazivNazivLijeka.Name = "NazivNazivLijeka";
            this.NazivNazivLijeka.Size = new System.Drawing.Size(77, 16);
            this.NazivNazivLijeka.TabIndex = 9;
            this.NazivNazivLijeka.Text = "Naziv lijeka";
            this.NazivNazivLijeka.Click += new System.EventHandler(this.NazivNazivLijeka_Click);
            // 
            // NazivOpisIPrimjena
            // 
            this.NazivOpisIPrimjena.AutoSize = true;
            this.NazivOpisIPrimjena.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.NazivOpisIPrimjena.CausesValidation = false;
            this.NazivOpisIPrimjena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazivOpisIPrimjena.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NazivOpisIPrimjena.Location = new System.Drawing.Point(20, 104);
            this.NazivOpisIPrimjena.Name = "NazivOpisIPrimjena";
            this.NazivOpisIPrimjena.Size = new System.Drawing.Size(97, 16);
            this.NazivOpisIPrimjena.TabIndex = 11;
            this.NazivOpisIPrimjena.Text = "Opis i primjena";
            this.NazivOpisIPrimjena.Click += new System.EventHandler(this.NazivOpisIPrimjena_Click);
            // 
            // UnosOpisPrimjena
            // 
            this.UnosOpisPrimjena.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.UnosOpisPrimjena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnosOpisPrimjena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UnosOpisPrimjena.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UnosOpisPrimjena.Location = new System.Drawing.Point(12, 98);
            this.UnosOpisPrimjena.MaxLength = 50;
            this.UnosOpisPrimjena.Multiline = true;
            this.UnosOpisPrimjena.Name = "UnosOpisPrimjena";
            this.UnosOpisPrimjena.Size = new System.Drawing.Size(389, 80);
            this.UnosOpisPrimjena.TabIndex = 10;
            this.UnosOpisPrimjena.WordWrap = false;
            this.UnosOpisPrimjena.TextChanged += new System.EventHandler(this.UnosOpisPrimjena_TextChanged);
            // 
            // NazivProizvodac
            // 
            this.NazivProizvodac.AutoSize = true;
            this.NazivProizvodac.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.NazivProizvodac.CausesValidation = false;
            this.NazivProizvodac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazivProizvodac.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NazivProizvodac.Location = new System.Drawing.Point(20, 191);
            this.NazivProizvodac.Name = "NazivProizvodac";
            this.NazivProizvodac.Size = new System.Drawing.Size(76, 16);
            this.NazivProizvodac.TabIndex = 13;
            this.NazivProizvodac.Text = "Proizvođač";
            this.NazivProizvodac.Click += new System.EventHandler(this.NazivProizvodac_Click);
            // 
            // UnosProizvodac
            // 
            this.UnosProizvodac.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.UnosProizvodac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnosProizvodac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UnosProizvodac.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UnosProizvodac.Location = new System.Drawing.Point(12, 185);
            this.UnosProizvodac.MaxLength = 50;
            this.UnosProizvodac.Multiline = true;
            this.UnosProizvodac.Name = "UnosProizvodac";
            this.UnosProizvodac.Size = new System.Drawing.Size(389, 80);
            this.UnosProizvodac.TabIndex = 12;
            this.UnosProizvodac.WordWrap = false;
            this.UnosProizvodac.TextChanged += new System.EventHandler(this.UnosProizvodac_TextChanged);
            // 
            // Izlaz
            // 
            this.Izlaz.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Izlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Izlaz.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Izlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Izlaz.Location = new System.Drawing.Point(12, 271);
            this.Izlaz.Name = "Izlaz";
            this.Izlaz.Size = new System.Drawing.Size(190, 45);
            this.Izlaz.TabIndex = 14;
            this.Izlaz.Text = "Izlaz";
            this.Izlaz.UseVisualStyleBackColor = false;
            this.Izlaz.Click += new System.EventHandler(this.Izlaz_Click);
            // 
            // Dodaj
            // 
            this.Dodaj.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Dodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dodaj.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Dodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dodaj.Location = new System.Drawing.Point(211, 271);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(190, 45);
            this.Dodaj.TabIndex = 15;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = false;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // Lijekovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(415, 333);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.Izlaz);
            this.Controls.Add(this.NazivProizvodac);
            this.Controls.Add(this.UnosProizvodac);
            this.Controls.Add(this.NazivOpisIPrimjena);
            this.Controls.Add(this.UnosOpisPrimjena);
            this.Controls.Add(this.NazivNazivLijeka);
            this.Controls.Add(this.UnosNazivLijeka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Lijekovi";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos novog lijeka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UnosNazivLijeka;
        private System.Windows.Forms.Label NazivNazivLijeka;
        private System.Windows.Forms.Label NazivOpisIPrimjena;
        private System.Windows.Forms.TextBox UnosOpisPrimjena;
        private System.Windows.Forms.Label NazivProizvodac;
        private System.Windows.Forms.TextBox UnosProizvodac;
        private System.Windows.Forms.Button Izlaz;
        private System.Windows.Forms.Button Dodaj;
    }
}
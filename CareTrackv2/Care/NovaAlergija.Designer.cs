namespace Care
{
    partial class NovaAlergija
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
            this.NazivAlergija = new System.Windows.Forms.Label();
            this.UnosAlergija = new System.Windows.Forms.TextBox();
            this.Izlaz = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NazivAlergija
            // 
            this.NazivAlergija.AutoSize = true;
            this.NazivAlergija.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.NazivAlergija.CausesValidation = false;
            this.NazivAlergija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazivAlergija.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NazivAlergija.Location = new System.Drawing.Point(20, 18);
            this.NazivAlergija.Name = "NazivAlergija";
            this.NazivAlergija.Size = new System.Drawing.Size(54, 16);
            this.NazivAlergija.TabIndex = 11;
            this.NazivAlergija.Text = "Alergija";
            this.NazivAlergija.Click += new System.EventHandler(this.NazivAlergija_Click);
            // 
            // UnosAlergija
            // 
            this.UnosAlergija.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.UnosAlergija.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnosAlergija.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UnosAlergija.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UnosAlergija.Location = new System.Drawing.Point(12, 12);
            this.UnosAlergija.MaxLength = 50;
            this.UnosAlergija.Multiline = true;
            this.UnosAlergija.Name = "UnosAlergija";
            this.UnosAlergija.Size = new System.Drawing.Size(386, 80);
            this.UnosAlergija.TabIndex = 10;
            this.UnosAlergija.WordWrap = false;
            this.UnosAlergija.TextChanged += new System.EventHandler(this.UnosAlergije_TextChanged);
            // 
            // Izlaz
            // 
            this.Izlaz.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Izlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Izlaz.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Izlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Izlaz.Location = new System.Drawing.Point(12, 98);
            this.Izlaz.Name = "Izlaz";
            this.Izlaz.Size = new System.Drawing.Size(190, 45);
            this.Izlaz.TabIndex = 15;
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
            this.Dodaj.Location = new System.Drawing.Point(208, 98);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(190, 45);
            this.Dodaj.TabIndex = 16;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = false;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // Alergije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 161);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.Izlaz);
            this.Controls.Add(this.NazivAlergija);
            this.Controls.Add(this.UnosAlergija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Alergije";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos nove alergije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NazivAlergija;
        private System.Windows.Forms.TextBox UnosAlergija;
        private System.Windows.Forms.Button Izlaz;
        private System.Windows.Forms.Button Dodaj;
    }
}
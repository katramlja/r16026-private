namespace Care
{
    partial class NoviOdjel
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
            this.Izlaz = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.Button();
            this.UnosNazivOdjela = new System.Windows.Forms.TextBox();
            this.NazivNazivOdjela = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Izlaz
            // 
            this.Izlaz.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Izlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Izlaz.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Izlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Izlaz.Location = new System.Drawing.Point(146, 116);
            this.Izlaz.Name = "Izlaz";
            this.Izlaz.Size = new System.Drawing.Size(130, 45);
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
            this.Dodaj.Location = new System.Drawing.Point(12, 116);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(128, 45);
            this.Dodaj.TabIndex = 16;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = false;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // UnosNazivOdjela
            // 
            this.UnosNazivOdjela.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.UnosNazivOdjela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnosNazivOdjela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UnosNazivOdjela.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UnosNazivOdjela.Location = new System.Drawing.Point(12, 12);
            this.UnosNazivOdjela.MaxLength = 50;
            this.UnosNazivOdjela.Multiline = true;
            this.UnosNazivOdjela.Name = "UnosNazivOdjela";
            this.UnosNazivOdjela.Size = new System.Drawing.Size(264, 98);
            this.UnosNazivOdjela.TabIndex = 17;
            this.UnosNazivOdjela.WordWrap = false;
            this.UnosNazivOdjela.TextChanged += new System.EventHandler(this.UnosNazivOdjela_TextChanged);
            // 
            // NazivNazivOdjela
            // 
            this.NazivNazivOdjela.AutoSize = true;
            this.NazivNazivOdjela.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.NazivNazivOdjela.CausesValidation = false;
            this.NazivNazivOdjela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazivNazivOdjela.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NazivNazivOdjela.Location = new System.Drawing.Point(21, 16);
            this.NazivNazivOdjela.Name = "NazivNazivOdjela";
            this.NazivNazivOdjela.Size = new System.Drawing.Size(83, 16);
            this.NazivNazivOdjela.TabIndex = 18;
            this.NazivNazivOdjela.Text = "Naziv odjela";
            this.NazivNazivOdjela.Click += new System.EventHandler(this.NazivNazivOdjela_Click);
            // 
            // NoviOdjel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(297, 182);
            this.Controls.Add(this.NazivNazivOdjela);
            this.Controls.Add(this.UnosNazivOdjela);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.Izlaz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NoviOdjel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos novog odjela";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Izlaz;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.TextBox UnosNazivOdjela;
        private System.Windows.Forms.Label NazivNazivOdjela;
    }
}
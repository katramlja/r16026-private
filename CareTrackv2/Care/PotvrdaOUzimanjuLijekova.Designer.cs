namespace Care
{
    partial class PotvrdaOUzimanjuLijekova
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
            this.PotvrdiUnos = new System.Windows.Forms.Button();
            this.Izlaz = new System.Windows.Forms.Button();
            this.ImeSticenika = new System.Windows.Forms.TextBox();
            this.LijekoviSticenika = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PotvrdiUnos
            // 
            this.PotvrdiUnos.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PotvrdiUnos.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.PotvrdiUnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PotvrdiUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PotvrdiUnos.Location = new System.Drawing.Point(12, 204);
            this.PotvrdiUnos.Name = "PotvrdiUnos";
            this.PotvrdiUnos.Size = new System.Drawing.Size(190, 45);
            this.PotvrdiUnos.TabIndex = 1;
            this.PotvrdiUnos.Text = "Potvrdi";
            this.PotvrdiUnos.UseVisualStyleBackColor = false;
            this.PotvrdiUnos.Click += new System.EventHandler(this.PotvrdiUnos_Click);
            // 
            // Izlaz
            // 
            this.Izlaz.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Izlaz.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Izlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Izlaz.Location = new System.Drawing.Point(208, 204);
            this.Izlaz.Name = "Izlaz";
            this.Izlaz.Size = new System.Drawing.Size(190, 45);
            this.Izlaz.TabIndex = 2;
            this.Izlaz.Text = "Izlaz";
            this.Izlaz.UseVisualStyleBackColor = false;
            this.Izlaz.Click += new System.EventHandler(this.button2_Click);
            // 
            // ImeSticenika
            // 
            this.ImeSticenika.Location = new System.Drawing.Point(12, 22);
            this.ImeSticenika.Multiline = true;
            this.ImeSticenika.Name = "ImeSticenika";
            this.ImeSticenika.ReadOnly = true;
            this.ImeSticenika.Size = new System.Drawing.Size(386, 41);
            this.ImeSticenika.TabIndex = 3;
            // 
            // LijekoviSticenika
            // 
            this.LijekoviSticenika.Location = new System.Drawing.Point(80, 78);
            this.LijekoviSticenika.Multiline = true;
            this.LijekoviSticenika.Name = "LijekoviSticenika";
            this.LijekoviSticenika.ReadOnly = true;
            this.LijekoviSticenika.Size = new System.Drawing.Size(238, 110);
            this.LijekoviSticenika.TabIndex = 4;
            // 
            // PotvrdaOUzimanjuLijekova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 261);
            this.Controls.Add(this.LijekoviSticenika);
            this.Controls.Add(this.ImeSticenika);
            this.Controls.Add(this.Izlaz);
            this.Controls.Add(this.PotvrdiUnos);
            this.Name = "PotvrdaOUzimanjuLijekova";
            this.Text = "Potvrda o uzimanju lijekova";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Izlaz;
        private System.Windows.Forms.TextBox ImeSticenika;
        private System.Windows.Forms.Button PotvrdiUnos;
        private System.Windows.Forms.TextBox LijekoviSticenika;
    }
}
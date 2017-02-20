namespace Care
{
    partial class PopisDekubitusaŠtićenika
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
            this.popisSvihDekubitusaŠtićenika = new System.Windows.Forms.DataGridView();
            this.Odaberi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popisSvihDekubitusaŠtićenika)).BeginInit();
            this.SuspendLayout();
            // 
            // popisSvihDekubitusaŠtićenika
            // 
            this.popisSvihDekubitusaŠtićenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popisSvihDekubitusaŠtićenika.Location = new System.Drawing.Point(12, 12);
            this.popisSvihDekubitusaŠtićenika.Name = "popisSvihDekubitusaŠtićenika";
            this.popisSvihDekubitusaŠtićenika.Size = new System.Drawing.Size(744, 342);
            this.popisSvihDekubitusaŠtićenika.TabIndex = 0;
            // 
            // Odaberi
            // 
            this.Odaberi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Odaberi.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Odaberi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Odaberi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Odaberi.Location = new System.Drawing.Point(566, 360);
            this.Odaberi.Name = "Odaberi";
            this.Odaberi.Size = new System.Drawing.Size(190, 45);
            this.Odaberi.TabIndex = 1;
            this.Odaberi.Text = "Odaberi";
            this.Odaberi.UseVisualStyleBackColor = false;
            this.Odaberi.Click += new System.EventHandler(this.Odaberi_Click);
            // 
            // PopisDekubitusaŠtićenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 417);
            this.Controls.Add(this.Odaberi);
            this.Controls.Add(this.popisSvihDekubitusaŠtićenika);
            this.Name = "PopisDekubitusaŠtićenika";
            ((System.ComponentModel.ISupportInitialize)(this.popisSvihDekubitusaŠtićenika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView popisSvihDekubitusaŠtićenika;
        private System.Windows.Forms.Button Odaberi;
    }
}
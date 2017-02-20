namespace Care
{
    partial class NoviDekubitus
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PraćenjeDekubitusaSlika1 = new System.Windows.Forms.PictureBox();
            this.PraćenjeDekubitusaDodajSlike = new System.Windows.Forms.Button();
            this.PraćenjeDekubitusaDatumNastanka = new System.Windows.Forms.DateTimePicker();
            this.PraćenjeDekubitusaLokacija = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PraćenjeDekubitusaOpis = new System.Windows.Forms.TextBox();
            this.PraćenjeDekubitusaDodaj = new System.Windows.Forms.Button();
            this.PraćenjeDekubitusaOdustani = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sticenikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.OdgovorniSkrbitelj = new System.Windows.Forms.ComboBox();
            this.skrbiteljBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.UnosŠtićenikaDekubitusa = new System.Windows.Forms.TextBox();
            this.KrajDekubitusa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PraćenjeDekubitusaSlika1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sticenikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skrbiteljBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum nastanka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(352, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(352, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lokacija dekubitusa";
            // 
            // PraćenjeDekubitusaSlika1
            // 
            this.PraćenjeDekubitusaSlika1.Location = new System.Drawing.Point(15, 19);
            this.PraćenjeDekubitusaSlika1.Name = "PraćenjeDekubitusaSlika1";
            this.PraćenjeDekubitusaSlika1.Size = new System.Drawing.Size(303, 145);
            this.PraćenjeDekubitusaSlika1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PraćenjeDekubitusaSlika1.TabIndex = 4;
            this.PraćenjeDekubitusaSlika1.TabStop = false;
            // 
            // PraćenjeDekubitusaDodajSlike
            // 
            this.PraćenjeDekubitusaDodajSlike.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PraćenjeDekubitusaDodajSlike.Location = new System.Drawing.Point(97, 172);
            this.PraćenjeDekubitusaDodajSlike.Name = "PraćenjeDekubitusaDodajSlike";
            this.PraćenjeDekubitusaDodajSlike.Size = new System.Drawing.Size(125, 39);
            this.PraćenjeDekubitusaDodajSlike.TabIndex = 6;
            this.PraćenjeDekubitusaDodajSlike.Text = "Dodaj sliku";
            this.PraćenjeDekubitusaDodajSlike.UseVisualStyleBackColor = true;
            this.PraćenjeDekubitusaDodajSlike.Click += new System.EventHandler(this.PraćenjeDekubitusaDodajSlike_Click);
            // 
            // PraćenjeDekubitusaDatumNastanka
            // 
            this.PraćenjeDekubitusaDatumNastanka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PraćenjeDekubitusaDatumNastanka.Location = new System.Drawing.Point(120, 246);
            this.PraćenjeDekubitusaDatumNastanka.Name = "PraćenjeDekubitusaDatumNastanka";
            this.PraćenjeDekubitusaDatumNastanka.Size = new System.Drawing.Size(216, 22);
            this.PraćenjeDekubitusaDatumNastanka.TabIndex = 7;
            // 
            // PraćenjeDekubitusaLokacija
            // 
            this.PraćenjeDekubitusaLokacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PraćenjeDekubitusaLokacija.Location = new System.Drawing.Point(353, 47);
            this.PraćenjeDekubitusaLokacija.Multiline = true;
            this.PraćenjeDekubitusaLokacija.Name = "PraćenjeDekubitusaLokacija";
            this.PraćenjeDekubitusaLokacija.Size = new System.Drawing.Size(288, 87);
            this.PraćenjeDekubitusaLokacija.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PraćenjeDekubitusaSlika1);
            this.groupBox1.Controls.Add(this.PraćenjeDekubitusaDodajSlike);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 222);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Slike dekubitusa";
            // 
            // PraćenjeDekubitusaOpis
            // 
            this.PraćenjeDekubitusaOpis.Location = new System.Drawing.Point(353, 179);
            this.PraćenjeDekubitusaOpis.Multiline = true;
            this.PraćenjeDekubitusaOpis.Name = "PraćenjeDekubitusaOpis";
            this.PraćenjeDekubitusaOpis.Size = new System.Drawing.Size(288, 109);
            this.PraćenjeDekubitusaOpis.TabIndex = 11;
            // 
            // PraćenjeDekubitusaDodaj
            // 
            this.PraćenjeDekubitusaDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PraćenjeDekubitusaDodaj.Location = new System.Drawing.Point(440, 362);
            this.PraćenjeDekubitusaDodaj.Name = "PraćenjeDekubitusaDodaj";
            this.PraćenjeDekubitusaDodaj.Size = new System.Drawing.Size(102, 35);
            this.PraćenjeDekubitusaDodaj.TabIndex = 12;
            this.PraćenjeDekubitusaDodaj.Text = "Dodaj";
            this.PraćenjeDekubitusaDodaj.UseVisualStyleBackColor = true;
            this.PraćenjeDekubitusaDodaj.Click += new System.EventHandler(this.PraćenjeDekubitusaDodaj_Click);
            // 
            // PraćenjeDekubitusaOdustani
            // 
            this.PraćenjeDekubitusaOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PraćenjeDekubitusaOdustani.Location = new System.Drawing.Point(548, 361);
            this.PraćenjeDekubitusaOdustani.Name = "PraćenjeDekubitusaOdustani";
            this.PraćenjeDekubitusaOdustani.Size = new System.Drawing.Size(104, 37);
            this.PraćenjeDekubitusaOdustani.TabIndex = 13;
            this.PraćenjeDekubitusaOdustani.Text = "Odustani";
            this.PraćenjeDekubitusaOdustani.UseVisualStyleBackColor = true;
            this.PraćenjeDekubitusaOdustani.Click += new System.EventHandler(this.PraćenjeDekubitusaOdustani_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(24, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Štićenik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(24, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Skrbitelj";
            // 
            // sticenikBindingSource1
            // 
            this.sticenikBindingSource1.DataSource = typeof(Care.Sticenik);
            // 
            // OdgovorniSkrbitelj
            // 
            this.OdgovorniSkrbitelj.DataSource = this.skrbiteljBindingSource1;
            this.OdgovorniSkrbitelj.DisplayMember = "ImeIPrezime";
            this.OdgovorniSkrbitelj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OdgovorniSkrbitelj.FormattingEnabled = true;
            this.OdgovorniSkrbitelj.Location = new System.Drawing.Point(95, 317);
            this.OdgovorniSkrbitelj.Name = "OdgovorniSkrbitelj";
            this.OdgovorniSkrbitelj.Size = new System.Drawing.Size(216, 24);
            this.OdgovorniSkrbitelj.TabIndex = 17;
            this.OdgovorniSkrbitelj.ValueMember = "OIBSkrbitelja";
            // 
            // skrbiteljBindingSource1
            // 
            this.skrbiteljBindingSource1.DataSource = typeof(Care.Skrbitelj);
            // 
            // UnosŠtićenikaDekubitusa
            // 
            this.UnosŠtićenikaDekubitusa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UnosŠtićenikaDekubitusa.Location = new System.Drawing.Point(95, 282);
            this.UnosŠtićenikaDekubitusa.Name = "UnosŠtićenikaDekubitusa";
            this.UnosŠtićenikaDekubitusa.ReadOnly = true;
            this.UnosŠtićenikaDekubitusa.Size = new System.Drawing.Size(216, 22);
            this.UnosŠtićenikaDekubitusa.TabIndex = 18;
            // 
            // KrajDekubitusa
            // 
            this.KrajDekubitusa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KrajDekubitusa.Location = new System.Drawing.Point(95, 362);
            this.KrajDekubitusa.Name = "KrajDekubitusa";
            this.KrajDekubitusa.Size = new System.Drawing.Size(210, 39);
            this.KrajDekubitusa.TabIndex = 19;
            this.KrajDekubitusa.Text = "Kraj dekubitusa";
            this.KrajDekubitusa.UseVisualStyleBackColor = true;
            this.KrajDekubitusa.Click += new System.EventHandler(this.KrajDekubitusa_Click);
            // 
            // NoviDekubitus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 412);
            this.Controls.Add(this.KrajDekubitusa);
            this.Controls.Add(this.UnosŠtićenikaDekubitusa);
            this.Controls.Add(this.OdgovorniSkrbitelj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PraćenjeDekubitusaOdustani);
            this.Controls.Add(this.PraćenjeDekubitusaDodaj);
            this.Controls.Add(this.PraćenjeDekubitusaOpis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PraćenjeDekubitusaLokacija);
            this.Controls.Add(this.PraćenjeDekubitusaDatumNastanka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NoviDekubitus";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Praćenje dekubitusa";
            this.Load += new System.EventHandler(this.NoviDekubitus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PraćenjeDekubitusaSlika1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sticenikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skrbiteljBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PraćenjeDekubitusaSlika1;
        private System.Windows.Forms.Button PraćenjeDekubitusaDodajSlike;
        private System.Windows.Forms.DateTimePicker PraćenjeDekubitusaDatumNastanka;
        private System.Windows.Forms.TextBox PraćenjeDekubitusaLokacija;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PraćenjeDekubitusaOpis;
        private System.Windows.Forms.Button PraćenjeDekubitusaDodaj;
        private System.Windows.Forms.Button PraćenjeDekubitusaOdustani;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox OdgovorniSkrbitelj;
        private System.Windows.Forms.BindingSource skrbiteljBindingSource1;
        private System.Windows.Forms.BindingSource sticenikBindingSource1;
        private System.Windows.Forms.TextBox UnosŠtićenikaDekubitusa;
        private System.Windows.Forms.Button KrajDekubitusa;
    }
}
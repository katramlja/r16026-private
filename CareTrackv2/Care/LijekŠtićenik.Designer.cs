namespace Care
{
    partial class LijekŠtićenik
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
            this.DodajLijek = new System.Windows.Forms.Button();
            this.Izlaz = new System.Windows.Forms.Button();
            this.UnosLijeka = new System.Windows.Forms.ComboBox();
            this.UnosPrimjeneLijeka = new System.Windows.Forms.Label();
            this.UnosRazlogSmjestaja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UnosPrizvođača = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UnosFrekvencijeUzimanjaLijeka = new System.Windows.Forms.TextBox();
            this.PočetniDatumUzimanjaLijekova = new System.Windows.Forms.DateTimePicker();
            this.ZavrsniDatumUzimanjaLijekova = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // DodajLijek
            // 
            this.DodajLijek.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DodajLijek.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.DodajLijek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DodajLijek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajLijek.Location = new System.Drawing.Point(135, 317);
            this.DodajLijek.Name = "DodajLijek";
            this.DodajLijek.Size = new System.Drawing.Size(190, 45);
            this.DodajLijek.TabIndex = 1;
            this.DodajLijek.Text = "Dodaj lijek";
            this.DodajLijek.UseVisualStyleBackColor = false;
            this.DodajLijek.Click += new System.EventHandler(this.DodajLijek_Click);
            // 
            // Izlaz
            // 
            this.Izlaz.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Izlaz.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Izlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Izlaz.Location = new System.Drawing.Point(331, 317);
            this.Izlaz.Name = "Izlaz";
            this.Izlaz.Size = new System.Drawing.Size(190, 45);
            this.Izlaz.TabIndex = 2;
            this.Izlaz.Text = "Izlaz";
            this.Izlaz.UseVisualStyleBackColor = false;
            this.Izlaz.Click += new System.EventHandler(this.Izlaz_Click);
            // 
            // UnosLijeka
            // 
            this.UnosLijeka.FormattingEnabled = true;
            this.UnosLijeka.Location = new System.Drawing.Point(266, 21);
            this.UnosLijeka.Name = "UnosLijeka";
            this.UnosLijeka.Size = new System.Drawing.Size(255, 21);
            this.UnosLijeka.TabIndex = 3;
            // 
            // UnosPrimjeneLijeka
            // 
            this.UnosPrimjeneLijeka.AutoSize = true;
            this.UnosPrimjeneLijeka.BackColor = System.Drawing.SystemColors.Window;
            this.UnosPrimjeneLijeka.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UnosPrimjeneLijeka.Location = new System.Drawing.Point(215, 63);
            this.UnosPrimjeneLijeka.Name = "UnosPrimjeneLijeka";
            this.UnosPrimjeneLijeka.Size = new System.Drawing.Size(75, 13);
            this.UnosPrimjeneLijeka.TabIndex = 28;
            this.UnosPrimjeneLijeka.Text = "Opis i primjena";
            // 
            // UnosRazlogSmjestaja
            // 
            this.UnosRazlogSmjestaja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnosRazlogSmjestaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnosRazlogSmjestaja.Location = new System.Drawing.Point(208, 48);
            this.UnosRazlogSmjestaja.Multiline = true;
            this.UnosRazlogSmjestaja.Name = "UnosRazlogSmjestaja";
            this.UnosRazlogSmjestaja.Size = new System.Drawing.Size(313, 68);
            this.UnosRazlogSmjestaja.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(215, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Proizvođač";
            // 
            // UnosPrizvođača
            // 
            this.UnosPrizvođača.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnosPrizvođača.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnosPrizvođača.Location = new System.Drawing.Point(208, 122);
            this.UnosPrizvođača.Multiline = true;
            this.UnosPrizvođača.Name = "UnosPrizvođača";
            this.UnosPrizvođača.Size = new System.Drawing.Size(313, 58);
            this.UnosPrizvođača.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(215, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Učestalost uzimanja lijeka (izražena u satima)";
            // 
            // UnosFrekvencijeUzimanjaLijeka
            // 
            this.UnosFrekvencijeUzimanjaLijeka.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnosFrekvencijeUzimanjaLijeka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnosFrekvencijeUzimanjaLijeka.Location = new System.Drawing.Point(208, 184);
            this.UnosFrekvencijeUzimanjaLijeka.Multiline = true;
            this.UnosFrekvencijeUzimanjaLijeka.Name = "UnosFrekvencijeUzimanjaLijeka";
            this.UnosFrekvencijeUzimanjaLijeka.Size = new System.Drawing.Size(313, 58);
            this.UnosFrekvencijeUzimanjaLijeka.TabIndex = 33;
            // 
            // PočetniDatumUzimanjaLijekova
            // 
            this.PočetniDatumUzimanjaLijekova.Location = new System.Drawing.Point(208, 248);
            this.PočetniDatumUzimanjaLijekova.Name = "PočetniDatumUzimanjaLijekova";
            this.PočetniDatumUzimanjaLijekova.Size = new System.Drawing.Size(313, 20);
            this.PočetniDatumUzimanjaLijekova.TabIndex = 34;
            // 
            // ZavrsniDatumUzimanjaLijekova
            // 
            this.ZavrsniDatumUzimanjaLijekova.Location = new System.Drawing.Point(208, 274);
            this.ZavrsniDatumUzimanjaLijekova.Name = "ZavrsniDatumUzimanjaLijekova";
            this.ZavrsniDatumUzimanjaLijekova.Size = new System.Drawing.Size(313, 20);
            this.ZavrsniDatumUzimanjaLijekova.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(109, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Naziv lijeka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(85, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Opis i primjena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(108, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "Proizvođač";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(12, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Učestalost uzimanja lijeka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label7.Location = new System.Drawing.Point(85, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Početak terapije";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label8.Location = new System.Drawing.Point(112, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "Kraj terapije";
            // 
            // LijekŠtićenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 368);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ZavrsniDatumUzimanjaLijekova);
            this.Controls.Add(this.PočetniDatumUzimanjaLijekova);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UnosFrekvencijeUzimanjaLijeka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnosPrizvođača);
            this.Controls.Add(this.UnosPrimjeneLijeka);
            this.Controls.Add(this.UnosRazlogSmjestaja);
            this.Controls.Add(this.UnosLijeka);
            this.Controls.Add(this.Izlaz);
            this.Controls.Add(this.DodajLijek);
            this.Name = "LijekŠtićenik";
            this.Text = "Unos lijekova";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DodajLijek;
        private System.Windows.Forms.Button Izlaz;
        private System.Windows.Forms.ComboBox UnosLijeka;
        private System.Windows.Forms.Label UnosPrimjeneLijeka;
        private System.Windows.Forms.TextBox UnosRazlogSmjestaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UnosPrizvođača;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UnosFrekvencijeUzimanjaLijeka;
        private System.Windows.Forms.DateTimePicker PočetniDatumUzimanjaLijekova;
        private System.Windows.Forms.DateTimePicker ZavrsniDatumUzimanjaLijekova;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
    }
}
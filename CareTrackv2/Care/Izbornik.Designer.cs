namespace Care
{
    partial class Izbornik
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PrikazSticenici = new System.Windows.Forms.Button();
            this.PrikazSkrbitelji = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrikazOdjeli = new System.Windows.Forms.Button();
            this.PrikazSobe = new System.Windows.Forms.Button();
            this.PrikazRadnaKnjiga = new System.Windows.Forms.Button();
            this.Izlaz = new System.Windows.Forms.Button();
            this.DodajDjelatnika = new System.Windows.Forms.Button();
            this.DodajSticenika = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Prikaz = new System.Windows.Forms.DataGridView();
            this.DodatniPrikaz = new System.Windows.Forms.DataGridView();
            this.DohvatiVelicinuDataGrida = new System.Windows.Forms.Timer(this.components);
            this.Uredi = new System.Windows.Forms.Button();
            this.PraćenjeŠtićenika = new System.Windows.Forms.Button();
            this.sobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prikaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DodatniPrikaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PrikazSticenici
            // 
            this.PrikazSticenici.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PrikazSticenici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrikazSticenici.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.PrikazSticenici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrikazSticenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrikazSticenici.Location = new System.Drawing.Point(10, 36);
            this.PrikazSticenici.Name = "PrikazSticenici";
            this.PrikazSticenici.Size = new System.Drawing.Size(190, 45);
            this.PrikazSticenici.TabIndex = 0;
            this.PrikazSticenici.Text = "Štićenici";
            this.PrikazSticenici.UseVisualStyleBackColor = false;
            this.PrikazSticenici.Click += new System.EventHandler(this.PrikazSticenici_Click);
            // 
            // PrikazSkrbitelji
            // 
            this.PrikazSkrbitelji.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PrikazSkrbitelji.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrikazSkrbitelji.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.PrikazSkrbitelji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrikazSkrbitelji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrikazSkrbitelji.Location = new System.Drawing.Point(10, 87);
            this.PrikazSkrbitelji.Name = "PrikazSkrbitelji";
            this.PrikazSkrbitelji.Size = new System.Drawing.Size(190, 45);
            this.PrikazSkrbitelji.TabIndex = 1;
            this.PrikazSkrbitelji.Text = "Skrbitelji";
            this.PrikazSkrbitelji.UseVisualStyleBackColor = false;
            this.PrikazSkrbitelji.Click += new System.EventHandler(this.PrikazSkrbitelji_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrikazOdjeli);
            this.groupBox1.Controls.Add(this.PrikazSobe);
            this.groupBox1.Controls.Add(this.PrikazSticenici);
            this.groupBox1.Controls.Add(this.PrikazSkrbitelji);
            this.groupBox1.Controls.Add(this.PrikazRadnaKnjiga);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 305);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prikaži";
            // 
            // PrikazOdjeli
            // 
            this.PrikazOdjeli.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PrikazOdjeli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrikazOdjeli.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.PrikazOdjeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrikazOdjeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrikazOdjeli.Location = new System.Drawing.Point(10, 189);
            this.PrikazOdjeli.Name = "PrikazOdjeli";
            this.PrikazOdjeli.Size = new System.Drawing.Size(190, 45);
            this.PrikazOdjeli.TabIndex = 5;
            this.PrikazOdjeli.Text = "Odjeli";
            this.PrikazOdjeli.UseVisualStyleBackColor = false;
            this.PrikazOdjeli.Click += new System.EventHandler(this.PrikazOdjeli_Click);
            // 
            // PrikazSobe
            // 
            this.PrikazSobe.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PrikazSobe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrikazSobe.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.PrikazSobe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrikazSobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrikazSobe.Location = new System.Drawing.Point(10, 240);
            this.PrikazSobe.Name = "PrikazSobe";
            this.PrikazSobe.Size = new System.Drawing.Size(190, 45);
            this.PrikazSobe.TabIndex = 4;
            this.PrikazSobe.Text = "Sobe";
            this.PrikazSobe.UseVisualStyleBackColor = false;
            this.PrikazSobe.Click += new System.EventHandler(this.PrikazSobe_Click);
            // 
            // PrikazRadnaKnjiga
            // 
            this.PrikazRadnaKnjiga.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PrikazRadnaKnjiga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrikazRadnaKnjiga.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.PrikazRadnaKnjiga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrikazRadnaKnjiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrikazRadnaKnjiga.Location = new System.Drawing.Point(10, 138);
            this.PrikazRadnaKnjiga.Name = "PrikazRadnaKnjiga";
            this.PrikazRadnaKnjiga.Size = new System.Drawing.Size(190, 45);
            this.PrikazRadnaKnjiga.TabIndex = 2;
            this.PrikazRadnaKnjiga.Text = "Radna knjiga";
            this.PrikazRadnaKnjiga.UseVisualStyleBackColor = false;
            this.PrikazRadnaKnjiga.Click += new System.EventHandler(this.PrikazRadnaKnjiga_Click);
            // 
            // Izlaz
            // 
            this.Izlaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Izlaz.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Izlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Izlaz.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Izlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Izlaz.Location = new System.Drawing.Point(583, 560);
            this.Izlaz.Name = "Izlaz";
            this.Izlaz.Size = new System.Drawing.Size(190, 45);
            this.Izlaz.TabIndex = 2;
            this.Izlaz.Text = "Izlaz";
            this.Izlaz.UseVisualStyleBackColor = false;
            this.Izlaz.Click += new System.EventHandler(this.Izlaz_Click);
            // 
            // DodajDjelatnika
            // 
            this.DodajDjelatnika.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DodajDjelatnika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DodajDjelatnika.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.DodajDjelatnika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DodajDjelatnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajDjelatnika.Location = new System.Drawing.Point(10, 91);
            this.DodajDjelatnika.Name = "DodajDjelatnika";
            this.DodajDjelatnika.Size = new System.Drawing.Size(190, 45);
            this.DodajDjelatnika.TabIndex = 6;
            this.DodajDjelatnika.Text = "Djelatnika";
            this.DodajDjelatnika.UseVisualStyleBackColor = false;
            this.DodajDjelatnika.Click += new System.EventHandler(this.DodajDjelatnika_Click_1);
            // 
            // DodajSticenika
            // 
            this.DodajSticenika.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DodajSticenika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DodajSticenika.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.DodajSticenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DodajSticenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajSticenika.Location = new System.Drawing.Point(10, 33);
            this.DodajSticenika.Name = "DodajSticenika";
            this.DodajSticenika.Size = new System.Drawing.Size(190, 45);
            this.DodajSticenika.TabIndex = 7;
            this.DodajSticenika.Text = "Štićenika";
            this.DodajSticenika.UseVisualStyleBackColor = false;
            this.DodajSticenika.Click += new System.EventHandler(this.DodajSticenika_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DodajSticenika);
            this.groupBox2.Controls.Add(this.DodajDjelatnika);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(12, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 147);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodaj novog";
            // 
            // Prikaz
            // 
            this.Prikaz.AllowUserToAddRows = false;
            this.Prikaz.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Prikaz.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Prikaz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Prikaz.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Prikaz.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Prikaz.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Prikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Prikaz.DefaultCellStyle = dataGridViewCellStyle3;
            this.Prikaz.Location = new System.Drawing.Point(231, 25);
            this.Prikaz.MultiSelect = false;
            this.Prikaz.Name = "Prikaz";
            this.Prikaz.ReadOnly = true;
            this.Prikaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Prikaz.Size = new System.Drawing.Size(542, 529);
            this.Prikaz.TabIndex = 7;
            this.Prikaz.SelectionChanged += new System.EventHandler(this.Prikaz_SelectionChanged);
            // 
            // DodatniPrikaz
            // 
            this.DodatniPrikaz.AllowUserToAddRows = false;
            this.DodatniPrikaz.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DodatniPrikaz.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DodatniPrikaz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DodatniPrikaz.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DodatniPrikaz.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DodatniPrikaz.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DodatniPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DodatniPrikaz.DefaultCellStyle = dataGridViewCellStyle6;
            this.DodatniPrikaz.Location = new System.Drawing.Point(231, 300);
            this.DodatniPrikaz.MultiSelect = false;
            this.DodatniPrikaz.Name = "DodatniPrikaz";
            this.DodatniPrikaz.ReadOnly = true;
            this.DodatniPrikaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DodatniPrikaz.Size = new System.Drawing.Size(542, 254);
            this.DodatniPrikaz.TabIndex = 8;
            // 
            // DohvatiVelicinuDataGrida
            // 
            this.DohvatiVelicinuDataGrida.Enabled = true;
            this.DohvatiVelicinuDataGrida.Interval = 1;
            this.DohvatiVelicinuDataGrida.Tick += new System.EventHandler(this.DohvatiVelicinuDataGrida_Tick);
            // 
            // Uredi
            // 
            this.Uredi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Uredi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Uredi.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Uredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Uredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Uredi.Location = new System.Drawing.Point(22, 492);
            this.Uredi.Name = "Uredi";
            this.Uredi.Size = new System.Drawing.Size(190, 45);
            this.Uredi.TabIndex = 7;
            this.Uredi.Text = "Uredi";
            this.Uredi.UseVisualStyleBackColor = false;
            this.Uredi.Click += new System.EventHandler(this.UrediSticenika_Click);
            // 
            // PraćenjeŠtićenika
            // 
            this.PraćenjeŠtićenika.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PraćenjeŠtićenika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PraćenjeŠtićenika.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.PraćenjeŠtićenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PraćenjeŠtićenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PraćenjeŠtićenika.Location = new System.Drawing.Point(22, 543);
            this.PraćenjeŠtićenika.Name = "PraćenjeŠtićenika";
            this.PraćenjeŠtićenika.Size = new System.Drawing.Size(190, 45);
            this.PraćenjeŠtićenika.TabIndex = 9;
            this.PraćenjeŠtićenika.Text = "Praćenje štićenika";
            this.PraćenjeŠtićenika.UseVisualStyleBackColor = false;
            this.PraćenjeŠtićenika.Click += new System.EventHandler(this.PraćenjeŠtićenika_Click);
            // 
            // sobaBindingSource
            // 
            this.sobaBindingSource.DataSource = typeof(Care.Soba);
            // 
            // Izbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(785, 640);
            this.Controls.Add(this.PraćenjeŠtićenika);
            this.Controls.Add(this.Uredi);
            this.Controls.Add(this.DodatniPrikaz);
            this.Controls.Add(this.Prikaz);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Izlaz);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(457, 511);
            this.Name = "Izbornik";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Izbornik";
            this.Load += new System.EventHandler(this.Izbornik_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Prikaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DodatniPrikaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrikazSticenici;
        private System.Windows.Forms.Button PrikazSkrbitelji;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Izlaz;
        private System.Windows.Forms.Button DodajDjelatnika;
        private System.Windows.Forms.Button DodajSticenika;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PrikazRadnaKnjiga;
        private System.Windows.Forms.DataGridView Prikaz;
        private System.Windows.Forms.Button PrikazOdjeli;
        private System.Windows.Forms.Button PrikazSobe;
        private System.Windows.Forms.DataGridView DodatniPrikaz;
        private System.Windows.Forms.Timer DohvatiVelicinuDataGrida;
        private System.Windows.Forms.Button Uredi;
        private System.Windows.Forms.Button PraćenjeŠtićenika;
        private System.Windows.Forms.BindingSource sobaBindingSource;
    }
}
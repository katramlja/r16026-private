namespace Care
{
    partial class RadnaKnjiga
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
            this.OdabirSkrbitelja = new System.Windows.Forms.ComboBox();
            this.skrbiteljBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OdabirDatuma = new System.Windows.Forms.DateTimePicker();
            this.PrikazSticenici = new System.Windows.Forms.DataGridView();
            this.PrikazIncidenti = new System.Windows.Forms.DataGridView();
            this.PrikazDekubitus = new System.Windows.Forms.DataGridView();
            this.PrikazMjerenja = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Uredu = new System.Windows.Forms.Button();
            this.Izlaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.skrbiteljBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrikazSticenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrikazIncidenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrikazDekubitus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrikazMjerenja)).BeginInit();
            this.SuspendLayout();
            // 
            // OdabirSkrbitelja
            // 
            this.OdabirSkrbitelja.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.skrbiteljBindingSource, "OIBSkrbitelja", true));
            this.OdabirSkrbitelja.DataSource = this.skrbiteljBindingSource;
            this.OdabirSkrbitelja.DisplayMember = "ImeIPrezime";
            this.OdabirSkrbitelja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OdabirSkrbitelja.FormattingEnabled = true;
            this.OdabirSkrbitelja.Location = new System.Drawing.Point(12, 49);
            this.OdabirSkrbitelja.Name = "OdabirSkrbitelja";
            this.OdabirSkrbitelja.Size = new System.Drawing.Size(305, 26);
            this.OdabirSkrbitelja.TabIndex = 0;
            this.OdabirSkrbitelja.ValueMember = "OIBSkrbitelja";
            // 
            // skrbiteljBindingSource
            // 
            this.skrbiteljBindingSource.DataSource = typeof(Care.Skrbitelj);
            // 
            // OdabirDatuma
            // 
            this.OdabirDatuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OdabirDatuma.Location = new System.Drawing.Point(370, 49);
            this.OdabirDatuma.Name = "OdabirDatuma";
            this.OdabirDatuma.Size = new System.Drawing.Size(262, 24);
            this.OdabirDatuma.TabIndex = 1;
            // 
            // PrikazSticenici
            // 
            this.PrikazSticenici.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PrikazSticenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PrikazSticenici.DefaultCellStyle = dataGridViewCellStyle1;
            this.PrikazSticenici.Location = new System.Drawing.Point(12, 117);
            this.PrikazSticenici.Name = "PrikazSticenici";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PrikazSticenici.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PrikazSticenici.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.PrikazSticenici.Size = new System.Drawing.Size(838, 118);
            this.PrikazSticenici.TabIndex = 2;
            this.PrikazSticenici.SelectionChanged += new System.EventHandler(this.PrikazSticenici_SelectionChanged);
            // 
            // PrikazIncidenti
            // 
            this.PrikazIncidenti.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PrikazIncidenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PrikazIncidenti.DefaultCellStyle = dataGridViewCellStyle3;
            this.PrikazIncidenti.Location = new System.Drawing.Point(12, 449);
            this.PrikazIncidenti.Name = "PrikazIncidenti";
            this.PrikazIncidenti.Size = new System.Drawing.Size(838, 129);
            this.PrikazIncidenti.TabIndex = 3;
            // 
            // PrikazDekubitus
            // 
            this.PrikazDekubitus.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PrikazDekubitus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PrikazDekubitus.DefaultCellStyle = dataGridViewCellStyle4;
            this.PrikazDekubitus.Location = new System.Drawing.Point(12, 604);
            this.PrikazDekubitus.Name = "PrikazDekubitus";
            this.PrikazDekubitus.Size = new System.Drawing.Size(838, 122);
            this.PrikazDekubitus.TabIndex = 4;
            // 
            // PrikazMjerenja
            // 
            this.PrikazMjerenja.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PrikazMjerenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PrikazMjerenja.DefaultCellStyle = dataGridViewCellStyle5;
            this.PrikazMjerenja.Location = new System.Drawing.Point(12, 261);
            this.PrikazMjerenja.Name = "PrikazMjerenja";
            this.PrikazMjerenja.Size = new System.Drawing.Size(838, 162);
            this.PrikazMjerenja.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Skrbitelj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(366, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Štićenici";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mjerenja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Incidenti";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 581);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Praćenje dekubitusa";
            // 
            // Uredu
            // 
            this.Uredu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Uredu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Uredu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Uredu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Uredu.Location = new System.Drawing.Point(671, 37);
            this.Uredu.Name = "Uredu";
            this.Uredu.Size = new System.Drawing.Size(179, 52);
            this.Uredu.TabIndex = 12;
            this.Uredu.Text = "U redu";
            this.Uredu.UseVisualStyleBackColor = false;
            this.Uredu.Click += new System.EventHandler(this.Uredu_Click);
            // 
            // Izlaz
            // 
            this.Izlaz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Izlaz.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Izlaz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Izlaz.Location = new System.Drawing.Point(687, 747);
            this.Izlaz.Name = "Izlaz";
            this.Izlaz.Size = new System.Drawing.Size(179, 52);
            this.Izlaz.TabIndex = 13;
            this.Izlaz.Text = "Izlaz";
            this.Izlaz.UseVisualStyleBackColor = false;
            this.Izlaz.Click += new System.EventHandler(this.Izlaz_Click);
            // 
            // RadnaKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(878, 811);
            this.Controls.Add(this.Izlaz);
            this.Controls.Add(this.Uredu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrikazMjerenja);
            this.Controls.Add(this.PrikazDekubitus);
            this.Controls.Add(this.PrikazIncidenti);
            this.Controls.Add(this.PrikazSticenici);
            this.Controls.Add(this.OdabirDatuma);
            this.Controls.Add(this.OdabirSkrbitelja);
            this.Name = "RadnaKnjiga";
            this.Text = "RadnaKnjiga";
            this.Load += new System.EventHandler(this.RadnaKnjiga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skrbiteljBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrikazSticenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrikazIncidenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrikazDekubitus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrikazMjerenja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OdabirSkrbitelja;
        private System.Windows.Forms.DateTimePicker OdabirDatuma;
        private System.Windows.Forms.DataGridView PrikazSticenici;
        private System.Windows.Forms.DataGridView PrikazIncidenti;
        private System.Windows.Forms.DataGridView PrikazDekubitus;
        private System.Windows.Forms.DataGridView PrikazMjerenja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource skrbiteljBindingSource;
        private System.Windows.Forms.Button Uredu;
        private System.Windows.Forms.Button Izlaz;
    }
}
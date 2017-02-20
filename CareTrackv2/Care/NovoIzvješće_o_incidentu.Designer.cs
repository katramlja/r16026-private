namespace Care
{
    partial class NovoIzvješće_o_incidentu
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
            this.OpisIncidenta = new System.Windows.Forms.Label();
            this.UnosOpisaIncidenta = new System.Windows.Forms.TextBox();
            this.UnosVrijemePočetkaIncidenta = new System.Windows.Forms.DateTimePicker();
            this.UnosVrijemeZavršetkaIncidenta = new System.Windows.Forms.DateTimePicker();
            this.UnosOIB_Skrbitelja = new System.Windows.Forms.ComboBox();
            this.skrbiteljBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Izlaz = new System.Windows.Forms.Button();
            this.Spremi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UnosŠtićenika = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.skrbiteljBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OpisIncidenta
            // 
            this.OpisIncidenta.AutoSize = true;
            this.OpisIncidenta.BackColor = System.Drawing.SystemColors.Window;
            this.OpisIncidenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpisIncidenta.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OpisIncidenta.Location = new System.Drawing.Point(156, 32);
            this.OpisIncidenta.Name = "OpisIncidenta";
            this.OpisIncidenta.Size = new System.Drawing.Size(93, 16);
            this.OpisIncidenta.TabIndex = 10;
            this.OpisIncidenta.Text = "Opis incidenta";
            // 
            // UnosOpisaIncidenta
            // 
            this.UnosOpisaIncidenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnosOpisaIncidenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnosOpisaIncidenta.Location = new System.Drawing.Point(149, 23);
            this.UnosOpisaIncidenta.Multiline = true;
            this.UnosOpisaIncidenta.Name = "UnosOpisaIncidenta";
            this.UnosOpisaIncidenta.Size = new System.Drawing.Size(413, 143);
            this.UnosOpisaIncidenta.TabIndex = 9;
            // 
            // UnosVrijemePočetkaIncidenta
            // 
            this.UnosVrijemePočetkaIncidenta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UnosVrijemePočetkaIncidenta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.UnosVrijemePočetkaIncidenta.Location = new System.Drawing.Point(149, 190);
            this.UnosVrijemePočetkaIncidenta.Name = "UnosVrijemePočetkaIncidenta";
            this.UnosVrijemePočetkaIncidenta.Size = new System.Drawing.Size(296, 20);
            this.UnosVrijemePočetkaIncidenta.TabIndex = 11;
            // 
            // UnosVrijemeZavršetkaIncidenta
            // 
            this.UnosVrijemeZavršetkaIncidenta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UnosVrijemeZavršetkaIncidenta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.UnosVrijemeZavršetkaIncidenta.Location = new System.Drawing.Point(149, 230);
            this.UnosVrijemeZavršetkaIncidenta.Name = "UnosVrijemeZavršetkaIncidenta";
            this.UnosVrijemeZavršetkaIncidenta.Size = new System.Drawing.Size(296, 20);
            this.UnosVrijemeZavršetkaIncidenta.TabIndex = 12;
            // 
            // UnosOIB_Skrbitelja
            // 
            this.UnosOIB_Skrbitelja.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.skrbiteljBindingSource, "OIBSkrbitelja", true));
            this.UnosOIB_Skrbitelja.DataSource = this.skrbiteljBindingSource;
            this.UnosOIB_Skrbitelja.DisplayMember = "ImeIPrezime";
            this.UnosOIB_Skrbitelja.FormattingEnabled = true;
            this.UnosOIB_Skrbitelja.Location = new System.Drawing.Point(149, 313);
            this.UnosOIB_Skrbitelja.Name = "UnosOIB_Skrbitelja";
            this.UnosOIB_Skrbitelja.Size = new System.Drawing.Size(296, 21);
            this.UnosOIB_Skrbitelja.TabIndex = 14;
            this.UnosOIB_Skrbitelja.ValueMember = "OIBSkrbitelja";
            // 
            // skrbiteljBindingSource
            // 
            this.skrbiteljBindingSource.DataSource = typeof(Care.Skrbitelj);
            // 
            // Izlaz
            // 
            this.Izlaz.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Izlaz.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Izlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Izlaz.Location = new System.Drawing.Point(513, 362);
            this.Izlaz.Name = "Izlaz";
            this.Izlaz.Size = new System.Drawing.Size(190, 45);
            this.Izlaz.TabIndex = 15;
            this.Izlaz.Text = "Izlaz";
            this.Izlaz.UseVisualStyleBackColor = false;
            this.Izlaz.Click += new System.EventHandler(this.Izlaz_Click);
            // 
            // Spremi
            // 
            this.Spremi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Spremi.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Spremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Spremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Spremi.Location = new System.Drawing.Point(317, 362);
            this.Spremi.Name = "Spremi";
            this.Spremi.Size = new System.Drawing.Size(190, 45);
            this.Spremi.TabIndex = 16;
            this.Spremi.Text = "Spremi";
            this.Spremi.UseVisualStyleBackColor = false;
            this.Spremi.Click += new System.EventHandler(this.Spremi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Opis incidenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Vrijeme početka ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Vrijeme završetka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Štićenik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Skrbitelj ";
            // 
            // UnosŠtićenika
            // 
            this.UnosŠtićenika.Location = new System.Drawing.Point(149, 273);
            this.UnosŠtićenika.Multiline = true;
            this.UnosŠtićenika.Name = "UnosŠtićenika";
            this.UnosŠtićenika.ReadOnly = true;
            this.UnosŠtićenika.Size = new System.Drawing.Size(296, 23);
            this.UnosŠtićenika.TabIndex = 22;
            // 
            // NovoIzvješće_o_incidentu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 419);
            this.Controls.Add(this.UnosŠtićenika);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Spremi);
            this.Controls.Add(this.Izlaz);
            this.Controls.Add(this.UnosOIB_Skrbitelja);
            this.Controls.Add(this.UnosVrijemeZavršetkaIncidenta);
            this.Controls.Add(this.UnosVrijemePočetkaIncidenta);
            this.Controls.Add(this.OpisIncidenta);
            this.Controls.Add(this.UnosOpisaIncidenta);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "NovoIzvješće_o_incidentu";
            this.Text = "Unos izvješća o incidentu";
            ((System.ComponentModel.ISupportInitialize)(this.skrbiteljBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OpisIncidenta;
        private System.Windows.Forms.TextBox UnosOpisaIncidenta;
        private System.Windows.Forms.DateTimePicker UnosVrijemePočetkaIncidenta;
        private System.Windows.Forms.DateTimePicker UnosVrijemeZavršetkaIncidenta;
        private System.Windows.Forms.ComboBox UnosOIB_Skrbitelja;
        private System.Windows.Forms.Button Izlaz;
        private System.Windows.Forms.Button Spremi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UnosŠtićenika;
        private System.Windows.Forms.BindingSource skrbiteljBindingSource;
    }
}
namespace Care
{
    partial class NovaSoba
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
            this.UnosBrojSobe = new System.Windows.Forms.TextBox();
            this.OdabirOdjela = new System.Windows.Forms.ComboBox();
            this.odjelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dodaj = new System.Windows.Forms.Button();
            this.Izlaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.odjelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UnosBrojSobe
            // 
            this.UnosBrojSobe.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.UnosBrojSobe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnosBrojSobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UnosBrojSobe.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UnosBrojSobe.Location = new System.Drawing.Point(10, 31);
            this.UnosBrojSobe.Margin = new System.Windows.Forms.Padding(4);
            this.UnosBrojSobe.MaxLength = 4;
            this.UnosBrojSobe.Multiline = true;
            this.UnosBrojSobe.Name = "UnosBrojSobe";
            this.UnosBrojSobe.Size = new System.Drawing.Size(159, 26);
            this.UnosBrojSobe.TabIndex = 10;
            this.UnosBrojSobe.WordWrap = false;
            // 
            // OdabirOdjela
            // 
            this.OdabirOdjela.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.odjelBindingSource, "ID_Odjela", true));
            this.OdabirOdjela.DataSource = this.odjelBindingSource;
            this.OdabirOdjela.DisplayMember = "Naziv_odjela";
            this.OdabirOdjela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OdabirOdjela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OdabirOdjela.FormattingEnabled = true;
            this.OdabirOdjela.Location = new System.Drawing.Point(10, 83);
            this.OdabirOdjela.Margin = new System.Windows.Forms.Padding(4);
            this.OdabirOdjela.Name = "OdabirOdjela";
            this.OdabirOdjela.Size = new System.Drawing.Size(263, 26);
            this.OdabirOdjela.TabIndex = 32;
            this.OdabirOdjela.ValueMember = "ID_Odjela";
            // 
            // odjelBindingSource
            // 
            this.odjelBindingSource.DataSource = typeof(Care.Odjel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(7, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Odabir odjela";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Broj sobe";
            // 
            // Dodaj
            // 
            this.Dodaj.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Dodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dodaj.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Dodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dodaj.Location = new System.Drawing.Point(10, 116);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(128, 45);
            this.Dodaj.TabIndex = 39;
            this.Dodaj.Text = "Spremi";
            this.Dodaj.UseVisualStyleBackColor = false;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // Izlaz
            // 
            this.Izlaz.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Izlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Izlaz.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Izlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Izlaz.Location = new System.Drawing.Point(144, 116);
            this.Izlaz.Name = "Izlaz";
            this.Izlaz.Size = new System.Drawing.Size(130, 45);
            this.Izlaz.TabIndex = 38;
            this.Izlaz.Text = "Izlaz";
            this.Izlaz.UseVisualStyleBackColor = false;
            this.Izlaz.Click += new System.EventHandler(this.Izlaz_Click);
            // 
            // NovaSoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(292, 175);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.Izlaz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OdabirOdjela);
            this.Controls.Add(this.UnosBrojSobe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NovaSoba";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobe";
            this.Load += new System.EventHandler(this.NovaSoba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.odjelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UnosBrojSobe;
        private System.Windows.Forms.ComboBox OdabirOdjela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button Izlaz;
        private System.Windows.Forms.BindingSource odjelBindingSource;
    }
}
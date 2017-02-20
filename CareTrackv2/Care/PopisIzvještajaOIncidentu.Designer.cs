namespace Care
{
    partial class PopisIzvještajaOIncidentu
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
            this.PopisSvihIzvještaja = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PopisSvihIzvještaja)).BeginInit();
            this.SuspendLayout();
            // 
            // PopisSvihIzvještaja
            // 
            this.PopisSvihIzvještaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PopisSvihIzvještaja.Location = new System.Drawing.Point(12, 12);
            this.PopisSvihIzvještaja.Name = "PopisSvihIzvještaja";
            this.PopisSvihIzvještaja.Size = new System.Drawing.Size(732, 313);
            this.PopisSvihIzvještaja.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(554, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Odaberi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PopisIzvještajaOIncidentu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 384);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PopisSvihIzvještaja);
            this.Name = "PopisIzvještajaOIncidentu";
            ((System.ComponentModel.ISupportInitialize)(this.PopisSvihIzvještaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PopisSvihIzvještaja;
        private System.Windows.Forms.Button button1;
    }
}
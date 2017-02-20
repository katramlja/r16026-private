namespace Care
{
    partial class GlavnaForma
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
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrikaziIzbornik = new System.Windows.Forms.ToolStripMenuItem();
            this.PrikaziSticenike = new System.Windows.Forms.ToolStripMenuItem();
            this.PrikaziSkrbitelje = new System.Windows.Forms.ToolStripMenuItem();
            this.PrikaziSveDjelatnike = new System.Windows.Forms.ToolStripMenuItem();
            this.PrikaziRadnuKnjigu = new System.Windows.Forms.ToolStripMenuItem();
            this.dekubitusaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mjerenjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DodajSticenika = new System.Windows.Forms.ToolStripMenuItem();
            this.DodajDjelatnika = new System.Windows.Forms.ToolStripMenuItem();
            this.DodajOdjele = new System.Windows.Forms.ToolStripMenuItem();
            this.DodajSobe = new System.Windows.Forms.ToolStripMenuItem();
            this.DodajAlergije = new System.Windows.Forms.ToolStripMenuItem();
            this.DodajLijekove = new System.Windows.Forms.ToolStripMenuItem();
            this.izvješćeOIncidentuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Odjava = new System.Windows.Forms.ToolStripMenuItem();
            this.KrajRada = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.oProgramuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.IzbornikTraka = new System.Windows.Forms.MenuStrip();
            this.izvješćaOIncidentuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IzbornikTraka.SuspendLayout();
            this.SuspendLayout();
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazToolStripMenuItem,
            this.dodajToolStripMenuItem,
            this.toolStripMenuItem1,
            this.Odjava,
            this.KrajRada});
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // prikazToolStripMenuItem
            // 
            this.prikazToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrikaziIzbornik,
            this.PrikaziSticenike,
            this.PrikaziSkrbitelje,
            this.PrikaziSveDjelatnike,
            this.PrikaziRadnuKnjigu,
            this.dekubitusaToolStripMenuItem,
            this.mjerenjaToolStripMenuItem,
            this.izvješćaOIncidentuToolStripMenuItem});
            this.prikazToolStripMenuItem.Name = "prikazToolStripMenuItem";
            this.prikazToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.prikazToolStripMenuItem.Text = "Prikaz";
            // 
            // PrikaziIzbornik
            // 
            this.PrikaziIzbornik.Name = "PrikaziIzbornik";
            this.PrikaziIzbornik.Size = new System.Drawing.Size(152, 22);
            this.PrikaziIzbornik.Text = "Izbornik";
            this.PrikaziIzbornik.Click += new System.EventHandler(this.PrikaziIzbornik_Click);
            // 
            // PrikaziSticenike
            // 
            this.PrikaziSticenike.Name = "PrikaziSticenike";
            this.PrikaziSticenike.Size = new System.Drawing.Size(152, 22);
            this.PrikaziSticenike.Text = "Štićenici";
            // 
            // PrikaziSkrbitelje
            // 
            this.PrikaziSkrbitelje.Name = "PrikaziSkrbitelje";
            this.PrikaziSkrbitelje.Size = new System.Drawing.Size(152, 22);
            this.PrikaziSkrbitelje.Text = "Skrbitelji";
            // 
            // PrikaziSveDjelatnike
            // 
            this.PrikaziSveDjelatnike.Name = "PrikaziSveDjelatnike";
            this.PrikaziSveDjelatnike.Size = new System.Drawing.Size(152, 22);
            this.PrikaziSveDjelatnike.Text = "Svi djelatnici";
            // 
            // PrikaziRadnuKnjigu
            // 
            this.PrikaziRadnuKnjigu.Name = "PrikaziRadnuKnjigu";
            this.PrikaziRadnuKnjigu.Size = new System.Drawing.Size(152, 22);
            this.PrikaziRadnuKnjigu.Text = "Radna knjiga";
            // 
            // dekubitusaToolStripMenuItem
            // 
            this.dekubitusaToolStripMenuItem.Name = "dekubitusaToolStripMenuItem";
            this.dekubitusaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dekubitusaToolStripMenuItem.Text = "Dekubitusa";
            this.dekubitusaToolStripMenuItem.Click += new System.EventHandler(this.dekubitusaToolStripMenuItem_Click);
            // 
            // mjerenjaToolStripMenuItem
            // 
            this.mjerenjaToolStripMenuItem.Name = "mjerenjaToolStripMenuItem";
            this.mjerenjaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mjerenjaToolStripMenuItem.Text = "Mjerenja";
            this.mjerenjaToolStripMenuItem.Click += new System.EventHandler(this.mjerenjaToolStripMenuItem_Click);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DodajSticenika,
            this.DodajDjelatnika,
            this.DodajOdjele,
            this.DodajSobe,
            this.DodajAlergije,
            this.DodajLijekove,
            this.izvješćeOIncidentuToolStripMenuItem});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // DodajSticenika
            // 
            this.DodajSticenika.Name = "DodajSticenika";
            this.DodajSticenika.Size = new System.Drawing.Size(177, 22);
            this.DodajSticenika.Text = "Štićenika";
            this.DodajSticenika.Click += new System.EventHandler(this.DodajSticenika_Click);
            // 
            // DodajDjelatnika
            // 
            this.DodajDjelatnika.Name = "DodajDjelatnika";
            this.DodajDjelatnika.Size = new System.Drawing.Size(177, 22);
            this.DodajDjelatnika.Text = "Djelatnika";
            this.DodajDjelatnika.Click += new System.EventHandler(this.DodajDjelatnika_Click);
            // 
            // DodajOdjele
            // 
            this.DodajOdjele.Name = "DodajOdjele";
            this.DodajOdjele.Size = new System.Drawing.Size(177, 22);
            this.DodajOdjele.Text = "Odjele";
            this.DodajOdjele.Click += new System.EventHandler(this.DodajOdjele_Click);
            // 
            // DodajSobe
            // 
            this.DodajSobe.Name = "DodajSobe";
            this.DodajSobe.Size = new System.Drawing.Size(177, 22);
            this.DodajSobe.Text = "Sobe";
            this.DodajSobe.Click += new System.EventHandler(this.DodajSobe_Click);
            // 
            // DodajAlergije
            // 
            this.DodajAlergije.Name = "DodajAlergije";
            this.DodajAlergije.Size = new System.Drawing.Size(177, 22);
            this.DodajAlergije.Text = "Alergije";
            this.DodajAlergije.Click += new System.EventHandler(this.DodajAlergije_Click);
            // 
            // DodajLijekove
            // 
            this.DodajLijekove.Name = "DodajLijekove";
            this.DodajLijekove.Size = new System.Drawing.Size(177, 22);
            this.DodajLijekove.Text = "Lijekove";
            this.DodajLijekove.Click += new System.EventHandler(this.DodajLijekove_Click);
            // 
            // izvješćeOIncidentuToolStripMenuItem
            // 
            this.izvješćeOIncidentuToolStripMenuItem.Name = "izvješćeOIncidentuToolStripMenuItem";
            this.izvješćeOIncidentuToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.izvješćeOIncidentuToolStripMenuItem.Text = "Izvješće o incidentu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // Odjava
            // 
            this.Odjava.Name = "Odjava";
            this.Odjava.Size = new System.Drawing.Size(152, 22);
            this.Odjava.Text = "Odjava";
            this.Odjava.Click += new System.EventHandler(this.Odjava_Click);
            // 
            // KrajRada
            // 
            this.KrajRada.Name = "KrajRada";
            this.KrajRada.Size = new System.Drawing.Size(152, 22);
            this.KrajRada.Text = "Kraj rada";
            this.KrajRada.Click += new System.EventHandler(this.KrajRada_Click);
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomoćToolStripMenuItem,
            this.toolStripMenuItem2,
            this.oProgramuToolStripMenuItem1});
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.oProgramuToolStripMenuItem.Text = "Pomoć";
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(136, 6);
            // 
            // oProgramuToolStripMenuItem1
            // 
            this.oProgramuToolStripMenuItem1.Name = "oProgramuToolStripMenuItem1";
            this.oProgramuToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.oProgramuToolStripMenuItem1.Text = "O programu";
            // 
            // IzbornikTraka
            // 
            this.IzbornikTraka.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.IzbornikTraka.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.oProgramuToolStripMenuItem});
            this.IzbornikTraka.Location = new System.Drawing.Point(0, 0);
            this.IzbornikTraka.Name = "IzbornikTraka";
            this.IzbornikTraka.Size = new System.Drawing.Size(752, 24);
            this.IzbornikTraka.TabIndex = 7;
            // 
            // izvješćaOIncidentuToolStripMenuItem
            // 
            this.izvješćaOIncidentuToolStripMenuItem.Name = "izvješćaOIncidentuToolStripMenuItem";
            this.izvješćaOIncidentuToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.izvješćaOIncidentuToolStripMenuItem.Text = "Izvješća o incidentu";
            this.izvješćaOIncidentuToolStripMenuItem.Click += new System.EventHandler(this.izvješćaOIncidentuToolStripMenuItem_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 315);
            this.Controls.Add(this.IzbornikTraka);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.IzbornikTraka;
            this.Name = "GlavnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CareTrack";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GlavnaForma_FormClosing);
            this.Load += new System.EventHandler(this.GlavnaForma_Load);
            this.IzbornikTraka.ResumeLayout(false);
            this.IzbornikTraka.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrikaziIzbornik;
        private System.Windows.Forms.ToolStripMenuItem PrikaziSticenike;
        private System.Windows.Forms.ToolStripMenuItem PrikaziSkrbitelje;
        private System.Windows.Forms.ToolStripMenuItem PrikaziSveDjelatnike;
        private System.Windows.Forms.ToolStripMenuItem PrikaziRadnuKnjigu;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DodajSticenika;
        private System.Windows.Forms.ToolStripMenuItem DodajDjelatnika;
        private System.Windows.Forms.ToolStripMenuItem DodajOdjele;
        private System.Windows.Forms.ToolStripMenuItem DodajSobe;
        private System.Windows.Forms.ToolStripMenuItem DodajAlergije;
        private System.Windows.Forms.ToolStripMenuItem DodajLijekove;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Odjava;
        private System.Windows.Forms.ToolStripMenuItem KrajRada;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip IzbornikTraka;
        private System.Windows.Forms.ToolStripMenuItem izvješćeOIncidentuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dekubitusaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mjerenjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvješćaOIncidentuToolStripMenuItem;
    }
}
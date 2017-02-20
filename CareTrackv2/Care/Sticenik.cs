using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Care
{
    public class Sticenik
    {
        public string OIBSticenika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojOsobneIskazncie { get; set; }
        public string Slika2 { get; set; }
        public string MjestoIzdavanjaOsobne { get; set; }
        public string MjestoRođenja { get; set; }
        public string DatumRođenja { get; set; }
        public string AdresaPrebivalista { get; set; }
        public string Telefon { get; set; }
        public string RazlogSmještaja { get; set; }
        public bool Pusenje { get; set; }
        public string KontaktOsoba { get; set; }
        public string KontaktTelefon { get; set; }
        public int soba { get; set; }
        public string skrbitelji;

        public byte[] poljeSlike = new byte[NoviSticenik.duljinaZapisaSlike];


        public static List<Skrbitelj> listaSkrbitelja = new List<Skrbitelj>();

        public Sticenik()
        {
            
        }
       public Sticenik(DbDataReader dr) {
            if (dr != null) {               
                OIBSticenika = dr["OIB_Štićenika"].ToString() ;
                Ime = dr["Ime"].ToString();
                Prezime = dr["Prezime"].ToString();
                BrojOsobneIskazncie = dr["Br_osobne_iskaznice"].ToString();
                Slika2 = dr["Slika2"].ToString();
                MjestoIzdavanjaOsobne = dr["Mjesto_izdavanja_osobne_iskaznice"].ToString();
                MjestoRođenja = dr["Mjesto_rođenja"].ToString();
                DatumRođenja = dr["Datum_rođenja"].ToString();
                AdresaPrebivalista = dr["Adresa_prebivališta"].ToString();
                Telefon = dr["Telefon"].ToString();
                RazlogSmještaja = dr["Razlog_smještaja"].ToString();
                Pusenje = bool.Parse(dr["Pušenje"].ToString());
                KontaktOsoba = dr["Kontakt_osoba"].ToString();
                KontaktTelefon = dr["Telefon_kontakt_osobe"].ToString();
                soba = int.Parse(dr["SobeID_Sobe"].ToString());
            }
        }
  
        public int Spremi()
        {
            string sqlUpit = "";
            sqlUpit = "SELECT OIB_Štićenika FROM Štićenici WHERE OIB_Štićenika = '" + OIBSticenika + "'";
            if (SQLServer.Instance.DohvatiVrijednost(sqlUpit) == null)
            {
                sqlUpit = "INSERT INTO Štićenici (OIB_Štićenika, Slika2, Ime, Prezime, Br_osobne_iskaznice, Mjesto_izdavanja_osobne_iskaznice, Mjesto_rođenja, Datum_rođenja, Adresa_prebivališta, Telefon, Razlog_smještaja, Pušenje, Kontakt_osoba, Telefon_kontakt_osobe,SobeID_Sobe) VALUES ('" + OIBSticenika + "','" + Slika2 + "','" + Ime + "','" + Prezime + "','" + BrojOsobneIskazncie + "','" + MjestoIzdavanjaOsobne + "','" + MjestoRođenja + "','" + DatumRođenja + "','" + AdresaPrebivalista + "','" + Telefon + "','" + RazlogSmještaja + "','" + Pusenje + "','" + KontaktOsoba + "','" + KontaktTelefon + "','" + soba + "')";              
            }
            else {
                sqlUpit = "UPDATE Štićenici SET Ime = '" + Ime 
                    + "',Prezime = '" + Prezime 
                    + "',Br_osobne_iskaznice = '"+ BrojOsobneIskazncie 
                    + "',Slika2 = '" + Slika2
                    + "', Mjesto_izdavanja_osobne_iskaznice = '" + MjestoIzdavanjaOsobne
                    +"', Mjesto_rođenja = '" + MjestoRođenja
                    + "', Datum_rođenja = '" + DatumRođenja 
                    + "', Adresa_prebivališta = '" + AdresaPrebivalista 
                    +"', Telefon = '" + Telefon 
                    + "', Razlog_smještaja = '" + RazlogSmještaja 
                    + "', Pušenje = '" + Pusenje 
                    +"', Kontakt_osoba = '" + KontaktOsoba 
                    + "', Telefon_kontakt_osobe = '" + KontaktTelefon 
                    + "', SobeID_Sobe = '" + soba
                    + "'WHERE OIB_Štićenika= '" + OIBSticenika+"'";
          }
            return SQLServer.Instance.IzvrsiUpit(sqlUpit);               
       }
        public void SpremiSkrbitelje(List<Skrbitelj> skrbitelj)
        {
            string sqlUpit = "DELETE FROM Skrbitelji_Štićenici WHERE ŠtićenikOIB_Štićenika= '" + OIBSticenika+"'";
            SQLServer.Instance.IzvrsiUpit(sqlUpit);
            foreach (var item in skrbitelj)
            {
                sqlUpit = "INSERT INTO Skrbitelji_Štićenici (SrbiteljOIB_Skrbitelja,ŠtićenikOIB_Štićenika) VALUES ('" + item.OIBSkrbitelja +"','" + OIBSticenika + "')";
                SQLServer.Instance.IzvrsiUpit(sqlUpit);
            }
        }
        public void Obrisi()
        {
            string sqlDelete = "DELETE FROM Skrbitelji_Štićenici WHERE ŠtićenikOIB_Štićenika = '" + OIBSticenika + "'";
            SQLServer.Instance.IzvrsiUpit(sqlDelete);
            
            sqlDelete = "DELETE FROM Štićenici_Težina WHERE ŠtićeniciOIB_Štićenika = '" + OIBSticenika + "'";
            SQLServer.Instance.IzvrsiUpit(sqlDelete);
            
            sqlDelete = "DELETE FROM Štićenici_Visine WHERE ŠtićeniciOIB_Štićenika = '" + OIBSticenika + "'";
            SQLServer.Instance.IzvrsiUpit(sqlDelete);

            sqlDelete = "DELETE FROM Štićenici WHERE OIB_Štićenika = '" + OIBSticenika + "'";
            SQLServer.Instance.IzvrsiUpit(sqlDelete);
        }
        public static List<Sticenik> DohvatiSticenike()
        {
            Sticenik sticenik = null;
            List<Sticenik> listaSticenika = new List<Sticenik>();
            string sqlUpit = "SELECT * FROM Štićenici";
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                sticenik = new Sticenik(dr);

                listaSticenika.Add(sticenik);
            }
            dr.Close();
            return listaSticenika;
        }
        public static List<Sticenik> DohvatiSticenikeUSobi(string odabranaSoba)
        {
            Sticenik sticenik = null;
            List<Sticenik> listaSticenika = new List<Sticenik>();
            string sqlUpit = "SELECT * FROM Štićenici WHERE SobeID_Sobe = " + odabranaSoba;
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                sticenik = new Sticenik(dr);

                listaSticenika.Add(sticenik);
            }
            dr.Close();
            return listaSticenika;
        }

        public static List<Sticenik> DohvatiSticenikePoSkrbitelju(string odabraniSkrbitelj)
        {
            Sticenik sticenik = null;
            List<Sticenik> listaSticenika = new List<Sticenik>();
            string sqlUpit = "SELECT *FROM Štićenici, Skrbitelji_Štićenici WHERE Štićenici.OIB_Štićenika=Skrbitelji_Štićenici.ŠtićenikOIB_Štićenika AND Skrbitelji_Štićenici.SrbiteljOIB_Skrbitelja='" + odabraniSkrbitelj+"'";
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                sticenik = new Sticenik(dr);
                listaSticenika.Add(sticenik);
            }
            dr.Close();
            return listaSticenika;
        }
        

    }
}

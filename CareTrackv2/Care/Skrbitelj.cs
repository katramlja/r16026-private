using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Windows.Forms;

namespace Care
{
    public class Skrbitelj
    {
        public string OIBSkrbitelja { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public bool Administrator { get; set; }
        public string ImeIPrezime
        {
            get
            {
                return Ime + " " + Prezime;
            }
            set { }
        }

        public Skrbitelj()
        {

        }
        public Skrbitelj(DbDataReader dr)
        {
            if (dr != null)
            {
                OIBSkrbitelja = dr["OIB_Skrbitelja"].ToString();
                Ime = dr["Ime"].ToString();
                Prezime = dr["Prezime"].ToString();
                Administrator = bool.Parse(dr["Administrator"].ToString());
                KorisnickoIme = dr["KorisničkoIme"].ToString();
                Lozinka = dr["Lozinka"].ToString();
                ImeIPrezime = Ime + " " + Prezime;
            }
        }
        public int Spremi()
        {
            string sqlUpit = "";
            sqlUpit = "SELECT OIB_Skrbitelja FROM Skrbitelji WHERE OIB_Skrbitelja = '" + OIBSkrbitelja + "'";
            SQLServer.Instance.DohvatiVrijednost(sqlUpit);
            if (SQLServer.Instance.DohvatiVrijednost(sqlUpit) == null)
            {
                sqlUpit = "INSERT INTO Skrbitelji (OIB_Skrbitelja, Ime, Prezime, Administrator,KorisničkoIme,Lozinka) VALUES ('" + OIBSkrbitelja + "','" + Ime + "','" + Prezime + "','" + Administrator + "','" + KorisnickoIme + "','" + Lozinka + "')";
            }
            else
            {
                sqlUpit = "UPDATE Skrbitelji SET Ime = '" + Ime 
                    + "',Prezime = '" + Prezime
                    + "',Administrator = '" + Administrator
                    + "',KorisničkoIme = '" + KorisnickoIme
                    + "',Lozinka = '" + Lozinka
                    + "'WHERE OIB_Skrbitelja= '" + OIBSkrbitelja + "'";
            }
            return SQLServer.Instance.IzvrsiUpit(sqlUpit);
        }
        public void Obrisi()
        {
            string sqlDelete = "DELETE FROM Skrbitelji_Štićenici WHERE SrbiteljOIB_Skrbitelja = '" + OIBSkrbitelja + "'";
            SQLServer.Instance.IzvrsiUpit(sqlDelete);


            sqlDelete = "DELETE FROM Skrbitelji WHERE OIB_Skrbitelja = '" + OIBSkrbitelja + "'";
            SQLServer.Instance.IzvrsiUpit(sqlDelete);
        }
        public static List<Skrbitelj> DohvatiSkrbiteljeOdSticenika(string oib)
        {
            List<Skrbitelj> lista = new List<Skrbitelj>();
            string sqlUpit = "SELECT * FROM Skrbitelji_Štićenici,Skrbitelji WHERE (Skrbitelji_Štićenici.ŠtićenikOIB_Štićenika= '" + oib + "' AND  Skrbitelji_Štićenici.SrbiteljOIB_Skrbitelja=Skrbitelji.OIB_Skrbitelja)";
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Skrbitelj s = new Skrbitelj(dr);
                lista.Add(s);
            }
            dr.Close();
            return lista;
        }

        public static List<Skrbitelj> DohvatiSkrbitelje()
        {
            List<Skrbitelj> lista = new List<Skrbitelj>();
            string sqlUpit = "SELECT * FROM Skrbitelji";
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Skrbitelj s = new Skrbitelj(dr);
                lista.Add(s);
            }
            dr.Close();
            return lista;
        }
    }
}

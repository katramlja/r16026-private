using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Care
{
    public class Soba
    {
        public Soba()
        {

        }
        public Soba(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_Sobe = int.Parse(dr["ID_Sobe"].ToString());
                Broj_sobe = int.Parse(dr["Broj_sobe"].ToString());
                Odjel = int.Parse((dr["OdjeliID_Odjela"].ToString()));
            }
        }
        
        public int ID_Sobe { get; set; }
        public int Broj_sobe { get; set; }
        public int Odjel { get; set; }
        public string ImeOdjela { get; set; }

        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_Sobe==0)
            {
                sqlUpit = "INSERT INTO Sobe (Broj_sobe, OdjeliID_Odjela) VALUES ('" + Broj_sobe + "','" + Odjel +"')";
            }
            else {
                sqlUpit = "UPDATE Sobe SET Broj_sobe = '" + Broj_sobe 
                    + "', OdjeliID_Odjela = '" + Odjel
                    +"' WHERE ID_Sobe= " + ID_Sobe;
            }
            return SQLServer.Instance.IzvrsiUpit(sqlUpit);
        }
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Sobe WHERE ID_Sobe = " + ID_Sobe;
            return SQLServer.Instance.IzvrsiUpit(sqlDelete);
        }
        public static List<Soba> DohvatiSobe(Odjel odabraniOdjel)
        {
            Soba soba = null;
            List<Soba> listaSoba = new List<Soba>();
            string sqlUpit = "SELECT * FROM Sobe WHERE OdjeliID_Odjela = " + odabraniOdjel.ID_Odjela;
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                soba = new Soba(dr);
                //soba.odjel = odabraniOdjel;
                listaSoba.Add(soba);
            }
            dr.Close();
            return listaSoba;
        }
        
        public static List<Soba> DohvatiSveSobe()
        {
            Soba soba = null;
            List<Soba> listaSoba = new List<Soba>();
            string sqlUpit = "SELECT * FROM Sobe, Odjeli WHERE Sobe.OdjeliID_Odjela = Odjeli.ID_Odjela";
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                soba = new Soba(dr);
                soba.ImeOdjela = dr["Naziv_Odjela"].ToString();
                listaSoba.Add(soba);
            }
            dr.Close();
            return listaSoba;
        }
       
        public static List<Soba> DohvatiSobeUOdjelu(string odabraniOdjel)
        {
            Soba soba = null;
            List<Soba> listaSoba = new List<Soba>();
            string sqlUpit = "SELECT * FROM Sobe WHERE OdjeliID_Odjela = " + odabraniOdjel;
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                soba = new Soba(dr);
                listaSoba.Add(soba);
            }
            dr.Close();
            return listaSoba;
        }
    }
}

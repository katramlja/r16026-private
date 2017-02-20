using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.Common;
using System.IO;

namespace Care
{
    public class Praćenje_dekubitusa
    {
        public int ID_Praćenja_dekubitusa { get; set; }
        //public Image Slika_dekubitusa { get; set; }
        public string Datum_nastanka { get; set; }
        public string Datum_prestanka { get; set; }
        public string Opis_dekubitusa { get; set; }
        public string Lokacija_dekubitusa { get; set; }
        public int DekubitusiID_Dekubitusa { get; set; }
        public string Slika { get; set; }

        public static byte[] poljeSlike = new byte[NoviDekubitus.duljinaZapisaSlikeDekubitus];
        public Praćenje_dekubitusa()
        {

        }
        public Praćenje_dekubitusa(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_Praćenja_dekubitusa = Convert.ToInt32(dr["ID_Praćenja_dekubitusa"]);
                Datum_nastanka = (dr["Datum_nastanka"]).ToString();
                Datum_prestanka = (dr["Datum_prestanka"]).ToString();
                Opis_dekubitusa = dr["Opis_dekubitusa"].ToString();
                Lokacija_dekubitusa = dr["Lokacija_dekubitusa"].ToString();
                DekubitusiID_Dekubitusa = Convert.ToInt32(dr["DekubitusiID_Dekubitusa"]);
                //Slika_dekubitusa = (dr["Slika_dekubitusa"]).ToString();
                Slika = dr["Slika"].ToString();
            }
        }
        public int Spremi(int IDdekubitusa)
        {
            string sqlUpit = "";
            sqlUpit = "SELECT ID_Praćenja_dekubitusa FROM Praćenje_dekubitusa WHERE ID_Praćenja_dekubitusa = '" + ID_Praćenja_dekubitusa + "'";
            if (SQLServer.Instance.DohvatiVrijednost(sqlUpit) == null)
            {
                sqlUpit = "INSERT INTO Praćenje_dekubitusa (Datum_nastanka, Slika, Opis_dekubitusa, Lokacija_dekubitusa,DekubitusiID_Dekubitusa) VALUES ('" + Datum_nastanka + "','" + Slika + "','" + Opis_dekubitusa + "','" + Lokacija_dekubitusa + "','" + IDdekubitusa + "')";
            }
            else 
            {
               // sqlUpit = "UPDATE Praćenje_dekubitusa SET Datum_prestanka = '" + Datum_prestanka + "' WHERE ID_Praćenja_dekubitusa=" + ID_Praćenja_dekubitusa;
            }
            return SQLServer.Instance.IzvrsiUpit(sqlUpit);
        }
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Praćenje_dekubitusa WHERE ID_Praćenja_dekubitusa = " + ID_Praćenja_dekubitusa;
            return SQLServer.Instance.IzvrsiUpit(sqlDelete);
        }
        public static List<Praćenje_dekubitusa> DohvatiPraćenjeDekubitusa(Sticenik sticenik)
        {
            List<Praćenje_dekubitusa> lista = new List<Praćenje_dekubitusa>();
            string sqlUpit = "SELECT * FROM Praćenje_dekubitusa,Dekubitusi WHERE Praćenje_dekubitusa.DekubitusiID_Dekubitusa=Dekubitusi.ID_Dekubitusa AND Dekubitusi.ŠtićeniciOIB_Štićenika='"+sticenik.OIBSticenika+"'";
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Praćenje_dekubitusa pd = new Praćenje_dekubitusa(dr);
                lista.Add(pd);
            }
            dr.Close();
            return lista;
        }
 /*       public static List<Praćenje_dekubitusa> DohvatiPraćenjePremaOIBu(string OIBSticenika) {
            List<Praćenje_dekubitusa> lista = new List<Praćenje_dekubitusa>();
            string sqlPitaj = "SELECT *FROM Praćenje_dekubitusa, Dekubitusi WHERE Praćenje_dekubitusa.DekubitusiID_Dekubitusa=Dekubitus.ID_Dekubitusa AND Dekubitus.ŠtićeniciOIB_Štićenika = '" + OIBSticenika +"'";
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlPitaj);
            while (dr.Read()) {
                Praćenje_dekubitusa pd = new Praćenje_dekubitusa();
                lista.Add(pd);
            }
            dr.Close();
            return lista;
        }*/

        public static List<Praćenje_dekubitusa> DohvatiDekubitusPoŠtićenikuIDatumu(Sticenik sticenik, DateTime datum)
        {
            List<Praćenje_dekubitusa> lista = new List<Praćenje_dekubitusa>();
            string sqlUpit = "SELECT * FROM Praćenje_dekubitusa, Dekubitusi WHERE Dekubitusi.ID_Dekubitusa = Praćenje_dekubitusa.DekubitusiID_Dekubitusa AND Dekubitusi.ŠtićeniciOIB_Štićenika = '" + sticenik.OIBSticenika + "' AND (DATEPART(yy, Datum_nastanka) = '" + datum.Year + "' AND DATEPART(mm, Datum_nastanka) = '" + datum.Month + "' AND DATEPART(dd, Datum_nastanka) = '" + datum.Day + "')";
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Praćenje_dekubitusa i = new Praćenje_dekubitusa(dr);
                lista.Add(i);
            }
            dr.Close();
            return lista;
        }
     
    }
}

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care
{
    public class Mjerenje
    {
        public int ID_Mjerenja { get; set; }
        public string DatumIVrijeme { get; set; }
        public bool Njega_tijela { get; set; }
        public bool Pelene { get; set; }
        public string Velika_nužda { get; set; }
        public string Količina_urina { get; set; }
        public float Tlak { get; set; }
        public float Šećer { get; set; }
        public float Puls { get; set; }
        public string Disanje { get; set; }
        public float Temperatura { get; set; }
        public string Bol { get; set; }
        public string ŠtićeniciOIB_Štićenika { get; set; }
        public Mjerenje()
        {

        }
        public Mjerenje(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_Mjerenja = Convert.ToInt32(dr["ID_Mjerenja"]);
                DatumIVrijeme = (dr["Datum_i_vrijeme"].ToString());
                Njega_tijela = bool.Parse(dr["Njega_tijela"].ToString());
                Pelene = bool.Parse(dr["Pelene"].ToString());
                Velika_nužda = dr["Velika_nužda"].ToString();
                Količina_urina = dr["Količina_urina"].ToString();
                Tlak = float.Parse(dr["Tlak"].ToString());
                Šećer =float.Parse(dr["Šećer"].ToString());
                Puls = float.Parse(dr["Puls"].ToString());
                Disanje = dr["Disanje"].ToString();
                Temperatura = float.Parse(dr["Temperatura"].ToString());
                Bol = dr["Bol"].ToString();
                ŠtićeniciOIB_Štićenika = (dr["ŠtićeniciOIB_Štićenika"]).ToString(); ;
            }
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_Mjerenja == 0) {
            //      sqlUpit = "SELECT ID_Mjerenja FROM Mjerenja WHERE ID_Mjerenja = '" + ID_Mjerenja + "'";
            //SQLServer.Instance.DohvatiVrijednost(sqlUpit);
            //if (SQLServer.Instance.DohvatiVrijednost(sqlUpit) == null)
            //{
                sqlUpit = "INSERT INTO Mjerenja (Datum_i_vrijeme, Njega_tijela, Pelene, Velika_nužda, Količina_urina, Tlak, Šećer, Puls, Disanje, Temperatura, Bol, ŠtićeniciOIB_Štićenika) VALUES ('" + DatumIVrijeme + "','" + Njega_tijela + "','" + Pelene + "','" + Velika_nužda + "','" + Količina_urina + "','" + Tlak + "','" + Šećer + "','" + Puls + "','" + Disanje + "','" + Temperatura + "','" + Bol + "','" + ŠtićeniciOIB_Štićenika + "')";

            }
            else {
                sqlUpit = "UPDATE Mjerenja SET Datum_i_vrijeme = '" + DatumIVrijeme
                    + "',Njega_tijela = '" + Njega_tijela
                    + "',Pelene = '" + Pelene
                    + "',Velika_nužda = '" + Velika_nužda
                    + "',Količina_urina = '" + Količina_urina
                    + "',Tlak = '" + Tlak
                    + "',Šećer = '" + Šećer
                    + "',Puls = '" + Puls
                    + "',Disanje = '" + Disanje
                    + "',Temperatura = '" + Temperatura
                    + "',ŠtićeniciOIB_Štićenika = '" + ŠtićeniciOIB_Štićenika 
                    + "' WHERE ID_Mjerenja = '" + ID_Mjerenja + "'";
            }
            return SQLServer.Instance.IzvrsiUpit(sqlUpit);
        }

        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Mjerenja WHERE ID_Mjerenja = '" + ID_Mjerenja + "'";
            return SQLServer.Instance.IzvrsiUpit(sqlDelete);
        }
        public static List<Mjerenje> DohvatiMjerenje(Sticenik OdabraniSticenik)
        {
            Mjerenje mjerenje1 = null;
            List<Mjerenje> listaMjerenja = new List<Mjerenje>();
            string sqlUpit = "SELECT * FROM Mjerenja WHERE ŠtićeniciOIB_Štićenika = '"+OdabraniSticenik.OIBSticenika+"'";
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                mjerenje1 = new Mjerenje(dr);

                listaMjerenja.Add(mjerenje1);
            }
            dr.Close();
            return listaMjerenja;
        }
        public static List<Mjerenje> DohvatiMjerenjePoDatumuISticeniku(Sticenik Sticenik,DateTime datum)
        {
            Mjerenje mjerenje1 = null;
            List<Mjerenje> listaMjerenja = new List<Mjerenje>();
            string sqlUpit = "SELECT * FROM Mjerenja WHERE ŠtićeniciOIB_Štićenika = '" + Sticenik.OIBSticenika + "' AND  (DATEPART(yy, Datum_i_vrijeme) = '" + datum.Year + "' AND DATEPART(mm, Datum_i_vrijeme) = '" + datum.Month + "' AND DATEPART(dd, Datum_i_vrijeme) = '" + datum.Day + "')";

            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                mjerenje1 = new Mjerenje(dr);
                listaMjerenja.Add(mjerenje1);
            }
            dr.Close();
            return listaMjerenja;
        }
        public static Mjerenje DohvatiMjerenjePoDatumuIOIBu_Sticeniku(string OIBSticenika, DateTime datum)
        {
            Mjerenje mjerenje = null;
            List<Mjerenje> listaMjerenja = new List<Mjerenje>();
            string sqlUpit = "SELECT * FROM Mjerenja WHERE ŠtićeniciOIB_Štićenika = '" + OIBSticenika + "' AND  (DATEPART(yy, Datum_i_vrijeme) = '" + datum.Year + "' AND DATEPART(mm, Datum_i_vrijeme) = '" + datum.Month + "' AND DATEPART(dd, Datum_i_vrijeme) = '" + datum.Day + "')";

            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            mjerenje = new Mjerenje(dr);
            return mjerenje;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care
{
    public class Lijekovi_Štićenici
    {
        public int ID_LijekoviŠtićenik { get; set; }
        public string Vrijeme_početka_terapije { get; set; }
        public string Vrijeme_prestanka_terapije { get; set; }
        public int Frekvencija_uzimanja_lijekova { get; set; }
        public int LijekoviID_Lijeka { get; set; }
        public string ŠtićeniciOIB_Štićenika { get; set; }

        public Lijekovi_Štićenici()
        {

        }
        public Lijekovi_Štićenici(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_LijekoviŠtićenik = Convert.ToInt32(dr["ID_LijekoviŠtićenik"]);
                Vrijeme_početka_terapije = (dr["Vrijeme_početka_terapije"].ToString());
                Vrijeme_prestanka_terapije = (dr["Vrijeme_prestanka_terapije"].ToString());
                Frekvencija_uzimanja_lijekova = Convert.ToInt32(dr["Frekvencija_uzimanja_lijekova"]);
                LijekoviID_Lijeka = Convert.ToInt32(dr["LijekoviID_Lijeka"]);
                ŠtićeniciOIB_Štićenika = Convert.ToString(dr["ŠtićeniciOIB_Štićenika"]);
            }
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_LijekoviŠtićenik == 0)
            {
                sqlUpit = "INSERT INTO Lijekovi_Štićenici (Vrijeme_početka_terapije, Vrijeme_prestanka_terapije, Frekvencija_uzimanja_lijekova, LijekoviID_Lijeka, ŠtićeniciOIB_Štićenika) VALUES ('" + Vrijeme_početka_terapije + "','" + Vrijeme_prestanka_terapije + "','" + Frekvencija_uzimanja_lijekova + "','" + LijekoviID_Lijeka + "','" + ŠtićeniciOIB_Štićenika + "')";
            }
            else {
                sqlUpit = "UPDATE Lijekovi_Štićenici SET Vrijeme_početka_terapije = '" + Vrijeme_početka_terapije 
                    +"', Vrijeme_prestanka_terapije = '" + Vrijeme_prestanka_terapije 
                    + "', Frekvencija_uzimanja_lijekova = '" + Frekvencija_uzimanja_lijekova
                    + "', LijekoviID_Lijeka = '" + LijekoviID_Lijeka 
                    + "', ŠtićeniciOIB_Štićenika = '" + ŠtićeniciOIB_Štićenika;
            }
            return SQLServer.Instance.IzvrsiUpit(sqlUpit);
        }
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Lijekovi_Štićenici WHERE ID_LijekoviŠtićenik = " + ID_LijekoviŠtićenik;
            return SQLServer.Instance.IzvrsiUpit(sqlDelete);
        }
        public static List<Lijekovi_Štićenici> DohvatiLijekoveŠtićenike()
        {
            List<Lijekovi_Štićenici> lista = new List<Lijekovi_Štićenici>();
            string sqlUpit = "SELECT * FROM Lijekovi_Štićenici";
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Lijekovi_Štićenici lš = new Lijekovi_Štićenici(dr);
                lista.Add(lš);
            }
            dr.Close();
            return lista;
        }
        public static List<Lijek> DohvatiLijekoveSticenika(string OIBodabranogSticenika)
        {
            string sqlOIB = "SELECT *FROM Lijekovi, Lijekovi_Štićenici WHERE Lijekovi.ID_Lijeka = Lijekovi_Štićenici.LijekoviID_Lijeka AND Lijekovi_Štićenici.ŠtićeniciOIB_Štićenika = '" + OIBodabranogSticenika + "'";
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlOIB);
            List<Lijek> listaLijekova = new List<Lijek>();
            while (dr.Read())
            {
                Lijek l = new Lijek(dr);
                listaLijekova.Add(l);
            }
            dr.Close();
            return listaLijekova;
        }
    }
}

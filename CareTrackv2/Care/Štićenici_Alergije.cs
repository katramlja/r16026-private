using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care
{
    class Štićenici_Alergije
    {
        public string ŠtićeniciOIB_Štićenika { get; set; }
        public int AlergijaID_Alergije { get; set; }
        public DateTime Datum_stjecanja_alergije { get; set; }
        public Štićenici_Alergije()
        {

        }
        public Štićenici_Alergije(DbDataReader dr)
        {
            if (dr != null)
            {
                ŠtićeniciOIB_Štićenika = Convert.ToString(dr["ŠtićeniciOIB_Štićenika"]);
                AlergijaID_Alergije = Convert.ToInt32(dr["AlergijaID_Alergije"]);
                Datum_stjecanja_alergije= Convert.ToDateTime(dr["Datum_stjecanja_alergije"]);
              
            }
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (Convert.ToInt32(ŠtićeniciOIB_Štićenika) == 0)
            {
                sqlUpit = "INSERT INTO Štićenici_Alergije (ŠtićeniciOIB_Štićenika, AlergijeID_Alergije, Datum_stjecanja_alergije) VALUES (" + ŠtićeniciOIB_Štićenika + "','" + AlergijaID_Alergije + "','" + Datum_stjecanja_alergije +")";
            }
            else {
                sqlUpit = "UPDATE Štićenici_Alergije SET ŠtićeniciOIB_Štićenika = '" + ŠtićeniciOIB_Štićenika +
                    "', AlergijeID_Alergije = '" + AlergijaID_Alergije + "', Datum_stjecanja_alergije = '" + Datum_stjecanja_alergije + ")";
            }
            return SQLServer.Instance.IzvrsiUpit(sqlUpit);
        }
        public int Obrisi()
        {
            string sqlUpit = "DELETE FROM Štićenici_Alergije WHERE ŠtićeniciOIB_Štićenika = " + ŠtićeniciOIB_Štićenika + "' AND AlergijeID_Alergije = '" + AlergijaID_Alergije;
            return SQLServer.Instance.IzvrsiUpit(sqlUpit);
        }
        public static List<Štićenici_Alergije> DohvatiAlergijeŠtićenika()
        {
            List<Štićenici_Alergije> lista = new List<Štićenici_Alergije>();
            string sqlUpit = "SELECT * FROM Štićenici_Alergije";
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Štićenici_Alergije ša = new Štićenici_Alergije(dr);
                lista.Add(ša);
            }
            dr.Close();
            return lista;
        }
    }
}

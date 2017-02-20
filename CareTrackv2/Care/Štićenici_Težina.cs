using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care
{
    public class Štićenici_Težina
    {
        public int ID_Težine { get; set; }
        public string Datum_mjerenja{ get; set; }
        public double Težina { get; set; }
        public string ŠtićeniciOIB_Štićenika { get; set; }
        public Štićenici_Težina()
        {

        }
        public Štićenici_Težina(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_Težine = Convert.ToInt32(dr["ID_Težine"]);
                Datum_mjerenja =dr["Datum_mjerenja"].ToString();
                Težina = Convert.ToDouble(dr["Težina"]);
                ŠtićeniciOIB_Štićenika = Convert.ToString(dr["ŠtićeniciOIB_Štićenika"]);
            }
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (Convert.ToInt32(ID_Težine) == 0)
            {
                sqlUpit = "INSERT INTO Štićenici_Težina (Datum_mjerenja, Težina, ŠtićeniciOIB_Štićenika) VALUES ('" + Datum_mjerenja + "','" + Težina + "','" + ŠtićeniciOIB_Štićenika + "')";
            }
            else {
                sqlUpit = "UPDATE Štićenici_Težina SET Datum_mjerenja = '" + Datum_mjerenja 
                    + "', Težina = '" + Težina 
                    + "', ŠtićeniciOIB_Štićenika = '" + ŠtićeniciOIB_Štićenika + "'";
            }
            return SQLServer.Instance.IzvrsiUpit(sqlUpit);
        }


        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Štićenici_Težina WHERE ID_Težine = " + ID_Težine;
            return SQLServer.Instance.IzvrsiUpit(sqlDelete);
        }
        public static List<Štićenici_Težina> DohvatiTežineŠtićenika()
        {
            List<Štićenici_Težina> lista = new List<Štićenici_Težina>();
            string sqlUpit = "SELECT * FROM Štićenici_Težina";
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Štićenici_Težina št = new Štićenici_Težina(dr);
                lista.Add(št);
            }
            dr.Close();
            return lista;
        }
       
    }
}

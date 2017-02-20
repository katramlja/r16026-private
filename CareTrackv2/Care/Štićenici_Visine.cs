using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care
{
    class Štićenici_Visine
    {
        public int ID_Visine { get; set; }
        public string Datum_mjerenja { get; set; }
        public double Visina { get; set; }
        public string ŠtićeniciOIB_Štićenika { get; set; }
        public Štićenici_Visine()
        {

        }
        public Štićenici_Visine(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_Visine = Convert.ToInt32(dr["ID_Visine"]);
                Datum_mjerenja = dr["Datum_mjerenja"].ToString();
                Visina = Convert.ToDouble(dr["Visina"]);
                ŠtićeniciOIB_Štićenika = Convert.ToString(dr["ŠtićeniciOIB_Štićenika"]);
            }
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (Convert.ToInt32(ID_Visine) == 0)
            {
                sqlUpit = "INSERT INTO Štićenici_Visine (Datum_mjerenja, Visina, ŠtićeniciOIB_Štićenika) VALUES ('" + Datum_mjerenja + "','" + Visina + "','" + ŠtićeniciOIB_Štićenika + "')";
            }
            else {
                sqlUpit = "UPDATE Štićenici_Težina SET Datum_mjerenja = '" + Datum_mjerenja
                    + "', Visina = '" + Visina
                    + "', ŠtićeniciOIB_Štićenika = '" + ŠtićeniciOIB_Štićenika + "'";
            }
            return SQLServer.Instance.IzvrsiUpit(sqlUpit);
        }


        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Štićenici_Visina WHERE ID_Težine = " + ID_Visine;
            return SQLServer.Instance.IzvrsiUpit(sqlDelete);
        }
        public static List<Štićenici_Visine> DohvatiVisineŠtićenika()
        {
            List<Štićenici_Visine> lista = new List<Štićenici_Visine>();
            string sqlUpit = "SELECT * FROM Štićenici_Visine";
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Štićenici_Visine šv = new Štićenici_Visine(dr);
                lista.Add(šv);
            }
            dr.Close();
            return lista;
        }
    }
}

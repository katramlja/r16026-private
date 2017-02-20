using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Care
{
    public class Alergija
    {
        public int ID_Alergije { get; set; }
        public string ImeAlergije { get; set; }

        public Alergija()
        {

        }
        public Alergija(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_Alergije = Convert.ToInt32(dr["ID_Alergije"]);
                ImeAlergije = dr["Alergija"].ToString();
            }
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (Convert.ToInt32(ID_Alergije) == 0)
            {
                sqlUpit = "INSERT INTO Alergije (ID_Alergije, Alergija) VALUES (null,'" + ImeAlergije + "')";
            }
            else {
                sqlUpit = "UPDATE Alergije SET Alergija = '" + ImeAlergije + "' WHERE ID_Alergije = " + ID_Alergije;
            }
            return SQLServer.Instance.IzvrsiUpit(sqlUpit);
        }
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Alergije WHERE ID_Alergije = " + ID_Alergije;
            return SQLServer.Instance.IzvrsiUpit(sqlDelete);
        }
        public static List<Alergija> DohvatiAlergije()
        {
            List<Alergija> lista = new List<Alergija>();
            string sqlUpit = "SELECT * FROM Alergije";
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Alergija a = new Alergija(dr);
                lista.Add(a);
            }
            dr.Close();
            return lista;
        }
    }
}

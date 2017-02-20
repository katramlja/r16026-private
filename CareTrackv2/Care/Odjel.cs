using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Care
{
    public class Odjel
    {
        public Odjel()
        {

        }

        public Odjel(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_Odjela = int.Parse(dr["ID_Odjela"].ToString());
                Naziv_odjela = dr["Naziv_odjela"].ToString();
            }
        }

        public int ID_Odjela { get; set; }
        public string Naziv_odjela { get; set; }

       
        
        public int Spremi()
        {
            string sqlUpit = "";
            if (Convert.ToInt32(ID_Odjela) == 0)
            {
                sqlUpit = "INSERT INTO Odjeli (Naziv_odjela) VALUES ('" + Naziv_odjela + "')";
            }
            else {
                sqlUpit = "UPDATE Odjeli SET Naziv_odjela = '" + Naziv_odjela 
                    + "' WHERE ID_Odjela = "+ ID_Odjela;
            }
            return SQLServer.Instance.IzvrsiUpit(sqlUpit);
        }
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Odjeli WHERE ID_Odjela = " + ID_Odjela;
            return SQLServer.Instance.IzvrsiUpit(sqlDelete);
        }
        public static List<Odjel> DohvatiOdjele()
        {
            List<Odjel> lista = new List<Odjel>();
            string sqlUpit = "SELECT * FROM Odjeli";
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Odjel s = new Odjel(dr);
                lista.Add(s);
            }
            dr.Close();
            return lista;
        }
    
}
}

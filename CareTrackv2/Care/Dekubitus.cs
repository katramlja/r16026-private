using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Care
{
    public class Dekubitus
    {
        public int ID_Dekubitusa { get; set; }
        public string ŠtićeniciOIB_Štićenika { get; set; }
        public string SkrbiteljiOIB_Skrbitelja { get; set; }
       
        public Dekubitus()
        {

        }
        public Dekubitus(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_Dekubitusa = Convert.ToInt32(dr["ID_Dekubitusa"]);
                ŠtićeniciOIB_Štićenika = Convert.ToString(dr["ŠtićeniciOIB_Štićenika"]);
                SkrbiteljiOIB_Skrbitelja = Convert.ToString(dr["SkrbiteljiOIB_Skrbitelja"]);
            }
        }
        public int Spremi()
        {
            string sqlUpit = "";
            sqlUpit = "SELECT ID_Dekubitusa FROM Dekubitusi WHERE ID_Dekubitusa = "+ID_Dekubitusa;
            if (SQLServer.Instance.DohvatiVrijednost(sqlUpit) == null)
            {
                sqlUpit = "INSERT INTO Dekubitusi (ŠtićeniciOIB_Štićenika, SkrbiteljiOIB_Skrbitelja) VALUES ('" + ŠtićeniciOIB_Štićenika + "','" + SkrbiteljiOIB_Skrbitelja + "')";
            }
            else
            {
                sqlUpit = "UPDATE Dekubitusi SET ŠtićeniciOIB_Štićenika = '" + ŠtićeniciOIB_Štićenika +
                    "', SkrbiteljiOIB_Skrbitelja = '" + SkrbiteljiOIB_Skrbitelja + "'";
            }
            return SQLServer.Instance.IzvrsiUpit(sqlUpit);
            
        }
        public int Obrisi()
        {
            string sqlUpit = "DELETE FROM Dekubitusi WHERE ID_Dekubitusa = " + ID_Dekubitusa;
            return SQLServer.Instance.IzvrsiUpit(sqlUpit);
        }


        public static List<Dekubitus> DohvatiDekubitus(Skrbitelj skrbitelj, Sticenik sticenik)
        {
            List<Dekubitus> lista = new List<Dekubitus>();
            string sqlUpit = "SELECT * FROM Dekubitusi WHERE Dekubitusi.SkrbiteljiOIB_Skrbitelja= '"+skrbitelj.OIBSkrbitelja+"' AND Dekubitusi.ŠtićeniciOIB_Štićenika= '"+sticenik.OIBSticenika+"'";
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Dekubitus d = new Dekubitus(dr);
                lista.Add(d);
            }
            dr.Close();
            return lista;
        }
    }
}

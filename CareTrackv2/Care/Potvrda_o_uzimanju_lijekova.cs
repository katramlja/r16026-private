using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care
{
    public class Potvrda_o_uzimanju_lijekova
    {
        public int ID_Potvrde_lijekova { get; set; }
        public DateTime Datum_potvrde { get; set; }
        public int Lijekovi_ŠtićeniciID_LijekoviŠtićenik{ get; set; }
        public bool potvrda_o_uzimanju_lijekova;

        public Potvrda_o_uzimanju_lijekova()
        {

        }
        public Potvrda_o_uzimanju_lijekova(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_Potvrde_lijekova = Convert.ToInt32(dr["ID_Potvrde_lijekova"]);
                Datum_potvrde = Convert.ToDateTime(dr["Datum_potvrde"]);
                Lijekovi_ŠtićeniciID_LijekoviŠtićenik = Convert.ToInt32(dr["Lijekovi_ŠtićeniciID_LijekoviŠtićenik"]);
                potvrda_o_uzimanju_lijekova = Convert.ToBoolean(dr["Potvrda_o_uzimanju_lijekova"]);
            }
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (Convert.ToInt32(ID_Potvrde_lijekova) == 0)
            {
                sqlUpit = "INSERT INTO Potvrda_o_uzimanju_lijekova (Datum_potvrde, Lijekovi_ŠtićeniciID_LijekoviŠtićenik, Potvrda_o_uzimanju_lijekova) VALUES (" + Datum_potvrde + "','" + Lijekovi_ŠtićeniciID_LijekoviŠtićenik + "','" + potvrda_o_uzimanju_lijekova + ")";
            }
            else {
                sqlUpit = "UPDATE Potvrda_o_uzimanju_lijekova SET Datum_potvrde = '" + Datum_potvrde +
                    "', Lijekovi_ŠtićeniciID_LijekoviŠtićenika = '" + Lijekovi_ŠtićeniciID_LijekoviŠtićenik + "', Potvrda_o_uzimanju_lijekova = '" + potvrda_o_uzimanju_lijekova + ")";
            }
            return SQLServer.Instance.IzvrsiUpit(sqlUpit);
        }
        public int Obrisi()
        {
            string sqlUpit = "DELETE FROM Potvrda_o_uzimanju_lijekova WHERE ID_Potvrde_lijekova = " + ID_Potvrde_lijekova;
            return SQLServer.Instance.IzvrsiUpit(sqlUpit);
        }
        public static List<Potvrda_o_uzimanju_lijekova> DohvatiPotvrdu()
        {
            List<Potvrda_o_uzimanju_lijekova> lista = new List<Potvrda_o_uzimanju_lijekova>();
            string sqlUpit = "SELECT * FROM Potvrda_o_uzimanju_lijekova";
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Potvrda_o_uzimanju_lijekova pol = new Potvrda_o_uzimanju_lijekova(dr);
                lista.Add(pol);
            }
            dr.Close();
            return lista;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Care
{
    public class Lijek
    {
        public int ID_Lijeka { get; set; }
        public string Naziv_lijeka { get; set; }
        public string Opis_i_primjena { get; set; }
        public string Proizvođač { get; set; }
        public Lijek()
        {

        }
        public Lijek(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_Lijeka = Convert.ToInt32(dr["ID_Lijeka"]);
                Naziv_lijeka = dr["Naziv_lijeka"].ToString();
                Opis_i_primjena = dr["Opis_i_primjena"].ToString();
                Proizvođač = dr["Proizvođač"].ToString();
            }
        }

        public int Spremi()
        {
            string sqlUpit = "";
            sqlUpit = "SELECT ID_Lijeka FROM Lijekovi WHERE ID_Lijeka = '" + ID_Lijeka + "'";
            SQLServer.Instance.DohvatiVrijednost(sqlUpit);
            if (SQLServer.Instance.DohvatiVrijednost(sqlUpit) == null)
            {
                sqlUpit = "INSERT INTO Lijekovi (Naziv_lijeka, Opis_i_primjena, Proizvođač) VALUES ('" + Naziv_lijeka + "','" + Opis_i_primjena + "','" + Proizvođač + "')";

            }
            else {
                sqlUpit = "UPDATE Lijekovi SET Naziv_lijeka = '" + Naziv_lijeka
                    + "', Opis_i_primjena = '" + Opis_i_primjena
                    + "', Proizvođač = '" + Proizvođač + "'WHERE ID_Lijeka = '" + ID_Lijeka+"'";


            }
            return SQLServer.Instance.IzvrsiUpit(sqlUpit);
        }

        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Lijekovi WHERE ID_Lijeka = '" + ID_Lijeka + "'";
            return SQLServer.Instance.IzvrsiUpit(sqlDelete);
        }
        public static List<Lijek> DohvatiLijekove()
        {
            Lijek lijek1 = null;
            List<Lijek> listaLijekova = new List<Lijek>();
            string sqlUpit = "SELECT * FROM Lijekovi";
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                lijek1 = new Lijek(dr);

                listaLijekova.Add(lijek1);
            }
            dr.Close();
            return listaLijekova;
        }
        public static List<Sticenik> DohvatiSticenikeUSobi(int odabranaSoba)
        {
            Sticenik sticenik = null;
            List<Sticenik> listaSticenika = new List<Sticenik>();
            string sqlUpit = "SELECT * FROM Štićenici WHERE SobeID_Sobe = " + odabranaSoba;
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                sticenik = new Sticenik(dr);

                listaSticenika.Add(sticenik);
            }
            dr.Close();
            return listaSticenika;
        }
    }
}

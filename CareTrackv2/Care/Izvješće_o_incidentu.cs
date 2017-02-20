using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care
{
    public class Izvješće_o_incidentu
    {
        public int ID_Izvješća { get; set; }
        public string Opis { get; set; }
        public string Vrijeme_početka_incidenta { get; set; }
        public string Vrijeme_završetka_incidenta { get; set; }
        public string ŠtićeniciOIB_Štićenika { get; set; }
        public string SkrbiteljiOIB_Skrbitelja { get; set; }

        public Izvješće_o_incidentu() {

        }
        public Izvješće_o_incidentu(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_Izvješća = int.Parse(dr["ID_Izvješća"].ToString());
                Opis = dr["Opis"].ToString();
                Vrijeme_početka_incidenta = dr["Vrijeme_početka_incidenta"].ToString();
                Vrijeme_završetka_incidenta = dr["Vrijeme_završetka_incidenta"].ToString();
                ŠtićeniciOIB_Štićenika = dr["ŠtićeniciOIB_Štićenika"].ToString();
                SkrbiteljiOIB_Skrbitelja = dr["SkrbiteljiOIB_Skrbitelja"].ToString();
            }
        }
        public int Spremi()
        {
            string sqlUpit = "";

            if (ID_Izvješća == 0)
            {
                sqlUpit = "INSERT INTO Izvješće_o_incidentu (Opis, Vrijeme_početka_incidenta, Vrijeme_završetka_incidenta, ŠtićeniciOIB_Štićenika, SkrbiteljiOIB_Skrbitelja) VALUES ('" + Opis + "','" + Vrijeme_početka_incidenta + "','" + Vrijeme_završetka_incidenta + "','" + ŠtićeniciOIB_Štićenika + "','" + SkrbiteljiOIB_Skrbitelja + "')";
            }
            else {
                sqlUpit = "UPDATE Izvješće_o_incidentu SET Opis = '" + Opis
                    + "', Vrijeme_početka_incidenta = '" + Vrijeme_početka_incidenta
                    + "', Vrijeme_završetka_incidenta = '" + Vrijeme_završetka_incidenta
                    + "', ŠtićeniciOIB_Štićenika = '" + ŠtićeniciOIB_Štićenika
                    + "', SkrbiteljiOIB_Skrbitelja = '" + SkrbiteljiOIB_Skrbitelja
                    + "' WHERE ID_Izvješća = " + ID_Izvješća;
            }
            return SQLServer.Instance.IzvrsiUpit(sqlUpit);
        }
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Izvješće_o_incidentu WHERE ID_Izvješća = " + ID_Izvješća;
            return SQLServer.Instance.IzvrsiUpit(sqlDelete);
        }
        public static List<Izvješće_o_incidentu> DohvatiIzvješćeOIncidentu(Sticenik sticenik)
        {
            List<Izvješće_o_incidentu> lista = new List<Izvješće_o_incidentu>();
            string sqlUpit = "SELECT * FROM Izvješće_o_incidentu WHERE ŠtićeniciOIB_Štićenika = '" + sticenik.OIBSticenika + "'";
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Izvješće_o_incidentu i = new Izvješće_o_incidentu(dr);
                lista.Add(i);
            }
            dr.Close();
            return lista;
        }

        public static List<Izvješće_o_incidentu> DohvatiIzvješćeOIncidentuPoDatumuISticeniku(Sticenik sticenik, DateTime datum)
        {
            List<Izvješće_o_incidentu> lista = new List<Izvješće_o_incidentu>();
            string sqlUpit = "SELECT * FROM Izvješće_o_incidentu WHERE ŠtićeniciOIB_Štićenika = '" + sticenik.OIBSticenika + "' AND (DATEPART(yy, Vrijeme_početka_incidenta) = '" + datum.Year + "' AND DATEPART(mm, Vrijeme_početka_incidenta) = '" + datum.Month + "' AND DATEPART(dd, Vrijeme_početka_incidenta) = '" + datum.Day + "')";
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Izvješće_o_incidentu i = new Izvješće_o_incidentu(dr);
                lista.Add(i);
            }
            dr.Close();
            return lista;
        }
        public static List<Izvješće_o_incidentu> DohvatiIzvješćeOIncidentuPoDatumNastanka(DateTime datumNastanka) {
            Izvješće_o_incidentu novo = null;
            List<Izvješće_o_incidentu> lista = new List<Izvješće_o_incidentu>();
            string sqlDohvati = "SELECT *FROM Izvješće_o_incidentu WHERE Vrijeme_početka_incidenta = '" + datumNastanka+"'";
            DbDataReader dr = SQLServer.Instance.DohvatiDataReader(sqlDohvati);
            while (dr.Read())
            {
                novo = new Izvješće_o_incidentu(dr);
                lista.Add(novo);
            }
            dr.Close();
            return lista;
        }
    }
}

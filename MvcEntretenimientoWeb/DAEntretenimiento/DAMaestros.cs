using BEEntities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAEntretenimiento
{
    public class DAMaestros: IDAMaestros
    {
        public static string GetConnectionString()
        {
            string connStr = ConfigurationManager.AppSettings.Get("mysqlconnection");

            return connStr;
        }

        public List<BEServicio> LeerServicios()
        {
            MySql.Data.MySqlClient.MySqlConnection mycon = new MySqlConnection(GetConnectionString());

            var servicio = new List<BEServicio>();

            try
            {
                mycon.Open();
                using (mycon)
                {
                    MySqlCommand cmd;
                    cmd = new MySqlCommand("select CoServicio,NoServicio from ent_familiar.servicio", mycon);
                    cmd.Prepare();
                    var reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        servicio.Add(new BEServicio() {  CoServicio = reader.GetInt32(0),  TxtDescripcion = reader.GetString(1) });
                    }


                }
            }
            catch (MySqlException ex)
            {
                throw (ex);
            }
            return servicio;
        }

      
        public List<BEClub> LeerClubs()
        {
            MySql.Data.MySqlClient.MySqlConnection mycon = new MySqlConnection(GetConnectionString());

            var clubs = new List<BEClub>();

            try
            {
                mycon.Open();
                using (mycon)
                {
                    MySqlCommand cmd;
                    cmd = new MySqlCommand("select CoClub,NoClub from ent_familiar.club", mycon);
                    cmd.Prepare();
                    var reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        clubs.Add(new BEClub() { CoClub = reader.GetInt32(0), NoClub = reader.GetString(1) });
                    }


                }
            }
            catch (MySqlException ex)
            {
                throw (ex);
            }
            return clubs;
        }

        public List<BEJuego> LeerJuegos()
        {
            MySql.Data.MySqlClient.MySqlConnection mycon = new MySqlConnection(GetConnectionString());

            var juegos = new List<BEJuego>();

            try
            {
                mycon.Open();
                using (mycon)
                {
                    MySqlCommand cmd;
                    cmd = new MySqlCommand("select CoJuego,NoJuego from ent_familiar.juego", mycon);
                    cmd.Prepare();
                    var reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        juegos.Add(new BEJuego() { CoJuego = reader.GetInt32(0),  TxtDescripcion  = reader.GetString(1) });
                    }   


                }
            }
            catch (MySqlException ex)
            {
                throw (ex);
            }
            return juegos;
        }
    
    
    }
}

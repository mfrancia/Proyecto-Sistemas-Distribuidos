using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using DAEntretenimiento;
using System.Data;

namespace DAEntretenimiento
{
    public class DASolicitudCompra : IDASolicitudCampo
    {
        public static string GetConnectionString()
        {
            string connStr = ConfigurationManager.AppSettings.Get("mysqlconnection");

            return connStr;
        }



        public void RegistrarSolicitudCampo(BEEntities.BESolicitudCampo besolicitudcampo)
        {
            MySql.Data.MySqlClient.MySqlConnection mycon = new MySqlConnection(GetConnectionString());

            try
            {
                mycon.Open();
                using (mycon)
                {
                    MySqlCommand cmd;
                    cmd = new MySqlCommand("insert into solicitud_dia_campo (CoResponsable,FeDiaCampo,NuTotalPersonas,CoClub) values (@codresponsable,@fecdiacampo,@totalpersonas,@coclub) ", mycon);
                    cmd.Parameters.AddWithValue("@codresponsable", besolicitudcampo.CoResponsable);
                    cmd.Parameters.AddWithValue("@fecdiacampo", besolicitudcampo.FeDiaCampo);
                    cmd.Parameters.AddWithValue("@totalpersonas", besolicitudcampo.NuTotalPersonas);
                    cmd.Parameters.AddWithValue("@coclub", besolicitudcampo.CoClub);
                    
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                throw (ex);
            }
        }
    }
}

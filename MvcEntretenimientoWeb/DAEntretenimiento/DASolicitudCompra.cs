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



        public int RegistrarSolicitudCampo(BEEntities.BESolicitudCampo besolicitudcampo)
        {
            MySql.Data.MySqlClient.MySqlConnection mycon = new MySqlConnection(GetConnectionString());
            long newid = 0;
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
                    newid = cmd.LastInsertedId;

                    
                }
            }
            catch (MySqlException ex)
            {
                throw (ex);
            }
            return (int)newid;
        }

        public void RegistrarServicioJuegoCampo(List<BEEntities.BEServicioCampo> listbeserviciocampo)
        {
            MySql.Data.MySqlClient.MySqlConnection mycon = new MySqlConnection(GetConnectionString());

            try
            {
                mycon.Open();
                using (mycon)
                {
                    MySqlCommand cmd;
                    int secuencia=1;
                    foreach (var beserviciocampo in listbeserviciocampo)
                    {
                        if (beserviciocampo.CoDiaCampo > 0)
                        {
                            cmd = new MySqlCommand("insert into detalle_dia_campo (CoDiaCampo,CoResponsable,NuSecuencia,NuPersonas,SsPrecioPersona,SsImporte,TxtComentario,CoServicio,CoJuego) values (@codcampo,@codresponsable,@nrosecuencia,@nropersonas,@preciopersona,@importe,@comentario,@codservicio,@codjuego) ", mycon);
                            cmd.Parameters.AddWithValue("@codcampo", beserviciocampo.CoDiaCampo);
                            cmd.Parameters.AddWithValue("@codresponsable", beserviciocampo.CoResponsable);
                            cmd.Parameters.AddWithValue("@nrosecuencia", beserviciocampo.NuSecuencia);
                            cmd.Parameters.AddWithValue("@nropersonas", beserviciocampo.NuPersonas);
                            cmd.Parameters.AddWithValue("@preciopersona", beserviciocampo.SsPrecioPersona);
                            cmd.Parameters.AddWithValue("@importe", beserviciocampo.NuPersonas * beserviciocampo.SsPrecioPersona);
                            cmd.Parameters.AddWithValue("@comentario", beserviciocampo.TxtComentario);
                            cmd.Parameters.AddWithValue("@codservicio", beserviciocampo.CoServicio);
                            cmd.Parameters.AddWithValue("@codjuego", beserviciocampo.CoJuego);

                            cmd.Prepare();

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw (ex);
            }
        }
    }
}

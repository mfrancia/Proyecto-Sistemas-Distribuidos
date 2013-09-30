using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using DAEntretenimiento;
using System.Data;
using BEEntities;

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
                    int preciojuego = 0;
                    int precioservicio = 0;
                    int preciojuegoxpoersona = 0;
                    int precioservicioxpersona = 0;
                    foreach (var beserviciocampo in listbeserviciocampo)
                    {
                        if (beserviciocampo.CoDiaCampo > 0)
                        {
                            MySqlCommand cmd;
                            MySqlCommand cmd1;
                            if (beserviciocampo.CoJuego != 0)
                            {
                                cmd1 = new MySqlCommand("select SsPrecio from Juego where CoJuego=@codjuego", mycon);
                                cmd1.Parameters.AddWithValue("@codjuego", beserviciocampo.CoJuego == 0 ? null : beserviciocampo.CoJuego);
                                cmd1.Prepare();
                                var reader1 = cmd1.ExecuteReader();


                                while (reader1.Read())
                                {
                                    preciojuego = preciojuego+reader1.GetInt32(0) * beserviciocampo.NuPersonas;
                                    preciojuegoxpoersona = reader1.GetInt32(0);
                                }
                                reader1.Close();
                                cmd1.Dispose();
                            }
                            MySqlCommand cmd2;
                            if (beserviciocampo.CoServicio != 0)
                            {
                                cmd2 = new MySqlCommand("select SsPrecio from Servicio where CoServicio=@codservicio", mycon);
                                cmd2.Parameters.AddWithValue("@codservicio", beserviciocampo.CoServicio == 0 ? null : beserviciocampo.CoServicio);
                                cmd2.Prepare();
                                var reader = cmd2.ExecuteReader();


                                while (reader.Read())
                                {
                                    precioservicio = precioservicio + reader.GetInt32(0) * beserviciocampo.NuPersonas;
                                    precioservicioxpersona = reader.GetInt32(0);
                                }
                                reader.Close();
                                cmd2.Dispose();
                            }
                          
                            cmd = new MySqlCommand("insert into detalle_dia_campo (CoDiaCampo,CoResponsable,NuSecuencia,NuPersonas,SsPrecioPersona,SsImporte,TxtComentario,CoServicio,CoJuego) values (@codcampo,@codresponsable,@nrosecuencia,@nropersonas,@preciopersona,@importe,@comentario,@codservicio,@codjuego) ", mycon);
                            cmd.Parameters.AddWithValue("@codcampo", beserviciocampo.CoDiaCampo);
                            cmd.Parameters.AddWithValue("@codresponsable", beserviciocampo.CoResponsable);
                            cmd.Parameters.AddWithValue("@nrosecuencia", beserviciocampo.NuSecuencia);
                            cmd.Parameters.AddWithValue("@nropersonas", beserviciocampo.NuPersonas);
                            cmd.Parameters.AddWithValue("@preciopersona", beserviciocampo.CoJuego != 0 ? preciojuegoxpoersona : precioservicioxpersona);
                            cmd.Parameters.AddWithValue("@importe", beserviciocampo.CoJuego != 0 ? preciojuego : precioservicio);
                            cmd.Parameters.AddWithValue("@comentario", beserviciocampo.TxtComentario);
                            cmd.Parameters.AddWithValue("@codservicio", beserviciocampo.CoServicio==0?null:beserviciocampo.CoServicio);
                            cmd.Parameters.AddWithValue("@codjuego", beserviciocampo.CoJuego==0?null:beserviciocampo.CoJuego);

                            cmd.Prepare();

                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                        }
                    }

                    MySqlCommand cmd3;
                    if (listbeserviciocampo.Count> 0)
                    {
                        cmd3 = new MySqlCommand("update solicitud_dia_campo set SsImporteTotal = @importetotal where CoDiaCampo=@codiacampo and coResponsable=@coresponsable", mycon);
                        cmd3.Parameters.AddWithValue("@importetotal", preciojuego + precioservicio);
                        cmd3.Parameters.AddWithValue("@codiacampo", listbeserviciocampo[0].CoDiaCampo);
                        cmd3.Parameters.AddWithValue("@coresponsable", listbeserviciocampo[0].CoResponsable);
                        cmd3.Prepare();
                        cmd3.ExecuteNonQuery();
                        cmd3.Dispose();
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

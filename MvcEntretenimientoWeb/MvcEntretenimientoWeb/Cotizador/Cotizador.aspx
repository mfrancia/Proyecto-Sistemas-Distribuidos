<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cotizador.aspx.cs" Inherits="MvcEntretenimientoWeb.Cotizador.Cotizador" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>detCotizacion</title>
		
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">

    <link href="../Scripts_Jquery/Menu_new.css" rel="stylesheet" />

</head>
<body>

    <form id="form1" runat="server">
    <div align="center">        

                    <table width="100%">
                    <tr>
                        <td align="center"> 
                            <table style="width:95%;">
                                <tr>
                                    <td></td>

                                </tr>
                                <tr>
                                    <td>
                                    <table id="Table1" cellspacing="0" cellpadding="0" width="100%" border="0">
	                                    <tr>
		                                    <td valign="top" width="60%">
			                                    <table id="Table2" cellspacing="0" cellpadding="0" border="0">
				                                    <tr>
					                                    <td>

						                                    <span id="UCCabecera1_lblTitulo" class="textoTitulo">SOLICITUD DE COTIZACIÓN</span></td>
				                                    </tr>
				
				                                    <tr>
					                                    <td>
						                                    <span id="UCCabecera1_lblSubSubtitulo" class="textoSubtitulo"></span></td>
				                                    </tr>
			                                    </table>
		                                    </td>

		                                    <td valign="top" width="40%" align="right">
			                                    <table width="70%">
				                                    <tr>
					                                    <td class="textoLabel">
						                                    <span id="UCCabecera1_lblEtiquetaAfiliado">Afiliado : </span>
						                                    <span id="UCCabecera1_lblAfiliado" class="textoContenido">  <asp:Label ID="lblAfiliado" runat="server" Text="Label"/>   </span></td>
				                                    </tr>

				                                    <tr>
					                                    <td class="textoLabel">
						                                    <span id="UCCabecera1_lblEtiquetaCaso">N° DNI : </span>
						                                    <span id="UCCabecera1_lblCaso" class="textoContenido">
                                                                <asp:Label ID="lblDNI" runat="server" Text="Label"/> </span></td>
				                                    </tr>			
				
			                                </table>
		                                </td>
	                                </tr>
                                </table>

            </td>
                                </tr>
                                <tr>
                                    <td width="100%" style="height:22px;" class="barramenu">
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>

                </table>

                    <table id="Table4" border="0" cellspacing="1" cellpadding="1" width="95%">
                        <tr>
                            <td align="right"></td>
                        </tr>
                    </table>

                    <table class="tabla" width="95%">
							<tr>
								<td class="textoLabel" width="25%">Tipo Cotización :</td>
								<td width="25%"><span id="lblTipoCotizacion" class="textoContenido">Oficial</span></td>

								<td class="campo1" width="25%"></td>
								<td width="25%"></td>
							</tr>
							<tr>
								<td class="campo1" width="25%"></td>
								<td width="25%"></td>
								<td class="campo1" width="25%"></td>
								<td width="25%"></td>
							</tr>

					</table>
                    
                    <br />

                    <table class="tabla" width="95%">
						<tr>
                            <td align="center" width="100%" colspan="4" class="barramenu"><b class="subtituloNuevo">Solicitud de cotización</b>
                            </td>
						</tr>
						<tr>
							<td><font class="textoLabel">Nombre(s) del Solicitante :</font></td>

							<td><font class="textoContenido"><span id="lblNombre" class="textoContenido">
                                <asp:Label ID="lblAfiliado2" runat="server" Text="Label"/>                
                            </span></font></td>
							<td class="textoLabel"></td>
							<td><font class="textoContenido"></font></td>
						</tr>
						<tr>
							<td class="textoLabel" width="25%">Apellido Paterno Solicitante :</td>
							<td width="25%"><font class="textoContenido"><span id="lblApePaterno" class="textoContenido"><asp:Label ID="lblPaterno" runat="server" Text="Label"/> </span></font></td>

							<td class="textoLabel" width="25%">Apellido Materno Solicitante :</td>
							<td width="25%"><font class="textoContenido"><span id="lblApeMaterno" class="textoContenido"><asp:Label ID="lblMaterno" runat="server" Text="Label"/>                     </span></font></td>
						</tr>
						<tr>
							<td class="textoLabel">Fecha Solicitud :</td>
							<td><font class="textoContenido"><span id="lblFecSolicitud" class="textoContenido"><asp:Label ID="lblFechaSolicitud" runat="server" Text="Label"/></span></font></td>
						</tr>

						
						<tr>
							<td class="textoLabel">Fecha de Recepción :</td>
							<td><font class="textoContenido"><span id="lblFecRecepcion" class="textoContenido"><asp:Label ID="lblFechaRecepcion" runat="server" Text="Label"/></span></font></td>
						</tr>
						<tr>
							
							<td class="textoLabel">Tipo de Cambio :</td>
							<td><font class="textoContenido"><asp:Label ID="lblTipoCambio" runat="server" Text="Label"/></font></td>

						</tr>
						<tr>
							<td class="textoLabel">Número de Operación :</td>
							<td><span id="lblNumOper" class="textoContenido"><asp:Label ID="lblNumeroOperacion" runat="server" Text="Label"/></span></td>							
						</tr>
					

					</table>
                    
                    <br />

                    <table class="tabla" width="95%">
                    	<tr>

                            <td align="center" width="100%" colspan="4" class="barramenu"><b class="subtituloNuevo">Servicios Cotizados</b>
                            </td>
						</tr>
                        <tr>
                            <td>
                                <asp:GridView ID="gvServicios" TabIndex="-1" AllowSorting="True" runat="server" 
                                Width="100%" CssClass="tabla" CellSpacing="1" CellPadding="3"  AutoGenerateColumns="False">
                                 <RowStyle HorizontalAlign="Center" CssClass="textoContenido" />
                                 <HeaderStyle HorizontalAlign="Center" CssClass="barramenu" />
                                 <AlternatingRowStyle HorizontalAlign="Center" CssClass="tablaFila" />
                                <Columns>
                                    <asp:BoundField DataField="numero" HeaderText="N°" />
                                    <asp:BoundField DataField="servicio" HeaderText="Servicio" />
                                    <asp:BoundField DataField="numeroPersonas" HeaderText="Cantidad" />
                                    <asp:BoundField DataField="precioPorPersona" HeaderText="Precio Unitario" />
                                    <asp:BoundField DataField="importe" HeaderText="Precio Total" />
                                </Columns>
                                 </asp:GridView>

                            </td>
                        </tr>                       
                    </table>

                    <br />

                    <table class="tabla" width="95%">
                        <tr>
                            <td align="right">

                                 <span id="Span1" class="textoContenido">
                                            Total Servicios: 
                                            <asp:Label ID="lblTotalServicio" runat="server" Text="Label" />

                                        </span> 
                            </td>
                        </tr>
                    </table>

                    <br />

                    <table class="tabla" width="95%">
                    	<tr>

                            <td align="center" width="100%" colspan="4" class="barramenu"><b class="subtituloNuevo">Juegos Cotizados</b>
                            </td>
						</tr>
                        <tr>
                            <td>
                                <asp:GridView ID="gvJuegos" TabIndex="-1" AllowSorting="True" runat="server" 
                                Width="100%" CssClass="tabla" CellSpacing="1" CellPadding="3"  AutoGenerateColumns="False">
                                 <RowStyle HorizontalAlign="Center" CssClass="textoContenido" />
                                 <HeaderStyle HorizontalAlign="Center" CssClass="barramenu" />
                                 <AlternatingRowStyle HorizontalAlign="Center" CssClass="tablaFila" />
                                <Columns>
                                    <asp:BoundField DataField="numero" HeaderText="N°" />
                                    <asp:BoundField DataField="juego" HeaderText="Juegos" />
                                    <asp:BoundField DataField="numeroPersonas" HeaderText="Cantidad" />
                                    <asp:BoundField DataField="precioPorPersona" HeaderText="Precio Unitario" />
                                    <asp:BoundField DataField="importe" HeaderText="Precio Total" />
                                </Columns>
                                 </asp:GridView>

                            </td>
                        </tr>                        
                    </table>        
        
                    <br />
        
                    <table class="tabla" width="95%">
                        <tr>
                            <td align="right">
                                  <span id="Span2" class="textoContenido">
                                Total Juegos: 
                                <asp:Label ID="lblTotalJuegos" runat="server" Text="Label" />

                                    </span> 
                            </td>
                        </tr>
                    </table>         

                    <br />

                    <table class="tabla" width="95%">
                        <tr>
                            <td align="right">
                                  <span id="Span3" class="textoContenido">
                                    Total Cotizacion: 
                                    <asp:Label ID="lblTotalCotizacion"  runat="server" Text="Label" />
                                   </span> 
                            </td>
                        </tr>
                    </table>       

     </div>
    </form>

</body>
</html>

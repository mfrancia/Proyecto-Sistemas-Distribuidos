'Imports System.Data.SqlClient
'Imports MySQLDriverCS
Imports MySql.Data.MySqlClient
Module Module1
    'Public cn As New MySQLConnection("server=.;initial catalog=Sistema Integrado;uid=Felipe;password=Ramos")
    'Public cn As New MySQLConnectionString("Server=localhost;user=root;database=ent_familiar;port=3306;pwd=root;")
    '(New MySQLConnectionString("localhost", "ent_familiar", "root", "root", 3306).AsString)
    Public cn As New MySqlConnection("Server=localhost;Uid=root;Pwd=francia;Database=ent_familiar;")
    Public dt_pla As New DataTable, nom_cat_prod As String, tip_cat As Byte
    Public foco_cambios As Boolean
    Public tipo_usuario As Integer = 0
    Public codigo_usuario As Integer = 0
End Module


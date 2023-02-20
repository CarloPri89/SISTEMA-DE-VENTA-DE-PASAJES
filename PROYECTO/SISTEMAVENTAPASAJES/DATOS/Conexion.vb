Imports System.Data.SqlClient
Public Class Conexion
    Public Cn As New SqlConnection
    Public Cmd As New SqlCommand
    Public Dr As SqlDataReader
    Public nombre, codigo, nivel As String
    Public Sub Abrir()
        Try
            Cn.ConnectionString = "Data Source=DESKTOP-03JJ853\SQLEXPRESS;Initial Catalog=BDVENTAPASAJES;Integrated Security=True"
            Cn.Open()
            Cmd.Connection = Cn
            Cmd.CommandType = CommandType.StoredProcedure
        Catch ex As Exception

        End Try

    End Sub
    Public Sub Cerrar()
        Try
            Cn.Close()
            Cmd.Parameters.Clear()
        Catch ex As Exception

        End Try

    End Sub
End Class

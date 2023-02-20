
Imports System.Windows.Forms

Public Class Procesos
    Public objcnt As New Conexion

    Public Structure bus
        Dim codbus As String
        Dim modbus As String
        Dim placabus As String
        Dim capbus As Integer
    End Structure
    Public Function insertabus(ByVal st As bus) As Boolean
        Dim opc As Boolean
        Try
            With objcnt
                .Abrir()
                .Cmd.CommandText = "SP_ingresarbus"
                .Cmd.Parameters.AddWithValue("@cod_bus", st.codbus)
                .Cmd.Parameters.AddWithValue("@mod_bus", st.modbus)
                .Cmd.Parameters.AddWithValue("@placa_bus", st.placabus)
                .Cmd.Parameters.AddWithValue("@cap_bus", st.capbus)

                Dim i As Integer = .Cmd.ExecuteNonQuery
                opc = IIf(i > 0, True, False)

                MsgBox("BUS REGISTRADO EXITOSAMENTE", 64, "Sistema")
                .Cerrar()
            End With

        Catch ex As Exception
            opc = False
        End Try
        Return opc

    End Function
    Public Function modificarbus(ByVal st As bus) As Boolean
        Dim opc As Boolean
        Try
            With objcnt
                .Abrir()
                .Cmd.CommandText = "SP_Actualizarbus"
                .Cmd.Parameters.AddWithValue("@cod_bus", st.codbus)
                .Cmd.Parameters.AddWithValue("@mod_bus", st.modbus)
                .Cmd.Parameters.AddWithValue("@placa_bus", st.placabus)
                .Cmd.Parameters.AddWithValue("@cap_bus", st.capbus)

                Dim i As Integer = .Cmd.ExecuteNonQuery
                opc = IIf(i > 0, True, False)

                MsgBox("BUS ACTUALIZADO EXITOSAMENTE", 64, "Sistema")
                .Cerrar()
            End With

        Catch ex As Exception
            opc = False
        End Try
        Return opc

    End Function

    Public Function eliminarbus(ByVal st As bus) As Boolean
        Dim opc As Boolean
        Try
            With objcnt
                .Abrir()
                .Cmd.CommandText = "SP_eliminarbus"
                .Cmd.Parameters.AddWithValue("@cod_bus", st.codbus)

                Dim i As Integer = .Cmd.ExecuteNonQuery
                opc = IIf(i > 0, True, False)

                MsgBox("BUS ELIMINADO EXITOSAMENTE", 64, "Sistema")
                .Cerrar()
            End With

        Catch ex As Exception
            opc = False
        End Try
        Return opc

    End Function

    Public Structure cliente
        Dim codcliente As String
        Dim dni As String
        Dim apaterno As String
        Dim amaterno As String
        Dim nombres As String
        Dim edad As String
        Dim sexo As String
        Dim email As String
        Dim fono As String
    End Structure

    Public Function insertarcliente(ByVal st As cliente) As Boolean
        Dim opc As Boolean
        Try

            With objcnt
                .Abrir()
                .Cmd.CommandText = "SP_ingresarcliente"
                .Cmd.Parameters.AddWithValue("@cod_clie", st.codcliente)
                .Cmd.Parameters.AddWithValue("@dni_clie", st.dni)
                .Cmd.Parameters.AddWithValue("@apelp_clie", st.apaterno)
                .Cmd.Parameters.AddWithValue("@apelm_clie", st.amaterno)
                .Cmd.Parameters.AddWithValue("@nomb_clie", st.nombres)
                .Cmd.Parameters.AddWithValue("@edad_clie", st.edad)
                .Cmd.Parameters.AddWithValue("@sexo_clie", st.sexo)
                .Cmd.Parameters.AddWithValue("@email", st.email)
                .Cmd.Parameters.AddWithValue("@fono", st.fono)

                Dim i As Integer = .Cmd.ExecuteNonQuery
                opc = IIf(i > 0, True, False)

                MsgBox("CLIENTE REGISTRADO EXITOSAMENTE", 64, "Sistema")
                .Cerrar()
            End With

        Catch ex As Exception
            opc = False
        End Try
        Return opc

    End Function

    Public Function modificarcliente(ByVal st As cliente) As Boolean
        Dim opc As Boolean
        Try
            With objcnt
                .Abrir()
                .Cmd.CommandText = "SP_Actualizarcliente"
                .Cmd.Parameters.AddWithValue("@cod_clie", st.codcliente)
                .Cmd.Parameters.AddWithValue("@dni_clie", st.dni)
                .Cmd.Parameters.AddWithValue("@apelp_clie", st.apaterno)
                .Cmd.Parameters.AddWithValue("@apelm_clie", st.amaterno)
                .Cmd.Parameters.AddWithValue("@nomb_clie", st.nombres)
                .Cmd.Parameters.AddWithValue("@edad_clie", st.edad)
                .Cmd.Parameters.AddWithValue("@sexo_clie", st.sexo)
                .Cmd.Parameters.AddWithValue("@email", st.email)
                .Cmd.Parameters.AddWithValue("@fono", st.fono)

                Dim i As Integer = .Cmd.ExecuteNonQuery
                opc = IIf(i > 0, True, False)

                MsgBox("DATOS DEL CLIENTE ACTUALIZADOS EXITOSAMENTE", 64, "Sistema")
                .Cerrar()
            End With

        Catch ex As Exception
            opc = False
        End Try
        Return opc

    End Function

    Public Function eliminarcliente(ByVal st As cliente) As Boolean
        Dim opc As Boolean
        Try
            With objcnt
                .Abrir()
                .Cmd.CommandText = "SP_eliminarcliente"
                .Cmd.Parameters.AddWithValue("@cod_clie", st.codcliente)

                Dim i As Integer = .Cmd.ExecuteNonQuery
                opc = IIf(i > 0, True, False)

                MsgBox("REGISTRO ELIMINADO EXITOSAMENTE", 64, "Sistema")
                .Cerrar()
            End With

        Catch ex As Exception
            opc = False
        End Try
        Return opc

    End Function

    Public Structure Venta
        Dim codventa As String
        Dim fechaventa As Date
        Dim idprogramacion As String
        Dim iduser As String
        Dim numasiento As String
        Dim idcliente As String
        Dim importe As String
        Dim fechaviaje As Date
    End Structure

    Public Function RegistrarVenta(ByVal st As Venta) As Boolean
        Dim opc As Boolean
        Try

            With objcnt
                .Abrir()
                .Cmd.CommandText = "SP_REGISTRAR_VENTA"
                .Cmd.Parameters.AddWithValue("@codventa", st.codventa)
                .Cmd.Parameters.AddWithValue("@fecha_venta", st.fechaventa)
                .Cmd.Parameters.AddWithValue("@id_prog", st.idprogramacion)
                .Cmd.Parameters.AddWithValue("@iduser", st.iduser)
                .Cmd.Parameters.AddWithValue("@numasiento", st.numasiento)
                .Cmd.Parameters.AddWithValue("@idcliente", st.idcliente)
                .Cmd.Parameters.AddWithValue("@importe", st.importe)
                .Cmd.Parameters.AddWithValue("@fechaviaje", st.fechaviaje)

                Dim i As Integer = .Cmd.ExecuteNonQuery
                opc = IIf(i > 0, True, False)

                MsgBox("VENTA REGISTRADA EXITOSAMENTE", 64, "GRACIAS..!!!")
                .Cerrar()
            End With

        Catch ex As Exception
            opc = False
        End Try
        Return opc

    End Function

End Class

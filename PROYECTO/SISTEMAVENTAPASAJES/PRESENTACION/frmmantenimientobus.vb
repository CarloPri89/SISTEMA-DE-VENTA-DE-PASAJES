Imports DATOS
Imports Negocio
Public Class frmmantenimientobus
    Dim objcn As New Conexion
    Dim WithEvents app As New Validacion
    Dim reg As New Procesos.bus



    Dim cod, codi As String
    Dim codbus As Integer
    Sub obtncodbus()
        With objcn
            .Abrir()
            .Cmd.CommandText = "obtcodigoBus"
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                cod = .Dr("cod_bus")
                codi = cod.Substring(1, 4).ToString
                codbus = (codi + 1)
                txtcodigo.Text = "B" & Format(codbus, "#0000")
            End While
            .Cerrar()
        End With
    End Sub
    Sub listarbus()
        Me.dgbus.Rows.Clear()

        With objcn
            .Abrir()
            .Cmd.CommandText = "listadoBus"
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                Me.dgbus.Rows.Add(dgbus.RowCount, .Dr(0), .Dr(1), .Dr(2), .Dr(3))
            End While

            .Cerrar()
        End With
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        Try
            If txtmodelo.Text = "" Then
                MsgBox("Ingrese el Modelo", 64, "AVISO!!!")
                txtmodelo.Focus()
            ElseIf txtplaca.Text = "" Then
                MsgBox("Ingrese el N° placa", 64, "AVISO!!!")
                txtplaca.Focus()
            ElseIf txtcapacidad.Text = "" Then
                MsgBox("Ingrese la capacidad", 64, "AVISO!!!")
                txtcapacidad.Focus()
            Else
                If (MsgBox("¿ESTÁ SEGURO DE REGISTRAR ESTE BUS?", 36, "Sistema") = 6) Then
                    With reg

                        .codbus = txtcodigo.Text
                        .modbus = txtmodelo.Text.ToUpper
                        .placabus = txtplaca.Text.ToUpper
                        .capbus = txtcapacidad.Text
                        app.insertarbus(reg)
                        listarbus()
                    End With
                Else
                    MsgBox("REGISTRO NO INGRESADO", 64, "AVISO!!!")
                    listarbus()
                End If
                limpiar()
            End If


        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmmantenimientobus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarbus()
    End Sub

    Sub limpiar()
        txtcodigo.ResetText()
        txtcapacidad.ResetText()
        txtmodelo.ResetText()
        txtplaca.ResetText()
        obtncodbus()
        txtmodelo.Focus()
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        ACTIVARTEXTOS(False)
        btnguardar.Enabled = True
    End Sub
    Sub ACTIVARTEXTOS(EST)
        txtmodelo.ReadOnly = EST
        txtplaca.ReadOnly = EST
        txtcapacidad.ReadOnly = EST
    End Sub
    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        btnguardar.Enabled = False
        btnactualizar.Visible = True
        ACTIVARTEXTOS(False)
        btneditar.Visible = False
    End Sub

    Private Sub btnelimminar_Click(sender As Object, e As EventArgs) Handles btnelimminar.Click
        Try
            If txtmodelo.Text = "" Then
                MsgBox("Ingrese el Modelo", 64, "AVISO!!!")
                txtmodelo.Focus()
            ElseIf txtplaca.Text = "" Then
                MsgBox("Ingrese el N° placa", 64, "AVISO!!!")
                txtplaca.Focus()
            ElseIf txtcapacidad.Text = "" Then
                MsgBox("Ingrese la capacidad", 64, "AVISO!!!")
                txtcapacidad.Focus()
            Else
                If (MsgBox("¿ESTÁ SEGURO DE ELIMINAR  ESTE BUS?", 36, "Sistema") = 6) Then
                    With reg

                        .codbus = txtcodigo.Text
                        app.eliminarbus(reg)
                        listarbus()
                    End With
                Else
                    MsgBox("REGISTRO NO ELIMINADO", 64, "AVISO!!!")
                    listarbus()
                End If
                limpiar()
                btnguardar.Enabled = False
            End If


        Catch ex As Exception

        End Try
        btnactualizar.Visible = False
        ACTIVARTEXTOS(True)
        btneditar.Visible = True
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Close()
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click

        Try
            If txtmodelo.Text = "" Then
                MsgBox("Ingrese el Modelo", 64, "AVISO!!!")
                txtmodelo.Focus()
            ElseIf txtplaca.Text = "" Then
                MsgBox("Ingrese el N° placa", 64, "AVISO!!!")
                txtplaca.Focus()
            ElseIf txtcapacidad.Text = "" Then
                MsgBox("Ingrese la capacidad", 64, "AVISO!!!")
                txtcapacidad.Focus()
            Else
                If (MsgBox("¿ESTÁ SEGURO DE MODIFICAR DATOS DE ESTE BUS?", 36, "Sistema") = 6) Then
                    With reg

                        .codbus = txtcodigo.Text
                        .modbus = txtmodelo.Text.ToUpper
                        .placabus = txtplaca.Text.ToUpper
                        .capbus = txtcapacidad.Text
                        app.modificarbus(reg)
                        listarbus()
                    End With
                Else
                    MsgBox("REGISTRO NO MODIFICADO", 64, "AVISO!!!")
                    listarbus()
                End If
                limpiar()
                btnguardar.Enabled = False
            End If


        Catch ex As Exception

        End Try
        btnactualizar.Visible = False
        ACTIVARTEXTOS(True)
        btneditar.Visible = True
    End Sub

    Private Sub dgbus_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgbus.CellContentClick
        btneditar.Enabled = True
        btnelimminar.Enabled = True
        btnguardar.Enabled = False
        ACTIVARTEXTOS(True)
    End Sub


    Private Sub dgbus_SelectionChanged(sender As Object, e As EventArgs) Handles dgbus.SelectionChanged
        Try
            With objcn
                If dgbus.SelectedRows.Count > 0 Then
                    txtcodigo.Text = dgbus.Item(1, dgbus.SelectedRows(0).Index).Value
                    txtmodelo.Text = dgbus.Item(2, dgbus.SelectedRows(0).Index).Value
                    txtplaca.Text = dgbus.Item(3, dgbus.SelectedRows(0).Index).Value
                    txtcapacidad.Text = dgbus.Item(4, dgbus.SelectedRows(0).Index).Value
                End If
            End With
        Catch ex As Exception

        End Try



    End Sub
End Class
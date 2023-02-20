Imports System.Windows.Forms
Imports DATOS
Imports Negocio
Public Class frmProgramacion
    Dim objcn As New Conexion
    Sub horas()
        cbohorario.Items.Add("09:15:00 a.m")
        cbohorario.Items.Add("10:15:00 a.m")
        cbohorario.Items.Add("10:30:00 a.m")
        cbohorario.Items.Add("01:15:00 p.m")
        cbohorario.Items.Add("02:30:00 p.m")
        cbohorario.Items.Add("04:45:00 p.m")
        cbohorario.Items.Add("07:15:00 p.m")
        cbohorario.Items.Add("09:30:00 p.m")
        cbohorario.Items.Add("10:30:00 p.m")

    End Sub

    Sub limpiar()
        txtcodigo.ResetText()
        txtduracion.ResetText()
        txtprecio.ResetText()
        cbodestino.ResetText()
        cbohorario.ResetText()
        cboorigen.ResetText()
        dtpfecha.ResetText()
    End Sub

    Sub listarprogramacion()
        Me.dgviajes.Rows.Clear()

        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_LISTARPROGRAMACION"
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                Me.dgviajes.Rows.Add(dgviajes.RowCount + 1, .Dr(0), Format(.Dr(1), "dd-MM-yyyy"), .Dr(2), .Dr(3), .Dr(4), Format(.Dr(5), "## ##0.00"), .Dr(6))
            End While

            .Cerrar()
        End With
    End Sub
    Sub llenarorigen_destino()

        cboorigen.ResetText()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_LstOrigenDestino"
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                cboorigen.Items.Add(.Dr(0))
            End While

            .Cerrar()
        End With
    End Sub

    Private Sub frmProgramacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        horas()
        listarprogramacion()

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        btnguardar.Enabled = True
        btnnuevo.Visible = False
        btncancelar.Visible = True
        limpiar()
        llenarorigen_destino()
    End Sub
    Sub registrarprogramaion()
        Try
            With objcn
                .Abrir()
                .Cmd.CommandText = "SP_RegistrarProgramacion"
                .Cmd.Parameters.AddWithValue("@origen", cboorigen.SelectedItem)
                .Cmd.Parameters.AddWithValue("@destino", cbodestino.SelectedItem)
                .Cmd.Parameters.AddWithValue("@fecha", Format(dtpfecha.Value, "dd-MM-yyyy"))
                .Cmd.Parameters.AddWithValue("@hora", cbohorario.SelectedItem)
                .Cmd.ExecuteNonQuery()
                MsgBox("PROGRAMACIÓN DE VIAJE REGISTRADA EXITOSAMENTE", 64, "Sistema")
                .Cerrar()


                Me.dgviajes.Rows.Clear()
                listarprogramacion()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try


            If cbodestino.Text = "".Trim Or cboorigen.Text = "".Trim Or cbohorario.Text = "".Trim Then
                MsgBox("Es obigatorio Llenar Todos los Datos", 64, "Sistema")
            Else
                btnguardar.Enabled = False
                btncancelar.Visible = False
                btnnuevo.Visible = True

                registrarprogramaion()
                limpiar()
            cboorigen.Items.Clear()
            cbodestino.Items.Clear()
                btneditar.Enabled = False
                btneliminar.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        btneditar.Visible = False
        btnactualizar.Visible = True
        btnnuevo.Visible = False
        btncancelar.Visible = True

    End Sub
    Sub ELIMINAR()

    End Sub
    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        btneliminar.Enabled = False
        btncancelar.Visible = False
        btnnuevo.Visible = True
        limpiar()

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Close()
    End Sub

    Private Sub lkbnuevahora_LinkClicked(sender As Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lkbnuevahora.LinkClicked
        Dim hora As String
        hora = InputBox("Ingrese Nueva Hora", "Registro de Hora de Salida de Bus", "Hora", 100, 0)
        cbohorario.Items.Add(hora)
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        btncancelar.Visible = False
        btnnuevo.Visible = True
        btnguardar.Enabled = False
        btneditar.Enabled = False
        limpiar()

    End Sub
    Sub Actualizarprogramaion()
        Try
            With objcn
                .Cmd.Parameters.Clear()
                .Abrir()
                .Cmd.CommandText = "SP_ACTUALIZARPROGRAMACION"
                .Cmd.Parameters.AddWithValue("@idprogramacion", txtcodigo.Text.Trim)
                .Cmd.Parameters.AddWithValue("@origen", cboorigen.Text.Trim)
                .Cmd.Parameters.AddWithValue("@destino", cbodestino.Text.Trim)
                .Cmd.Parameters.AddWithValue("@fecha", Format(dtpfecha.Value, "dd-MM-yyyy"))
                .Cmd.Parameters.AddWithValue("@hora", cbohorario.Text)
                .Cmd.ExecuteNonQuery()
                MsgBox("PROGRAMACIÓN DE VIAJE ACTUALIZADA EXITOSAMENTE", 64, "Sistema")
                .Cerrar()

                Me.dgviajes.Rows.Clear()
                listarprogramacion()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Actualizarprogramaion()
        btncancelar.Visible = False
        btnnuevo.Visible = True
        btnactualizar.Visible = False
        btneditar.Visible = True
        btneditar.Enabled = False
        limpiar()

    End Sub

    Private Sub dgviajes_SelectionChanged(sender As Object, e As EventArgs) Handles dgviajes.SelectionChanged
        Try
            limpiar()

            If dgviajes.SelectedRows.Count > 0 Then
                txtcodigo.Text = dgviajes.Item(1, dgviajes.SelectedRows(0).Index).Value
                dtpfecha.Value = dgviajes.Item(2, dgviajes.SelectedRows(0).Index).Value
                cbohorario.SelectedText = dgviajes.Item(3, dgviajes.SelectedRows(0).Index).Value
                cboorigen.Text = dgviajes.Item(4, dgviajes.SelectedRows(0).Index).Value
                cbodestino.Text = dgviajes.Item(5, dgviajes.SelectedRows(0).Index).Value
                txtprecio.Text = dgviajes.Item(6, dgviajes.SelectedRows(0).Index).Value
                txtduracion.Text = dgviajes.Item(7, dgviajes.SelectedRows(0).Index).Value


                btneditar.Enabled = True
                btneliminar.Enabled = True
            End If
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try
    End Sub

    Private Sub cboorigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboorigen.SelectedIndexChanged
        cbodestino.ResetText()
        cbodestino.Items.Clear()
        txtduracion.ResetText()
        txtprecio.ResetText()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_LISTARDESTINO"
            .Cmd.Parameters.AddWithValue("@origen", cboorigen.SelectedItem)
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                cbodestino.Items.Add(.Dr(0))
            End While

            .Cerrar()
        End With
    End Sub

    Private Sub cbodestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbodestino.SelectedIndexChanged


        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_LLENARDATOSVIAJE"
            .Cmd.Parameters.AddWithValue("@origen", cboorigen.SelectedItem)
            .Cmd.Parameters.AddWithValue("@destino", cbodestino.SelectedItem)
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                txtduracion.ResetText()
                txtprecio.ResetText()
                txtprecio.Text = .Dr(0)
                txtduracion.Text = .Dr(1)
            End While

            .Cerrar()
        End With
    End Sub

    Private Sub dgviajes_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgviajes.MouseDoubleClick
        Try
            With frmventa
                If Me.dgviajes.SelectedRows.Count > 0 Then
                    .txtidprogramacion.Text = Me.dgviajes.Item(1, Me.dgviajes.SelectedRows(0).Index).Value
                    .txtfechaviaje.Text = Me.dgviajes.Item(2, Me.dgviajes.SelectedRows(0).Index).Value
                    .txthsalida.Text = Me.dgviajes.Item(3, Me.dgviajes.SelectedRows(0).Index).Value
                    .txtorigen.Text = Me.dgviajes.Item(4, Me.dgviajes.SelectedRows(0).Index).Value
                    .txtdestino.Text = Me.dgviajes.Item(5, Me.dgviajes.SelectedRows(0).Index).Value
                    .txtimporte.Text = Me.dgviajes.Item(6, Me.dgviajes.SelectedRows(0).Index).Value
                    .txtpago.ResetText()
                    .txtvuelto.ResetText()
                    Me.Close()
                Else
                    MsgBox("Debe Seleccionar un Viaje Programado", "Aviso", 64)
                End If
            End With
        Catch ex As Exception

        End Try

    End Sub
End Class
Imports DATOS
Imports Negocio
Public Class frmruta

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        btnguardar.Enabled = True
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

    End Sub

    Private Sub btnelimminar_Click(sender As Object, e As EventArgs) Handles btnelimminar.Click

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub BTNEDITAR_Click_1(sender As Object, e As EventArgs) Handles BTNEDITAR.Click
        BTNEDITAR.Visible = False
        btnactualizar.Visible = True
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        btnactualizar.Visible = True
    End Sub

    Private Sub frmruta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarrutas()
        llenarcomobus()
    End Sub

    Dim objcn As New Conexion

    Sub limpiar()
        txtcodigo.ResetText()
        txtdestino.ResetText()
        txtorigen.ResetText()
        txtprecio.ResetText()
        txtduracion.ResetText()
        cbobus.ResetText()
    End Sub

    Sub listarrutas()
        Me.dgrutas.Rows.Clear()

        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_listadoRuta"
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                Me.dgrutas.Rows.Add(dgrutas.RowCount, .Dr(0), .Dr(1), .Dr(2), .Dr(3), .Dr(4), .Dr(5))
            End While

            .Cerrar()
        End With
    End Sub

    Private Sub btnbus_Click(sender As Object, e As EventArgs) Handles btnbus.Click
        frmmantenimientobus.Show()
    End Sub
    Sub llenarcomobus()
        Me.cbobus.Items.Clear()

        With objcn
            .Abrir()
            .Cmd.CommandText = "listadoBus"
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                'Me.dgbus.Rows.Add(dgbus.RowCount, .Dr(0), .Dr(1), .Dr(2), .Dr(3))

                cbobus.Items.Add(.Dr(1))
            End While

            .Cerrar()
        End With
    End Sub
    Private Sub dgrutas_SelectionChanged(sender As Object, e As EventArgs) Handles dgrutas.SelectionChanged
        limpiar()

        Try
            With objcn
                If dgrutas.SelectedRows.Count > 0 Then
                    txtcodigo.Text = dgrutas.Item(1, dgrutas.SelectedRows(0).Index).Value
                    txtorigen.Text = dgrutas.Item(2, dgrutas.SelectedRows(0).Index).Value
                    txtdestino.Text = dgrutas.Item(3, dgrutas.SelectedRows(0).Index).Value
                    txtprecio.Text = dgrutas.Item(4, dgrutas.SelectedRows(0).Index).Value
                    txtduracion.Text = dgrutas.Item(5, dgrutas.SelectedRows(0).Index).Value
                    cbobus.SelectedText = dgrutas.Item(6, dgrutas.SelectedRows(0).Index).Value
                End If
            End With
        Catch ex As Exception

        End Try
        btnnuevo.Enabled = True
        BTNEDITAR.Enabled = True
    End Sub


    Private Sub dgrutas_DoubleClick(sender As Object, e As EventArgs) Handles dgrutas.DoubleClick

    End Sub
End Class
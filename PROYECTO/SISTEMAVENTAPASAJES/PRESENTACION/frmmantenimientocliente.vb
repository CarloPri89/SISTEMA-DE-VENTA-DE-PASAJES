Imports System.Windows.Forms
Imports DATOS
Imports Negocio
Public Class frmmantenimientocliente
    Dim objcn As New Conexion
    Dim WithEvents app As New Validacion
    Dim reg As New Procesos.cliente
    Sub textos(estado)
        txtdni.ReadOnly = estado
        txtedad.ReadOnly = estado
        txtamaterno.ReadOnly = estado
        txtapaterno.ReadOnly = estado
        txtedad.ReadOnly = estado
        txtemail.ReadOnly = estado
        txtfono.ReadOnly = estado
        txtnombre.ReadOnly = estado
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        obtncodcliente()
        textos(False)
    End Sub

    Dim sexo As String
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            If txtamaterno.Text = "" Then
                MsgBox("Ingrese el Apellido Materno", 64, "AVISO!!!")
                txtamaterno.Focus()
            ElseIf txtapaterno.Text = "" Then
                MsgBox("Ingrese Apellido Paterno", 64, "AVISO!!!")
                txtapaterno.Focus()
            ElseIf txtdni.Text = "" Then
                MsgBox("Ingrese el DNI", 64, "AVISO!!!")
                txtdni.Focus()
            ElseIf txtedad.Text = "" Then
                MsgBox("Ingrese la edad", 64, "AVISO!!!")
                txtedad.Focus()
            Else
                If (MsgBox("¿ESTÁ SEGURO DE REGISTRAR ESTE REGISTRO?", 36, "Sistema") = 6) Then
                    With reg

                        .codcliente = txtcodigo.Text
                        .dni = txtdni.Text
                        .apaterno = txtapaterno.Text.ToUpper
                        .amaterno = txtamaterno.Text.ToUpper
                        .nombres = txtnombre.Text.ToUpper
                        .edad = txtedad.Text

                        .sexo = sexo
                        .email = txtemail.Text
                        .fono = txtfono.Text
                        app.insertarcliente(reg)
                        listarclientes()
                    End With
                Else
                    MsgBox("REGISTRO NO INGRESADO", 64, "AVISO!!!")
                    listarclientes()
                End If
                limpiar()
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        btnactualizar.Visible = True
        btneditar.Visible = False
        textos(False)
    End Sub


    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Try
            Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmmantenimientocliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarclientes()
    End Sub
    Dim cod, codi As String
    Dim codbus As Integer
    Sub obtncodcliente()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_obtcodigoCliente"
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                cod = .Dr("cod_clie")
                codi = cod.Substring(1, 4).ToString
                codbus = (codi + 1)
                txtcodigo.Text = "C" & Format(codbus, "#0000")
            End While
            .Cerrar()
        End With
    End Sub

    Sub listarclientes()
        Me.dgcliente.Rows.Clear()

        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_ListadoCliente"
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                Me.dgcliente.Rows.Add(dgcliente.RowCount, .Dr(0), .Dr(1), .Dr(2), .Dr(3), .Dr(4), .Dr(5), .Dr(6), .Dr(7), .Dr(8))
            End While

            .Cerrar()
        End With
    End Sub
    Sub limpiar()
        txtcodigo.ResetText()
        txtdni.ResetText()
        txtapaterno.ResetText()
        txtamaterno.ResetText()
        txtnombre.ResetText()
        txtedad.ResetText()
        txtemail.ResetText()
        txtfono.ResetText()
        ' txtbuscardni.ResetText()
        cbosexo.ResetText()
    End Sub

    Private Sub cbosexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosexo.SelectedIndexChanged
        sexo = cbosexo.Text.Substring(0, 1)

    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        textos(True)
        btnactualizar.Visible = False
        btneditar.Visible = True
        Try
            If txtamaterno.Text = "" Then
                MsgBox("Ingrese el Apellido Materno", 64, "AVISO!!!")
                txtamaterno.Focus()
            ElseIf txtapaterno.Text = "" Then
                MsgBox("Ingrese Apellido Paterno", 64, "AVISO!!!")
                txtapaterno.Focus()
            ElseIf txtdni.Text = "" Then
                MsgBox("Ingrese el DNI", 64, "AVISO!!!")
                txtdni.Focus()
            ElseIf txtedad.Text = "" Then
                MsgBox("Ingrese la edad", 64, "AVISO!!!")
                txtedad.Focus()
            Else
                If (MsgBox("¿ESTÁ SEGURO DE ACTUALIZAR ESTE REGISTRO?", 36, "Sistema") = 6) Then
                    With reg

                        .codcliente = txtcodigo.Text
                        .dni = txtdni.Text
                        .apaterno = txtapaterno.Text.ToUpper
                        .amaterno = txtamaterno.Text.ToUpper
                        .nombres = txtnombre.Text.ToUpper
                        .edad = txtedad.Text

                        .sexo = sexo
                        .email = txtemail.Text
                        .fono = txtfono.Text
                        app.modificarcliente(reg)
                        listarclientes()
                    End With
                Else
                    MsgBox("REGISTRO NO ACTUALIZADO", 64, "AVISO!!!")
                    listarclientes()
                End If
                limpiar()
            End If


        Catch ex As Exception

        End Try
    End Sub


    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try

            If (MsgBox("¿ESTÁ SEGURO DE ELIMINAR  ESTE REGISTRO?", 36, "Sistema") = 6) Then
                With reg

                    .codcliente = txtcodigo.Text
                    app.eliminarcliente(reg)
                    listarclientes()
                End With
            Else
                MsgBox("REGISTRO NO ELIMINADO", 64, "AVISO!!!")
                listarclientes()
            End If
            limpiar()
            btnguardar.Enabled = False


        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgcliente_SelectionChanged(sender As Object, e As EventArgs) Handles dgcliente.SelectionChanged
        limpiar()

        Try
            With objcn
                If dgcliente.SelectedRows.Count > 0 Then
                    txtcodigo.Text = dgcliente.Item(1, dgcliente.SelectedRows(0).Index).Value
                    txtdni.Text = dgcliente.Item(2, dgcliente.SelectedRows(0).Index).Value
                    txtapaterno.Text = dgcliente.Item(3, dgcliente.SelectedRows(0).Index).Value
                    txtamaterno.Text = dgcliente.Item(4, dgcliente.SelectedRows(0).Index).Value
                    txtnombre.Text = dgcliente.Item(5, dgcliente.SelectedRows(0).Index).Value
                    txtedad.Text = dgcliente.Item(6, dgcliente.SelectedRows(0).Index).Value
                    cbosexo.SelectedText = dgcliente.Item(7, dgcliente.SelectedRows(0).Index).Value
                    txtemail.Text = dgcliente.Item(8, dgcliente.SelectedRows(0).Index).Value
                    txtfono.Text = dgcliente.Item(9, dgcliente.SelectedRows(0).Index).Value
                Else
                    MsgBox("Seleccione un Registro", "Aviso", 64)
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
    Sub limpiardaosclt()
        With frmventa
            .txtcodcliente.ResetText()
            .txtdni.ResetText()
            .txtapaterno.ResetText()
            .txtamaterno.ResetText()
            .txtnombre.ResetText()
            .cbosexo.ResetText()
            .txtemail.ResetText()
            .txtfono.ResetText()
        End With



    End Sub
    Sub filtrarclientes()

        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_filtrarCliente"
            .Cmd.Parameters.AddWithValue("@dni_clie", txtbuscardni.Text)
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                dgcliente.Rows.Add(dgcliente.RowCount + 1, .Dr(0), .Dr(1), .Dr(2), .Dr(3), .Dr(4), .Dr(5), .Dr(6), .Dr(7), .Dr(8))
            End While
            .Cerrar()
        End With
    End Sub
    Private Sub txtbuscardni_TextChanged(sender As Object, e As EventArgs) Handles txtbuscardni.TextChanged
        Try
            dgcliente.Rows.Clear()
            filtrarclientes()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub dgcliente_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgcliente.MouseDoubleClick
        With frmventa
            If dgcliente.SelectedRows.Count > 0 Then
                limpiardaosclt()
                .txtcodcliente.Text = dgcliente.Item(1, dgcliente.SelectedRows(0).Index).Value
                .txtdni.Text = dgcliente.Item(2, dgcliente.SelectedRows(0).Index).Value
                .txtapaterno.Text = dgcliente.Item(3, dgcliente.SelectedRows(0).Index).Value
                .txtamaterno.Text = dgcliente.Item(4, dgcliente.SelectedRows(0).Index).Value
                .txtnombre.Text = dgcliente.Item(5, dgcliente.SelectedRows(0).Index).Value
                .cbosexo.SelectedText = dgcliente.Item(7, dgcliente.SelectedRows(0).Index).Value
                .txtemail.Text = dgcliente.Item(8, dgcliente.SelectedRows(0).Index).Value
                .txtfono.Text = dgcliente.Item(9, dgcliente.SelectedRows(0).Index).Value
                Me.Close()
            Else
                MsgBox("Seleccione un Registro", "Aviso", 64)
            End If

        End With
    End Sub
End Class
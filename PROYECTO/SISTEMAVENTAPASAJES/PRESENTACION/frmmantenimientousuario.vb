Imports System.Windows.Forms
Imports DATOS
Public Class frmmantenimientousuario
    Public objcnt As New Conexion
    Public objlst As New Procesos
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Try
            Close()
        Catch ex As Exception

        End Try
    End Sub


    Sub listar()
        dguser.Rows.Clear()

        With objcnt
            .Abrir()
            .Cmd.CommandText = "SP_listaruser"
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                dguser.Rows.Add(dguser.RowCount + 1, .Dr("Codigo"), .Dr("nombrecompleto"), .Dr("nombreacceso"), .Dr("Clave"), .Dr("Nivel"), .Dr("Estado"))

            End While
            .Cerrar()
        End With
    End Sub
    Sub anular_activar()
        Try
            With objcnt
                .Abrir()
                If lblestado.Visible = False Then
                    MsgBox("USUARIO ANULADO EXITOSAMENTE", 64, "Sistema")
                    .Cmd.CommandText = "anular"
                    .Cmd.Parameters.AddWithValue("@cod", txtcodigo.Text)
                Else
                    MsgBox("USUARIO ACTIVADO EXITOSAMENTE", 64, "Sistema")
                    .Cmd.CommandText = "ACTIVAR"
                    .Cmd.Parameters.AddWithValue("@cod", txtcodigo.Text)
                    lblestado.Visible = False
                    pcimage.Visible = False
                End If

                .Cmd.ExecuteNonQuery()
                .Cerrar()
            End With
        Catch ex As Exception

        End Try

    End Sub

    Sub filtrar()

        Try
            With objcnt
                .Abrir()
                .Cmd.CommandText = "SP_filtrar"
                .Cmd.Parameters.AddWithValue("@filtro", txtbuscar.Text.ToUpper)
                .Dr = .Cmd.ExecuteReader
                While .Dr.Read
                    dguser.Rows.Add(dguser.RowCount + 1, .Dr("Codigo"), .Dr("nombrecompleto"), .Dr("nombreacceso"), .Dr("Clave"), .Dr("Nivel"), .Dr("Estado"))
                End While
                .Cerrar()
            End With
        Catch ex As Exception

        End Try


    End Sub

    Private Sub frmmantenimientousuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Private Sub dguser_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dguser.CellFormatting
        If ((e.ColumnIndex = 4) AndAlso (Not e.Value Is Nothing)) Then
            e.Value = New String("●"c, Convert.ToString(e.Value).Length)
        End If

    End Sub
    Dim est As String
    Dim codigoaut, substring As String
    Dim cod As Integer
    Sub generarcodigo()
        Try
            With objcnt
                .Abrir()
                .Cmd.CommandText = "obtcodigo"
                .Dr = .Cmd.ExecuteReader
                While .Dr.Read()
                    codigoaut = .Dr("CODIGO").ToString().Substring(1, 3)
                    txtcodigo.Text = "U" & (Format(Val(codigoaut) + 1, "00#"))
                End While
                .Cerrar()
            End With
        Catch ex As Exception

        End Try

    End Sub

    Sub ingresar()
        Try
            With objcnt
                .Abrir()
                .Cmd.CommandText = "SP_ingresarusuario"
                .Cmd.Parameters.AddWithValue("@cod", txtcodigo.Text)
                .Cmd.Parameters.AddWithValue("@nomc", txtnombrecomp.Text.ToUpper)
                .Cmd.Parameters.AddWithValue("@nomaa", txtnomacceso.Text.ToUpper)
                .Cmd.Parameters.AddWithValue("@clave", txtclave1.Text)
                .Cmd.Parameters.AddWithValue("@nivel", txtnivel.Text.ToUpper)
                .Cmd.ExecuteNonQuery()
                MsgBox("USUARIO REGISTRADO EXITOSAMENTE", 64, "Sistema")
                .Cerrar()
            End With
        Catch ex As Exception

        End Try

    End Sub
    Sub consulataragregarusuario()
        Try
            With objcnt
                .Abrir()
                .Cmd.CommandText = "SP_consutarusuario"
                .Cmd.Parameters.AddWithValue("@nombre", txtnombrecomp.Text.ToUpper)
                .Dr = .Cmd.ExecuteReader
                If .Dr.Read Then
                    MsgBox("Usuario Ya se Encuentra Registrado Con el Código: " & .Dr("Codigo"), 64, "SISTEMA")
                    .Cerrar()
                    Exit Sub
                Else
                    .Cerrar()
                    ingresar()
                End If
            End With
        Catch ex As Exception

        End Try


    End Sub
    Private Sub dguser_SelectionChanged(sender As Object, e As EventArgs) Handles dguser.SelectionChanged
        If dguser.SelectedRows.Count > 0 Then
            txtcodigo.Text = dguser.Item(1, dguser.SelectedRows(0).Index).Value
            txtnombrecomp.Text = dguser.Item(2, dguser.SelectedRows(0).Index).Value
            txtnomacceso.Text = dguser.Item(3, dguser.SelectedRows(0).Index).Value
            txtclave1.Text = dguser.Item(4, dguser.SelectedRows(0).Index).Value
            txtclave2.Text = dguser.Item(4, dguser.SelectedRows(0).Index).Value
            txtnivel.Text = dguser.Item(5, dguser.SelectedRows(0).Index).Value
            est = dguser.Item(6, dguser.SelectedRows(0).Index).Value
            If est = "X".Trim Then
                lblestado.Visible = True
                pcimage.Visible = True
            Else
                lblestado.Visible = False
                pcimage.Visible = False
            End If
            'textos(True)
            btnguardar.Enabled = False
            btneditar.Enabled = True
            btneliminar.Enabled = True
            btnactivar.Enabled = True
        End If
    End Sub


    Private Sub btnrc1_MouseUp(sender As Object, e As MouseEventArgs) Handles btnrc1.MouseUp
        txtclave1.PasswordChar = "●"
    End Sub

    Private Sub btnrc1_MouseDown(sender As Object, e As MouseEventArgs) Handles btnrc1.MouseDown
        txtclave1.PasswordChar = ""
    End Sub


    Private Sub btnrc2_MouseDown(sender As Object, e As MouseEventArgs) Handles btnrc2.MouseDown
        txtclave2.PasswordChar = ""
    End Sub

    Private Sub btnrc2_MouseUp(sender As Object, e As MouseEventArgs) Handles btnrc2.MouseUp
        txtclave2.PasswordChar = "●"
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        dguser.Rows.Clear()
        filtrar()
    End Sub

    Sub eliminar()
        Try
            With objcnt
                .Abrir()
                .Cmd.CommandText = "SP_eliminararuser"
                .Cmd.Parameters.AddWithValue("@cod", txtcodigo.Text)
                .Cmd.ExecuteNonQuery()
                .Cerrar()
            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If (MsgBox("¿ESTÁ SEGURO DE ELIMINAR  USUARIO?", 36, "Sistema") = 6) Then
            eliminar()
            MsgBox("USUARIO ELIMINADO DEL SISTEMA EXITOSAMENTE", 64, "Sistema")
            listar()
            limpiar("")
            btneliminar.Enabled = False
            btneditar.Enabled = False
        Else
            MsgBox("USUARIO NO ELIMINADO", 64, "Sistema")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnactivar.Click
        anular_activar()
        dguser.Rows.Clear()
        listar()
        limpiar("")
    End Sub

    Sub textos(estado)
        txtclave1.ReadOnly = estado
        txtclave2.ReadOnly = estado
        txtnivel.ReadOnly = estado
        txtnomacceso.ReadOnly = estado
        txtnombrecomp.ReadOnly = estado
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        textos(False)
        limpiar("")
        generarcodigo()
        btnguardar.Enabled = True
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If txtcodigo.Text <> "" And txtnombrecomp.Text <> "" And txtnomacceso.Text <> "" And txtclave1.Text <> "" And txtclave2.Text <> "" And txtnivel.Text <> "" Then

            If (txtclave1.Text = txtclave2.Text) Then

                If (MsgBox("¿Esta seguro de Registrar Este Usuario?", 36, "Sistema") = 6) Then
                    consulataragregarusuario()
                    listar()
                    limpiar("")
                    btnguardar.Enabled = False
                Else
                    MsgBox("USUARIO NO REGISTRADO", 16, "Sistema")
                End If
            Else
                MsgBox("Las Claves o Contraseñas Ingresadas no Coinciden", 16, "Sistema")
                txtclave1.Clear()
                txtclave2.Clear()
                txtclave1.Focus()
            End If

        Else
            MsgBox("Es Obligatorio Llenar Todos Los Campos", 16, "Sistema")
        End If
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        textos(False)
        btneliminar.Enabled = False
        btnguardar.Enabled = False
        btnactualizar.Enabled = True
    End Sub

    Sub actualizar()
        Try
            With objcnt
                .Abrir()
                .Cmd.CommandText = "SP_Actualizaruser"
                .Cmd.Parameters.AddWithValue("@cod", txtcodigo.Text)
                .Cmd.Parameters.AddWithValue("@nomc", txtnombrecomp.Text.ToUpper)
                .Cmd.Parameters.AddWithValue("@noma", txtnomacceso.Text.ToUpper)
                .Cmd.Parameters.AddWithValue("@clave", txtclave1.Text)
                .Cmd.Parameters.AddWithValue("@nivel", txtnivel.Text.ToUpper)
                .Cmd.ExecuteNonQuery()
                MsgBox("Datos Modificados Exitosamente", 64, "Sistema")
                .Cerrar()
            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        If (MsgBox("¿Esta seguro de Modificar los datos del Registro?", 36, "Sistema") = 6) Then
            actualizar()
            listar()
            limpiar("")
            btnactualizar.Enabled = False
            btneditar.Enabled = False
        Else
            MsgBox("DATOS NO MODIFICADOS", 16, "Sistema")
        End If
    End Sub

    Sub limpiar(estado)
        txtcodigo.Text = estado
        txtclave1.Text = estado
        txtclave2.Text = estado
        txtnivel.Text = estado
        txtnomacceso.Text = estado
        txtnombrecomp.Text = estado
    End Sub
End Class
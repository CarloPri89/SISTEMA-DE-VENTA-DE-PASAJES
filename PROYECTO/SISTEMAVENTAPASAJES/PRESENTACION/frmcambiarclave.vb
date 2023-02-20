Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports DATOS

Public Class frmcambiarclave

    Dim objcn As New Conexion

    Public user As String
    Sub titulos()
        dguser.ColumnCount = 0
        dguser.Columns.Add("Numero", "N°")
        dguser.Columns.Add("Codigo", "Código")
        dguser.Columns.Add("Nombrecompleto", "Nombre Completo")
        dguser.Columns.Add("Nombreacceso", "Nombre de Acceso")
        dguser.Columns.Add("clave", "Clave")
        dguser.Columns.Add("Nivel", "Nivel")
        dguser.Columns.Add("Estado", "Estado")

        dguser.Columns("Numero").Width = 50
        dguser.Columns("Codigo").Width = 100
        dguser.Columns("Nivel").Width = 50
        dguser.Columns("Clave").Width = 150
        dguser.Columns("Estado").Width = 50
        dguser.Columns("Nombrecompleto").Width = 300
        dguser.Columns("Nombreacceso").Width = 200
        dguser.Columns("Numero").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dguser.Columns("Codigo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dguser.Columns("Nivel").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dguser.Columns("Estado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
    Sub listar()
        titulos()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_listaruser"
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                dguser.Rows.Add(dguser.RowCount + 1, .Dr("Codigo"), .Dr("nombrecompleto"), .Dr("nombreacceso"), .Dr("Clave"), .Dr("Nivel"), .Dr("Estado"))
            End While
            .Cerrar()
        End With

    End Sub
    Sub filtrar()
        titulos()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_filtrar"
            .Cmd.Parameters.AddWithValue("@filtro", txtbuscar.Text)
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                dguser.Rows.Add(dguser.RowCount + 1, .Dr("Codigo"), .Dr("nombrecompleto"), .Dr("nombreacceso"), .Dr("Clave"), .Dr("Nivel"), .Dr("Estado"))
            End While
            .Cerrar()
        End With

    End Sub

    Private Sub frmmantenimientousuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        textos(True)

    End Sub

    Sub textos(estado)
        txtclave1.ReadOnly = estado
        txtclave2.ReadOnly = estado
        txtnivel.ReadOnly = estado
        txtnomacceso.ReadOnly = estado
        txtnombrecomp.ReadOnly = estado
    End Sub
    Sub limpiar(estado)
        txtcodigo.Text = estado
        txtclave1.Text = estado
        txtclave2.Text = estado
        txtnivel.Text = estado
        txtnomacceso.Text = estado
        txtnombrecomp.Text = estado
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        textos(False)
        btnactualizar.Enabled = True
    End Sub

    Sub actualizar()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_Actualizaruser"
            .Cmd.Parameters.AddWithValue("@cod", txtcodigo.Text)
            .Cmd.Parameters.AddWithValue("@nomc", txtnombrecomp.Text.ToUpper)
            .Cmd.Parameters.AddWithValue("@noma", txtnomacceso.Text)
            .Cmd.Parameters.AddWithValue("@clave", txtclave1.Text)
            .Cmd.Parameters.AddWithValue("@nivel", txtnivel.Text)
            .Cmd.ExecuteNonQuery()
            MsgBox("Datos Modificados Exitosamente", 64, "Sistema")
            .Cerrar()
        End With

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub
    Dim est As String
    Private Sub dguser_SelectionChanged(sender As Object, e As EventArgs) Handles dguser.SelectionChanged
        Try
            With objcn
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
                    If user = txtnombrecomp.Text Then
                        btneditar.Enabled = True
                        btnrc1.Enabled = True
                        btnrc2.Enabled = True
                    Else
                        btneditar.Enabled = False
                        btnrc1.Enabled = False
                        btnrc2.Enabled = False
                    End If
                    txtbuscar.ResetText()
                End If
            End With
        Catch ex As Exception

        End Try


    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        filtrar()
    End Sub

    Private Sub dguser_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dguser.CellFormatting
        If ((e.ColumnIndex = 4) AndAlso (Not e.Value Is Nothing)) Then
            e.Value = New String("●"c, Convert.ToString(e.Value).Length)
        End If
    End Sub


    Private Sub btnrc2_MouseDown(sender As Object, e As MouseEventArgs) Handles btnrc2.MouseDown
        txtclave2.PasswordChar = ""
    End Sub

    Private Sub btnrc2_MouseUp(sender As Object, e As MouseEventArgs) Handles btnrc2.MouseUp
        txtclave2.PasswordChar = "●"
    End Sub

    Private Sub btnrc1_MouseDown(sender As Object, e As MouseEventArgs) Handles btnrc1.MouseDown
        txtclave1.PasswordChar = ""
    End Sub

    Private Sub btnrc1_MouseUp(sender As Object, e As MouseEventArgs) Handles btnrc1.MouseUp
        txtclave1.PasswordChar = "●"
    End Sub
    Private Sub txtnivel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnivel.KeyPress
        Dim num As New Regex("[^ABC\b]", RegexOptions.IgnoreCase)
        e.Handled = num.IsMatch(e.KeyChar)
        If Asc(e.KeyChar) = Keys.Enter Then
            txtbuscar.Focus()
        ElseIf Asc(e.KeyChar) = 27 Then
            Close()
        End If
    End Sub

    Private Sub txtnomacceso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnomacceso.KeyPress
        Dim num As New Regex("[^A-Z éúñáíó\b]", RegexOptions.IgnoreCase)
        e.Handled = num.IsMatch(e.KeyChar)

        If Asc(e.KeyChar) = Keys.Enter Then
            txtclave1.Focus()
        ElseIf Asc(e.KeyChar) = 27 Then
            Close()
        End If
    End Sub
    Private Sub txtnombrecomp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombrecomp.KeyPress
        Dim num As New Regex("[^A-Z éúñáíó\b]", RegexOptions.IgnoreCase)
        e.Handled = num.IsMatch(e.KeyChar)

        If Asc(e.KeyChar) = Keys.Enter Then
            txtnomacceso.Focus()
        ElseIf Asc(e.KeyChar) = 27 Then
            Close()
        End If
    End Sub
    Private Sub txtclave1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtclave1.KeyPress

        If Asc(e.KeyChar) = Keys.Enter Then
            txtclave2.Focus()
        ElseIf Asc(e.KeyChar) = 27 Then
            Close()
        End If
    End Sub

    Private Sub txtclave2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtclave2.KeyPress

        If Asc(e.KeyChar) = Keys.Enter Then
            txtnivel.Focus()
        ElseIf Asc(e.KeyChar) = 27 Then
            Close()
        End If
    End Sub

    Private Sub txtbuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbuscar.KeyPress
        Dim num As New Regex("[^A-Z éúñáíó\b]", RegexOptions.IgnoreCase)
        e.Handled = num.IsMatch(e.KeyChar)
        If Asc(e.KeyChar) = Keys.Enter Then
            txtnombrecomp.Focus()
        ElseIf Asc(e.KeyChar) = 27 Then
            Close()
        End If
    End Sub
End Class
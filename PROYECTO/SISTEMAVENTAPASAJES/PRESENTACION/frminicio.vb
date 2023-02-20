Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports DATOS
Imports Negocio
Public Class frminicio
    Dim objcn As New Conexion
    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        With objcn


            .Abrir()
            .Cmd.CommandText = "Verificar_usuario"
            .Cmd.Parameters.AddWithValue("@nombre", txtuser.Text)
            .Cmd.Parameters.AddWithValue("@clave", txtclave.Text)
            .Dr = .Cmd.ExecuteReader
            If .Dr.Read Then
                If .Dr("ESTADO") <> "X" Then
                    .codigo = .Dr("Codigo")
                    .nombre = .Dr("NombreCompleto")
                    .nivel = .Dr("NIVEL")
                    MDIMENU.lbluser.Text = "Usuario: " & .nombre
                    MDIMENU.codigousuario = .codigo
                    frmcambiarclave.user = .nombre
                    frmventa.coduser = .Dr("Codigo")
                    frmventa.nombreuser = .Dr("NombreCompleto")
                    txtuser.Clear()
                    txtclave.Clear()
                    txtuser.Focus()
                    MDIMENU.Show()
                    Select Case .nivel
                        Case "A"

                        Case "B"
                            MDIMENU.UsuariosToolStripMenuItem.Visible = False
                        Case "C"
                            MDIMENU.UsuariosToolStripMenuItem.Visible = False
                            MDIMENU.ReportesToolStripMenuItem.Visible = False
                    End Select

                Else

                    MsgBox("Usuario Bloquedo", 16, "Sistema")
                    txtuser.Clear()
                    txtclave.Clear()
                    txtuser.Focus()
                End If
            Else

                MsgBox("Usuario o Clave Incorrecta", 16, "Sistema")
                txtuser.Clear()
                txtclave.Clear()
                txtuser.Focus()
            End If
            .Cerrar()
        End With
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Try
            End
        Catch ex As Exception
            End
        End Try


    End Sub

    Private Sub txtuser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtuser.KeyPress
        Dim num As New Regex("[^A-Z éúñáíó 0-9\b]", RegexOptions.IgnoreCase)
        e.Handled = num.IsMatch(e.KeyChar)
        If Asc(e.KeyChar) = Keys.Enter Then
            txtclave.Focus()
        ElseIf Asc(e.KeyChar) = 27 Then
            Close()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Contactarse con el Administrador Cel: 947483015", 64, "AVISO")
    End Sub
End Class

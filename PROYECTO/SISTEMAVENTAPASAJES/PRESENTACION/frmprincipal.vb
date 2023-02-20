Imports System.Drawing
Imports System.Windows.Forms

Public Class frmprincipal


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If lblbienvenida.Left < 300 Then
            lblbienvenida.Left = lblbienvenida.Left + 10
        Else
            Timer1.Enabled = False
            Timer2.Enabled = True
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If lblbienvenida.Left > 10 Then
            lblbienvenida.Left = lblbienvenida.Left - 10
        Else
            Timer1.Enabled = True
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Static c As Integer
        c = c + 1

        If c = 1 Then
            lblbienvenida.ForeColor = Color.Red
        ElseIf c = 2 Then
            lblbienvenida.ForeColor = Color.BlueViolet
        ElseIf c = 3 Then
            lblbienvenida.ForeColor = Color.Blue
        ElseIf c = 4 Then
            lblbienvenida.ForeColor = Color.OrangeRed
        ElseIf c = 5 Then
            c = 0
        End If
    End Sub

    Private Sub frmprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblbienvenida.BackColor = Color.Transparent

    End Sub


    Private Sub frmprincipal_Click(sender As Object, e As EventArgs) Handles Me.Click

        frminicio.Show()
    End Sub
End Class

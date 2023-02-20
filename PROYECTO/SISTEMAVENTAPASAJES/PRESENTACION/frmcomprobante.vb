Imports System.Drawing
Imports System.Windows.Forms

Public Class frmcomprobante
    Private Sub frmcomprobante_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(35, 0, 100, 75)
        PrintForm1.PrintAction = Drawing.Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

        Me.Close()
    End Sub

    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(35, 0, 100, 75)
        PrintForm1.PrintAction = Drawing.Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

        Me.Close()
    End Sub

    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseClick
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(35, 0, 100, 75)
        PrintForm1.PrintAction = Drawing.Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

        Me.Close()
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(35, 0, 100, 75)
        PrintForm1.PrintAction = Drawing.Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

        Me.Close()
    End Sub

    Private Sub lblempleado_Click(sender As Object, e As EventArgs) Handles lblempleado.Click
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(35, 0, 100, 75)
        PrintForm1.PrintAction = Drawing.Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

        Me.Close()
    End Sub

    Private Sub lblprecioescrito_Click(sender As Object, e As EventArgs) Handles lblprecioescrito.Click
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(35, 0, 100, 75)
        PrintForm1.PrintAction = Drawing.Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

        Me.Close()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(35, 0, 100, 75)
        PrintForm1.PrintAction = Drawing.Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(35, 0, 100, 75)
        PrintForm1.PrintAction = Drawing.Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

        Me.Close()
    End Sub

    Private Sub lblnumeroboleta_Click(sender As Object, e As EventArgs) Handles lblnumeroboleta.Click
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(35, 0, 100, 75)
        PrintForm1.PrintAction = Drawing.Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

        Me.Close()
    End Sub

    Private Sub lblvalorventa_Click(sender As Object, e As EventArgs) Handles lblvalorventa.Click
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(35, 0, 100, 75)
        PrintForm1.PrintAction = Drawing.Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

        Me.Close()
    End Sub

    Private Sub lbldni_Click(sender As Object, e As EventArgs) Handles lbldni.Click
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(35, 0, 100, 75)
        PrintForm1.PrintAction = Drawing.Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(35, 0, 100, 75)
        PrintForm1.PrintAction = Drawing.Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(35, 0, 100, 75)
        PrintForm1.PrintAction = Drawing.Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

        Me.Close()
    End Sub
End Class
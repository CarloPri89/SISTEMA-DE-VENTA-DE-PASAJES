Imports System.Windows.Forms

Public Class MDIMENU
    Public codigousuario As String
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItem3.Click
        Try
            End
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub PrintToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        frmmantenimientocliente.MdiParent = Me

        frmmantenimientocliente.Show()
    End Sub

    Private Sub BusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BusToolStripMenuItem.Click
        frmmantenimientobus.MdiParent = Me

        frmmantenimientobus.Show()
    End Sub

    Private Sub RutaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RutaToolStripMenuItem.Click
        frmruta.MdiParent = Me
        frmruta.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        frmlistadoventas.MdiParent = Me
        frmlistadoventas.Show()
    End Sub

    Private Sub VentasToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem2.Click
        frmventa.MdiParent = Me
        frmventa.Show()
    End Sub

    Private Sub ReservasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReservasToolStripMenuItem1.Click

        Try

            System.Diagnostics.Process.Start("https://www.redbus.pe/viajes/pasajes-de-bus-gh-bus")
        Catch
            'Code to handle the error.
        End Try
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        frmmantenimientousuario.MdiParent = Me
        frmmantenimientousuario.Show()
    End Sub

    Private Sub CambiarClaveDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarClaveDeUsuarioToolStripMenuItem.Click
        frmcambiarclave.MdiParent = Me
        frmcambiarclave.Show()
        frmcambiarclave.lblusuario.Text = lbluser.Text
    End Sub

    Private Sub SugerenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SugerenciasToolStripMenuItem.Click

        Shell("C:\Windows\System32\Notepad.exe d:\Sugerencias\Sugerencias.txt", 1)
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PrintSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.Close()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        Try

            System.Diagnostics.Process.Start("https://www.google.com.pe/search?q=google&oq=goo&aqs=chrome.1.69i57j0l3j35i39l2.2335j0j7&sourceid=chrome&ie=UTF-8")
        Catch
            'Code to handle the error.
        End Try
    End Sub

    Private Sub correoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles correoToolStripMenuItem.Click
        frmcorreos.MdiParent = Me
        frmcorreos.Show()

    End Sub

    Private Sub ProgramaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramaciónToolStripMenuItem.Click
        frmProgramacion.MdiParent = Me
        frmProgramacion.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

    End Sub
End Class

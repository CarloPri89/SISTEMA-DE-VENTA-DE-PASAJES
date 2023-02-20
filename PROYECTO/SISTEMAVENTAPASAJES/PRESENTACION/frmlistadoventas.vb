Imports System.Windows.Forms
Imports DATOS
Public Class frmlistadoventas
    Dim objcn As New Conexion
    Private Sub txtclientes_TextChanged(sender As Object, e As EventArgs) Handles txtclientes.TextChanged
        With objcn
            dgventas.Rows.Clear()
            .Abrir()
            .Cmd.CommandText = "SP_FILTRARVCLT"
            .Cmd.Parameters.AddWithValue("@nombclt", txtclientes.Text)
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                dgventas.Rows.Add(dgventas.RowCount + 1, .Dr(0), .Dr(1), .Dr(2), .Dr(3), .Dr(4), .Dr(5), Format(.Dr(6), "dd-MM-yyyy"))
            End While
            .Cerrar()
        End With
    End Sub

    Private Sub Listar_Click(sender As Object, e As EventArgs) Handles Listar.Click
        With objcn
            dgventas.Rows.Clear()
            .Abrir()
            .Cmd.CommandText = "SP_LISTARVENTASXFECHA"
            .Cmd.Parameters.AddWithValue("@fdesde", Format(dtpdesde.Value, "yyyy-MM-dd"))
            .Cmd.Parameters.AddWithValue("@fhasta", Format(dtphasta.Value, "yyyy-MM-dd"))
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                dgventas.Rows.Add(dgventas.RowCount + 1, .Dr(0), .Dr(1), .Dr(2), .Dr(3), .Dr(4), .Dr(5), Format(.Dr(6), "dd-MM-yyyy"))
            End While
            .Cerrar()
        End With
    End Sub

    Public Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString
                exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            'Aplicación visible
            exApp.Application.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True
    End Function
    Private Sub btnexcel_Click(sender As Object, e As EventArgs) Handles btnexcel.Click
        GridAExcel(dgventas)
    End Sub

    Private Sub frmlistadoventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_LISTARVENTAST"
            '.Cmd.Parameters.AddWithValue("@nombclt", txtclientes.Text)
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                dgventas.Rows.Add(dgventas.RowCount + 1, .Dr(0), .Dr(1), .Dr(2), .Dr(3), .Dr(4), .Dr(5), Format(.Dr(6), "dd-MM-yyyy"))
            End While
            .Cerrar()
        End With
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class
Imports System.Globalization
Imports System.Windows.Forms
Imports DATOS
Imports Negocio
Public Class frmventa
    Dim objcn As New Conexion
    Dim WithEvents app As New Validacion
    Dim reg As New Procesos.Venta
    Private Sub btnnuevocliene_Click(sender As Object, e As EventArgs) Handles btnnuevocliene.Click
        frmmantenimientocliente.Show()
    End Sub

    Public coduser, nombreuser, nombreempleado As String
    Sub obtusers()
        txtcodcliente.Text = ""
        nombreuser = MDIMENU.lbluser.Text.Remove(0, 9)
        nombreempleado = nombreuser.ToString
        coduser = MDIMENU.codigousuario.ToString
        'MsgBox("Coduuser: " & coduser)
    End Sub
    Sub llenarboleto()
        Try
            With frmcomprobante
                .lblnumeroboleta.Text = serieb & "-" & txtcodventa.Text
                .lblserienumboleta.Text = serieb & "-" & txtcodventa.Text
                .lbldni.Text = txtdni.Text
                .lblpasajero.Text = txtapaterno.Text & " " & txtamaterno.Text & ", " & txtnombre.Text
                .lblhorapartida.Text = txthsalida.Text
                .lblfecviaje.Text = txtfechaviaje.Text
                .lblfecexpedicion.Text = Format(Now(), "dd/MM/yyyy")
                .lblorigen.Text = txtorigen.Text
                .lbldestino.Text = txtdestino.Text
                .lblasiento.Text = lblnasiento.Text
                .lblprecio.Text = txtimporte.Text
                .lblvalorventa.Text = txtimporte.Text
                .lblempleado.Text = nombreempleado
                .lblprecioescrito.Text = (Numalet.ToCardinal(txtimporte.Text, New CultureInfo("en-US")) & "  Nuevos Soles").ToUpper

                .Show()
            End With
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        ' MessageBox.Show(Numalet.ToCardinal(txtpago.Text, New CultureInfo("en-US")))
        Try
            If txtcodcliente.Text = "" Then
                MsgBox("SELECCIONE O REGISTRE UN CLIENTE", 64, "AVISO!!!")
                txtcodcliente.Focus()
            ElseIf txtorigen.Text = "" Then
                MsgBox("Ingrese Ciudad de Origen", 64, "AVISO!!!")
                txtorigen.Focus()
            ElseIf lblnasiento.Text = "#" Then
                MsgBox("SELECCINE ASIENTO A VENDER", 64, "AVISO!!!")
                lblnasiento.Focus()
            ElseIf txtpago.Text = "" Then
                MsgBox("Ingrese Monto de Pago", 64, "AVISO!!!")
                txtpago.Focus()
            Else
                If (MsgBox("¿ESTÁ SEGURO DE REGISTRAR ESTA VENTA?", 36, "Sistema") = 6) Then
                    With reg
                        .codventa = txtcodventa.Text
                        .fechaventa = Format(Now(), "dd-MM-yyyy")
                        .idprogramacion = txtidprogramacion.Text
                        .iduser = coduser
                        .numasiento = lblnasiento.Text
                        .idcliente = txtcodcliente.Text
                        .importe = txtimporte.Text
                        .fechaviaje = txtfechaviaje.Text
                        app.REGISTRAVENTA(reg)
                    End With
                    llenarboleto()
                    obtcodventa()
                Else
                    MsgBox("VENTA NO REGISTRADA", 64, "AVISO!!!")
                    limpiardaosclt()
                    limpiardatosviaje()
                End If
                limpiardaosclt()
                limpiardatosviaje()
            End If


        Catch ex As Exception

        End Try
    End Sub
    Dim serienum As Integer
    Dim codigoaut, substring, serieb As String
    Sub obtcodventa()
        Try
            txtcodventa.ResetText()

            With objcn
                .Abrir()
                .Cmd.CommandText = "SP_GENERARCODVENTA"
                .Dr = .Cmd.ExecuteReader
                While .Dr.Read()
                    codigoaut = .Dr("CODIGO").ToString().Substring(1, 4)
                    serienum = Val(codigoaut).ToString.Length
                    serieb = Format(serienum, "00#")
                    txtcodventa.Text = "B" & (Format(Val(codigoaut) + 1, "000#"))

                End While
                .Cerrar()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmventa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtusers()
        Me.lblhora.Text = String.Format("{0:hh:mm:ss  tt}", DateTime.Now)

        Timer1.Interval = 1000  ' Un segundo
        Timer1.Start()
        'obtcodventa()
    End Sub
    Sub filtarclientes()
        dgcliente.Visible = True
        Me.dgcliente.Rows.Clear()

        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_filtrarCliente"
            .Cmd.Parameters.AddWithValue("@dni_clie", txtbuscar.Text)
            .Cmd.ExecuteNonQuery()
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                Me.dgcliente.Rows.Add(.Dr(0), .Dr(1), .Dr(2), .Dr(3), .Dr(4), .Dr(5), .Dr(6), .Dr(7), .Dr(8))
            End While
            .Cmd.Parameters.Clear()
            .Cerrar()
        End With
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblhora.Text = String.Format("{0:hh:mm:ss  tt}", DateTime.Now)
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btnprogramacion_Click(sender As Object, e As EventArgs) Handles btnprogramacion.Click
        frmProgramacion.Show()

    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        filtarclientes()

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn1.Text), "0#")
            Me.btn1.ForeColor = Drawing.Color.Red
            Me.btn1.Enabled = False
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn2.Text), "0#")
            Me.btn2.ForeColor = Drawing.Color.Red
            Me.btn2.Enabled = False
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn3.Text), "0#")
            Me.btn3.ForeColor = Drawing.Color.Red
            Me.btn3.Enabled = False
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn4.Text), "0#")
            Me.btn4.ForeColor = Drawing.Color.Red
            Me.btn4.Enabled = False
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn5.Text), "0#")
            Me.btn5.ForeColor = Drawing.Color.Red
            Me.btn5.Enabled = False
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn6.Text), "0#")
            Me.btn6.ForeColor = Drawing.Color.Red
            Me.btn6.Enabled = False
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn7.Text), "0#")
            Me.btn7.ForeColor = Drawing.Color.Red
            Me.btn7.Enabled = False
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn8.Text), "0#")
            Me.btn8.ForeColor = Drawing.Color.Red
            Me.btn8.Enabled = False
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn9.Text), "0#")
            Me.btn9.ForeColor = Drawing.Color.Red
            Me.btn9.Enabled = False
        End If
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn10.Text), "0#")
            Me.btn10.ForeColor = Drawing.Color.Red
            Me.btn10.Enabled = False
        End If
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn11.Text), "0#")
            Me.btn11.ForeColor = Drawing.Color.Red
            Me.btn11.Enabled = False
        End If
    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn12.Text), "0#")
            Me.btn12.ForeColor = Drawing.Color.Red
            Me.btn12.Enabled = False
        End If
    End Sub

    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn13.Text), "0#")
            Me.btn13.ForeColor = Drawing.Color.Red
            Me.btn13.Enabled = False
        End If
    End Sub

    Private Sub btn14_Click(sender As Object, e As EventArgs) Handles btn14.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn14.Text), "0#")
            Me.btn14.ForeColor = Drawing.Color.Red
            Me.btn14.Enabled = False
        End If
    End Sub

    Private Sub btn15_Click(sender As Object, e As EventArgs) Handles btn15.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn15.Text), "0#")
            Me.btn15.ForeColor = Drawing.Color.Red
            Me.btn15.Enabled = False
        End If
    End Sub

    Private Sub btn16_Click(sender As Object, e As EventArgs) Handles btn16.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn16.Text), "0#")
            Me.btn16.ForeColor = Drawing.Color.Red
            Me.btn16.Enabled = False
        End If
    End Sub

    Private Sub btn17_Click(sender As Object, e As EventArgs) Handles btn17.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn17.Text), "0#")
            Me.btn17.ForeColor = Drawing.Color.Red
            Me.btn17.Enabled = False
        End If
    End Sub

    Private Sub btn18_Click(sender As Object, e As EventArgs) Handles btn18.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn18.Text), "0#")
            Me.btn18.ForeColor = Drawing.Color.Red
            Me.btn18.Enabled = False
        End If
    End Sub

    Private Sub btn19_Click(sender As Object, e As EventArgs) Handles btn19.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn19.Text), "0#")
            Me.btn19.ForeColor = Drawing.Color.Red
            Me.btn19.Enabled = False
        End If
    End Sub

    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn20.Text), "0#")
            Me.btn20.ForeColor = Drawing.Color.Red
            Me.btn20.Enabled = False
        End If
    End Sub

    Private Sub btn21_Click(sender As Object, e As EventArgs) Handles btn21.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn21.Text), "0#")
            Me.btn21.ForeColor = Drawing.Color.Red
            Me.btn21.Enabled = False
        End If
    End Sub

    Private Sub btn22_Click(sender As Object, e As EventArgs) Handles btn22.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn22.Text), "0#")
            Me.btn22.ForeColor = Drawing.Color.Red
            Me.btn22.Enabled = False
        End If
    End Sub

    Private Sub btn23_Click(sender As Object, e As EventArgs) Handles btn23.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn23.Text), "0#")
            Me.btn23.ForeColor = Drawing.Color.Red
            Me.btn23.Enabled = False
        End If
    End Sub

    Private Sub btn24_Click(sender As Object, e As EventArgs) Handles btn24.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn24.Text), "0#")
            Me.btn24.ForeColor = Drawing.Color.Red
            Me.btn24.Enabled = False
        End If
    End Sub

    Private Sub btn25_Click(sender As Object, e As EventArgs) Handles btn25.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn25.Text), "0#")
            Me.btn25.ForeColor = Drawing.Color.Red
            Me.btn25.Enabled = False
        End If
    End Sub

    Private Sub btn26_Click(sender As Object, e As EventArgs) Handles btn26.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn26.Text), "0#")
            Me.btn26.ForeColor = Drawing.Color.Red
            Me.btn26.Enabled = False
        End If
    End Sub

    Private Sub btn27_Click(sender As Object, e As EventArgs) Handles btn27.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn27.Text), "0#")
            Me.btn27.ForeColor = Drawing.Color.Red
            Me.btn27.Enabled = False
        End If
    End Sub

    Private Sub btn28_Click(sender As Object, e As EventArgs) Handles btn28.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn28.Text), "0#")
            Me.btn28.ForeColor = Drawing.Color.Red
            Me.btn28.Enabled = False
        End If
    End Sub

    Private Sub btn29_Click(sender As Object, e As EventArgs) Handles btn29.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn29.Text), "0#")
            Me.btn29.ForeColor = Drawing.Color.Red
            Me.btn29.Enabled = False
        End If
    End Sub

    Private Sub btn30_Click(sender As Object, e As EventArgs) Handles btn30.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn30.Text), "0#")
            Me.btn30.ForeColor = Drawing.Color.Red
            Me.btn30.Enabled = False
        End If
    End Sub

    Private Sub btn31_Click(sender As Object, e As EventArgs) Handles btn31.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn31.Text), "0#")
            Me.btn31.ForeColor = Drawing.Color.Red
            Me.btn31.Enabled = False
        End If
    End Sub

    Private Sub btn32_Click(sender As Object, e As EventArgs) Handles btn32.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn32.Text), "0#")
            Me.btn32.ForeColor = Drawing.Color.Red
            Me.btn32.Enabled = False
        End If
    End Sub

    Private Sub btn33_Click(sender As Object, e As EventArgs) Handles btn33.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn33.Text), "0#")
            Me.btn33.ForeColor = Drawing.Color.Red
            Me.btn33.Enabled = False
        End If
    End Sub

    Private Sub btn34_Click(sender As Object, e As EventArgs) Handles btn34.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn34.Text), "0#")
            Me.btn34.ForeColor = Drawing.Color.Red
            Me.btn34.Enabled = False
        End If
    End Sub

    Private Sub btn35_Click(sender As Object, e As EventArgs) Handles btn35.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn35.Text), "0#")
            Me.btn35.ForeColor = Drawing.Color.Red
            Me.btn35.Enabled = False
        End If
    End Sub

    Private Sub btn36_Click(sender As Object, e As EventArgs) Handles btn36.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn36.Text), "0#")
            Me.btn36.ForeColor = Drawing.Color.Red
            Me.btn36.Enabled = False
        End If
    End Sub

    Private Sub btn37_Click(sender As Object, e As EventArgs) Handles btn37.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn37.Text), "0#")
            Me.btn37.ForeColor = Drawing.Color.Red
            Me.btn37.Enabled = False
        End If
    End Sub

    Private Sub btn38_Click(sender As Object, e As EventArgs) Handles btn38.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn38.Text), "0#")
            Me.btn38.ForeColor = Drawing.Color.Red
            Me.btn38.Enabled = False
        End If
    End Sub

    Private Sub btn39_Click(sender As Object, e As EventArgs) Handles btn39.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn39.Text), "0#")
            Me.btn39.ForeColor = Drawing.Color.Red
            Me.btn39.Enabled = False
        End If
    End Sub

    Private Sub btn40_Click(sender As Object, e As EventArgs) Handles btn40.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn40.Text), "0#")
            Me.btn40.ForeColor = Drawing.Color.Red
            Me.btn40.Enabled = False
        End If
    End Sub

    Private Sub btn41_Click(sender As Object, e As EventArgs) Handles btn41.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn41.Text), "0#")
            Me.btn41.ForeColor = Drawing.Color.Red
            Me.btn41.Enabled = False
        End If
    End Sub

    Private Sub btn42_Click(sender As Object, e As EventArgs) Handles btn42.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn42.Text), "0#")
            Me.btn42.ForeColor = Drawing.Color.Red
            Me.btn42.Enabled = False
        End If
    End Sub

    Private Sub btn43_Click(sender As Object, e As EventArgs) Handles btn43.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn43.Text), "0#")
            Me.btn43.ForeColor = Drawing.Color.Red
            Me.btn43.Enabled = False
        End If
    End Sub

    Private Sub btn44_Click(sender As Object, e As EventArgs) Handles btn44.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn44.Text), "0#")
            Me.btn44.ForeColor = Drawing.Color.Red
            Me.btn44.Enabled = False
        End If
    End Sub

    Private Sub btn45_Click(sender As Object, e As EventArgs) Handles btn45.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn45.Text), "0#")
            Me.btn45.ForeColor = Drawing.Color.Red
            Me.btn45.Enabled = False
        End If
    End Sub

    Private Sub btn46_Click(sender As Object, e As EventArgs) Handles btn46.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn46.Text), "0#")
            Me.btn46.ForeColor = Drawing.Color.Red
            Me.btn46.Enabled = False
        End If
    End Sub

    Private Sub btn47_Click(sender As Object, e As EventArgs) Handles btn47.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn47.Text), "0#")
            Me.btn47.ForeColor = Drawing.Color.Red
            Me.btn47.Enabled = False
        End If
    End Sub

    Private Sub btn48_Click(sender As Object, e As EventArgs) Handles btn48.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn48.Text), "0#")
            Me.btn48.ForeColor = Drawing.Color.Red
            Me.btn48.Enabled = False
        End If
    End Sub

    Private Sub btn49_Click(sender As Object, e As EventArgs) Handles btn49.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn49.Text), "0#")
            Me.btn49.ForeColor = Drawing.Color.Red
            Me.btn49.Enabled = False
        End If
    End Sub

    Private Sub btn50_Click(sender As Object, e As EventArgs) Handles btn50.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn50.Text), "0#")
            Me.btn50.ForeColor = Drawing.Color.Red
            Me.btn50.Enabled = False
        End If
    End Sub

    Private Sub btn51_Click(sender As Object, e As EventArgs) Handles btn51.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn51.Text), "0#")
            Me.btn51.ForeColor = Drawing.Color.Red
            Me.btn51.Enabled = False
        End If
    End Sub

    Private Sub btn52_Click(sender As Object, e As EventArgs) Handles btn52.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn52.Text), "0#")
            Me.btn52.ForeColor = Drawing.Color.Red
            Me.btn52.Enabled = False
        End If
    End Sub

    Private Sub btn53_Click(sender As Object, e As EventArgs) Handles btn53.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn53.Text), "0#")
            Me.btn53.ForeColor = Drawing.Color.Red
            Me.btn53.Enabled = False
        End If
    End Sub

    Private Sub btn54_Click(sender As Object, e As EventArgs) Handles btn54.Click


        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn54.Text), "0#")
            Me.btn54.ForeColor = Drawing.Color.Red
            Me.btn54.Enabled = False
        End If
    End Sub

    Private Sub btn55_Click(sender As Object, e As EventArgs) Handles btn55.Click

        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn55.Text), "0#")
            Me.btn55.ForeColor = Drawing.Color.Red
            Me.btn55.Enabled = False
        End If
    End Sub

    Private Sub btn56_Click(sender As Object, e As EventArgs) Handles btn56.Click
        If txtidprogramacion.Text = "" Then
            MsgBox("Clic en el Boton 'Seleccionar Asiento' para Iniciar Asiento")
        Else
            Me.lblnasiento.ResetText()
            Me.lblnasiento.Text = Format(Val(btn56.Text), "0#")
            Me.btn56.ForeColor = Drawing.Color.Red
            Me.btn56.Enabled = False
        End If

    End Sub
    Sub limpiardatosviaje()
        txtorigen.ResetText()
        txtdestino.ResetText()
        txtfechaviaje.ResetText()
        'txtcodventa.ResetText()
        lblhora.ResetText()
        lblnasiento.Text = "#"
        txtidprogramacion.ResetText()
        txtpago.ResetText()
        txtvuelto.ResetText()
        txtimporte.ResetText()
        txthsalida.ResetText()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiardaosclt()
        limpiardatosviaje()
        btncancelar.Enabled = False
        btnnventa.Enabled = True
        txtbuscar.ReadOnly = True
        btnnuevocliene.Enabled = False
        btnprogramacion.Enabled = False
    End Sub

    Dim numero As String
    Sub controlasiento1()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "1")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "1" Then
                    btn1.Enabled = False
                    btn1.ForeColor = Drawing.Color.Red
                Else
                    btn1.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento2()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "2")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "2" Then
                    btn2.Enabled = False
                    btn2.ForeColor = Drawing.Color.Red
                Else
                    btn2.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento3()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "3")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "3" Then
                    btn3.Enabled = False
                    btn3.ForeColor = Drawing.Color.Red
                Else
                    btn3.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento4()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "4")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "4" Then
                    btn4.Enabled = False
                    btn4.ForeColor = Drawing.Color.Red
                Else
                    btn4.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento5()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "5")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "5" Then
                    btn5.Enabled = False
                    btn5.ForeColor = Drawing.Color.Red
                Else
                    btn5.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento6()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "6")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "6" Then
                    btn6.Enabled = False
                    btn6.ForeColor = Drawing.Color.Red
                Else
                    btn6.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    ':::::::::::::::::::::::::::::::::::::::::::::
    Sub controlasiento7()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "7")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "7" Then
                    btn7.Enabled = False
                    btn7.ForeColor = Drawing.Color.Red
                Else
                    btn7.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento8()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "8")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "8" Then
                    btn8.Enabled = False
                    btn8.ForeColor = Drawing.Color.Red
                Else
                    btn8.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento9()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "9")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "9" Then
                    btn9.Enabled = False
                    btn9.ForeColor = Drawing.Color.Red
                Else
                    btn9.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento10()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "10")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "10" Then
                    btn10.Enabled = False
                    btn10.ForeColor = Drawing.Color.Red
                Else
                    btn10.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento11()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "11")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "11" Then
                    btn11.Enabled = False
                    btn11.ForeColor = Drawing.Color.Red
                Else
                    btn11.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento12()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "12")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "12" Then
                    btn12.Enabled = False
                    btn12.ForeColor = Drawing.Color.Red
                Else
                    btn12.Enabled = True
                End If
            End While

            .Cerrar()
        End With

    End Sub

    Sub controlasiento13()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "13")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "13" Then
                    btn13.Enabled = False
                    btn13.ForeColor = Drawing.Color.Red
                Else
                    btn13.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento14()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "14")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "14" Then
                    btn14.Enabled = False
                    btn14.ForeColor = Drawing.Color.Red
                Else
                    btn14.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento15()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "15")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "15" Then
                    btn15.Enabled = False
                    btn15.ForeColor = Drawing.Color.Red
                Else
                    btn15.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento16()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "16")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "16" Then
                    btn16.Enabled = False
                    btn16.ForeColor = Drawing.Color.Red
                Else
                    btn16.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento17()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "17")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "17" Then
                    btn17.Enabled = False
                    btn17.ForeColor = Drawing.Color.Red
                Else
                    btn17.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento18()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "18")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "18" Then
                    btn18.Enabled = False
                    btn18.ForeColor = Drawing.Color.Red
                Else
                    btn18.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    ':::::::::::::::::::::::::::::::::::::::::::::
    Sub controlasiento19()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "19")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "19" Then
                    btn19.Enabled = False
                    btn19.ForeColor = Drawing.Color.Red
                Else
                    btn19.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento20()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "20")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "20" Then
                    btn20.Enabled = False
                    btn20.ForeColor = Drawing.Color.Red
                Else
                    btn20.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento21()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "21")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "21" Then
                    btn21.Enabled = False
                    btn21.ForeColor = Drawing.Color.Red
                Else
                    btn21.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento22()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "22")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "22" Then
                    btn22.Enabled = False
                    btn22.ForeColor = Drawing.Color.Red
                Else
                    btn22.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento23()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "23")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "23" Then
                    btn23.Enabled = False
                    btn23.ForeColor = Drawing.Color.Red
                Else
                    btn23.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento24()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "24")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "24" Then
                    btn24.Enabled = False
                    btn24.ForeColor = Drawing.Color.Red
                Else
                    btn24.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub

    Sub controlasiento25()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "25")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "25" Then
                    btn25.Enabled = False
                    btn25.ForeColor = Drawing.Color.Red
                Else
                    btn25.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub

    Sub controlasiento26()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "26")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "26" Then
                    btn26.Enabled = False
                    btn26.ForeColor = Drawing.Color.Red
                Else
                    btn26.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento27()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "27")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "27" Then
                    btn27.Enabled = False
                    btn27.ForeColor = Drawing.Color.Red
                Else
                    btn27.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento28()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "28")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "28" Then
                    btn28.Enabled = False
                    btn28.ForeColor = Drawing.Color.Red
                Else
                    btn28.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento29()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "29")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "29" Then
                    btn29.Enabled = False
                    btn29.ForeColor = Drawing.Color.Red
                Else
                    btn29.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub

    Sub controlasiento30()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "30")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "30" Then
                    btn30.Enabled = False
                    btn30.ForeColor = Drawing.Color.Red
                Else
                    btn30.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento31()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "31")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "31" Then
                    btn31.Enabled = False
                    btn31.ForeColor = Drawing.Color.Red
                Else
                    btn31.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub

    Sub controlasiento32()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "32")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "32" Then
                    btn32.Enabled = False
                    btn32.ForeColor = Drawing.Color.Red
                Else
                    btn32.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub

    Sub controlasiento33()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "33")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "33" Then
                    btn33.Enabled = False
                    btn33.ForeColor = Drawing.Color.Red
                Else
                    btn33.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento34()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "34")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "34" Then
                    btn34.Enabled = False
                    btn34.ForeColor = Drawing.Color.Red
                Else
                    btn34.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento35()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "35")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "35" Then
                    btn35.Enabled = False
                    btn35.ForeColor = Drawing.Color.Red
                Else
                    btn35.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento36()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "36")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "36" Then
                    btn36.Enabled = False
                    btn36.ForeColor = Drawing.Color.Red
                Else
                    btn36.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento37()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "37")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "37" Then
                    btn37.Enabled = False
                    btn37.ForeColor = Drawing.Color.Red
                Else
                    btn37.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento38()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "38")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "38" Then
                    btn38.Enabled = False
                    btn38.ForeColor = Drawing.Color.Red
                Else
                    btn38.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento39()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "39")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "39" Then
                    btn39.Enabled = False
                    btn39.ForeColor = Drawing.Color.Red
                Else
                    btn39.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento40()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "40")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "40" Then
                    btn40.Enabled = False
                    btn40.ForeColor = Drawing.Color.Red
                Else
                    btn40.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub

    Sub controlasiento41()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "41")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "41" Then
                    btn41.Enabled = False
                    btn41.ForeColor = Drawing.Color.Red
                Else
                    btn41.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento42()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "42")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "42" Then
                    btn42.Enabled = False
                    btn42.ForeColor = Drawing.Color.Red
                Else
                    btn42.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento43()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "43")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "43" Then
                    btn43.Enabled = False
                    btn43.ForeColor = Drawing.Color.Red
                Else
                    btn43.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento44()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "44")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "44" Then
                    btn44.Enabled = False
                    btn44.ForeColor = Drawing.Color.Red
                Else
                    btn44.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento45()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "45")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "45" Then
                    btn45.Enabled = False
                    btn45.ForeColor = Drawing.Color.Red
                Else
                    btn45.Enabled = True
                End If
            End While

            .Cerrar()
        End With

    End Sub

    Sub controlasiento46()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "46")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "46" Then
                    btn46.Enabled = False
                    btn46.ForeColor = Drawing.Color.Red
                Else
                    btn46.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento47()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "47")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "47" Then
                    btn47.Enabled = False
                    btn47.ForeColor = Drawing.Color.Red
                Else
                    btn47.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento48()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "48")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "48" Then
                    btn48.Enabled = False
                    btn48.ForeColor = Drawing.Color.Red
                Else
                    btn48.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento49()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "49")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "49" Then
                    btn49.Enabled = False
                    btn49.ForeColor = Drawing.Color.Red
                Else
                    btn49.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub

    Sub controlasiento50()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "50")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "50" Then
                    btn50.Enabled = False
                    btn50.ForeColor = Drawing.Color.Red
                Else
                    btn50.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub

    Sub controlasiento51()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "51")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "51" Then
                    btn51.Enabled = False
                    btn51.ForeColor = Drawing.Color.Red
                Else
                    btn51.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento52()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "52")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "52" Then
                    btn52.Enabled = False
                    btn52.ForeColor = Drawing.Color.Red
                Else
                    btn52.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento53()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "53")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "53" Then
                    btn53.Enabled = False
                    btn53.ForeColor = Drawing.Color.Red
                Else
                    btn53.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento54()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "54")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "54" Then
                    btn54.Enabled = False
                    btn54.ForeColor = Drawing.Color.Red
                Else
                    btn54.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento55()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "55")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "55" Then
                    btn55.Enabled = False
                    btn55.ForeColor = Drawing.Color.Red
                Else
                    btn55.Enabled = True
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Sub controlasiento56()
        With objcn
            .Abrir()
            .Cmd.CommandText = "SP_CONSULTARASIENTOS"
            .Cmd.Parameters.AddWithValue("@codprogramacion", txtidprogramacion.Text)
            .Cmd.Parameters.AddWithValue("@numasientos", "56")
            .Dr = .Cmd.ExecuteReader
            While .Dr.Read
                numero = .Dr(2)
                If numero = "56" Then
                    btn56.Enabled = False
                    btn56.ForeColor = Drawing.Color.Red
                Else
                    btn56.Enabled = True
                    btn56.ForeColor = Drawing.Color.Black
                End If
            End While

            .Cerrar()
        End With
    End Sub
    Private Sub BTNASIENTOS_Click(sender As Object, e As EventArgs) Handles BTNASIENTOS.Click
        If txtidprogramacion.Text.Trim <> "" Then
            controlasiento1()
            controlasiento2()
            controlasiento3()
            controlasiento4()
            controlasiento5()
            controlasiento6()
            controlasiento7()
            controlasiento8()
            controlasiento9()
            controlasiento10()
            controlasiento11()
            controlasiento12()
            controlasiento13()
            controlasiento14()
            controlasiento15()
            controlasiento16()
            controlasiento17()
            controlasiento18()
            controlasiento19()
            controlasiento20()
            controlasiento21()
            controlasiento22()
            controlasiento23()
            controlasiento24()
            controlasiento25()
            controlasiento26()
            controlasiento27()
            controlasiento28()
            controlasiento29()
            controlasiento30()
            controlasiento31()
            controlasiento32()
            controlasiento33()
            controlasiento34()
            controlasiento35()
            controlasiento36()
            controlasiento37()
            controlasiento38()
            controlasiento39()
            controlasiento40()
            controlasiento41()
            controlasiento42()
            controlasiento43()
            controlasiento44()
            controlasiento45()
            controlasiento46()
            controlasiento47()
            controlasiento48()
            controlasiento49()
            controlasiento50()
            controlasiento51()
            controlasiento52()
            controlasiento53()
            controlasiento54()
            controlasiento55()
            controlasiento56()
        Else
            MsgBox("Antes de Seleccionar un Asiento debe Llenar Datos del viaje", 64, "Aviso")
        End If
    End Sub

    Private Sub btnnventa_Click(sender As Object, e As EventArgs) Handles btnnventa.Click
        obtcodventa()
        limpiardaosclt()
        limpiardatosviaje()
        btnguardar.Enabled = True
        btncancelar.Enabled = True
        btnnuevocliene.Enabled = True
        txtbuscar.ReadOnly = False
        btnnventa.Enabled = False
        btnprogramacion.Enabled = True
    End Sub

    Sub limpiardaosclt()
        With Me
            .txtdni.ResetText()
            .txtapaterno.ResetText()
            .txtamaterno.ResetText()
            .txtnombre.ResetText()
            .cbosexo.ResetText()
            .txtemail.ResetText()
            .txtfono.ResetText()
            .txtcodcliente.ResetText()
        End With
    End Sub

    Private Sub dgcliente_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgcliente.MouseDoubleClick
        If dgcliente.SelectedRows.Count > 0 Then
            limpiardaosclt()
            Me.txtcodcliente.Text = dgcliente.Item(0, dgcliente.SelectedRows(0).Index).Value
            Me.txtdni.Text = dgcliente.Item(1, dgcliente.SelectedRows(0).Index).Value
            Me.txtapaterno.Text = dgcliente.Item(2, dgcliente.SelectedRows(0).Index).Value
            Me.txtamaterno.Text = dgcliente.Item(3, dgcliente.SelectedRows(0).Index).Value
            Me.txtnombre.Text = dgcliente.Item(4, dgcliente.SelectedRows(0).Index).Value
            Me.cbosexo.SelectedText = dgcliente.Item(6, dgcliente.SelectedRows(0).Index).Value
            Me.txtemail.Text = dgcliente.Item(7, dgcliente.SelectedRows(0).Index).Value
            Me.txtfono.Text = dgcliente.Item(8, dgcliente.SelectedRows(0).Index).Value
            Me.dgcliente.Hide()
            Me.txtbuscar.ResetText()
        Else
            MsgBox("Seleccione un Registro", "Aviso", 64)
        End If
    End Sub

    Private Sub txtpago_TextChanged(sender As Object, e As EventArgs) Handles txtpago.TextChanged
        If txtpago.Text >= txtimporte.Text Then
            txtvuelto.Text = Val(txtpago.Text) - Val(txtimporte.Text)
        Else
            txtvuelto.Text = "Insuficiente"
        End If
    End Sub

End Class
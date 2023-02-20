Imports System.Net
Imports System.Net.Mail
Imports System.Windows.Forms

Public Class frmcorreos
    Private correo As New MailMessage
    Private autenticar As New NetworkCredential
    Private envio As New SmtpClient
    Private Sub Button_enviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_enviar.Click
        'llamo al procedimiento
        enviar_correo()
    End Sub


    Sub enviar_correo()

        Try
            correo.Body = Me.TextBox_mensaje.Text  'aqui va el cuerpo del mensaje
            correo.Subject = Me.TextBox_asunto.Text  'aqui va el asunto
            correo.IsBodyHtml = True
            correo.To.Add(Trim(Me.TextBox_destino.Text))  'aqui va el destinatario
            correo.To.Add(Trim("micorreo@hotmail.com"))  'este es otro destinatario
            correo.To.Add(Trim("minumero@movistar.com.co"))   'para enviar a un celular


            'ahora se especifica la cuenta desde la que se envia el correo
            correo.From = New MailAddress(Me.TextBox_user.Text.Trim, "Mensajeria 1.0 vb.net ®")

            'ahora indicamos el usuario y la contraseña de la persona que envia el e-mail
            envio.Credentials = New NetworkCredential(Me.TextBox_user.Text.Trim, Me.TextBox_pass.Text.Trim)


            'verifico si es hotmail, gmail o yahoo
            '------------------------------------------------------------------------------------------------
            If (RadioButton_yahoo.Checked = True) Then
                'el correo es enviado desde yahoo

                envio.Host = "smtp.correo.yahoo.es"                     'este esl el que utilizamos por la configuracion de smtp (Simple Mail Transfer Protocol) 
                envio.Port = 587 'Puerto del Servidor smtp"             'gmail y yahoo usan el puerto 587, mientras que hotmail usa el 25
                envio.EnableSsl = False                                 'el servidor de yahoo.es no admite conexiones seguras, por eso se le asigna false, mientas que gmail y hotmail si la admiten
                'correo.Attachments                                     'aqui se envian mensajes adjuntos
            End If

            If (RadioButton_hotmail.Checked = True) Then
                'el correo es enviado desde hotmail
                envio.Host = "smtp.live.com"                            'este esl el que utilizamos por la configuracion de smtp (Simple Mail Transfer Protocol) 
                envio.Port = 25 'Puerto del Servidor smtp"             'gmail y yahoo usan el puerto 587, mientras que hotmail usa el 25
                envio.EnableSsl = True                                 'el servidor de yahoo.es no admite conexiones seguras, por eso se le asigna false, mientas que gmail y hotmail si la admiten
                'correo.Attachments                                     'aqui se envian mensajes adjuntos

            End If


            If (RadioButton_gmail.Checked = True) Then
                'el correo es enviado desde gmail
                envio.Host = "smtp.gmail.com"                          'este esl el que utilizamos por la configuracion de smtp (Simple Mail Transfer Protocol) 
                envio.Port = 587 'Puerto del Servidor smtp"             'gmail y yahoo usan el puerto 587, mientras que hotmail usa el 25
                envio.EnableSsl = True                                 'el servidor de yahoo.es no admite conexiones seguras, por eso se le asigna false, mientas que gmail y hotmail si la admiten
                'correo.Attachments                                     'aqui se envian mensajes adjuntos

            End If

            '-------------------------------------------------------------

            'Procedo a enviar el correo
            envio.Send(correo)
            MessageBox.Show("Correo Enviado exitosamente...", "Sistema de venta de Pasajes v.1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sistema de Venta de Pasajes v.1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

End Class

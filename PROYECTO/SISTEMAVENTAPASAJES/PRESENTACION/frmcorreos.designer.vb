<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcorreos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcorreos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button_enviar = New System.Windows.Forms.Button()
        Me.TextBox_mensaje = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_asunto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_destino = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_pass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_user = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_gmail = New System.Windows.Forms.RadioButton()
        Me.RadioButton_hotmail = New System.Windows.Forms.RadioButton()
        Me.RadioButton_yahoo = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(565, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Binvenido a su Asistente de Mensajeria y Recuperación de Clave"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(749, 432)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Especifiquenos Lo Siguiente Por Favor"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button_enviar)
        Me.GroupBox4.Controls.Add(Me.TextBox_mensaje)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.TextBox_asunto)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.TextBox_destino)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(21, 188)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(710, 235)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Enviar a"
        '
        'Button_enviar
        '
        Me.Button_enviar.Location = New System.Drawing.Point(552, 38)
        Me.Button_enviar.Name = "Button_enviar"
        Me.Button_enviar.Size = New System.Drawing.Size(112, 63)
        Me.Button_enviar.TabIndex = 9
        Me.Button_enviar.Text = "Enviar"
        Me.Button_enviar.UseVisualStyleBackColor = True
        '
        'TextBox_mensaje
        '
        Me.TextBox_mensaje.Location = New System.Drawing.Point(158, 126)
        Me.TextBox_mensaje.Multiline = True
        Me.TextBox_mensaje.Name = "TextBox_mensaje"
        Me.TextBox_mensaje.Size = New System.Drawing.Size(506, 91)
        Me.TextBox_mensaje.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Cuerpo del Mensaje"
        '
        'TextBox_asunto
        '
        Me.TextBox_asunto.Location = New System.Drawing.Point(158, 77)
        Me.TextBox_asunto.Name = "TextBox_asunto"
        Me.TextBox_asunto.Size = New System.Drawing.Size(319, 26)
        Me.TextBox_asunto.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Asunto"
        '
        'TextBox_destino
        '
        Me.TextBox_destino.Location = New System.Drawing.Point(158, 39)
        Me.TextBox_destino.Name = "TextBox_destino"
        Me.TextBox_destino.Size = New System.Drawing.Size(319, 26)
        Me.TextBox_destino.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "E-mail Destinatario"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TextBox_pass)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TextBox_user)
        Me.GroupBox3.Location = New System.Drawing.Point(346, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(325, 117)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Login de Cuenta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Contraseña"
        '
        'TextBox_pass
        '
        Me.TextBox_pass.Location = New System.Drawing.Point(111, 67)
        Me.TextBox_pass.Name = "TextBox_pass"
        Me.TextBox_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_pass.Size = New System.Drawing.Size(186, 26)
        Me.TextBox_pass.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario"
        '
        'TextBox_user
        '
        Me.TextBox_user.Location = New System.Drawing.Point(111, 32)
        Me.TextBox_user.Name = "TextBox_user"
        Me.TextBox_user.Size = New System.Drawing.Size(186, 26)
        Me.TextBox_user.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton_gmail)
        Me.GroupBox2.Controls.Add(Me.RadioButton_hotmail)
        Me.GroupBox2.Controls.Add(Me.RadioButton_yahoo)
        Me.GroupBox2.Location = New System.Drawing.Point(52, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(142, 129)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Su Cuenta de Correo es"
        '
        'RadioButton_gmail
        '
        Me.RadioButton_gmail.AutoSize = True
        Me.RadioButton_gmail.Location = New System.Drawing.Point(30, 88)
        Me.RadioButton_gmail.Name = "RadioButton_gmail"
        Me.RadioButton_gmail.Size = New System.Drawing.Size(59, 22)
        Me.RadioButton_gmail.TabIndex = 2
        Me.RadioButton_gmail.TabStop = True
        Me.RadioButton_gmail.Text = "Gmail"
        Me.RadioButton_gmail.UseVisualStyleBackColor = True
        '
        'RadioButton_hotmail
        '
        Me.RadioButton_hotmail.AutoSize = True
        Me.RadioButton_hotmail.Location = New System.Drawing.Point(30, 42)
        Me.RadioButton_hotmail.Name = "RadioButton_hotmail"
        Me.RadioButton_hotmail.Size = New System.Drawing.Size(72, 22)
        Me.RadioButton_hotmail.TabIndex = 0
        Me.RadioButton_hotmail.TabStop = True
        Me.RadioButton_hotmail.Text = "Hotmail"
        Me.RadioButton_hotmail.UseVisualStyleBackColor = True
        '
        'RadioButton_yahoo
        '
        Me.RadioButton_yahoo.AutoSize = True
        Me.RadioButton_yahoo.Location = New System.Drawing.Point(30, 65)
        Me.RadioButton_yahoo.Name = "RadioButton_yahoo"
        Me.RadioButton_yahoo.Size = New System.Drawing.Size(63, 22)
        Me.RadioButton_yahoo.TabIndex = 1
        Me.RadioButton_yahoo.TabStop = True
        Me.RadioButton_yahoo.Text = "Yahoo"
        Me.RadioButton_yahoo.UseVisualStyleBackColor = True
        '
        'frmcorreos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(772, 530)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmcorreos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORMULARIO DE ENVIO DE CORREOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_user As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_gmail As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_hotmail As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_yahoo As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_pass As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox_mensaje As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox_asunto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox_destino As System.Windows.Forms.TextBox
    Friend WithEvents Button_enviar As System.Windows.Forms.Button

End Class

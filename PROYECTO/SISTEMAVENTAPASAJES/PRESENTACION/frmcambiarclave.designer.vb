Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcambiarclave
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcambiarclave))
        Me.grdatos = New System.Windows.Forms.GroupBox()
        Me.pcimage = New System.Windows.Forms.PictureBox()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.btnrc1 = New System.Windows.Forms.Button()
        Me.btnrc2 = New System.Windows.Forms.Button()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.txtclave2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.txtnivel = New System.Windows.Forms.TextBox()
        Me.txtnomacceso = New System.Windows.Forms.TextBox()
        Me.txtclave1 = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtnombrecomp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.dguser = New System.Windows.Forms.DataGridView()
        Me.grdatos.SuspendLayout()
        CType(Me.pcimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dguser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdatos
        '
        Me.grdatos.BackColor = System.Drawing.Color.Transparent
        Me.grdatos.Controls.Add(Me.pcimage)
        Me.grdatos.Controls.Add(Me.lblusuario)
        Me.grdatos.Controls.Add(Me.btnrc1)
        Me.grdatos.Controls.Add(Me.btnrc2)
        Me.grdatos.Controls.Add(Me.lblestado)
        Me.grdatos.Controls.Add(Me.txtclave2)
        Me.grdatos.Controls.Add(Me.Label7)
        Me.grdatos.Controls.Add(Me.PictureBox1)
        Me.grdatos.Controls.Add(Me.Label6)
        Me.grdatos.Controls.Add(Me.txtbuscar)
        Me.grdatos.Controls.Add(Me.txtnivel)
        Me.grdatos.Controls.Add(Me.txtnomacceso)
        Me.grdatos.Controls.Add(Me.txtclave1)
        Me.grdatos.Controls.Add(Me.txtcodigo)
        Me.grdatos.Controls.Add(Me.txtnombrecomp)
        Me.grdatos.Controls.Add(Me.Label5)
        Me.grdatos.Controls.Add(Me.Label4)
        Me.grdatos.Controls.Add(Me.Label3)
        Me.grdatos.Controls.Add(Me.Label2)
        Me.grdatos.Controls.Add(Me.Label1)
        Me.grdatos.Controls.Add(Me.GroupBox1)
        Me.grdatos.Controls.Add(Me.dguser)
        Me.grdatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdatos.Location = New System.Drawing.Point(12, 12)
        Me.grdatos.Name = "grdatos"
        Me.grdatos.Size = New System.Drawing.Size(957, 523)
        Me.grdatos.TabIndex = 0
        Me.grdatos.TabStop = False
        Me.grdatos.Text = "Datos de Usuarios"
        '
        'pcimage
        '
        Me.pcimage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pcimage.Image = CType(resources.GetObject("pcimage.Image"), System.Drawing.Image)
        Me.pcimage.Location = New System.Drawing.Point(612, 365)
        Me.pcimage.Name = "pcimage"
        Me.pcimage.Size = New System.Drawing.Size(82, 50)
        Me.pcimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcimage.TabIndex = 23
        Me.pcimage.TabStop = False
        Me.pcimage.Visible = False
        '
        'lblusuario
        '
        Me.lblusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusuario.ForeColor = System.Drawing.Color.Navy
        Me.lblusuario.Location = New System.Drawing.Point(367, 492)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(581, 23)
        Me.lblusuario.TabIndex = 20
        Me.lblusuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnrc1
        '
        Me.btnrc1.BackgroundImage = CType(resources.GetObject("btnrc1.BackgroundImage"), System.Drawing.Image)
        Me.btnrc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnrc1.Location = New System.Drawing.Point(531, 398)
        Me.btnrc1.Name = "btnrc1"
        Me.btnrc1.Size = New System.Drawing.Size(34, 23)
        Me.btnrc1.TabIndex = 19
        Me.btnrc1.UseVisualStyleBackColor = True
        '
        'btnrc2
        '
        Me.btnrc2.BackgroundImage = CType(resources.GetObject("btnrc2.BackgroundImage"), System.Drawing.Image)
        Me.btnrc2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnrc2.Location = New System.Drawing.Point(531, 430)
        Me.btnrc2.Name = "btnrc2"
        Me.btnrc2.Size = New System.Drawing.Size(34, 23)
        Me.btnrc2.TabIndex = 18
        Me.btnrc2.UseVisualStyleBackColor = True
        '
        'lblestado
        '
        Me.lblestado.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestado.ForeColor = System.Drawing.Color.Red
        Me.lblestado.Location = New System.Drawing.Point(700, 292)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(35, 196)
        Me.lblestado.TabIndex = 17
        Me.lblestado.Text = "ANULADO"
        Me.lblestado.Visible = False
        '
        'txtclave2
        '
        Me.txtclave2.Location = New System.Drawing.Point(140, 433)
        Me.txtclave2.MaxLength = 50
        Me.txtclave2.Name = "txtclave2"
        Me.txtclave2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtclave2.Size = New System.Drawing.Size(385, 20)
        Me.txtclave2.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 436)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "REPITA CLAVE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(759, 306)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 182)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(191, 471)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Buscar por Nombre de Acceso"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(367, 468)
        Me.txtbuscar.MaxLength = 50
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(198, 20)
        Me.txtbuscar.TabIndex = 12
        '
        'txtnivel
        '
        Me.txtnivel.Location = New System.Drawing.Point(140, 468)
        Me.txtnivel.MaxLength = 1
        Me.txtnivel.Name = "txtnivel"
        Me.txtnivel.Size = New System.Drawing.Size(45, 20)
        Me.txtnivel.TabIndex = 11
        '
        'txtnomacceso
        '
        Me.txtnomacceso.Location = New System.Drawing.Point(140, 365)
        Me.txtnomacceso.MaxLength = 50
        Me.txtnomacceso.Name = "txtnomacceso"
        Me.txtnomacceso.Size = New System.Drawing.Size(425, 20)
        Me.txtnomacceso.TabIndex = 10
        '
        'txtclave1
        '
        Me.txtclave1.Location = New System.Drawing.Point(140, 401)
        Me.txtclave1.MaxLength = 50
        Me.txtclave1.Name = "txtclave1"
        Me.txtclave1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtclave1.Size = New System.Drawing.Size(385, 20)
        Me.txtclave1.TabIndex = 9
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(140, 303)
        Me.txtcodigo.MaxLength = 4
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(160, 20)
        Me.txtcodigo.TabIndex = 8
        '
        'txtnombrecomp
        '
        Me.txtnombrecomp.Location = New System.Drawing.Point(140, 335)
        Me.txtnombrecomp.MaxLength = 100
        Me.txtnombrecomp.Name = "txtnombrecomp"
        Me.txtnombrecomp.Size = New System.Drawing.Size(425, 20)
        Me.txtnombrecomp.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 475)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "NIVEL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 404)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "CLAVE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 368)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NOMBRE DE ACCESO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 338)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NOMBRE COMPLETO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CÓDIGO"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnsalir)
        Me.GroupBox1.Controls.Add(Me.btnactualizar)
        Me.GroupBox1.Controls.Add(Me.btneditar)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 237)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(945, 54)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnsalir
        '
        Me.btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.Location = New System.Drawing.Point(773, 10)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(170, 42)
        Me.btnsalir.TabIndex = 5
        Me.btnsalir.Text = "SALIR "
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.Enabled = False
        Me.btnactualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualizar.Location = New System.Drawing.Point(411, 10)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(337, 42)
        Me.btnactualizar.TabIndex = 3
        Me.btnactualizar.Text = "GRABAR DATOS MODIFICADOS DEL USUARIO"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Enabled = False
        Me.btneditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditar.Location = New System.Drawing.Point(13, 10)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(367, 42)
        Me.btneditar.TabIndex = 2
        Me.btneditar.Text = "EDITAR DATOS DEL REGISTRO DEL USUARIO"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'dguser
        '
        Me.dguser.AllowUserToAddRows = False
        Me.dguser.AllowUserToDeleteRows = False
        Me.dguser.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.dguser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dguser.Location = New System.Drawing.Point(6, 19)
        Me.dguser.Name = "dguser"
        Me.dguser.ReadOnly = True
        Me.dguser.Size = New System.Drawing.Size(945, 212)
        Me.dguser.TabIndex = 0
        '
        'frmcambiarclave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(981, 536)
        Me.Controls.Add(Me.grdatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmcambiarclave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAMBIAR CLAVE O CONTRASEÑA DE USUARIOS"
        Me.grdatos.ResumeLayout(False)
        Me.grdatos.PerformLayout()
        CType(Me.pcimage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dguser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdatos As GroupBox
    Friend WithEvents dguser As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents txtnivel As TextBox
    Friend WithEvents txtnomacceso As TextBox
    Friend WithEvents txtclave1 As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txtnombrecomp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnactualizar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents txtclave2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblestado As Label
    Friend WithEvents btnrc1 As Button
    Friend WithEvents btnrc2 As Button
    Friend WithEvents lblusuario As Label
    Friend WithEvents pcimage As PictureBox
End Class

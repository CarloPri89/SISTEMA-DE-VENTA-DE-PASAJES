<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmantenimientousuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmantenimientousuario))
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
        Me.grcontroles = New System.Windows.Forms.GroupBox()
        Me.btnactivar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.dguser = New System.Windows.Forms.DataGridView()
        Me.Col1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdatos.SuspendLayout()
        CType(Me.pcimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grcontroles.SuspendLayout()
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
        Me.grdatos.Controls.Add(Me.grcontroles)
        Me.grdatos.Controls.Add(Me.dguser)
        Me.grdatos.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdatos.Location = New System.Drawing.Point(12, 12)
        Me.grdatos.Name = "grdatos"
        Me.grdatos.Size = New System.Drawing.Size(969, 605)
        Me.grdatos.TabIndex = 1
        Me.grdatos.TabStop = False
        Me.grdatos.Text = "Datos de Usuarios"
        '
        'pcimage
        '
        Me.pcimage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pcimage.Image = CType(resources.GetObject("pcimage.Image"), System.Drawing.Image)
        Me.pcimage.Location = New System.Drawing.Point(528, 529)
        Me.pcimage.Name = "pcimage"
        Me.pcimage.Size = New System.Drawing.Size(83, 50)
        Me.pcimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcimage.TabIndex = 23
        Me.pcimage.TabStop = False
        Me.pcimage.Visible = False
        '
        'lblusuario
        '
        Me.lblusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusuario.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblusuario.Location = New System.Drawing.Point(622, 574)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(323, 23)
        Me.lblusuario.TabIndex = 20
        '
        'btnrc1
        '
        Me.btnrc1.BackgroundImage = CType(resources.GetObject("btnrc1.BackgroundImage"), System.Drawing.Image)
        Me.btnrc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnrc1.Location = New System.Drawing.Point(528, 471)
        Me.btnrc1.Name = "btnrc1"
        Me.btnrc1.Size = New System.Drawing.Size(44, 26)
        Me.btnrc1.TabIndex = 19
        Me.btnrc1.UseVisualStyleBackColor = True
        '
        'btnrc2
        '
        Me.btnrc2.BackgroundImage = CType(resources.GetObject("btnrc2.BackgroundImage"), System.Drawing.Image)
        Me.btnrc2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnrc2.Location = New System.Drawing.Point(528, 503)
        Me.btnrc2.Name = "btnrc2"
        Me.btnrc2.Size = New System.Drawing.Size(44, 24)
        Me.btnrc2.TabIndex = 18
        Me.btnrc2.UseVisualStyleBackColor = True
        '
        'lblestado
        '
        Me.lblestado.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestado.ForeColor = System.Drawing.Color.Red
        Me.lblestado.Location = New System.Drawing.Point(645, 376)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(35, 198)
        Me.lblestado.TabIndex = 17
        Me.lblestado.Text = "ANULADO"
        Me.lblestado.Visible = False
        '
        'txtclave2
        '
        Me.txtclave2.Location = New System.Drawing.Point(186, 503)
        Me.txtclave2.MaxLength = 50
        Me.txtclave2.Name = "txtclave2"
        Me.txtclave2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtclave2.Size = New System.Drawing.Size(336, 24)
        Me.txtclave2.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 506)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "REPITA CLAVE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(720, 376)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 544)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(214, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Buscar por Nombre de Acceso"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(229, 541)
        Me.txtbuscar.MaxLength = 50
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(293, 24)
        Me.txtbuscar.TabIndex = 12
        '
        'txtnivel
        '
        Me.txtnivel.Location = New System.Drawing.Point(528, 378)
        Me.txtnivel.MaxLength = 1
        Me.txtnivel.Name = "txtnivel"
        Me.txtnivel.Size = New System.Drawing.Size(83, 24)
        Me.txtnivel.TabIndex = 11
        '
        'txtnomacceso
        '
        Me.txtnomacceso.Location = New System.Drawing.Point(186, 441)
        Me.txtnomacceso.MaxLength = 50
        Me.txtnomacceso.Name = "txtnomacceso"
        Me.txtnomacceso.Size = New System.Drawing.Size(425, 24)
        Me.txtnomacceso.TabIndex = 10
        '
        'txtclave1
        '
        Me.txtclave1.Location = New System.Drawing.Point(186, 471)
        Me.txtclave1.MaxLength = 50
        Me.txtclave1.Name = "txtclave1"
        Me.txtclave1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtclave1.Size = New System.Drawing.Size(336, 24)
        Me.txtclave1.TabIndex = 9
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(186, 378)
        Me.txtcodigo.MaxLength = 4
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(216, 24)
        Me.txtcodigo.TabIndex = 8
        '
        'txtnombrecomp
        '
        Me.txtnombrecomp.Location = New System.Drawing.Point(186, 408)
        Me.txtnombrecomp.MaxLength = 100
        Me.txtnombrecomp.Name = "txtnombrecomp"
        Me.txtnombrecomp.Size = New System.Drawing.Size(425, 24)
        Me.txtnombrecomp.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(463, 381)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "NIVEL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 474)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "CLAVE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 444)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NOMBRE DE ACCESO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 408)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NOMBRE COMPLETO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 381)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CÓDIGO"
        '
        'grcontroles
        '
        Me.grcontroles.Controls.Add(Me.btnactivar)
        Me.grcontroles.Controls.Add(Me.btnsalir)
        Me.grcontroles.Controls.Add(Me.btneliminar)
        Me.grcontroles.Controls.Add(Me.btnactualizar)
        Me.grcontroles.Controls.Add(Me.btneditar)
        Me.grcontroles.Controls.Add(Me.btnguardar)
        Me.grcontroles.Controls.Add(Me.btnnuevo)
        Me.grcontroles.Cursor = System.Windows.Forms.Cursors.Default
        Me.grcontroles.Location = New System.Drawing.Point(6, 290)
        Me.grcontroles.Name = "grcontroles"
        Me.grcontroles.Size = New System.Drawing.Size(945, 80)
        Me.grcontroles.TabIndex = 1
        Me.grcontroles.TabStop = False
        '
        'btnactivar
        '
        Me.btnactivar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnactivar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnactivar.Enabled = False
        Me.btnactivar.Location = New System.Drawing.Point(681, 19)
        Me.btnactivar.Name = "btnactivar"
        Me.btnactivar.Size = New System.Drawing.Size(161, 55)
        Me.btnactivar.TabIndex = 6
        Me.btnactivar.Text = "ACTTIVAR O ANULAR USUARIO"
        Me.btnactivar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsalir.Location = New System.Drawing.Point(848, 19)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(91, 55)
        Me.btnsalir.TabIndex = 5
        Me.btnsalir.Text = "SALIR"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneliminar.Enabled = False
        Me.btneliminar.Location = New System.Drawing.Point(560, 19)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(115, 55)
        Me.btneliminar.TabIndex = 4
        Me.btneliminar.Text = "ELIMINAR REGISTRO"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnactualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnactualizar.Enabled = False
        Me.btnactualizar.Location = New System.Drawing.Point(447, 19)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(105, 55)
        Me.btnactualizar.TabIndex = 3
        Me.btnactualizar.Text = "GRABAR CAMBIOS"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btneditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneditar.Enabled = False
        Me.btneditar.Location = New System.Drawing.Point(294, 19)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(136, 55)
        Me.btneditar.TabIndex = 2
        Me.btneditar.Text = "EDITAR DATOS DEL USUARIO"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.Enabled = False
        Me.btnguardar.Location = New System.Drawing.Point(180, 19)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(108, 55)
        Me.btnguardar.TabIndex = 1
        Me.btnguardar.Text = "GUARDAR  REGISTRO"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnuevo.Location = New System.Drawing.Point(6, 19)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(168, 55)
        Me.btnnuevo.TabIndex = 0
        Me.btnnuevo.Text = "REGISTRAR NUEVO USUARIO"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'dguser
        '
        Me.dguser.AllowUserToAddRows = False
        Me.dguser.AllowUserToDeleteRows = False
        Me.dguser.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dguser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dguser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dguser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col1, Me.Col2, Me.Col3, Me.Col4, Me.Col5, Me.Col6, Me.Col7})
        Me.dguser.Location = New System.Drawing.Point(6, 19)
        Me.dguser.Name = "dguser"
        Me.dguser.ReadOnly = True
        Me.dguser.RowHeadersVisible = False
        Me.dguser.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dguser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dguser.Size = New System.Drawing.Size(945, 265)
        Me.dguser.TabIndex = 0
        '
        'Col1
        '
        Me.Col1.Frozen = True
        Me.Col1.HeaderText = "N°"
        Me.Col1.MaxInputLength = 100
        Me.Col1.Name = "Col1"
        Me.Col1.ReadOnly = True
        '
        'Col2
        '
        Me.Col2.Frozen = True
        Me.Col2.HeaderText = "Código"
        Me.Col2.MaxInputLength = 100
        Me.Col2.Name = "Col2"
        Me.Col2.ReadOnly = True
        '
        'Col3
        '
        Me.Col3.Frozen = True
        Me.Col3.HeaderText = "Nombre Completo"
        Me.Col3.MaxInputLength = 100
        Me.Col3.Name = "Col3"
        Me.Col3.ReadOnly = True
        Me.Col3.Width = 290
        '
        'Col4
        '
        Me.Col4.Frozen = True
        Me.Col4.HeaderText = "Nombre Acceso"
        Me.Col4.MaxInputLength = 100
        Me.Col4.Name = "Col4"
        Me.Col4.ReadOnly = True
        Me.Col4.Width = 200
        '
        'Col5
        '
        Me.Col5.Frozen = True
        Me.Col5.HeaderText = "Clave"
        Me.Col5.MaxInputLength = 50
        Me.Col5.Name = "Col5"
        Me.Col5.ReadOnly = True
        '
        'Col6
        '
        Me.Col6.FillWeight = 80.0!
        Me.Col6.Frozen = True
        Me.Col6.HeaderText = "Nivel"
        Me.Col6.MaxInputLength = 5
        Me.Col6.Name = "Col6"
        Me.Col6.ReadOnly = True
        Me.Col6.Width = 80
        '
        'Col7
        '
        Me.Col7.FillWeight = 90.0!
        Me.Col7.Frozen = True
        Me.Col7.HeaderText = "Estado"
        Me.Col7.MaxInputLength = 5
        Me.Col7.Name = "Col7"
        Me.Col7.ReadOnly = True
        '
        'frmmantenimientousuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 629)
        Me.Controls.Add(Me.grdatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmmantenimientousuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANTENIMIENTO DE USUARIOS"
        Me.grdatos.ResumeLayout(False)
        Me.grdatos.PerformLayout()
        CType(Me.pcimage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grcontroles.ResumeLayout(False)
        CType(Me.dguser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdatos As System.Windows.Forms.GroupBox
    Friend WithEvents pcimage As System.Windows.Forms.PictureBox
    Friend WithEvents lblusuario As System.Windows.Forms.Label
    Friend WithEvents btnrc1 As System.Windows.Forms.Button
    Friend WithEvents btnrc2 As System.Windows.Forms.Button
    Friend WithEvents lblestado As System.Windows.Forms.Label
    Friend WithEvents txtclave2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents txtnivel As System.Windows.Forms.TextBox
    Friend WithEvents txtnomacceso As System.Windows.Forms.TextBox
    Friend WithEvents txtclave1 As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtnombrecomp As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grcontroles As System.Windows.Forms.GroupBox
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnactualizar As System.Windows.Forms.Button
    Friend WithEvents btneditar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents dguser As System.Windows.Forms.DataGridView
    Friend WithEvents Col1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnactivar As System.Windows.Forms.Button
End Class

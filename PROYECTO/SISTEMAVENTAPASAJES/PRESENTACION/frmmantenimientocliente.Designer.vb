<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmantenimientocliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmantenimientocliente))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtedad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbosexo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtfono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtamaterno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtapaterno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbuscardni = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DGClientes = New System.Windows.Forms.GroupBox()
        Me.dgcliente = New System.Windows.Forms.DataGridView()
        Me.Col1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DGClientes.SuspendLayout()
        CType(Me.dgcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtedad)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.cbosexo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtfono)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtamaterno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtapaterno)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtdni)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(682, 172)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Pasajero"
        '
        'txtedad
        '
        Me.txtedad.Location = New System.Drawing.Point(408, 37)
        Me.txtedad.MaxLength = 2
        Me.txtedad.Name = "txtedad"
        Me.txtedad.ReadOnly = True
        Me.txtedad.Size = New System.Drawing.Size(115, 22)
        Me.txtedad.TabIndex = 18
        Me.txtedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(408, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Edad Cliente"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(6, 37)
        Me.txtcodigo.MaxLength = 5
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(115, 22)
        Me.txtcodigo.TabIndex = 16
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Código Cliente"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(597, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(79, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'cbosexo
        '
        Me.cbosexo.FormattingEnabled = True
        Me.cbosexo.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.cbosexo.Location = New System.Drawing.Point(6, 133)
        Me.cbosexo.MaxLength = 1
        Me.cbosexo.Name = "cbosexo"
        Me.cbosexo.Size = New System.Drawing.Size(223, 24)
        Me.cbosexo.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Sexo"
        '
        'txtfono
        '
        Me.txtfono.Location = New System.Drawing.Point(474, 133)
        Me.txtfono.MaxLength = 10
        Me.txtfono.Name = "txtfono"
        Me.txtfono.ReadOnly = True
        Me.txtfono.Size = New System.Drawing.Size(202, 22)
        Me.txtfono.TabIndex = 11
        Me.txtfono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(474, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Telf / Cel"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(235, 133)
        Me.txtemail.MaxLength = 50
        Me.txtemail.Name = "txtemail"
        Me.txtemail.ReadOnly = True
        Me.txtemail.Size = New System.Drawing.Size(233, 22)
        Me.txtemail.TabIndex = 9
        Me.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(235, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "E-Mail"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(474, 90)
        Me.txtnombre.MaxLength = 50
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.ReadOnly = True
        Me.txtnombre.Size = New System.Drawing.Size(202, 22)
        Me.txtnombre.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(474, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nombre(s)"
        '
        'txtamaterno
        '
        Me.txtamaterno.Location = New System.Drawing.Point(235, 90)
        Me.txtamaterno.MaxLength = 50
        Me.txtamaterno.Name = "txtamaterno"
        Me.txtamaterno.ReadOnly = True
        Me.txtamaterno.Size = New System.Drawing.Size(233, 22)
        Me.txtamaterno.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellido Materno"
        '
        'txtapaterno
        '
        Me.txtapaterno.Location = New System.Drawing.Point(6, 90)
        Me.txtapaterno.MaxLength = 50
        Me.txtapaterno.Name = "txtapaterno"
        Me.txtapaterno.ReadOnly = True
        Me.txtapaterno.Size = New System.Drawing.Size(223, 22)
        Me.txtapaterno.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido Paterno"
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(143, 37)
        Me.txtdni.MaxLength = 8
        Me.txtdni.Name = "txtdni"
        Me.txtdni.ReadOnly = True
        Me.txtdni.Size = New System.Drawing.Size(223, 22)
        Me.txtdni.TabIndex = 1
        Me.txtdni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(143, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Documento de Identidad"
        '
        'txtbuscardni
        '
        Me.txtbuscardni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscardni.Location = New System.Drawing.Point(229, 276)
        Me.txtbuscardni.MaxLength = 8
        Me.txtbuscardni.Name = "txtbuscardni"
        Me.txtbuscardni.Size = New System.Drawing.Size(274, 22)
        Me.txtbuscardni.TabIndex = 15
        Me.txtbuscardni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(38, 279)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(185, 16)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Buscar Cliente por N° DNI"
        '
        'DGClientes
        '
        Me.DGClientes.BackColor = System.Drawing.Color.Transparent
        Me.DGClientes.Controls.Add(Me.dgcliente)
        Me.DGClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGClientes.Location = New System.Drawing.Point(35, 316)
        Me.DGClientes.Name = "DGClientes"
        Me.DGClientes.Size = New System.Drawing.Size(676, 223)
        Me.DGClientes.TabIndex = 17
        Me.DGClientes.TabStop = False
        Me.DGClientes.Text = "Clientes"
        '
        'dgcliente
        '
        Me.dgcliente.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col1, Me.Col2, Me.Col3, Me.Col4, Me.Col5, Me.Col6, Me.Col7, Me.Col8, Me.Col9, Me.Col10})
        Me.dgcliente.Location = New System.Drawing.Point(8, 21)
        Me.dgcliente.Name = "dgcliente"
        Me.dgcliente.RowHeadersVisible = False
        Me.dgcliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgcliente.Size = New System.Drawing.Size(662, 196)
        Me.dgcliente.TabIndex = 0
        '
        'Col1
        '
        Me.Col1.HeaderText = "N°"
        Me.Col1.Name = "Col1"
        Me.Col1.ReadOnly = True
        '
        'Col2
        '
        Me.Col2.HeaderText = "Código"
        Me.Col2.Name = "Col2"
        Me.Col2.ReadOnly = True
        '
        'Col3
        '
        Me.Col3.HeaderText = "DNI N°"
        Me.Col3.Name = "Col3"
        Me.Col3.ReadOnly = True
        '
        'Col4
        '
        Me.Col4.HeaderText = "APE. PATERNO"
        Me.Col4.Name = "Col4"
        Me.Col4.ReadOnly = True
        Me.Col4.Width = 150
        '
        'Col5
        '
        Me.Col5.HeaderText = "APE. MATERNO"
        Me.Col5.Name = "Col5"
        Me.Col5.ReadOnly = True
        Me.Col5.Width = 150
        '
        'Col6
        '
        Me.Col6.HeaderText = "NOMBRES(S)"
        Me.Col6.Name = "Col6"
        Me.Col6.ReadOnly = True
        Me.Col6.Width = 150
        '
        'Col7
        '
        Me.Col7.HeaderText = "Edad"
        Me.Col7.Name = "Col7"
        Me.Col7.ReadOnly = True
        '
        'Col8
        '
        Me.Col8.HeaderText = "Sexo"
        Me.Col8.Name = "Col8"
        Me.Col8.ReadOnly = True
        '
        'Col9
        '
        Me.Col9.HeaderText = "E-mail"
        Me.Col9.Name = "Col9"
        Me.Col9.ReadOnly = True
        Me.Col9.Width = 150
        '
        'Col10
        '
        Me.Col10.HeaderText = "Telf. / Cel."
        Me.Col10.Name = "Col10"
        Me.Col10.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btneliminar)
        Me.GroupBox2.Controls.Add(Me.btnactualizar)
        Me.GroupBox2.Controls.Add(Me.btnsalir)
        Me.GroupBox2.Controls.Add(Me.btneditar)
        Me.GroupBox2.Controls.Add(Me.btnguardar)
        Me.GroupBox2.Controls.Add(Me.btnnuevo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(35, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(682, 75)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Botones de Acciones"
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(408, 21)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(112, 35)
        Me.btneliminar.TabIndex = 6
        Me.btneliminar.Text = "&ELIMINAR"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.Location = New System.Drawing.Point(276, 21)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(112, 35)
        Me.btnactualizar.TabIndex = 5
        Me.btnactualizar.Text = "&ACTUALIZAR"
        Me.btnactualizar.UseVisualStyleBackColor = True
        Me.btnactualizar.Visible = False
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(541, 21)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(112, 35)
        Me.btnsalir.TabIndex = 4
        Me.btnsalir.Text = "&SALIR"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Location = New System.Drawing.Point(276, 21)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(112, 35)
        Me.btneditar.TabIndex = 2
        Me.btneditar.Text = "&EDITAR"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(143, 21)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(112, 35)
        Me.btnguardar.TabIndex = 1
        Me.btnguardar.Text = "&GUARDAR"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(9, 21)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(112, 35)
        Me.btnnuevo.TabIndex = 0
        Me.btnnuevo.Text = "&NUEVO"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'frmmantenimientocliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(729, 547)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DGClientes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtbuscardni)
        Me.Controls.Add(Me.Label16)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmmantenimientocliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANTENIMIENTO DE CLIENTES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DGClientes.ResumeLayout(False)
        CType(Me.dgcliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbosexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtfono As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtamaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtapaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdni As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbuscardni As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DGClientes As System.Windows.Forms.GroupBox
    Friend WithEvents dgcliente As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btneditar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtedad As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Col1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnactualizar As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
End Class

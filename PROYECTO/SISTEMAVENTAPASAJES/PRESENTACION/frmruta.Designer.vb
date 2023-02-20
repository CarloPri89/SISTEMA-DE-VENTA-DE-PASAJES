<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmruta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmruta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnbus = New System.Windows.Forms.Button()
        Me.cbobus = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtduracion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNEDITAR = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnelimminar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.dgrutas = New System.Windows.Forms.DataGridView()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtdestino = New System.Windows.Forms.TextBox()
        Me.txtorigen = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Col1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgrutas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnbus)
        Me.GroupBox1.Controls.Add(Me.cbobus)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtduracion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.dgrutas)
        Me.GroupBox1.Controls.Add(Me.txtprecio)
        Me.GroupBox1.Controls.Add(Me.txtdestino)
        Me.GroupBox1.Controls.Add(Me.txtorigen)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(988, 286)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Rutas"
        '
        'btnbus
        '
        Me.btnbus.Location = New System.Drawing.Point(328, 232)
        Me.btnbus.Name = "btnbus"
        Me.btnbus.Size = New System.Drawing.Size(58, 24)
        Me.btnbus.TabIndex = 24
        Me.btnbus.Text = "☻☻☻"
        Me.btnbus.UseVisualStyleBackColor = True
        '
        'cbobus
        '
        Me.cbobus.FormattingEnabled = True
        Me.cbobus.Location = New System.Drawing.Point(128, 232)
        Me.cbobus.Name = "cbobus"
        Me.cbobus.Size = New System.Drawing.Size(194, 24)
        Me.cbobus.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Bus"
        '
        'txtduracion
        '
        Me.txtduracion.Location = New System.Drawing.Point(126, 192)
        Me.txtduracion.Name = "txtduracion"
        Me.txtduracion.ReadOnly = True
        Me.txtduracion.Size = New System.Drawing.Size(260, 22)
        Me.txtduracion.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Duración"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BTNEDITAR)
        Me.GroupBox2.Controls.Add(Me.btnsalir)
        Me.GroupBox2.Controls.Add(Me.btnelimminar)
        Me.GroupBox2.Controls.Add(Me.btnactualizar)
        Me.GroupBox2.Controls.Add(Me.btnguardar)
        Me.GroupBox2.Controls.Add(Me.btnnuevo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(407, 195)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(574, 75)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Botones de Acciones"
        '
        'BTNEDITAR
        '
        Me.BTNEDITAR.Location = New System.Drawing.Point(242, 21)
        Me.BTNEDITAR.Name = "BTNEDITAR"
        Me.BTNEDITAR.Size = New System.Drawing.Size(112, 35)
        Me.BTNEDITAR.TabIndex = 5
        Me.BTNEDITAR.Text = "&EDITAR"
        Me.BTNEDITAR.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(472, 21)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(96, 35)
        Me.btnsalir.TabIndex = 4
        Me.btnsalir.Text = "&SALIR"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnelimminar
        '
        Me.btnelimminar.Location = New System.Drawing.Point(360, 21)
        Me.btnelimminar.Name = "btnelimminar"
        Me.btnelimminar.Size = New System.Drawing.Size(96, 35)
        Me.btnelimminar.TabIndex = 3
        Me.btnelimminar.Text = "&ELIMINAR"
        Me.btnelimminar.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.Location = New System.Drawing.Point(242, 21)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(112, 35)
        Me.btnactualizar.TabIndex = 2
        Me.btnactualizar.Text = "&ACTUALIZAR"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Enabled = False
        Me.btnguardar.Location = New System.Drawing.Point(124, 21)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(96, 35)
        Me.btnguardar.TabIndex = 1
        Me.btnguardar.Text = "&GUARDAR"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(6, 21)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(96, 35)
        Me.btnnuevo.TabIndex = 0
        Me.btnnuevo.Text = "&NUEVO"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'dgrutas
        '
        Me.dgrutas.BackgroundColor = System.Drawing.SystemColors.HotTrack
        Me.dgrutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrutas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col1, Me.Col2, Me.Col3, Me.Col4, Me.Col5, Me.Col6, Me.Col7})
        Me.dgrutas.Location = New System.Drawing.Point(407, 33)
        Me.dgrutas.Name = "dgrutas"
        Me.dgrutas.RowHeadersVisible = False
        Me.dgrutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrutas.Size = New System.Drawing.Size(575, 144)
        Me.dgrutas.TabIndex = 8
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(128, 152)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.ReadOnly = True
        Me.txtprecio.Size = New System.Drawing.Size(260, 22)
        Me.txtprecio.TabIndex = 7
        '
        'txtdestino
        '
        Me.txtdestino.Location = New System.Drawing.Point(128, 116)
        Me.txtdestino.Name = "txtdestino"
        Me.txtdestino.ReadOnly = True
        Me.txtdestino.Size = New System.Drawing.Size(260, 22)
        Me.txtdestino.TabIndex = 6
        '
        'txtorigen
        '
        Me.txtorigen.Location = New System.Drawing.Point(128, 78)
        Me.txtorigen.Name = "txtorigen"
        Me.txtorigen.ReadOnly = True
        Me.txtorigen.Size = New System.Drawing.Size(260, 22)
        Me.txtorigen.TabIndex = 5
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(128, 30)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(260, 22)
        Me.txtcodigo.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio S/."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ciudad Destino"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ciudad Origen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'Col1
        '
        Me.Col1.HeaderText = "N°"
        Me.Col1.Name = "Col1"
        '
        'Col2
        '
        Me.Col2.HeaderText = "Código"
        Me.Col2.Name = "Col2"
        '
        'Col3
        '
        Me.Col3.HeaderText = "Ciudad Origen"
        Me.Col3.Name = "Col3"
        Me.Col3.Width = 200
        '
        'Col4
        '
        Me.Col4.HeaderText = "Ciudad Destino"
        Me.Col4.Name = "Col4"
        Me.Col4.Width = 200
        '
        'Col5
        '
        Me.Col5.HeaderText = "Precio"
        Me.Col5.Name = "Col5"
        '
        'Col6
        '
        Me.Col6.HeaderText = "Duración"
        Me.Col6.Name = "Col6"
        '
        'Col7
        '
        Me.Col7.HeaderText = "Bus"
        Me.Col7.Name = "Col7"
        Me.Col7.Width = 200
        '
        'frmruta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1012, 319)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmruta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANTENIMIENTO DE RUTAS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgrutas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbobus As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtduracion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnelimminar As System.Windows.Forms.Button
    Friend WithEvents btnactualizar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents dgrutas As System.Windows.Forms.DataGridView
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents txtdestino As System.Windows.Forms.TextBox
    Friend WithEvents txtorigen As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTNEDITAR As System.Windows.Forms.Button
    Friend WithEvents btnbus As System.Windows.Forms.Button
    Friend WithEvents Col1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

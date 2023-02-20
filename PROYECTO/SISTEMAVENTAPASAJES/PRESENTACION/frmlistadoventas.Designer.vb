<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlistadoventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlistadoventas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtclientes = New System.Windows.Forms.TextBox()
        Me.dtphasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpdesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Listar = New System.Windows.Forms.Button()
        Me.btnexcel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgventas = New System.Windows.Forms.DataGridView()
        Me.Nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Origen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Destino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Listar por Clientes"
        '
        'txtclientes
        '
        Me.txtclientes.Location = New System.Drawing.Point(158, 23)
        Me.txtclientes.Name = "txtclientes"
        Me.txtclientes.Size = New System.Drawing.Size(391, 22)
        Me.txtclientes.TabIndex = 1
        '
        'dtphasta
        '
        Me.dtphasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtphasta.Location = New System.Drawing.Point(820, 21)
        Me.dtphasta.Name = "dtphasta"
        Me.dtphasta.Size = New System.Drawing.Size(107, 22)
        Me.dtphasta.TabIndex = 2
        '
        'dtpdesde
        '
        Me.dtpdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdesde.Location = New System.Drawing.Point(632, 21)
        Me.dtpdesde.Name = "dtpdesde"
        Me.dtpdesde.Size = New System.Drawing.Size(107, 22)
        Me.dtpdesde.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(571, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Desde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(764, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hasta"
        '
        'Listar
        '
        Me.Listar.BackColor = System.Drawing.Color.Transparent
        Me.Listar.Location = New System.Drawing.Point(940, 6)
        Me.Listar.Name = "Listar"
        Me.Listar.Size = New System.Drawing.Size(78, 55)
        Me.Listar.TabIndex = 6
        Me.Listar.Text = "&Listar"
        Me.Listar.UseVisualStyleBackColor = False
        '
        'btnexcel
        '
        Me.btnexcel.BackColor = System.Drawing.Color.Transparent
        Me.btnexcel.Location = New System.Drawing.Point(1024, 7)
        Me.btnexcel.Name = "btnexcel"
        Me.btnexcel.Size = New System.Drawing.Size(130, 55)
        Me.btnexcel.TabIndex = 8
        Me.btnexcel.Text = "&Importar a Excel"
        Me.btnexcel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgventas)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1272, 479)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Ventas"
        '
        'dgventas
        '
        Me.dgventas.AllowUserToAddRows = False
        Me.dgventas.BackgroundColor = System.Drawing.SystemColors.Highlight
        Me.dgventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nro, Me.Codigo, Me.Nombre, Me.Origen, Me.Destino, Me.Importe, Me.Asiento, Me.Fecha})
        Me.dgventas.Location = New System.Drawing.Point(6, 21)
        Me.dgventas.Name = "dgventas"
        Me.dgventas.RowHeadersVisible = False
        Me.dgventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgventas.Size = New System.Drawing.Size(1253, 434)
        Me.dgventas.TabIndex = 0
        '
        'Nro
        '
        Me.Nro.HeaderText = "N°"
        Me.Nro.Name = "Nro"
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Width = 150
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre Cliente"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 250
        '
        'Origen
        '
        Me.Origen.HeaderText = "Ciudad Origen"
        Me.Origen.Name = "Origen"
        Me.Origen.Width = 200
        '
        'Destino
        '
        Me.Destino.HeaderText = "Ciudad Destino"
        Me.Destino.Name = "Destino"
        Me.Destino.Width = 200
        '
        'Importe
        '
        Me.Importe.HeaderText = "Precio"
        Me.Importe.Name = "Importe"
        '
        'Asiento
        '
        Me.Asiento.HeaderText = "N° Asiento"
        Me.Asiento.Name = "Asiento"
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha Venta"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 150
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.Location = New System.Drawing.Point(1203, 6)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(56, 55)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmlistadoventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1276, 543)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnexcel)
        Me.Controls.Add(Me.Listar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpdesde)
        Me.Controls.Add(Me.dtphasta)
        Me.Controls.Add(Me.txtclientes)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmlistadoventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENTAS"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtclientes As System.Windows.Forms.TextBox
    Friend WithEvents dtphasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Listar As System.Windows.Forms.Button
    Friend WithEvents btnexcel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgventas As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Nro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Origen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Destino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Asiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

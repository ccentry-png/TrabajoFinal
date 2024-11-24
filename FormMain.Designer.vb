<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ButtonVolverALogin = New System.Windows.Forms.Button()
        Me.ButtonVerClientes = New System.Windows.Forms.Button()
        Me.ButtonVerProductos = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NombreProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetVentas = New TrabajoFinal.DataSetVentas()
        Me.DataTable1TableAdapter = New TrabajoFinal.DataSetVentasTableAdapters.DataTable1TableAdapter()
        Me.ButtonBorrarVenta = New System.Windows.Forms.Button()
        Me.ButtonModificarVEnta = New System.Windows.Forms.Button()
        Me.LabelProductoSelecionado = New System.Windows.Forms.Label()
        Me.ButtonCrearVenta = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonVolverALogin
        '
        Me.ButtonVolverALogin.Location = New System.Drawing.Point(12, 12)
        Me.ButtonVolverALogin.Name = "ButtonVolverALogin"
        Me.ButtonVolverALogin.Size = New System.Drawing.Size(92, 42)
        Me.ButtonVolverALogin.TabIndex = 1
        Me.ButtonVolverALogin.Text = "Salir"
        Me.ButtonVolverALogin.UseVisualStyleBackColor = True
        '
        'ButtonVerClientes
        '
        Me.ButtonVerClientes.Location = New System.Drawing.Point(732, 551)
        Me.ButtonVerClientes.Name = "ButtonVerClientes"
        Me.ButtonVerClientes.Size = New System.Drawing.Size(118, 83)
        Me.ButtonVerClientes.TabIndex = 2
        Me.ButtonVerClientes.Text = "Ver todos los Clientes"
        Me.ButtonVerClientes.UseVisualStyleBackColor = True
        '
        'ButtonVerProductos
        '
        Me.ButtonVerProductos.Location = New System.Drawing.Point(856, 551)
        Me.ButtonVerProductos.Name = "ButtonVerProductos"
        Me.ButtonVerProductos.Size = New System.Drawing.Size(112, 83)
        Me.ButtonVerProductos.TabIndex = 3
        Me.ButtonVerProductos.Text = "Ver todos los Productos"
        Me.ButtonVerProductos.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreProductoDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioUnitarioDataGridViewTextBoxColumn, Me.SubtotalDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.FechaVentaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DataTable1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 62)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(1173, 475)
        Me.DataGridView1.TabIndex = 4
        '
        'NombreProductoDataGridViewTextBoxColumn
        '
        Me.NombreProductoDataGridViewTextBoxColumn.DataPropertyName = "NombreProducto"
        Me.NombreProductoDataGridViewTextBoxColumn.HeaderText = "NombreProducto"
        Me.NombreProductoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NombreProductoDataGridViewTextBoxColumn.Name = "NombreProductoDataGridViewTextBoxColumn"
        Me.NombreProductoDataGridViewTextBoxColumn.Width = 150
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.Width = 150
        '
        'PrecioUnitarioDataGridViewTextBoxColumn
        '
        Me.PrecioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.HeaderText = "PrecioUnitario"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PrecioUnitarioDataGridViewTextBoxColumn.Name = "PrecioUnitarioDataGridViewTextBoxColumn"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.Width = 150
        '
        'SubtotalDataGridViewTextBoxColumn
        '
        Me.SubtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SubtotalDataGridViewTextBoxColumn.Name = "SubtotalDataGridViewTextBoxColumn"
        Me.SubtotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubtotalDataGridViewTextBoxColumn.Width = 150
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.Width = 150
        '
        'FechaVentaDataGridViewTextBoxColumn
        '
        Me.FechaVentaDataGridViewTextBoxColumn.DataPropertyName = "FechaVenta"
        Me.FechaVentaDataGridViewTextBoxColumn.HeaderText = "FechaVenta"
        Me.FechaVentaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FechaVentaDataGridViewTextBoxColumn.Name = "FechaVentaDataGridViewTextBoxColumn"
        Me.FechaVentaDataGridViewTextBoxColumn.Width = 150
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre Cliente"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 150
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DataSetVentasBindingSource
        '
        'DataSetVentasBindingSource
        '
        Me.DataSetVentasBindingSource.DataSource = Me.DataSetVentas
        Me.DataSetVentasBindingSource.Position = 0
        '
        'DataSetVentas
        '
        Me.DataSetVentas.DataSetName = "DataSetVentas"
        Me.DataSetVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'ButtonBorrarVenta
        '
        Me.ButtonBorrarVenta.Location = New System.Drawing.Point(250, 583)
        Me.ButtonBorrarVenta.Name = "ButtonBorrarVenta"
        Me.ButtonBorrarVenta.Size = New System.Drawing.Size(88, 62)
        Me.ButtonBorrarVenta.TabIndex = 9
        Me.ButtonBorrarVenta.Text = "Borrar Venta"
        Me.ButtonBorrarVenta.UseVisualStyleBackColor = True
        '
        'ButtonModificarVEnta
        '
        Me.ButtonModificarVEnta.Location = New System.Drawing.Point(154, 583)
        Me.ButtonModificarVEnta.Name = "ButtonModificarVEnta"
        Me.ButtonModificarVEnta.Size = New System.Drawing.Size(92, 62)
        Me.ButtonModificarVEnta.TabIndex = 8
        Me.ButtonModificarVEnta.Text = "Modificar Venta"
        Me.ButtonModificarVEnta.UseVisualStyleBackColor = True
        '
        'LabelProductoSelecionado
        '
        Me.LabelProductoSelecionado.AutoSize = True
        Me.LabelProductoSelecionado.Location = New System.Drawing.Point(18, 551)
        Me.LabelProductoSelecionado.Name = "LabelProductoSelecionado"
        Me.LabelProductoSelecionado.Size = New System.Drawing.Size(144, 20)
        Me.LabelProductoSelecionado.TabIndex = 7
        Me.LabelProductoSelecionado.Text = "Venta Selecionada"
        '
        'ButtonCrearVenta
        '
        Me.ButtonCrearVenta.Location = New System.Drawing.Point(14, 583)
        Me.ButtonCrearVenta.Name = "ButtonCrearVenta"
        Me.ButtonCrearVenta.Size = New System.Drawing.Size(134, 62)
        Me.ButtonCrearVenta.TabIndex = 6
        Me.ButtonCrearVenta.Text = "Nueva Venta"
        Me.ButtonCrearVenta.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer"
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 660)
        Me.Controls.Add(Me.ButtonBorrarVenta)
        Me.Controls.Add(Me.ButtonModificarVEnta)
        Me.Controls.Add(Me.LabelProductoSelecionado)
        Me.Controls.Add(Me.ButtonCrearVenta)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonVerProductos)
        Me.Controls.Add(Me.ButtonVerClientes)
        Me.Controls.Add(Me.ButtonVolverALogin)
        Me.Name = "FormMain"
        Me.Text = "FormMain"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetVentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonVolverALogin As Button
    Friend WithEvents ButtonVerClientes As Button
    Friend WithEvents ButtonVerProductos As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSetVentasBindingSource As BindingSource
    Friend WithEvents DataSetVentas As DataSetVentas
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataTable1TableAdapter As DataSetVentasTableAdapters.DataTable1TableAdapter
    Friend WithEvents NombreProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ButtonBorrarVenta As Button
    Friend WithEvents ButtonModificarVEnta As Button
    Friend WithEvents LabelProductoSelecionado As Label
    Friend WithEvents ButtonCrearVenta As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class

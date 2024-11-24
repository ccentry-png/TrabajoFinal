<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelectProducto
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductoIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoBarraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetProductos = New TrabajoFinal.DataSetProductos()
        Me.ProductosTableAdapter = New TrabajoFinal.DataSetProductosTableAdapters.ProductosTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductoIDDataGridViewTextBoxColumn, Me.NombreProductoDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.CodigoBarraDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(763, 426)
        Me.DataGridView1.TabIndex = 0
        '
        'ProductoIDDataGridViewTextBoxColumn
        '
        Me.ProductoIDDataGridViewTextBoxColumn.DataPropertyName = "ProductoID"
        Me.ProductoIDDataGridViewTextBoxColumn.HeaderText = "ProductoID"
        Me.ProductoIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ProductoIDDataGridViewTextBoxColumn.Name = "ProductoIDDataGridViewTextBoxColumn"
        Me.ProductoIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductoIDDataGridViewTextBoxColumn.Width = 150
        '
        'NombreProductoDataGridViewTextBoxColumn
        '
        Me.NombreProductoDataGridViewTextBoxColumn.DataPropertyName = "NombreProducto"
        Me.NombreProductoDataGridViewTextBoxColumn.HeaderText = "NombreProducto"
        Me.NombreProductoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NombreProductoDataGridViewTextBoxColumn.Name = "NombreProductoDataGridViewTextBoxColumn"
        Me.NombreProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreProductoDataGridViewTextBoxColumn.Width = 150
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioDataGridViewTextBoxColumn.Width = 150
        '
        'CodigoBarraDataGridViewTextBoxColumn
        '
        Me.CodigoBarraDataGridViewTextBoxColumn.DataPropertyName = "CodigoBarra"
        Me.CodigoBarraDataGridViewTextBoxColumn.HeaderText = "CodigoBarra"
        Me.CodigoBarraDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CodigoBarraDataGridViewTextBoxColumn.Name = "CodigoBarraDataGridViewTextBoxColumn"
        Me.CodigoBarraDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoBarraDataGridViewTextBoxColumn.Width = 150
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.DataSetProductos
        '
        'DataSetProductos
        '
        Me.DataSetProductos.DataSetName = "DataSetProductos"
        Me.DataSetProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'FormSelectProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormSelectProducto"
        Me.Text = "FormSelectProducto"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSetProductos As DataSetProductos
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As DataSetProductosTableAdapters.ProductosTableAdapter
    Friend WithEvents ProductoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoBarraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

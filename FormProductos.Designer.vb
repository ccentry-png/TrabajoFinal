<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProductos
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NombreProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoBarraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetProductos = New TrabajoFinal.DataSetProductos()
        Me.ButtonCrearProducto = New System.Windows.Forms.Button()
        Me.LabelProductoSelecionado = New System.Windows.Forms.Label()
        Me.ButtonModificarProducto = New System.Windows.Forms.Button()
        Me.ButtonBorrarProducto = New System.Windows.Forms.Button()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New TrabajoFinal.DataSetProductosTableAdapters.ProductosTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonVolverALogin
        '
        Me.ButtonVolverALogin.Location = New System.Drawing.Point(12, 12)
        Me.ButtonVolverALogin.Name = "ButtonVolverALogin"
        Me.ButtonVolverALogin.Size = New System.Drawing.Size(92, 42)
        Me.ButtonVolverALogin.TabIndex = 0
        Me.ButtonVolverALogin.Text = "Salir"
        Me.ButtonVolverALogin.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreProductoDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.CodigoBarraDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductosBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 60)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(514, 425)
        Me.DataGridView1.TabIndex = 1
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
        'ProductosBindingSource1
        '
        Me.ProductosBindingSource1.DataMember = "Productos"
        Me.ProductosBindingSource1.DataSource = Me.DataSetProductos
        '
        'DataSetProductos
        '
        Me.DataSetProductos.DataSetName = "DataSetProductos"
        Me.DataSetProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonCrearProducto
        '
        Me.ButtonCrearProducto.Location = New System.Drawing.Point(12, 532)
        Me.ButtonCrearProducto.Name = "ButtonCrearProducto"
        Me.ButtonCrearProducto.Size = New System.Drawing.Size(133, 62)
        Me.ButtonCrearProducto.TabIndex = 2
        Me.ButtonCrearProducto.Text = "Crear Producto Nuevo"
        Me.ButtonCrearProducto.UseVisualStyleBackColor = True
        '
        'LabelProductoSelecionado
        '
        Me.LabelProductoSelecionado.AutoSize = True
        Me.LabelProductoSelecionado.Location = New System.Drawing.Point(17, 500)
        Me.LabelProductoSelecionado.Name = "LabelProductoSelecionado"
        Me.LabelProductoSelecionado.Size = New System.Drawing.Size(169, 20)
        Me.LabelProductoSelecionado.TabIndex = 3
        Me.LabelProductoSelecionado.Text = "Producto Selecionado:"
        '
        'ButtonModificarProducto
        '
        Me.ButtonModificarProducto.Location = New System.Drawing.Point(151, 532)
        Me.ButtonModificarProducto.Name = "ButtonModificarProducto"
        Me.ButtonModificarProducto.Size = New System.Drawing.Size(91, 62)
        Me.ButtonModificarProducto.TabIndex = 4
        Me.ButtonModificarProducto.Text = "Modificar Producto"
        Me.ButtonModificarProducto.UseVisualStyleBackColor = True
        '
        'ButtonBorrarProducto
        '
        Me.ButtonBorrarProducto.Location = New System.Drawing.Point(248, 532)
        Me.ButtonBorrarProducto.Name = "ButtonBorrarProducto"
        Me.ButtonBorrarProducto.Size = New System.Drawing.Size(88, 62)
        Me.ButtonBorrarProducto.TabIndex = 5
        Me.ButtonBorrarProducto.Text = "Borrar Producto"
        Me.ButtonBorrarProducto.UseVisualStyleBackColor = True
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.DataSetProductos
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 612)
        Me.Controls.Add(Me.ButtonBorrarProducto)
        Me.Controls.Add(Me.ButtonModificarProducto)
        Me.Controls.Add(Me.LabelProductoSelecionado)
        Me.Controls.Add(Me.ButtonCrearProducto)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonVolverALogin)
        Me.Name = "FormClientes"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonVolverALogin As Button
    Friend WithEvents DataSetProductos As DataSetProductos
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As DataSetProductosTableAdapters.ProductosTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NombreProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoBarraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductosBindingSource1 As BindingSource
    Friend WithEvents ButtonCrearProducto As Button
    Friend WithEvents LabelProductoSelecionado As Label
    Friend WithEvents ButtonModificarProducto As Button
    Friend WithEvents ButtonBorrarProducto As Button
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormClientes
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
        Me.DataSetProductos = New TrabajoFinal.DataSetProductos()
        Me.ButtonCrearProducto = New System.Windows.Forms.Button()
        Me.LabelProductoSelecionado = New System.Windows.Forms.Label()
        Me.ButtonModificarProducto = New System.Windows.Forms.Button()
        Me.ButtonBorrarProducto = New System.Windows.Forms.Button()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New TrabajoFinal.DataSetProductosTableAdapters.ClienteTableAdapter()
        Me.ClienteIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClienteIDDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClienteBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 60)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(514, 425)
        Me.DataGridView1.TabIndex = 1
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
        Me.ButtonCrearProducto.Text = "Añadir Cliente"
        Me.ButtonCrearProducto.UseVisualStyleBackColor = True
        '
        'LabelProductoSelecionado
        '
        Me.LabelProductoSelecionado.AutoSize = True
        Me.LabelProductoSelecionado.Location = New System.Drawing.Point(17, 500)
        Me.LabelProductoSelecionado.Name = "LabelProductoSelecionado"
        Me.LabelProductoSelecionado.Size = New System.Drawing.Size(154, 20)
        Me.LabelProductoSelecionado.TabIndex = 3
        Me.LabelProductoSelecionado.Text = "Cliente Selecionado:"
        '
        'ButtonModificarProducto
        '
        Me.ButtonModificarProducto.Location = New System.Drawing.Point(151, 532)
        Me.ButtonModificarProducto.Name = "ButtonModificarProducto"
        Me.ButtonModificarProducto.Size = New System.Drawing.Size(91, 62)
        Me.ButtonModificarProducto.TabIndex = 4
        Me.ButtonModificarProducto.Text = "Modificar Cliente"
        Me.ButtonModificarProducto.UseVisualStyleBackColor = True
        '
        'ButtonBorrarProducto
        '
        Me.ButtonBorrarProducto.Location = New System.Drawing.Point(248, 532)
        Me.ButtonBorrarProducto.Name = "ButtonBorrarProducto"
        Me.ButtonBorrarProducto.Size = New System.Drawing.Size(88, 62)
        Me.ButtonBorrarProducto.TabIndex = 5
        Me.ButtonBorrarProducto.Text = "Borrar Cliente"
        Me.ButtonBorrarProducto.UseVisualStyleBackColor = True
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.DataSetProductos
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'ClienteIDDataGridViewTextBoxColumn
        '
        Me.ClienteIDDataGridViewTextBoxColumn.DataPropertyName = "ClienteID"
        Me.ClienteIDDataGridViewTextBoxColumn.HeaderText = "ClienteID"
        Me.ClienteIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ClienteIDDataGridViewTextBoxColumn.Name = "ClienteIDDataGridViewTextBoxColumn"
        Me.ClienteIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteIDDataGridViewTextBoxColumn.Width = 150
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 150
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailDataGridViewTextBoxColumn.Width = 150
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoDataGridViewTextBoxColumn.Width = 150
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
        CType(Me.DataSetProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonVolverALogin As Button
    Friend WithEvents DataSetProductos As DataSetProductos
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonCrearProducto As Button
    Friend WithEvents LabelProductoSelecionado As Label
    Friend WithEvents ButtonModificarProducto As Button
    Friend WithEvents ButtonBorrarProducto As Button
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As DataSetProductosTableAdapters.ClienteTableAdapter
    Friend WithEvents ClienteIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

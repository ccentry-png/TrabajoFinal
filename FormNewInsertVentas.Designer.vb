<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewInsertVentas
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataSetProductos1 = New TrabajoFinal.DataSetProductos()
        Me.ProductosTableAdapter1 = New TrabajoFinal.DataSetProductosTableAdapters.ProductosTableAdapter()
        Me.DetalleVentaTableAdapter1 = New TrabajoFinal.DataSetProductosTableAdapters.DetalleVentaTableAdapter()
        Me.VentaTableAdapter1 = New TrabajoFinal.DataSetProductosTableAdapters.VentaTableAdapter()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetProductos1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.Location = New System.Drawing.Point(625, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 60)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Agregar Venta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(162, 65)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 26)
        Me.NumericUpDown1.TabIndex = 6
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(429, 6)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(23, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(170, 33)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Selecciona Producto"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(199, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(199, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 13
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 191)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(170, 33)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Selecciona Cliente"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataSetProductos1
        '
        Me.DataSetProductos1.DataSetName = "DataSetProductos"
        Me.DataSetProductos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosTableAdapter1
        '
        Me.ProductosTableAdapter1.ClearBeforeFill = True
        '
        'DetalleVentaTableAdapter1
        '
        Me.DetalleVentaTableAdapter1.ClearBeforeFill = True
        '
        'VentaTableAdapter1
        '
        Me.VentaTableAdapter1.ClearBeforeFill = True
        '
        'FormNewInsertVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 368)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormNewInsertVentas"
        Me.Text = "FormNewInsertVentas"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetProductos1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DataSetProductos1 As DataSetProductos
    Friend WithEvents ProductosTableAdapter1 As DataSetProductosTableAdapters.ProductosTableAdapter
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents DetalleVentaTableAdapter1 As DataSetProductosTableAdapters.DetalleVentaTableAdapter
    Friend WithEvents VentaTableAdapter1 As DataSetProductosTableAdapters.VentaTableAdapter
End Class

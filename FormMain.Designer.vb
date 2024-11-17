<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.ButtonVolverALogin = New System.Windows.Forms.Button()
        Me.ButtonVerClientes = New System.Windows.Forms.Button()
        Me.ButtonVerProductos = New System.Windows.Forms.Button()
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
        Me.ButtonVerClientes.Location = New System.Drawing.Point(542, 346)
        Me.ButtonVerClientes.Name = "ButtonVerClientes"
        Me.ButtonVerClientes.Size = New System.Drawing.Size(118, 58)
        Me.ButtonVerClientes.TabIndex = 2
        Me.ButtonVerClientes.Text = "Ver todos los Clientes"
        Me.ButtonVerClientes.UseVisualStyleBackColor = True
        '
        'ButtonVerProductos
        '
        Me.ButtonVerProductos.Location = New System.Drawing.Point(666, 346)
        Me.ButtonVerProductos.Name = "ButtonVerProductos"
        Me.ButtonVerProductos.Size = New System.Drawing.Size(113, 58)
        Me.ButtonVerProductos.TabIndex = 3
        Me.ButtonVerProductos.Text = "Ver todos los Productos"
        Me.ButtonVerProductos.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonVerProductos)
        Me.Controls.Add(Me.ButtonVerClientes)
        Me.Controls.Add(Me.ButtonVolverALogin)
        Me.Name = "FormMain"
        Me.Text = "FormMain"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonVolverALogin As Button
    Friend WithEvents ButtonVerClientes As Button
    Friend WithEvents ButtonVerProductos As Button
End Class

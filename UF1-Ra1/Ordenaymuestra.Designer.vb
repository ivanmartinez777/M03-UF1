<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ordenaymuestra
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
        Me.textbox1 = New System.Windows.Forms.TextBox()
        Me.textbox2 = New System.Windows.Forms.TextBox()
        Me.textbox3 = New System.Windows.Forms.TextBox()
        Me.ordenador = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textbox1
        '
        Me.textbox1.Location = New System.Drawing.Point(393, 96)
        Me.textbox1.Name = "textbox1"
        Me.textbox1.Size = New System.Drawing.Size(100, 20)
        Me.textbox1.TabIndex = 0
        '
        'textbox2
        '
        Me.textbox2.Location = New System.Drawing.Point(393, 145)
        Me.textbox2.Name = "textbox2"
        Me.textbox2.Size = New System.Drawing.Size(100, 20)
        Me.textbox2.TabIndex = 1
        '
        'textbox3
        '
        Me.textbox3.Location = New System.Drawing.Point(393, 191)
        Me.textbox3.Name = "textbox3"
        Me.textbox3.Size = New System.Drawing.Size(100, 20)
        Me.textbox3.TabIndex = 2
        '
        'ordenador
        '
        Me.ordenador.Location = New System.Drawing.Point(241, 145)
        Me.ordenador.Name = "ordenador"
        Me.ordenador.Size = New System.Drawing.Size(75, 23)
        Me.ordenador.TabIndex = 3
        Me.ordenador.Text = "ordena"
        Me.ordenador.UseVisualStyleBackColor = True
        '
        'Ordenaymuestra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 327)
        Me.Controls.Add(Me.ordenador)
        Me.Controls.Add(Me.textbox3)
        Me.Controls.Add(Me.textbox2)
        Me.Controls.Add(Me.textbox1)
        Me.Name = "Ordenaymuestra"
        Me.Text = "Ordenaymuestra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textbox1 As TextBox
    Friend WithEvents textbox2 As TextBox
    Friend WithEvents textbox3 As TextBox
    Friend WithEvents ordenador As Button
End Class

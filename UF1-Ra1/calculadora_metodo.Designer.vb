<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calculadora_metodo
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textbox1
        '
        Me.textbox1.Location = New System.Drawing.Point(54, 45)
        Me.textbox1.Name = "textbox1"
        Me.textbox1.Size = New System.Drawing.Size(23, 20)
        Me.textbox1.TabIndex = 0
        '
        'textbox2
        '
        Me.textbox2.Location = New System.Drawing.Point(124, 45)
        Me.textbox2.Name = "textbox2"
        Me.textbox2.Size = New System.Drawing.Size(21, 20)
        Me.textbox2.TabIndex = 1
        '
        'textbox3
        '
        Me.textbox3.Location = New System.Drawing.Point(197, 44)
        Me.textbox3.Name = "textbox3"
        Me.textbox3.Size = New System.Drawing.Size(60, 20)
        Me.textbox3.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(43, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(124, 97)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(43, 127)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(51, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "*"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(124, 126)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "/"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'calculadora_metodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.textbox3)
        Me.Controls.Add(Me.textbox2)
        Me.Controls.Add(Me.textbox1)
        Me.Name = "calculadora_metodo"
        Me.Text = "calculadora_metodo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textbox1 As TextBox
    Friend WithEvents textbox2 As TextBox
    Friend WithEvents textbox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.sumaBtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RestarBtn = New System.Windows.Forms.Button()
        Me.MultiplicarBtn = New System.Windows.Forms.Button()
        Me.DividirBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'sumaBtn
        '
        Me.sumaBtn.Location = New System.Drawing.Point(158, 142)
        Me.sumaBtn.Name = "sumaBtn"
        Me.sumaBtn.Size = New System.Drawing.Size(75, 23)
        Me.sumaBtn.TabIndex = 0
        Me.sumaBtn.Text = "sumar"
        Me.sumaBtn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(45, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(232, 56)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(413, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'RestarBtn
        '
        Me.RestarBtn.Location = New System.Drawing.Point(158, 191)
        Me.RestarBtn.Name = "RestarBtn"
        Me.RestarBtn.Size = New System.Drawing.Size(75, 23)
        Me.RestarBtn.TabIndex = 4
        Me.RestarBtn.Text = "Restar"
        Me.RestarBtn.UseVisualStyleBackColor = True
        '
        'MultiplicarBtn
        '
        Me.MultiplicarBtn.Location = New System.Drawing.Point(158, 236)
        Me.MultiplicarBtn.Name = "MultiplicarBtn"
        Me.MultiplicarBtn.Size = New System.Drawing.Size(75, 23)
        Me.MultiplicarBtn.TabIndex = 5
        Me.MultiplicarBtn.Text = "Multiplicar"
        Me.MultiplicarBtn.UseVisualStyleBackColor = True
        '
        'DividirBtn
        '
        Me.DividirBtn.Location = New System.Drawing.Point(158, 277)
        Me.DividirBtn.Name = "DividirBtn"
        Me.DividirBtn.Size = New System.Drawing.Size(75, 23)
        Me.DividirBtn.TabIndex = 6
        Me.DividirBtn.Text = "Dividir"
        Me.DividirBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 442)
        Me.Controls.Add(Me.DividirBtn)
        Me.Controls.Add(Me.MultiplicarBtn)
        Me.Controls.Add(Me.RestarBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.sumaBtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sumaBtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RestarBtn As Button
    Friend WithEvents MultiplicarBtn As Button
    Friend WithEvents DividirBtn As Button
End Class

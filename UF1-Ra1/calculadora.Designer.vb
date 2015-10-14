<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculadora
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
        Me.DividirBtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MultiplicarBtn = New System.Windows.Forms.Button()
        Me.RestarBtn = New System.Windows.Forms.Button()
        Me.sumaBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DividirBtn
        '
        Me.DividirBtn.Location = New System.Drawing.Point(451, 198)
        Me.DividirBtn.Name = "DividirBtn"
        Me.DividirBtn.Size = New System.Drawing.Size(75, 23)
        Me.DividirBtn.TabIndex = 0
        Me.DividirBtn.Text = "dividir"
        Me.DividirBtn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(354, 324)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(539, 323)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(718, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(677, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "="
        '
        'MultiplicarBtn
        '
        Me.MultiplicarBtn.Location = New System.Drawing.Point(451, 228)
        Me.MultiplicarBtn.Name = "MultiplicarBtn"
        Me.MultiplicarBtn.Size = New System.Drawing.Size(75, 23)
        Me.MultiplicarBtn.TabIndex = 6
        Me.MultiplicarBtn.Text = "multiplicar"
        Me.MultiplicarBtn.UseVisualStyleBackColor = True
        '
        'RestarBtn
        '
        Me.RestarBtn.Location = New System.Drawing.Point(451, 257)
        Me.RestarBtn.Name = "RestarBtn"
        Me.RestarBtn.Size = New System.Drawing.Size(75, 23)
        Me.RestarBtn.TabIndex = 7
        Me.RestarBtn.Text = "restar"
        Me.RestarBtn.UseVisualStyleBackColor = True
        '
        'sumaBtn
        '
        Me.sumaBtn.Location = New System.Drawing.Point(451, 287)
        Me.sumaBtn.Name = "sumaBtn"
        Me.sumaBtn.Size = New System.Drawing.Size(75, 23)
        Me.sumaBtn.TabIndex = 8
        Me.sumaBtn.Text = "sumar"
        Me.sumaBtn.UseVisualStyleBackColor = True
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 507)
        Me.Controls.Add(Me.sumaBtn)
        Me.Controls.Add(Me.RestarBtn)
        Me.Controls.Add(Me.MultiplicarBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DividirBtn)
        Me.Name = "Calculadora"
        Me.Text = "calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DividirBtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MultiplicarBtn As Button
    Friend WithEvents RestarBtn As Button
    Friend WithEvents sumaBtn As Button
End Class

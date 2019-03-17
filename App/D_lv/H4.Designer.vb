<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class H4
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.num1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(659, 56)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Сторона треугольника равна 21, а две другие стороны образуют угол в 60°" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "и относя" &
    "тся как 3:8. Найдите сумму всех сторон."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(140, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 24)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Проверить"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'num1
        '
        Me.num1.Location = New System.Drawing.Point(17, 86)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(100, 20)
        Me.num1.TabIndex = 24
        Me.num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'H4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 142)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "H4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "H4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents num1 As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Easy
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.num1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Save = New System.Windows.Forms.Button()
        Me.Load = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Down = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Задачи легкого уровня" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "С ними должен справиться каждый!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(88, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'num1
        '
        Me.num1.Cursor = System.Windows.Forms.Cursors.Help
        Me.num1.Location = New System.Drawing.Point(578, 6)
        Me.num1.Name = "num1"
        Me.num1.ReadOnly = True
        Me.num1.Size = New System.Drawing.Size(21, 20)
        Me.num1.TabIndex = 2
        Me.num1.Text = "0"
        Me.num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(521, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Решено:"
        '
        'Save
        '
        Me.Save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Save.Location = New System.Drawing.Point(524, 32)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 23)
        Me.Save.TabIndex = 4
        Me.Save.Text = "Сохранить"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Load
        '
        Me.Load.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Load.Location = New System.Drawing.Point(524, 61)
        Me.Load.Name = "Load"
        Me.Load.Size = New System.Drawing.Size(75, 23)
        Me.Load.TabIndex = 5
        Me.Load.Text = "Загрузить"
        Me.Load.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(132, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 35)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Down
        '
        Me.Down.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Down.Location = New System.Drawing.Point(524, 216)
        Me.Down.Name = "Down"
        Me.Down.Size = New System.Drawing.Size(75, 23)
        Me.Down.TabIndex = 7
        Me.Down.Text = "Назад"
        Me.Down.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(176, 112)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(38, 35)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button4.Location = New System.Drawing.Point(220, 112)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(38, 35)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button5.Location = New System.Drawing.Point(264, 112)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(38, 35)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button6.Location = New System.Drawing.Point(308, 112)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(38, 35)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button7.Location = New System.Drawing.Point(352, 112)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(38, 35)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button8.Location = New System.Drawing.Point(396, 112)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(38, 35)
        Me.Button8.TabIndex = 13
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Easy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(613, 251)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Down)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Load)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Easy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Легкий"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents num1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Save As Button
    Friend WithEvents Load As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Down As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class

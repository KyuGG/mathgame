﻿Public Class M5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        a = num1.Text
        If (Med.Button5.BackColor <> Color.Lime And a = 45) Then
            Med.num1.Text = Med.num1.Text + 1
            Med.Button5.BackColor = Color.Lime
        End If
        If (a = 45) Then
            Me.Close()
            MsgBox("Задание 5 выполнено!")
        End If
    End Sub
End Class
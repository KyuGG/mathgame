﻿Public Class H4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        a = num1.Text
        If (DIFFLVL.Button4.BackColor <> Color.Lime And a = 36) Then
            DIFFLVL.num1.Text = DIFFLVL.num1.Text + 1
            DIFFLVL.Button4.BackColor = Color.Lime
        End If
        If (a = 36) Then
            Me.Close()
            MsgBox("Задание 4 выполнено!")
        End If
    End Sub
End Class
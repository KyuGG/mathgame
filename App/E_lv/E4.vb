Public Class E4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As String
        a = num1.Text
        b = num2.Text
        If (Easy.Button4.BackColor <> Color.Lime And a = 1 And b = "ws") Then
            Easy.num1.Text = Easy.num1.Text + 1
            Easy.Button4.BackColor = Color.Lime
        End If
        If (a = 1 And b = "ws") Then
            Me.Close()
            MsgBox("Задание 4 выполнено!")
        End If
    End Sub
End Class
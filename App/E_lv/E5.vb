Public Class E5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        a = num1.Text
        If (Easy.Button5.BackColor <> Color.Lime And a = 30) Then
            Easy.num1.Text = Easy.num1.Text + 1
            Easy.Button5.BackColor = Color.Lime
        End If
        If (a = 30) Then
            Me.Close()
            MsgBox("Задание 5 выполнено!")
        End If
    End Sub
End Class
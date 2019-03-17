Public Class E6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        a = num1.Text
        If (Easy.Button6.BackColor <> Color.Lime And a = 2) Then
            Easy.num1.Text = Easy.num1.Text + 1
            Easy.Button6.BackColor = Color.Lime
        End If
        If (a = 2) Then
            Me.Close()
            MsgBox("Задание 6 выполнено!")
        End If
    End Sub
End Class
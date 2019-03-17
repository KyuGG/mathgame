Public Class E1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        a = num1.Text
        If (Easy.Button1.BackColor <> Color.Lime And a = 100) Then
            Easy.num1.Text = Easy.num1.Text + 1
            Easy.Button1.BackColor = Color.Lime
        End If
        If a = 100 Then
            Me.Close()
            MsgBox("Задание 1 выполнено!")
        End If
    End Sub
End Class






Public Class M8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        a = num1.Text
        If (Med.Button8.BackColor <> Color.Lime And a = 24) Then
            Med.num1.Text = Med.num1.Text + 1
            Med.Button8.BackColor = Color.Lime
        End If
        If (a = 24) Then
            Me.Close()
            MsgBox("Задание 8 выполнено!")
        End If
    End Sub
End Class
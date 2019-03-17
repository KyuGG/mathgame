Public Class M4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        a = num1.Text
        If (Med.Button4.BackColor <> Color.Lime And a = 4) Then
            Med.num1.Text = Med.num1.Text + 1
            Med.Button4.BackColor = Color.Lime
        End If
        If (a = 4) Then
            Me.Close()
            MsgBox("Задание 4 выполнено!")
        End If
    End Sub
End Class
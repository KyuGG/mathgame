Public Class M7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        a = num1.Text
        If (Med.Button7.BackColor <> Color.Lime And a = "-1.375") Then
            Med.num1.Text = Med.num1.Text + 1
            Med.Button7.BackColor = Color.Lime
        End If
        If (a = "-1.375") Then
            Me.Close()
            MsgBox("Задание 7 выполнено!")
        End If
    End Sub
End Class
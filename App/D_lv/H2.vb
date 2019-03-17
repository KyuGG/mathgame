Public Class H2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        a = num1.Text
        If (DIFFLVL.Button2.BackColor <> Color.Lime And a = 12) Then
            DIFFLVL.num1.Text = DIFFLVL.num1.Text + 1
            DIFFLVL.Button2.BackColor = Color.Lime
        End If
        If (a = 12) Then
            Me.Close()
            MsgBox("Задание 2 выполнено!")
        End If
    End Sub

    Private Sub num1_TextChanged(sender As Object, e As EventArgs) Handles num1.TextChanged

    End Sub
End Class
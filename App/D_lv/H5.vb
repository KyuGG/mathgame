Public Class H5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        a = num1.Text
        If (DIFFLVL.Button5.BackColor <> Color.Lime And a = 97) Then
            DIFFLVL.num1.Text = DIFFLVL.num1.Text + 1
            DIFFLVL.Button5.BackColor = Color.Lime
        End If
        If (a = 97) Then
            Me.Close()
            MsgBox("Задание 5 выполнено!")
        End If
    End Sub
End Class
Public Class DIFFLVL
    Private Sub Down_Click(sender As Object, e As EventArgs) Handles Down.Click
        Difficulty.Show()
        Me.Close()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        FileOpen(1, "C:\MathGame\HardInfo.txt", OpenMode.Output, OpenAccess.Default, OpenShare.Default, 1)
        Print(1, Me.num1.Text)
        FileClose(1)
    End Sub

    Private Sub Load_Click(sender As Object, e As EventArgs) Handles Load.Click
        FileOpen(1, "C:\MathGame\HardInfo.txt", OpenMode.Input, OpenAccess.Default, OpenShare.Default, 1)
        Dim f As Integer
        f = CInt(Me.num1.Text)
        Input(1, Me.num1.Text)
        If (CInt(Me.num1.Text) = 0) Then
            For i = f To 1 Step -1
                Me.Controls("button" & i).BackColor = Color.WhiteSmoke
            Next i
        End If
        If (CInt(Me.num1.Text) <> 0) Then
            For i = 1 To CInt(Me.num1.Text)
                Me.Controls("button" & i).BackColor = Color.Lime
            Next i
        End If
        FileClose(1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        H1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (CInt(Me.num1.Text) > 0) Then
            H2.Show()
        End If
        If (CInt(Me.num1.Text) < 1) Then
            MsgBox("Завершите предыдущие задания.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (CInt(Me.num1.Text) > 1) Then
            H3.Show()
        End If
        If (CInt(Me.num1.Text) < 2) Then
            MsgBox("Завершите предыдущие задания.")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (CInt(Me.num1.Text) > 2) Then
            H4.Show()
        End If
        If (CInt(Me.num1.Text) < 3) Then
            MsgBox("Завершите предыдущие задания.")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (CInt(Me.num1.Text) > 3) Then
            H5.Show()
        End If
        If (CInt(Me.num1.Text) < 4) Then
            MsgBox("Завершите предыдущие задания.")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (CInt(Me.num1.Text) > 4) Then
            H6.Show()
        End If
        If (CInt(Me.num1.Text) < 5) Then
            MsgBox("Завершите предыдущие задания.")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (CInt(Me.num1.Text) > 6) Then
            H7.Show()
        End If
        If (CInt(Me.num1.Text) < 7) Then
            MsgBox("Завершите предыдущие задания.")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (CInt(Me.num1.Text) > 7) Then
            H8.Show()
        End If
        If (CInt(Me.num1.Text) < 8) Then
            MsgBox("Завершите предыдущие задания.")
        End If
    End Sub
End Class
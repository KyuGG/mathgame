Public Class Difficulty
    Dim Medium, Harderst As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Easy.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FileOpen(1, "C:\MathGame\EasyInfo.txt", OpenMode.Input, OpenAccess.Default, OpenShare.Default, 1)
        Dim k As String
        k = "0"
        Input(1, k)
        FileClose(1)
        If (CInt(k) >= 8) Then
            Med.Show()
            Me.Close()
        End If
        If (CInt(k) < 8) Then
            MsgBox("Завершите 8 уровней в легком уровне сложности.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FileOpen(1, "C:\MathGame\MediumInfo.txt", OpenMode.Input, OpenAccess.Default, OpenShare.Default, 1)
        Dim k As String
        k = "0"
        Input(1, k)
        FileClose(1)
        If (CInt(k) >= 8) Then
            DIFFLVL.Show()
            Me.Close()
        End If
        If (CInt(k) < 8) Then
            MsgBox("Завершите 8 уровней в легком уровне сложности.")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class
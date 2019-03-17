Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("cmd /cstart https://vk.me/kyugg")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Тут будет небольшой текст с правилами")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Difficulty.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Computer.FileSystem.CreateDirectory("C:\MathGame")
        Dim fso1 As Object
        Dim fso2 As Object
        Dim fso3 As Object
        fso1 = CreateObject("Scripting.FileSystemObject")
        fso2 = CreateObject("Scripting.FileSystemObject")
        fso3 = CreateObject("Scripting.FileSystemObject")
        Dim File1 As Object
        Dim File2 As Object
        Dim File3 As Object
        File1 = fso1.CreateTextFile("C:\MathGame\EasyInfo.txt")
        File2 = fso2.CreateTextFile("C:\MathGame\MediumInfo.txt")
        File3 = fso3.CreateTextFile("C:\MathGame\HardInfo.txt")
        File1.Write("0")
        File2.Write("0")
        File3.Write("0")
        File1.Close
        File2.Close
        File3.Close
        fso1 = Nothing
        fso2 = Nothing
        fso3 = Nothing
        File1 = Nothing
        File2 = Nothing
        File3 = Nothing
        Difficulty.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Difficulty.Show()
        Me.Close()
    End Sub
End Class

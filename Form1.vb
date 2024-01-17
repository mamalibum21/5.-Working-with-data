Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim YourMessage As String

        Dim BirthYear As Integer
        YourMessage = "Happy Birthday! How old are you now?"


        MsgBox(YourMessage)
        BirthYear = Val(InputBox("enter year of birth"))
        MsgBox("You are now " & 2023 - BirthYear & " years old")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

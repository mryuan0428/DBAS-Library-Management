Public Class Form0

    Private Sub Form0_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        User_ID = TextBox1.Text
        Password = TextBox2.Text
        ConnectStr = "Data Source=169.254.98.172;initial catalog=LMS;user id='" & User_ID & "';password='" & Password & "'"
        Dim sqlstr As String
        sqlstr = "UPDATE StudentInfo SET LendTimes=1"
        If UpdateDataBase(sqlstr) = True Then

            Form1.Show()
            Me.Hide()
        Else
            MsgBox("非管理员！",, "警告")
        End If

    End Sub
End Class

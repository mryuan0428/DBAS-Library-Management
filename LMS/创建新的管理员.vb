Public Class frmAdmin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If User_ID = "sa" Then

            If TextBox1.Text <> "" And TextBox2.Text <> "" Then
                Dim sqlstr1, sqlstr2 As String

                sqlstr1 = "create login " & TextBox1.Text & " with password='" & TextBox2.Text & "'; create user " & TextBox1.Text & " for login " & TextBox1.Text & " with default_schema=dbo ;grant select,insert,delete,update on database::LMS to " & TextBox1.Text & " WITH GRANT OPTION;"
                sqlstr2 = "INSERT INTO Admin VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "')"
                If UpdateDataBase(sqlstr1) = True Then
                    If UpdateDataBase(sqlstr2) = True Then
                        MsgBox("创建成功",, "提示")
                    Else MsgBox("创建失败",, "提示")
                    End If
                Else MsgBox("创建失败",, "提示")
                End If
            End If

        Else MsgBox("无权限！",, "警告！")
        End If
    End Sub

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox2.PasswordChar = "*"
    End Sub
End Class
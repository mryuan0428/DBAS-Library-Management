Public Class frmModifyBook
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim isbn As String = Trim(TextBox1.Text)
        Dim sqlstr As String
        sqlstr = "SELECT* FROM BookInfo WHERE ISBN='" & isbn & "'"
        Dim ds As New DataSet()
        ds.Clear()
        Dim sqlconn As New SqlClient.SqlConnection(ConnectStr)
        DataAdapter = New SqlClient.SqlDataAdapter(sqlstr, sqlconn)
        DataAdapter.Fill(ds)

        If ds.Tables(0).Rows.Count = 0 Then
            MsgBox("待修改图书不存在",, "警告")
        Else
            Dim sign As Integer = 1

            If CheckBox1.Checked = True Then
                Dim isbn0 As String = TextBox2.Text
                sqlstr = "UPDATE BookInfo SET ISBN='" & isbn0 & "' WHERE ISBN='" & isbn & "'"
                If UpdateDataBase(sqlstr) = True Then
                    sign = sign * 1
                Else sign = sign * 0
                End If
            End If
            If CheckBox2.Checked = True Then
                Dim name As String = TextBox3.Text
                sqlstr = "UPDATE BookInfo SET Name='" & name & "' WHERE ISBN='" & isbn & "'"
                If UpdateDataBase(sqlstr) = True Then
                    sign = sign * 1
                Else sign = sign * 0
                End If
            End If
            If CheckBox3.Checked = True Then
                Dim type0 As String = TextBox4.Text
                sqlstr = "UPDATE BookInfo SET Type='" & type0 & "' WHERE ISBN='" & isbn & "'"
                If UpdateDataBase(sqlstr) = True Then
                    sign = sign * 1
                Else sign = sign * 0
                End If
            End If
            If CheckBox4.Checked = True Then
                Dim author As String = TextBox5.Text
                sqlstr = "UPDATE BookInfo SET Authors='" & author & "' WHERE ISBN='" & isbn & "'"
                If UpdateDataBase(sqlstr) = True Then
                    sign = sign * 1
                Else sign = sign * 0
                End If
            End If
            If CheckBox5.Checked = True Then
                Dim price As Double = TextBox6.Text
                sqlstr = "UPDATE BookInfo SET Price='" & price & "' WHERE ISBN='" & isbn & "'"
                If UpdateDataBase(sqlstr) = True Then
                    sign = sign * 1
                Else sign = sign * 0
                End If
            End If
            If CheckBox6.Checked = True Then
                Dim numbers As Integer = TextBox7.Text
                sqlstr = "UPDATE BookInfo SET Numbers='" & numbers & "' WHERE ISBN='" & isbn & "'"
                If UpdateDataBase(sqlstr) = True Then
                    sign = sign * 1
                Else sign = sign * 0
                End If
            End If
            If CheckBox7.Checked = True Then
                Dim publisher As String = TextBox8.Text
                sqlstr = "UPDATE BookInfo SET Publisher='" & publisher & "' WHERE ISBN='" & isbn & "'"
                If UpdateDataBase(sqlstr) = True Then
                    sign = sign * 1
                Else sign = sign * 0
                End If
            End If

            sqlstr = "SELECT* FROM BookInfo WHERE ISBN='" & isbn & "'"
            ds.Clear()
            DataAdapter = New SqlClient.SqlDataAdapter(sqlstr, sqlconn)
            DataAdapter.Fill(ds)
            Dim type As String
            type = ds.Tables(0).Rows(0)("Type")

            If CheckBox9.Checked = True Then
                Dim borrowdays As Integer = TextBox10.Text
                sqlstr = "UPDATE BorrowType SET BorrowDays='" & borrowdays & "' WHERE Type='" & Type & "'"
                If UpdateDataBase(sqlstr) = True Then
                    sign = sign * 1
                Else sign = sign * 0
                End If
            End If
            If CheckBox10.Checked = True Then
                Dim finebasse As Double = TextBox11.Text
                sqlstr = "UPDATE Dictionary SET FineBase='" & finebasse & "' WHERE ISBN='" & isbn & "'"
                If UpdateDataBase(sqlstr) = True Then
                    sign = sign * 1
                Else sign = sign * 0
                End If
            End If
            If CheckBox11.Checked = True Then
                Dim finemulti As Integer = TextBox12.Text
                sqlstr = "UPDATE Dictionary SET FineMulti='" & finemulti & "' WHERE ISBN='" & isbn & "'"
                If UpdateDataBase(sqlstr) = True Then
                    sign = sign * 1
                Else sign = sign * 0
                End If
            End If
            If CheckBox12.Checked = True Then
                Dim finefactor As Integer = TextBox13.Text
                sqlstr = "UPDATE Dictionary SET FineFactor='" & finefactor & "' WHERE ISBN='" & isbn & "'"
                If UpdateDataBase(sqlstr) = True Then
                    sign = sign * 1
                Else sign = sign * 0
                End If
            End If

            If sign = 1 Then
                MsgBox("修改成功",, "提示")
            End If
        End If



    End Sub


End Class
Public Class frmStockBook
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim bkInfo As New BookInfo()
        Dim sign As Integer = 1
        bkInfo = AddBookInfo()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox6.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox11.Text = "" Then
            MsgBox("*项不能为空！",, "警告")
        Else
            Dim isbn As String = Trim(Me.TextBox1.Text)
            Dim sqlstr As String
            sqlstr = "SELECT* FROM BookInfo WHERE ISBN='" & isbn & "'"
            Dim ds As New DataSet()
            ds.Clear()
            Dim sqlconn As New SqlClient.SqlConnection(ConnectStr)
            DataAdapter = New SqlClient.SqlDataAdapter(sqlstr, sqlconn)
            DataAdapter.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                Dim num0 As New Integer
                num0 = ds.Tables(0).Rows(0)("Numbers")
                Dim num As Integer = Val(Me.TextBox6.Text)
                num = num0 + num
                sqlstr = "UPDATE BookInfo SET Numbers='" & num & "' WHERE ISBN='" & isbn & "'"

            Else
                sqlstr = "INSERT INTO BookInfo(ISBN,Name,Type,Authors,Price,Numbers,Publisher)VALUES('" & bkInfo.ISBN & "','" & bkInfo.Name & "','" & bkInfo.Type & "','" & bkInfo.Authors & "','" & bkInfo.Price & "','" & bkInfo.Numbers & "','" & bkInfo.Publishers & "')"
                If UpdateDataBase(sqlstr) = True Then
                    sign = sign * 1
                Else sign = sign * 0
                End If

                Dim fb As Double = TextBox9.Text
                Dim fm As Integer = TextBox10.Text
                Dim ff As Integer = TextBox11.Text

                sqlstr = "INSERT INTO Dictionary(ISBN,FineBase,FineMulti,FineFactor)VALUES('" & bkInfo.ISBN & "','" & fb & "','" & fm & "','" & ff & "')"
                If UpdateDataBase(sqlstr) = True Then
                    sign = sign * 1
                Else sign = sign * 0
                End If
            End If

            If sign = 1 Then
                MsgBox("图书信息及逾期罚款参数添加成功。", MsgBoxStyle.OkOnly +
                       MsgBoxStyle.Information, "添加成功")
            End If

        End If


    End Sub

    Public Function AddBookInfo() As BookInfo
        Dim bookInfo As New BookInfo
        bookInfo.ISBN = Trim(Me.TextBox1.Text)
        bookInfo.Name = Trim(Me.TextBox2.Text)
        bookInfo.Type = Trim(Me.TextBox3.Text)
        bookInfo.Price = Val(Me.TextBox5.Text)
        bookInfo.Numbers = Val(Me.TextBox6.Text)
        bookInfo.Publishers = Trim(Me.TextBox7.Text)
        bookInfo.Authors = Trim(Me.TextBox4.Text)
        Return bookInfo
    End Function


End Class
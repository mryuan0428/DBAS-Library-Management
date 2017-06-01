Public Class frmBorrow
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Trim（Me.TextBox2.Text) <> "" Then
            Dim Regedited As Boolean
            Dim finesum As Double

            Dim sqlstr As String

            sqlstr = "SELECT Regedit,FineSum FROM StudentInfo WHERE ID='" & Trim(Me.TextBox2.Text) & "'"

            Dim MyDS As New DataSet()
            MyDS.Clear()
            Dim sqlconn As New SqlClient.SqlConnection(ConnectStr)
            DataAdapter = New SqlClient.SqlDataAdapter(sqlstr, sqlconn)
            DataAdapter.Fill(MyDS)
            If Not MyDS Is Nothing Then
                Regedited = CBool(MyDS.Tables(0).Rows(0)("Regedit"))
                finesum = Val(MyDS.Tables(0).Rows(0)("FineSum"))

                If Regedited = False Then
                    MsgBox("还没有注册，不能借阅图书，请先注册", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "借阅失败")
                    Exit Sub
                End If

                If finesum <> 0 Then
                    MsgBox("尚有罚款未交，请先交纳罚款。", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "借阅失败")
                    Exit Sub
                End If


                If Trim（Me.TextBox1.Text) <> "" Then
                    Dim num, num0 As Integer

                    sqlstr = "SELECT * FROM BookInfo WHERE ISBN='" & TextBox1.Text & "'"

                    Dim ds As New DataSet()
                    ds.Clear()
                    DataAdapter = New SqlClient.SqlDataAdapter(sqlstr, sqlconn)
                    DataAdapter.Fill(ds)
                    If Not ds Is Nothing Then
                        If ds.Tables(0).Rows(0)("Numbers") > 1 Then

                            Dim id As String = TextBox2.Text
                            Dim isbn As String = TextBox1.Text
                            Dim name As String
                            sqlstr = "SELECT * FROM BookInfo WHERE ISBN='" & TextBox1.Text & "'"
                            Dim ds2 As New DataSet()
                            ds2.Clear()
                            DataAdapter = New SqlClient.SqlDataAdapter(sqlstr, sqlconn)
                            DataAdapter.Fill(ds2)
                            name = ds2.Tables(0).Rows(0)("Name")

                            Dim lenddate As String = Format(Now, "yyyy-MM-dd")
                            Dim returntime As String
                            Dim type As String
                            Dim day As Integer
                            sqlstr = "SELECT * FROM BookInfo WHERE ISBN='" & TextBox1.Text & "'"

                            Dim ds3 As New DataSet()
                            ds3.Clear()
                            DataAdapter = New SqlClient.SqlDataAdapter(sqlstr, sqlconn)
                            DataAdapter.Fill(ds3)
                            type = ds3.Tables(0).Rows(0)("Type")

                            sqlstr = "SELECT * FROM BorrowType WHERE Type='" & type & "'"
                            Dim ds4 As New DataSet()
                            ds4.Clear()
                            DataAdapter = New SqlClient.SqlDataAdapter(sqlstr, sqlconn)
                            DataAdapter.Fill(ds4)
                            day = ds4.Tables(0).Rows(0)("BorrowDays")
                            returntime = Format(Now.AddDays(day), "yyyy-MM-dd")

                            Dim states As Boolean = 1
                            Dim renew As Boolean = 0

                            sqlstr = "SELECT * FROM LendInfo WHERE ID='" & id & "' AND ISBN='" & isbn & "'"
                            Dim ds5 As New DataSet()
                            ds5.Clear()
                            DataAdapter = New SqlClient.SqlDataAdapter(sqlstr, sqlconn)
                            DataAdapter.Fill(ds5)

                            If ds5.Tables(0).Rows.Count = 0 Then
                                num = ds.Tables(0).Rows(0)("Numbers") - 1
                                sqlstr = "UPDATE BookInfo SET Numbers='" & num & "' WHERE ISBN='" & TextBox1.Text & "'"
                                UpdateDataBase(sqlstr)

                                sqlstr = "SELECT * FROM StudentInfo WHERE ID='" & TextBox2.Text & "'"
                                Dim ds1 As New DataSet()
                                ds1.Clear()
                                DataAdapter = New SqlClient.SqlDataAdapter(sqlstr, sqlconn)
                                DataAdapter.Fill(ds1)

                                num0 = ds1.Tables(0).Rows(0)("LendTimes") + 1
                                sqlstr = "UPDATE StudentInfo SET LendTimes='" & num0 & "' WHERE ID='" & TextBox2.Text & "'"
                                UpdateDataBase(sqlstr)
                                sqlstr = "INSERT INTO LendInfo(ID,ISBN,Name,LendDate,ReturnDate,States,ReNew)VALUES('" & id & "','" & isbn & "','" & name & "','" & lenddate & "','" & returntime & "','" & states & "','" & renew & "')"

                                If UpdateDataBase(sqlstr) = True Then
                                    MsgBox("已成功借阅。",, "借阅成功")
                                End If
                            Else
                                If ds5.Tables(0).Rows(0)("States") = 0 Then
                                    num = ds.Tables(0).Rows(0)("Numbers") - 1
                                    sqlstr = "UPDATE BookInfo SET Numbers='" & num & "' WHERE ISBN='" & TextBox1.Text & "'"
                                    UpdateDataBase(sqlstr)

                                    sqlstr = "SELECT * FROM StudentInfo WHERE ID='" & TextBox2.Text & "'"
                                    Dim ds1 As New DataSet()
                                    ds1.Clear()
                                    DataAdapter = New SqlClient.SqlDataAdapter(sqlstr, sqlconn)
                                    DataAdapter.Fill(ds1)

                                    num0 = ds1.Tables(0).Rows(0)("LendTimes") + 1
                                    sqlstr = "UPDATE StudentInfo SET LendTimes='" & num0 & "' WHERE ID='" & TextBox2.Text & "'"
                                    UpdateDataBase(sqlstr)
                                    sqlstr = "UPDATE LendInfo SET States='" & states & "' WHERE ID='" & id & "' AND ISBN='" & isbn & "' "
                                    If UpdateDataBase(sqlstr) = True Then
                                        MsgBox("已成功借阅。",, "借阅成功")
                                    End If
                                Else MsgBox("您已借阅该图书，不可重复借阅。",, "借阅借阅")
                                End If

                            End If

                            sqlstr = "SELECT* FROM LendInfo WHERE ID='" & id & "'"
                            Dim ds6 As New DataSet()
                            ds6.Clear()
                            DataAdapter = New SqlClient.SqlDataAdapter(sqlstr, sqlconn)
                            DataAdapter.Fill(ds6)
                            Me.DataGridView1.DataSource = ds6.Tables(0)

                        Else
                            MsgBox("该图书库存不足", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "借阅失败")

                        End If
                    Else MsgBox("没有该图书，请重新输入图书的ISBN。", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "查无此书")
                    End If

                End If

            Else MsgBox("无读者ID信息",, "借阅失败")
            End If
        End If
    End Sub

    Private Sub frmBorrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
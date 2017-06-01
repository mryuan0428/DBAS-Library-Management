Public Class frmReturn
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlstr As String
        Dim isbn, id As String

        id = Trim(Me.TextBox2.Text)
        isbn = Trim(Me.TextBox1.Text)

        If id = "" Or isbn = "" Then
            Exit Sub
        End If

        sqlstr = "SELECT States,ReturnDate FROM LendInfo WHERE ID='" & id & "' AND ISBN='" & isbn & "'"
        Dim ds1 As New DataSet()
        ds1.Clear()
        ds1 = GetDataFromDB(sqlstr)
        If ds1.Tables(0).Rows.Count <> 0 Then

            If ds1.Tables(0).Rows(0)("States") <> 0 Then

                Dim rd1 As String = ds1.Tables(0).Rows(0)("ReturnDate")
                Dim now0 As String = Format(Now, "yyyy-MM-dd")

                If now0 <= rd1 Then

                    sqlstr = "UPDATE LendInfo SET States=0 WHERE ISBN = '" & isbn & "' AND ID= '" & id & " '"
                    If UpdateDataBase(sqlstr) = True Then
                        MsgBox("您已经成功的还掉了所借阅的书籍，欢迎下次光临！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "还书成功")
                        sqlstr = "SELECT* FROM LendInfo WHERE ID='" & id & "'"
                        Dim ds6 As New DataSet()
                        ds6.Clear()
                        Dim sqlconn As New SqlClient.SqlConnection(ConnectStr)
                        DataAdapter = New SqlClient.SqlDataAdapter(sqlstr, sqlconn)
                        DataAdapter.Fill(ds6)
                        Me.DataGridView1.DataSource = ds6.Tables(0)
                    Else
                        Return
                    End If
                Else
                    Dim fnum As Double
                    sqlstr = "SELECT FineSum FROM StudentInfo WHERE ID='" & id & "'"
                    Dim ds As New DataSet()
                    ds.Clear()
                    ds = GetDataFromDB(sqlstr)
                    fnum = Val(ds.Tables(0).Rows(0)("FineSum"))

                    Dim fb As Double
                    Dim fm As Double
                    Dim ff As Double

                    sqlstr = "SELECT FineBase,FineMulti,FineFactor FROM Dictionary WHERE ISBN='" & isbn & "'"
                    Dim ds2 As New DataSet()
                    ds2.Clear()
                    ds2 = GetDataFromDB(sqlstr)
                    fb = ds2.Tables(0).Rows(0)("FineBase")
                    fm = ds2.Tables(0).Rows(0)("FineMulti")
                    ff = ds2.Tables(0).Rows(0)("FineFactor")

                    fnum = fnum + fb + fm * ff * DateDiff(DateInterval.Day, Now.Today, CDate(rd1))
                    sqlstr = "UPDATE StudentInfo SET FineSum='" & fnum & "' WHERE ID='" & id & "'"
                    UpdateDataBase(sqlstr)

                    sqlstr = "UPDATE LendInfo SET States=0 WHERE ISBN = '" & isbn & "' AND ID= '" & id & " '"
                    If UpdateDataBase(sqlstr) = True Then
                        MsgBox("逾期还掉了所借阅的书籍，请及时缴纳欠款！", , "还书成功")
                        sqlstr = "SELECT* FROM LendInfo WHERE ID='" & id & "'"
                        Dim ds6 As New DataSet()
                        ds6.Clear()
                        Dim sqlconn As New SqlClient.SqlConnection(ConnectStr)
                        DataAdapter = New SqlClient.SqlDataAdapter(sqlstr, sqlconn)
                        DataAdapter.Fill(ds6)
                        Me.DataGridView1.DataSource = ds6.Tables(0)
                    Else
                        Return
                    End If



                End If
            Else MsgBox("该图书未借阅", , "提示")
            End If
        Else
            MsgBox("该图书未借阅", , "提示")
        End If
    End Sub
End Class
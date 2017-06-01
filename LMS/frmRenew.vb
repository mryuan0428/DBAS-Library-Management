Public Class frmRenew
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlstr As String

        Dim isbn, id As String
        id = Trim(Me.TextBox2.Text)
        isbn = Trim(Me.TextBox1.Text)

        If id = "" Or isbn = "" Then
            Exit Sub
        End If

        Dim rn, st As Boolean
        Dim Rt As Date

        sqlstr = "SELECT States,ReNew,ReturnDate FROM LendInfo WHERE ID='" & id & "' AND ISBN='" & isbn & "'"

        Dim MyDS = New DataSet()
        MyDS.Clear()
        MyDS = GetDataFromDB(sqlstr)

        If Not MyDS Is Nothing Then
            rn = CBool(MyDS.Tables(0).Rows(0)("ReNew"))
            Rt = CDate(MyDS.Tables(0).Rows(0)("ReturnDate"))
            st = CBool(MyDS.Tables(0).Rows(0)("States"))

            If st = False Then
                MsgBox("未借阅该图书！", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "续借失败")
                Exit Sub
            End If

            If rn = True Then
                MsgBox("该书已经续借了。此次续借失败。", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "续借失败")
                Exit Sub
            End If

            If DateDiff(DateInterval.Day, Now.Today, Rt) < 0 Then
                MsgBox("该书已经过期了，不能续借，此次续借失败。", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "续借失败")
                Exit Sub
            End If

            If DateDiff(DateInterval.Day, Rt, Now.Today) < 5 Then
                MsgBox("借阅时间太短，还不能续借，此次续借失败。", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "续借失败")
                Exit Sub
            End If


            sqlstr = "UPDATE LendInfo SET ReNew=1,ReturnDate='" & Format(Now.AddDays(10), "yyyy-MM-dd") & "' WHERE ID='" & id & "' AND ISBN='" & isbn & "'"

            If UpdateDataBase(sqlstr) = True Then
                MsgBox("已成功续借。",, "续借成功")
            End If

            sqlstr = "SELECT* FROM LendInfo WHERE ID='" & id & "'"
            Dim ds6 As New DataSet()
            ds6.Clear()
            Dim sqlconn As New SqlClient.SqlConnection(ConnectStr)
            DataAdapter = New SqlClient.SqlDataAdapter(sqlstr, sqlconn)
            DataAdapter.Fill(ds6)
            Me.DataGridView1.DataSource = ds6.Tables(0)
        Else
            MsgBox("未借阅该图书！",, "续借失败")
        End If


    End Sub

End Class
Public Class frmDeleteBook
    Dim sqlstr As String
    Dim sqlstr1 As String
    Dim sqlstr2 As String
    Dim num As Integer

    Private Sub TextBoxl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim isbn As String
            isbn = Trim(Me.TextBox1.Text)
            If isbn <> "" Then
                sqlstr = "SELECT Numbers FROM BookInfo WHERE ISBN='" & isbn & " '"

                Dim ds As New DataSet()
                ds.Clear()
                Dim sqlconn As New SqlClient.SqlConnection(ConnectStr)
                DataAdapter = New SqlClient.SqlDataAdapter(sqlstr, sqlconn)
                DataAdapter.Fill(ds)

                If Not ds Is Nothing Then
                    Me.NumericUpDown1.Maximum = ds.Tables(0).Rows(0)("Numbers")
                    Me.NumericUpDown1.Value = Me.NumericUpDown1.Maximum
                End If
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case Me.ComboBox1.SelectedIndex
            Case 0
                Me.NumericUpDown1.Value = Me.NumericUpDown1.Maximum
                Me.NumericUpDown1.Enabled = False
            Case 1
                num = Me.NumericUpDown1.Value
                Me.NumericUpDown1.Enabled = True
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim isbn As String
        Dim num1 As Integer
        isbn = Trim(Me.TextBox1.Text)
        If isbn <> "" Then
            Select Case Me.ComboBox1.SelectedIndex
                Case 0
                    sqlstr1 = "DELETE FROM BookInfo WHERE ISBN ='" & isbn & "'"
                    sqlstr2 = "DELETE FROM Dictionary WHERE ISBN ='" & isbn & "'"
                    If UpdateDataBase(sqlstr1) = True And UpdateDataBase(sqlstr2) = True Then
                        MsgBox("图书及其欠费参数注销成功。", , "注销成功")
                    End If
                Case 1
                    num1 = Me.NumericUpDown1.Value
                    num = num - num1
                    If num >= 0 Then
                        sqlstr = "UPDATE BookInfo SET Numbers='" & num & "' WHERE ISBN ='" & isbn & "'"
                        If UpdateDataBase(sqlstr) = True Then
                            MsgBox("部分图书注销成功。", , "注销成功")
                        End If
                    Else MsgBox("注销数量超出库存！",, "警告")
                    End If
            End Select

        End If
    End Sub

End Class
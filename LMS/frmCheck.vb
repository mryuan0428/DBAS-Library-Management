Public Class frmCheck
    Public tbName As String
    Public Sheet As String

    Public sqlstr As String

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case Me.ComboBox1.SelectedIndex
            Case 0
                tbName = "StudentInfo"
            Case 1
                tbName = "BookInfo"
            Case 2
                tbName = "LendInfo"
            Case 3
                tbName = "LendInfo"
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case Me.ComboBox2.SelectedIndex
            Case 0
                Sheet = "ISBN"
            Case 1
                Sheet = "ID"
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Trim(Me.TextBox1.Text) <> "" Then
            sqlstr = "SELECT * FROM " & tbName & " WHERE " & Sheet & "= '" & Trim(Me.TextBox1.Text) & "'"
            Dim ds As New DataSet()
            ds.Clear()
            ds = GetDataFromDB(sqlstr)
            If Not ds Is Nothing Then
                Me.DataGridView1.DataSource = ds.Tables(0).DefaultView
            Else msgbox("查无信息！",, "提示")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlstr = "SELECT * FROM StudentInfo"
        Dim ds As New DataSet()
        ds.Clear()
        ds = GetDataFromDB(sqlstr)
        If Not ds Is Nothing Then
            Me.DataGridView1.DataSource = ds.Tables(0).DefaultView
        Else MsgBox("查无信息！",, "提示")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sqlstr = "SELECT * FROM BookInfo"
        Dim ds As New DataSet()
        ds.Clear()
        ds = GetDataFromDB(sqlstr)
        If Not ds Is Nothing Then
            Me.DataGridView1.DataSource = ds.Tables(0).DefaultView
        Else MsgBox("查无信息！",, "提示")
        End If
    End Sub


End Class
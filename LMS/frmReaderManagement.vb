Public Class frmReaderManagement
    Dim id As String
    Dim sqlstr As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        id = Trim(Me.TextBox1.Text)
        If id <> "" Then
            sqlstr = "UPDATE StudentInfo SET Regedit='1' WHERE ID='" & id & "'"
            UpdateDataBase(sqlstr)
            sqlstr = "SELECT * FROM StudentInfo WHERE ID = '" & id & "'"
            Dim ds As New DataSet()
            ds.Clear()
            ds = GetDataFromDB(sqlstr)
            If Not ds Is Nothing Then
                Me.DataGridView1.DataSource = ds.Tables(0).DefaultView
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        id = Trim(Me.TextBox1.Text)
        If id <> "" Then
            sqlstr = "UPDATE StudentInfo SET Regedit='0' WHERE ID='" & id & "'"
            UpdateDataBase(sqlstr)
            sqlstr = "SELECT * FROM StudentInfo WHERE ID = '" & id & "'"
            Dim ds1 As New DataSet()
            ds1.Clear()
            ds1 = GetDataFromDB(sqlstr)
            If Not ds1 Is Nothing Then
                Me.DataGridView1.DataSource = ds1.Tables(0).DefaultView
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        id = Trim(Me.TextBox1.Text)
        If id <> "" Then
            sqlstr = "UPDATE StudentInfo SET FineSum='0',Regedit='1'  WHERE ID='" & id & "'"
            UpdateDataBase(sqlstr)
            sqlstr = "SELECT * FROM StudentInfo WHERE ID = '" & id & "'"
            Dim ds1 As New DataSet()
            ds1.Clear()
            ds1 = GetDataFromDB(sqlstr)
            If Not ds1 Is Nothing Then
                Me.DataGridView1.DataSource = ds1.Tables(0).DefaultView
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        id = Trim(Me.TextBox2.Text)
        Dim name As String = Trim(Me.TextBox3.Text)
        If id <> "" And name <> "" Then
            sqlstr = "INSERT INTO StudentInfo(ID,Name,Regedit,LendTimes,FineSum)VALUES('" & id & "','" & name & "',1,0,0)"
            UpdateDataBase(sqlstr)
            sqlstr = "SELECT * FROM StudentInfo WHERE ID = '" & id & "'"
            Dim ds1 As New DataSet()
            ds1.Clear()
            ds1 = GetDataFromDB(sqlstr)
            If Not ds1 Is Nothing Then
                Me.DataGridView1.DataSource = ds1.Tables(0).DefaultView
            End If
        End If
    End Sub
End Class
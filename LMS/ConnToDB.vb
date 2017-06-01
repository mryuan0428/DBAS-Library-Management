Imports System.Data.SqlClient

Module ConnToDB
    Public User_ID As String = Form0.TextBox1.Text
    Public Password As String = Form0.TextBox2.Text
    Public ConnectStr As String
    Public DataAdapter As SqlDataAdapter
    Public DataConnection As SqlConnection
    Public DataSet As DataSet

    Public Function GetDataFromDB(ByRef sqlstr As String) As DataSet
        ConnectStr = "169.254.98.172;initial catalog=LMS;user id='" & User_ID & "';password='" & Password & "'"
        Dim sqlconn As New SqlConnection(ConnectStr)
        Try
            DataAdapter = New SqlDataAdapter(sqlstr, sqlconn)
            DataSet = New DataSet()
            DataSet.Clear()
            DataAdapter.Fill(DataSet)
            sqlconn.Close()
        Catch
            MsgBox(Err.Description)
        End Try

        If DataSet.Tables(0).Rows.Count > 0 Then
            Return DataSet
        Else
            Return Nothing
        End If

    End Function

    Public Function UpdateDataBase(ByVal sqlstr As String) As String
        ConnectStr = "Data Source=169.254.98.172;initial catalog=LMS;user id='" & User_ID & "';password='" & Password & "'"
        Dim sqlconn As New SqlConnection(ConnectStr)
        Try
            Dim cmdTable As SqlCommand = New SqlCommand(sqlstr, sqlconn)
            cmdTable.CommandType = CommandType.Text
            sqlconn.Open()
            cmdTable.ExecuteNonQuery()
            sqlconn.Close()
        Catch
            MessageBox.Show(Err.Description)
            Return False
        End Try

        Return True
    End Function

    Public Class Dictionary
        Public ISBN As String
        Public FineBase As Double
        Public FineMulti As Double
        Public FineFactor As Double

    End Class
    Public Structure OnceLends
        Public ReadStyle As String
        Public LendBooks As Integer

    End Structure
    Public Structure BoorowType
        Public Type As String
        Public Days As Integer
    End Structure

End Module
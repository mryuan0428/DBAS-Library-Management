Public Class Form1
    Private Sub Form1_formclosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Form0.Close()
    End Sub

    Private Sub 添加图书ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 添加图书ToolStripMenuItem.Click
        If User_ID = "sa" Or User_ID = "admin1" Then
            Dim frm As New frmStockBook
            frm.MdiParent = Me
            frm.Show()
        Else MsgBox("无权限！",, "警告！")
        End If
    End Sub

    Private Sub 信息修改ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 信息修改ToolStripMenuItem.Click
        If User_ID = "sa" Or User_ID = "admin1" Then
            Dim frm As New frmModifyBook
            frm.MdiParent = Me
            frm.Show()
        Else MsgBox("无权限！",, "警告！")
        End If
    End Sub

    Private Sub 图书注销ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 图书注销ToolStripMenuItem.Click
        If User_ID = "sa" Or User_ID = "admin1" Then
            Dim frm As New frmDeleteBook
            frm.MdiParent = Me
            frm.Show()
        Else MsgBox("无权限！",, "警告！")
        End If
    End Sub

    Private Sub 借阅ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 借阅ToolStripMenuItem.Click
        Dim frm As New frmBorrow
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub 续借ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 续借ToolStripMenuItem.Click
        Dim frm As New frmRenew
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub 还书ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 还书ToolStripMenuItem.Click
        Dim frm As New frmReturn
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub 读者管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 读者管理ToolStripMenuItem.Click
        If User_ID = "sa" Or User_ID = "admin1" Then
            Dim frm As New frmReaderManagement
            frm.MdiParent = Me
            frm.Show()
        Else MsgBox("无权限！",, "警告！")
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim frm As New frmCheck
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub 水平平铺ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 水平平铺ToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub 垂直平铺ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 垂直平铺ToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub 创建新的管理员ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 创建新的管理员ToolStripMenuItem.Click
        If User_ID = "sa" Then
            Dim frm As New frmAdmin
            frm.MdiParent = Me
            frm.Show()
        Else MsgBox("无权限！",, "警告！")
        End If
    End Sub
End Class

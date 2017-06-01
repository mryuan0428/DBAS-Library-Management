<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.图书入库ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.添加图书ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.信息修改ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.图书注销ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.借阅管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.借阅ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.续借ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.还书ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.读者管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.管理员ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.创建新的管理员ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.窗口ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.水平平铺ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.垂直平铺ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.图书入库ToolStripMenuItem, Me.借阅管理ToolStripMenuItem, Me.ToolStripMenuItem2, Me.读者管理ToolStripMenuItem, Me.管理员ToolStripMenuItem, Me.窗口ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(550, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '图书入库ToolStripMenuItem
        '
        Me.图书入库ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.添加图书ToolStripMenuItem, Me.信息修改ToolStripMenuItem, Me.图书注销ToolStripMenuItem})
        Me.图书入库ToolStripMenuItem.Name = "图书入库ToolStripMenuItem"
        Me.图书入库ToolStripMenuItem.Size = New System.Drawing.Size(68, 21)
        Me.图书入库ToolStripMenuItem.Text = "图书管理"
        '
        '添加图书ToolStripMenuItem
        '
        Me.添加图书ToolStripMenuItem.Name = "添加图书ToolStripMenuItem"
        Me.添加图书ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.添加图书ToolStripMenuItem.Text = "图书入库"
        '
        '信息修改ToolStripMenuItem
        '
        Me.信息修改ToolStripMenuItem.Name = "信息修改ToolStripMenuItem"
        Me.信息修改ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.信息修改ToolStripMenuItem.Text = "信息修改"
        '
        '图书注销ToolStripMenuItem
        '
        Me.图书注销ToolStripMenuItem.Name = "图书注销ToolStripMenuItem"
        Me.图书注销ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.图书注销ToolStripMenuItem.Text = "图书注销"
        '
        '借阅管理ToolStripMenuItem
        '
        Me.借阅管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.借阅ToolStripMenuItem, Me.续借ToolStripMenuItem, Me.还书ToolStripMenuItem})
        Me.借阅管理ToolStripMenuItem.Name = "借阅管理ToolStripMenuItem"
        Me.借阅管理ToolStripMenuItem.Size = New System.Drawing.Size(68, 21)
        Me.借阅管理ToolStripMenuItem.Text = "借阅管理"
        '
        '借阅ToolStripMenuItem
        '
        Me.借阅ToolStripMenuItem.Name = "借阅ToolStripMenuItem"
        Me.借阅ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.借阅ToolStripMenuItem.Text = "借阅"
        '
        '续借ToolStripMenuItem
        '
        Me.续借ToolStripMenuItem.Name = "续借ToolStripMenuItem"
        Me.续借ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.续借ToolStripMenuItem.Text = "续借"
        '
        '还书ToolStripMenuItem
        '
        Me.还书ToolStripMenuItem.Name = "还书ToolStripMenuItem"
        Me.还书ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.还书ToolStripMenuItem.Text = "还书"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(44, 21)
        Me.ToolStripMenuItem2.Text = "查询"
        '
        '读者管理ToolStripMenuItem
        '
        Me.读者管理ToolStripMenuItem.Name = "读者管理ToolStripMenuItem"
        Me.读者管理ToolStripMenuItem.Size = New System.Drawing.Size(68, 21)
        Me.读者管理ToolStripMenuItem.Text = "读者管理"
        '
        '管理员ToolStripMenuItem
        '
        Me.管理员ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.创建新的管理员ToolStripMenuItem})
        Me.管理员ToolStripMenuItem.Name = "管理员ToolStripMenuItem"
        Me.管理员ToolStripMenuItem.Size = New System.Drawing.Size(56, 21)
        Me.管理员ToolStripMenuItem.Text = "管理员"
        '
        '创建新的管理员ToolStripMenuItem
        '
        Me.创建新的管理员ToolStripMenuItem.Name = "创建新的管理员ToolStripMenuItem"
        Me.创建新的管理员ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.创建新的管理员ToolStripMenuItem.Text = "创建新的管理员"
        '
        '窗口ToolStripMenuItem
        '
        Me.窗口ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.水平平铺ToolStripMenuItem, Me.垂直平铺ToolStripMenuItem})
        Me.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem"
        Me.窗口ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.窗口ToolStripMenuItem.Text = "窗口"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.ToolStripMenuItem1.Text = "层叠"
        '
        '水平平铺ToolStripMenuItem
        '
        Me.水平平铺ToolStripMenuItem.Name = "水平平铺ToolStripMenuItem"
        Me.水平平铺ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.水平平铺ToolStripMenuItem.Text = "水平平铺"
        '
        '垂直平铺ToolStripMenuItem
        '
        Me.垂直平铺ToolStripMenuItem.Name = "垂直平铺ToolStripMenuItem"
        Me.垂直平铺ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.垂直平铺ToolStripMenuItem.Text = "垂直平铺"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(550, 346)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "书吧管理系统"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 图书入库ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 添加图书ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 信息修改ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 图书注销ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 借阅管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 借阅ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 续借ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 还书ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 读者管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 窗口ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 水平平铺ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 垂直平铺ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents 管理员ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 创建新的管理员ToolStripMenuItem As ToolStripMenuItem
End Class

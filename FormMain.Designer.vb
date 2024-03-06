<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.新增IToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonAddTable = New System.Windows.Forms.Button()
        Me.ComboBoxTable = New System.Windows.Forms.ComboBox()
        Me.ButtonLoad = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonAddDatabase = New System.Windows.Forms.Button()
        Me.ComboBoxDataBase = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxHost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 154)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 31
        Me.DataGridView1.Size = New System.Drawing.Size(872, 566)
        Me.DataGridView1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新增IToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(134, 34)
        '
        '新增IToolStripMenuItem
        '
        Me.新增IToolStripMenuItem.Name = "新增IToolStripMenuItem"
        Me.新增IToolStripMenuItem.Size = New System.Drawing.Size(133, 30)
        Me.新增IToolStripMenuItem.Text = "新增(&I)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ButtonAddTable)
        Me.GroupBox1.Controls.Add(Me.ComboBoxTable)
        Me.GroupBox1.Controls.Add(Me.ButtonLoad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ButtonAddDatabase)
        Me.GroupBox1.Controls.Add(Me.ComboBoxDataBase)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxPassword)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxUsername)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxHost)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(871, 124)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "連線設定"
        '
        'ButtonAddTable
        '
        Me.ButtonAddTable.Location = New System.Drawing.Point(547, 83)
        Me.ButtonAddTable.Name = "ButtonAddTable"
        Me.ButtonAddTable.Size = New System.Drawing.Size(29, 27)
        Me.ButtonAddTable.TabIndex = 15
        Me.ButtonAddTable.Text = ".."
        Me.ButtonAddTable.UseVisualStyleBackColor = True
        '
        'ComboBoxTable
        '
        Me.ComboBoxTable.FormattingEnabled = True
        Me.ComboBoxTable.Location = New System.Drawing.Point(378, 82)
        Me.ComboBoxTable.Name = "ComboBoxTable"
        Me.ComboBoxTable.Size = New System.Drawing.Size(160, 26)
        Me.ComboBoxTable.TabIndex = 14
        '
        'ButtonLoad
        '
        Me.ButtonLoad.Location = New System.Drawing.Point(595, 74)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New System.Drawing.Size(259, 38)
        Me.ButtonLoad.TabIndex = 10
        Me.ButtonLoad.Text = "載入資料"
        Me.ButtonLoad.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(310, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 18)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "資料表"
        '
        'ButtonAddDatabase
        '
        Me.ButtonAddDatabase.Location = New System.Drawing.Point(268, 82)
        Me.ButtonAddDatabase.Name = "ButtonAddDatabase"
        Me.ButtonAddDatabase.Size = New System.Drawing.Size(29, 27)
        Me.ButtonAddDatabase.TabIndex = 12
        Me.ButtonAddDatabase.Text = ".."
        Me.ButtonAddDatabase.UseVisualStyleBackColor = True
        '
        'ComboBoxDataBase
        '
        Me.ComboBoxDataBase.FormattingEnabled = True
        Me.ComboBoxDataBase.Location = New System.Drawing.Point(99, 81)
        Me.ComboBoxDataBase.Name = "ComboBoxDataBase"
        Me.ComboBoxDataBase.Size = New System.Drawing.Size(160, 26)
        Me.ComboBoxDataBase.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "資料庫"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(642, 32)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(212, 29)
        Me.TextBoxPassword.TabIndex = 7
        Me.TextBoxPassword.Text = "!Asd8877"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(592, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "密碼"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(379, 32)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(200, 29)
        Me.TextBoxUsername.TabIndex = 5
        Me.TextBoxUsername.Text = "root"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(330, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "帳號"
        '
        'TextBoxHost
        '
        Me.TextBoxHost.Location = New System.Drawing.Point(99, 32)
        Me.TextBoxHost.Name = "TextBoxHost"
        Me.TextBoxHost.Size = New System.Drawing.Size(200, 29)
        Me.TextBoxHost.TabIndex = 3
        Me.TextBoxHost.Text = "DESKTOP-ML99O76"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "伺服器"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 732)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormMain"
        Me.Text = "MSSQL 操作範例"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonLoad As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxHost As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonAddDatabase As Button
    Friend WithEvents ComboBoxDataBase As ComboBox
    Friend WithEvents ButtonAddTable As Button
    Friend WithEvents ComboBoxTable As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 新增IToolStripMenuItem As ToolStripMenuItem
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Bad = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Good = New System.Windows.Forms.Label()
        Me.ProxyCount = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.StopBtn = New System.Windows.Forms.Button()
        Me.SourceBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ThreadsCount = New System.Windows.Forms.NumericUpDown()
        Me.TimeoutCount = New System.Windows.Forms.NumericUpDown()
        Me.GridLog = New System.Windows.Forms.DataGridView()
        Me.IPp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Countryy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cityy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Regionn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.setTypeProxy = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.ThreadsCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeoutCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bad
        '
        resources.ApplyResources(Me.Bad, "Bad")
        Me.Bad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bad.Name = "Bad"
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Bad)
        Me.Panel1.Controls.Add(Me.Good)
        Me.Panel1.Controls.Add(Me.ProxyCount)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Name = "Panel1"
        '
        'Good
        '
        resources.ApplyResources(Me.Good, "Good")
        Me.Good.ForeColor = System.Drawing.Color.Green
        Me.Good.Name = "Good"
        '
        'ProxyCount
        '
        resources.ApplyResources(Me.ProxyCount, "ProxyCount")
        Me.ProxyCount.ForeColor = System.Drawing.Color.White
        Me.ProxyCount.Name = "ProxyCount"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Name = "Label8"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Name = "Label11"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Name = "Label12"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Name = "Label5"
        '
        'StartBtn
        '
        resources.ApplyResources(Me.StartBtn, "StartBtn")
        Me.StartBtn.BackColor = System.Drawing.Color.Black
        Me.StartBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.UseVisualStyleBackColor = False
        '
        'StopBtn
        '
        resources.ApplyResources(Me.StopBtn, "StopBtn")
        Me.StopBtn.BackColor = System.Drawing.Color.Black
        Me.StopBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.StopBtn.Name = "StopBtn"
        Me.StopBtn.UseVisualStyleBackColor = False
        '
        'SourceBtn
        '
        resources.ApplyResources(Me.SourceBtn, "SourceBtn")
        Me.SourceBtn.BackColor = System.Drawing.Color.Black
        Me.SourceBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SourceBtn.Name = "SourceBtn"
        Me.SourceBtn.UseVisualStyleBackColor = False
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Name = "Label7"
        '
        'ThreadsCount
        '
        resources.ApplyResources(Me.ThreadsCount, "ThreadsCount")
        Me.ThreadsCount.BackColor = System.Drawing.Color.Black
        Me.ThreadsCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ThreadsCount.ForeColor = System.Drawing.SystemColors.Window
        Me.ThreadsCount.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.ThreadsCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ThreadsCount.Name = "ThreadsCount"
        Me.ThreadsCount.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'TimeoutCount
        '
        resources.ApplyResources(Me.TimeoutCount, "TimeoutCount")
        Me.TimeoutCount.BackColor = System.Drawing.Color.Black
        Me.TimeoutCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TimeoutCount.ForeColor = System.Drawing.SystemColors.Window
        Me.TimeoutCount.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.TimeoutCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TimeoutCount.Name = "TimeoutCount"
        Me.TimeoutCount.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'GridLog
        '
        resources.ApplyResources(Me.GridLog, "GridLog")
        Me.GridLog.AllowUserToAddRows = False
        Me.GridLog.AllowUserToDeleteRows = False
        Me.GridLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GridLog.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GridLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridLog.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.GridLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IPp, Me.Countryy, Me.Cityy, Me.Regionn})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridLog.DefaultCellStyle = DataGridViewCellStyle8
        Me.GridLog.EnableHeadersVisualStyles = False
        Me.GridLog.Name = "GridLog"
        Me.GridLog.RowHeadersVisible = False
        Me.GridLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'IPp
        '
        Me.IPp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        resources.ApplyResources(Me.IPp, "IPp")
        Me.IPp.Name = "IPp"
        '
        'Countryy
        '
        Me.Countryy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        resources.ApplyResources(Me.Countryy, "Countryy")
        Me.Countryy.Name = "Countryy"
        '
        'Cityy
        '
        Me.Cityy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        resources.ApplyResources(Me.Cityy, "Cityy")
        Me.Cityy.Name = "Cityy"
        '
        'Regionn
        '
        Me.Regionn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        resources.ApplyResources(Me.Regionn, "Regionn")
        Me.Regionn.Name = "Regionn"
        '
        'Button4
        '
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'setTypeProxy
        '
        resources.ApplyResources(Me.setTypeProxy, "setTypeProxy")
        Me.setTypeProxy.BackColor = System.Drawing.SystemColors.InfoText
        Me.setTypeProxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.setTypeProxy.ForeColor = System.Drawing.SystemColors.Window
        Me.setTypeProxy.FormattingEnabled = True
        Me.setTypeProxy.Items.AddRange(New Object() {resources.GetString("setTypeProxy.Items"), resources.GetString("setTypeProxy.Items1"), resources.GetString("setTypeProxy.Items2")})
        Me.setTypeProxy.Name = "setTypeProxy"
        '
        'Form2
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.setTypeProxy)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GridLog)
        Me.Controls.Add(Me.ThreadsCount)
        Me.Controls.Add(Me.TimeoutCount)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.StartBtn)
        Me.Controls.Add(Me.StopBtn)
        Me.Controls.Add(Me.SourceBtn)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ThreadsCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeoutCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bad As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Good As Label
    Friend WithEvents ProxyCount As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents StartBtn As Button
    Friend WithEvents StopBtn As Button
    Friend WithEvents SourceBtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ThreadsCount As NumericUpDown
    Friend WithEvents TimeoutCount As NumericUpDown
    Friend WithEvents GridLog As DataGridView
    Friend WithEvents IPp As DataGridViewTextBoxColumn
    Friend WithEvents Countryy As DataGridViewTextBoxColumn
    Friend WithEvents Cityy As DataGridViewTextBoxColumn
    Friend WithEvents Regionn As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
    Friend WithEvents setTypeProxy As ComboBox
End Class

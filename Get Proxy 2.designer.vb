<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Getproxy2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Getproxy2))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Download = New System.Windows.Forms.Button()
        Me.CM_SSL = New System.Windows.Forms.ComboBox()
        Me.CM_Anonymity = New System.Windows.Forms.ComboBox()
        Me.CM_Country = New System.Windows.Forms.ComboBox()
        Me.Time = New System.Windows.Forms.TrackBar()
        Me.CM_Type = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.timeout = New System.Windows.Forms.Label()
        Me.Results = New System.Windows.Forms.TextBox()
        Me.count = New System.Windows.Forms.Label()
        Me.save = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Time, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Download)
        Me.GroupBox1.Controls.Add(Me.CM_SSL)
        Me.GroupBox1.Controls.Add(Me.CM_Anonymity)
        Me.GroupBox1.Controls.Add(Me.CM_Country)
        Me.GroupBox1.Controls.Add(Me.Time)
        Me.GroupBox1.Controls.Add(Me.CM_Type)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.timeout)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(284, 254)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'Download
        '
        Me.Download.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Download.Location = New System.Drawing.Point(12, 219)
        Me.Download.Name = "Download"
        Me.Download.Size = New System.Drawing.Size(262, 23)
        Me.Download.TabIndex = 7
        Me.Download.Text = "Download"
        Me.Download.UseVisualStyleBackColor = True
        '
        'CM_SSL
        '
        Me.CM_SSL.BackColor = System.Drawing.Color.White
        Me.CM_SSL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CM_SSL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CM_SSL.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CM_SSL.ForeColor = System.Drawing.Color.Black
        Me.CM_SSL.FormattingEnabled = True
        Me.CM_SSL.Items.AddRange(New Object() {"SSL:ALL", "SSL:Yes", "SSL:No"})
        Me.CM_SSL.Location = New System.Drawing.Point(12, 190)
        Me.CM_SSL.Name = "CM_SSL"
        Me.CM_SSL.Size = New System.Drawing.Size(262, 23)
        Me.CM_SSL.TabIndex = 6
        '
        'CM_Anonymity
        '
        Me.CM_Anonymity.BackColor = System.Drawing.Color.White
        Me.CM_Anonymity.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CM_Anonymity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CM_Anonymity.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CM_Anonymity.ForeColor = System.Drawing.Color.Black
        Me.CM_Anonymity.FormattingEnabled = True
        Me.CM_Anonymity.Items.AddRange(New Object() {"Anonymity:All", "Anonymity:elite", "Anonymity:anonymous", "Anonymity:transparent"})
        Me.CM_Anonymity.Location = New System.Drawing.Point(12, 161)
        Me.CM_Anonymity.Name = "CM_Anonymity"
        Me.CM_Anonymity.Size = New System.Drawing.Size(262, 23)
        Me.CM_Anonymity.TabIndex = 5
        '
        'CM_Country
        '
        Me.CM_Country.BackColor = System.Drawing.Color.White
        Me.CM_Country.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CM_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CM_Country.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CM_Country.ForeColor = System.Drawing.Color.Black
        Me.CM_Country.FormattingEnabled = True
        Me.CM_Country.Items.AddRange(New Object() {"Country:All", "Country:US", "Country:GB", "Country:DE", "Country:CA", "Country:NL"})
        Me.CM_Country.Location = New System.Drawing.Point(12, 132)
        Me.CM_Country.Name = "CM_Country"
        Me.CM_Country.Size = New System.Drawing.Size(262, 23)
        Me.CM_Country.TabIndex = 4
        '
        'Time
        '
        Me.Time.Location = New System.Drawing.Point(9, 110)
        Me.Time.Maximum = 1000
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(265, 45)
        Me.Time.TabIndex = 2
        Me.Time.TickStyle = System.Windows.Forms.TickStyle.None
        Me.Time.Value = 1000
        '
        'CM_Type
        '
        Me.CM_Type.BackColor = System.Drawing.Color.White
        Me.CM_Type.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CM_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CM_Type.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CM_Type.ForeColor = System.Drawing.Color.Black
        Me.CM_Type.FormattingEnabled = True
        Me.CM_Type.Items.AddRange(New Object() {"HTTP Proxies", "Socks4 Proxies", "Socks5 Proxies"})
        Me.CM_Type.Location = New System.Drawing.Point(9, 68)
        Me.CM_Type.Name = "CM_Type"
        Me.CM_Type.Size = New System.Drawing.Size(265, 23)
        Me.CM_Type.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(89, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'timeout
        '
        Me.timeout.Location = New System.Drawing.Point(9, 94)
        Me.timeout.Name = "timeout"
        Me.timeout.Size = New System.Drawing.Size(265, 23)
        Me.timeout.TabIndex = 3
        Me.timeout.Text = "Timeout: 1000ms"
        Me.timeout.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Results
        '
        Me.Results.BackColor = System.Drawing.Color.White
        Me.Results.Location = New System.Drawing.Point(3, 287)
        Me.Results.Multiline = True
        Me.Results.Name = "Results"
        Me.Results.ReadOnly = True
        Me.Results.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Results.Size = New System.Drawing.Size(284, 223)
        Me.Results.TabIndex = 1
        Me.Results.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'count
        '
        Me.count.AutoSize = True
        Me.count.Location = New System.Drawing.Point(8, 267)
        Me.count.Name = "count"
        Me.count.Size = New System.Drawing.Size(55, 15)
        Me.count.TabIndex = 2
        Me.count.Text = "Count : 0"
        '
        'save
        '
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.Enabled = False
        Me.save.Location = New System.Drawing.Point(209, 259)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(71, 23)
        Me.save.TabIndex = 8
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.Location = New System.Drawing.Point(60, 518)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(164, 23)
        Me.LinkLabel1.TabIndex = 22
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Contact By Me"
        '
        'Getproxy2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(289, 547)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.count)
        Me.Controls.Add(Me.Results)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Getproxy2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "XC"
        Me.Text = "Get Proxy version 2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Time, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CM_Type As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Time As System.Windows.Forms.TrackBar
    Friend WithEvents timeout As System.Windows.Forms.Label
    Friend WithEvents CM_Country As System.Windows.Forms.ComboBox
    Friend WithEvents CM_Anonymity As System.Windows.Forms.ComboBox
    Friend WithEvents CM_SSL As System.Windows.Forms.ComboBox
    Friend WithEvents Results As System.Windows.Forms.TextBox
    Friend WithEvents Download As System.Windows.Forms.Button
    Friend WithEvents count As System.Windows.Forms.Label
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contry
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contry))
        Me.Lv1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveByCountryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IM = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ST = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lv1
        '
        Me.Lv1.AllowDrop = True
        Me.Lv1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.Lv1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Lv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lv1.FullRowSelect = True
        Me.Lv1.GridLines = True
        Me.Lv1.LargeImageList = Me.IM
        Me.Lv1.Location = New System.Drawing.Point(0, 0)
        Me.Lv1.Name = "Lv1"
        Me.Lv1.Size = New System.Drawing.Size(413, 431)
        Me.Lv1.SmallImageList = Me.IM
        Me.Lv1.TabIndex = 2
        Me.Lv1.UseCompatibleStateImageBehavior = False
        Me.Lv1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Proxy"
        Me.ColumnHeader1.Width = 259
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Country"
        Me.ColumnHeader2.Width = 87
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveByCountryToolStripMenuItem, Me.ClearAllToolStripMenuItem, Me.HomeToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(161, 70)
        '
        'SaveByCountryToolStripMenuItem
        '
        Me.SaveByCountryToolStripMenuItem.Image = CType(resources.GetObject("SaveByCountryToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveByCountryToolStripMenuItem.Name = "SaveByCountryToolStripMenuItem"
        Me.SaveByCountryToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SaveByCountryToolStripMenuItem.Text = "Save By Country"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Image = CType(resources.GetObject("ClearAllToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ClearAllToolStripMenuItem.Text = "Clear All"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'IM
        '
        Me.IM.ImageStream = CType(resources.GetObject("IM.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IM.TransparentColor = System.Drawing.Color.Transparent
        Me.IM.Images.SetKeyName(0, "0.jpeg")
        Me.IM.Images.SetKeyName(1, "AD.png")
        Me.IM.Images.SetKeyName(2, "AE.png")
        Me.IM.Images.SetKeyName(3, "AF.png")
        Me.IM.Images.SetKeyName(4, "AG.png")
        Me.IM.Images.SetKeyName(5, "AI.png")
        Me.IM.Images.SetKeyName(6, "AL.png")
        Me.IM.Images.SetKeyName(7, "Algeria.png")
        Me.IM.Images.SetKeyName(8, "AM.png")
        Me.IM.Images.SetKeyName(9, "androrat_logo_32pix.png")
        Me.IM.Images.SetKeyName(10, "AO.png")
        Me.IM.Images.SetKeyName(11, "AQ.png")
        Me.IM.Images.SetKeyName(12, "AR.png")
        Me.IM.Images.SetKeyName(13, "AS.png")
        Me.IM.Images.SetKeyName(14, "AT.png")
        Me.IM.Images.SetKeyName(15, "AU.png")
        Me.IM.Images.SetKeyName(16, "AW.png")
        Me.IM.Images.SetKeyName(17, "AZ.png")
        Me.IM.Images.SetKeyName(18, "BA.png")
        Me.IM.Images.SetKeyName(19, "BB.png")
        Me.IM.Images.SetKeyName(20, "BD.png")
        Me.IM.Images.SetKeyName(21, "BE.png")
        Me.IM.Images.SetKeyName(22, "BF.png")
        Me.IM.Images.SetKeyName(23, "BG.png")
        Me.IM.Images.SetKeyName(24, "BH.png")
        Me.IM.Images.SetKeyName(25, "BI.png")
        Me.IM.Images.SetKeyName(26, "BJ.png")
        Me.IM.Images.SetKeyName(27, "BM.png")
        Me.IM.Images.SetKeyName(28, "BN.png")
        Me.IM.Images.SetKeyName(29, "BO.png")
        Me.IM.Images.SetKeyName(30, "BR.png")
        Me.IM.Images.SetKeyName(31, "BS.png")
        Me.IM.Images.SetKeyName(32, "BT.png")
        Me.IM.Images.SetKeyName(33, "BW.png")
        Me.IM.Images.SetKeyName(34, "BY.png")
        Me.IM.Images.SetKeyName(35, "BZ.png")
        Me.IM.Images.SetKeyName(36, "CA.png")
        Me.IM.Images.SetKeyName(37, "CD.png")
        Me.IM.Images.SetKeyName(38, "CF.png")
        Me.IM.Images.SetKeyName(39, "CG.png")
        Me.IM.Images.SetKeyName(40, "CH.png")
        Me.IM.Images.SetKeyName(41, "CI.png")
        Me.IM.Images.SetKeyName(42, "CIS.png")
        Me.IM.Images.SetKeyName(43, "CK.png")
        Me.IM.Images.SetKeyName(44, "CL.png")
        Me.IM.Images.SetKeyName(45, "CM.png")
        Me.IM.Images.SetKeyName(46, "CN.png")
        Me.IM.Images.SetKeyName(47, "CO.png")
        Me.IM.Images.SetKeyName(48, "CR.png")
        Me.IM.Images.SetKeyName(49, "CU.png")
        Me.IM.Images.SetKeyName(50, "CV.png")
        Me.IM.Images.SetKeyName(51, "CY.png")
        Me.IM.Images.SetKeyName(52, "CZ.png")
        Me.IM.Images.SetKeyName(53, "DE.png")
        Me.IM.Images.SetKeyName(54, "DJ.png")
        Me.IM.Images.SetKeyName(55, "DK.png")
        Me.IM.Images.SetKeyName(56, "DM.png")
        Me.IM.Images.SetKeyName(57, "DO.png")
        Me.IM.Images.SetKeyName(58, "DZ.png")
        Me.IM.Images.SetKeyName(59, "EC.png")
        Me.IM.Images.SetKeyName(60, "EE.png")
        Me.IM.Images.SetKeyName(61, "EG.png")
        Me.IM.Images.SetKeyName(62, "EH.png")
        Me.IM.Images.SetKeyName(63, "ER.png")
        Me.IM.Images.SetKeyName(64, "ES.png")
        Me.IM.Images.SetKeyName(65, "ET.png")
        Me.IM.Images.SetKeyName(66, "EU.png")
        Me.IM.Images.SetKeyName(67, "FI.png")
        Me.IM.Images.SetKeyName(68, "Fiji.png")
        Me.IM.Images.SetKeyName(69, "FJ.png")
        Me.IM.Images.SetKeyName(70, "FM.png")
        Me.IM.Images.SetKeyName(71, "FO.png")
        Me.IM.Images.SetKeyName(72, "FR.png")
        Me.IM.Images.SetKeyName(73, "GA.png")
        Me.IM.Images.SetKeyName(74, "GB.png")
        Me.IM.Images.SetKeyName(75, "GD.png")
        Me.IM.Images.SetKeyName(76, "GE.png")
        Me.IM.Images.SetKeyName(77, "GH.png")
        Me.IM.Images.SetKeyName(78, "GI.png")
        Me.IM.Images.SetKeyName(79, "GM.png")
        Me.IM.Images.SetKeyName(80, "GN.png")
        Me.IM.Images.SetKeyName(81, "GQ.png")
        Me.IM.Images.SetKeyName(82, "GR.png")
        Me.IM.Images.SetKeyName(83, "GT.png")
        Me.IM.Images.SetKeyName(84, "GU.png")
        Me.IM.Images.SetKeyName(85, "GW.png")
        Me.IM.Images.SetKeyName(86, "GY.png")
        Me.IM.Images.SetKeyName(87, "HK.png")
        Me.IM.Images.SetKeyName(88, "HN.png")
        Me.IM.Images.SetKeyName(89, "HR.png")
        Me.IM.Images.SetKeyName(90, "HT.png")
        Me.IM.Images.SetKeyName(91, "HU.png")
        Me.IM.Images.SetKeyName(92, "ID.png")
        Me.IM.Images.SetKeyName(93, "IE.png")
        Me.IM.Images.SetKeyName(94, "IL.png")
        Me.IM.Images.SetKeyName(95, "IN.png")
        Me.IM.Images.SetKeyName(96, "IQ.png")
        Me.IM.Images.SetKeyName(97, "IR.png")
        Me.IM.Images.SetKeyName(98, "IS.png")
        Me.IM.Images.SetKeyName(99, "IT.png")
        Me.IM.Images.SetKeyName(100, "Japan.png")
        Me.IM.Images.SetKeyName(101, "JE.png")
        Me.IM.Images.SetKeyName(102, "JM.png")
        Me.IM.Images.SetKeyName(103, "JO.png")
        Me.IM.Images.SetKeyName(104, "KE.png")
        Me.IM.Images.SetKeyName(105, "KG.png")
        Me.IM.Images.SetKeyName(106, "KH.png")
        Me.IM.Images.SetKeyName(107, "KI.png")
        Me.IM.Images.SetKeyName(108, "KM.png")
        Me.IM.Images.SetKeyName(109, "KN.png")
        Me.IM.Images.SetKeyName(110, "KP.png")
        Me.IM.Images.SetKeyName(111, "KR.png")
        Me.IM.Images.SetKeyName(112, "KW.png")
        Me.IM.Images.SetKeyName(113, "KY.png")
        Me.IM.Images.SetKeyName(114, "KZ.png")
        Me.IM.Images.SetKeyName(115, "LA.png")
        Me.IM.Images.SetKeyName(116, "LB.png")
        Me.IM.Images.SetKeyName(117, "LC.png")
        Me.IM.Images.SetKeyName(118, "LI.png")
        Me.IM.Images.SetKeyName(119, "LK.png")
        Me.IM.Images.SetKeyName(120, "LR.png")
        Me.IM.Images.SetKeyName(121, "LS.png")
        Me.IM.Images.SetKeyName(122, "LT.png")
        Me.IM.Images.SetKeyName(123, "LU.png")
        Me.IM.Images.SetKeyName(124, "LV.png")
        Me.IM.Images.SetKeyName(125, "LY.png")
        Me.IM.Images.SetKeyName(126, "MA.png")
        Me.IM.Images.SetKeyName(127, "MC.png")
        Me.IM.Images.SetKeyName(128, "MD.png")
        Me.IM.Images.SetKeyName(129, "ME.png")
        Me.IM.Images.SetKeyName(130, "MG.png")
        Me.IM.Images.SetKeyName(131, "MH.png")
        Me.IM.Images.SetKeyName(132, "MK.png")
        Me.IM.Images.SetKeyName(133, "ML.png")
        Me.IM.Images.SetKeyName(134, "MM.png")
        Me.IM.Images.SetKeyName(135, "MN.png")
        Me.IM.Images.SetKeyName(136, "MO.png")
        Me.IM.Images.SetKeyName(137, "Moldova.png")
        Me.IM.Images.SetKeyName(138, "MR.png")
        Me.IM.Images.SetKeyName(139, "MS.png")
        Me.IM.Images.SetKeyName(140, "MT.png")
        Me.IM.Images.SetKeyName(141, "MU.png")
        Me.IM.Images.SetKeyName(142, "MV.png")
        Me.IM.Images.SetKeyName(143, "MW.png")
        Me.IM.Images.SetKeyName(144, "MX.png")
        Me.IM.Images.SetKeyName(145, "MY.png")
        Me.IM.Images.SetKeyName(146, "MZ.png")
        Me.IM.Images.SetKeyName(147, "NA.png")
        Me.IM.Images.SetKeyName(148, "NE.png")
        Me.IM.Images.SetKeyName(149, "NG.png")
        Me.IM.Images.SetKeyName(150, "NI.png")
        Me.IM.Images.SetKeyName(151, "NL.png")
        Me.IM.Images.SetKeyName(152, "NO.png")
        Me.IM.Images.SetKeyName(153, "NP.png")
        Me.IM.Images.SetKeyName(154, "NR.png")
        Me.IM.Images.SetKeyName(155, "NZ.png")
        Me.IM.Images.SetKeyName(156, "OM.png")
        Me.IM.Images.SetKeyName(157, "OPEC.png")
        Me.IM.Images.SetKeyName(158, "PA.png")
        Me.IM.Images.SetKeyName(159, "PE.png")
        Me.IM.Images.SetKeyName(160, "PF.png")
        Me.IM.Images.SetKeyName(161, "PG.png")
        Me.IM.Images.SetKeyName(162, "PH.png")
        Me.IM.Images.SetKeyName(163, "PK.png")
        Me.IM.Images.SetKeyName(164, "PL.png")
        Me.IM.Images.SetKeyName(165, "PR.png")
        Me.IM.Images.SetKeyName(166, "PS.png")
        Me.IM.Images.SetKeyName(167, "PT.png")
        Me.IM.Images.SetKeyName(168, "PW.png")
        Me.IM.Images.SetKeyName(169, "PY.png")
        Me.IM.Images.SetKeyName(170, "QA.png")
        Me.IM.Images.SetKeyName(171, "Red Cross.png")
        Me.IM.Images.SetKeyName(172, "RO.png")
        Me.IM.Images.SetKeyName(173, "RS.png")
        Me.IM.Images.SetKeyName(174, "RU.png")
        Me.IM.Images.SetKeyName(175, "RW.png")
        Me.IM.Images.SetKeyName(176, "SA.png")
        Me.IM.Images.SetKeyName(177, "SB.png")
        Me.IM.Images.SetKeyName(178, "SC.png")
        Me.IM.Images.SetKeyName(179, "SD.png")
        Me.IM.Images.SetKeyName(180, "SE.png")
        Me.IM.Images.SetKeyName(181, "SG.png")
        Me.IM.Images.SetKeyName(182, "SI.png")
        Me.IM.Images.SetKeyName(183, "SK.png")
        Me.IM.Images.SetKeyName(184, "SL.png")
        Me.IM.Images.SetKeyName(185, "SM.png")
        Me.IM.Images.SetKeyName(186, "SN.png")
        Me.IM.Images.SetKeyName(187, "SO.png")
        Me.IM.Images.SetKeyName(188, "SR.png")
        Me.IM.Images.SetKeyName(189, "ST.png")
        Me.IM.Images.SetKeyName(190, "SV.png")
        Me.IM.Images.SetKeyName(191, "SY.png")
        Me.IM.Images.SetKeyName(192, "SZ.png")
        Me.IM.Images.SetKeyName(193, "TC.png")
        Me.IM.Images.SetKeyName(194, "TD.png")
        Me.IM.Images.SetKeyName(195, "TG.png")
        Me.IM.Images.SetKeyName(196, "TH.png")
        Me.IM.Images.SetKeyName(197, "TJ.png")
        Me.IM.Images.SetKeyName(198, "TL.png")
        Me.IM.Images.SetKeyName(199, "TM.png")
        Me.IM.Images.SetKeyName(200, "TN.png")
        Me.IM.Images.SetKeyName(201, "TO.png")
        Me.IM.Images.SetKeyName(202, "Togo.png")
        Me.IM.Images.SetKeyName(203, "Tonga.png")
        Me.IM.Images.SetKeyName(204, "TR.png")
        Me.IM.Images.SetKeyName(205, "TT.png")
        Me.IM.Images.SetKeyName(206, "Turks and Caicos Islands.png")
        Me.IM.Images.SetKeyName(207, "Tuvalu.png")
        Me.IM.Images.SetKeyName(208, "TV.png")
        Me.IM.Images.SetKeyName(209, "TW.png")
        Me.IM.Images.SetKeyName(210, "TZ.png")
        Me.IM.Images.SetKeyName(211, "UA.png")
        Me.IM.Images.SetKeyName(212, "UG.png")
        Me.IM.Images.SetKeyName(213, "US.png")
        Me.IM.Images.SetKeyName(214, "UY.png")
        Me.IM.Images.SetKeyName(215, "UZ.png")
        Me.IM.Images.SetKeyName(216, "VC.png")
        Me.IM.Images.SetKeyName(217, "VE.png")
        Me.IM.Images.SetKeyName(218, "Venezuela.png")
        Me.IM.Images.SetKeyName(219, "VG.png")
        Me.IM.Images.SetKeyName(220, "VI.png")
        Me.IM.Images.SetKeyName(221, "VN.png")
        Me.IM.Images.SetKeyName(222, "VU.png")
        Me.IM.Images.SetKeyName(223, "Wales.png")
        Me.IM.Images.SetKeyName(224, "WS.png")
        Me.IM.Images.SetKeyName(225, "YE.png")
        Me.IM.Images.SetKeyName(226, "ZA.png")
        Me.IM.Images.SetKeyName(227, "ZM.png")
        Me.IM.Images.SetKeyName(228, "ZW.png")
        Me.IM.Images.SetKeyName(229, "Facheda.ico")
        Me.IM.Images.SetKeyName(230, "true.ico")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ST})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(413, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ST
        '
        Me.ST.IsLink = True
        Me.ST.Name = "ST"
        Me.ST.Size = New System.Drawing.Size(106, 17)
        Me.ST.Text = "Contact Ken Viruss"
        '
        'Contry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 453)
        Me.Controls.Add(Me.Lv1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Contry"
        Me.Text = "Get proxy country By Ken Viruss"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lv1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SaveByCountryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IM As ImageList
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ST As ToolStripStatusLabel
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
End Class

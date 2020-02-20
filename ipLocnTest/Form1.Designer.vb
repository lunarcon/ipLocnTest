<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Titlebar = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ChangeMapStyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SatelliteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TrafficToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.StaticMapFasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.GoToCoordinatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ZmIn = New System.Windows.Forms.ToolStripButton()
        Me.ZmOu = New System.Windows.Forms.ToolStripButton()
        Me.Sept = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lbe = New System.Windows.Forms.ToolStripLabel()
        Me.wb = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nav = New System.Windows.Forms.Panel()
        Me.KDN = New System.Windows.Forms.Button()
        Me.KUP = New System.Windows.Forms.Button()
        Me.KLT = New System.Windows.Forms.Button()
        Me.KRT = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Titlebar.SuspendLayout()
        Me.Nav.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Titlebar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1064, 23)
        Me.Panel1.TabIndex = 1
        '
        'Titlebar
        '
        Me.Titlebar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Titlebar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Titlebar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripDropDownButton1, Me.ToolStripDropDownButton2, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator4, Me.ZmIn, Me.ZmOu, Me.Sept, Me.ToolStripLabel1, Me.lbe})
        Me.Titlebar.Location = New System.Drawing.Point(0, 0)
        Me.Titlebar.Name = "Titlebar"
        Me.Titlebar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.Titlebar.Size = New System.Drawing.Size(1064, 27)
        Me.Titlebar.TabIndex = 0
        Me.Titlebar.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoToolTip = False
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButton1.Text = "Save Image"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeMapStyleToolStripMenuItem, Me.ToolStripSeparator3, Me.StaticMapFasterToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripDropDownButton1.Text = "Map Options"
        '
        'ChangeMapStyleToolStripMenuItem
        '
        Me.ChangeMapStyleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SatelliteToolStripMenuItem, Me.RoadToolStripMenuItem, Me.ToolStripSeparator2, Me.TrafficToolStripMenuItem})
        Me.ChangeMapStyleToolStripMenuItem.Name = "ChangeMapStyleToolStripMenuItem"
        Me.ChangeMapStyleToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ChangeMapStyleToolStripMenuItem.Text = "Change Map Style"
        '
        'SatelliteToolStripMenuItem
        '
        Me.SatelliteToolStripMenuItem.Name = "SatelliteToolStripMenuItem"
        Me.SatelliteToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.SatelliteToolStripMenuItem.Text = "Satellite"
        '
        'RoadToolStripMenuItem
        '
        Me.RoadToolStripMenuItem.Name = "RoadToolStripMenuItem"
        Me.RoadToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.RoadToolStripMenuItem.Text = "Regular"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(112, 6)
        '
        'TrafficToolStripMenuItem
        '
        Me.TrafficToolStripMenuItem.CheckOnClick = True
        Me.TrafficToolStripMenuItem.Name = "TrafficToolStripMenuItem"
        Me.TrafficToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.TrafficToolStripMenuItem.Text = "Labels"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(167, 6)
        '
        'StaticMapFasterToolStripMenuItem
        '
        Me.StaticMapFasterToolStripMenuItem.CheckOnClick = True
        Me.StaticMapFasterToolStripMenuItem.Name = "StaticMapFasterToolStripMenuItem"
        Me.StaticMapFasterToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.StaticMapFasterToolStripMenuItem.Text = "Static Map"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.GoToCoordinatesToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripDropDownButton2.Text = "Search"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'GoToCoordinatesToolStripMenuItem
        '
        Me.GoToCoordinatesToolStripMenuItem.Name = "GoToCoordinatesToolStripMenuItem"
        Me.GoToCoordinatesToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.GoToCoordinatesToolStripMenuItem.Text = "Search Input"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButton2.Text = "Locate Me"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButton3.Text = "Refresh"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'ZmIn
        '
        Me.ZmIn.AutoToolTip = False
        Me.ZmIn.BackColor = System.Drawing.Color.Transparent
        Me.ZmIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ZmIn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZmIn.Image = CType(resources.GetObject("ZmIn.Image"), System.Drawing.Image)
        Me.ZmIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ZmIn.Name = "ZmIn"
        Me.ZmIn.Size = New System.Drawing.Size(24, 24)
        Me.ZmIn.Text = "+"
        Me.ZmIn.ToolTipText = "Zoom In"
        Me.ZmIn.Visible = False
        '
        'ZmOu
        '
        Me.ZmOu.AutoToolTip = False
        Me.ZmOu.BackColor = System.Drawing.Color.Transparent
        Me.ZmOu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ZmOu.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZmOu.Image = CType(resources.GetObject("ZmOu.Image"), System.Drawing.Image)
        Me.ZmOu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ZmOu.Name = "ZmOu"
        Me.ZmOu.Size = New System.Drawing.Size(23, 24)
        Me.ZmOu.Text = "-"
        Me.ZmOu.ToolTipText = "Zoom Out"
        Me.ZmOu.Visible = False
        '
        'Sept
        '
        Me.Sept.Name = "Sept"
        Me.Sept.Size = New System.Drawing.Size(6, 27)
        Me.Sept.Visible = False
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(225, 24)
        Me.ToolStripLabel1.Text = "Bing Maps - Copyright @ Microsoft, 2020"
        '
        'lbe
        '
        Me.lbe.Name = "lbe"
        Me.lbe.Size = New System.Drawing.Size(188, 24)
        Me.lbe.Text = "Drag to move map, Scroll to zoom"
        '
        'wb
        '
        Me.wb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wb.IsWebBrowserContextMenuEnabled = False
        Me.wb.Location = New System.Drawing.Point(0, 23)
        Me.wb.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb.Name = "wb"
        Me.wb.ScriptErrorsSuppressed = True
        Me.wb.ScrollBarsEnabled = False
        Me.wb.Size = New System.Drawing.Size(1064, 828)
        Me.wb.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(1007, 838)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Bing Maps"
        '
        'Nav
        '
        Me.Nav.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Nav.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Nav.Controls.Add(Me.KDN)
        Me.Nav.Controls.Add(Me.KUP)
        Me.Nav.Controls.Add(Me.KLT)
        Me.Nav.Controls.Add(Me.KRT)
        Me.Nav.Location = New System.Drawing.Point(12, 779)
        Me.Nav.Name = "Nav"
        Me.Nav.Size = New System.Drawing.Size(60, 60)
        Me.Nav.TabIndex = 4
        Me.Nav.Visible = False
        '
        'KDN
        '
        Me.KDN.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.KDN.FlatAppearance.BorderSize = 0
        Me.KDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KDN.Font = New System.Drawing.Font("Webdings", 11.25!)
        Me.KDN.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.KDN.Location = New System.Drawing.Point(20, 34)
        Me.KDN.Name = "KDN"
        Me.KDN.Size = New System.Drawing.Size(23, 23)
        Me.KDN.TabIndex = 1
        Me.KDN.Text = "6"
        Me.KDN.UseVisualStyleBackColor = True
        '
        'KUP
        '
        Me.KUP.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.KUP.FlatAppearance.BorderSize = 0
        Me.KUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KUP.Font = New System.Drawing.Font("Webdings", 11.25!)
        Me.KUP.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.KUP.Location = New System.Drawing.Point(20, -1)
        Me.KUP.Name = "KUP"
        Me.KUP.Size = New System.Drawing.Size(23, 23)
        Me.KUP.TabIndex = 0
        Me.KUP.Text = "5"
        Me.KUP.UseVisualStyleBackColor = True
        '
        'KLT
        '
        Me.KLT.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.KLT.FlatAppearance.BorderSize = 0
        Me.KLT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KLT.Font = New System.Drawing.Font("Webdings", 11.25!)
        Me.KLT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.KLT.Location = New System.Drawing.Point(3, 18)
        Me.KLT.Name = "KLT"
        Me.KLT.Size = New System.Drawing.Size(23, 23)
        Me.KLT.TabIndex = 3
        Me.KLT.Text = "3"
        Me.KLT.UseVisualStyleBackColor = True
        '
        'KRT
        '
        Me.KRT.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.KRT.FlatAppearance.BorderSize = 0
        Me.KRT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KRT.Font = New System.Drawing.Font("Webdings", 11.25!)
        Me.KRT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.KRT.Location = New System.Drawing.Point(37, 18)
        Me.KRT.Name = "KRT"
        Me.KRT.Size = New System.Drawing.Size(23, 23)
        Me.KRT.TabIndex = 2
        Me.KRT.Text = "4"
        Me.KRT.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 851)
        Me.Controls.Add(Me.Nav)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.wb)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(1080, 890)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GetMap"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Titlebar.ResumeLayout(False)
        Me.Titlebar.PerformLayout()
        Me.Nav.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Titlebar As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ChangeMapStyleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SatelliteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TrafficToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents StaticMapFasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents GoToCoordinatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents wb As WebBrowser
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ZmIn As ToolStripButton
    Friend WithEvents ZmOu As ToolStripButton
    Friend WithEvents Sept As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbe As ToolStripLabel
    Friend WithEvents Nav As Panel
    Friend WithEvents KLT As Button
    Friend WithEvents KRT As Button
    Friend WithEvents KDN As Button
    Friend WithEvents KUP As Button
    Friend WithEvents ToolStripButton3 As ToolStripButton
End Class

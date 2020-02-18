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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
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
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.GoToCoordinatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ZmIn = New System.Windows.Forms.ToolStripButton()
        Me.ZmOu = New System.Windows.Forms.ToolStripButton()
        Me.Sept = New System.Windows.Forms.ToolStripSeparator()
        Me.wb = New System.Windows.Forms.WebBrowser()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1064, 23)
        Me.Panel1.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripDropDownButton1, Me.ToolStripButton2, Me.ToolStripDropDownButton2, Me.ToolStripSeparator4, Me.ZmIn, Me.ZmOu, Me.Sept, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1064, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoToolTip = False
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(71, 22)
        Me.ToolStripButton1.Text = "Save Image"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeMapStyleToolStripMenuItem, Me.ToolStripSeparator3, Me.StaticMapFasterToolStripMenuItem})
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripDropDownButton1.Text = "Map Options"
        '
        'ChangeMapStyleToolStripMenuItem
        '
        Me.ChangeMapStyleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SatelliteToolStripMenuItem, Me.RoadToolStripMenuItem, Me.ToolStripSeparator2, Me.TrafficToolStripMenuItem})
        Me.ChangeMapStyleToolStripMenuItem.Name = "ChangeMapStyleToolStripMenuItem"
        Me.ChangeMapStyleToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ChangeMapStyleToolStripMenuItem.Text = "Change Map Style"
        '
        'SatelliteToolStripMenuItem
        '
        Me.SatelliteToolStripMenuItem.Name = "SatelliteToolStripMenuItem"
        Me.SatelliteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.SatelliteToolStripMenuItem.Text = "Aerial"
        '
        'RoadToolStripMenuItem
        '
        Me.RoadToolStripMenuItem.Name = "RoadToolStripMenuItem"
        Me.RoadToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.RoadToolStripMenuItem.Text = "Road"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(104, 6)
        '
        'TrafficToolStripMenuItem
        '
        Me.TrafficToolStripMenuItem.CheckOnClick = True
        Me.TrafficToolStripMenuItem.Name = "TrafficToolStripMenuItem"
        Me.TrafficToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.TrafficToolStripMenuItem.Text = "Labels"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(169, 6)
        '
        'StaticMapFasterToolStripMenuItem
        '
        Me.StaticMapFasterToolStripMenuItem.CheckOnClick = True
        Me.StaticMapFasterToolStripMenuItem.Name = "StaticMapFasterToolStripMenuItem"
        Me.StaticMapFasterToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.StaticMapFasterToolStripMenuItem.Text = "Static Map (Faster)"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripButton2.Text = "Locate Me"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.GoToCoordinatesToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(67, 22)
        Me.ToolStripDropDownButton2.Text = "Navigate"
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
        Me.GoToCoordinatesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GoToCoordinatesToolStripMenuItem.Text = "Go to Coordinates"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ZmIn
        '
        Me.ZmIn.AutoToolTip = False
        Me.ZmIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ZmIn.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ZmIn.Image = CType(resources.GetObject("ZmIn.Image"), System.Drawing.Image)
        Me.ZmIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ZmIn.Name = "ZmIn"
        Me.ZmIn.Size = New System.Drawing.Size(23, 24)
        Me.ZmIn.Text = "+"
        Me.ZmIn.ToolTipText = "Zoom In"
        Me.ZmIn.Visible = False
        '
        'ZmOu
        '
        Me.ZmOu.AutoToolTip = False
        Me.ZmOu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ZmOu.Font = New System.Drawing.Font("Segoe UI", 11.0!)
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
        Me.Sept.Size = New System.Drawing.Size(6, 25)
        Me.Sept.Visible = False
        '
        'wb
        '
        Me.wb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wb.Location = New System.Drawing.Point(0, 23)
        Me.wb.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb.Name = "wb"
        Me.wb.ScriptErrorsSuppressed = True
        Me.wb.ScrollBarsEnabled = False
        Me.wb.Size = New System.Drawing.Size(1064, 828)
        Me.wb.TabIndex = 2
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(225, 22)
        Me.ToolStripLabel1.Text = "Bing Maps - Copyright @ Microsoft, 2020"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 851)
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
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
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
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class applicants
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(applicants))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtfullname = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtid = New MaterialSkin.Controls.MaterialTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtage = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtRegion = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdistrict = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcontact = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtposition = New System.Windows.Forms.ComboBox()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.BunifuCards28 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnexpenseaprove = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.popalertexpense = New Bunifu.Framework.UI.BunifuCards()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.lblexpense = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards28.SuspendLayout()
        Me.popalertexpense.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(740, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(359, 101)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 253
        Me.PictureBox2.TabStop = False
        '
        'txtfullname
        '
        Me.txtfullname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtfullname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtfullname.Depth = 0
        Me.txtfullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtfullname.Hint = "Full Name"
        Me.txtfullname.Location = New System.Drawing.Point(527, 95)
        Me.txtfullname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtfullname.MaxLength = 50
        Me.txtfullname.MouseState = MaterialSkin.MouseState.OUT
        Me.txtfullname.Multiline = False
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Password = True
        Me.txtfullname.Size = New System.Drawing.Size(340, 50)
        Me.txtfullname.TabIndex = 255
        Me.txtfullname.Text = ""
        '
        'txtid
        '
        Me.txtid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtid.Depth = 0
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtid.Hint = "User ID"
        Me.txtid.Location = New System.Drawing.Point(369, 95)
        Me.txtid.Margin = New System.Windows.Forms.Padding(2)
        Me.txtid.MaxLength = 50
        Me.txtid.MouseState = MaterialSkin.MouseState.OUT
        Me.txtid.Multiline = False
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(142, 50)
        Me.txtid.TabIndex = 254
        Me.txtid.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(365, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 22)
        Me.Label1.TabIndex = 262
        Me.Label1.Text = "User ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(539, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 22)
        Me.Label2.TabIndex = 263
        Me.Label2.Text = "Full Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(894, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 22)
        Me.Label3.TabIndex = 281
        Me.Label3.Text = "Age"
        '
        'txtage
        '
        Me.txtage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtage.Depth = 0
        Me.txtage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtage.Hint = "Age"
        Me.txtage.Location = New System.Drawing.Point(893, 95)
        Me.txtage.Margin = New System.Windows.Forms.Padding(2)
        Me.txtage.MaxLength = 50
        Me.txtage.MouseState = MaterialSkin.MouseState.OUT
        Me.txtage.Multiline = False
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(96, 50)
        Me.txtage.TabIndex = 280
        Me.txtage.Text = ""
        '
        'txtRegion
        '
        Me.txtRegion.BackColor = System.Drawing.SystemColors.Control
        Me.txtRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegion.FormattingEnabled = True
        Me.txtRegion.Items.AddRange(New Object() {"Goal Keeper", "Striker", "Center Midfilder", "Defender"})
        Me.txtRegion.Location = New System.Drawing.Point(369, 186)
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.Size = New System.Drawing.Size(168, 33)
        Me.txtRegion.TabIndex = 295
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(365, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 22)
        Me.Label7.TabIndex = 296
        Me.Label7.Text = "Region"
        '
        'txtdistrict
        '
        Me.txtdistrict.BackColor = System.Drawing.SystemColors.Control
        Me.txtdistrict.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdistrict.FormattingEnabled = True
        Me.txtdistrict.Items.AddRange(New Object() {"Goal Keeper", "Striker", "Center Midfilder", "Defender"})
        Me.txtdistrict.Location = New System.Drawing.Point(543, 186)
        Me.txtdistrict.Name = "txtdistrict"
        Me.txtdistrict.Size = New System.Drawing.Size(168, 33)
        Me.txtdistrict.TabIndex = 298
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(543, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 22)
        Me.Label8.TabIndex = 297
        Me.Label8.Text = "District"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(1006, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 22)
        Me.Label6.TabIndex = 306
        Me.Label6.Text = "Contact"
        '
        'txtcontact
        '
        Me.txtcontact.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcontact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcontact.Depth = 0
        Me.txtcontact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtcontact.Hint = "Contact"
        Me.txtcontact.Location = New System.Drawing.Point(1010, 95)
        Me.txtcontact.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcontact.MaxLength = 50
        Me.txtcontact.MouseState = MaterialSkin.MouseState.OUT
        Me.txtcontact.Multiline = False
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(192, 50)
        Me.txtcontact.TabIndex = 303
        Me.txtcontact.Text = ""
        '
        'txtposition
        '
        Me.txtposition.BackColor = System.Drawing.SystemColors.Control
        Me.txtposition.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtposition.FormattingEnabled = True
        Me.txtposition.Items.AddRange(New Object() {"Goal Keeper", "Striker", "Center Midfilder", "Defender"})
        Me.txtposition.Location = New System.Drawing.Point(729, 186)
        Me.txtposition.Name = "txtposition"
        Me.txtposition.Size = New System.Drawing.Size(168, 33)
        Me.txtposition.TabIndex = 302
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.ForeColor = System.Drawing.Color.Black
        Me.Label101.Location = New System.Drawing.Point(729, 161)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(90, 22)
        Me.Label101.TabIndex = 301
        Me.Label101.Text = "Position"
        '
        'BunifuCards28
        '
        Me.BunifuCards28.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuCards28.BackColor = System.Drawing.Color.White
        Me.BunifuCards28.BorderRadius = 5
        Me.BunifuCards28.BottomSahddow = False
        Me.BunifuCards28.color = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BunifuCards28.Controls.Add(Me.Label6)
        Me.BunifuCards28.Controls.Add(Me.txtcontact)
        Me.BunifuCards28.Controls.Add(Me.txtdistrict)
        Me.BunifuCards28.Controls.Add(Me.txtposition)
        Me.BunifuCards28.Controls.Add(Me.Label101)
        Me.BunifuCards28.Controls.Add(Me.BunifuThinButton21)
        Me.BunifuCards28.Controls.Add(Me.Label8)
        Me.BunifuCards28.Controls.Add(Me.btnexpenseaprove)
        Me.BunifuCards28.Controls.Add(Me.Label7)
        Me.BunifuCards28.Controls.Add(Me.popalertexpense)
        Me.BunifuCards28.Controls.Add(Me.txtRegion)
        Me.BunifuCards28.Controls.Add(Me.Label108)
        Me.BunifuCards28.Controls.Add(Me.Label3)
        Me.BunifuCards28.Controls.Add(Me.txtfullname)
        Me.BunifuCards28.Controls.Add(Me.txtage)
        Me.BunifuCards28.Controls.Add(Me.txtid)
        Me.BunifuCards28.Controls.Add(Me.Label2)
        Me.BunifuCards28.Controls.Add(Me.Label1)
        Me.BunifuCards28.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCards28.LeftSahddow = False
        Me.BunifuCards28.Location = New System.Drawing.Point(134, 119)
        Me.BunifuCards28.Name = "BunifuCards28"
        Me.BunifuCards28.RightSahddow = False
        Me.BunifuCards28.ShadowDepth = 20
        Me.BunifuCards28.Size = New System.Drawing.Size(1529, 670)
        Me.BunifuCards28.TabIndex = 307
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BunifuThinButton21.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "ViewApplications"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(639, 311)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(243, 62)
        Me.BunifuThinButton21.TabIndex = 249
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnexpenseaprove
        '
        Me.btnexpenseaprove.ActiveBorderThickness = 1
        Me.btnexpenseaprove.ActiveCornerRadius = 20
        Me.btnexpenseaprove.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.btnexpenseaprove.ActiveForecolor = System.Drawing.Color.White
        Me.btnexpenseaprove.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.btnexpenseaprove.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnexpenseaprove.BackColor = System.Drawing.Color.White
        Me.btnexpenseaprove.BackgroundImage = CType(resources.GetObject("btnexpenseaprove.BackgroundImage"), System.Drawing.Image)
        Me.btnexpenseaprove.ButtonText = "Add "
        Me.btnexpenseaprove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexpenseaprove.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexpenseaprove.ForeColor = System.Drawing.Color.White
        Me.btnexpenseaprove.IdleBorderThickness = 1
        Me.btnexpenseaprove.IdleCornerRadius = 20
        Me.btnexpenseaprove.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btnexpenseaprove.IdleForecolor = System.Drawing.Color.White
        Me.btnexpenseaprove.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btnexpenseaprove.Location = New System.Drawing.Point(385, 304)
        Me.btnexpenseaprove.Margin = New System.Windows.Forms.Padding(6)
        Me.btnexpenseaprove.Name = "btnexpenseaprove"
        Me.btnexpenseaprove.Size = New System.Drawing.Size(233, 71)
        Me.btnexpenseaprove.TabIndex = 233
        Me.btnexpenseaprove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'popalertexpense
        '
        Me.popalertexpense.BackColor = System.Drawing.SystemColors.Control
        Me.popalertexpense.BorderRadius = 5
        Me.popalertexpense.BottomSahddow = False
        Me.popalertexpense.color = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.popalertexpense.Controls.Add(Me.Panel10)
        Me.popalertexpense.Controls.Add(Me.lblexpense)
        Me.popalertexpense.LeftSahddow = False
        Me.popalertexpense.Location = New System.Drawing.Point(385, 382)
        Me.popalertexpense.Name = "popalertexpense"
        Me.popalertexpense.RightSahddow = False
        Me.popalertexpense.ShadowDepth = 20
        Me.popalertexpense.Size = New System.Drawing.Size(497, 79)
        Me.popalertexpense.TabIndex = 248
        Me.popalertexpense.Visible = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(0, 74)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(497, 5)
        Me.Panel10.TabIndex = 149
        '
        'lblexpense
        '
        Me.lblexpense.BackColor = System.Drawing.Color.Transparent
        Me.lblexpense.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexpense.ForeColor = System.Drawing.Color.Lime
        Me.lblexpense.Location = New System.Drawing.Point(31, 19)
        Me.lblexpense.Name = "lblexpense"
        Me.lblexpense.Size = New System.Drawing.Size(428, 40)
        Me.lblexpense.TabIndex = 148
        Me.lblexpense.Text = "Save Successful"
        Me.lblexpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label108
        '
        Me.Label108.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Label108.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label108.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label108.ForeColor = System.Drawing.Color.White
        Me.Label108.Location = New System.Drawing.Point(0, 0)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(1529, 29)
        Me.Label108.TabIndex = 230
        Me.Label108.Text = "Expenses"
        Me.Label108.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(-78, 190)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(542, 616)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 307
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 0
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(1259, 280)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(542, 650)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 307
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 0
        '
        'applicants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1801, 739)
        Me.Controls.Add(Me.BunifuImageButton2)
        Me.Controls.Add(Me.BunifuImageButton3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BunifuCards28)
        Me.Name = "applicants"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "applicants"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards28.ResumeLayout(False)
        Me.BunifuCards28.PerformLayout()
        Me.popalertexpense.ResumeLayout(False)
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtfullname As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtid As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtage As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtRegion As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtdistrict As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcontact As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtposition As ComboBox
    Friend WithEvents Label101 As Label
    Friend WithEvents BunifuCards28 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnexpenseaprove As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents popalertexpense As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Panel10 As Panel
    Friend WithEvents lblexpense As Label
    Friend WithEvents Label108 As Label
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.pnldisable = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnlogin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtpassword = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtusername = New MaterialSkin.Controls.MaterialTextBox()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tmmrq = New System.Windows.Forms.Timer(Me.components)
        Me.tmpoacity = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.my_animate = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.tmpop = New System.Windows.Forms.Timer(Me.components)
        Me.logout = New System.Windows.Forms.Timer(Me.components)
        Me.tmcountdown = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuCards1.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCards1
        '
        Me.BunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 10
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.SystemColors.HotTrack
        Me.BunifuCards1.Controls.Add(Me.pnldisable)
        Me.BunifuCards1.Controls.Add(Me.btnlogin)
        Me.BunifuCards1.Controls.Add(Me.Label1)
        Me.BunifuCards1.Controls.Add(Me.Label2)
        Me.BunifuCards1.Controls.Add(Me.Panel4)
        Me.BunifuCards1.Controls.Add(Me.Panel5)
        Me.BunifuCards1.Controls.Add(Me.Panel1)
        Me.BunifuCards1.Controls.Add(Me.Panel2)
        Me.BunifuCards1.Controls.Add(Me.Label5)
        Me.BunifuCards1.Controls.Add(Me.BunifuThinButton21)
        Me.BunifuCards1.Controls.Add(Me.txtpassword)
        Me.BunifuCards1.Controls.Add(Me.txtusername)
        Me.BunifuCards1.Controls.Add(Me.BunifuImageButton1)
        Me.my_animate.SetDecoration(Me.BunifuCards1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCards1.LeftSahddow = True
        Me.BunifuCards1.Location = New System.Drawing.Point(668, 108)
        Me.BunifuCards1.Margin = New System.Windows.Forms.Padding(2)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 50
        Me.BunifuCards1.Size = New System.Drawing.Size(394, 757)
        Me.BunifuCards1.TabIndex = 177
        '
        'pnldisable
        '
        Me.pnldisable.Activecolor = System.Drawing.Color.White
        Me.pnldisable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnldisable.BackColor = System.Drawing.Color.White
        Me.pnldisable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnldisable.BorderRadius = 5
        Me.pnldisable.ButtonText = "Login Successful"
        Me.pnldisable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.my_animate.SetDecoration(Me.pnldisable, BunifuAnimatorNS.DecorationType.None)
        Me.pnldisable.DisabledColor = System.Drawing.Color.Gray
        Me.pnldisable.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnldisable.Iconcolor = System.Drawing.Color.Transparent
        Me.pnldisable.Iconimage = Nothing
        Me.pnldisable.Iconimage_right = Nothing
        Me.pnldisable.Iconimage_right_Selected = Nothing
        Me.pnldisable.Iconimage_Selected = Nothing
        Me.pnldisable.IconMarginLeft = 0
        Me.pnldisable.IconMarginRight = 0
        Me.pnldisable.IconRightVisible = False
        Me.pnldisable.IconRightZoom = 0R
        Me.pnldisable.IconVisible = False
        Me.pnldisable.IconZoom = 90.0R
        Me.pnldisable.IsTab = False
        Me.pnldisable.Location = New System.Drawing.Point(31, 468)
        Me.pnldisable.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.pnldisable.Name = "pnldisable"
        Me.pnldisable.Normalcolor = System.Drawing.Color.White
        Me.pnldisable.OnHovercolor = System.Drawing.Color.White
        Me.pnldisable.OnHoverTextColor = System.Drawing.Color.Gray
        Me.pnldisable.selected = False
        Me.pnldisable.Size = New System.Drawing.Size(333, 46)
        Me.pnldisable.TabIndex = 180
        Me.pnldisable.Text = "Login Successful"
        Me.pnldisable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.pnldisable.Textcolor = System.Drawing.Color.Lime
        Me.pnldisable.TextFont = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnldisable.Visible = False
        '
        'btnlogin
        '
        Me.btnlogin.ActiveBorderThickness = 1
        Me.btnlogin.ActiveCornerRadius = 10
        Me.btnlogin.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.btnlogin.ActiveForecolor = System.Drawing.Color.White
        Me.btnlogin.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.btnlogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnlogin.BackColor = System.Drawing.Color.White
        Me.btnlogin.BackgroundImage = CType(resources.GetObject("btnlogin.BackgroundImage"), System.Drawing.Image)
        Me.btnlogin.ButtonText = "Login"
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.my_animate.SetDecoration(Me.btnlogin, BunifuAnimatorNS.DecorationType.None)
        Me.btnlogin.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.White
        Me.btnlogin.IdleBorderThickness = 1
        Me.btnlogin.IdleCornerRadius = 10
        Me.btnlogin.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btnlogin.IdleForecolor = System.Drawing.Color.White
        Me.btnlogin.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btnlogin.Location = New System.Drawing.Point(27, 414)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(6)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(334, 59)
        Me.btnlogin.TabIndex = 230
        Me.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.my_animate.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 571)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 28)
        Me.Label1.TabIndex = 157
        Me.Label1.Text = "Best software for your business"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.my_animate.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Impact", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 143)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(390, 60)
        Me.Label2.TabIndex = 156
        Me.Label2.Text = "Login"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.my_animate.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.Panel4.Location = New System.Drawing.Point(15, 313)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(8, 20)
        Me.Panel4.TabIndex = 155
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.my_animate.SetDecoration(Me.Panel5, BunifuAnimatorNS.DecorationType.None)
        Me.Panel5.Location = New System.Drawing.Point(364, 313)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(8, 20)
        Me.Panel5.TabIndex = 154
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.my_animate.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(16, 254)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(8, 20)
        Me.Panel1.TabIndex = 153
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.my_animate.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(365, 254)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(8, 20)
        Me.Panel2.TabIndex = 152
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.my_animate.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-7, 620)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(394, 28)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Powered By CaterStudio"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BunifuThinButton21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Forget Password"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.my_animate.SetDecoration(Me.BunifuThinButton21, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(80, 516)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(235, 44)
        Me.BunifuThinButton21.TabIndex = 150
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtpassword
        '
        Me.txtpassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.my_animate.SetDecoration(Me.txtpassword, BunifuAnimatorNS.DecorationType.None)
        Me.txtpassword.Depth = 0
        Me.txtpassword.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtpassword.Hint = "Password"
        Me.txtpassword.Location = New System.Drawing.Point(27, 303)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpassword.MaxLength = 50
        Me.txtpassword.MouseState = MaterialSkin.MouseState.OUT
        Me.txtpassword.Multiline = False
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Password = True
        Me.txtpassword.Size = New System.Drawing.Size(334, 50)
        Me.txtpassword.TabIndex = 147
        Me.txtpassword.Text = ""
        '
        'txtusername
        '
        Me.txtusername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.my_animate.SetDecoration(Me.txtusername, BunifuAnimatorNS.DecorationType.None)
        Me.txtusername.Depth = 0
        Me.txtusername.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtusername.Hint = "User Name"
        Me.txtusername.Location = New System.Drawing.Point(27, 243)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtusername.MaxLength = 50
        Me.txtusername.MouseState = MaterialSkin.MouseState.OUT
        Me.txtusername.Multiline = False
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(334, 50)
        Me.txtusername.TabIndex = 146
        Me.txtusername.Text = ""
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.my_animate.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(144, 19)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(103, 121)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 145
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.my_animate.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(99, 173)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(542, 616)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 178
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.my_animate.SetDecoration(Me.BunifuImageButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(1080, 183)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(542, 616)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 179
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
        '
        'tmmrq
        '
        Me.tmmrq.Interval = 10
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'my_animate
        '
        Me.my_animate.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.my_animate.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.my_animate.DefaultAnimation = Animation2
        '
        'tmpop
        '
        '
        'logout
        '
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1678, 960)
        Me.Controls.Add(Me.BunifuImageButton3)
        Me.Controls.Add(Me.BunifuImageButton2)
        Me.Controls.Add(Me.BunifuCards1)
        Me.my_animate.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Login"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BunifuCards1.ResumeLayout(False)
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnlogin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtpassword As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtusername As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents tmmrq As Timer
    Friend WithEvents tmpoacity As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents my_animate As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents tmpop As Timer
    Friend WithEvents logout As Timer
    Friend WithEvents tmcountdown As Timer
    Friend WithEvents pnldisable As Bunifu.Framework.UI.BunifuFlatButton
End Class

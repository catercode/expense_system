<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class expensedata
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(expensedata))
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.BunifuCards27 = New Bunifu.Framework.UI.BunifuCards()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuCards28 = New Bunifu.Framework.UI.BunifuCards()
        Me.txtexpenseendorse = New System.Windows.Forms.ComboBox()
        Me.txtexpensename = New System.Windows.Forms.ComboBox()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnexpenseaprove = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.dpkexpensedate = New System.Windows.Forms.DateTimePicker()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.txtexpenseamount = New System.Windows.Forms.TextBox()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.txtexpensedescription = New System.Windows.Forms.TextBox()
        Me.popalertexpense = New Bunifu.Framework.UI.BunifuCards()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.lblexpense = New System.Windows.Forms.Label()
        Me.expenseimage = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.animate_onlysales = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.systemTime = New System.Windows.Forms.Timer(Me.components)
        Me.my_animate = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.tmpop = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuCards27.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards28.SuspendLayout()
        Me.popalertexpense.SuspendLayout()
        CType(Me.expenseimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCards27
        '
        Me.BunifuCards27.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCards27.BackColor = System.Drawing.Color.White
        Me.BunifuCards27.BorderRadius = 5
        Me.BunifuCards27.BottomSahddow = False
        Me.BunifuCards27.color = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BunifuCards27.Controls.Add(Me.PictureBox2)
        Me.BunifuCards27.Controls.Add(Me.BunifuCards28)
        Me.BunifuCards27.Controls.Add(Me.PictureBox1)
        Me.my_animate.SetDecoration(Me.BunifuCards27, BunifuAnimatorNS.DecorationType.None)
        Me.animate_onlysales.SetDecoration(Me.BunifuCards27, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCards27.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCards27.LeftSahddow = False
        Me.BunifuCards27.Location = New System.Drawing.Point(0, 0)
        Me.BunifuCards27.Name = "BunifuCards27"
        Me.BunifuCards27.RightSahddow = False
        Me.BunifuCards27.ShadowDepth = 20
        Me.BunifuCards27.Size = New System.Drawing.Size(1819, 911)
        Me.BunifuCards27.TabIndex = 183
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.animate_onlysales.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.my_animate.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(694, 37)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(359, 101)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 252
        Me.PictureBox2.TabStop = False
        '
        'BunifuCards28
        '
        Me.BunifuCards28.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCards28.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuCards28.BorderRadius = 5
        Me.BunifuCards28.BottomSahddow = False
        Me.BunifuCards28.color = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BunifuCards28.Controls.Add(Me.txtexpenseendorse)
        Me.BunifuCards28.Controls.Add(Me.txtexpensename)
        Me.BunifuCards28.Controls.Add(Me.BunifuThinButton21)
        Me.BunifuCards28.Controls.Add(Me.btnexpenseaprove)
        Me.BunifuCards28.Controls.Add(Me.Label100)
        Me.BunifuCards28.Controls.Add(Me.dpkexpensedate)
        Me.BunifuCards28.Controls.Add(Me.Label98)
        Me.BunifuCards28.Controls.Add(Me.txtexpenseamount)
        Me.BunifuCards28.Controls.Add(Me.Label99)
        Me.BunifuCards28.Controls.Add(Me.Label101)
        Me.BunifuCards28.Controls.Add(Me.txtexpensedescription)
        Me.BunifuCards28.Controls.Add(Me.popalertexpense)
        Me.BunifuCards28.Controls.Add(Me.BunifuImageButton2)
        Me.BunifuCards28.Controls.Add(Me.Label95)
        Me.BunifuCards28.Controls.Add(Me.Label108)
        Me.my_animate.SetDecoration(Me.BunifuCards28, BunifuAnimatorNS.DecorationType.None)
        Me.animate_onlysales.SetDecoration(Me.BunifuCards28, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCards28.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCards28.LeftSahddow = False
        Me.BunifuCards28.Location = New System.Drawing.Point(146, 179)
        Me.BunifuCards28.Name = "BunifuCards28"
        Me.BunifuCards28.RightSahddow = False
        Me.BunifuCards28.ShadowDepth = 20
        Me.BunifuCards28.Size = New System.Drawing.Size(1529, 659)
        Me.BunifuCards28.TabIndex = 180
        '
        'txtexpenseendorse
        '
        Me.my_animate.SetDecoration(Me.txtexpenseendorse, BunifuAnimatorNS.DecorationType.None)
        Me.animate_onlysales.SetDecoration(Me.txtexpenseendorse, BunifuAnimatorNS.DecorationType.None)
        Me.txtexpenseendorse.FormattingEnabled = True
        Me.txtexpenseendorse.Items.AddRange(New Object() {"Myself", "HoIT", "Mr Imoro", "Mr Rahim", "Sec"})
        Me.txtexpenseendorse.Location = New System.Drawing.Point(91, 539)
        Me.txtexpenseendorse.Name = "txtexpenseendorse"
        Me.txtexpenseendorse.Size = New System.Drawing.Size(213, 31)
        Me.txtexpenseendorse.TabIndex = 251
        '
        'txtexpensename
        '
        Me.my_animate.SetDecoration(Me.txtexpensename, BunifuAnimatorNS.DecorationType.None)
        Me.animate_onlysales.SetDecoration(Me.txtexpensename, BunifuAnimatorNS.DecorationType.None)
        Me.txtexpensename.FormattingEnabled = True
        Me.txtexpensename.Items.AddRange(New Object() {"Myself", "Mr Malik", "Mr Imoro", "Mr Rahim", "Miss Fali"})
        Me.txtexpensename.Location = New System.Drawing.Point(91, 100)
        Me.txtexpensename.Name = "txtexpensename"
        Me.txtexpensename.Size = New System.Drawing.Size(168, 31)
        Me.txtexpensename.TabIndex = 250
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BunifuThinButton21.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BunifuThinButton21.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "View Expense"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.my_animate.SetDecoration(Me.BunifuThinButton21, BunifuAnimatorNS.DecorationType.None)
        Me.animate_onlysales.SetDecoration(Me.BunifuThinButton21, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(584, 579)
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
        Me.btnexpenseaprove.BackColor = System.Drawing.SystemColors.Control
        Me.btnexpenseaprove.BackgroundImage = CType(resources.GetObject("btnexpenseaprove.BackgroundImage"), System.Drawing.Image)
        Me.btnexpenseaprove.ButtonText = "Approve Payment"
        Me.btnexpenseaprove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.my_animate.SetDecoration(Me.btnexpenseaprove, BunifuAnimatorNS.DecorationType.None)
        Me.animate_onlysales.SetDecoration(Me.btnexpenseaprove, BunifuAnimatorNS.DecorationType.None)
        Me.btnexpenseaprove.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexpenseaprove.ForeColor = System.Drawing.Color.White
        Me.btnexpenseaprove.IdleBorderThickness = 1
        Me.btnexpenseaprove.IdleCornerRadius = 20
        Me.btnexpenseaprove.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btnexpenseaprove.IdleForecolor = System.Drawing.Color.White
        Me.btnexpenseaprove.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btnexpenseaprove.Location = New System.Drawing.Point(330, 572)
        Me.btnexpenseaprove.Margin = New System.Windows.Forms.Padding(6)
        Me.btnexpenseaprove.Name = "btnexpenseaprove"
        Me.btnexpenseaprove.Size = New System.Drawing.Size(233, 71)
        Me.btnexpenseaprove.TabIndex = 233
        Me.btnexpenseaprove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.animate_onlysales.SetDecoration(Me.Label100, BunifuAnimatorNS.DecorationType.None)
        Me.my_animate.SetDecoration(Me.Label100, BunifuAnimatorNS.DecorationType.None)
        Me.Label100.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.ForeColor = System.Drawing.Color.Black
        Me.Label100.Location = New System.Drawing.Point(86, 143)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(340, 22)
        Me.Label100.TabIndex = 246
        Me.Label100.Text = "Description of what you spend on."
        '
        'dpkexpensedate
        '
        Me.dpkexpensedate.CustomFormat = "MM/dd/yyyy"
        Me.animate_onlysales.SetDecoration(Me.dpkexpensedate, BunifuAnimatorNS.DecorationType.None)
        Me.my_animate.SetDecoration(Me.dpkexpensedate, BunifuAnimatorNS.DecorationType.None)
        Me.dpkexpensedate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpkexpensedate.Location = New System.Drawing.Point(451, 100)
        Me.dpkexpensedate.Name = "dpkexpensedate"
        Me.dpkexpensedate.Size = New System.Drawing.Size(158, 31)
        Me.dpkexpensedate.TabIndex = 241
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.animate_onlysales.SetDecoration(Me.Label98, BunifuAnimatorNS.DecorationType.None)
        Me.my_animate.SetDecoration(Me.Label98, BunifuAnimatorNS.DecorationType.None)
        Me.Label98.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.ForeColor = System.Drawing.Color.Black
        Me.Label98.Location = New System.Drawing.Point(454, 75)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(50, 22)
        Me.Label98.TabIndex = 240
        Me.Label98.Text = "Date"
        '
        'txtexpenseamount
        '
        Me.txtexpenseamount.BackColor = System.Drawing.Color.White
        Me.txtexpenseamount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.animate_onlysales.SetDecoration(Me.txtexpenseamount, BunifuAnimatorNS.DecorationType.None)
        Me.my_animate.SetDecoration(Me.txtexpenseamount, BunifuAnimatorNS.DecorationType.None)
        Me.txtexpenseamount.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexpenseamount.ForeColor = System.Drawing.Color.Black
        Me.txtexpenseamount.Location = New System.Drawing.Point(265, 101)
        Me.txtexpenseamount.Multiline = True
        Me.txtexpenseamount.Name = "txtexpenseamount"
        Me.txtexpenseamount.Size = New System.Drawing.Size(174, 30)
        Me.txtexpenseamount.TabIndex = 238
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.animate_onlysales.SetDecoration(Me.Label99, BunifuAnimatorNS.DecorationType.None)
        Me.my_animate.SetDecoration(Me.Label99, BunifuAnimatorNS.DecorationType.None)
        Me.Label99.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.ForeColor = System.Drawing.Color.Black
        Me.Label99.Location = New System.Drawing.Point(266, 75)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(130, 22)
        Me.Label99.TabIndex = 239
        Me.Label99.Text = "Amount Spent"
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.animate_onlysales.SetDecoration(Me.Label101, BunifuAnimatorNS.DecorationType.None)
        Me.my_animate.SetDecoration(Me.Label101, BunifuAnimatorNS.DecorationType.None)
        Me.Label101.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.ForeColor = System.Drawing.Color.Black
        Me.Label101.Location = New System.Drawing.Point(86, 75)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(50, 22)
        Me.Label101.TabIndex = 235
        Me.Label101.Text = "Auth"
        '
        'txtexpensedescription
        '
        Me.txtexpensedescription.BackColor = System.Drawing.Color.White
        Me.txtexpensedescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.animate_onlysales.SetDecoration(Me.txtexpensedescription, BunifuAnimatorNS.DecorationType.None)
        Me.my_animate.SetDecoration(Me.txtexpensedescription, BunifuAnimatorNS.DecorationType.None)
        Me.txtexpensedescription.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexpensedescription.ForeColor = System.Drawing.Color.Black
        Me.txtexpensedescription.Location = New System.Drawing.Point(90, 168)
        Me.txtexpensedescription.Multiline = True
        Me.txtexpensedescription.Name = "txtexpensedescription"
        Me.txtexpensedescription.Size = New System.Drawing.Size(957, 336)
        Me.txtexpensedescription.TabIndex = 247
        '
        'popalertexpense
        '
        Me.popalertexpense.BackColor = System.Drawing.SystemColors.Control
        Me.popalertexpense.BorderRadius = 5
        Me.popalertexpense.BottomSahddow = False
        Me.popalertexpense.color = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.popalertexpense.Controls.Add(Me.Panel10)
        Me.popalertexpense.Controls.Add(Me.lblexpense)
        Me.popalertexpense.Controls.Add(Me.expenseimage)
        Me.my_animate.SetDecoration(Me.popalertexpense, BunifuAnimatorNS.DecorationType.None)
        Me.animate_onlysales.SetDecoration(Me.popalertexpense, BunifuAnimatorNS.DecorationType.None)
        Me.popalertexpense.LeftSahddow = False
        Me.popalertexpense.Location = New System.Drawing.Point(289, 211)
        Me.popalertexpense.Name = "popalertexpense"
        Me.popalertexpense.RightSahddow = False
        Me.popalertexpense.ShadowDepth = 20
        Me.popalertexpense.Size = New System.Drawing.Size(586, 246)
        Me.popalertexpense.TabIndex = 248
        Me.popalertexpense.Visible = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.my_animate.SetDecoration(Me.Panel10, BunifuAnimatorNS.DecorationType.None)
        Me.animate_onlysales.SetDecoration(Me.Panel10, BunifuAnimatorNS.DecorationType.None)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(0, 241)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(586, 5)
        Me.Panel10.TabIndex = 149
        '
        'lblexpense
        '
        Me.lblexpense.BackColor = System.Drawing.Color.Transparent
        Me.animate_onlysales.SetDecoration(Me.lblexpense, BunifuAnimatorNS.DecorationType.None)
        Me.my_animate.SetDecoration(Me.lblexpense, BunifuAnimatorNS.DecorationType.None)
        Me.lblexpense.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexpense.ForeColor = System.Drawing.Color.Lime
        Me.lblexpense.Location = New System.Drawing.Point(3, 48)
        Me.lblexpense.Name = "lblexpense"
        Me.lblexpense.Size = New System.Drawing.Size(598, 40)
        Me.lblexpense.TabIndex = 148
        Me.lblexpense.Text = "Save Successful"
        Me.lblexpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'expenseimage
        '
        Me.expenseimage.BackColor = System.Drawing.Color.Transparent
        Me.my_animate.SetDecoration(Me.expenseimage, BunifuAnimatorNS.DecorationType.None)
        Me.animate_onlysales.SetDecoration(Me.expenseimage, BunifuAnimatorNS.DecorationType.None)
        Me.expenseimage.Image = CType(resources.GetObject("expenseimage.Image"), System.Drawing.Image)
        Me.expenseimage.ImageActive = Nothing
        Me.expenseimage.Location = New System.Drawing.Point(259, 142)
        Me.expenseimage.Name = "expenseimage"
        Me.expenseimage.Size = New System.Drawing.Size(71, 71)
        Me.expenseimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.expenseimage.TabIndex = 1
        Me.expenseimage.TabStop = False
        Me.expenseimage.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.my_animate.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.animate_onlysales.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(987, 45)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(542, 616)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 245
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.animate_onlysales.SetDecoration(Me.Label95, BunifuAnimatorNS.DecorationType.None)
        Me.my_animate.SetDecoration(Me.Label95, BunifuAnimatorNS.DecorationType.None)
        Me.Label95.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.ForeColor = System.Drawing.Color.Black
        Me.Label95.Location = New System.Drawing.Point(87, 514)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(130, 22)
        Me.Label95.TabIndex = 243
        Me.Label95.Text = "Approved by."
        '
        'Label108
        '
        Me.Label108.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.animate_onlysales.SetDecoration(Me.Label108, BunifuAnimatorNS.DecorationType.None)
        Me.my_animate.SetDecoration(Me.Label108, BunifuAnimatorNS.DecorationType.None)
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
        'PictureBox1
        '
        Me.animate_onlysales.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.my_animate.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-80, 298)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(504, 504)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 251
        Me.PictureBox1.TabStop = False
        '
        'animate_onlysales
        '
        Me.animate_onlysales.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.animate_onlysales.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.animate_onlysales.DefaultAnimation = Animation1
        '
        'my_animate
        '
        Me.my_animate.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
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
        Me.tmpop.Interval = 500
        '
        'expensedata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1819, 911)
        Me.Controls.Add(Me.BunifuCards27)
        Me.animate_onlysales.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.my_animate.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "expensedata"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "expensedata"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BunifuCards27.ResumeLayout(False)
        Me.BunifuCards27.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards28.ResumeLayout(False)
        Me.BunifuCards28.PerformLayout()
        Me.popalertexpense.ResumeLayout(False)
        CType(Me.expenseimage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuCards27 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards28 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label95 As Label
    Friend WithEvents dpkexpensedate As DateTimePicker
    Friend WithEvents Label98 As Label
    Friend WithEvents txtexpenseamount As TextBox
    Friend WithEvents Label99 As Label
    Friend WithEvents Label101 As Label
    Friend WithEvents btnexpenseaprove As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label108 As Label
    Friend WithEvents animate_onlysales As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents systemTime As Timer
    Friend WithEvents my_animate As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents tmpop As Timer
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents popalertexpense As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Panel10 As Panel
    Friend WithEvents lblexpense As Label
    Friend WithEvents expenseimage As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtexpensedescription As TextBox
    Friend WithEvents Label100 As Label
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtexpenseendorse As ComboBox
    Friend WithEvents txtexpensename As ComboBox
End Class

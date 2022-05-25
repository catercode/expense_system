<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dailyexpense
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dailyexpense))
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.txtbudget = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnprint = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnsearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btndelete = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnrefresh = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbsearch = New System.Windows.Forms.ComboBox()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.pnldisable = New Bunifu.Framework.UI.BunifuCards()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtdisable = New System.Windows.Forms.Label()
        Me.BunifuImageButton6 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label23 = New System.Windows.Forms.Label()
        Me.systemTime = New System.Windows.Forms.Timer(Me.components)
        Me.tmgreen = New System.Windows.Forms.Timer(Me.components)
        Me.tmred = New System.Windows.Forms.Timer(Me.components)
        Me.my_animate = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tmpop = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btnback = New System.Windows.Forms.Button()
        Me.BunifuCards3.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        CType(Me.btnsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards1.SuspendLayout()
        Me.pnldisable.SuspendLayout()
        CType(Me.BunifuImageButton6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCards3
        '
        Me.BunifuCards3.AutoScroll = True
        Me.BunifuCards3.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuCards3.BorderRadius = 5
        Me.BunifuCards3.BottomSahddow = True
        Me.BunifuCards3.color = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BunifuCards3.Controls.Add(Me.txtbudget)
        Me.BunifuCards3.Controls.Add(Me.Label3)
        Me.BunifuCards3.Controls.Add(Me.lbltotal)
        Me.BunifuCards3.Controls.Add(Me.Label4)
        Me.BunifuCards3.Controls.Add(Me.Label7)
        Me.BunifuCards3.Controls.Add(Me.lbltime)
        Me.BunifuCards3.Controls.Add(Me.lbldate)
        Me.BunifuCards3.Controls.Add(Me.Label2)
        Me.BunifuCards3.Controls.Add(Me.Label1)
        Me.BunifuCards3.Controls.Add(Me.btnprint)
        Me.BunifuCards3.Controls.Add(Me.Label22)
        Me.my_animate.SetDecoration(Me.BunifuCards3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCards3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuCards3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCards3.LeftSahddow = False
        Me.BunifuCards3.Location = New System.Drawing.Point(0, 0)
        Me.BunifuCards3.Name = "BunifuCards3"
        Me.BunifuCards3.RightSahddow = True
        Me.BunifuCards3.ShadowDepth = 20
        Me.BunifuCards3.Size = New System.Drawing.Size(363, 912)
        Me.BunifuCards3.TabIndex = 187
        '
        'txtbudget
        '
        Me.txtbudget.BackColor = System.Drawing.Color.White
        Me.txtbudget.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.my_animate.SetDecoration(Me.txtbudget, BunifuAnimatorNS.DecorationType.None)
        Me.txtbudget.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbudget.ForeColor = System.Drawing.Color.Black
        Me.txtbudget.Location = New System.Drawing.Point(98, 243)
        Me.txtbudget.Multiline = True
        Me.txtbudget.Name = "txtbudget"
        Me.txtbudget.Size = New System.Drawing.Size(210, 30)
        Me.txtbudget.TabIndex = 235
        Me.txtbudget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.my_animate.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(367, 47)
        Me.Label3.TabIndex = 194
        Me.Label3.Text = "Budget"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.my_animate.SetDecoration(Me.lbltotal, BunifuAnimatorNS.DecorationType.None)
        Me.lbltotal.Font = New System.Drawing.Font("Agency FB", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(2, 115)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(364, 51)
        Me.lbltotal.TabIndex = 193
        Me.lbltotal.Text = "00"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.my_animate.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-1, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(367, 47)
        Me.Label4.TabIndex = 192
        Me.Label4.Text = "Total Data"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.my_animate.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label7.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(0, 866)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(365, 29)
        Me.Label7.TabIndex = 191
        Me.Label7.Text = "Powered By CaterCode"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltime
        '
        Me.my_animate.SetDecoration(Me.lbltime, BunifuAnimatorNS.DecorationType.None)
        Me.lbltime.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(0, 765)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(359, 52)
        Me.lbltime.TabIndex = 190
        Me.lbltime.Text = "00:00:00"
        Me.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldate
        '
        Me.my_animate.SetDecoration(Me.lbldate, BunifuAnimatorNS.DecorationType.None)
        Me.lbldate.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(4, 709)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(355, 56)
        Me.lbldate.TabIndex = 189
        Me.lbldate.Text = "05/14/2021"
        Me.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.my_animate.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 350)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(364, 51)
        Me.Label2.TabIndex = 188
        Me.Label2.Text = "GHs 0.00"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.my_animate.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 47)
        Me.Label1.TabIndex = 187
        Me.Label1.Text = "Total Amount Spent"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnprint
        '
        Me.btnprint.ActiveBorderThickness = 1
        Me.btnprint.ActiveCornerRadius = 20
        Me.btnprint.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.btnprint.ActiveForecolor = System.Drawing.Color.White
        Me.btnprint.ActiveLineColor = System.Drawing.Color.White
        Me.btnprint.BackColor = System.Drawing.SystemColors.Control
        Me.btnprint.BackgroundImage = CType(resources.GetObject("btnprint.BackgroundImage"), System.Drawing.Image)
        Me.btnprint.ButtonText = "Print"
        Me.btnprint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.my_animate.SetDecoration(Me.btnprint, BunifuAnimatorNS.DecorationType.None)
        Me.btnprint.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.ForeColor = System.Drawing.Color.Black
        Me.btnprint.IdleBorderThickness = 1
        Me.btnprint.IdleCornerRadius = 20
        Me.btnprint.IdleFillColor = System.Drawing.Color.White
        Me.btnprint.IdleForecolor = System.Drawing.Color.Black
        Me.btnprint.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.btnprint.Location = New System.Drawing.Point(32, 487)
        Me.btnprint.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(331, 61)
        Me.btnprint.TabIndex = 174
        Me.btnprint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.my_animate.SetDecoration(Me.Label22, BunifuAnimatorNS.DecorationType.None)
        Me.Label22.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(5, 8)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(354, 29)
        Me.Label22.TabIndex = 140
        Me.Label22.Text = "Expenses"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BunifuCards2.Controls.Add(Me.Label5)
        Me.BunifuCards2.Controls.Add(Me.DateTimePicker1)
        Me.BunifuCards2.Controls.Add(Me.btnsearch)
        Me.BunifuCards2.Controls.Add(Me.btndelete)
        Me.BunifuCards2.Controls.Add(Me.btnrefresh)
        Me.BunifuCards2.Controls.Add(Me.Label21)
        Me.BunifuCards2.Controls.Add(Me.cbsearch)
        Me.my_animate.SetDecoration(Me.BunifuCards2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCards2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BunifuCards2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(363, 827)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(1406, 85)
        Me.BunifuCards2.TabIndex = 189
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.my_animate.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(457, 14)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(303, 23)
        Me.Label5.TabIndex = 193
        Me.Label5.Text = "Search by Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.my_animate.SetDecoration(Me.DateTimePicker1, BunifuAnimatorNS.DecorationType.None)
        Me.DateTimePicker1.Location = New System.Drawing.Point(456, 46)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(304, 31)
        Me.DateTimePicker1.TabIndex = 192
        '
        'btnsearch
        '
        Me.btnsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsearch.BackColor = System.Drawing.Color.Transparent
        Me.my_animate.SetDecoration(Me.btnsearch, BunifuAnimatorNS.DecorationType.None)
        Me.btnsearch.Image = CType(resources.GetObject("btnsearch.Image"), System.Drawing.Image)
        Me.btnsearch.ImageActive = Nothing
        Me.btnsearch.Location = New System.Drawing.Point(1285, 15)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(90, 64)
        Me.btnsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnsearch.TabIndex = 179
        Me.btnsearch.TabStop = False
        Me.btnsearch.Zoom = 10
        '
        'btndelete
        '
        Me.btndelete.ActiveBorderThickness = 1
        Me.btndelete.ActiveCornerRadius = 20
        Me.btndelete.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.btndelete.ActiveForecolor = System.Drawing.Color.White
        Me.btndelete.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.btndelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btndelete.BackColor = System.Drawing.SystemColors.Control
        Me.btndelete.BackgroundImage = CType(resources.GetObject("btndelete.BackgroundImage"), System.Drawing.Image)
        Me.btndelete.ButtonText = "Delete"
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.my_animate.SetDecoration(Me.btndelete, BunifuAnimatorNS.DecorationType.None)
        Me.btndelete.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.IdleBorderThickness = 1
        Me.btndelete.IdleCornerRadius = 20
        Me.btndelete.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btndelete.IdleForecolor = System.Drawing.Color.White
        Me.btndelete.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btndelete.Location = New System.Drawing.Point(231, 20)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(6)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(167, 58)
        Me.btndelete.TabIndex = 176
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnrefresh
        '
        Me.btnrefresh.ActiveBorderThickness = 1
        Me.btnrefresh.ActiveCornerRadius = 20
        Me.btnrefresh.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.btnrefresh.ActiveForecolor = System.Drawing.Color.White
        Me.btnrefresh.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.btnrefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnrefresh.BackColor = System.Drawing.SystemColors.Control
        Me.btnrefresh.BackgroundImage = CType(resources.GetObject("btnrefresh.BackgroundImage"), System.Drawing.Image)
        Me.btnrefresh.ButtonText = "Refresh"
        Me.btnrefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.my_animate.SetDecoration(Me.btnrefresh, BunifuAnimatorNS.DecorationType.None)
        Me.btnrefresh.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.ForeColor = System.Drawing.Color.White
        Me.btnrefresh.IdleBorderThickness = 1
        Me.btnrefresh.IdleCornerRadius = 20
        Me.btnrefresh.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btnrefresh.IdleForecolor = System.Drawing.Color.White
        Me.btnrefresh.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btnrefresh.Location = New System.Drawing.Point(39, 20)
        Me.btnrefresh.Margin = New System.Windows.Forms.Padding(5)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(167, 58)
        Me.btnrefresh.TabIndex = 175
        Me.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.my_animate.SetDecoration(Me.Label21, BunifuAnimatorNS.DecorationType.None)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(959, 15)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(321, 23)
        Me.Label21.TabIndex = 137
        Me.Label21.Text = "Search by Name "
        '
        'cbsearch
        '
        Me.cbsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.my_animate.SetDecoration(Me.cbsearch, BunifuAnimatorNS.DecorationType.None)
        Me.cbsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbsearch.FormattingEnabled = True
        Me.cbsearch.Items.AddRange(New Object() {"*"})
        Me.cbsearch.Location = New System.Drawing.Point(959, 48)
        Me.cbsearch.Name = "cbsearch"
        Me.cbsearch.Size = New System.Drawing.Size(321, 31)
        Me.cbsearch.TabIndex = 136
        '
        'BunifuCards1
        '
        Me.BunifuCards1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCards1.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BunifuCards1.Controls.Add(Me.pnldisable)
        Me.BunifuCards1.Controls.Add(Me.ListView1)
        Me.BunifuCards1.Controls.Add(Me.Label23)
        Me.my_animate.SetDecoration(Me.BunifuCards1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCards1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(382, 146)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(1375, 667)
        Me.BunifuCards1.TabIndex = 190
        '
        'pnldisable
        '
        Me.pnldisable.BackColor = System.Drawing.SystemColors.Control
        Me.pnldisable.BorderRadius = 5
        Me.pnldisable.BottomSahddow = True
        Me.pnldisable.color = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.pnldisable.Controls.Add(Me.Panel2)
        Me.pnldisable.Controls.Add(Me.txtdisable)
        Me.pnldisable.Controls.Add(Me.BunifuImageButton6)
        Me.my_animate.SetDecoration(Me.pnldisable, BunifuAnimatorNS.DecorationType.None)
        Me.pnldisable.LeftSahddow = False
        Me.pnldisable.Location = New System.Drawing.Point(332, 144)
        Me.pnldisable.Name = "pnldisable"
        Me.pnldisable.RightSahddow = True
        Me.pnldisable.ShadowDepth = 20
        Me.pnldisable.Size = New System.Drawing.Size(586, 347)
        Me.pnldisable.TabIndex = 179
        Me.pnldisable.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.my_animate.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 342)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(586, 5)
        Me.Panel2.TabIndex = 149
        '
        'txtdisable
        '
        Me.txtdisable.BackColor = System.Drawing.Color.Transparent
        Me.my_animate.SetDecoration(Me.txtdisable, BunifuAnimatorNS.DecorationType.None)
        Me.txtdisable.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdisable.ForeColor = System.Drawing.Color.Lime
        Me.txtdisable.Location = New System.Drawing.Point(3, 74)
        Me.txtdisable.Name = "txtdisable"
        Me.txtdisable.Size = New System.Drawing.Size(598, 40)
        Me.txtdisable.TabIndex = 148
        Me.txtdisable.Text = "Save Successful"
        Me.txtdisable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuImageButton6
        '
        Me.BunifuImageButton6.BackColor = System.Drawing.Color.Transparent
        Me.my_animate.SetDecoration(Me.BunifuImageButton6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton6.Image = CType(resources.GetObject("BunifuImageButton6.Image"), System.Drawing.Image)
        Me.BunifuImageButton6.ImageActive = Nothing
        Me.BunifuImageButton6.Location = New System.Drawing.Point(259, 178)
        Me.BunifuImageButton6.Name = "BunifuImageButton6"
        Me.BunifuImageButton6.Size = New System.Drawing.Size(71, 71)
        Me.BunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton6.TabIndex = 1
        Me.BunifuImageButton6.TabStop = False
        Me.BunifuImageButton6.Zoom = 10
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.my_animate.SetDecoration(Me.ListView1, BunifuAnimatorNS.DecorationType.None)
        Me.ListView1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(3, 41)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1369, 615)
        Me.ListView1.TabIndex = 178
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Expense ID"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Amount_Spent"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 148
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "By Who"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 200
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Reason"
        Me.ColumnHeader5.Width = 600
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Approved By"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 150
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Date"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 150
        '
        'Label23
        '
        Me.Label23.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.my_animate.SetDecoration(Me.Label23, BunifuAnimatorNS.DecorationType.None)
        Me.Label23.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(3, 8)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(1369, 29)
        Me.Label23.TabIndex = 140
        Me.Label23.Text = "Expenses Data"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'systemTime
        '
        '
        'tmgreen
        '
        Me.tmgreen.Interval = 500
        '
        'tmred
        '
        Me.tmred.Interval = 500
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
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.my_animate.SetDecoration(Me.PrintPreviewDialog1, BunifuAnimatorNS.DecorationType.None)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.my_animate.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(862, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(359, 101)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 253
        Me.PictureBox2.TabStop = False
        '
        'tmpop
        '
        Me.tmpop.Interval = 1000
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnback
        '
        Me.btnback.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnback.BackColor = System.Drawing.Color.White
        Me.my_animate.SetDecoration(Me.btnback, BunifuAnimatorNS.DecorationType.None)
        Me.btnback.FlatAppearance.BorderSize = 0
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(1634, 8)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(129, 41)
        Me.btnback.TabIndex = 254
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'dailyexpense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1769, 912)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.BunifuCards2)
        Me.Controls.Add(Me.BunifuCards3)
        Me.my_animate.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Name = "dailyexpense"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dailyexpense"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BunifuCards3.ResumeLayout(False)
        Me.BunifuCards3.PerformLayout()
        Me.BunifuCards2.ResumeLayout(False)
        CType(Me.btnsearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards1.ResumeLayout(False)
        Me.pnldisable.ResumeLayout(False)
        CType(Me.BunifuImageButton6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label7 As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnprint As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label22 As Label
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnsearch As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btndelete As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnrefresh As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label21 As Label
    Friend WithEvents cbsearch As ComboBox
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents pnldisable As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtdisable As Label
    Friend WithEvents BunifuImageButton6 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Label23 As Label
    Friend WithEvents my_animate As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents systemTime As Timer
    Friend WithEvents tmgreen As Timer
    Friend WithEvents tmred As Timer
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents tmpop As Timer
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbudget As TextBox
    Friend WithEvents btnback As Button
End Class

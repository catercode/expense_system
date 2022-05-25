
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Drawing.Printing

Public Class dailyexpense
    Dim MyString As String = "Server=LocalHost;user id = root;password = '';Database =startlet ;Port=3306 "
    Dim SQLconnection As MySqlConnection = New MySqlConnection
    Dim SQLStatement As String
    Dim dr As MySqlDataReader
    Dim sda As MySqlDataAdapter
    Dim table As DataTable
    Dim delt2 As String


    Private Sub deleterecord(ByRef SQLStatement As String)
        Try
            Dim cmd As MySqlCommand = New MySqlCommand
            With cmd
                .CommandText = SQLStatement
                .CommandType = CommandType.Text
                .Connection = SQLconnection
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub expense_load_reader()
        Try
            ListView1.Items.Clear()
            Dim command As New MySqlCommand(SQLStatement, SQLconnection)
            dr = command.ExecuteReader
            While dr.Read

                Dim i As Integer
                Dim lst As New ListViewItem(i)

                lst.SubItems.Add(dr.Item("Expense_Id"))
                lst.SubItems.Add(dr.Item("Amount_Spent"))
                lst.SubItems.Add(dr.Item("By_Who"))
                lst.SubItems.Add(dr.Item("Description"))
                lst.SubItems.Add(dr.Item("Approved_By"))
                lst.SubItems.Add(dr.Item("Date"))
                ListView1.Items.Add(lst)
            End While
            dr.Close()
            multiprint()
        Catch ex As Exception
            dr.Close()
            Dim exms As String
            exms = ex.Message
            If exms = "Connection must be valid and open." Or exms = "Fatal error encountered during command execution." Or exms = "Unable to write data to the transport connection: An existing connection was forcibly closed by the remote host." Or exms = "Unable to connect to any of the specified MySQL hosts." Then
                SQLconnection.ConnectionString = MyString
                SQLconnection.Open()
            Else
                MsgBox(ex.Message)
            End If
        End Try
    End Sub

    Private Sub Stock_check()
        If My.Computer.Network.IsAvailable Then
            Try
                Dim Command = New MySqlCommand(SQLStatement, SQLconnection)
                dr = Command.ExecuteReader
                If dr.Read Then
                    dr.Close()
                Else
                End If
            Catch ex As Exception
                dr.Close()
                Dim exms As String
                exms = ex.Message
                If exms = "Connection must be valid and open." Or exms = "Fatal error encountered during command execution." Or exms = "Unable to write data to the transport connection: An existing connection was forcibly closed by the remote host." Or exms = "Unable to connect to any of the specified MySQL hosts." Then
                    SQLconnection.ConnectionString = MyString
                    SQLconnection.Open()
                Else
                    MsgBox(ex.Message)
                End If
            End Try
        End If
    End Sub
    Private Sub systemTime_Tick(sender As Object, e As EventArgs) Handles systemTime.Tick
        lbldate.Text = System.DateTime.Now.ToString("MM/dd/yyyy ")
        lbltime.Text = Date.Now.ToString("hh : mm : ss")
    End Sub


    Private Sub ExpenseID()
        If My.Settings.checkinternet = True Then
            If My.Computer.Network.IsAvailable Then

            Else

                netmsg = MsgBox("Please check your connections!", vbOK, "Internet connection")
                If netmsg = vbOKOnly Then

                End If
                Exit Sub
            End If
        End If

        Try

            SQLStatement = " SELECT* FROM expense"
            Dim Command = New MySqlCommand(SQLStatement, SQLconnection)
            dr = Command.ExecuteReader

            While dr.Read
                cbsearch.Items.Add(dr.Item("By_Who"))
                cbsearch.AutoCompleteCustomSource.Add(dr.Item("By_Who"))
            End While
            dr.Close()
        Catch ex As Exception
            Dim exms As String
            exms = ex.Message
            If exms = "Connection must be valid and open." Or exms = "Fatal error encountered during command execution." Or exms = "Unable to write data to the transport connection: An existing connection was forcibly closed by the remote host." Or exms = "Unable to connect to any of the specified MySQL hosts." Then
                SQLconnection.ConnectionString = MyString
                SQLconnection.Open()
            Else
                MsgBox(ex.Message)
            End If



        End Try
    End Sub

    Private Sub tmred_Tick(sender As Object, e As EventArgs) Handles tmred.Tick

    End Sub

    Private Sub tmgreen_Tick(sender As Object, e As EventArgs) Handles tmgreen.Tick

    End Sub

    Private Sub myalert()
        'pnldisable.Top = 36
        'pnldisable.Left = 536
        pnldisable.BringToFront()
        my_animate.AnimationType = BunifuAnimatorNS.AnimationType.Transparent
        my_animate.ShowSync(pnldisable)

        tmpop.Interval = 1000
        tmpop.Start()
    End Sub

    Dim netmsg As String
    Dim xdelete As Integer
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click


        Try
            SQLStatement = "DELETE FROM expense WHERE Expense_Id = '" & ListView1.SelectedItems(0).SubItems(1).Text & "'"
            deleterecord(SQLStatement)
            ListView1.Items.RemoveAt(xdelete)
            txtdisable.Text = "Expense data delete successful"
            txtdisable.ForeColor = Color.Green

            lbltotal.Text = ListView1.Items.Count
            myalert()



        Catch ex As Exception
            Dim exms As String
            exms = ex.Message
            If exms = "Connection must be valid and open." Or exms = "Fatal error encountered during command execution." Or exms = "Unable to write data to the transport connection: An existing connection was forcibly closed by the remote host." Or exms = "Unable to connect to any of the specified MySQL hosts." Then
                SQLconnection.ConnectionString = MyString
                SQLconnection.Open()
            Else
                MsgBox(ex.Message)
            End If

        End Try

    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click

        SQLStatement = "SELECT * FROM expense "
        expense_load_reader()
        txtdisable.Text = "Please wait while data load..."
        txtdisable.ForeColor = Color.Green

        ExpenseID()
        Label2.Text = "GHs " & totalspent() & ".00"
        lbltotal.Text = ListView1.Items.Count
        myalert()

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click

    End Sub

    Private Sub dailyexpense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQLconnection.ConnectionString = MyString
        SQLconnection.Open()
        If ConnectionState.Closed Then
            MsgBox("Server is not running")
        Else




            SQLStatement = "SELECT * FROM Expense "
            expense_load_reader()
            ExpenseID()
            Label2.Text = "GHs " & totalspent() & ".00"
            lbltotal.Text = ListView1.Items.Count
            systemTime.Start()
        End If


    End Sub
    Public Function totalspent() As Double

        Dim i, j As Integer
        Dim k As Double
        i = 0
        j = 0
        k = 0
        Try
            j = ListView1.Items.Count
            For i = 0 To j - 1
                k = k + (ListView1.Items(i).SubItems(2).Text)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Return k

    End Function

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub tmpop_Tick(sender As Object, e As EventArgs) Handles tmpop.Tick

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        xdelete = ListView1.FocusedItem.Index
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        On Error Resume Next
        compute()
        Dim pr As Integer = 0
        myincrement += 1

        If myincrement = 1 Then
            pr = 50
            e.Graphics.DrawString(vbTab & vbTab & vbTab & "SOCCER TALENT HUNT", New Drawing.Font("Berlin Sans FB Demi", 14), Brushes.Black, 50, pr)
            pr += 20
            e.Graphics.DrawString(vbTab & vbTab & vbTab & vbTab & vbTab & "Living The Dream" & My.Settings.myloca & "", New Drawing.Font("Consolas", 10), Brushes.Black, 50, pr)
            pr += 16
            e.Graphics.DrawString(vbTab & vbTab & vbTab & vbTab & vbTab & " Daily Expenses " & My.Settings.myaddres & "", New Drawing.Font("Consolas", 10), Brushes.Black, 50, pr)
            pr += 16

            e.Graphics.DrawString("_________________________________________________________________________________________________________________________________________________________________________________", New Drawing.Font("Berlin Sans FB Demi", 9), Brushes.Black, 10, pr)
            pr += 20

            pr += 30
            e.Graphics.DrawString("   Expense Id" & "            Amount" & "             By Whom" & "                    Reason" & "                                                        Approve By" & "               Date", New Drawing.Font("Berlin Sans FB Demi", 10), Brushes.Black, 0, pr)
            pr += 30

            End If

        For Me.i_counter = i_start To ListView1.Items.Count - 1

            e.Graphics.DrawString(ListView1.Items(i_counter).SubItems(1).Text, New Drawing.Font("Consolas", 10), Brushes.Black, 20, pr)
            e.Graphics.DrawString(ListView1.Items(i_counter).SubItems(2).Text, New Drawing.Font("Consolas", 10), Brushes.Black, 120, pr)
            e.Graphics.DrawString(ListView1.Items(i_counter).SubItems(3).Text, New Drawing.Font("Consolas", 10), Brushes.Black, 210, pr)
            e.Graphics.DrawString(ListView1.Items(i_counter).SubItems(4).Text, New Drawing.Font("Consolas", 10), Brushes.Black, 320, pr)
            e.Graphics.DrawString(ListView1.Items(i_counter).SubItems(5).Text, New Drawing.Font("Consolas", 10), Brushes.Black, 600, pr)
            e.Graphics.DrawString(ListView1.Items(i_counter).SubItems(6).Text, New Drawing.Font("Consolas", 10), Brushes.Black, 700, pr)
            'e.Graphics.DrawString(ListView1.Items(i_counter).SubItems(7).Text, New Drawing.Font("Consolas", 10), Brushes.Black, 700, pr)

            pr += 18
            linenumber += 1
            '  MsgBox(linenumber & "ok")
            If linenumber = lineperpage Then
                linenumber = 0
                i_start = i_counter + 1
                pr = 50
                e.HasMorePages = True
                Exit For
                'Else
                '    MsgBox(linenumber)
            End If
        Next
        '   MsgBox(mydecrease)
        mydecrease = mydecrease - 1
        'MsgBox(mydecrease)
        If mydecrease = 0 Then
            e.Graphics.DrawString("_________________________________________________________________________", New Drawing.Font("Berlin Sans FB Demi", 9), Brushes.Black, 150, pr)
            pr += 13
            e.Graphics.DrawString("Total Spent" & vbTab & vbTab & "Budget" & vbTab & vbTab & "Balance", New Drawing.Font("Berlin Sans FB Demi", 12), Brushes.Black, 150, pr)
            pr += 20
            e.Graphics.DrawString(subtot() & vbTab & vbTab & "       " & myBudget & vbTab & vbTab & " " & myBalance, New Drawing.Font("Consolas", 11), Brushes.Black, 195, pr)
            pr += 18
            e.Graphics.DrawString("_________________________________________________________________________________________________________________________________________________________________________________", New Drawing.Font("Berlin Sans FB Demi", 9), Brushes.Black, 10, pr)
            pr += 18
            e.Graphics.DrawString(vbTab & vbTab & vbTab & vbTab & "   Expense System Powered By CaterCode", New Drawing.Font("Consolas", 11), Brushes.Black, 50, pr)

        End If
    End Sub

    Dim myBudget, myBalance As Double
    Private Sub compute()
        myBudget = txtbudget.Text
        myBalance = txtbudget.Text - subtot()
    End Sub
    Public Function subtot() As Double

        Dim i, j As Integer
        Dim k As Double
        i = 0
        j = 0
        k = 0
        Try
            j = ListView1.Items.Count
            For i = 0 To j - 1
                k = k + (ListView1.Items(i).SubItems(2).Text)
            Next
        Catch ex As Exception


        End Try
        Return k

    End Function
    Dim linenumber As Integer
    Dim lineperpage As Integer
    Dim i_start As Integer
    Dim i_counter As Integer
    Dim wholenumber As Double '
    Dim remainnumber As Integer '
    Dim sss As Integer
    Dim myincrement As Integer
    Dim mydecrease As Integer
    Dim mylistcount As Integer

    Private Sub multiprint()
        lineperpage = 40
        mylistcount = ListView1.Items.Count

        wholenumber = mylistcount / lineperpage
        If wholenumber <= 1.9 Then
            wholenumber = 1
        Else
            wholenumber += 1
        End If

        If mylistcount > lineperpage Then
            ''  lineperpage += 1


            mydecrease = wholenumber

        Else
            lineperpage += 1
            mydecrease = wholenumber
            'MsgBox(remainnumber & "1")


        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        SQLStatement = "SELECT * FROM expense WHERE Date ='" & DateTimePicker1.Value.ToString("MM/dd/yyyy") & "' "
        expense_load_reader()
        txtdisable.Text = "Please wait while data load..."
        txtdisable.ForeColor = Color.Green


        If ListView1.Items.Count = 0 Then
            txtdisable.Text = "No data found for the search..!"
            lbltotal.Text = ListView1.Items.Count
            Label2.Text = "GHs " & totalspent() & ".00"
            txtdisable.ForeColor = Color.Red

            myalert()
        Else
            myalert()

        End If


    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click

        On Error Resume Next
        'linenumber = 0
        'lineperpage = 0
        'i_start = 0
        'i_counter = 0
        'wholenumber = 0
        'remainnumber = 0
        'sss = 0
        'myincrement = 0
        'mydecrease = 1
        'mylistcount = 0

        Me.TopMost = False
        If ListView1.Items.Count = 0 Then
            txtdisable.Text = "There is no data to print!"
            txtdisable.ForeColor = Color.Red

            myalert()
            Exit Sub
        End If

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        'On Error Resume Next
        'PrintDialog1.Document = PrintDocument1
        'If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings

        '    Dim New_Paper As New PaperSize("", 800, 800)
        '    New_Paper.PaperName = PaperKind.Custom
        '    Dim New_Margin As New Margins
        '    New_Margin.Left = 0
        '    New_Margin.Top = 50

        '    With PrintDocument1
        '        .DefaultPageSettings.PaperSize = New_Paper
        '        .DefaultPageSettings.Margins = New_Margin
        '        .PrinterSettings.DefaultPageSettings.Landscape = False
        '        .Print()
        '    End With
        '    PrintPreviewDialog1.Document = PrintDocument1
        '    PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        '    PrintPreviewDialog1.ShowDialog()
        'End If

    End Sub

    Private Sub cbsearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsearch.SelectedIndexChanged



    End Sub

    Private Sub btnprint_Move(sender As Object, e As EventArgs) Handles btnprint.Move

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles btnback.Click
        expensedata.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuCards3_Paint(sender As Object, e As PaintEventArgs) Handles BunifuCards3.Paint

    End Sub

    Private Sub cbsearch_TextChanged(sender As Object, e As EventArgs) Handles cbsearch.TextChanged
        SQLStatement = "SELECT * FROM expense WHERE By_Who LIKE'" & cbsearch.Text & "%'"
        expense_load_reader()

        If ListView1.Items.Count = 0 Then
            txtdisable.Text = "No data found for the search..!"
            lbltotal.Text = ListView1.Items.Count
            Label2.Text = "GHs " & totalspent() & ".00"
            txtdisable.ForeColor = Color.Red

            myalert()

        End If
        myalert()
    End Sub
End Class
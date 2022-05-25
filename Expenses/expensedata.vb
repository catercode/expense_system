Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Drawing.Printing
Public Class expensedata
    Dim dt As Date
    Dim days As Integer
    Dim MyString As String = "Server=LocalHost;user id = root;password = '';Database =startlet ;Port=3306 "
    Dim SQLconnection As MySqlConnection = New MySqlConnection

    Dim SQLStatement As String
    Dim dr As MySqlDataReader
    Dim sda As MySqlDataAdapter
    Dim table As DataTable
    Dim command As MySqlCommand

    Dim mult As Double
    Dim lblproremainout As Integer
    Dim st, qty As Integer
    Dim c, cx As Integer
    Dim pn As String

    Dim pt As String
    Dim q As Integer
    Dim pri, bulk As Integer

    Dim D, T, Type, Type2, qanti As String


    Private Sub BunifuCards28_Paint(sender As Object, e As PaintEventArgs) Handles BunifuCards28.Paint

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub tmpop_Tick(sender As Object, e As EventArgs) Handles tmpop.Tick
        my_animate.HideSync(popalertexpense)
        tmpop.Stop()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        dailyexpense.Show()
        Me.Hide()
    End Sub

    Dim x As Integer = 0



    Private Sub expensedata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQLconnection.ConnectionString = MyString
        SQLconnection.Open()

        If SQLconnection.State = ConnectionState.Closed Then
            MsgBox("Server is not running")
        Else


        End If


    End Sub


    Private Sub btnexpenseaprove_Click(sender As Object, e As EventArgs) Handles btnexpenseaprove.Click
        postData()
    End Sub

    Private Async Function postData() As Task


        Try
            If txtexpensename.Text = "" Then

                lblexpense.Text = "Please field must filled"

                lblexpense.ForeColor = Color.Red
                msgboxalertexpense()
                Exit Function
            ElseIf txtexpenseamount.Text = "" Then
                lblexpense.Text = "Please field must filled"

                lblexpense.ForeColor = Color.Red
                msgboxalertexpense()
                Exit Function
            ElseIf txtexpensedescription.Text = "" Then
                lblexpense.Text = "Please field must filled"

                lblexpense.ForeColor = Color.Red
                msgboxalertexpense()
                Exit Function
            ElseIf txtexpenseendorse.Text = "" Then
                lblexpense.Text = "Please field must filled"

                lblexpense.ForeColor = Color.Red
                msgboxalertexpense()
                Exit Function
            ElseIf dpkexpensedate.Text = "" Then
                lblexpense.Text = "Please field must filled"

                lblexpense.ForeColor = Color.Red
                msgboxalertexpense()
                Exit Function
            Else
                SQLStatement = "INSERT INTO expense VALUES('','" & txtexpenseamount.Text & "','" & txtexpensename.Text & "','" & txtexpensedescription.Text & "','" & txtexpenseendorse.Text & "','" & dpkexpensedate.Value.ToString("MM/dd/yyyy") & "')"
                Await Saverecords(SQLStatement)
                lblexpense.Text = "Successfull"

                lblexpense.ForeColor = Color.Green
                msgboxalertexpense()
                tmpop.Interval = 2000
                tmpop.Start()

                'My.Settings.taskperform = "Withdrawal has been made with the amount GHs" + txtexpenseamount.Text + " by" + txtexpensename.Text
                'My.Settings.Save()
                'SQLStatement = " INSERT INTO userlog(User_Name,Event_Log,Date,Time,Store_Id)VALUES( '" & My.Settings.myuser & "','" & My.Settings.taskperform & "','" & System.DateTime.Now.ToString("MM/dd/yyyy") & "','" & System.DateTime.Now.ToString("hh:mm:ss") & "','" & My.Settings.settenstoreid & "')"


                txtexpensename.Text = ""
                txtexpenseamount.Text = ""
                txtexpensedescription.Text = ""
                txtexpenseendorse.Text = ""
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Private Sub msgboxalertexpense()


        popalertexpense.Top = 200
        popalertexpense.Left = 350
        my_animate.AnimationType = BunifuAnimatorNS.AnimationType.Transparent
        popalertexpense.BringToFront()
        my_animate.ShowSync(popalertexpense)
        TMexpense()
    End Sub
    'Private Sub Saverecords(ByRef SQLStatement As String)

    '    Using Mycmd As MySqlCommand = New MySqlCommand

    '        With Mycmd
    '            .CommandText = SQLStatement
    '            .CommandType = CommandType.Text
    '            .Connection = SQLconnection
    '            .ExecuteNonQuery()
    '        End With

    '    End Using


    'End Sub

    Async Function Saverecords(SQLStatement As String) As Task

        Using Mycmd As MySqlCommand = New MySqlCommand

            With Mycmd
                .CommandText = SQLStatement
                .CommandType = CommandType.Text
                .Connection = SQLconnection
                .ExecuteNonQuery()
            End With

        End Using

    End Function
    Private Async Sub TMexpense()
        'Await Task.Delay(10000)
        'MsgBox("000000000000000000000")
    End Sub


End Class
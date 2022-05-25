Imports MySql.Data.MySqlClient
Public Class Login
    Dim dt As Date
    Dim days As Integer
    Dim cb1, cb2, cb3, cb4, cb5, cb6 As Integer
    Dim x As String
    Dim count As Integer = 0

    Dim SQLStatement As String
    Dim rd As MySqlDataReader
    Dim cmd As New MySqlCommand

    Dim MyString As String = "Server=LocalHost;user id = root;password = '';Database =startlet ;Port=3306 "
    Dim newid As String

    Dim SQLconnection As MySqlConnection = New MySqlConnection
    Dim sda As MySqlDataAdapter
    Dim table As DataTable

    Private Sub playbeep()

        My.Computer.Audio.Play(System.AppDomain.CurrentDomain.BaseDirectory & "beep\done.wav")

    End Sub
    Private Sub playerror()

        My.Computer.Audio.Play(System.AppDomain.CurrentDomain.BaseDirectory & "beep\error2.wav")

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        Dim netmsg As String
        If My.Settings.checkinternet = True Then
            If My.Computer.Network.IsAvailable Then

            Else

                netmsg = MsgBox("Please check your connections!", vbOK, "Internet connection")
                If netmsg = vbOKOnly Then
                End If
                Exit Sub
            End If
        End If

        SQLconnection.ConnectionString = MyString
        SQLconnection.Open()


        If My.Settings.abrogatelo = True Then
            txtusername.Visible = True
            txtpassword.Visible = True
            btnlogin.Visible = True


        ElseIf My.Settings.abrogatelo = False Then
            txtusername.Visible = False
            txtpassword.Visible = False
            btnlogin.Visible = False

        End If

    End Sub
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        On Error Resume Next
        If My.Settings.secty = bp Then
            playerror()
            Exit Sub
        ElseIf My.Settings.secty <> op Then
            playerror()
            Exit Sub
        ElseIf My.Settings.secty = op Then
        End If
        If My.Settings.checkinternet = True Then
            If My.Computer.Network.IsAvailable Then

            Else

                netmsg = MsgBox("Please check your connections!", vbOK, "Internet connection")
                If netmsg = vbOKOnly Then
                End If
                Exit Sub
            End If
        End If


    End Sub
    Private Sub txtpassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassword.KeyPress
        On Error Resume Next
        If My.Settings.checkinternet = True Then
            If My.Computer.Network.IsAvailable Then

            Else

                netmsg = MsgBox("Please check your connections!", vbOK, "Internet connection")
                If netmsg = vbOKOnly Then
                End If
                Exit Sub
            End If
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then

            If txtusername.Text = "Developer" Or txtusername.Text = "Devl" Then
                dvlp()

            ElseIf txtusername.Text = "Server" And txtpassword.Text = "zdsaqwesxcvf" Then

            Else
                lg()
            End If

        End If

    End Sub
    Dim bp As String = "lockzdsaqwesxcvfrtyg"
    Dim op As String = "openzdsaqwesxcvfrtyg"
    Dim Utype, storeverify, myuser As String
    'LOGIN CODE 
    Dim mysuer
    Private Sub lg()

        Try

            SQLStatement = "SELECT * FROM accounts WHERE User_Name ='" & txtusername.Text & "' and Password= '" & txtpassword.Text & "' And Store_Id = '" & My.Settings.storeverify & "'"
            Dim cmd = New MySqlCommand(SQLStatement, SQLconnection)
            rd = cmd.ExecuteReader

            If rd.Read Then
                Utype = (rd.Item("User_Type"))
                My.Settings.myuserlevel = (rd.Item("User_Type"))
                My.Settings.myuser = (rd.Item("User_Name"))
                My.Settings.settenstoreid = (rd.Item("Store_Id"))
                ' newid = rd.Item("Store_Id")
                My.Settings.settenstoreid = newid
                rd.Close()
                users_load()


                If My.Settings.myaccesstype = "Denied Access" Then

                    my_animate.ShowSync(pnldisable)
                    txtusername.Text = ""
                    txtpassword.Text = ""
                    rd.Close()
                Else
                    my_animate.ShowSync(pnldisable)
                    pnldisable.Text = "Login successful."
                    playbeep()

                    pnldisable.ForeColor = Color.Green
                    my_animate.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
                    my_animate.ShowSync(pnldisable)
                    '  Await Task.Delay(2000)
                    tmpop.Interval = 5000
                    tmpop.Start()

                    Saverecords(SQLStatement)
                    'checkuserlevel()


                End If

            ElseIf txtusername.Text = "" And txtpassword.Text = "" Then
                rd.Close()
                pnldisable.Text = " Please enter your login cridencials"

                pnldisable.ForeColor = Color.Red
                my_animate.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
                my_animate.ShowSync(pnldisable)
                tmpop.Interval = 5000
                tmpop.Start()
                playerror()
            ElseIf count = 3 Then
                rd.Close()
                pnldisable.Text = "You elapse all trails! Contact Admin"

                pnldisable.ForeColor = Color.Red
                my_animate.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
                my_animate.ShowSync(pnldisable)
                tmpop.Interval = 5000
                tmpop.Start()
                playerror()
            Else
                rd.Close()
                pnldisable.Text = "username and password incorrect, please you have attempt " & count & " of (3)"

                pnldisable.ForeColor = Color.Red
                my_animate.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
                my_animate.ShowSync(pnldisable)
                tmpop.Interval = 5000
                tmpop.Start()
                count = count + 1
                txtpassword.Text = ""
                txtpassword.Focus()
                playerror()
            End If
        Catch ex As Exception
            playerror()
            rd.Close()

            Dim exms As String
            exms = ex.Message
            If exms = "Connection must be valid and open." Or exms = "Fatal error encountered during command execution." Or exms = "Unable to write data to the transport connection: An existing connection was forcibly closed by the remote host." Or exms = "Unable to connect to any of the specified MySQL hosts." Then
                SQLconnection.ConnectionString = MyString
                SQLconnection.Open()

            Else

                MsgBox(ex.Message)
            End If

        Finally

        End Try
    End Sub


    Private Sub kilprocess()
        On Error Resume Next
        Dim zetprocess As Process() = System.Diagnostics.Process.GetProcessesByName("ZE-TROVE")
        For Each mykill As Process In zetprocess
            mykill.Kill()
        Next

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub
    Private Sub dvlp()
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
            SQLStatement = "SELECT * FROM ss WHERE UserName ='" & txtusername.Text & "' and Password= '" & txtpassword.Text & "'"
            Dim cmd = New MySqlCommand(SQLStatement, SQLconnection)
            rd = cmd.ExecuteReader
            If rd.Read Then
                Utype = (rd.Item("UserName"))
                My.Settings.devl = "devl"
                My.Settings.employeeprofile = False
                My.Settings.managerprofile = True
                My.Settings.Save()
                rd.Close()
                pnldisable.Text = "Login successful."

                playbeep()
                pnldisable.ForeColor = Color.Green
                my_animate.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
                my_animate.ShowSync(pnldisable)
                tmpop.Interval = 5000
                tmpop.Start()
                Me.Hide()
                '   myhome.Show()
            End If


        Catch ex As Exception
            playerror()
            rd.Close()
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
    Dim netmsg As String
    Dim dr As MySqlDataReader

    Dim trackid, trackdate, acctype, trac, tracdays As String



    Private Sub Saverecords(ByRef SQLStatement As String)
        If My.Settings.checkinternet = True Then
            If My.Computer.Network.IsAvailable Then

            Else

                netmsg = MsgBox("Please check your connections!", vbOK, "Internet connection")
                If netmsg = vbOKOnly Then
                End If
                Exit Sub
            End If
        End If

        Using Mycmd As MySqlCommand = New MySqlCommand

            With Mycmd
                .CommandText = SQLStatement
                .CommandType = CommandType.Text
                .Connection = SQLconnection
                .ExecuteNonQuery()
            End With

        End Using


    End Sub

    Private Sub logout_Tick(sender As Object, e As EventArgs) Handles logout.Tick

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        kilprocess()
    End Sub

    Private Sub tmmrq_Tick(sender As Object, e As EventArgs) Handles tmmrq.Tick

    End Sub

    Private Sub tmpop_Tick(sender As Object, e As EventArgs) Handles tmpop.Tick

    End Sub
    Dim dys, dy As Integer
    Private Sub users_load()
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
            SQLStatement = " SELECT* FROM appcontrols WHERE  Store_Id ='" & newid & "'"
            Dim Command = New MySqlCommand(SQLStatement, SQLconnection)
            rd = Command.ExecuteReader
            While rd.Read
                trackdate = rd.Item("Date")
                acctype = rd.Item("Access_Type")
                trac = rd.Item("Tracking")
                tracdays = rd.Item("Days")
                trackid = rd.Item("Store_Id")
            End While

            rd.Close()
            dys = tracdays + 1

            My.Settings.myaccesstype = acctype
            My.Settings.Save()
            tracking()
        Catch ex As Exception
            playerror()
            rd.Close()
            Dim exms As String
            exms = ex.Message
            If exms = "Connection must be valid and open." Or exms = "Fatal error encountered during command execution." Or exms = "Unable to write data to the transport connection: An existing connection was forcibly closed by the remote host." Or exms = "Unable to connect to any of the specified MySQL hosts." Then
                SQLconnection.ConnectionString = MyString
                SQLconnection.Open()

            Else

                MsgBox(ex.Message)
            End If

        Finally


        End Try

    End Sub
    Private Sub tracking()
        If My.Settings.checkinternet = True Then
            If My.Computer.Network.IsAvailable Then

            Else

                netmsg = MsgBox("Please check your connections!", vbOK, "Internet connection")
                If netmsg = vbOKOnly Then
                End If
                Exit Sub
            End If
        End If

        On Error Resume Next
        If trackdate <> System.DateTime.Now.ToString("MM/dd/yyyy ") Then
            SQLStatement = "Update appcontrols Set Days = '" & dys & "', Date = '" & System.DateTime.Now.ToString("MM/dd/yyyy ") & "' WHERE Store_Id = '" & trackid & "'"
            Saverecords(SQLStatement)
            My.Settings.actdays = My.Settings.actdays + 1
            My.Settings.Save()
        End If
        If trac = "Offline" Then
            SQLStatement = "Update appcontrols Set Tracking = 'Online', Date = '" & System.DateTime.Now.ToString("MM/dd/yyyy ") & "' WHERE Store_Id = '" & trackid & "'"
            Saverecords(SQLStatement)
        End If
        store_new()

    End Sub
    Private Sub store_new()
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
            SQLStatement = " SELECT Store_Id FROM appcontrols WHERE  Store_Id ='" & newid & "'"
            Dim Command = New MySqlCommand(SQLStatement, SQLconnection)
            rd = Command.ExecuteReader
            If rd.Read Then
                rd.Close()

            Else
                rd.Close()
                dys = "0"
                SQLStatement = " INSERT INTO appcontrols(Store_Id,Access_Type,Days,Tracking,Date)VALUES('" & newid & "', '','" & dys & "','" & trac & "','" & System.DateTime.Now.ToString("MM/dd/yyyy ") & "')"
                Saverecords(SQLStatement)


            End If
        Catch ex As Exception
            playerror()
            rd.Close()
            Dim exms As String
            exms = ex.Message
            If exms = "Connection must be valid and open." Or exms = "Fatal error encountered during command execution." Or exms = "Unable to write data to the transport connection: An existing connection was forcibly closed by the remote host." Or exms = "Unable to connect to any of the specified MySQL hosts." Then
                SQLconnection.ConnectionString = MyString
                SQLconnection.Open()
            Else

                MsgBox(ex.Message)
            End If

        Finally


        End Try

    End Sub




End Class
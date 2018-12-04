Imports System.Net
Imports System.Net.Sockets
Imports System.IO


Public Class frmServer
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btOpen As System.Windows.Forms.Button
    Friend WithEvents tbPath As System.Windows.Forms.TextBox
    Friend WithEvents btStart As System.Windows.Forms.Button
    Friend WithEvents tb1 As System.Windows.Forms.TextBox
    Friend WithEvents tb2 As System.Windows.Forms.TextBox
    Friend WithEvents tb3 As System.Windows.Forms.TextBox
    Friend WithEvents tb4 As System.Windows.Forms.TextBox
    Friend WithEvents lbTime1 As System.Windows.Forms.Label
    Friend WithEvents lbTime2 As System.Windows.Forms.Label
    Friend WithEvents lbTime3 As System.Windows.Forms.Label
    Friend WithEvents lbTime4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbName1 As System.Windows.Forms.Label
    Friend WithEvents lbName2 As System.Windows.Forms.Label
    Friend WithEvents lbName3 As System.Windows.Forms.Label
    Friend WithEvents lbName4 As System.Windows.Forms.Label
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnIPAddress As System.Windows.Forms.MenuItem
    Friend WithEvents mnStartServer As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.btOpen = New System.Windows.Forms.Button
        Me.tbPath = New System.Windows.Forms.TextBox
        Me.btStart = New System.Windows.Forms.Button
        Me.tb1 = New System.Windows.Forms.TextBox
        Me.tb2 = New System.Windows.Forms.TextBox
        Me.tb3 = New System.Windows.Forms.TextBox
        Me.tb4 = New System.Windows.Forms.TextBox
        Me.lbTime1 = New System.Windows.Forms.Label
        Me.lbTime2 = New System.Windows.Forms.Label
        Me.lbTime3 = New System.Windows.Forms.Label
        Me.lbTime4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbName1 = New System.Windows.Forms.Label
        Me.lbName2 = New System.Windows.Forms.Label
        Me.lbName3 = New System.Windows.Forms.Label
        Me.lbName4 = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.mnIPAddress = New System.Windows.Forms.MenuItem
        Me.mnStartServer = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btOpen
        '
        Me.btOpen.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btOpen.Location = New System.Drawing.Point(120, 16)
        Me.btOpen.Name = "btOpen"
        Me.btOpen.Size = New System.Drawing.Size(72, 24)
        Me.btOpen.TabIndex = 1
        Me.btOpen.Text = "Mở File"
        '
        'tbPath
        '
        Me.tbPath.Location = New System.Drawing.Point(200, 16)
        Me.tbPath.Name = "tbPath"
        Me.tbPath.Size = New System.Drawing.Size(328, 20)
        Me.tbPath.TabIndex = 2
        Me.tbPath.Text = "File Path"
        '
        'btStart
        '
        Me.btStart.Enabled = False
        Me.btStart.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btStart.Location = New System.Drawing.Point(24, 16)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(72, 24)
        Me.btStart.TabIndex = 3
        Me.btStart.Text = "Bắt đầu"
        '
        'tb1
        '
        Me.tb1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb1.Location = New System.Drawing.Point(176, 16)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(136, 32)
        Me.tb1.TabIndex = 6
        Me.tb1.Text = ""
        '
        'tb2
        '
        Me.tb2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb2.Location = New System.Drawing.Point(176, 56)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(136, 32)
        Me.tb2.TabIndex = 6
        Me.tb2.Text = ""
        '
        'tb3
        '
        Me.tb3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb3.Location = New System.Drawing.Point(176, 96)
        Me.tb3.Name = "tb3"
        Me.tb3.Size = New System.Drawing.Size(136, 32)
        Me.tb3.TabIndex = 6
        Me.tb3.Text = ""
        '
        'tb4
        '
        Me.tb4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb4.Location = New System.Drawing.Point(176, 136)
        Me.tb4.Name = "tb4"
        Me.tb4.Size = New System.Drawing.Size(136, 32)
        Me.tb4.TabIndex = 6
        Me.tb4.Text = ""
        '
        'lbTime1
        '
        Me.lbTime1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTime1.Location = New System.Drawing.Point(328, 24)
        Me.lbTime1.Name = "lbTime1"
        Me.lbTime1.Size = New System.Drawing.Size(64, 23)
        Me.lbTime1.TabIndex = 7
        Me.lbTime1.Text = "0.00"
        '
        'lbTime2
        '
        Me.lbTime2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTime2.Location = New System.Drawing.Point(328, 64)
        Me.lbTime2.Name = "lbTime2"
        Me.lbTime2.Size = New System.Drawing.Size(64, 23)
        Me.lbTime2.TabIndex = 7
        Me.lbTime2.Text = "0.00"
        '
        'lbTime3
        '
        Me.lbTime3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTime3.Location = New System.Drawing.Point(328, 96)
        Me.lbTime3.Name = "lbTime3"
        Me.lbTime3.Size = New System.Drawing.Size(64, 23)
        Me.lbTime3.TabIndex = 7
        Me.lbTime3.Text = "0.00"
        '
        'lbTime4
        '
        Me.lbTime4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTime4.Location = New System.Drawing.Point(328, 136)
        Me.lbTime4.Name = "lbTime4"
        Me.lbTime4.Size = New System.Drawing.Size(64, 23)
        Me.lbTime4.TabIndex = 7
        Me.lbTime4.Text = "0.00"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbTime4)
        Me.GroupBox1.Controls.Add(Me.lbTime3)
        Me.GroupBox1.Controls.Add(Me.lbTime1)
        Me.GroupBox1.Controls.Add(Me.lbTime2)
        Me.GroupBox1.Controls.Add(Me.tb1)
        Me.GroupBox1.Controls.Add(Me.tb2)
        Me.GroupBox1.Controls.Add(Me.tb3)
        Me.GroupBox1.Controls.Add(Me.tb4)
        Me.GroupBox1.Controls.Add(Me.lbName1)
        Me.GroupBox1.Controls.Add(Me.lbName2)
        Me.GroupBox1.Controls.Add(Me.lbName3)
        Me.GroupBox1.Controls.Add(Me.lbName4)
        Me.GroupBox1.Location = New System.Drawing.Point(64, 352)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 176)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'lbName1
        '
        Me.lbName1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName1.Location = New System.Drawing.Point(8, 24)
        Me.lbName1.Name = "lbName1"
        Me.lbName1.Size = New System.Drawing.Size(160, 23)
        Me.lbName1.TabIndex = 7
        Me.lbName1.Text = "Team1"
        Me.lbName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbName2
        '
        Me.lbName2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName2.Location = New System.Drawing.Point(8, 64)
        Me.lbName2.Name = "lbName2"
        Me.lbName2.Size = New System.Drawing.Size(160, 23)
        Me.lbName2.TabIndex = 7
        Me.lbName2.Text = "Team2"
        Me.lbName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbName3
        '
        Me.lbName3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName3.Location = New System.Drawing.Point(8, 104)
        Me.lbName3.Name = "lbName3"
        Me.lbName3.Size = New System.Drawing.Size(160, 23)
        Me.lbName3.TabIndex = 7
        Me.lbName3.Text = "Team3"
        Me.lbName3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbName4
        '
        Me.lbName4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName4.Location = New System.Drawing.Point(8, 136)
        Me.lbName4.Name = "lbName4"
        Me.lbName4.Size = New System.Drawing.Size(160, 23)
        Me.lbName4.TabIndex = 7
        Me.lbName4.Text = "Team4"
        Me.lbName4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnIPAddress, Me.mnStartServer, Me.MenuItem2})
        Me.MenuItem1.Text = "Config"
        '
        'mnIPAddress
        '
        Me.mnIPAddress.Index = 0
        Me.mnIPAddress.Text = "IP Address"
        '
        'mnStartServer
        '
        Me.mnStartServer.Index = 1
        Me.mnStartServer.Text = "Start Server"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.Text = "Send Path"
        '
        'frmServer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(592, 550)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btStart)
        Me.Controls.Add(Me.tbPath)
        Me.Controls.Add(Me.btOpen)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmServer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Server Tăng tốc"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    
    Public ip As String = "127.0.0.1"
    Public port As Integer = 8000
    Public ClientManager As ArrayList = New ArrayList
    Public tbArr As ArrayList = New ArrayList
    Public lbArr As ArrayList = New ArrayList
    Public lbNameArr As ArrayList = New ArrayList
    Public Listener As TcpListener 'New TcpListener(IPAddress.Parse("127.0.0.1"), 8000)
    Dim server As New System.Threading.Thread(AddressOf StartServer)
    Public exited As Boolean = False
    Public cnt As Long = 0
    Dim counter As New Threading.Thread(AddressOf DoCounter)

    Public Sub DoCounter()
        Debug.WriteLine("Counting")        
        Do
            Threading.Thread.Sleep(10)
            cnt += 1
            'If cnt Mod 100 = 0 Then Debug.WriteLine(cnt)
            If (cnt > 2000000000) Then cnt = 0
        Loop Until exited = True
    End Sub

    Private Sub btOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOpen.Click
        OpenFileDialog1.ShowDialog()
        If (OpenFileDialog1.FileName <> "") Then
            tbPath.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStart.Click        
        StartAllClient()
        'WMP1.URL = tbPath.Text
        'WMP1.Ctlcontrols.play()
        'Do
        '    Application.DoEvents()
        'Loop Until WMP1.playState = WMPLib.WMPPlayState.wmppsPlaying
        cnt = 0
    End Sub

    Private Sub SendPaths()
        Dim handler As ClientHandlerWrite
        Dim i As Integer
        For i = 0 To ClientManager.Count - 1
            handler = CType(ClientManager.Item(i), ClientHandlerWrite)
            handler.path = tbPath.Text
            handler.isPathSent = True            
        Next
    End Sub

    Private Sub StartAllClient()
        Dim handler As ClientHandlerWrite
        Dim i As Integer
        For i = 0 To ClientManager.Count - 1
            handler = CType(ClientManager.Item(i), ClientHandlerWrite)
            handler.isStarted = True

        Next
    End Sub

    Private Sub frmServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'counter.Start()
        tbArr.Add(tb1)
        tbArr.Add(tb2)
        tbArr.Add(tb3)
        tbArr.Add(tb4)
        lbArr.Add(lbTime1)
        lbArr.Add(lbTime2)
        lbArr.Add(lbTime3)
        lbArr.Add(lbTime4)
        lbNameArr.Add(lbName1)
        lbNameArr.Add(lbName2)
        lbNameArr.Add(lbName3)
        lbNameArr.Add(lbName4)
    End Sub


    Public Sub StartServer()
        Listener = New TcpListener(IPAddress.Parse(ip), port)
        Listener.Start()

        Debug.WriteLine("Server: Listening for a connection...")

        Dim ClientNum As Integer
        Do
            Try
                'Threading.Thread.Sleep(1000)
                Dim Client As TcpClient = Listener.AcceptTcpClient()
                Application.DoEvents()
                Debug.WriteLine("Server: Connection accepted.")

                ClientNum += 1
                Dim Handler As New ClientHandlerWrite(Client, "Client " & ClientNum.ToString())
                ClientManager.Add(Handler)
                Dim HandlerThread As New System.Threading.Thread(AddressOf Handler.Start)
                HandlerThread.IsBackground = True
                HandlerThread.Start()
                'Add hander for reading
                Dim HandlerRead As New ClientHandlerRead(Client, "Client " & ClientNum.ToString(), CType(tbArr.Item(ClientNum - 1), TextBox), CType(lbNameArr.Item(ClientNum - 1), Label))
                Dim HandlerReadThread As New System.Threading.Thread(AddressOf HandlerRead.Start)
                HandlerReadThread.IsBackground = True
                HandlerReadThread.Start()
            Catch Err As Exception
                Debug.WriteLine(Err.ToString())
            End Try
        Loop Until exited = True


    End Sub


    Private Sub frmServer_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        server.Interrupt()
        server.Abort()
        counter.Abort()
        Debug.WriteLine("abort")
        exited = True
        Try
            Listener.Stop()
        Catch ex As Exception
            'nothing
        End Try        
    End Sub


    Private Sub tb1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb1.TextChanged, tb2.TextChanged, tb3.TextChanged, tb4.TextChanged
        Dim index As Integer
        Dim lbTemp As Label
        index = tbArr.IndexOf(sender)
        lbTemp = CType(lbArr.Item(index), Label)
        lbTemp.Text = Format(cnt / 100, "N")
    End Sub

    Private Sub mnIPAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnIPAddress.Click
        ip = InputBox("Nhập IP server: ", "Server IP", ip)
    End Sub

    Private Sub mnStartServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnStartServer.Click
        server.Start()
        counter.Start()        
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        SendPaths()
        btStart.Enabled = True
    End Sub
End Class

Public Class MyMessages
    Public Const RequestConnect As String = "#Hello"
    Public Const Disconnect As String = "#Bye"
    Public Const AcknowledgeOK As String = "#OK"
    Public Const AcknowledgeCancel As String = "#Cancel"
    Public Const SendPath As String = "#SendPath"
    Public Const StartWMP As String = "#StartWMP"
    Public Const SendAnswer As String = "#AnswerHere"
    Public Const SendTeamName As String = "#TeamName"
End Class

Public Class ClientHandlerWrite

    Private Client As TcpClient
    Public ID As String
    Public isStarted As Boolean = False
    Public isPathSent As Boolean = False
    Public path As String = ""

    Public Sub New(ByVal client As TcpClient, ByVal ID As String)
        Me.Client = client
        Me.ID = ID
    End Sub

    Public Sub Start()
        Dim Stream As NetworkStream = Client.GetStream()
        Dim isDis As Boolean = False
        Dim w As New BinaryWriter(Stream)

        'Dim r As New BinaryReader(Stream)
        Try
            'If r.ReadString() = MyMessages.RequestConnect Then
            '    w.Write(MyMessages.AcknowledgeOK)
            '    Debug.WriteLine(ID + " connected")
            Do

                If (isPathSent) Then
                    w.Write(MyMessages.SendPath)
                    w.Write(path)
                    isPathSent = False
                    Debug.WriteLine("Path sent  - " + ID)
                End If
                If (isStarted) Then
                    w.Write(MyMessages.StartWMP)
                    isStarted = False
                    Debug.WriteLine(ID + " Started")
                End If
                'If (r.ReadString() = MyMessages.Disconnect) Then
                ' i() 'sDis = True
                'End If
            Loop
            '  Loop Until r.ReadString() = MyMessages.Disconnect
            Debug.WriteLine(ID & ": Disconnected.")
            'w.Write(ServerMessages.Disconnect)                


            'Else
            '    Debug.WriteLine(ID & ": Could not complete connection.")
            'End If

            Client.Close()
            Debug.WriteLine(ID & ": Client connection closed.")
        Catch Err As Exception
            Debug.WriteLine(Err.ToString)
        End Try
    End Sub

End Class

Public Class ClientHandlerRead

    Private Client As TcpClient
    Public ID As String
    Public isStarted As Boolean = False
    Public isPathSent As Boolean = False
    Public path As String = ""
    Public tbAnswer As TextBox
    Public lbTeamName As Label

    Public Sub New(ByVal client As TcpClient, ByVal ID As String, ByRef tbAnswer As TextBox, ByRef lbTeamName As Label)
        Me.Client = client
        Me.ID = ID
        Me.tbAnswer = tbAnswer
        Me.lbTeamName = lbTeamName
    End Sub

    Public Sub Start()
        Dim Stream As NetworkStream = Client.GetStream()
        Dim isDis As Boolean = False
        'Dim w As New BinaryWriter(Stream)
        Dim temp As String
        Dim r As New BinaryReader(Stream)
        Dim w As New BinaryWriter(Stream)
        Try
            If r.ReadString() = MyMessages.RequestConnect Then
                w.Write(MyMessages.AcknowledgeOK)
                'Debug.WriteLine(ID + " connected")
                Do
                    temp = r.ReadString()
                    If (temp = MyMessages.Disconnect) Then
                        Debug.WriteLine(ID + " disconnected")
                    End If
                    If (temp = MyMessages.SendAnswer) Then
                        temp = r.ReadString()
                        tbAnswer.Text = ""
                        tbAnswer.Text = temp
                        Debug.WriteLine(ID & "  sent Answer")
                    End If
                    If (temp = MyMessages.SendTeamName) Then
                        temp = r.ReadString()
                        lbTeamName.Text = temp
                    End If
                Loop Until temp = MyMessages.Disconnect

                '  Loop Until r.ReadString() = MyMessages.Disconnect
                Debug.WriteLine(ID & ": Disconnected.")
                'w.Write(ServerMessages.Disconnect)                


            Else
                Debug.WriteLine(ID & ": Could not complete connection.")
            End If

            Client.Close()
            Debug.WriteLine(ID & ": Client connection closed.")
        Catch Err As Exception
            Debug.WriteLine(Err.ToString)
        End Try
    End Sub

End Class
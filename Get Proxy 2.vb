Imports System.Threading
Imports System.Net
Imports System.IO

Public Class Getproxy2

    'CODED BY X-SLAYER // 1:36 am
    'FACEBOOK : https://www.facebook.com/ihebbriki1
    'YOUTUBE : https://www.youtube.com/c/XSLAYERTN
    'Instagram : https://www.instagram.com/ih3_b/
    'Linkedin : https://www.linkedin.com/in/x-slayer/
    'Github : https://github.com/X-SLAYER

    Public Types As String() = {"http", "socks4", "socks5"}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        For Each Combo As Control In Me.Controls
            If TypeOf Combo Is GroupBox Then
                For Each ComboBox In Combo.Controls
                    If TypeOf ComboBox Is ComboBox Then
                        CType(ComboBox, ComboBox).SelectedIndex = 0
                    End If
                Next
            End If
        Next
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Public Sub GetProxy(ByVal Type As String, ByVal TimeOut As String, ByVal Country As String, ByVal SSl As String, ByVal anonymity As String)
        Try
            Dim URL As String = ""
            If CM_Anonymity.Enabled Then
                URL = String.Format("https://api.proxyscrape.com/?request=getproxies&proxytype={0}&timeout={1}&country={2}&ssl={3}&anonymity={4}&uptime=0", Type, TimeOut, Country, SSl, anonymity)
            Else
                URL = String.Format("https://api.proxyscrape.com/?request=getproxies&proxytype={0}&timeout={1}&country={2}&uptime=0", Type, TimeOut, Country)
            End If
            HET(URL)
        Catch ex As Exception
            MsgBox("Error Required : " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Function NewFormat(ByVal str As String)
        Return str.Split(":")(1).ToLower()
    End Function

    Private Sub Download_Click(sender As Object, e As EventArgs) Handles Download.Click
        Results.Clear()
        Dim SLAYER As New Thread(Sub() GetProxy(Types(CM_Type.SelectedIndex), Time.Value, NewFormat(CM_Country.SelectedItem), NewFormat(CM_SSL.SelectedItem), NewFormat(CM_Anonymity.SelectedItem)))
        SLAYER.Start()
    End Sub

    Private Sub CM_Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CM_Type.SelectedIndexChanged
        CM_Anonymity.Enabled = CM_Type.SelectedIndex = 0
        CM_SSL.Enabled = CM_Type.SelectedIndex = 0
    End Sub

#Region "Downloading"

    Public Function HET(ByVal LINK As String) As String
        Try
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create((LINK)), HttpWebRequest)
            request.Proxy = Nothing
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36"
            request.CookieContainer = New CookieContainer
            Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
            Dim reader As New StreamReader(response.GetResponseStream)
            Dim str2 As String = reader.ReadToEnd
            reader.Close()
            Results.Text = str2
            MsgBox("Download Done ", MsgBoxStyle.Information)
            count.Text = "Count : " & Results.Lines.Count - 1
            save.Enabled = True
            Return str2
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function

#End Region

    Private Sub Time_Scroll(sender As Object, e As EventArgs) Handles Time.Scroll
        timeout.Text = "TimeOut : " & Time.Value & "ms"
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim O As New SaveFileDialog
        O.Filter = "TXT Files|*.txt"
        O.FileName = CM_Type.SelectedItem
        If O.ShowDialog = Windows.Forms.DialogResult.OK Then
            File.WriteAllText(O.FileName, Results.Text)
            MsgBox("Proxies Saved Successfully", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Getproxy2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://zalo.me/+13159740267")
    End Sub
End Class

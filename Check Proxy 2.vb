Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Threading
Imports xNet
'-------------------------------------------------------------
' Credit to: Jester_2
' Extract source code and edited by: Samad.Dz
' https://www.youtube.com/c/SamadDZ
' https://www.facebook.com/profile.php?id=100010322857392
'-------------------------------------------------------------
Public Class Form2
    Private dragging As Boolean
    Private offset As Point
    Public Property Country As String
    Public Property City As String
    Public Property Region As String
    Public Property ISP As String
    Public Property GMT As String
    Public Property Block1 As String
    Public Property Block2 As String
    Public Property Block3 As String
    Public Shared ProxysList As List(Of String) = New List(Of String)()
    Private ThreadList As List(Of Thread) = New List(Of Thread)()
    Private Random As Random = New Random()
    Private Shared Timeout As Integer = 10000
    Private [stop] As Boolean = True
    Private goodCounter As Integer = 0
    Private badCounter As Integer = 0
    Private time As String = DateTime.Now.ToString("HH.mm.ss")
    Private patch As String = String.Empty
    Private Errors As String = ""
    Public Sub New()
        Me.InitializeComponent()
        Control.CheckForIllegalCrossThreadCalls = False
        Me.setTypeProxy.SelectedIndex = 0
    End Sub

    Private Sub SourceBtn_Click(sender As Object, e As EventArgs) Handles SourceBtn.Click
        Try
            Dim dialog As New OpenFileDialog With {
                .Filter = "Proxy file (*.txt)|*.txt"
            }
            If (dialog.ShowDialog = DialogResult.OK) Then
                Form2.ProxysList = Enumerable.ToList(Of String)(Enumerable.Distinct(Of String)(File.ReadAllLines(dialog.FileName)))
                Me.ProxyCount.Text = Form2.ProxysList.Count.ToString
            End If
        Catch obj1 As Exception
        End Try
    End Sub

    Private Sub SourceBtn_DragDrop(sender As Object, e As DragEventArgs) Handles SourceBtn.DragDrop
        Try
            Dim data As Array = DirectCast(e.Data.GetData(DataFormats.FileDrop), Array)
            If (Not data Is Nothing) Then
                Dim sFile As String = data.GetValue(0).ToString
                MyBase.Activate()
                Me.LoadProxy(sFile)
            End If
        Catch obj1 As Exception
            MessageBox.Show("Upload Error, try Restart your App.")
        End Try
    End Sub

    Private Sub SourceBtn_DragEnter(sender As Object, e As DragEventArgs) Handles SourceBtn.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        Try
            Dim num As Integer = 0
            Dim num2 As Integer = num
            Me.badCounter = num
            Me.goodCounter = num2
            Me.ProxyCount.Text = Form2.ProxysList.Count.ToString()
            Me.Good.Text = Me.goodCounter.ToString()
            Me.Bad.Text = Me.badCounter.ToString()
            Me.GridLog.Rows.Clear()
            Form2.Timeout = CInt((Me.TimeoutCount.Value * 1000L))
            Me.[stop] = False
            Me.ThreadList.Clear()
            Dim num3 As Integer = 0
            While CLng(num3) < Me.ThreadsCount.Value
                Dim item As New Thread(New ThreadStart(AddressOf Me.StartChecker))
                Me.ThreadList.Add(item)
                item.Start()
                num3 += 1
            End While
        Catch ex As Exception

        End Try

    End Sub
    Private Sub StartChecker()
        While Not Me.[stop] AndAlso Form2.ProxysList.Count > 0
            Dim text As String = String.Empty
            Dim flag As Boolean = False
            Dim obj As Form2
            Try
                obj = Me
                Monitor.Enter(Me, flag)
                If Form2.ProxysList.Count > 0 Then
                    text = Form2.ProxysList(0)
                    Form2.ProxysList.RemoveAt(0)
                End If
            Finally
                If flag Then
                    Monitor.[Exit](obj)
                End If
            End Try
            If String.IsNullOrEmpty(text) Then
                Thread.Sleep(500)
            Else
                Dim rez As String = Me.Checker(text)
                Dim flag2 As Boolean = False
                Try
                    obj = Me
                    Monitor.Enter(Me, flag2)
                    Me.Updatee(rez, text)
                Finally
                    If flag2 Then
                        Monitor.[Exit](obj)
                    End If
                End Try
            End If
        End While
    End Sub
    Private Sub Updatee(rez As String, proxy As String)
        Dim flag As Boolean = False
        Dim flag2 As Boolean = False
        If rez.Contains("Good") Then
            flag = True
            Me.goodCounter += 1
        End If
        If rez.Contains("Bad") Then
            flag2 = True
            Me.badCounter += 1
        End If
        If flag Then
            Me.patch = ("Proxy Checker / Proxy -" & Me.time)
            Dim directoryInfo As DirectoryInfo = Directory.CreateDirectory(Me.patch)
            MyBase.Invoke(New MethodInvoker(Sub()
                                                Me.GridLog.Rows.Add(New Object() {proxy, Me.Country, Me.City, Me.Region})
                                            End Sub))
            File.AppendAllText((Me.patch & "\Good with the logo.txt"), String.Concat(New String() {"=======================================================" & ChrW(13) & ChrW(10) & "IP: ", proxy, ChrW(13) & ChrW(10) & "Country: ", Me.Country, ChrW(13) & ChrW(10) & "City: ", Me.City, ChrW(13) & ChrW(10) & "Region: ", Me.Region, ChrW(13) & ChrW(10) & "Provider: ", Me.ISP, ChrW(13) & ChrW(10) & "Timezone: ", Me.GMT, ChrW(13) & ChrW(10) & "======================blocking=======================" & ChrW(13) & ChrW(10) & "spamhaus.org: ", Me.Block1, ChrW(13) & ChrW(10) & "sorbs.net: ", Me.Block2, ChrW(13) & ChrW(10) & "spamcop.net: ", Me.Block3, ChrW(13) & ChrW(10)}))
            File.AppendAllText((Me.patch & "\Good with no log.txt"), (proxy & ChrW(13) & ChrW(10)))
            Me.patch = ("Proxy Checker / Proxy - " & Me.time & "/Sorting by Country/Country - " & Me.Country)
            Dim directoryInfo2 As DirectoryInfo = Directory.CreateDirectory(Me.patch)
            MyBase.Invoke(New MethodInvoker(Sub()
                                                Me.GridLog.Rows.Add(New Object() {proxy, Me.Country, Me.City, Me.Region})
                                            End Sub))
            File.AppendAllText((Me.patch & "\Good.txt"), String.Concat(New String() {"=======================================================" & ChrW(13) & ChrW(10) & "IP: ", proxy, ChrW(13) & ChrW(10) & "Country: ", Me.Country, ChrW(13) & ChrW(10) & "City: ", Me.City, ChrW(13) & ChrW(10) & "Region: ", Me.Region, ChrW(13) & ChrW(10) & "Provider: ", Me.ISP, ChrW(13) & ChrW(10) & "Timezone: ", Me.GMT, ChrW(13) & ChrW(10) & "======================blocking=======================" & ChrW(13) & ChrW(10) & "spamhaus.org: ", Me.Block1, ChrW(13) & ChrW(10) & "sorbs.net: ", Me.Block2, ChrW(13) & ChrW(10) & "spamcop.net: ", Me.Block3, ChrW(13) & ChrW(10)}))
        End If
        If flag2 Then
            Me.patch = ("Proxy Checker / Proxy - " & Me.time)
            Dim directoryInfo As DirectoryInfo = Directory.CreateDirectory(Me.patch)
            File.AppendAllText((Me.patch & "\Bad.txt"), (proxy & ChrW(13) & ChrW(10)))
        End If
        If flag OrElse flag2 Then
            MyBase.Invoke(New MethodInvoker(Sub()
                                                Me.Good.Text = Me.goodCounter.ToString()
                                                Me.Bad.Text = Me.badCounter.ToString()
                                            End Sub))
        Else
            MyBase.Invoke(New MethodInvoker(Sub()
                                                Me.Bad.Text = Me.badCounter.ToString()
                                            End Sub))
        End If
    End Sub
    Private Function Checker(proxy As String) As String
        Try
            Using httpRequest As HttpRequest = New HttpRequest()
                httpRequest.ConnectTimeout = Form2.Timeout
                httpRequest.AllowAutoRedirect = False
                httpRequest.Cookies = New CookieDictionary(False)
                httpRequest.Referer = "http://check2ip.com/"
                '   httpRequest.UserAgent = HttpHelper.RandomUserAgent()
                httpRequest.Proxy = Me.GetProxy()
                Dim text As String = httpRequest.[Get]("http://check2ip.com/", Nothing).ToString()
                If text.Contains("IP Timezone") Then
                    Dim match As Match = Regex.Match(httpRequest.[Get]("http://check2ip.com/", Nothing).ToString(), "(?<=Country: </td><td style='font-size: 9pt;'>)(.*?)(?=</td> </tr>)")
                    If match.Success Then
                        Me.Country = match.ToString
                    Else
                        Me.Country = ChrW(1054) & ChrW(1096) & ChrW(1080) & ChrW(1073) & ChrW(1082) & ChrW(1072)
                    End If
                    Dim match2 As Match = Regex.Match(httpRequest.[Get]("http://check2ip.com/", Nothing).ToString(), "(?<=City: </td><td style='font-size: 9pt;'>)(.*?)(?=</td>  </tr>)")
                    If match2.Success Then
                        Me.City = match2.ToString()
                    Else
                        Me.City = ChrW(1054) & ChrW(1096) & ChrW(1080) & ChrW(1073) & ChrW(1082) & ChrW(1072)
                    End If
                    Dim match3 As Match = Regex.Match(httpRequest.[Get]("http://check2ip.com/", Nothing).ToString(), "(?<=Region: </td><td style='font-size: 9pt;'>)(.*?)(?=</td>  </tr>)")
                    If match3.Success Then
                        Me.Region = match3.ToString()
                    Else
                        Me.Region = ChrW(1054) & ChrW(1096) & ChrW(1080) & ChrW(1073) & ChrW(1082) & ChrW(1072)
                    End If
                    Dim match4 As Match = Regex.Match(httpRequest.[Get]("http://check2ip.com/", Nothing).ToString(), "(?<=ISP: </td><td id=1157 colspan=3 style='font-size: 9pt;'>"")(.*?)(?=""</td></tr>)")
                    If match4.Success Then
                        Me.ISP = match4.ToString()
                    Else
                        Me.ISP = ChrW(1054) & ChrW(1096) & ChrW(1080) & ChrW(1073) & ChrW(1082) & ChrW(1072)
                    End If
                    Dim match5 As Match = Regex.Match(httpRequest.[Get]("http://check2ip.com/", Nothing).ToString(), "(?<= GMT+)(.*?)(?=</td></tr>)")
                    If match5.Success Then
                        Me.GMT = match5.ToString()
                    Else
                        Me.GMT = ChrW(1054) & ChrW(1096) & ChrW(1080) & ChrW(1073) & ChrW(1082) & ChrW(1072)
                    End If
                    Dim match6 As Match = Regex.Match(httpRequest.[Get]("http://check2ip.com/", Nothing).ToString(), "(?<=zen.spamhaus.org</td><td style='font-size: 8pt;'><font color=00FF00>)(.*?)(?=</font></td>)")
                    If match6.Success Then
                        Me.Block1 = "-"
                    Else
                        Me.Block1 = "+"
                    End If
                    Dim match7 As Match = Regex.Match(httpRequest.[Get]("http://check2ip.com/", Nothing).ToString(), "(?<=dnsbl.sorbs.net</td><td style='font-size: 8pt;'><font color=00FF00>)(.*?)(?=</font></td>)")
                    If match7.Success Then
                        Me.Block2 = "-"
                    Else
                        Me.Block2 = "+"
                    End If
                    Dim match8 As Match = Regex.Match(httpRequest.[Get]("http://check2ip.com/", Nothing).ToString(), "(?<=bl.spamcop.net</td><td style='font-size: 8pt;'><font color=00FF00>)(.*?)(?=</font></td>)")
                    If match8.Success Then
                        Me.Block3 = "-"
                    Else
                        Me.Block3 = "+"
                    End If
                    Return "Good"
                End If
            End Using
        Catch
            Return "Bad"
        End Try
        Return ""
    End Function

    Private Sub StopBtn_Click(sender As Object, e As EventArgs) Handles StopBtn.Click
        Try
            Me.stop = True
            Dim thread As Thread
            For Each thread In Me.ThreadList
                thread.Abort()
            Next
            If (Form2.ProxysList.Count <> 0) Then
                File.AppendAllLines((Me.patch & "\Balance.txt"), Form2.ProxysList)
            End If
        Catch obj1 As Exception
        End Try
    End Sub
    Private Function GetProxy() As ProxyClient
        Dim text As String = Me.setTypeProxy.Text
        If text IsNot Nothing Then
            If text = "HTTP(S)" Then
                Return HttpProxyClient.Parse(Form2.ProxysList(Me.Random.[Next](0, Form2.ProxysList.Count)))
            End If
            If text = "SOCKS 4" Then
                Return Socks5ProxyClient.Parse(Form2.ProxysList(Me.Random.[Next](0, Form2.ProxysList.Count)))
            End If
            If text = "SOCKS 5" Then
                Return Socks5ProxyClient.Parse(Form2.ProxysList(Me.Random.[Next](0, Form2.ProxysList.Count)))
            End If
        End If
        Return Nothing
    End Function
    Private Sub LoadProxy(ByVal sFile As String)
        Try
            Dim reader As New StreamReader(sFile)
            Form2.ProxysList.Clear()
            Form2.ProxysList = Enumerable.ToList(Of String)(Enumerable.Distinct(Of String)(File.ReadAllLines(sFile)))
            Me.ProxyCount.Text = Form2.ProxysList.Count.ToString
            reader.Close()
        Catch obj1 As Exception
            MessageBox.Show("Upload Error, try Restart your App.")
        End Try
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Form2_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Me.dragging = True
        Me.offset = e.Location
    End Sub
    Private Sub Form2_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If Me.dragging Then
            Dim point As Point = MyBase.PointToScreen(e.Location)
            MyBase.Location = New Point((point.X - Me.offset.X), (point.Y - Me.offset.Y))
            Cursor.Current = Cursors.NoMove2D
        End If
    End Sub

    Private Sub Form2_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        Me.dragging = False
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim CP As CreateParams = MyBase.CreateParams
            CP.Style = &HA0000
            Return CP
        End Get
    End Property

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            For i As Integer = 0 To Me.GridLog.RowCount - 2
                For j As Integer = i + 1 To Me.GridLog.RowCount - 2
                    If GridLog.Rows(i).Cells(0).Value = GridLog.Rows(j).Cells(0).Value Then

                        GridLog.Rows.Remove(GridLog.Rows(i))
                        i -= 1
                        Debug.Print("duplicate value " & GridLog.Rows(i).Cells(0).Value)
                    End If

                Next
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class
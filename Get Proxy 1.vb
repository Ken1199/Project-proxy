Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Public Class Getproxy1
    Private dragging As Boolean
    Private offset As Point

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.BackColor = Color.FromArgb(195, 10, 30)
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.BackColor = Color.FromArgb(19, 19, 30)
    End Sub
    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        Label5.BackColor = Color.FromArgb(195, 10, 30)
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        Label5.BackColor = Color.FromArgb(19, 19, 30)
    End Sub
    Private Sub Label6_MouseEnter(sender As Object, e As EventArgs) Handles Label6.MouseEnter
        Label6.BackColor = Color.FromArgb(195, 10, 30)
    End Sub

    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles Label6.MouseLeave
        Label6.BackColor = Color.FromArgb(19, 19, 30)
    End Sub
    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.BackColor = Color.FromArgb(195, 10, 30)
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.BackColor = Color.FromArgb(19, 19, 30)
    End Sub
    Private Sub Label7_MouseEnter(sender As Object, e As EventArgs) Handles Label7.MouseEnter
        Label7.BackColor = Color.FromArgb(195, 10, 30)
    End Sub

    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles Label7.MouseLeave
        Label7.BackColor = Color.FromArgb(19, 19, 30)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim enumerator As IEnumerator = Nothing
        Me.ListBox1.Items.Clear()
        Dim response As HttpWebResponse = DirectCast(DirectCast(WebRequest.Create("https://api.proxyscrape.com?request=getproxies&amp;proxytype=socks4&amp;timeout=10000&amp;country=all"), HttpWebRequest).GetResponse(), HttpWebResponse)
        Dim [end] As String = (New StreamReader(response.GetResponseStream())).ReadToEnd()
        Dim matchCollections As MatchCollection = (New Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")).Matches([end])
        Try
            Try
                enumerator = matchCollections.GetEnumerator()
                While enumerator.MoveNext()
                    Dim objectValue As Match = DirectCast(RuntimeHelpers.GetObjectValue(enumerator.Current), Match)
                    Me.ListBox1.Items.Add(objectValue)
                End While
            Finally
            End Try
        Finally
        End Try
        Dim count As Integer = Me.ListBox1.Items.Count
        publicCountLbl.Text = String.Concat(count.ToString())
        count = Me.ListBox1.Items.Count
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Try
            If (Me.ListBox1.Items.Count > 0) Then
                Dim str() As String = {Me.ListBox1.Items.ToString()}
                Dim saveFileDialog As System.Windows.Forms.SaveFileDialog = New System.Windows.Forms.SaveFileDialog() With
                {
                    .Filter = "Proxy List (*.txt)|*.txt|All Files (*.*)|*.*",
                    .CheckPathExists = True
                }
                saveFileDialog.ShowDialog(Me)
                Dim streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(saveFileDialog.FileName)
                Dim count As Integer = Me.ListBox1.Items.Count - 1
                Dim num As Integer = 0
                Do
                    streamWriter.WriteLine(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Me.ListBox1.Items(num))))
                    num = num + 1
                Loop While num <= count
                streamWriter.Close()
            Else
                MsgBox("Grab Proxies First And Save", MsgBoxStyle.Information, "Dz")
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim enumerator As IEnumerator = Nothing
        Me.ListBox1.Items.Clear()
        Dim response As HttpWebResponse = DirectCast(DirectCast(WebRequest.Create("https://api.proxyscrape.com?request=getproxies&proxytype=socks5&timeout=10000&country=all"), HttpWebRequest).GetResponse(), HttpWebResponse)
        Dim [end] As String = (New StreamReader(response.GetResponseStream())).ReadToEnd()
        Dim matchCollections As MatchCollection = (New Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")).Matches([end])
        Try
            Try
                enumerator = matchCollections.GetEnumerator()
                While enumerator.MoveNext()
                    Dim objectValue As Match = DirectCast(RuntimeHelpers.GetObjectValue(enumerator.Current), Match)
                    Me.ListBox1.Items.Add(objectValue)
                End While
            Finally
            End Try
        Finally
        End Try
        Dim count As Integer = Me.ListBox1.Items.Count
        publicCountLbl.Text = String.Concat(count.ToString())
        count = Me.ListBox1.Items.Count
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim enumerator As IEnumerator = Nothing
        Dim enumerator1 As IEnumerator = Nothing
        Dim enumerator2 As IEnumerator = Nothing
        Dim enumerator3 As IEnumerator = Nothing
        Me.ListBox1.Items.Clear()
        Dim response As System.Net.HttpWebResponse = DirectCast(DirectCast(WebRequest.Create("https://api.proxyscrape.com?request=getproxies&amp;proxytype=http&amp;timeout=10000&amp;country=all&amp;ssl=all&amp;anonymity=all"), System.Net.HttpWebRequest).GetResponse(), System.Net.HttpWebResponse)
        Dim [end] As String = (New System.IO.StreamReader(response.GetResponseStream())).ReadToEnd()
        Dim matchCollections As MatchCollection = (New System.Text.RegularExpressions.Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")).Matches([end])
        Try
            Try
                enumerator = matchCollections.GetEnumerator()
                While enumerator.MoveNext()
                    Dim objectValue As System.Text.RegularExpressions.Match = DirectCast(RuntimeHelpers.GetObjectValue(enumerator.Current), System.Text.RegularExpressions.Match)
                    Me.ListBox1.Items.Add(objectValue)
                End While
            Finally
            End Try
        Finally
        End Try
        Dim httpWebResponse As System.Net.HttpWebResponse = DirectCast(DirectCast(WebRequest.Create("http://www.cybersyndrome.net/pla.html"), System.Net.HttpWebRequest).GetResponse(), System.Net.HttpWebResponse)
        Dim str As String = (New System.IO.StreamReader(httpWebResponse.GetResponseStream())).ReadToEnd()
        Dim matchCollections1 As MatchCollection = (New System.Text.RegularExpressions.Regex("[0-9].{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")).Matches(str)
        Try
            enumerator1 = matchCollections1.GetEnumerator()
            While enumerator1.MoveNext()
                Dim current As System.Text.RegularExpressions.Match = DirectCast(enumerator1.Current, System.Text.RegularExpressions.Match)
                Me.ListBox1.Items.Add(current)
            End While
        Finally
        End Try
        Dim httpWebRequest As System.Net.HttpWebRequest = DirectCast(WebRequest.Create("http://proxy-ip-list.com/"), System.Net.HttpWebRequest)
        Dim response1 As System.Net.HttpWebResponse = DirectCast(httpWebRequest.GetResponse(), System.Net.HttpWebResponse)
        Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(response1.GetResponseStream())
        Dim end1 As String = streamReader.ReadToEnd()
        Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("[0-9].{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")
        Dim matchCollections2 As MatchCollection = regex.Matches(end1)
        Try
            enumerator2 = matchCollections2.GetEnumerator()
            While enumerator2.MoveNext()
                Dim match As System.Text.RegularExpressions.Match = DirectCast(enumerator2.Current, System.Text.RegularExpressions.Match)
                Me.ListBox1.Items.Add(match)
            End While
        Finally
        End Try
        Dim httpWebRequest1 As System.Net.HttpWebRequest = DirectCast(WebRequest.Create("http://proxy-ip-list.com/"), System.Net.HttpWebRequest)
        Dim httpWebResponse1 As System.Net.HttpWebResponse = DirectCast(httpWebRequest.GetResponse(), System.Net.HttpWebResponse)
        Dim streamReader1 As System.IO.StreamReader = New System.IO.StreamReader(response1.GetResponseStream())
        streamReader.ReadToEnd()
        Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("[0-9].{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")
        regex.Matches(end1)
        Try
            enumerator3 = matchCollections2.GetEnumerator()
            While enumerator3.MoveNext()
                Dim current1 As System.Text.RegularExpressions.Match = DirectCast(enumerator3.Current, System.Text.RegularExpressions.Match)
                Me.ListBox1.Items.Add(current1)
            End While
        Finally
        End Try
        Dim count As Integer = Me.ListBox1.Items.Count
        publicCountLbl.Text = String.Concat(count.ToString())
        count = Me.ListBox1.Items.Count
    End Sub
    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseDown
        Me.dragging = True
        Me.offset = e.Location
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseMove
        If (Me.dragging) Then
            Dim screen As Point = MyBase.PointToScreen(e.Location)
            MyBase.Location = New Point(screen.X - Me.offset.X, screen.Y - Me.offset.Y)
            Cursor.Current = Cursors.NoMove2D
        End If
    End Sub

    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseUp
        Me.dragging = False
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.ListBox1.Items.Clear()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub publicCountLbl_Click(sender As Object, e As EventArgs) Handles publicCountLbl.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://zalo.me/+13159740267")
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.Hide()
        Main.Show()
    End Sub
End Class

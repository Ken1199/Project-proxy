Imports System.IO
Imports System.Text.RegularExpressions
Public Class Contry
    Public Geoip As New Getcountry(Application.StartupPath & "\GeoIP.dat")

    Private Sub Lv1_DragDrop(sender As Object, e As DragEventArgs) Handles Lv1.DragDrop
        On Error Resume Next
        Lv1.Items.Clear()
        Dim pprx As String = e.Data.GetData(DataFormats.FileDrop)(0)
        For Each Line As String In File.ReadAllLines(pprx)
            Dim IT As New ListViewItem
            IT.UseItemStyleForSubItems = False
            IT.Text = Line
            IT.SubItems.Add(Geoip.LookupCountryCode(Line.Split(":")(0)).ToUpper).ForeColor = Color.Blue
            If IM.Images.ContainsKey(Geoip.LookupCountryCode(Line.Split(":")(0)).ToUpper & ".png") Then
                IT.ImageIndex = IM.Images.IndexOfKey(Geoip.LookupCountryCode(Line.Split(":")(0)).ToUpper & ".png")
            Else
                IT.ImageIndex = 0
            End If
            Lv1.Items.Add(IT)
        Next
    End Sub

    Private Sub Lv1_DragEnter(sender As Object, e As DragEventArgs) Handles Lv1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub SaveByCountryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveByCountryToolStripMenuItem.Click
        On Error Resume Next
        Dim Country As String = InputBox("Choose Country Code Exp : UK" & vbCrLf & "U CAN CHOOSE MULTIPLE Exp : UK|US|TN", "Choose Country Code", "")
        If Country = Nothing Then : Exit Sub : End If

        Dim I As New SaveFileDialog
        I.Filter = "TxT Files (*.txt)|*.txt"
        If I.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim NewTXT As New StreamWriter(I.FileName)
            For Each T As ListViewItem In Lv1.Items
                If Regex.IsMatch(T.SubItems(1).Text, Country.ToUpper) Then
                    NewTXT.WriteLine(T.Text)
                End If
            Next
            NewTXT.Close()
            MsgBox(I.FileName)
        End If

    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        Lv1.Items.Clear()
    End Sub

    Private Sub ST_Click(sender As Object, e As EventArgs) Handles ST.Click
        Process.Start("https://zalo.me/+13159740267")
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Main = New Main
        Main = Nothing
    End Sub

    Private Sub Contry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Main.Show()
    End Sub
End Class
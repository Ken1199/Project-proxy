Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Text
Imports System.Threading
Public Class Check1
    Private Shared _count As Integer = 0
    Public ext As Boolean
    Private Delegate Sub T1(ByVal s As String)
    Private Delegate Sub T2(ByVal c As String)
    Public Sub New()
        Me.ext = False
        Me.InitializeComponent()
    End Sub
    Public Shared Function M0(ByVal proxyport As String) As Boolean
        Dim flag As Boolean = False
        Dim hostNameOrAddress As String = proxyport.Split(New Char() {":"c})(0)
        Dim ping As New Ping
        Try
            Dim reply As PingReply = ping.Send(hostNameOrAddress, &H7D0)
            If (reply Is Nothing) Then
                flag = False
            End If
            If (reply.Status = IPStatus.Success) Then
                flag = True
            End If
        Catch ex As PingException
            flag = False
        End Try
        Return flag
    End Function
    Private Sub M1()
        Dim num As Integer = 0
        Dim reader As New StreamReader(Me.TextBox1.Text)
        Do While True
            Dim str As String = reader.ReadLine
            Dim proxyport As String = str
            If (str = Nothing) Then
                Exit Do
            End If
            num += 1
            If M0(proxyport) Then
                Me.M2((proxyport & Environment.NewLine))
                Me.M3(String.Concat(New Object() {num}))
            End If
        Loop
    End Sub

    Public Sub M2(ByVal s As String)
        If Me.txtProxified12.InvokeRequired Then
            Dim method As T1 = New T1(AddressOf Me.M2)
            MyBase.Invoke(method, New Object() {s})
        Else
            Me.txtProxified12.AppendText(s)
        End If
    End Sub

    Public Sub M3(ByVal c As String)
        If (Me.Label11.InvokeRequired AndAlso Me.Label12.InvokeRequired) Then
            Dim method As T2 = New T2(AddressOf Me.M3)
            MyBase.Invoke(method, New Object() {c})
        Else
            Me.Label11.Text = c
            Dim objArray As Object() = New Object() {(Me.txtProxified12.Lines.Length - 1).ToString}
            Me.Label12.Text = String.Concat(objArray)
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim dialog As New OpenFileDialog
        dialog.Filter = ".txt | *.txt"
        If (dialog.ShowDialog = DialogResult.OK) Then
            Me.TextBox1.Text = dialog.FileName
            Check1._count = File.ReadAllLines(Me.TextBox1.Text).Length
            Me.Label13.Text = ((Check1._count) & "")
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim dz As New Thread(New ThreadStart(AddressOf Me.M1))
        dz.Start()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.txtProxified12.Clear()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Using dialog As SaveFileDialog = New SaveFileDialog
            dialog.Filter = ".txt | *.txt"
            If (dialog.ShowDialog = DialogResult.OK) Then
                File.WriteAllLines(dialog.FileName, Me.txtProxified12.Text.ToString.Split(New Char() {ChrW(10)}), Encoding.UTF8)
            End If
        End Using
    End Sub
    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://zalo.me/+13159740267")
    End Sub
End Class
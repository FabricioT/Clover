Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates
Public Class certificate
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim shadowsf As New Core.DropShadow()
        shadowsf.ApplyShadows(Me)
    End Sub
    Private Sub certificate_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.Close()
    End Sub
    Public Sub ButtonBorderRadius(ByRef buttonObj As Object, ByVal borderRadiusINT As Integer)
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        'TOP LEFT CORNER
        p.AddArc(New Rectangle(0, 0, borderRadiusINT, borderRadiusINT), 180, 90)
        p.AddLine(40, 0, buttonObj.Width - borderRadiusINT, 0)
        'TOP RIGHT CORNER
        p.AddArc(New Rectangle(buttonObj.Width - borderRadiusINT, 0, borderRadiusINT, borderRadiusINT), -90, 90)
        p.AddLine(buttonObj.Width, 40, buttonObj.Width, buttonObj.Height - borderRadiusINT)
        'BOTTOM RIGHT CORNER
        p.AddArc(New Rectangle(buttonObj.Width - borderRadiusINT, buttonObj.Height - borderRadiusINT, borderRadiusINT, borderRadiusINT), 0, 90)
        p.AddLine(buttonObj.Width - borderRadiusINT, buttonObj.Height, borderRadiusINT, buttonObj.Height)
        'BOTTOM LEF T CORNER
        p.AddArc(New Rectangle(0, buttonObj.Height - borderRadiusINT, borderRadiusINT, borderRadiusINT), 90, 90)
        p.CloseFigure()
        buttonObj.Region = New Region(p)
    End Sub
    Private Sub certificate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loc As New Point
        Dim frm As Form = runtimeactions.LastFormActive
        If frm IsNot Nothing Then
            Dim btn As Button
            btn = frm.Controls("Button4")
            loc = btn.PointToScreen(New Point(0, 0))
            Me.Location = loc
            Me.Top -= 30
        Else
            loc = windowbroser.Button3.PointToScreen(New Point(0, 0))
            Me.Location = loc
            Me.Top -= 30
        End If
        Me.BackColor = StyleBrowser(14)
        Button1.BackColor = StyleBrowser(8)
        Button1.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        Button1.FlatAppearance.MouseDownBackColor = StyleBrowser(12)
        Button1.ForeColor = StyleBrowser(11)
        Label2.ForeColor = StyleBrowser(11)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Opacity += 1
        Me.Top += 5
        Label5.Text += 1
        If Label5.Text = 4 Then
            Timer1.Stop()
            Me.Opacity = windowbroser.Opacity
            Label5.Text = "00"
        End If
    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint
        ButtonBorderRadius(sender, 10)
    End Sub
End Class
Imports System.Windows.Forms
Imports System.Reflection
Public Class clMenu
    Inherits Form

    Public IsExecuting As Boolean = False
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim shadowsf As New Core.DropShadow()
        shadowsf.ApplyShadows(Me)
    End Sub
    'Protected Overrides ReadOnly Property CreateParams As CreateParams
    'Get
    'Const CS_DROPSHADOW As Integer = &H20000
    'Dim cp As CreateParams = MyBase.CreateParams
    'cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
    'Return cp
    'End Get
    'End Property

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
        'BOTTOM LEFT CORNER
        p.AddArc(New Rectangle(0, buttonObj.Height - borderRadiusINT, borderRadiusINT, borderRadiusINT), 90, 90)
        p.CloseFigure()
        buttonObj.Region = New Region(p)
    End Sub

    Private Sub clMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Location = windowbroser.Button11.Location
        'Me.PointToScreen(New Point(windowbroser.Button11.Location))
        Dim loc As New Point
        Dim frm As Form = runtimeactions.LastFormActive
        If frm IsNot Nothing Then
            Dim btn As Button
            btn = frm.Controls("Button3")
            loc = btn.PointToScreen(New Point(0, 0))
            Me.Location = loc
            Me.Top -= 30
        Else
            loc = windowbroser.Button3.PointToScreen(New Point(0, 0))
            Me.Location = loc
            Me.Top -= 30
        End If


        Me.BackColor = StyleBrowser(14)
        Button1.BackColor = StyleBrowser(9)
        Button2.BackColor = StyleBrowser(9)
        Button3.BackColor = StyleBrowser(9)
        Button4.BackColor = StyleBrowser(9)
        Button5.BackColor = StyleBrowser(9)
        Button6.BackColor = StyleBrowser(9)
        Button7.BackColor = StyleBrowser(9)
        Button8.BackColor = StyleBrowser(9)
        Button9.BackColor = StyleBrowser(9)
        Button10.BackColor = StyleBrowser(9)
        Button11.BackColor = StyleBrowser(9)
        Button12.BackColor = StyleBrowser(9)
        Button1.ForeColor = StyleBrowser(11)
        Button2.ForeColor = StyleBrowser(11)
        Button3.ForeColor = StyleBrowser(11)
        Button4.ForeColor = StyleBrowser(11)
        Button5.ForeColor = StyleBrowser(11)
        Button6.ForeColor = StyleBrowser(11)
        Button7.ForeColor = StyleBrowser(11)
        Button8.ForeColor = StyleBrowser(11)
        Button9.ForeColor = StyleBrowser(11)
        Button10.ForeColor = StyleBrowser(11)
        Button11.ForeColor = StyleBrowser(11)
        Button12.ForeColor = StyleBrowser(11)

        Button1.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        Button1.FlatAppearance.MouseDownBackColor = StyleBrowser(12)

        Button2.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        Button2.FlatAppearance.MouseDownBackColor = StyleBrowser(12)

        Button3.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        Button3.FlatAppearance.MouseDownBackColor = StyleBrowser(12)

        Button4.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        Button4.FlatAppearance.MouseDownBackColor = StyleBrowser(12)

        Button5.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        Button5.FlatAppearance.MouseDownBackColor = StyleBrowser(12)

        Button6.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        Button6.FlatAppearance.MouseDownBackColor = StyleBrowser(12)

        Button7.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        Button7.FlatAppearance.MouseDownBackColor = StyleBrowser(12)

        Button8.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        Button8.FlatAppearance.MouseDownBackColor = StyleBrowser(12)

        Button9.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        Button9.FlatAppearance.MouseDownBackColor = StyleBrowser(12)

        Button10.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        Button10.FlatAppearance.MouseDownBackColor = StyleBrowser(12)

        Button11.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        Button11.FlatAppearance.MouseDownBackColor = StyleBrowser(12)

        Button12.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        Button12.FlatAppearance.MouseDownBackColor = StyleBrowser(12)

        PictureBox1.BackColor = StyleBrowser(7)
        PictureBox2.BackColor = StyleBrowser(7)
        PictureBox3.BackColor = StyleBrowser(7)
    End Sub

    Private Sub clMenu_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        'ButtonBorderRadius(sender, 25)
    End Sub

    Private Sub clMenu_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        If IsExecuting = False Then
            Me.Close()
        Else
            Return
        End If
    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub Button2_Paint(sender As Object, e As PaintEventArgs) Handles Button2.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub Button3_Paint(sender As Object, e As PaintEventArgs) Handles Button3.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IsExecuting = True
        'MsgBox(runtimeactions.LastFormActive)
        AddNewTab(runtimeactions.LastFormActive)
        Me.Close()
    End Sub

    Private Sub AddNewTab(sender As Form)
        Dim frm = sender
        'MsgBox(frm.Controls.Item(6).ToString)
        Dim newbrowser As New browsertab
        Dim tabs As MdiTabControl.TabControl
        tabs = frm.Controls("TabControl1")
        tabs.TabPages.Add(newbrowser)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Opacity += 1
        Me.Top += 5
        Label1.Text += 1
        If Label1.Text = 4 Then
            Timer1.Stop()
            Me.Opacity = windowbroser.Opacity
            Label1.Text = "00"
        End If
    End Sub

    Private Sub Button7_Paint(sender As Object, e As PaintEventArgs) Handles Button7.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub Button8_Paint(sender As Object, e As PaintEventArgs) Handles Button8.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub Button10_Paint(sender As Object, e As PaintEventArgs) Handles Button10.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub Button4_Paint(sender As Object, e As PaintEventArgs) Handles Button4.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub Button5_Paint(sender As Object, e As PaintEventArgs) Handles Button5.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub Button9_Paint(sender As Object, e As PaintEventArgs) Handles Button9.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub Button11_Paint(sender As Object, e As PaintEventArgs) Handles Button11.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub Button12_Paint(sender As Object, e As PaintEventArgs) Handles Button12.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub Button6_Paint(sender As Object, e As PaintEventArgs) Handles Button6.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim thisform As New windowbroser
        thisform.WindowState = FormWindowState.Normal
        thisform.StartPosition = FormStartPosition.WindowsDefaultLocation
        thisform.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        AboutClover.Show()
    End Sub
End Class
Imports System.Windows.Forms
Imports System.Reflection
Imports System.Net

Public Class bookmarks
    Inherits Form
    Public IsExecuting As Boolean = False
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim shadowsf As New Core.DropShadow()
        shadowsf.ApplyShadows(Me)
    End Sub

    Private Sub roundCorners(obj As Form)

        obj.FormBorderStyle = FormBorderStyle.None
        obj.BackColor = Color.Cyan


        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)


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
        'BOTTOM LEFT CORNER
        p.AddArc(New Rectangle(0, buttonObj.Height - borderRadiusINT, borderRadiusINT, borderRadiusINT), 90, 90)
        p.CloseFigure()
        buttonObj.Region = New Region(p)
    End Sub
    Private Sub bookmarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'roundCorners(Me)
        Dim loc As New Point
        Dim frm As Form = runtimeactions.LastFormActive

        If frm IsNot Nothing Then
            Dim btn As Button
            btn = frm.Controls("Button6")
            loc = btn.PointToScreen(New Point(0, 0))
            Me.Location = loc
            Me.Top -= 30
            Dim tabc As MdiTabControl.TabControl = frm.Controls("TabControl1")
            'Dim tabp As MdiTabControl.TabPage = tabc.SelectedForm
            Dim tabp As Form = tabc.SelectedForm
            Dim pan As Panel = tabp.Controls("Panel2")
            Dim btnstar As FontAwesome.Sharp.IconButton = pan.Controls("IconButton2")
            If btnstar.IconColor = Color.Gold Then
                Button1.Text = "Eliminar favorito"
                Label2.Text = "Favorito añadido"
            End If
        Else
            loc = windowbroser.Button3.PointToScreen(New Point(0, 0))
            Me.Location = loc
            Me.Top -= 30
        End If
        Me.BackColor = StyleBrowser(14)
        Label2.ForeColor = StyleBrowser(11)
        Label3.ForeColor = StyleBrowser(4)
        IconPictureBox1.IconColor = StyleBrowser(4)
        TextBoxParent.BackColor = StyleBrowser(8)
        RichTextBox1.BackColor = StyleBrowser(8)
        RichTextBox1.ForeColor = StyleBrowser(13)

        Button1.BackColor = StyleBrowser(8)
        Button1.ForeColor = StyleBrowser(11)
        Button1.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        Button1.FlatAppearance.MouseDownBackColor = StyleBrowser(12)

        Dim frm1 = runtimeactions.LastFormActive
        'MsgBox(frm.Controls.Item(6).ToString)
        Dim tabs As MdiTabControl.TabControl
        tabs = frm1.Controls("TabControl1")
        RichTextBox1.Text = tabs.SelectedForm.text
        Dim rich As RichTextBox
        rich = tabs.SelectedForm.Controls("Panel2").Controls("RichTextBox1")
        Label3.Text = rich.Text
        Dim icox As Icon = tabs.SelectedForm.Icon
        PictureBox2.Image = icox.ToBitmap

        Dim url As Uri = New Uri(Label3.Text)
        If url.HostNameType = UriHostNameType.Dns Then
            Dim icons = "http://" & url.Host & "/favicon.ico"
            Label4.Text = icons
        End If
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

    Private Sub bookmarks_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        If IsExecuting = False Then
            Me.Close()
        Else
            Return
        End If
    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub RichTextBox1_GotFocus(sender As Object, e As EventArgs) Handles RichTextBox1.GotFocus
        TextBoxParent.FlatAppearance.BorderColor = Color.MediumSeaGreen
        TextBoxParent.FlatAppearance.BorderSize = 2
    End Sub

    Private Sub TextBoxParent_Paint(sender As Object, e As PaintEventArgs) Handles TextBoxParent.Paint
        ButtonBorderRadius(sender, 15)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Añadir favorito" Then
            IsExecuting = True
            'MsgBox(IO.Directory.GetParent(IO.Directory.GetParent(My.Application.Info.DirectoryPath).ToString).ToString)
            InsertBookMark()
            'Me.Close()
        ElseIf button1.Text = "Eliminar favorito" Then
            IsExecuting = True
            DeleteBookMark()
        Else
            Return
        End If
    End Sub

    Public Sub InsertBookMark()
        If My.Settings.BookAddress IsNot Nothing Then
            'If My.Settings.TopSitesAddress.Contains(s) Then
            'My.Settings.TopSitesAddress.Remove(s)
            'End If
            My.Settings.BookAddress.Insert(0, Label3.Text)
        Else
            My.Settings.BookAddress = New System.Collections.Specialized.StringCollection From {
                        Label3.Text
                    }
        End If

        If My.Settings.BookNames IsNot Nothing Then
            'If My.Settings.TopSitesAddress.Contains(s) Then
            'My.Settings.TopSitesAddress.Remove(s)
            'End If
            My.Settings.BookNames.Insert(0, RichTextBox1.Text)
        Else
            My.Settings.BookNames = New System.Collections.Specialized.StringCollection From {
                    RichTextBox1.Text
                }
        End If

        If My.Settings.BookImages IsNot Nothing Then
            'If My.Settings.TopSitesAddress.Contains(s) Then
            'My.Settings.TopSitesAddress.Remove(s)
            'End If
            My.Settings.BookImages.Insert(0, Label3.Text)
        Else
            My.Settings.BookImages = New System.Collections.Specialized.StringCollection From {
                Label3.Text
            }
        End If
        My.Settings.Save()
        runtimeactions.actions = "addbookmark"
        Me.Close()
    End Sub

    Public Sub DeleteBookMark()
        If My.Settings.BookAddress IsNot Nothing Then
            Dim booktodelete As String = Label3.Text
            If My.Settings.BookAddress.Contains(booktodelete) Then
                runtimeactions.deleteBookIndex = My.Settings.BookAddress.IndexOf(booktodelete)
                'MsgBox(runtimeactions.deleteBookIndex & " - " & runtimeactions.deleteBookIndex + 1)
                My.Settings.BookAddress.Remove(booktodelete)
            Else
                Return
            End If
        Else
            Return
        End If

        If My.Settings.BookNames IsNot Nothing Then
            Dim nametodelete As String = RichTextBox1.Text
            If My.Settings.BookNames.Contains(nametodelete) Then
                My.Settings.BookNames.Remove(nametodelete)
            Else
                Return
            End If
        Else
            Return
        End If

        If My.Settings.BookImages IsNot Nothing Then
            Dim imgtodelete As String = Label3.Text
            If My.Settings.BookImages.Contains(imgtodelete) Then
                My.Settings.BookImages.Remove(imgtodelete)
            Else
                Return
            End If
        Else
            Return
        End If
        My.Settings.Save()
        runtimeactions.deleteBookAdress = Label3.Text
        runtimeactions.deleteBookName = RichTextBox1.Text
        runtimeactions.deleteBookImg = Label3.Text
        runtimeactions.actions = "deletebookmark"
        Me.Close()
    End Sub
End Class
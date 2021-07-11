Option Strict Off
Option Explicit On
Imports System.Security.Permissions
Imports System.Runtime.InteropServices
Imports System
Imports System.Windows
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Drawing2D
Imports System.Web
Imports System.Security
Imports System.Net
Imports CefSharp
Imports CefSharp.WinForms
Imports System.Linq
Imports CefSharp.SchemeHandler
Imports System.Threading
Public Class windowbroser

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


    Private Sub windowbrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Text = String.Empty
        runtimeactions.LastFormActive = Me
        runtimeactions.countforms += 1
        Me.Activate()
        Dim newmename As String
        newmename = "windowbroser" & runtimeactions.countforms
        Me.Name = newmename
        Dim newbrowser As New browsertab
        TabControl1.TabPages.Add(newbrowser)
        StyleClover()
        Me.BackColor = StyleBrowser(0)
        TabControl1.BackHighColor = StyleBrowser(0)
        TabControl1.BackLowColor = StyleBrowser(0)
        'TabControl1.BorderColor = StyleBrowser(0)
        'TabControl1.BackHighColor = Color.Transparent
        'TabControl1.BackLowColor = Color.Transparent
        'Button5.BackColor = StyleBrowser(0)
        Button5.BackColor = StyleBrowser(0)
        Button5.FlatAppearance.MouseOverBackColor = StyleBrowser(6)
        Button5.FlatAppearance.MouseDownBackColor = StyleBrowser(6)
        Button5.FlatAppearance.BorderColor = StyleBrowser(10)
        If My.Settings.IsDarkTheme = False Then
            Button5.BackgroundImage = My.Resources.newtab
        Else
            Button5.BackgroundImage = My.Resources.wnewtab
        End If
        TabControl1.BorderColor = StyleBrowser(1)
        TabControl1.BorderColorDisabled = StyleBrowser(2)
        TabControl1.ForeColor = StyleBrowser(3)
        TabControl1.ForeColorDisabled = StyleBrowser(4)
        TabControl1.TabBackHighColor = StyleBrowser(5)
        TabControl1.TabBackLowColor = StyleBrowser(5)
        TabControl1.TabBackHighColorDisabled = StyleBrowser(6)
        TabControl1.TabBackLowColorDisabled = StyleBrowser(6)
        TabControl1.TabCloseButtonForeColor = StyleBrowser(3)
        TabControl1.TabCloseButtonForeColorDisabled = StyleBrowser(4)
        Me.ContextMenuStrip1.Renderer = New ContextRender()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TabControl1.TabPages.Count > 0 Then
            Me.Text = "Clover - " + TabControl1.SelectedForm.text.ToString
        End If
        If runtimeactions.actions = "newtabaddress" Then
            Dim newbrowser As New browsertab
            TabControl1.TabPages.Add(newbrowser)
        End If
        If runtimeactions.actions = "newtabsource" Then
            Dim newbrowser As New browsertab
            TabControl1.TabPages.Add(newbrowser)
        End If
        If runtimeactions.actions = "newtabmenu" Then
            Dim newbrowser As New browsertab
            TabControl1.TabPages.Add(newbrowser)
            runtimeactions.actions = ""
        End If
        If runtimeactions.actions = "newwindowaddress" Then
            Dim nav As New windowbroser With {
            .StartPosition = FormStartPosition.CenterParent,
            .WindowState = FormWindowState.Normal
            }
            'nav.StartPosition = FormStartPosition.CenterParent
            'nav.WindowState = FormWindowState.Normal
            nav.Show()
        End If
        If TabControl1.TabPages.Count = 1 Then
            Button5.Left = "208"
            TabControl1.TabMaximumWidth = 200
            TabControl1.TabMinimumWidth = 200
        End If
        If TabControl1.TabPages.Count = 2 Then
            Button5.Left = "411"
            TabControl1.TabMaximumWidth = 200
            TabControl1.TabMinimumWidth = 200
        End If
        If TabControl1.TabPages.Count = 3 Then
            Button5.Left = "614"
            TabControl1.TabMaximumWidth = 200
            TabControl1.TabMinimumWidth = 200
        End If
        If TabControl1.TabPages.Count = 4 Then
            Button5.Left = "817"
            TabControl1.TabMaximumWidth = 200
            TabControl1.TabMinimumWidth = 200
        End If
        If TabControl1.TabPages.Count = 5 Then
            Button5.Left = "1020"
            TabControl1.TabMaximumWidth = 200
            TabControl1.TabMinimumWidth = 200
        End If
        If TabControl1.TabPages.Count > 5 Then
            TabControl1.TabMaximumWidth = (Button1.Width / TabControl1.TabPages.Count) - 3
            TabControl1.TabMinimumWidth = (Button1.Width / TabControl1.TabPages.Count) - 3
            Button5.Left = Button2.Left
        End If
        'If TabControl1.TabPages.Count = 6 Then
        'Button5.Left = "1223"
        'TabControl1.TabMaximumWidth = 200
        'TabControl1.TabMinimumWidth = 200
        'End If
        'If TabControl1.TabPages.Count = 7 Then
        'Button5.Left = "1426"
        'TabControl1.TabMaximumWidth = 200
        'TabControl1.TabMinimumWidth = 200
        'End If
        'If TabControl1.TabPages.Count = 8 Then
        'Button5.Left = "1629"
        'TabControl1.TabMaximumWidth = 200
        'TabControl1.TabMinimumWidth = 200
        'End If
        'If TabControl1.TabPages.Count = 9 Then
        'Button5.Left = "1832"
        'End If

        If TabControl1.TabPages.Count = 0 Then
            End
        End If
    End Sub

    Private Sub windowbrowser_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Button5.Left = PictureBox2.Left
    End Sub

    Private Sub windowbrowser_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        Timer1.Start()
    End Sub

    Private Sub windowbrowser_ResizeBegin(sender As Object, e As EventArgs) Handles MyBase.ResizeBegin
        Timer1.Stop()
    End Sub

    Private Sub TabControl1_Load(sender As Object, e As EventArgs) Handles TabControl1.Load

    End Sub
    Dim numberFormsOpen As Integer
    Dim browserisopen As Boolean
    Private Sub windowbroser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.TabControl1.TabPages.Clear()
        numberFormsOpen = My.Application.OpenForms.Count - 1
        browserisopen = False
        If Application.OpenForms().OfType(Of browsertab).Any Then
            browserisopen = True
        End If
    End Sub

    Private Sub windowbrowser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        TabControl1.TabPages.Clear()
        If (numberFormsOpen = 1) Then
            browsertab.Close()
            CefSharp.Cef.Shutdown()
            Application.ExitThread()
            End
        End If
    End Sub

    Private Sub NuevaPestañaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaPestañaToolStripMenuItem.Click
        Dim newbrowser As New browsertab
        TabControl1.TabPages.Add(newbrowser)
    End Sub

    Private Sub ContextMenuStrip1_Paint(sender As Object, e As PaintEventArgs) Handles ContextMenuStrip1.Paint
        'ButtonBorderRadius(sender, 15)
    End Sub

    Private Sub CerrarPestañaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarPestañaToolStripMenuItem.Click
        Try
            TabControl1.TabPages.Remove(TabControl1.TabPages.SelectedTab)
        Catch ex As Exception
            End
        End Try

    End Sub

    Private Sub AbrirEnUnaNuevaVentanaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirEnUnaNuevaVentanaToolStripMenuItem.Click

        Dim thisrich = TabControl1.SelectedForm.Controls("Panel2").Controls("label2")
        runtimeactions.actions = "duplicatewindow"
        runtimeactions.urlsnt = thisrich.Text
        Dim thisform As New windowbroser
        thisform.WindowState = FormWindowState.Normal
        thisform.StartPosition = FormStartPosition.WindowsDefaultLocation
        thisform.Show()
        'MsgBox(runtimeactions.urlsnt)
        'Dim newbrowser As New browsertab
        'TabControl1.TabPages.Add(newbrowser)
    End Sub

    Private Sub DuplicarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuplicarToolStripMenuItem.Click
        Dim thisrich = TabControl1.SelectedForm.Controls("Panel2").Controls("label2")
        runtimeactions.actions = "duplicatetab"
        runtimeactions.urlsnt = thisrich.Text
        'MsgBox(runtimeactions.urlsnt)
        Dim newbrowser As New browsertab
        TabControl1.TabPages.Add(newbrowser)
    End Sub

    Private Sub windowbroser_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        runtimeactions.LastFormActive = Me
    End Sub

    Private Sub windowbroser_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        runtimeactions.LastFormActive = Me
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim newbrowser As New browsertab
        TabControl1.TabPages.Add(newbrowser)
    End Sub

    Private Sub Button5_Paint(sender As Object, e As PaintEventArgs) Handles Button5.Paint
        ButtonBorderRadius(sender, 10)
    End Sub
End Class
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
    Public CachePath As String


#Region "Fields"
    Private dwmMargins As Dwm.MARGINS
    Private _marginOk As Boolean
    Private _aeroEnabled As Boolean
#End Region
#Region "Ctor"
    Public Sub New()
        SetStyle(ControlStyles.ResizeRedraw, True)

        InitializeComponent()

        DoubleBuffered = True

        CheckGlassEnabled()
    End Sub
#End Region
#Region "Props"
    Public ReadOnly Property AeroEnabled() As Boolean
        Get
            Return _aeroEnabled
        End Get
    End Property
#End Region
#Region "Methods"
    ''' <summary>
    ''' Sets the value of AeroEnabled
    ''' </summary>
    Private Sub CheckGlassEnabled()
        If Environment.OSVersion.Version.Major >= 6 Then
            Dim enabled As Integer = 0
            Dim response As Integer = Dwm.DwmIsCompositionEnabled(enabled)

            _aeroEnabled = enabled = 1
        End If
    End Sub
    ''' <summary>
    ''' Equivalent to the LoWord C Macro
    ''' </summary>
    ''' <param name="dwValue"></param>
    ''' <returns></returns>
    Public Shared Function LoWord(ByVal dwValue As Integer) As Integer
        Return dwValue And &HFFFF
    End Function
    ''' <summary>
    ''' Equivalent to the HiWord C Macro
    ''' </summary>
    ''' <param name="dwValue"></param>
    ''' <returns></returns>
    Public Shared Function HiWord(ByVal dwValue As Integer) As Integer
        Return (dwValue >> 16) And &HFFFF
    End Function
#End Region

    Public Sub InitializeSettings()
        Dim settings As New CefSettings
        settings.RegisterScheme(New CefCustomScheme() With {
                       .SchemeName = "Clover",
                       .SchemeHandlerFactory = New LocalSchemeHandlerFactory,
                       .IsSecure = True
            })
        CachePath = System.IO.Path.GetFullPath("cache")
        'MsgBox(CachePath)
        settings.RootCachePath = CachePath
        'settings.UserAgent = "CefSharp" + Cef.CefSharpVersion
        'settings.UserAgent = "Clover " & My.Application.Info.Version.ToString
        'settings.UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 10_0_1 like Mac OS X) AppleWebKit/602.1.50 (KHTML, like Gecko) Version/10.0 Mobile/14A403 Safari/602.1"
        settings.CefCommandLineArgs.Add("enable-media-stream")
        settings.CefCommandLineArgs.Add("use-fake-ui-for-media-stream")
        settings.CefCommandLineArgs.Add("enable-usermedia-screen-capturing")
        settings.IgnoreCertificateErrors = True
        settings.CachePath = CachePath
        settings.PersistSessionCookies = True
        settings.PersistUserPreferences = True
        'settings.UserAgentProduct = "Clover " & My.Application.Info.Version.ToString

        settings.Locale = "es"
        CefSharp.Cef.Initialize(settings)
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

    Public Sub LoadStyle()
        StyleClover()
        Me.BackColor = StyleBrowser(0)
        TabControl1.BackHighColor = StyleBrowser(0)
        TabControl1.BackLowColor = StyleBrowser(0)
        'TabControl1.BorderColor = StyleBrowser(0)
        'TabControl1.BackHighColor = Color.Transparent
        'TabControl1.BackLowColor = Color.Transparent
        'Button5.BackColor = StyleBrowser(0)
        Button5.BackColor = StyleBrowser(0)
        Button5.FlatAppearance.MouseOverBackColor = StyleBrowser(10)
        Button5.FlatAppearance.MouseDownBackColor = StyleBrowser(10)
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




    End Sub


    Private Sub windowbrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Cef.IsInitialized Then
            InitializeSettings()
        End If
        'TabControl1.Height = Button8.Height
        'Me.Text = String.Empty
        runtimeactions.LastFormActive = Me
        runtimeactions.countforms += 1
        Me.Activate()
        Dim newmename As String
        newmename = "windowbroser" & runtimeactions.countforms
        Me.Name = newmename
        AddTab()
        LoadStyle()

        Me.ContextMenuStrip1.Renderer = New ContextRender()

        'My.Settings.TopSitesAddress.Clear()
        'My.Settings.TopSitesName.Clear()
        'My.Settings.TopSitesImages.Clear()
        'My.Settings.Save()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TabControl1.TabPages.Count > 0 Then
            Me.Text = "Clover - " + TabControl1.SelectedForm.text.ToString
        End If
        If runtimeactions.actions = "newtabaddress" Then
            AddTab()
            runtimeactions.actions = ""
        End If
        If runtimeactions.actions = "newtabsource" Then
            AddTab()
            runtimeactions.actions = ""
        End If
        If runtimeactions.actions = "newtabmenu" Then
            AddTab()
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
            runtimeactions.actions = ""
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
        If runtimeactions.actions = "addbookmark" Then
            For I As Integer = 0 To TabControl1.TabPages.Count - 1
                Dim tabb As MdiTabControl.TabPage = TabControl1.TabPages(I)
                Dim tab As Form = tabb.Form
                Dim pan As Panel = tab.Controls("Panel2")
                Dim tools As ToolStrip = pan.Controls("ToolStrip1")
                'MsgBox(tools.Items.Count.ToString)

                Dim fav = My.Resources.clover_logo1
                Dim url As Uri = New Uri(My.Settings.BookAddress.Item(0))
                If url.HostNameType = UriHostNameType.Dns Then
                    Dim icons = "http://" & url.Host & "/favicon.ico"
                    Try
                        Dim req As System.Net.WebRequest = System.Net.HttpWebRequest.Create(icons)
                        Dim res As System.Net.HttpWebResponse = req.GetResponse()
                        Dim col As WebHeaderCollection = res.Headers
                        Dim stream As System.IO.Stream = res.GetResponseStream()
                        Dim favpr = Image.FromStream(stream)
                        Dim favpr2 As Bitmap = favpr
                        fav = favpr2

                    Catch ex As Exception
                        fav = My.Resources.clover_logo1
                    End Try
                Else
                    fav = My.Resources.clover_logo1
                End If

                Dim itm As New ToolStripButton With {
                                    .Image = fav,
                                    .Text = My.Settings.BookNames.Item(0),
                                    .ToolTipText = My.Settings.BookAddress.Item(0),
                                    .Name = "BookItem" & My.Settings.BookAddress.Count + 1
                                    }

                tools.Items.Insert(0, itm)
                AddHandler tools.Items.Item(0).Click, AddressOf browsertab.HandleDynamicBookMarkButtonClick
                runtimeactions.actions = ""
            Next
        End If
        If runtimeactions.actions = "deletebookmark" Then
            For I As Integer = 0 To TabControl1.TabPages.Count - 1
                Dim tabb As MdiTabControl.TabPage = TabControl1.TabPages(I)
                Dim tab As Form = tabb.Form
                Dim pan As Panel = tab.Controls("Panel2")
                Dim tools As ToolStrip = pan.Controls("ToolStrip1")
                'MsgBox(tools.Items.Count.ToString)

                If runtimeactions.deleteBookName IsNot Nothing Then
                    Dim deleteBookName As String = "BookItem" & runtimeactions.deleteBookIndex + 1
                    'MsgBox(deleteBookName)
                    tools.Items.RemoveByKey(deleteBookName)
                Else
                    MsgBox("La variable runtimeactions.deleteBookName está vacía", MsgBoxStyle.Critical, "Error.")
                End If

                runtimeactions.actions = ""
            Next
        End If
        If runtimeactions.actions = "changetheme" Then
            LoadStyle()

            For I As Integer = 0 To TabControl1.TabPages.Count - 1
                'Dim tabb As MdiTabControl.TabPage = TabControl1.TabPages(I)
                'Dim tab As Form = tabb.Form
                'Dim pan As Panel = tab.Controls("Panel2")
                runtimeactions.actions = "changethemebrowser"
            Next
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
        'Me.TabControl1.TabPages.Clear()
        'numberFormsOpen = My.Application.OpenForms.Count
        'MsgBox(countforms)



        'browserisopen = False
        If TabControl1.TabPages.Count > 1 Then
            If My.Settings.AskforCloseTabs = True Then
                If MsgBox("¿Deseas cerrar todas las pestañas abiertas?", MsgBoxStyle.YesNo, "Cerrar múltiples pestañas") = MsgBoxResult.Yes Then
                    If (runtimeactions.countforms > 1) Then

                    Else
                        Me.TabControl1.TabPages.Clear()
                        browsertab.Close()
                        CefSharp.Cef.Shutdown()
                        End
                    End If
                Else
                    e.Cancel = True
                    Return
                End If
            Else
                'e.Cancel = True
                'Return
            End If
        Else
            If (runtimeactions.countforms > 1) Then

            Else
                Me.TabControl1.TabPages.Clear()
                browsertab.Close()
                CefSharp.Cef.Shutdown()
                End
            End If

        End If

        'Me.TabControl1.TabPages.Clear()
        'browsertab.Close()
        'CefSharp.Cef.Shutdown()
        'Application.ExitThread()
        'End
    End Sub
    Private Sub windowbrowser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'TabControl1.TabPages.Clear()
        'If (numberFormsOpen = 1) Then
        'browsertab.Close()
        'CefSharp.Cef.Shutdown()
        'Application.ExitThread()
        'End
        'End If
    End Sub

    Private Sub NuevaPestañaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaPestañaToolStripMenuItem.Click
        AddTab()
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
        'AddTab()
    End Sub

    Private Sub DuplicarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuplicarToolStripMenuItem.Click
        Dim thisrich = TabControl1.SelectedForm.Controls("Panel2").Controls("label2")
        runtimeactions.actions = "duplicatetab"
        runtimeactions.urlsnt = thisrich.Text
        'MsgBox(runtimeactions.urlsnt)
        AddTab()
    End Sub

    Private Sub windowbroser_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        runtimeactions.LastFormActive = Me
        ContextMenuStrip1.Close()
    End Sub

    Private Sub windowbroser_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        runtimeactions.LastFormActive = Me
        Dwm.DwmExtendFrameIntoClientArea(Me.Handle, dwmMargins)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AddTab()
    End Sub

    Private Sub Button5_Paint(sender As Object, e As PaintEventArgs) Handles Button5.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Public Sub AddTab()
        Dim newbrowser As New browsertab
        Dim tabs As Integer = TabControl1.TabPages.Count

        If tabs >= 1 Then
            runtimeactions.LoadStart = False
            Dim pan As Panel = newbrowser.Controls("Panel2")
            Dim tools As ToolStrip = pan.Controls("ToolStrip1")

            Dim firsttab As MdiTabControl.TabPage = TabControl1.TabPages(0)
            Dim firstform As Form = firsttab.Form
            Dim firstpan As Panel = firstform.Controls("Panel2")
            Dim firsttools As ToolStrip = firstpan.Controls("ToolStrip1")
            'MsgBox(TabControl1.TabPages.SelectedIndex)
            tools.Items.Clear()
            For i As Integer = 0 To firsttools.Items.Count - 1
                'Dim toolsh As New ToolStripButton()
                'toolsh = firsttools.Items.Item(i)
                Dim itm As New ToolStripButton With {
                                    .Image = firsttools.Items.Item(i).Image,
                                    .Text = firsttools.Items.Item(i).Text,
                                    .ToolTipText = firsttools.Items.Item(i).ToolTipText,
                                    .Name = firsttools.Items.Item(i).Name
                                    }

                'tools.Items.Insert(0, itm)
                tools.Items.Add(itm)
                Dim itmidx As Integer = tools.Items.IndexOf(itm)
                AddHandler tools.Items.Item(itmidx).Click, AddressOf HandleDynamicBookMarkButtonClick
            Next
        End If
        TabControl1.TabPages.Add(newbrowser)
        LoadStyle()
    End Sub
    Public Sub HandleDynamicBookMarkButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As ToolStripButton = DirectCast(sender, ToolStripButton)
        runtimeactions.actionBook = "loadBookMarkToWin"
        runtimeactions.booktoread = btn
        runtimeactions.actionBookForm = TabControl1.SelectedForm
    End Sub

    Private Sub IconButton1_Paint(sender As Object, e As PaintEventArgs)
        ButtonBorderRadius(sender, 15)
    End Sub
End Class
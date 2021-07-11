
Imports CefSharp
Imports CefSharp.WinForms
Imports System
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Web
Imports System.Net
Imports System.Xml
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Security
Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates

Public Class browsertab

    Inherits System.Windows.Forms.Form
    Public WithEvents _browser As ChromiumWebBrowser
    Public WithEvents _contextMenu As CloverMenuHandler
    Public transparentPanel As TransparentPanel
    Public topadd As New List(Of String)
    Public topnam As New List(Of String)
    Public topimg As New List(Of String)
    Const quote As String = """"
    'Private Const html As String = aboutblankcontent

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
    Private Sub InitializeSettings()
        Dim settings As New CefSettings
        settings.RegisterScheme(New CefCustomScheme() With {
                       .SchemeName = "clover",
                       .SchemeHandlerFactory = New LocalSchemeHandlerFactory,
                       .IsSecure = True
            })

        CefSharp.Cef.Initialize(settings)

    End Sub
    Public Sub InitializeChromium()

        If Not Cef.IsInitialized Then
            InitializeSettings()
        End If

        If runtimeactions.actions = "newtabaddress" Then
            _browser = New ChromiumWebBrowser(runtimeactions.urls)
            runtimeactions.actions = ""
        ElseIf runtimeactions.actions = "newwindowaddress" Then
            _browser = New ChromiumWebBrowser(runtimeactions.urls)
            runtimeactions.actions = ""
        ElseIf runtimeactions.actions = "duplicatetab" Then
            If runtimeactions.urlsnt IsNot Nothing Then
                _browser = New ChromiumWebBrowser(runtimeactions.urlsnt)
                runtimeactions.urlsnt = ""
            Else
                _browser = New ChromiumWebBrowser("clover://newtab/")
                MsgBox("Ocurrió un error en Clover. Lo sentimos, vuelve a intentar la acción")
            End If
            runtimeactions.actions = ""

        ElseIf runtimeactions.actions = "duplicatewindow" Then
            If runtimeactions.urlsnt IsNot Nothing Then
                _browser = New ChromiumWebBrowser(runtimeactions.urlsnt)
                runtimeactions.urlsnt = ""
            Else
                _browser = New ChromiumWebBrowser("clover://newtab/")
                MsgBox("Ocurrió un error en Clover. Lo sentimos, vuelve a intentar la acción")
            End If
            runtimeactions.actions = ""

        ElseIf runtimeactions.actions = "newtabsource" Then
            If runtimeactions.urlsnt IsNot Nothing Then
                _browser = New ChromiumWebBrowser(runtimeactions.urlsnt)
                runtimeactions.urlsnt = ""
            Else
                _browser = New ChromiumWebBrowser("clover://newtab/")
                MsgBox("Ocurrió un error en Clover. Lo sentimos, vuelve a intentar la acción")
            End If
            runtimeactions.actions = ""
        Else
            _browser = New ChromiumWebBrowser("clover://newtab/")
        End If

        AddHandler _browser.FrameLoadStart, AddressOf BrowserOnFrameLoadStart
        AddHandler _browser.FrameLoadEnd, AddressOf BrowserOnFrameLoadEnd
        AddHandler _browser.TitleChanged, AddressOf BrowserTitleChanged
        AddHandler _browser.StatusMessage, AddressOf BrowserStatusMessage
        AddHandler _browser.AddressChanged, AddressOf BrowserAddressChanged

        System.Console.WriteLine("*** Initializing Chromium")

        Panel1.Controls.Add(_browser)
        _browser.Dock = DockStyle.Fill
        _browser.BackColor = Color.White
    End Sub

    Public Sub InitializeContextMenu()
        _contextMenu = New CloverMenuHandler
        _browser.MenuHandler = _contextMenu
    End Sub

    Private Sub BrowserOnFrameLoadStart(sender As Object, e As FrameLoadStartEventArgs)
        ProgressBar1.Invoke(
            Sub()
                ProgressBar1.Visible = True
                ProgressBar1.Style = ProgressBarStyle.Marquee
                ProgressBar1.Refresh()
            End Sub)


        'If _browser.Address = "clover://newtab/" Then
        'Dim html As String = My.Resources.aboutblank
        'Dim base64EncodedHtml = Convert.ToBase64String(Encoding.UTF8.GetBytes(html))
        '_browser.Load("data:text/html;base64," + base64EncodedHtml)
        'End If
        Button3.Invoke(
            Sub()
                Button3.Visible = False
            End Sub)
        Button6.Invoke(
            Sub()
                Button6.Visible = True
            End Sub)
        Label2.Invoke(
            Sub()
                Label2.Text = _browser.Address
            End Sub)


    End Sub
    Private Sub Opencertificate(sender As Object)

    End Sub
    Private Sub BrowserOnFrameLoadEnd(sender As Object, e As FrameLoadEndEventArgs)
        Try
            Dim url As Uri = New Uri(_browser.Address)
            If url.HostNameType = UriHostNameType.Dns Then
                Dim icons = "http://" & url.Host & "/favicon.ico"
                Try
                    Dim req As System.Net.WebRequest = System.Net.HttpWebRequest.Create(icons)
                    Dim res As System.Net.HttpWebResponse = req.GetResponse()
                    Dim col As WebHeaderCollection = res.Headers
                    Dim stream As System.IO.Stream = res.GetResponseStream()
                    Dim fav = Image.FromStream(stream)
                    Dim blah As Bitmap = fav
                    Dim icox As Icon = Icon.FromHandle(blah.GetHicon())
                    Me.Invoke(
                    Sub()
                        Me.Icon = icox
                    End Sub)
                Catch ex As Exception
                    Me.Invoke(
                            Sub()
                                Me.Icon = My.Resources.clover_logo
                            End Sub)
                End Try
            End If
        Catch ex As Exception
            'MsgBox("Error. Clover no pudo conseguir los valores de inicialización.")
            '_browser.Load("clover://newtab/")
            'runtimeactions.actions = ""
            'runtimeactions.urlsnt = ""
        End Try

        RichTextBox1.Invoke(
            Sub()
                RichTextBox1.Text = _browser.Address
            End Sub)
        ProgressBar1.Invoke(
            Sub()
                ProgressBar1.Visible = False
            End Sub)
        If _browser.Address.Contains("data:text/html;base64,") And Me.Text = "Nueva pestaña" Then
            bringlist1()
            bringlist2()
            bringlist3()



            If My.Settings.TopSitesAddress IsNot Nothing Then
                If My.Settings.TopSitesAddress.Count > 0 Then
                    Dim imgis As String = "<img src='" + topimg.ElementAt(0) + "' class='mark-img'>"
                    Dim script1 = "(function(){ document.getElementsByClassName(  ""card""  )[0].innerHTML = " & quote & "<a class='card-dir table' href='" + topadd.ElementAt(0) + "'><div Class='card-dir-content table-cell'>" & imgis & "<span Class='d-block text-truncate float-left'>" + topnam.ElementAt(0) + "</span></div>" & quote & "; })();"
                    _browser.ExecuteScriptAsync(script1)
                    If My.Settings.TopSitesAddress.Count > 1 Then
                        Dim script2 = "(function(){ document.getElementsByClassName(  ""card""  )[1].innerHTML = " & quote & "<a class='card-dir table' href='" + topadd.ElementAt(1) + "'><div Class='card-dir-content table-cell'><img src='" + topimg.ElementAt(1) + "' class='mark-img'><span Class='d-block text-truncate float-left'>" + topnam.ElementAt(1) + "</span></div>" & quote & "; })();"
                        _browser.ExecuteScriptAsync(script2)
                    End If
                    If My.Settings.TopSitesAddress.Count > 2 Then
                        Dim script3 = "(function(){ document.getElementsByClassName(  ""card""  )[2].innerHTML = " & quote & "<a class='card-dir table' href='" + topadd.ElementAt(2) + "'><div Class='card-dir-content table-cell'><img src='" + topimg.ElementAt(2) + "' class='mark-img'><span Class='d-block text-truncate float-left'>" + topnam.ElementAt(2) + "</span></div>" & quote & "; })();"
                        _browser.ExecuteScriptAsync(script3)
                    End If
                    If My.Settings.TopSitesAddress.Count > 3 Then
                        Dim script4 = "(function(){ document.getElementsByClassName(  ""card""  )[3].innerHTML = " & quote & "<a class='card-dir table' href='" + topadd.ElementAt(3) + "'><div Class='card-dir-content table-cell'><img src='" + topimg.ElementAt(3) + "' class='mark-img'><span Class='d-block text-truncate float-left'>" + topnam.ElementAt(3) + "</span></div>" & quote & "; })();"
                        _browser.ExecuteScriptAsync(script4)
                    End If
                    If My.Settings.TopSitesAddress.Count > 4 Then
                        Dim script5 = "(function(){ document.getElementsByClassName(  ""card""  )[4].innerHTML = " & quote & "<a class='card-dir table' href='" + topadd.ElementAt(4) + "'><div Class='card-dir-content table-cell'><img src='" + topimg.ElementAt(4) + "' class='mark-img'><span Class='d-block text-truncate float-left'>" + topnam.ElementAt(4) + "</span></div>" & quote & "; })();"
                        _browser.ExecuteScriptAsync(script5)
                    End If
                    If My.Settings.TopSitesAddress.Count > 5 Then
                        Dim script6 = "(function(){ document.getElementsByClassName(  ""card""  )[5].innerHTML = " & quote & "<a class='card-dir table' href='" + topadd.ElementAt(5) + "'><div Class='card-dir-content table-cell'><img src='" + topimg.ElementAt(5) + "' class='mark-img'><span Class='d-block text-truncate float-left'>" + topnam.ElementAt(5) + "</span></div>" & quote & "; })();"
                        _browser.ExecuteScriptAsync(script6)
                    End If
                    If My.Settings.TopSitesAddress.Count > 6 Then
                        Dim script7 = "(function(){ document.getElementsByClassName(  ""card""  )[6].innerHTML = " & quote & "<a class='card-dir table' href='" + topadd.ElementAt(6) + "'><div Class='card-dir-content table-cell'><img src='" + topimg.ElementAt(6) + "' class='mark-img'><span Class='d-block text-truncate float-left'>" + topnam.ElementAt(6) + "</span></div>" & quote & "; })();"
                        _browser.ExecuteScriptAsync(script7)
                    End If
                    If My.Settings.TopSitesAddress.Count > 7 Then
                        Dim script8 = "(function(){ document.getElementsByClassName(  ""card""  )[7].innerHTML = " & quote & "<a class='card-dir table' href='" + topadd.ElementAt(7) + "'><div Class='card-dir-content table-cell'><img src='" + topimg.ElementAt(7) + "' class='mark-img'><span Class='d-block text-truncate float-left'>" + topnam.ElementAt(7) + "</span></div>" & quote & "; })();"
                        _browser.ExecuteScriptAsync(script8)
                    End If
                End If
            End If
            RichTextBox1.Invoke(
            Sub()
                RichTextBox1.Text = "clover://newtab/"
            End Sub)
        End If
        Label2.Invoke(
            Sub()
                Label2.Text = _browser.Address
            End Sub)


        'If _browser.Address.Contains("http://") Then
        '   IconButton1.IconChar = FontAwesome.Sharp.IconChar.GlobeAmericas
        'Else
        '  Try
        '     Dim sslrequest As HttpWebRequest = CType(WebRequest.Create(_browser.Address), HttpWebRequest)
        '      Dim sslresponse As HttpWebResponse = CType(sslrequest.GetResponse(), HttpWebResponse)
        '       Dim cert As X509Certificate = sslrequest.ServicePoint.Certificate
        'Dim cert2 As X509Certificate2 = New X509Certificate2(cert)
        'Dim cn As String = cert2.GetIssuerName()
        ' Dim cedate As String = cert2.GetExpirationDateString()
        '  Dim cpub As String = cert2.GetPublicKeyString()
        '   IconButton1.IconChar = FontAwesome.Sharp.IconChar.Lock
        'IconButton1.IconColor = Color.FromArgb(0, 192, 0)
        'Catch ex As Exception
        '    RichTextBox1.Invoke(
        'Sub()
        '   If _browser.Address.Contains("data:text/html;base64,") And RichTextBox1.Text.Contains("clover://") Then
        '        IconButton1.IconChar = FontAwesome.Sharp.IconChar.Lock
        '         'IconButton1.IconColor = Color.FromArgb(0, 192, 0)
        '      Else
        '           IconButton1.IconChar = FontAwesome.Sharp.IconChar.GlobeAmericas
        '            'IconButton1.IconColor = StyleBrowser(11)
        '         End If
        '      End Sub)
        '   End Try
        'End If

        Button3.Invoke(
            Sub()
                Button3.Visible = True
            End Sub)
        Button6.Invoke(
            Sub()
                Button6.Visible = False
            End Sub)

    End Sub
    Public Sub listview1(s As String)
        'ListBox1.Items.Add(s)
        If My.Settings.TopSitesAddress IsNot Nothing Then
            'If My.Settings.TopSitesAddress.Contains(s) Then
            'My.Settings.TopSitesAddress.Remove(s)
            'End If
            My.Settings.TopSitesAddress.Insert(0, s)
        Else
            My.Settings.TopSitesAddress = New System.Collections.Specialized.StringCollection
            My.Settings.TopSitesAddress.Add(s)
        End If
        My.Settings.Save()
    End Sub
    Public Sub listview2(s As String)
        'ListBox2.Items.Add(s)
        If My.Settings.TopSitesName IsNot Nothing Then
            'My.Settings.TopSitesName.Remove(s)
            My.Settings.TopSitesName.Insert(0, s)
        Else
            My.Settings.TopSitesName = New System.Collections.Specialized.StringCollection
            My.Settings.TopSitesName.Add(s)
        End If
        My.Settings.Save()
    End Sub
    Public Sub listview3(s As String)
        'ListBox3.Items.Add(s)
        If My.Settings.TopSitesImages IsNot Nothing Then
            'My.Settings.TopSitesImages.Remove(s)
            My.Settings.TopSitesImages.Insert(0, s)
        Else
            My.Settings.TopSitesImages = New System.Collections.Specialized.StringCollection
            My.Settings.TopSitesImages.Add(s)
        End If
        My.Settings.Save()
    End Sub
    Public Sub bringlist1()
        'My.Settings.TopSitesAddress.Clear()
        'My.Settings.Save()
        'My.Settings.Reload()
        If My.Settings.TopSitesAddress IsNot Nothing Then
            topadd.Clear()
            topadd = My.Settings.TopSitesAddress.Cast(Of String)().ToList()
        End If
    End Sub
    Public Sub bringlist2()
        'My.Settings.TopSitesName.Clear()
        'My.Settings.Save()
        'My.Settings.Reload()

        If My.Settings.TopSitesName IsNot Nothing Then
            topnam.Clear()
            topnam = My.Settings.TopSitesName.Cast(Of String)().ToList()
        End If
    End Sub
    Public Sub bringlist3()
        'My.Settings.TopSitesImages.Clear()
        'My.Settings.Save()
        'My.Settings.Reload()
        If My.Settings.TopSitesImages IsNot Nothing Then
            topimg.Clear()
            topimg = My.Settings.TopSitesImages.Cast(Of String)().ToList()
        End If
    End Sub
    Public Sub BrowserStatusMessage(sender As Object, e As StatusMessageEventArgs)
        Label1.Invoke(
            Sub()
                Label1.Text = e.Value
            End Sub)
        runtimeactions.urlscontext = e.Value
        If e.Value.Length > 0 Then
            runtimeactions.urls = e.Value
        End If
    End Sub
    Private Sub BrowserTitleChanged(sender As Object, e As TitleChangedEventArgs)
        Me.Invoke(
            Sub()
                Me.Text = e.Title
            End Sub)
        RichTextBox1.Invoke(
            Sub()
                If RichTextBox1.Text.Contains("clover://") Or _browser.Address.Contains("data:text/html;base64,") Then
                    Label2.Invoke(
                    Sub()
                        Label2.Text = RichTextBox1.Text
                    End Sub)
                Else
                    Label2.Invoke(
                    Sub()
                        Label2.Text = _browser.Address
                    End Sub)
                    Try
                        Dim url As Uri = New Uri(_browser.Address)
                        If url.HostNameType = UriHostNameType.Dns Then
                            Dim icons = "http://" & url.Host & "/favicon.ico"
                            If Not runtimeactions.HistoryToday.Contains(_browser.Address) Then
                                runtimeactions.HistoryTodayFavs.Add(icons)
                                runtimeactions.HistoryToday.Add(_browser.Address)
                                runtimeactions.HistoryTodayNames.Add(e.Title)
                            Else
                            End If
                            If My.Settings.TopSitesAddress IsNot Nothing Then
                                If My.Settings.TopSitesAddress.Contains(_browser.Address) Then
                                    Dim count As Integer = (My.Settings.TopSitesAddress.Count - 1)
                                    For i As Integer = 0 To count
                                        If i < My.Settings.TopSitesAddress.Count Then
                                            If My.Settings.TopSitesAddress.Item(i).Contains(_browser.Address) Then
                                                My.Settings.TopSitesAddress.RemoveAt(i)
                                                My.Settings.TopSitesName.RemoveAt(i)
                                                My.Settings.TopSitesImages.RemoveAt(i)
                                                My.Settings.Save()
                                            End If
                                        End If
                                    Next i
                                End If
                            End If
                            'runtimeactions.HistoryTodayFavs.ForEach(AddressOf listview1)
                            'runtimeactions.HistoryTodayNames.ForEach(AddressOf listview2)
                            'runtimeactions.HistoryToday.ForEach(AddressOf listview3)
                            SurroundingSub()
                        End If

                    Catch ex As Exception
                        MsgBox("Error. Clover no pudo conseguir los valores de inicialización.")
                        _browser.Load("clover://newtab/")
                        runtimeactions.actions = ""
                        runtimeactions.urlsnt = ""
                    End Try

                End If
            End Sub)
    End Sub
    Private Sub BrowserAddressChanged(sender As Object, e As AddressChangedEventArgs)

    End Sub
    Private Sub SurroundingSub()
        If My.Settings.TopSitesAddress IsNot Nothing Then
            If My.Settings.TopSitesAddress.Count > 10933 Then
                My.Settings.TopSitesAddress.Clear()
                My.Settings.TopSitesName.Clear()
                My.Settings.TopSitesImages.Clear()
                My.Settings.Save()
            End If
        End If

        runtimeactions.HistoryTodayFavs.ForEach(AddressOf listview3)
        runtimeactions.HistoryTodayNames.ForEach(AddressOf listview2)
        runtimeactions.HistoryToday.ForEach(AddressOf listview1)

        'Dim contador As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)()

        'For Each item As String In runtimeactions.HistoryTodayNames

        'ontador.ContainsKey(item) Then
        'ox1.Items.Count < 8 Then
        'contador(item) += 1
        'ListBox1.Items.Clear()
        'runtimeactions.HistoryToday.ForEach(AddressOf listview1)
        'End If
        'Else
        'If ListBox1.Items.Count < 8 Then
        'contador.Add(item, 1)
        'ListBox1.Items.Clear()
        'runtimeactions.HistoryToday.ForEach(AddressOf listview1)
        'End If
        'End If
        'Next
        'For Each item As KeyValuePair(Of String, Integer) In contador
        'Console.WriteLine(String.Format("{0} - {1}", item.Key, item.Value))
        'Next
    End Sub

    Private Sub browsertab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'My.Settings.TopSitesAddress.Clear()
        'My.Settings.TopSitesName.Clear()
        'My.Settings.TopSitesImages.Clear()
        'My.Settings.Save()

        Me.ContextMenuStrip1.Renderer = New ContextRender()
        Me.ContextMenuStrip2.Renderer = New ContextRender()
        InitializeChromium()
        InitializeContextMenu()
        StyleClover()
        Panel2.BackColor = StyleBrowser(7)
        TextBoxParent.BackColor = StyleBrowser(8)
        Me.BackColor = StyleBrowser(0)
        Button1.BackColor = StyleBrowser(9)
        Button2.BackColor = StyleBrowser(9)
        Button3.BackColor = StyleBrowser(9)
        Button4.BackColor = StyleBrowser(9)
        Button5.BackColor = StyleBrowser(9)
        Button6.BackColor = StyleBrowser(9)
        Button1.FlatAppearance.MouseOverBackColor = StyleBrowser(10)
        Button1.FlatAppearance.MouseDownBackColor = StyleBrowser(10)
        Button1.FlatAppearance.BorderColor = StyleBrowser(7)

        Button2.FlatAppearance.MouseOverBackColor = StyleBrowser(10)
        Button2.FlatAppearance.MouseDownBackColor = StyleBrowser(10)
        Button2.FlatAppearance.BorderColor = StyleBrowser(7)

        Button3.FlatAppearance.MouseOverBackColor = StyleBrowser(10)
        Button3.FlatAppearance.MouseDownBackColor = StyleBrowser(10)
        Button3.FlatAppearance.BorderColor = StyleBrowser(7)

        Button4.FlatAppearance.MouseOverBackColor = StyleBrowser(10)
        Button4.FlatAppearance.MouseDownBackColor = StyleBrowser(10)
        Button4.FlatAppearance.BorderColor = StyleBrowser(7)

        Button5.FlatAppearance.MouseOverBackColor = StyleBrowser(10)
        Button5.FlatAppearance.MouseDownBackColor = StyleBrowser(10)
        Button5.FlatAppearance.BorderColor = StyleBrowser(7)

        Button6.FlatAppearance.MouseOverBackColor = StyleBrowser(10)
        Button6.FlatAppearance.MouseDownBackColor = StyleBrowser(10)
        Button6.FlatAppearance.BorderColor = StyleBrowser(7)

        If My.Settings.IsDarkTheme = False Then
            Button1.BackgroundImage = My.Resources.back
            Button2.BackgroundImage = My.Resources.forward
            Button3.BackgroundImage = My.Resources.reload
            Button4.BackgroundImage = My.Resources.home
            Button6.BackgroundImage = My.Resources._stop
        Else
            Button1.BackgroundImage = My.Resources.wback
            Button2.BackgroundImage = My.Resources.wforward
            Button3.BackgroundImage = My.Resources.wreload
            Button4.BackgroundImage = My.Resources.whome
            Button6.BackgroundImage = My.Resources.wstop
        End If

        IconButton1.IconColor = StyleBrowser(11)
        IconButton2.IconColor = StyleBrowser(11)

        IconButton1.BackColor = StyleBrowser(8)
        IconButton2.BackColor = StyleBrowser(8)

        IconButton1.FlatAppearance.BorderColor = StyleBrowser(8)
        IconButton2.FlatAppearance.BorderColor = StyleBrowser(8)

        TextBoxParent.FlatAppearance.BorderColor = StyleBrowser(8)
        RichTextBox1.BackColor = StyleBrowser(8)
        RichTextBox1.ForeColor = StyleBrowser(13)

        IconButton1.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        IconButton1.FlatAppearance.MouseDownBackColor = StyleBrowser(12)

        IconButton2.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        IconButton2.FlatAppearance.MouseDownBackColor = StyleBrowser(12)

        Label1.ForeColor = StyleBrowser(11)
        Label1.BackColor = StyleBrowser(7)
        Me.ActiveControl = RichTextBox1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If _browser IsNot Nothing AndAlso _browser.CanGoBack Then
            _browser.Back()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If _browser IsNot Nothing AndAlso _browser.CanGoForward Then
            _browser.Forward()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If _browser IsNot Nothing Then
            _browser.Reload()
        End If
    End Sub

    Private Sub Richtextbox1_KeyDown(sender As Object, e As KeyEventArgs) Handles RichTextBox1.KeyDown
        If RichTextBox1.Text = "" Or Panel3.Controls.Count = 0 Then
            Panel3.Visible = False
        Else
            Panel3.Visible = True
        End If

        If e.KeyCode = Keys.Enter Then
            If RichTextBox1.Text.Trim(" ") = "" Then
                Return
            End If
            If _browser IsNot Nothing Then

                If (RichTextBox1.Text.Contains("http://") Or RichTextBox1.Text.Contains("https://") Or RichTextBox1.Text.Contains("clover://") Or RichTextBox1.Text.Contains(".")) Then
                    _browser.Load(RichTextBox1.Text.Trim)
                Else
                    _browser.Load("https://www.google.com/search?client=clover&q=" + RichTextBox1.Text)
                End If
            End If
            Panel3.Visible = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If _browser IsNot Nothing Then
            _browser.Stop()
        End If
    End Sub

    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        Label1.Visible = False
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.Visible = True
    End Sub

    Private Sub RichTextBox1_GotFocus(sender As Object, e As EventArgs) Handles RichTextBox1.GotFocus
        TextBoxParent.FlatAppearance.BorderColor = Color.MediumSeaGreen
        TextBoxParent.FlatAppearance.BorderSize = 2
    End Sub

    Private Sub RichTextBox1_LostFocus(sender As Object, e As EventArgs) Handles RichTextBox1.LostFocus
        TextBoxParent.FlatAppearance.BorderColor = StyleBrowser(8)
        TextBoxParent.FlatAppearance.BorderSize = 1
        'Panel3.Visible = False
    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint
        ButtonBorderRadius(sender, 15)
    End Sub

    Private Sub Button2_Paint(sender As Object, e As PaintEventArgs) Handles Button2.Paint
        ButtonBorderRadius(sender, 15)
    End Sub

    Private Sub Button6_Paint(sender As Object, e As PaintEventArgs) Handles Button6.Paint
        ButtonBorderRadius(sender, 15)
    End Sub

    Private Sub Button4_Paint(sender As Object, e As PaintEventArgs) Handles Button4.Paint
        ButtonBorderRadius(sender, 15)
    End Sub

    Private Sub Button3_Paint(sender As Object, e As PaintEventArgs) Handles Button3.Paint
        ButtonBorderRadius(sender, 15)
    End Sub

    Private Sub Button5_Paint(sender As Object, e As PaintEventArgs) Handles Button5.Paint
        ButtonBorderRadius(sender, 15)
    End Sub

    Private Sub TextBoxParent_Paint(sender As Object, e As PaintEventArgs) Handles TextBoxParent.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If My.Settings.homepage = "" Then
            _browser.Load("google.com")
        Else
            _browser.Load(My.Settings.homepage)
        End If
    End Sub

    Private Sub IconButton1_Paint(sender As Object, e As PaintEventArgs) Handles IconButton1.Paint
        ButtonBorderRadius(sender, 8)
    End Sub

    Private Sub IconButton2_Paint(sender As Object, e As PaintEventArgs) Handles IconButton2.Paint
        ButtonBorderRadius(sender, 8)
    End Sub

    Private Sub ConfigurarElTemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurarElTemaToolStripMenuItem.Click
        settingswindow.Show()
    End Sub

    Private Sub RichTextBox1_DoubleClick(sender As Object, e As EventArgs) Handles RichTextBox1.DoubleClick
        RichTextBox1.SelectAll()
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub SeleccionarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarTodoToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub EmpiezaABuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpiezaABuscarToolStripMenuItem.Click
        If RichTextBox1.Text.Trim(" ") = "" Then
            Return
        End If
        If _browser IsNot Nothing Then

            If (RichTextBox1.Text.Contains("http://") Or RichTextBox1.Text.Contains("https://") Or RichTextBox1.Text.Contains("clover://") Or RichTextBox1.Text.Contains(".")) Then
                _browser.Load(RichTextBox1.Text.Trim)
            Else
                _browser.Load("https://www.google.com/search?client=clover&q=" + RichTextBox1.Text)
            End If
        End If
    End Sub

    Private Sub BorrarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarTodoToolStripMenuItem.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub RichTextBox1_Click(sender As Object, e As EventArgs) Handles RichTextBox1.Click
        If RichTextBox1.Text = "clover://newtab/" Then
            RichTextBox1.Clear()
        End If
    End Sub

    Private Sub ContextMenuStrip1_Paint(sender As Object, e As PaintEventArgs) Handles ContextMenuStrip1.Paint
        'ButtonBorderRadius(sender, 15)
    End Sub

    Private Sub ContextMenuStrip2_Paint(sender As Object, e As PaintEventArgs) Handles ContextMenuStrip2.Paint
        'ButtonBorderRadius(sender, 15)
    End Sub

    Private Sub ListControl1_Paint(sender As Object, e As PaintEventArgs)
        ButtonBorderRadius(sender, 15)
    End Sub
    Private X As Integer = 0
    Private Y As Integer = 0
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        Panel3.Controls.Clear()
        Panel3.BackColor = RichTextBox1.BackColor
        Y = 0
        If Not RichTextBox1.Text = "" Then
            Y = 0
            If My.Settings.TopSitesAddress IsNot Nothing Then
                Dim count As Integer = (My.Settings.TopSitesAddress.Count - 1)
                Dim SearchWords As String
                For a As Integer = 0 To count
                    SearchWords = My.Settings.TopSitesAddress.Item(a)
                    If InStr(SearchWords.ToLower, RichTextBox1.Text.ToLower) Then
                        Dim locationY As Integer = 40 * (Y + 1)
                        If Panel3.Controls.Count = 0 Then
                            locationY = 3
                            Panel3.Size = Button10.Size
                        ElseIf Panel3.Controls.Count = 1 Then
                            locationY = 40
                            Panel3.Size = Button7.Size
                        ElseIf Panel3.Controls.Count = 2 Then
                            locationY = 40 * (Panel3.Controls.Count)
                            Panel3.Size = Button8.Size
                        Else
                            locationY = 40 * (Panel3.Controls.Count)
                            Panel3.Size = Button9.Size
                        End If
                        Dim btn As New Button With {
                            .Parent = Panel3,
                            .Name = a,
                            .Anchor = AnchorStyles.Left + AnchorStyles.Top + AnchorStyles.Right,
                            .Text = My.Settings.TopSitesName.Item(a) + " - " + SearchWords,
                            .Height = 40,
                            .Width = Panel3.Width - 6,
                            .Location = New Point(3, locationY),
                            .BackColor = Panel3.BackColor,
                            .ForeColor = RichTextBox1.ForeColor,
                            .FlatStyle = FlatStyle.Flat,
                            .TextAlign = ContentAlignment.MiddleLeft
                        }

                        Y += 1
                        Panel3.Controls.Add(btn)
                        btn.FlatAppearance.BorderSize = 0
                        btn.Padding = Button7.Padding

                        AddHandler btn.Click, AddressOf HandleDynamicButtonClick
                        'Try
                        'Dim icons = My.Settings.TopSitesImages.Item(a)
                        'Dim req As System.Net.WebRequest = System.Net.HttpWebRequest.Create(icons)
                        'Dim res As System.Net.HttpWebResponse = req.GetResponse()
                        'Dim stream As System.IO.Stream = res.GetResponseStream()
                        'Dim fav = Image.FromStream(stream)
                        'btn.TextAlign = ContentAlignment.MiddleLeft
                        'btn.TextImageRelation = TextImageRelation.ImageBeforeText
                        'btn.ImageAlign = ContentAlignment.MiddleLeft
                        'btn.Image = fav
                        'Catch ex As Exception
                        'btn.Image = Nothing
                        'End Try

                    End If
                Next
            End If
        Else
            Panel3.Visible = False
        End If
    End Sub
    Private Sub HandleDynamicButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        'MsgBox(btn.Name)
        _browser.Load(My.Settings.TopSitesAddress.Item(btn.Name))
        RichTextBox1.Text = My.Settings.TopSitesAddress.Item(btn.Name)
        Panel3.Visible = False
    End Sub
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        ButtonBorderRadius(sender, 15)
        'ControlPaint.DrawBorder(e.Graphics, Panel3.ClientRectangle, Color.Gainsboro, ButtonBorderStyle.Inset)
        Dim w As Integer = 1
        Dim w2 As Integer = CInt(Math.Floor(w / 2))

        e.Graphics.DrawRectangle(New Pen(StyleBrowser(0), w),
                                 New Rectangle(w2, w2,
                                               Panel3.ClientRectangle.Width - w,
                                               Panel3.ClientRectangle.Height - w))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim menuform As New clMenu
        'clMenu.Location = Button11.Location
        'MsgBox(windowbroser.Controls.Item(0).ToString)
        clMenu.Show()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If _browser.Address.Contains("http://") Then
            certificate.Show()
            certificate.Label1.Text = "Esta conexión no es segura"
            certificate.Label1.ForeColor = Color.Red
            certificate.Label2.Text = "Ten cuidado con exponer contraseñas y datos importantes en este sitio"
            certificate.Label2.Visible = True
        Else
            Try
                Dim action As Boolean = False
                Dim sslrequest As HttpWebRequest = CType(WebRequest.Create(_browser.Address), HttpWebRequest)
                Dim sslresponse As HttpWebResponse = CType(sslrequest.GetResponse(), HttpWebResponse)
                Dim cert As X509Certificate = sslrequest.ServicePoint.Certificate
                Dim cert2 As X509Certificate2 = New X509Certificate2(cert)
                'Dim cn As String = cert2.GetIssuerName()
                Dim cedate As String = cert2.GetExpirationDateString()
                Dim cpub As String = cert2.GetPublicKeyString()
                certificate.Show()
                certificate.Label1.Text = "Conexión segura"
                certificate.Label1.ForeColor = Color.FromArgb(0, 192, 0)
                certificate.Label2.Text = "La información que envíes por este sitio es privada"
                certificate.Label2.Visible = True

            Catch ex As Exception
                If _browser.Address.Contains("data:text/html;base64,") And Label2.Text.Contains("clover://") Then
                    certificate.Show()
                    certificate.Label1.Text = "Estás viendo una página segura de Clover"
                    certificate.Label1.ForeColor = StyleBrowser(11)
                Else
                    certificate.Show()
                    certificate.Label1.Text = "Esta conexión no es segura"
                    certificate.Label1.ForeColor = Color.Red
                    certificate.Label2.Text = "Ten cuidado con exponer contraseñas y datos importantes en este sitio"
                    certificate.Label2.Visible = True
                End If
            End Try
        End If

    End Sub

    Private Sub Label1_Paint(sender As Object, e As PaintEventArgs) Handles Label1.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub Label1_TextChanged(sender As Object, e As EventArgs) Handles Label1.TextChanged
        If Label1.Text = "" Then
            Label1.Visible = False
        Else
            Label1.Visible = True
        End If
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        bookmarks.Show()
    End Sub
End Class

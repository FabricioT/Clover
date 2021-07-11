Imports CefSharp
Imports CefSharp.WinForms
Imports System
Imports System.Net
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Public Class CloverMenuHandler
    Implements IContextMenuHandler

    Public Sub OnBeforeContextMenu(ByVal browserControl As IWebBrowser, ByVal browser As IBrowser, ByVal frame As IFrame, ByVal parameters As IContextMenuParams, ByVal model As IMenuModel) Implements IContextMenuHandler.OnBeforeContextMenu
        model.Clear()
        If runtimeactions.urlscontext IsNot Nothing Then
            If runtimeactions.urlscontext.Length > 0 Then
                model.AddItem(1, "Abrir enlace en nueva pestaña")
                model.AddItem(CefMenuCommand.CustomLast, "Abrir enlace en nueva ventana")
                model.AddSeparator()
            End If
        End If
        If parameters.HasImageContents = True Then
            model.AddItem(CefMenuCommand.UserFirst, "Guardar imagen como...")
            model.AddItem(3, "Abrir imagen en una nueva pestaña")
            model.AddSeparator()
        End If
        model.AddItem(CefMenuCommand.Back, "Atrás")
        model.SetEnabled(CefMenuCommand.Back, browser.CanGoBack)
        model.AddItem(CefMenuCommand.Forward, "Adelante")
        model.SetEnabled(CefMenuCommand.Forward, browser.CanGoForward)
        model.AddItem(CefMenuCommand.Reload, "Actualizar")
        model.AddSeparator()
        If parameters.LinkUrl = "" Then
        Else
            model.AddItem(2, "Copiar dirección de enlace")
            model.AddSeparator()
        End If
        model.AddItem(CefMenuCommand.Copy, "Copiar")
        model.SetEnabled(CefMenuCommand.Copy, String.IsNullOrWhiteSpace(parameters.SelectionText) = False)
        model.AddItem(CefMenuCommand.Cut, "Cortar")
        model.SetEnabled(CefMenuCommand.Cut, String.IsNullOrWhiteSpace(parameters.SelectionText) = False)
        model.AddItem(CefMenuCommand.Paste, "Pegar")
        If frame.Url.Contains(".txt") Or frame.Url.Contains(".js") Or frame.Url.Contains(".css") Then
            model.AddItem(CefMenuCommand.SelectAll, "Seleccionar todo")
        End If
        model.AddSeparator()
        model.AddItem(CefMenuCommand.ViewSource, "Ver código fuente")
        model.AddItem(CefMenuCommand.CustomFirst, "Abrir el inspector de desarrollo")
        model.AddItem(Nothing, "Acerca de Clover")
    End Sub
    Public WithEvents Download As WebClient
    Public Function OnContextMenuCommand(ByVal browserControl As IWebBrowser, ByVal browser As IBrowser, ByVal frame As IFrame, ByVal parameters As IContextMenuParams, ByVal commandId As CefMenuCommand, ByVal eventFlags As CefEventFlags) As Boolean Implements IContextMenuHandler.OnContextMenuCommand
        If commandId = 1 Then
            runtimeactions.actions = "newtabaddress"
            Return True
        End If
        If commandId = CefMenuCommand.CustomLast Then
            runtimeactions.actions = "newwindowaddress"
            Return True
        End If
        If commandId = CefMenuCommand.CustomFirst Then
            browser.ShowDevTools()
        End If
        If commandId = 2 Then
            Clipboard.SetText(parameters.LinkUrl)
            Return True
        End If
        If commandId = 3 Then
            runtimeactions.actions = "newtabsource"
            runtimeactions.urlsnt = parameters.SourceUrl
            Return True
        End If
        If commandId = 4 Then
            'Dim script = "var url='" + frame.Url + "',xmlhttp; if('XMLHttpRequest' in window)xmlhttp=new XMLHttpRequest(); if('ActiveXObject' in window)xmlhttp=new ActiveXObject('Msxml2.XMLHTTP'); xmlhttp.open('GET',url,true); xmlhttp.onreadystatechange=function() { if(xmlhttp.readyState==4) { document.body.innerHTML = ''; document.body.innerHTML = '<figure><pre><code>' + xmlhttp.responseText + '</code></pre></figure>'; } }; xmlhttp.send(null);"
            'frame.ExecuteJavaScriptAsync(script)
            'MsgBox(runtimeactions.urlsnt & runtimeactions.actions)
            Return True
        End If
        If commandId = CefMenuCommand.UserFirst Then
            'browser.GetHost.StartDownload(parameters.SourceUrl)
            Dim savefile As New SaveFileDialog
            savefile.Filter = "Todos los archivos (*.*)|*.*"
            If parameters.SourceUrl.Contains(".jpg") Then
                savefile.Filter = "Imagen JPG [*.jpg*]|*.jpg*|Todos los archivos (*.*)|*.*"
            End If
            If parameters.SourceUrl.Contains(".jpeg") Then
                savefile.Filter = "Imagen JPEG [*.jpg*]|*.jpg*|Todos los archivos (*.*)|*.*"
            End If
            If parameters.SourceUrl.Contains(".png") Then
                savefile.Filter = "Imagen PNG[*.png*]|*.png*|Todos los archivos (*.*)|*.*"
            End If
            If parameters.SourceUrl.Contains(".svg") Then
                savefile.Filter = "Archivo SVG[*.svg*]|*.svg*|Todos los archivos (*.*)|*.*"
            End If
            If parameters.SourceUrl.Contains(".bmp") Then
                savefile.Filter = "Bit map image (*.bmp)|*.bmp|Todos los archivos (*.*)|*.*"
            End If
            If parameters.SourceUrl.Contains(".gif") Then
                savefile.Filter = "Bit map image (*.gif)|*.gif|Todos los archivos (*.*)|*.*"
            End If
            If parameters.SourceUrl.Contains(".mp3") Then
                savefile.Filter = "Archivos de Música y Sonido MP3 [*.mp3*]|*.mp3*|Todos los archivos (*.*)|*.*"
            End If
            If parameters.SourceUrl.Contains(".wave") Then
                savefile.Filter = "Archivos de Música WAVE[*.wav*]|*.wav*|Todos los archivos (*.*)|*.*"
            End If
            If parameters.SourceUrl.Contains(".wmv") Then
                savefile.Filter = "Archivos de Video[*.wmv*]|*.wmv*|Todos los archivos (*.*)|*.*"
            End If
            If parameters.SourceUrl.Contains(".flv") Then
                savefile.Filter = "Flash video Files [*.flv*]|*.flv*|Todos los archivos (*.*)|*.*"
            End If
            If parameters.SourceUrl.Contains(".mp4") Then
                savefile.Filter = "Archivo de video MP4 [*.mp4*]|*.mp4*|Todos los archivos (*.*)|*.*"
            End If
            If parameters.SourceUrl.Contains(".mov") Then
                savefile.Filter = "Archivo de video QuickTime [*.mov*]|*.mov*|Todos los archivos (*.*)|*.*"
            End If
            'Dim FileInfo As New FileInfo(parameters.SourceUrl)
            'savefile.FileName = FileInfo.Name + FileInfo.Extension
            savefile.FileName = GetFileName(parameters.SourceUrl)
            Dim result = savefile.ShowDialog()
            If result = DialogResult.OK Then
                Download = New WebClient
                Download.DownloadFile((parameters.SourceUrl), savefile.FileName)
            End If

        End If
        If commandId = CefMenuCommand.ViewSource Then
            'Dim sourcecode = frame.GetSourceAsync
            'Dim sourcecode = "Source of\" + frame.Url + "\"
            'browser.MainFrame.ViewSource()
            'runtimeactions.actions = "newtabaddress"
            'runtimeactions.urlsnt = sourcecode
        End If
        If commandId = Nothing Then
            AboutClover.Show()
        End If
        Return False
    End Function
    Private Function GetFileName(ByVal path As String) As String
        Dim _filename As String = System.IO.Path.GetFileName(path)
        _filename += System.IO.Path.GetExtension(path)
        Return _filename
    End Function
    Public Sub OnContextMenuDismissed(ByVal browserControl As IWebBrowser, ByVal browser As IBrowser, ByVal frame As IFrame) Implements IContextMenuHandler.OnContextMenuDismissed
    End Sub

    Public Function RunContextMenu(ByVal browserControl As IWebBrowser, ByVal browser As IBrowser, ByVal frame As IFrame, ByVal parameters As IContextMenuParams, ByVal model As IMenuModel, ByVal callback As IRunContextMenuCallback) As Boolean Implements IContextMenuHandler.RunContextMenu
        Return False
    End Function
End Class

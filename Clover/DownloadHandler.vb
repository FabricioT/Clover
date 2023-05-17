Imports CefSharp
Imports CefSharp.WinForms
Imports System
Imports System.Net
Imports System.Text
Imports System.Windows.Forms
Imports System.IO

Public Class DownloadHandler
    Implements IDownloadHandler
    Private progressing As CircularProgressBar.CircularProgressBar
    Private DownFileName As Label
    Private DownFileInfo As Label
    Private PanelDownloads As Panel
    Private PanelBrowser As Panel
    Private ButtonSM As Button
    Private ButtonLG As Button
    Private IconItem As FontAwesome.Sharp.IconPictureBox

    Public Event OnBeforeDownloadFired As EventHandler(Of DownloadItem)
    Public Event OnDownloadUpdatedFired As EventHandler(Of DownloadItem)
    'Dim frm As Form = runtimeactions.LastFormActive
    'Dim pan As Panel = frm.Controls("PanelDownloads")
    'Dim pan As Panel = windowbroser.PanelDownloads
    'Dim progressing As New CircularProgressBar.CircularProgressBar


    Public Sub New(ByVal bar As CircularProgressBar.CircularProgressBar, label1 As Label, label2 As Label, Panels As Panel, panelbr As Panel, button1 As Button, button2 As Button, iconp As FontAwesome.Sharp.IconPictureBox)
        progressing = bar
        DownFileName = label1
        DownFileInfo = label2
        PanelDownloads = Panels
        PanelBrowser = panelbr
        ButtonSM = button1
        ButtonLG = button2
        IconItem = iconp

    End Sub

    Public Sub Types(ByVal TheType As String)
        Dim typeFile As String = TheType
        If typeFile.Contains("image") Then
            IconItem.IconChar = FontAwesome.Sharp.IconChar.Image
        ElseIf typeFile.Contains("audio") Then
            IconItem.IconChar = FontAwesome.Sharp.IconChar.FileAudio
        ElseIf typeFile.Contains("text") Then
            IconItem.IconChar = FontAwesome.Sharp.IconChar.FileCode
        ElseIf typeFile.Contains("application") Then
            IconItem.IconChar = FontAwesome.Sharp.IconChar.FileArchive
        ElseIf typeFile.Contains("application/vnd.openxmlformats-officedocument.presentationml.presentation") Or typeFile.Contains("application/vnd.ms-powerpoint") Then
            IconItem.IconChar = FontAwesome.Sharp.IconChar.FilePowerpoint
        ElseIf typeFile.Contains("application/vnd.openxmlformats-officedocument.wordprocessingml.document") Or typeFile.Contains("application/msword") Then
            IconItem.IconChar = FontAwesome.Sharp.IconChar.FileWord
        ElseIf typeFile.Contains("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet") Or typeFile.Contains("application/vnd.ms-excel") Then
            IconItem.IconChar = FontAwesome.Sharp.IconChar.FileExcel
        ElseIf typeFile.Contains("application/pdf") Then
            IconItem.IconChar = FontAwesome.Sharp.IconChar.FilePdf
        ElseIf typeFile.Contains("text/plain") Then
            IconItem.IconChar = FontAwesome.Sharp.IconChar.FileAlt
        ElseIf typeFile.Contains("video") Then
            IconItem.IconChar = FontAwesome.Sharp.IconChar.FileVideo
        ElseIf typeFile.Contains("application/rtf") Then
            IconItem.IconChar = FontAwesome.Sharp.IconChar.FileAlt
        ElseIf typeFile.Contains("application/x-httpd-php") Then
            IconItem.IconChar = FontAwesome.Sharp.IconChar.FileCode
        ElseIf typeFile.Contains("font") Then
            IconItem.IconChar = FontAwesome.Sharp.IconChar.Font
        Else
            IconItem.IconChar = FontAwesome.Sharp.IconChar.File
        End If
    End Sub

    Public Sub OnBeforeDownload(ByVal chromiumWebBrowser As IWebBrowser, ByVal browser As IBrowser, ByVal downloadItem As DownloadItem, ByVal callback As IBeforeDownloadCallback)
        RaiseEvent OnBeforeDownloadFired(Me, downloadItem)

        If callback.IsDisposed = False Then

            Using callback

                If My.Settings.AskforDownloads = False Then
                    Dim DownsPath As String
                    If My.Settings.DownloadsFolder = "" Then
                        DownsPath = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
                    Else
                        DownsPath = My.Settings.DownloadsFolder
                    End If
                    Dim DownloadsFolderPath As String = DownsPath
                    callback.Continue(Path.Combine(DownloadsFolderPath, downloadItem.SuggestedFileName), False)
                    PanelBrowser.Height = ButtonSM.Height
                    progressing.Value = 0
                    DownFileName.Text = downloadItem.SuggestedFileName
                    DownFileName.Visible = True
                    progressing.Visible = True
                    Types(downloadItem.MimeType)
                Else
                    callback.Continue(downloadItem.SuggestedFileName, True)
                    PanelBrowser.Height = ButtonSM.Height
                    progressing.Value = 0
                    DownFileName.Text = downloadItem.SuggestedFileName
                    DownFileName.Visible = True
                    progressing.Visible = True
                    Types(downloadItem.MimeType)
                End If

                'frm.Controls("TabControl1").Height = frm.Controls("Button7").Height
                'Dim labelFileName As Label = pan.Controls("label6")
                'labelFileName.Text = downloadItem.SuggestedFileName
            End Using
        End If
    End Sub

    Public Sub OnDownloadUpdated(ByVal chromiumWebBrowser As IWebBrowser, ByVal browser As IBrowser, ByVal downloadItem As DownloadItem, ByVal callback As IDownloadItemCallback)
        RaiseEvent OnDownloadUpdatedFired(Me, downloadItem)

        If downloadItem.IsValid Then

            If downloadItem.IsInProgress AndAlso (downloadItem.PercentComplete <> 0) Then
                Console.WriteLine("Current Download Speed: {0} bytes ({1}%)", downloadItem.CurrentSpeed, downloadItem.PercentComplete)
                Debug.Print("{0}/{1} bytes", downloadItem.ReceivedBytes, downloadItem.TotalBytes)
                progressing.Maximum = downloadItem.TotalBytes
                progressing.Value = downloadItem.ReceivedBytes
                'DownFileName.Text = downloadItem.SuggestedFileName
                DownFileInfo.Text = FormatBytes(downloadItem.ReceivedBytes) & "/" & FormatBytes(downloadItem.TotalBytes) & " a " & FormatBytes(downloadItem.CurrentSpeed) & "/s"
            End If

            If downloadItem.IsComplete Then
                Console.WriteLine("The download has been finished !")
                DownFileInfo.Text = "Descarga finalizada"
            End If
        End If
    End Sub

    Public Sub IDownloadHandler_OnBeforeDownload(chromiumWebBrowser As IWebBrowser, browser As IBrowser, downloadItem As DownloadItem, callback As IBeforeDownloadCallback) Implements IDownloadHandler.OnBeforeDownload
        RaiseEvent OnBeforeDownloadFired(Me, downloadItem)

        If callback.IsDisposed = False Then

            Using callback

                If My.Settings.AskforDownloads = False Then
                    Dim DownsPath As String
                    If My.Settings.DownloadsFolder = "" Then
                        DownsPath = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
                    Else
                        DownsPath = My.Settings.DownloadsFolder
                    End If
                    Dim DownloadsFolderPath As String = DownsPath
                    callback.Continue(Path.Combine(DownloadsFolderPath, downloadItem.SuggestedFileName), False)
                    PanelBrowser.Height = ButtonSM.Height
                    progressing.Value = 0
                    DownFileName.Text = downloadItem.SuggestedFileName
                    DownFileName.Visible = True
                    progressing.Visible = True
                    Types(downloadItem.MimeType)
                Else
                    callback.Continue(downloadItem.SuggestedFileName, True)
                    PanelBrowser.Height = ButtonSM.Height
                    progressing.Value = 0
                    DownFileName.Text = downloadItem.SuggestedFileName
                    DownFileName.Visible = True
                    progressing.Visible = True
                    Types(downloadItem.MimeType)
                End If

            End Using
        End If
        'Throw New NotImplementedException()
    End Sub

    Public Sub IDownloadHandler_OnDownloadUpdated(chromiumWebBrowser As IWebBrowser, browser As IBrowser, downloadItem As DownloadItem, callback As IDownloadItemCallback) Implements IDownloadHandler.OnDownloadUpdated
        'Throw New NotImplementedException()

        If downloadItem.IsValid Then

            If downloadItem.IsInProgress AndAlso (downloadItem.PercentComplete <> 0) Then
                Console.WriteLine("Current Download Speed: {0} bytes ({1}%)", downloadItem.CurrentSpeed, downloadItem.PercentComplete)
                Debug.Print("{0}/{1} bytes", downloadItem.ReceivedBytes, downloadItem.TotalBytes)
                progressing.Maximum = downloadItem.TotalBytes
                progressing.Value = downloadItem.ReceivedBytes
                'DownFileName.Text = downloadItem.SuggestedFileName
                DownFileInfo.Text = FormatBytes(downloadItem.ReceivedBytes) & "/" & FormatBytes(downloadItem.TotalBytes) & " a " & FormatBytes(downloadItem.CurrentSpeed) & "/s"
            End If

            If downloadItem.IsComplete Then
                Console.WriteLine("The download has been finished !")
                DownFileInfo.Text = "Descarga finalizada"
            End If
        End If
    End Sub

    Public Function CanDownload(chromiumWebBrowser As IWebBrowser, browser As IBrowser, url As String, requestMethod As String) As Boolean Implements IDownloadHandler.CanDownload
        'Throw New NotImplementedException()
        Return True
    End Function
End Class


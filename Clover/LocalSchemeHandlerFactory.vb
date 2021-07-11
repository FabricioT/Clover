Imports System.IO
Imports CefSharp
Imports System
Imports System.Text
Imports System.Windows.Forms
Imports System.Web
Imports System.Net
Public Class LocalSchemeHandlerFactory
    Implements ISchemeHandlerFactory

    Public Const SchemeName As String = "clover"
    Private Shared ResourceDictionary As IDictionary(Of String, String)
    Public Sub LocalSchemeHandlerFactory()
        Dim ResourceDictionary = New Dictionary(Of String, String) From {
        {"/newtab.html", My.Resources.newtab1},
        {"/viewsource.html", My.Resources.viewsource}
        }
    End Sub
    Public Function Create(browser As IBrowser, frame As IFrame, schemeName As String, request As IRequest) As IResourceHandler Implements ISchemeHandlerFactory.Create
        'Dim uri = New Uri(request.Url)
        'Dim fileName = uri.AbsolutePath
        'Dim resource As String
        'LocalSchemeHandlerFactory()
        'If ResourceDictionary.TryGetValue(fileName, resource) AndAlso Not String.IsNullOrEmpty(resource) Then
        'Dim fileExtension = Path.GetExtension(fileName)
        'Return ResourceHandler.FromString(resource, , mimeType:=Cef.GetMimeType(fileExtension))
        'Else
        'MsgBox("error mi llave")
        'End If
        'Return Nothing

        If schemeName = "clover" Then
            Dim uri = New Uri(request.Url)
            Dim fileName = uri.Authority
            Dim newtab As String = My.Resources.newtab1
            Dim viewsource As String = My.Resources.viewsource
            Dim base64EncodedHtml1 = Convert.ToBase64String(Encoding.UTF8.GetBytes(newtab))
            Dim base64EncodedHtml2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(viewsource))
            If fileName = "newtab" Then
                browser.MainFrame.LoadUrl("data:text/html;base64," + base64EncodedHtml1)
                Return ResourceHandler.FromString("data:text/html;base64," + base64EncodedHtml1)
            End If
            If fileName = "viewsource" Then
                    browser.MainFrame.LoadUrl("data:text/html;base64," + base64EncodedHtml2)
                    Return ResourceHandler.FromString("data:text/html;base64," + base64EncodedHtml2)
                End If
            End If
        Return New ResourceHandler()
    End Function
End Class

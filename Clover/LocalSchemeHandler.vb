Imports CefSharp
Imports System.IO
Imports System.Object
Imports CefSharp.CefCustomScheme
Imports CefSharp.Handler.RequestHandler
Imports CefSharp.Callback

Public Class LocalSchemeHandler
    Inherits ResourceHandler
    Implements IResourceHandler

    Private disposedValue As Boolean

    Public Sub GetResponseHeaders(response As IResponse, ByRef responseLength As Long, ByRef redirectUrl As String) Implements IResourceHandler.GetResponseHeaders
        Throw New NotImplementedException()
    End Sub

    Public Sub Cancel() Implements IResourceHandler.Cancel
        Throw New NotImplementedException()
    End Sub

    Public Function Open(request As IRequest, ByRef handleRequest As Boolean, callback As ICallback) As Boolean Implements IResourceHandler.Open
        Throw New NotImplementedException()
    End Function
    Public Overrides Function ProcessRequestAsync(ByVal request As IRequest, ByVal callback As ICallback) As CefReturnValue
        Return False
    End Function
    Public Function ProcessRequest(request As IRequest, callback As ICallback) As Boolean Implements IResourceHandler.ProcessRequest
        Throw New NotImplementedException()
    End Function

    Public Function Skip(bytesToSkip As Long, ByRef bytesSkipped As Long, callback As IResourceSkipCallback) As Boolean Implements IResourceHandler.Skip
        Throw New NotImplementedException()
    End Function

    Public Function Read(dataOut As Stream, ByRef bytesRead As Integer, callback As IResourceReadCallback) As Boolean Implements IResourceHandler.Read
        Throw New NotImplementedException()
    End Function

    Public Function ReadResponse(dataOut As Stream, ByRef bytesRead As Integer, callback As ICallback) As Boolean Implements IResourceHandler.ReadResponse
        Throw New NotImplementedException()
    End Function

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: eliminar el estado administrado (objetos administrados)
            End If

            ' TODO: liberar los recursos no administrados (objetos no administrados) y reemplazar el finalizador
            ' TODO: establecer los campos grandes como NULL
            disposedValue = True
        End If
    End Sub

    ' ' TODO: reemplazar el finalizador solo si "Dispose(disposing As Boolean)" tiene código para liberar los recursos no administrados
    ' Protected Overrides Sub Finalize()
    '     ' No cambie este código. Coloque el código de limpieza en el método "Dispose(disposing As Boolean)".
    '     Dispose(disposing:=False)
    '     MyBase.Finalize()
    ' End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        ' No cambie este código. Coloque el código de limpieza en el método "Dispose(disposing As Boolean)".
        Dispose(disposing:=True)
        GC.SuppressFinalize(Me)
    End Sub
End Class
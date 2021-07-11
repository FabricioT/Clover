Imports System.ComponentModel

Public Class TransparentPanel
    Inherits Panel

    Private Const WS_EX_TRANSPARENT As Integer = &H20

    Public Sub New()
        SetStyle(ControlStyles.Opaque, True)
    End Sub

    Private opacityField As Integer = 50

    <DefaultValue(50)>
    Public Property Opacity As Integer
        Get
            Return opacityField
        End Get
        Set(ByVal value As Integer)
            If value < 0 OrElse value > 100 Then Throw New ArgumentException("value must be between 0 and 100")
            opacityField = value
        End Set
    End Property

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or WS_EX_TRANSPARENT
            Return cp
        End Get
    End Property

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Using brush = New SolidBrush(Color.FromArgb(opacityField * 255 / 100, Me.BackColor))
            e.Graphics.FillRectangle(brush, Me.ClientRectangle)
        End Using

        MyBase.OnPaint(e)
    End Sub
End Class

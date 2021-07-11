Imports System.Drawing.Drawing2D

Public Class ContextRender
    Inherits ToolStripProfessionalRenderer

    Public Sub New()
        MyBase.New(New ColorsTable())
    End Sub

    Protected Overrides Sub OnRenderArrow(ByVal e As ToolStripArrowRenderEventArgs)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim r = New Rectangle(e.ArrowRectangle.Location, e.ArrowRectangle.Size)
        r.Inflate(-2, -6)
        e.Graphics.DrawLines(Pens.Black, New Point() {New Point(r.Left, r.Top), New Point(r.Right, r.Top + r.Height / 2), New Point(r.Left, r.Top + r.Height)})
    End Sub

    Protected Overrides Sub OnRenderItemCheck(ByVal e As ToolStripItemImageRenderEventArgs)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim r = New Rectangle(e.ImageRectangle.Location, e.ImageRectangle.Size)
        r.Inflate(-4, -6)
        e.Graphics.DrawLines(Pens.Black, New Point() {New Point(r.Left, r.Bottom - r.Height / 2), New Point(r.Left + r.Width / 3, r.Bottom), New Point(r.Right, r.Top)})
    End Sub

    Protected Overrides Sub OnRenderToolStripBorder(e As ToolStripRenderEventArgs)
        'MyBase.ColorTable.ToolStripBorder.ToArgb()
    End Sub

    Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
        MyBase.OnRenderMenuItemBackground(e)
    End Sub
End Class

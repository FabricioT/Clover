Public Class ListControl
    Public Sub Add(c As Control)
        flpListBox.Controls.Add(c)
        SetupAnchors()
    End Sub

    Public Sub Remove(name As String)
        Dim c As Control = flpListBox.Controls(name)
        flpListBox.Controls.Remove(c)
        c.Dispose()
        SetupAnchors()
    End Sub

    Public Sub Clear()
        Do
            If flpListBox.Controls.Count = 0 Then Exit Do
            Dim c As Control = flpListBox.Controls(0)
            flpListBox.Controls.Remove(c)
            c.Dispose()
        Loop
    End Sub

    Public ReadOnly Property Count() As Integer
        Get
            Return flpListBox.Controls.Count
        End Get
    End Property
    Private Sub SetupAnchors()
        If flpListBox.Controls.Count > 0 Then
            For i = 0 To flpListBox.Controls.Count - 1
                Dim c As Control = flpListBox.Controls(i)
                If i = 0 Then
                    ' Its the first control, all subsequent controls follow
                    ' the anchor behavior of this control.
                    c.Anchor = AnchorStyles.Left + AnchorStyles.Top
                    c.Width = flpListBox.Width - SystemInformation.VerticalScrollBarWidth
                Else
                    ' It is not the first control. Set its anchor to
                    ' copy the width of the first control in the list.
                    c.Anchor = AnchorStyles.Left + AnchorStyles.Top + AnchorStyles.Right
                End If
            Next
        End If
    End Sub
    Private Sub flpListBox_Layout(sender As Object, e As System.Windows.Forms.LayoutEventArgs) Handles flpListBox.Layout
        If flpListBox.Controls.Count Then
            flpListBox.Controls(0).Width = flpListBox.Size.Width - SystemInformation.VerticalScrollBarWidth
        End If
    End Sub
End Class

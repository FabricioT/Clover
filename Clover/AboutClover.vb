Public NotInheritable Class AboutClover
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

    Private Sub AboutClover_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.Close()
    End Sub

    Private Sub OKButton_Paint(sender As Object, e As PaintEventArgs) Handles OKButton.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub AboutClover_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establezca el título del formulario.
        Me.Activate()
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("Acerca de {0}", ApplicationTitle)
        LabelProductName.Text = My.Application.Info.ProductName
        LabelVersion.Text = String.Format("Versión {0}", My.Application.Info.Version.ToString)
        LabelCopyright.Text = My.Application.Info.Copyright
        'LabelCompanyName.Text = My.Application.Info.CompanyName
        Dim thisversion As String = "13"
        RichTextBox1.Text = My.Application.Info.Description & vbCrLf & "Este navegador fue posible gracias al proyecto Chromium de código abierto en su versión para Visual Studio, CEFSharp. https://cefsharp.github.io/" & vbCrLf & vbCrLf & "Desarrolladores y colaboradores:" & vbCrLf & "Fabricio Trujillo, 'Arctic', Steven Santos, José Trujillo." & vbCrLf & vbCrLf & "Novedades de esta versión:" & vbCrLf & "https://duographics.com.ec/clover/?p=overview&v=" & thisversion
        Me.BackColor = StyleBrowser(14)
        Me.ForeColor = StyleBrowser(11)
        OKButton.BackColor = StyleBrowser(8)
        OKButton.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        OKButton.FlatAppearance.MouseDownBackColor = StyleBrowser(12)

        Button1.BackColor = StyleBrowser(8)
        Button1.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        Button1.FlatAppearance.MouseDownBackColor = StyleBrowser(12)

        Button2.BackColor = StyleBrowser(8)
        Button2.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        Button2.FlatAppearance.MouseDownBackColor = StyleBrowser(12)

        Button3.BackColor = StyleBrowser(8)
        Button3.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        Button3.FlatAppearance.MouseDownBackColor = StyleBrowser(12)

        RichTextBox1.BackColor = StyleBrowser(14)
        RichTextBox1.ForeColor = StyleBrowser(11)
        Me.ContextMenuStrip1.Renderer = New ContextRender()
    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub Button2_Paint(sender As Object, e As PaintEventArgs) Handles Button2.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub RichTextBox1_SelectionChanged(sender As Object, e As EventArgs) Handles RichTextBox1.SelectionChanged
        If RichTextBox1.SelectionLength = 0 Then
            ContextMenuStrip1.Items(0).Enabled = False
        Else
            ContextMenuStrip1.Items(0).Enabled = True
        End If
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        Clipboard.SetText(RichTextBox1.SelectedText)
    End Sub

    Private Sub Button3_Paint(sender As Object, e As PaintEventArgs) Handles Button3.Paint
        ButtonBorderRadius(sender, 10)
    End Sub
End Class

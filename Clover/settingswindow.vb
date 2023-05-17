Imports System.IO
Public Class settingswindow


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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Classic.Click
        Dim thisbtn As Button = DirectCast(sender, Button)
        My.Settings.StyleBrowser0 = Color.FromArgb(216, 214, 211) 'Backtab color and newtab button
        My.Settings.StyleBrowser1 = Color.FromArgb(186, 185, 183) 'BorderColor active tab
        My.Settings.StyleBrowser2 = Color.FromArgb(216, 214, 211) 'BorderColor disabled tabs
        My.Settings.StyleBrowser3 = Color.FromArgb(64, 64, 64) 'Font color of tabs and close button
        My.Settings.StyleBrowser4 = Color.DimGray 'Font color of disabled tabs and close button
        My.Settings.StyleBrowser5 = Color.FromArgb(238, 236, 233) 'Tabs color
        My.Settings.StyleBrowser6 = Color.FromArgb(216, 214, 211) 'Disabled tabs color
        My.Settings.StyleBrowser7 = Color.FromArgb(238, 236, 233) 'Background panel
        My.Settings.StyleBrowser8 = Color.FromArgb(255, 255, 255) 'TextBox back color and Icon Buttons back color
        My.Settings.StyleBrowser9 = Color.Transparent 'Buttons back color
        My.Settings.StyleBrowser10 = Color.FromArgb(229, 226, 222) 'Buttons hover and active
        My.Settings.StyleBrowser11 = Color.FromArgb(86, 75, 68) 'Icon Buttons font color
        My.Settings.StyleBrowser12 = Color.FromArgb(229, 226, 222) 'Icon Buttons hover and active
        My.Settings.StyleBrowser13 = Color.FromArgb(86, 75, 68) 'Search text
        My.Settings.StyleBrowser14 = Color.FromArgb(255, 255, 255) 'Forms
        My.Settings.StyleBrowser15 = Color.FromArgb(249, 249, 251) 'NewTabPage BackgroundColor
        My.Settings.IsDarkTheme = False
        My.Settings.Mytheme = thisbtn.Name
        My.Settings.Save()

        StyleClover()
        runtimeactions.actions = "changetheme"

        For I As Integer = 0 To FlowLayoutPanel1.Controls.Count - 1
            Dim controlsFound = FlowLayoutPanel1.Controls.Item(I)
            If TypeOf controlsFound Is Button Then
                Dim buttonchange As Button = FlowLayoutPanel1.Controls.Item(I)
                buttonchange.FlatAppearance.BorderColor = StyleBrowser(8)
                buttonchange.FlatAppearance.BorderSize = 0
            End If
        Next
        thisbtn.FlatAppearance.BorderColor = Color.MediumSeaGreen
        thisbtn.FlatAppearance.BorderSize = 2
        Styling()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles DarkClover.Click
        Dim thisbtn As Button = DirectCast(sender, Button)
        My.Settings.StyleBrowser0 = Color.FromArgb(33, 39, 44) 'Backtab color and newtab button
        My.Settings.StyleBrowser1 = Color.FromArgb(10, 12, 12) 'BorderColor active tab
        My.Settings.StyleBrowser2 = Color.FromArgb(33, 39, 44) 'BorderColor disabled tabs
        My.Settings.StyleBrowser3 = Color.FromArgb(255, 255, 255) 'Font color of tabs and close button
        My.Settings.StyleBrowser4 = Color.FromArgb(133, 153, 166) 'Font color of disabled tabs and close button
        My.Settings.StyleBrowser5 = Color.FromArgb(49, 61, 68) 'Tabs color
        My.Settings.StyleBrowser6 = Color.FromArgb(33, 39, 44) 'Disabled tabs color
        My.Settings.StyleBrowser7 = Color.FromArgb(49, 61, 68) 'Background panel
        My.Settings.StyleBrowser8 = Color.FromArgb(36, 44, 50) 'TextBox back color and Icon Buttons back color
        My.Settings.StyleBrowser9 = Color.Transparent 'Buttons back color
        My.Settings.StyleBrowser10 = Color.FromArgb(59, 72, 80) 'Buttons hover and active
        My.Settings.StyleBrowser11 = Color.FromArgb(184, 196, 209) 'Icon Buttons font color
        My.Settings.StyleBrowser12 = Color.FromArgb(48, 58, 65) 'Icon Buttons hover and active
        My.Settings.StyleBrowser13 = Color.FromArgb(160, 172, 184) 'Search text
        My.Settings.StyleBrowser14 = Color.FromArgb(51, 67, 77) 'Forms
        My.Settings.StyleBrowser15 = Color.FromArgb(36, 44, 50) 'NewTabPage BackgroundColor
        My.Settings.IsDarkTheme = True
        My.Settings.Mytheme = thisbtn.Name
        My.Settings.Save()

        StyleClover()
        runtimeactions.actions = "changetheme"

        For I As Integer = 0 To FlowLayoutPanel1.Controls.Count - 1
            Dim controlsFound = FlowLayoutPanel1.Controls.Item(I)
            If TypeOf controlsFound Is Button Then
                Dim buttonchange As Button = FlowLayoutPanel1.Controls.Item(I)
                buttonchange.FlatAppearance.BorderColor = StyleBrowser(8)
                buttonchange.FlatAppearance.BorderSize = 0
            End If
        Next
        thisbtn.FlatAppearance.BorderColor = Color.MediumSeaGreen
        thisbtn.FlatAppearance.BorderSize = 2
        Styling()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles CloverAltern.Click
        Dim thisbtn As Button = DirectCast(sender, Button)
        My.Settings.StyleBrowser0 = Color.FromArgb(49, 162, 77) 'Backtab color and newtab button
        My.Settings.StyleBrowser1 = Color.FromArgb(18, 121, 18) 'BorderColor active tab
        My.Settings.StyleBrowser2 = Color.FromArgb(84, 182, 92) 'BorderColor disabled tabs
        My.Settings.StyleBrowser3 = Color.FromArgb(32, 80, 43) 'Font color of tabs and close button
        My.Settings.StyleBrowser4 = Color.FromArgb(1, 34, 15) 'Font color of disabled tabs and close button
        My.Settings.StyleBrowser5 = Color.FromArgb(235, 235, 230) 'Tabs color
        My.Settings.StyleBrowser6 = Color.FromArgb(84, 182, 92) 'Disabled tabs color
        My.Settings.StyleBrowser7 = Color.FromArgb(235, 235, 230) 'Background panel
        My.Settings.StyleBrowser8 = Color.FromArgb(255, 255, 255) 'TextBox back color and Icon Buttons back color
        My.Settings.StyleBrowser9 = Color.Transparent 'Buttons back color
        My.Settings.StyleBrowser10 = Color.FromArgb(213, 228, 211) 'Buttons hover and active
        My.Settings.StyleBrowser11 = Color.FromArgb(32, 80, 43) 'Icon Buttons font color
        My.Settings.StyleBrowser12 = Color.FromArgb(224, 239, 222) 'Icon Buttons hover and active
        My.Settings.StyleBrowser13 = Color.FromArgb(35, 122, 50) 'Search text
        My.Settings.StyleBrowser14 = Color.FromArgb(255, 255, 255) 'Forms
        My.Settings.StyleBrowser15 = Color.FromArgb(249, 249, 251) 'NewTabPage BackgroundColor
        My.Settings.IsDarkTheme = False
        My.Settings.Mytheme = thisbtn.Name
        My.Settings.Save()

        StyleClover()
        runtimeactions.actions = "changetheme"

        For I As Integer = 0 To FlowLayoutPanel1.Controls.Count - 1
            Dim controlsFound = FlowLayoutPanel1.Controls.Item(I)
            If TypeOf controlsFound Is Button Then
                Dim buttonchange As Button = FlowLayoutPanel1.Controls.Item(I)
                buttonchange.FlatAppearance.BorderColor = StyleBrowser(8)
                buttonchange.FlatAppearance.BorderSize = 0
            End If
        Next
        thisbtn.FlatAppearance.BorderColor = Color.MediumSeaGreen
        thisbtn.FlatAppearance.BorderSize = 2
        Styling()
    End Sub
    Private Sub Styling()
        StyleClover()
        Me.BackColor = StyleBrowser(14)
        Me.ForeColor = StyleBrowser(11)

        For I As Integer = 0 To Me.Controls.Count - 1
            Dim controlsFound = Me.Controls.Item(I)
            controlsFound.ForeColor = StyleBrowser(11)
            If TypeOf controlsFound Is TextBox Then
                Dim AllTextBoxes As TextBox = Me.Controls.Item(I)
                AllTextBoxes.BackColor = StyleBrowser(8)
            End If
            If TypeOf controlsFound Is ComboBox Then
                Dim AllComboBoxes As ComboBox = Me.Controls.Item(I)
                AllComboBoxes.BackColor = StyleBrowser(8)
            End If
            If TypeOf controlsFound Is Label Then
                Dim AllLabels As Label = Me.Controls.Item(I)
                AllLabels.ForeColor = StyleBrowser(11)
            End If
            If TypeOf controlsFound Is Button Then
                Dim AllButtons As Button = Me.Controls.Item(I)
                AllButtons.BackColor = StyleBrowser(8)
                AllButtons.ForeColor = StyleBrowser(11)
                AllButtons.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
                AllButtons.FlatAppearance.MouseDownBackColor = StyleBrowser(12)
            End If
            If TypeOf controlsFound Is CheckBox Then
                Dim AllCheckBoxes As CheckBox = Me.Controls.Item(I)
                AllCheckBoxes.ForeColor = StyleBrowser(11)
            End If
        Next

        For I As Integer = 0 To FlowLayoutPanel1.Controls.Count - 1
            Dim controlsFound = FlowLayoutPanel1.Controls.Item(I)
            controlsFound.ForeColor = StyleBrowser(11)
            If TypeOf controlsFound Is TextBox Then
                Dim AllTextBoxes As TextBox = FlowLayoutPanel1.Controls.Item(I)
                AllTextBoxes.BackColor = StyleBrowser(8)
            End If
            If TypeOf controlsFound Is ComboBox Then
                Dim AllComboBoxes As ComboBox = FlowLayoutPanel1.Controls.Item(I)
                AllComboBoxes.BackColor = StyleBrowser(8)
            End If
            If TypeOf controlsFound Is Label Then
                Dim AllLabels As Label = FlowLayoutPanel1.Controls.Item(I)
                AllLabels.ForeColor = StyleBrowser(11)
            End If
            If TypeOf controlsFound Is Button Then
                Dim AllButtons As Button = FlowLayoutPanel1.Controls.Item(I)
                AllButtons.BackColor = StyleBrowser(8)
                AllButtons.ForeColor = StyleBrowser(11)
                AllButtons.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
                AllButtons.FlatAppearance.MouseDownBackColor = StyleBrowser(12)
            End If
            If TypeOf controlsFound Is CheckBox Then
                Dim AllCheckBoxes As CheckBox = FlowLayoutPanel1.Controls.Item(I)
                AllCheckBoxes.ForeColor = StyleBrowser(11)
            End If
        Next

        For I As Integer = 0 To FlowLayoutPanel2.Controls.Count - 1
            Dim controlsFound = FlowLayoutPanel2.Controls.Item(I)
            controlsFound.ForeColor = StyleBrowser(11)
            If TypeOf controlsFound Is TextBox Then
                Dim AllTextBoxes As TextBox = FlowLayoutPanel2.Controls.Item(I)
                AllTextBoxes.BackColor = StyleBrowser(8)
            End If
            If TypeOf controlsFound Is ComboBox Then
                Dim AllComboBoxes As ComboBox = FlowLayoutPanel2.Controls.Item(I)
                AllComboBoxes.BackColor = StyleBrowser(8)
            End If
            If TypeOf controlsFound Is Label Then
                Dim AllLabels As Label = FlowLayoutPanel2.Controls.Item(I)
                AllLabels.ForeColor = StyleBrowser(11)
            End If
            If TypeOf controlsFound Is Button Then
                Dim AllButtons As Button = FlowLayoutPanel2.Controls.Item(I)
                AllButtons.BackColor = StyleBrowser(8)
                AllButtons.ForeColor = StyleBrowser(11)
                AllButtons.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
                AllButtons.FlatAppearance.MouseDownBackColor = StyleBrowser(12)
            End If
            If TypeOf controlsFound Is CheckBox Then
                Dim AllCheckBoxes As CheckBox = FlowLayoutPanel2.Controls.Item(I)
                AllCheckBoxes.ForeColor = StyleBrowser(11)
            End If
        Next

        IconButton1.BackColor = StyleBrowser(14)
        IconButton1.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        IconButton1.FlatAppearance.MouseDownBackColor = StyleBrowser(12)
        IconButton1.IconColor = StyleBrowser(11)

        IconButton2.BackColor = StyleBrowser(14)
        IconButton2.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        IconButton2.FlatAppearance.MouseDownBackColor = StyleBrowser(12)
        IconButton2.IconColor = StyleBrowser(11)

        IconButton3.BackColor = StyleBrowser(14)
        IconButton3.FlatAppearance.MouseOverBackColor = StyleBrowser(12)
        IconButton3.FlatAppearance.MouseDownBackColor = StyleBrowser(12)
        IconButton3.IconColor = StyleBrowser(11)
    End Sub
    Private Sub settingswindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Styling()
        Dim btnThemeSelectedIndex As Integer = FlowLayoutPanel1.Controls.IndexOfKey(My.Settings.Mytheme)
        Dim btnThemeSelectedName As Button = FlowLayoutPanel1.Controls.Item(btnThemeSelectedIndex)
        btnThemeSelectedName.FlatAppearance.BorderColor = Color.MediumSeaGreen
        btnThemeSelectedName.FlatAppearance.BorderSize = 2

        TextBox1.Text = My.Settings.homepage

        If My.Settings.AskforCloseTabs = True Then
            CheckBox2.CheckState = CheckState.Checked
        Else
            CheckBox2.CheckState = CheckState.Unchecked
        End If

        If My.Settings.AskforDownloads = True Then
            CheckBox3.CheckState = CheckState.Checked
            Label10.Enabled = False
            TextBox2.Enabled = False
            ChangeDownloadsPlace.Enabled = False
        Else
            CheckBox3.CheckState = CheckState.Unchecked
            Label10.Enabled = True
            TextBox2.Enabled = True
            ChangeDownloadsPlace.Enabled = True
        End If

        Dim DownsPath As String
        If My.Settings.DownloadsFolder = "" Then
            DownsPath = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
        Else
            DownsPath = My.Settings.DownloadsFolder
        End If
        TextBox2.Text = DownsPath
    End Sub

    Private Sub IconButton1_Paint(sender As Object, e As PaintEventArgs) Handles IconButton1.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub IconButton2_Paint(sender As Object, e As PaintEventArgs) Handles IconButton2.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub IconButton3_Paint(sender As Object, e As PaintEventArgs) Handles IconButton3.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Classic.Paint
        ButtonBorderRadius(sender, 20)
    End Sub

    Private Sub Button2_Paint(sender As Object, e As PaintEventArgs) Handles DarkClover.Paint
        ButtonBorderRadius(sender, 20)
    End Sub

    Private Sub Button3_Paint(sender As Object, e As PaintEventArgs) Handles CloverAltern.Paint
        ButtonBorderRadius(sender, 20)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If runtimeactions.actions = "changetheme" Or runtimeactions.actions = "changethemebrowser" Then
            Styling()
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        For I As Integer = 0 To Me.Controls.Count - 1
            Dim controlsFound = Me.Controls.Item(I)
            If TypeOf controlsFound Is FlowLayoutPanel Then
                Dim panelChange As FlowLayoutPanel = Me.Controls.Item(I)
                panelChange.Visible = False
            End If
        Next
        FlowLayoutPanel2.Visible = True
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        For I As Integer = 0 To Me.Controls.Count - 1
            Dim controlsFound = Me.Controls.Item(I)
            If TypeOf controlsFound Is FlowLayoutPanel Then
                Dim panelChange As FlowLayoutPanel = Me.Controls.Item(I)
                panelChange.Visible = False
            End If
        Next
        FlowLayoutPanel1.Visible = True
    End Sub

    Private Sub CustomTheme_Paint(sender As Object, e As PaintEventArgs) Handles CustomTheme.Paint
        ButtonBorderRadius(sender, 20)
    End Sub

    Private Sub SaveHomePage_Click(sender As Object, e As EventArgs) Handles SaveHomePage.Click
        My.Settings.homepage = TextBox1.Text
        My.Settings.Save()
    End Sub

    Private Sub SaveHomePage_Paint(sender As Object, e As PaintEventArgs) Handles SaveHomePage.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        My.Settings.AskforCloseTabs = CheckBox2.Checked
        My.Settings.Save()
        'MsgBox(My.Settings.AskforCloseTabs.ToString)
    End Sub

    Private Sub ChangeDownloadsPlace_Paint(sender As Object, e As PaintEventArgs) Handles ChangeDownloadsPlace.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub LoadBookMarksButton_Paint(sender As Object, e As PaintEventArgs) Handles LoadBookMarksButton.Paint
        ButtonBorderRadius(sender, 10)
    End Sub

    Private Sub ChangeDownloadsPlace_Click(sender As Object, e As EventArgs) Handles ChangeDownloadsPlace.Click
        Dim fdialog As New FolderBrowserDialog
        fdialog.ShowNewFolderButton = True
        fdialog.SelectedPath = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
        Dim result = fdialog.ShowDialog()
        If result = DialogResult.OK Then
            Dim dir As New DirectoryInfo(fdialog.SelectedPath)
            If dir.Exists Then
                TextBox2.Text = dir.FullName
                My.Settings.DownloadsFolder = dir.FullName
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        My.Settings.AskforDownloads = CheckBox3.Checked
        My.Settings.Save()

        If CheckBox3.Checked = True Then
            Label10.Enabled = False
            TextBox2.Enabled = False
            ChangeDownloadsPlace.Enabled = False
        Else
            Label10.Enabled = True
            TextBox2.Enabled = True
            ChangeDownloadsPlace.Enabled = True
        End If
    End Sub
End Class
Public Class settingswindow
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        My.Settings.IsDarkTheme = False
        My.Settings.Save()

        StyleClover()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
        My.Settings.IsDarkTheme = True
        My.Settings.Save()

        StyleClover()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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
        My.Settings.IsDarkTheme = False
        My.Settings.Save()

        StyleClover()
    End Sub
End Class
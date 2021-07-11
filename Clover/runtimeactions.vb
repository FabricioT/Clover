Module runtimeactions
    Public actions As String
    Public changetheme As String
    Public urls As String
    Public urlscontext As String
    Public urlsnt As String
    Public LastFormActive As Form
    Public countforms As Integer = 0
    Public StyleBrowser(15) As Color
    Public HistoryToday As New List(Of String)
    Public HistoryTodayNames As New List(Of String)
    Public HistoryTodayFavs As New List(Of String)

    Public Sub StyleClover()
        'Style is property of Hilsoft Community
        StyleBrowser(0) = My.Settings.StyleBrowser0 'Backtab color and newtab button
        StyleBrowser(1) = My.Settings.StyleBrowser1 'BorderColor active tab
        StyleBrowser(2) = My.Settings.StyleBrowser2 'BorderColor disabled tabs
        StyleBrowser(3) = My.Settings.StyleBrowser3 'Font color of tabs and close button
        StyleBrowser(4) = My.Settings.StyleBrowser4 'Font color of disabled tabs and close button
        StyleBrowser(5) = My.Settings.StyleBrowser5 'Tabs color
        StyleBrowser(6) = My.Settings.StyleBrowser6 'Disabled tabs color
        StyleBrowser(7) = My.Settings.StyleBrowser7 'Background panel
        StyleBrowser(8) = My.Settings.StyleBrowser8 'TextBox back color and Icon Buttons back color
        StyleBrowser(9) = My.Settings.StyleBrowser9 'Buttons back color
        StyleBrowser(10) = My.Settings.StyleBrowser10 'Buttons hover and active
        StyleBrowser(11) = My.Settings.StyleBrowser11 'Icon Buttons font color
        StyleBrowser(12) = My.Settings.StyleBrowser12 'Icon Buttons hover and active
        StyleBrowser(13) = My.Settings.StyleBrowser13 'Search text
        StyleBrowser(14) = My.Settings.StyleBrowser14 'Forms
    End Sub
End Module

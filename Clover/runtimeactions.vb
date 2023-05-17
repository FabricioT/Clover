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
    Public LoadStart As Boolean = True
    Public deleteBookName As String
    Public deleteBookAdress As String
    Public deleteBookImg As String
    Public deleteBookIndex As Integer
    Public actionBook As String
    Public actionBookForm As Form
    Public booktoread As ToolStripButton

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
        StyleBrowser(15) = My.Settings.StyleBrowser15 'NewTabPage BackgroundColor
    End Sub

    Function ConvertColorToRgb(ColorValue As Long) As String
        Dim Red As Long, Green As Long, Blue As Long
        Red = ColorValue Mod 256
        Green = ((ColorValue - Red) / 256) Mod 256
        Blue = ((ColorValue - Red - (Green * 256)) / 256 / 256) Mod 256

        ConvertColorToRgb = "rgb(" &
                        Red & ", " &
                        Green & ", " &
                        Blue & ")"
    End Function

    Dim DoubleBytes As Double
    Public Property FormatBytes(ByVal BytesCaller As ULong) As String
        Get
            Try
                Select Case BytesCaller
                    Case Is >= 1099511627776
                        DoubleBytes = CDbl(BytesCaller / 1099511627776) 'TB
                        Return FormatNumber(DoubleBytes, 2) & " TB"
                    Case 1073741824 To 1099511627775
                        DoubleBytes = CDbl(BytesCaller / 1073741824) 'GB
                        Return FormatNumber(DoubleBytes, 2) & " GB"
                    Case 1048576 To 1073741823
                        DoubleBytes = CDbl(BytesCaller / 1048576) 'MB
                        Return FormatNumber(DoubleBytes, 2) & " MB"
                    Case 1024 To 1048575
                        DoubleBytes = CDbl(BytesCaller / 1024) 'KB
                        Return FormatNumber(DoubleBytes, 2) & " KB"
                    Case 0 To 1023
                        DoubleBytes = BytesCaller ' bytes
                        Return FormatNumber(DoubleBytes, 2) & " bytes"
                    Case Else
                        Return ""
                End Select
            Catch
                Return ""
            End Try
        End Get
        Set(value As String)

        End Set
    End Property
End Module

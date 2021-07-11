Module FormsColored
    Declare Function SetSysColors Lib "user32" (ByVal nChanges As Long, ByVal lpSysColor As Long, ByVal lpColorValues As Long) As Long
    ' This code goes in the userform module...
    Private Const COLOR_SCROLLBAR = 0 'The Scrollbar colour
    Private Const COLOR_BACKGROUND = 1 'Colour of the background with no wallpaper
    Private Const COLOR_ACTIVECAPTION = 2 'Caption of Active Window
    Private Const COLOR_INACTIVECAPTION = 3 'Caption of Inactive window
    Private Const COLOR_MENU = 4 'Menu
    Private Const COLOR_WINDOW = 5 'Windows background
    Private Const COLOR_WINDOWFRAME = 6 'Window frame
    Private Const COLOR_MENUTEXT = 7 'Window Text
    Private Const COLOR_WINDOWTEXT = 8 '3D dark shadow (Win95)
    Private Const COLOR_CAPTIONTEXT = 9 'Text in window caption
    Private Const COLOR_ACTIVEBORDER = 10 'Border of active window
    Private Const COLOR_INACTIVEBORDER = 11 'Border of inactive window
    Private Const COLOR_APPWORKSPACE = 12 'Background of MDI desktop
    Private Const COLOR_HIGHLIGHT = 13 'Selected item background
    Private Const COLOR_HIGHLIGHTTEXT = 14 'Selected menu item
    Private Const COLOR_BTNFACE = 15 'Button
    Private Const COLOR_BTNSHADOW = 16 '3D shading of button
    Private Const COLOR_GRAYTEXT = 17 'Grey text, of zero if dithering is used.
    Private Const COLOR_BTNTEXT = 18 'Button text
    Private Const COLOR_INACTIVECAPTIONTEXT = 19 'Text of inactive window
    Private Const COLOR_BTNHIGHLIGHT = 20 '3D highlight of button
    Sub Main()
        Dim t As Long
        t = SetSysColors(1, 1, RGB(255, 0, 0))
        t = SetSysColors(1, 2, RGB(255, 0, 0))
        t = SetSysColors(1, 3, RGB(255, 0, 0))
        t = SetSysColors(1, 4, RGB(255, 0, 0))
        t = SetSysColors(1, 5, RGB(255, 0, 0))
        t = SetSysColors(1, 6, RGB(255, 0, 0))

        t = SetSysColors(1, 7, RGB(255, 0, 0))
        t = SetSysColors(1, 8, RGB(255, 0, 0))
        t = SetSysColors(1, 9, RGB(255, 0, 0))
        t = SetSysColors(1, 10, RGB(255, 0, 0))
        t = SetSysColors(1, 11, RGB(255, 0, 0))
        t = SetSysColors(1, 12, RGB(255, 0, 0))
        t = SetSysColors(1, 13, RGB(255, 0, 0))
        t = SetSysColors(1, 14, RGB(255, 0, 0))
        t = SetSysColors(1, 15, RGB(255, 0, 0))
        t = SetSysColors(1, 16, RGB(255, 0, 0))

        t = SetSysColors(1, 18, RGB(255, 0, 0))
        t = SetSysColors(1, 19, RGB(255, 0, 0))
        t = SetSysColors(1, 20, RGB(255, 0, 0))
    End Sub
End Module

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class settingswindow
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settingswindow))
        Me.Classic = New System.Windows.Forms.Button()
        Me.DarkClover = New System.Windows.Forms.Button()
        Me.CloverAltern = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CustomTheme = New System.Windows.Forms.Button()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SaveHomePage = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ChangeDownloadsPlace = New System.Windows.Forms.Button()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LoadBookMarksButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Classic
        '
        Me.Classic.BackgroundImage = Global.Clover.My.Resources.Resources.classic_theme
        Me.Classic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Classic.FlatAppearance.BorderSize = 0
        Me.Classic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Classic.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Classic.Location = New System.Drawing.Point(13, 188)
        Me.Classic.Name = "Classic"
        Me.Classic.Padding = New System.Windows.Forms.Padding(5)
        Me.Classic.Size = New System.Drawing.Size(250, 226)
        Me.Classic.TabIndex = 0
        Me.Classic.Text = "Clover Clásico"
        Me.Classic.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Classic.UseVisualStyleBackColor = True
        '
        'DarkClover
        '
        Me.DarkClover.BackgroundImage = Global.Clover.My.Resources.Resources.dark_theme
        Me.DarkClover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DarkClover.FlatAppearance.BorderSize = 0
        Me.DarkClover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DarkClover.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DarkClover.Location = New System.Drawing.Point(269, 188)
        Me.DarkClover.Name = "DarkClover"
        Me.DarkClover.Padding = New System.Windows.Forms.Padding(5)
        Me.DarkClover.Size = New System.Drawing.Size(250, 226)
        Me.DarkClover.TabIndex = 1
        Me.DarkClover.Text = "DarkTheme"
        Me.DarkClover.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DarkClover.UseVisualStyleBackColor = True
        '
        'CloverAltern
        '
        Me.CloverAltern.BackgroundImage = Global.Clover.My.Resources.Resources.clover_altern_theme
        Me.CloverAltern.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CloverAltern.FlatAppearance.BorderSize = 0
        Me.CloverAltern.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloverAltern.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloverAltern.Location = New System.Drawing.Point(13, 420)
        Me.CloverAltern.Name = "CloverAltern"
        Me.CloverAltern.Padding = New System.Windows.Forms.Padding(5)
        Me.CloverAltern.Size = New System.Drawing.Size(250, 226)
        Me.CloverAltern.TabIndex = 2
        Me.CloverAltern.Text = "Clover Alterno"
        Me.CloverAltern.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CloverAltern.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.Label9)
        Me.FlowLayoutPanel1.Controls.Add(Me.CheckBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Classic)
        Me.FlowLayoutPanel1.Controls.Add(Me.DarkClover)
        Me.FlowLayoutPanel1.Controls.Add(Me.CloverAltern)
        Me.FlowLayoutPanel1.Controls.Add(Me.CustomTheme)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(200, 77)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(10, 20, 0, 100)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(549, 429)
        Me.FlowLayoutPanel1.TabIndex = 3
        Me.FlowLayoutPanel1.Visible = False
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.SetFlowBreak(Me.Label9, True)
        Me.Label9.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(13, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label9.Size = New System.Drawing.Size(277, 45)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Formulario"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FlowLayoutPanel1.SetFlowBreak(Me.CheckBox1, True)
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(16, 68)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.CheckBox1.Size = New System.Drawing.Size(503, 24)
        Me.CheckBox1.TabIndex = 26
        Me.CheckBox1.Text = "Mostrar barra de marcadores"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.SetFlowBreak(Me.Label2, True)
        Me.Label2.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(277, 45)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Navegación"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.SetFlowBreak(Me.Label4, True)
        Me.Label4.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(277, 45)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Tema del navegador"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CustomTheme
        '
        Me.CustomTheme.BackgroundImage = Global.Clover.My.Resources.Resources.custom_theme
        Me.CustomTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CustomTheme.FlatAppearance.BorderSize = 0
        Me.CustomTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomTheme.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomTheme.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CustomTheme.Location = New System.Drawing.Point(269, 420)
        Me.CustomTheme.Name = "CustomTheme"
        Me.CustomTheme.Padding = New System.Windows.Forms.Padding(5)
        Me.CustomTheme.Size = New System.Drawing.Size(250, 226)
        Me.CustomTheme.TabIndex = 25
        Me.CustomTheme.Text = "Tema personalizado"
        Me.CustomTheme.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CustomTheme.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.White
        Me.IconButton1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.GlobeAmericas
        Me.IconButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconButton1.IconSize = 24
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(3, 107)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.IconButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IconButton1.Size = New System.Drawing.Size(193, 45)
        Me.IconButton1.TabIndex = 12
        Me.IconButton1.Text = "General"
        Me.IconButton1.UseCompatibleTextRendering = True
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.White
        Me.IconButton2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Palette
        Me.IconButton2.IconColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconButton2.IconSize = 24
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(3, 154)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.IconButton2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IconButton2.Size = New System.Drawing.Size(193, 45)
        Me.IconButton2.TabIndex = 13
        Me.IconButton2.Text = "Apariencia"
        Me.IconButton2.UseCompatibleTextRendering = True
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.Color.White
        Me.IconButton3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Microchip
        Me.IconButton3.IconColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconButton3.IconSize = 24
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.Location = New System.Drawing.Point(3, 201)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.IconButton3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IconButton3.Size = New System.Drawing.Size(193, 45)
        Me.IconButton3.TabIndex = 14
        Me.IconButton3.Text = "Avanzado"
        Me.IconButton3.UseCompatibleTextRendering = True
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label1.Location = New System.Drawing.Point(55, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 47)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Configuración"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.AutoScroll = True
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel2.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel2.Controls.Add(Me.ComboBox2)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox1)
        Me.FlowLayoutPanel2.Controls.Add(Me.SaveHomePage)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel2.Controls.Add(Me.ComboBox1)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel2.Controls.Add(Me.CheckBox2)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox2)
        Me.FlowLayoutPanel2.Controls.Add(Me.ChangeDownloadsPlace)
        Me.FlowLayoutPanel2.Controls.Add(Me.CheckBox3)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label11)
        Me.FlowLayoutPanel2.Controls.Add(Me.LoadBookMarksButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.TableLayoutPanel1)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(200, 77)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 100)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(10, 20, 0, 200)
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(549, 429)
        Me.FlowLayoutPanel2.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel2.SetFlowBreak(Me.Label3, True)
        Me.Label3.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 5)
        Me.Label3.Size = New System.Drawing.Size(277, 45)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Inicio"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semilight", 11.75!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(13, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label8.Size = New System.Drawing.Size(203, 32)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Al abrir una Nueva Pestaña:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Página de 'Nueva Pestaña' de Clover", "Mostrar Página de inicio"})
        Me.ComboBox2.Location = New System.Drawing.Point(222, 68)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(294, 28)
        Me.ComboBox2.TabIndex = 30
        Me.ComboBox2.Text = "Mostrar Página de 'Nueva Pestaña' de Clover"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semilight", 11.75!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(13, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label6.Size = New System.Drawing.Size(130, 32)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Página de inicio:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(149, 102)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(274, 27)
        Me.TextBox1.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Si queda en blanco se utilizará google.com")
        '
        'SaveHomePage
        '
        Me.SaveHomePage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveHomePage.FlatAppearance.BorderSize = 0
        Me.SaveHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveHomePage.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveHomePage.Location = New System.Drawing.Point(429, 102)
        Me.SaveHomePage.Name = "SaveHomePage"
        Me.SaveHomePage.Size = New System.Drawing.Size(87, 27)
        Me.SaveHomePage.TabIndex = 28
        Me.SaveHomePage.Text = "Guardar"
        Me.SaveHomePage.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SaveHomePage.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semilight", 11.75!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(13, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label7.Size = New System.Drawing.Size(162, 32)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Motor de búsqueda:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.SetFlowBreak(Me.ComboBox1, True)
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Google", "Bing", "DuckDuck Go"})
        Me.ComboBox1.Location = New System.Drawing.Point(181, 135)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(335, 28)
        Me.ComboBox1.TabIndex = 27
        Me.ComboBox1.Text = "Google (Predeterminado)"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel2.SetFlowBreak(Me.Label5, True)
        Me.Label5.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(10, 0, 0, 5)
        Me.Label5.Size = New System.Drawing.Size(277, 45)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Navegador"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'CheckBox2
        '
        Me.CheckBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(13, 214)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.CheckBox2.Size = New System.Drawing.Size(375, 24)
        Me.CheckBox2.TabIndex = 31
        Me.CheckBox2.Text = "Preguntar antes de cerrar varias pestañas a la vez"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semilight", 11.75!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(13, 241)
        Me.Label10.Name = "Label10"
        Me.Label10.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label10.Size = New System.Drawing.Size(203, 32)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Ubicación de las descargas:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(222, 244)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(201, 27)
        Me.TextBox2.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.TextBox2, "Si queda en blanco se utilizará google.com")
        '
        'ChangeDownloadsPlace
        '
        Me.ChangeDownloadsPlace.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChangeDownloadsPlace.FlatAppearance.BorderSize = 0
        Me.ChangeDownloadsPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangeDownloadsPlace.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeDownloadsPlace.Location = New System.Drawing.Point(429, 244)
        Me.ChangeDownloadsPlace.Name = "ChangeDownloadsPlace"
        Me.ChangeDownloadsPlace.Size = New System.Drawing.Size(87, 27)
        Me.ChangeDownloadsPlace.TabIndex = 34
        Me.ChangeDownloadsPlace.Text = "Cambiar..."
        Me.ChangeDownloadsPlace.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ChangeDownloadsPlace.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(13, 277)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.CheckBox3.Size = New System.Drawing.Size(503, 24)
        Me.CheckBox3.TabIndex = 35
        Me.CheckBox3.Text = "Preguntar siempre antes de descargar"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel2.SetFlowBreak(Me.Label11, True)
        Me.Label11.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(13, 304)
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New System.Windows.Forms.Padding(10, 0, 0, 5)
        Me.Label11.Size = New System.Drawing.Size(277, 45)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Favoritos"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'LoadBookMarksButton
        '
        Me.LoadBookMarksButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadBookMarksButton.FlatAppearance.BorderSize = 0
        Me.LoadBookMarksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FlowLayoutPanel2.SetFlowBreak(Me.LoadBookMarksButton, True)
        Me.LoadBookMarksButton.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadBookMarksButton.Location = New System.Drawing.Point(13, 352)
        Me.LoadBookMarksButton.Name = "LoadBookMarksButton"
        Me.LoadBookMarksButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LoadBookMarksButton.Size = New System.Drawing.Size(487, 42)
        Me.LoadBookMarksButton.TabIndex = 37
        Me.LoadBookMarksButton.Text = "Cargar todos los favoritos..."
        Me.LoadBookMarksButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LoadBookMarksButton.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 400)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 60)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(503, 417)
        Me.TableLayoutPanel1.TabIndex = 38
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Clover.My.Resources.Resources.logoapp
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(9, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 50)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Clover.My.Resources.Resources.shadow
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(753, 25)
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(-1, 37)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(753, 34)
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'settingswindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 506)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.IconButton3)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(491, 278)
        Me.Name = "settingswindow"
        Me.Text = "settings"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Classic As Button
    Friend WithEvents DarkClover As Button
    Friend WithEvents CloverAltern As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CustomTheme As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SaveHomePage As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ChangeDownloadsPlace As Button
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents LoadBookMarksButton As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class windowbroser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(windowbroser))
        Me.TabControl1 = New MdiTabControl.TabControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevaPestañaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarPestañaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DuplicarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirEnUnaNuevaVentanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.AllowDrop = True
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.BackColor = System.Drawing.Color.Transparent
        Me.TabControl1.BackHighColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.TabControl1.BackLowColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.TabControl1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.TabControl1.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.TabControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TabControl1.DropButtonVisible = False
        Me.TabControl1.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.FontBoldOnSelect = False
        Me.TabControl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabControl1.ForeColorDisabled = System.Drawing.Color.DimGray
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.MenuRenderer = Nothing
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = New System.Drawing.Size(800, 577)
        Me.TabControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        Me.TabControl1.TabBackHighColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.TabControl1.TabBackHighColorDisabled = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.TabControl1.TabBackLowColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.TabControl1.TabBackLowColorDisabled = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.TabControl1.TabBorderEnhanced = True
        Me.TabControl1.TabBorderEnhanceWeight = MdiTabControl.TabControl.Weight.Soft
        Me.TabControl1.TabCloseButtonBackHighColor = System.Drawing.Color.Transparent
        Me.TabControl1.TabCloseButtonBackHighColorDisabled = System.Drawing.Color.Transparent
        Me.TabControl1.TabCloseButtonBackLowColor = System.Drawing.Color.Transparent
        Me.TabControl1.TabCloseButtonBackLowColorDisabled = System.Drawing.Color.Transparent
        Me.TabControl1.TabCloseButtonBackLowColorHot = System.Drawing.Color.LightCoral
        Me.TabControl1.TabCloseButtonBorderColor = System.Drawing.Color.Transparent
        Me.TabControl1.TabCloseButtonBorderColorDisabled = System.Drawing.Color.Transparent
        Me.TabControl1.TabCloseButtonBorderColorHot = System.Drawing.Color.LightCoral
        Me.TabControl1.TabCloseButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabControl1.TabCloseButtonForeColorDisabled = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabControl1.TabCloseButtonImage = Nothing
        Me.TabControl1.TabCloseButtonImageDisabled = Nothing
        Me.TabControl1.TabCloseButtonImageHot = Nothing
        Me.TabControl1.TabGlassGradient = True
        Me.TabControl1.TabHeight = 32
        Me.TabControl1.TabIndex = 1
        Me.TabControl1.TabMinimumWidth = 200
        Me.TabControl1.TabPadLeft = 20
        Me.TabControl1.TabPadRight = 10
        Me.TabControl1.TabsDirection = MdiTabControl.TabControl.FlowDirection.RightToLeft
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaPestañaToolStripMenuItem, Me.CerrarPestañaToolStripMenuItem, Me.DuplicarToolStripMenuItem, Me.AbrirEnUnaNuevaVentanaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(412, 121)
        '
        'NuevaPestañaToolStripMenuItem
        '
        Me.NuevaPestañaToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.NuevaPestañaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NuevaPestañaToolStripMenuItem.Image = Global.Clover.My.Resources.Resources.newtab
        Me.NuevaPestañaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.NuevaPestañaToolStripMenuItem.Margin = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.NuevaPestañaToolStripMenuItem.Name = "NuevaPestañaToolStripMenuItem"
        Me.NuevaPestañaToolStripMenuItem.Padding = New System.Windows.Forms.Padding(3)
        Me.NuevaPestañaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.NuevaPestañaToolStripMenuItem.Size = New System.Drawing.Size(417, 28)
        Me.NuevaPestañaToolStripMenuItem.Text = "Nueva pestaña"
        '
        'CerrarPestañaToolStripMenuItem
        '
        Me.CerrarPestañaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CerrarPestañaToolStripMenuItem.Image = Global.Clover.My.Resources.Resources._stop
        Me.CerrarPestañaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.CerrarPestañaToolStripMenuItem.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.CerrarPestañaToolStripMenuItem.Name = "CerrarPestañaToolStripMenuItem"
        Me.CerrarPestañaToolStripMenuItem.Padding = New System.Windows.Forms.Padding(3)
        Me.CerrarPestañaToolStripMenuItem.Size = New System.Drawing.Size(417, 28)
        Me.CerrarPestañaToolStripMenuItem.Text = "Cerrar pestaña actual"
        '
        'DuplicarToolStripMenuItem
        '
        Me.DuplicarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DuplicarToolStripMenuItem.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.DuplicarToolStripMenuItem.Name = "DuplicarToolStripMenuItem"
        Me.DuplicarToolStripMenuItem.Padding = New System.Windows.Forms.Padding(3)
        Me.DuplicarToolStripMenuItem.Size = New System.Drawing.Size(417, 28)
        Me.DuplicarToolStripMenuItem.Text = "Duplicar pestaña actual"
        '
        'AbrirEnUnaNuevaVentanaToolStripMenuItem
        '
        Me.AbrirEnUnaNuevaVentanaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AbrirEnUnaNuevaVentanaToolStripMenuItem.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.AbrirEnUnaNuevaVentanaToolStripMenuItem.Name = "AbrirEnUnaNuevaVentanaToolStripMenuItem"
        Me.AbrirEnUnaNuevaVentanaToolStripMenuItem.Padding = New System.Windows.Forms.Padding(3)
        Me.AbrirEnUnaNuevaVentanaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.AbrirEnUnaNuevaVentanaToolStripMenuItem.Size = New System.Drawing.Size(417, 28)
        Me.AbrirEnUnaNuevaVentanaToolStripMenuItem.Text = "Abrir pestaña actual en una nueva ventana"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(762, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(0, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(720, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(722, 43)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 34)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(440, 90)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "panel"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(150, 87)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "certificate"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = Global.Clover.My.Resources.Resources.newtab
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(208, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(30, 28)
        Me.Button5.TabIndex = 9
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Location = New System.Drawing.Point(348, 90)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "bookmarks"
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.Visible = False
        '
        'windowbroser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 576)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(400, 400)
        Me.Name = "windowbroser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clover"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents TabControl1 As MdiTabControl.TabControl
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents NuevaPestañaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarPestañaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DuplicarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirEnUnaNuevaVentanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class

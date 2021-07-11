<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListControl
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.flpListBox = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'flpListBox
        '
        Me.flpListBox.AutoScroll = True
        Me.flpListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpListBox.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpListBox.Location = New System.Drawing.Point(0, 0)
        Me.flpListBox.Margin = New System.Windows.Forms.Padding(0)
        Me.flpListBox.Name = "flpListBox"
        Me.flpListBox.Size = New System.Drawing.Size(150, 150)
        Me.flpListBox.TabIndex = 0
        Me.flpListBox.WrapContents = False
        '
        'ListControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.flpListBox)
        Me.Name = "ListControl"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flpListBox As FlowLayoutPanel
End Class

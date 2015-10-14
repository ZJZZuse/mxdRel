<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutoKeyPressCom
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CheckBoxEnable = New System.Windows.Forms.CheckBox()
        Me.TextBoxKeyName = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerEnable = New System.Windows.Forms.Timer(Me.components)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBoxEnable
        '
        Me.CheckBoxEnable.AutoSize = True
        Me.CheckBoxEnable.Location = New System.Drawing.Point(9, 17)
        Me.CheckBoxEnable.Name = "CheckBoxEnable"
        Me.CheckBoxEnable.Size = New System.Drawing.Size(48, 16)
        Me.CheckBoxEnable.TabIndex = 0
        Me.CheckBoxEnable.Text = "启用"
        Me.CheckBoxEnable.UseVisualStyleBackColor = True
        '
        'TextBoxKeyName
        '
        Me.TextBoxKeyName.Location = New System.Drawing.Point(63, 12)
        Me.TextBoxKeyName.Name = "TextBoxKeyName"
        Me.TextBoxKeyName.Size = New System.Drawing.Size(130, 21)
        Me.TextBoxKeyName.TabIndex = 1
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(199, 12)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 21)
        Me.NumericUpDown1.TabIndex = 2
        Me.NumericUpDown1.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(408, 12)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(186, 21)
        Me.TextBox4.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(325, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ms"
        '
        'Timer1
        '
        '
        'TimerEnable
        '
        Me.TimerEnable.Enabled = True
        '
        'AutoKeyPressCom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.TextBoxKeyName)
        Me.Controls.Add(Me.CheckBoxEnable)
        Me.Name = "AutoKeyPressCom"
        Me.Size = New System.Drawing.Size(597, 47)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBoxEnable As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxKeyName As System.Windows.Forms.TextBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TimerEnable As System.Windows.Forms.Timer

End Class

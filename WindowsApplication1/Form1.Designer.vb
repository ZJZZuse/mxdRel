﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1



    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.common = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KeyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IntervalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AutoPressTaskBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutoPressTaskBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MxdAutoPressHelperBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutoPressTaskBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutoPressTaskBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MxdAutoPressHelperBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(21, 6)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(78, 16)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "auto pick"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(21, 44)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(90, 16)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "auto attack"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(21, 83)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(140, 21)
        Me.TextBox1.TabIndex = 2
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(177, 88)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(84, 16)
        Me.CheckBox3.TabIndex = 3
        Me.CheckBox3.Text = "auto press"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.common)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(676, 354)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.CheckedListBox1)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.CheckBox3)
        Me.TabPage1.Controls.Add(Me.CheckBox2)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(668, 328)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(170, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 5
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"左右移动"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(376, 6)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(240, 164)
        Me.CheckedListBox1.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.CheckBox4)
        Me.TabPage2.Controls.Add(Me.TrackBar1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(668, 328)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "血蓝"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(352, 29)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(125, 21)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "pgdn"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(243, 34)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(102, 16)
        Me.CheckBox4.TabIndex = 1
        Me.CheckBox4.Text = "auto reply hp"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(8, 6)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(228, 45)
        Me.TrackBar1.TabIndex = 0
        Me.TrackBar1.Value = 4
        '
        'common
        '
        Me.common.Location = New System.Drawing.Point(4, 22)
        Me.common.Name = "common"
        Me.common.Padding = New System.Windows.Forms.Padding(3)
        Me.common.Size = New System.Drawing.Size(668, 328)
        Me.common.TabIndex = 3
        Me.common.Text = "TabPage4"
        Me.common.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(668, 328)
        Me.TabPage3.TabIndex = 4
        Me.TabPage3.Text = "auto press"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KeyDataGridViewTextBoxColumn, Me.IntervalDataGridViewTextBoxColumn, Me.EnableDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AutoPressTaskBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(104, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(507, 218)
        Me.DataGridView1.TabIndex = 0
        '
        'KeyDataGridViewTextBoxColumn
        '
        Me.KeyDataGridViewTextBoxColumn.DataPropertyName = "key"
        Me.KeyDataGridViewTextBoxColumn.HeaderText = "key"
        Me.KeyDataGridViewTextBoxColumn.Name = "KeyDataGridViewTextBoxColumn"
        '
        'IntervalDataGridViewTextBoxColumn
        '
        Me.IntervalDataGridViewTextBoxColumn.DataPropertyName = "interval"
        Me.IntervalDataGridViewTextBoxColumn.HeaderText = "interval"
        Me.IntervalDataGridViewTextBoxColumn.Name = "IntervalDataGridViewTextBoxColumn"
        '
        'EnableDataGridViewTextBoxColumn
        '
        Me.EnableDataGridViewTextBoxColumn.DataPropertyName = "enable"
        Me.EnableDataGridViewTextBoxColumn.HeaderText = "enable"
        Me.EnableDataGridViewTextBoxColumn.Name = "EnableDataGridViewTextBoxColumn"
        '
        'AutoPressTaskBindingSource
        '
        Me.AutoPressTaskBindingSource.DataSource = GetType(WindowsApplication1.AutoPressTask)
        '
        'AutoPressTaskBindingSource1
        '
        Me.AutoPressTaskBindingSource1.DataSource = GetType(WindowsApplication1.AutoPressTask)
        '
        'MxdAutoPressHelperBindingSource
        '
        Me.MxdAutoPressHelperBindingSource.DataSource = GetType(WindowsApplication1.MxdAutoPressHelper)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 354)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "mxd"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutoPressTaskBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutoPressTaskBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MxdAutoPressHelperBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents common As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents AutoPressTaskBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AutoPressTaskBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents KeyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntervalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MxdAutoPressHelperBindingSource As System.Windows.Forms.BindingSource

End Class

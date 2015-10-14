Public Class AutoKeyPressCom

    'Private dm As Dm.dmsoft

    Property dm()

    Property enable()

    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

        enable = True

    End Sub

    Sub New(ByVal dm)

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

        Me.dm = dm

    End Sub

    Private Sub UserControl1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxKeyName.TextChanged

    End Sub

    Private Sub NumericUpDown1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumericUpDown1.LostFocus

        Timer1.Interval = NumericUpDown1.Value

    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub



    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        mainLoop()
    End Sub

    Private Sub mainLoop()

        If Not enable Then
            Exit Sub
        End If

        dm.KeyPressChar(TextBoxKeyName.Text)
    End Sub

    Private Sub CheckBoxEnable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxEnable.CheckedChanged

        If CheckBoxEnable.Checked Then
            Timer1.Start()

        Else
            Timer1.Stop()
        End If


    End Sub
End Class

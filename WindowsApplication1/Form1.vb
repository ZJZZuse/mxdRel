Public Class Form1

    Private hwnd

    Dim dm_ret

    Private dm As New Dm.dmsoft

    Private Const basePath = "E:\software\大漠插件\字体"

    Private autoAttack As Boolean
    Dim autoPick As Boolean

    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。


        initDate()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim path

        'path = dm.GetDir(0)

        'MsgBox(path)


        'hwnd = dm.FindWindow("MapleStoryClass", "MapleStory")


        '' display: 前台 鼠标:前台键盘:前台 模式0
        ''dm_ret = dm.BindWindow(hwnd, "normal", "normal", "normal", 0)


        ''dm_ret = dm.BindWindow(hwnd, "dx", "dx", "dx", 0)

        'dm_ret = dm.BindWindow(hwnd, "dx", "windows", "windows", 0)



    End Sub

    Private Sub mainLoop()
        'If isGameForwarde() Then

        '    enableOthenCom(True)

        autoPickB()
        autoAttackB()
        autoPress(TextBox1.Text)

        If CheckBox4.Checked Then


            Try

                replyHp(TrackBar1.Value / CDbl(TrackBar1.Maximum), TextBox2.Text)
            Catch ex As Exception

            End Try


        End If

        If CheckedListBox1.GetItemChecked(0) Then

            moveLeftAndRight()
        End If

        'Else

        'enableOthenCom(False)

        'End If

    End Sub



    Function isGameForwarde()

        dm_ret = dm.GetWindowState(hwnd, 1)
        isGameForwarde = (dm_ret = 1)
    End Function


    Sub autoPickB()

        If Not CheckBox1.Checked Then

            Exit Sub

        End If

        dm.KeyPressChar("z")



    End Sub


    Sub autoAttackB()

        If Not CheckBox2.Checked Then

            Exit Sub

        End If

        dm.KeyPressChar("delete")



    End Sub

    Sub autoPress(ByVal key)

        If Not CheckBox3.Checked Then

            Exit Sub


        End If
        dm.KeyPressChar(key)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        mainLoop()
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub replyHp(ByVal proportion, ByVal key)

        dm_ret = dm.SetPath(basePath)
        dm_ret = dm.SetDict(0, "mxd.txt")

        Dim s = dm.Ocr(279, 565, 395, 584, "ffffff-000000", 1.0)

        If s = "" Then

            Exit Sub

        End If

        Dim maxHp = CStr(s)

        Dim hps = maxHp.Substring(1, maxHp.Length - 2).Split("/")

        If hps.Length <> 2 Then
            Exit Sub
        End If

        maxHp = hps(1)

        Dim hpNow = hps(0)

        If CInt(hpNow) / CDbl(maxHp) < proportion Then

            dm.KeyPressChar(key)

        End If





    End Sub


    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub


    Sub moveLeftAndRight()

        dm.KeyDownChar("left")

        Threading.Thread.Sleep(100)
        dm.KeyUpChar("left")

        dm.KeyDownChar("right")

        Threading.Thread.Sleep(100)

        dm.KeyUpChar("right")

    End Sub


    Sub test()



    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub initDate()


        'mydm
        ' collection

        Dim myDm = New MyDm(dm)

        Dim a = New AutoPressTask(myDm, "z", 10)

        Dim t = New MxdAutoPressHelper(myDm)

        t.add(a)

        DataGridView1.DataSource = t.autpPressTasks


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick



    End Sub
End Class

Public Class MyDm


    Public Delegate Function findHwnd(ByVal dm)

    Public Delegate Sub bindAction(ByVal dm, ByVal hwnd)

    Public Delegate Function gainDoneSign(ByVal dm)

    Public Delegate Function gainObjByDmCommon(ByVal dm)

    ''' <summary>
    ''' 主要用于设置basePath，dictName
    ''' </summary>
    ''' <param name="myDm"></param>
    ''' <remarks></remarks>
    Delegate Sub initMyDmMine(ByVal myDm As MyDm)

    Property dm As Dm.dmsoft

    Property dm_ret

    ' Property basePath = "E:\software\大漠插件\字体"


    Property basePath = ".\data"


    'Property dictName = "dm_soft.txt"

    Property dictName = "dm_soft.dmd"

    Property hwnd

    Private cfgFName = "cfg.ini"


    Sub initBaskPath()

        basePath = dm.GetBasePath()

    End Sub


    Public zoneWidth As Object = 800
    Public zoneHeight As Object = 600

    Sub New(ByVal dm)

        Me.dm = dm

    End Sub

    ''' <summary>
    ''' common one time builder
    ''' </summary>
    ''' <param name="dm"></param>
    ''' <param name="findWin"></param>
    ''' <param name="bindAction"></param>
    ''' <remarks></remarks>
    Sub New(ByVal dm As Dm.dmsoft, ByVal findWin As findHwnd, ByVal bindAction As bindAction, ByVal initMyDmMine As initMyDmMine)

        Me.New(dm)

        initMyDmMine.Invoke(Me)


        initDm(findWin, bindAction)

    End Sub

    Function writeIni(ByVal section, ByVal key, ByVal value)

        Return dm.WriteIni(section, key, value, cfgFName)



    End Function

    Function readFile(ByVal f)

        Return dm.ReadFile(f)


    End Function

    Function writeFile(ByVal f, ByVal content)

        Return dm.WriteFile(f, content)

    End Function

    Function writeFileCover(ByVal f, ByVal content)

        If dm.IsFileExist(f) = 1 Then

            dm.DeleteFile(f)

        End If


        Return dm.WriteFile(f, content)

    End Function


    Function readIni(ByVal section, ByVal key)

        Return dm.ReadIni(section, key, cfgFName)

    End Function

    Sub askTaoBindW()

        dm_ret = dm.BindWindow(hwnd, "dx2", "dx2", "dx", 0)

    End Sub


    Sub initDm(ByVal findWin As findHwnd, ByVal bindAction As bindAction)

        'todo protect

        Me.hwnd = findWin.Invoke(dm)

        bindAction.Invoke(dm, hwnd)

        'basePath = dm.GetBasePath()

        ' dm_ret = dm.SetPath(basePath)

        dm_ret = dm.SetDict(0, dictName)

        dm_ret = dm.GetClientSize(hwnd, zoneWidth, zoneHeight)

    End Sub


    Sub initMousePosition()

        dm.MoveTo(zoneWidth + 50, zoneHeight + 50)

    End Sub

    Shared Sub delay(ByVal ms)

        Threading.Thread.Sleep(ms)

    End Sub


    Sub unbind()

        dm.UnBindWindow()

    End Sub

    'wait function
    Sub waitUntil(ByVal gainDoneSign As gainDoneSign)


        Do While True

            If gainDoneSign(dm) Then

                Exit Do

            End If

        Loop

    End Sub

    Protected Overloads Sub Dispose()

        dm.UnBindWindow()

    End Sub

End Class

''' <summary>
''' 游戏初始化mydm助手，运用单例模式实现
''' </summary>
''' <remarks></remarks>
Public Class MyMxdGameInitHelper

    Inherits MyDmAtionConvenience

    Private Shared myMxdGameInitHelper As MyMxdGameInitHelper

    Shared Function getMyMxdGameInitHelper(ByVal basePath, ByVal dictName)

        If IsNothing(myMxdGameInitHelper) Then

            myMxdGameInitHelper = New MyMxdGameInitHelper(basePath, dictName)

        End If

        Return myMxdGameInitHelper

    End Function

    'Public Sub bindAction(ByVal dm As Dm.Idmsoft, ByVal hwnd As Integer)

    '    Dim dm_ret = dm.BindWindow(hwnd, "dx", "windows", "windows", 0)

    'End Sub

    'Public Function findHwnd(ByVal dm As Dm.Idmsoft) As Object

    '    'todo
    '    Dim hwnd = dm.FindWindow("", "记事本")

    '    Return hwnd

    'End Function

    Private Sub New(ByVal basePath, ByVal dictName)

        MyBase.New(basePath, dictName)


    End Sub

    Protected Overrides Sub bindActionToBeRealize(ByVal dm As Dm.Idmsoft, ByVal hwnd As Integer)
        Dim dm_ret = dm.BindWindow(hwnd, "dx", "windows", "windows", 0)
    End Sub

    Protected Overrides Function findHwndToBeRealize(ByVal dm As Dm.Idmsoft) As Object

        Dim hwnd = dm.FindWindow("MapleStoryClass", "MapleStory")

        Return hwnd
    End Function


End Class

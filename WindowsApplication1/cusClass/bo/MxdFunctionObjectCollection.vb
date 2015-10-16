''' <summary>
''' 游戏功能集合类，使得form等界面方便引用
''' </summary>
''' <remarks></remarks>
Public Class MxdFunctionObjectCollection

    Public bloodR As MxdBloodRecoverRelHelper
    Public mxd As MyMxdCommonHelper
    Public autoPress As MxdAutoPressHelper

    Property autoPick As AutoPressTask
    Property autoAttack As AutoPressTask

    Private myDm As MyDm

    Property autoPickKey = "z"

    Property autoAttackKey = "delete"

    Sub New(ByVal myDm, ByVal bloodR, ByVal mxd, ByVal autoPress)

        Me.myDm = myDm

        Me.bloodR = bloodR
        Me.mxd = mxd
        Me.autoPress = autoPress

        myInit()

    End Sub

    Private Sub myInit()

        autoPick = New AutoPressTask(myDm, autoPickKey, 500)
        autoAttack = New AutoPressTask(myDm, autoAttackKey, 500)

    End Sub





End Class

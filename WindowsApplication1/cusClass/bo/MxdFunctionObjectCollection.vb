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

    Sub New(ByVal bloodR, ByVal mxd, ByVal autoPress)

        Me.bloodR = bloodR
        Me.mxd = mxd
        Me.autoPress = autoPress

    End Sub



End Class

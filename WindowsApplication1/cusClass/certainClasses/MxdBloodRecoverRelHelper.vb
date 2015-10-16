''' <summary>
''' 自动回血回蓝相关
''' </summary>
''' <remarks></remarks>
Public Class MxdBloodRecoverRelHelper

    Inherits MyMxdHelperBase

    Property hpRecoverKey = "pgup"

    Sub New(ByVal myDm)

        MyBase.New(myDm)

    End Sub


    Sub recoverHp(ByVal ratio)

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

        If CInt(hpNow) / CDbl(maxHp) < ratio Then

            dm.KeyPressChar(hpRecoverKey)

        End If

    End Sub

End Class

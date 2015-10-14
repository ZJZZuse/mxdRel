Public Class BloodReplyRel

    Private dm

    Private basePath

    Private hpAll, hpNow, pAll, mpNow, hpProportion, mpProportion



    Public Sub init(ByVal dm)

        Me.dm = dm

    End Sub


    Private Sub findBhpMpS()

        Dim dm_ret, s

        dm = CreateObject("dm.dmsoft")

        dm_ret = dm.SetPath(basePath)
        dm_ret = dm.SetDict(0, "dm_soft.txt")

        s = dm.Ocr(295, 567, 392, 583, "ffffff-000000", 1.0)



    End Sub

End Class

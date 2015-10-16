Public MustInherit Class MyDmAtionConvenience

    Implements MyDmAtion

    Private basePath

    Private dictName

    Sub New(ByVal basePath, ByVal dictName)

        Me.basePath = basePath
        Me.dictName = dictName

    End Sub

    Public Sub bindAction(ByVal dm As Dm.Idmsoft, ByVal hwnd As Integer) Implements MyDmAtion.bindAction
        bindActionToBeRealize(dm, hwnd)
    End Sub

    Protected MustOverride Sub bindActionToBeRealize(ByVal dm As Dm.Idmsoft, ByVal hwnd As Integer)


    Public Function findHwnd(ByVal dm As Dm.Idmsoft) As Object Implements MyDmAtion.findHwnd

        Return findHwndToBeRealize(dm)

    End Function

    Protected MustOverride Function findHwndToBeRealize(ByVal dm As Dm.Idmsoft)

    Public Sub initMyDmMine(ByVal myDm As MyDm) Implements MyDmAtion.initMyDmMine
        myDm.basePath = basePath
        myDm.dictName = dictName
    End Sub

End Class

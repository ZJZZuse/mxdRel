''' <summary>
''' dm 便利抽象类，类是模版方法，so nice
''' </summary>
''' <remarks></remarks>
Public MustInherit Class MyDmSubBaseFormat

    Protected myDm As MyDm

    Protected dm As Dm.Idmsoft

    Protected dm_ret

    Sub New(ByVal myDm As MyDm)

        Me.myDm = myDm

        Me.dm = myDm.dm

    End Sub

End Class

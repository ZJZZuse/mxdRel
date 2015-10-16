Public Class MyMxdCommonHelper

    Inherits MyDmSubBaseFormat

    Sub New(ByVal myDm)

        MyBase.New(myDm)

    End Sub

    Sub autoPress(ByVal key)

        dm.KeyPressChar(key)

    End Sub

End Class

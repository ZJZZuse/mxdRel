''' <summary>
''' 自动按键集合封装类
''' </summary>
''' <remarks></remarks>
Public Class MxdAutoPressHelper

    Inherits MyMxdHelperBase

    Private autpPressTasks As New Collection

    WriteOnly Property enable()

        Set(ByVal value)
            enableAutpPressTasks(value)
        End Set

    End Property

    Sub New(ByVal myDm)

        MyBase.New(myDm)

    End Sub

    Sub add(ByVal autoPressTask, Optional ByVal key = Nothing)

        autpPressTasks.Add(autoPressTask, key)

    End Sub

    Sub remove(ByVal index)

        autpPressTasks.Remove(index)

    End Sub

    Sub clean()

        autpPressTasks.Clear()

    End Sub

    Private Sub enableAutpPressTasks(ByVal value As Object)

        For Each t As AutoPressTask In autpPressTasks

            t.enable = value

        Next

    End Sub

End Class

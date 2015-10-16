''' <summary>
''' 自动按键任务类，
''' </summary>
''' <remarks></remarks>
Public Class AutoPressTask

    Inherits MyMxdHelperBase
    ''' <summary>
    ''' the key want to press
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property key

    Property interval

        Get
            Return timer.Interval
        End Get
        Set(ByVal value)
            timer.Interval = value
        End Set
    End Property


    Property enable()

        Get
            Return timer.Enabled
        End Get
        Set(ByVal value)
            timer.Enabled = value
        End Set
    End Property

    Private WithEvents timer As New Timer

    Sub New(ByVal myDm)

        MyBase.New(myDm)


    End Sub

    Sub New(ByVal myDm, ByVal key, ByVal interval)

        Me.New(myDm)

        Me.key = key
        Me.interval = interval



    End Sub



    Sub timertick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer.Tick


        dm.KeyPressChar(key)


    End Sub


End Class

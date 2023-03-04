''' <summary>
''' Logs Errors
''' </summary>
Public Class ErrorLogger

    Private ErrorSource = Nothing
    ''' <summary>
    ''' Constructor capture the source of error
    ''' </summary>
    ''' <param name="obj"></param>
    Public Sub New(obj As Object)

        ErrorSource = obj

    End Sub
    ''' <summary>
    ''' Method to log the error
    ''' </summary>
    Public Sub LogError()

    End Sub

End Class

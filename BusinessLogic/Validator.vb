Imports System.Text.RegularExpressions
''' <summary>
''' Oakland Community College Project
''' Developer: Mateo Ortiz Date: 3/3/2023
''' Validate Data Members
''' </summary>
Public Class Validator
#Region "Fields"
    Private namesRegex As New Regex("^[a-zA-Z]+$")
    Private phoneRegex As New Regex("\d{3}-\d{3}-\d{4}")
    Private emailRegex As New Regex("\b[A-Za-z0-9._%+-]+@[A_Za-z0-9.-]+\.[a-z]{2,}\b")
#End Region
#Region "Function"
    ''' <summary>
    ''' Validate UI Fields before processing
    ''' The ValidateStudentInfo Function checks that all data returned
    ''' from the Web Form is valid before pssing on for processing
    ''' </summary>
    ''' <param name="StudentContactInfo" >Takes the Model to validate its properties or if its null</param>
    ''' <returns name="Boolean">True if all fields are not null, empty, or wrongly formatted</returns>
    ''' <exception cref="System.NullReferenceException">If the object is Null it throws exception and returns False</exception>
    ''' <remarks>Run Visual Studios All Test to Unit Test the functionality of this Function</remarks>
    Public Function ValidateStudentInfo(studentContactInfo As StudentContactInfo) As Boolean

        Try
            If Not String.IsNullOrEmpty(studentContactInfo.FirstName) And
               Not String.IsNullOrEmpty(studentContactInfo.LastName) And
               Not String.IsNullOrEmpty(studentContactInfo.Phone) And
               Not String.IsNullOrEmpty(studentContactInfo.Email) And
               namesRegex.IsMatch(studentContactInfo.FirstName) And
               namesRegex.IsMatch(studentContactInfo.LastName) And
               phoneRegex.IsMatch(studentContactInfo.Phone) And
               emailRegex.IsMatch(studentContactInfo.Email) Then

                Return True

            Else

                Return False

            End If

        Catch ex As System.NullReferenceException

            Return False

            Exit Try
        End Try

    End Function
#End Region
End Class

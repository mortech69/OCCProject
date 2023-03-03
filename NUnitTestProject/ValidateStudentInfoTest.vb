Imports BusinessLogic
Imports System.Text.RegularExpressions
Imports NUnit.Framework
''' <summary>
''' Oakland Community College Project
''' Developer: Mateo Ortiz Date: 3/3/2023
''' Unit Tests (VB)
''' </summary>
Namespace NUnitTestProject
    ''' <summary>
    ''' Unit Testing OCC Project
    ''' </summary>
    ''' 
    Public Class NUnitTests
        '===============ARRANGE=============================
#Region "Arrange"
        Private studentInfo, nullStudentInfo, emptyStudentInfo, badlyFormattedStudentInfo As New StudentContactInfo

        Private namesRegex As New Regex("^[a-zA-Z]+$")
        Private phoneRegex As New Regex("\d{3}-\d{3}-\d{4}")
        Private emailRegex As New Regex("\b[A-Za-z0-9._%+-]+@[A_Za-z0-9.-]+\.[a-z]{2,}\b")

        Private validateInfo As New Validator
#End Region
        <SetUp>
        Public Sub Setup()

            'Good Data
            studentInfo.FirstName = "Mateo"
            studentInfo.LastName = "Ortiz"
            studentInfo.Phone = "407-663-4000"
            studentInfo.Email = "mortiz@occ.com"

            'Null Object
            nullStudentInfo = Nothing

            'Empty Data
            emptyStudentInfo.FirstName = String.Empty
            emptyStudentInfo.LastName = String.Empty
            emptyStudentInfo.Phone = String.Empty
            emptyStudentInfo.Email = String.Empty

            'Bad Format
            badlyFormattedStudentInfo.FirstName = "12345"
            badlyFormattedStudentInfo.LastName = "@#$%^"
            badlyFormattedStudentInfo.Phone = "abcdfg-0000"
            badlyFormattedStudentInfo.Email = "bademailcom"
        End Sub
        '====================ACT AND ASSERT===============================
        ''' <summary>
        '''  'Simulates UI Fields Validation with Good Data
        ''' </summary>
        <Test>
        Public Sub TestModel()
            Assert.IsNotNull(studentInfo)
            Assert.IsNotEmpty(studentInfo.FirstName)
            Assert.IsNotEmpty(studentInfo.LastName)
            Assert.IsNotEmpty(studentInfo.Phone)
            Assert.IsNotEmpty(studentInfo.Email)
        End Sub
        ''' <summary>
        ''' 'Simulates UI Fields Validation with Null Object or Empty Fields
        ''' </summary>
        <Test>
        Public Sub TestEmptyAndNullModel()

            Assert.IsNull(nullStudentInfo) 'Null Object
            Assert.IsEmpty(emptyStudentInfo.FirstName)
            Assert.IsEmpty(emptyStudentInfo.LastName)
            Assert.IsEmpty(emptyStudentInfo.Phone)
            Assert.IsEmpty(emptyStudentInfo.Email)
        End Sub
        ''' <summary>
        '''  'Simulates UI Regular Expression Validation
        ''' </summary>
        <Test>
        Public Sub TestRegex()
            Dim Supported As Boolean
            'Good Format
            Supported = namesRegex.IsMatch(studentInfo.FirstName)
            Assert.IsTrue(Supported)
            Supported = namesRegex.IsMatch(studentInfo.LastName)
            Assert.IsTrue(Supported)
            Supported = phoneRegex.IsMatch(studentInfo.Phone)
            Assert.IsTrue(Supported)
            Supported = emailRegex.IsMatch(studentInfo.Email)
            Assert.IsTrue(Supported)
            'Bad Format
            Supported = namesRegex.IsMatch(badlyFormattedStudentInfo.FirstName)
            Assert.IsFalse(Supported)
            Supported = namesRegex.IsMatch(badlyFormattedStudentInfo.LastName)
            Assert.IsFalse(Supported)
            Supported = phoneRegex.IsMatch(badlyFormattedStudentInfo.Phone)
            Assert.IsFalse(Supported)
            Supported = emailRegex.IsMatch(badlyFormattedStudentInfo.Email)
            Assert.IsFalse(Supported)
        End Sub
        ''' <summary>
        ''' Test the Event Handler Validator
        ''' </summary>
        ''' <exception cref="System.NullReferenceException"></exception>
        ''' <remarks>
        ''' The ValidateStudentInfo Function checks that all data returned
        ''' from the Web Form is valid before pssing on for processing
        ''' </remarks>
        <Test>
        Public Sub TestEventHandlerValidation()

            'Good Data
            Assert.IsTrue(validateInfo.ValidateStudentInfo(studentInfo))

            'Null Object; this returns asserts if a System.NullReferenceException is thrown
            Assert.IsFalse(validateInfo.ValidateStudentInfo(nullStudentInfo))

            'Empty Data
            Assert.IsFalse(validateInfo.ValidateStudentInfo(emptyStudentInfo))

            'Bad Format
            Assert.IsFalse(validateInfo.ValidateStudentInfo(badlyFormattedStudentInfo))
        End Sub
    End Class
End Namespace
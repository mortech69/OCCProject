Imports BusinessLogic
''' <summary>
''' Oakland Community College Project
''' Developer: Mateo Ortiz Date: 3/3/2023
''' Code Behind ASP.NET Web Page (VB)
''' </summary>
''' 
#Region "Class System.Web.UI.Page"
Partial Class ProjectWebForm
    Inherits System.Web.UI.Page
#Region "Fields"
    Private studentContactInfo As New StudentContactInfo
    Private validateStudentInfo As New Validator
    Private processStudentRequest As New StudentRequestProcessor
#End Region
#Region "Event Handlers"
    ''' <summary>
    ''' If needed to handle something on Page Load or PostBack
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles MyClass.Load
        If Page.IsPostBack Then
            'Do something here....
        End If
    End Sub
    ''' <summary>
    ''' Handles InsertButton Click Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>
    ''' This method handles the form submit and collects the Web Form fields data, and passes them on for
    ''' validation. If returns validated equal True it then passes the data for processing and then triggers the Success Alert.
    ''' </remarks>
    Protected Sub InsertButton_Click(sender As Object, e As EventArgs) Handles InsertButton.Click

        Dim validated As Boolean

        If Page.IsValid Then

            studentContactInfo.FirstName = FirstNameTextBox.Text
            studentContactInfo.LastName = FirstNameTextBox.Text
            studentContactInfo.Phone = PhoneTextBox.Text
            studentContactInfo.Email = EmailTextBox.Text

            'Uncomment out below if want to see Error Alert
            studentContactInfo = Nothing

            'This method is unit tested (Run All Tests in Visual Studios Test)
            validated = validateStudentInfo.ValidateStudentInfo(studentContactInfo)

            If validated = True Then
                Success_Message.Visible = True
                processStudentRequest.ProcessRequest(studentContactInfo)
            End If

            If validated = False Then
                Error_Message.Visible = True
                Dim errorLogger = New ErrorLogger(Me)
            End If

        Else
            Error_Message.Visible = True
            Dim errorLogger = New ErrorLogger(Me)
        End If
    End Sub

    ''' <summary>
    ''' Clean Up Fields when Cancel
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Wrapped around IsPostBack just to indicate that a reloaded Page is returned</remarks>
    Protected Sub InsertCancelButton_Click(sender As Object, e As EventArgs) Handles InsertCancelButton.Click
        If Page.IsPostBack Then
            FirstNameTextBox.Text = String.Empty
            LastNameTextBox.Text = String.Empty
            PhoneTextBox.Text = String.Empty
            EmailTextBox.Text = String.Empty
            Success_Message.Visible = False
            Error_Message.Visible = False
        End If
    End Sub
#End Region
End Class
#End Region

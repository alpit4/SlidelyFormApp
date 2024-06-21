Imports Newtonsoft.Json
Imports System.Net

Public Class ViewSubmissionsForm
    Private submissions As List(Of Submission)
    Private currentIndex As Integer

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
        LoadSubmissions()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            DisplaySubmission(0)
        End If
    End Sub

    Private Sub LoadSubmissions()
        Try
            Dim client As New WebClient()
            Dim response As String = client.DownloadString("http://localhost:3000/read")
            submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(response)
            DisplaySubmission(0)
        Catch ex As Exception
            MessageBox.Show("Error loading submissions: " & ex.Message)
        End Try
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            Dim submission As Submission = submissions(index)
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhone.Text = submission.Phone
            txtGithubLink.Text = submission.GithubLink
            txtStopwatch.Text = submission.StopwatchTime
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.P
                    BtnPrevious_Click(sender, e)
                Case Keys.N
                    BtnNext_Click(sender, e)
            End Select
        End If
    End Sub
End Class

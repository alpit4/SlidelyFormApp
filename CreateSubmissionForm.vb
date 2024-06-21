Imports Newtonsoft.Json
Imports System.Net

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Private Sub BtnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        UpdateStopwatchLabel()
    End Sub

    Private Sub UpdateStopwatchLabel()
        lblStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .GithubLink = txtGithubLink.Text,
            .StopwatchTime = lblStopwatch.Text
        }

        Dim jsonData As String = JsonConvert.SerializeObject(submission)

        Try
            Dim client As New WebClient()
            client.Headers(HttpRequestHeader.ContentType) = "application/json"
            Dim response As String = client.UploadString("http://localhost:3000/submit", jsonData)
            MessageBox.Show("Submission successful: " & response)
        Catch ex As Exception
            MessageBox.Show("Error submitting data: " & ex.Message)
        End Try
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.T
                    BtnToggleStopwatch_Click(sender, e)
                Case Keys.S
                    BtnSubmit_Click(sender, e)
            End Select
        End If
    End Sub
End Class

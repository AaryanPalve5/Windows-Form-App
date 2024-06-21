Imports System.Net.Http
Imports Newtonsoft.Json

Public Class Form3
    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            nxt.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.V Then
            previous.PerformClick()
        End If
    End Sub

    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True ' Set KeyPreview property to True
        LoadSubmissions()
    End Sub

    Private Async Sub LoadSubmissions()
        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/submissions")
                response.EnsureSuccessStatusCode()

                Dim json As String = Await response.Content.ReadAsStringAsync()
                submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(json)

                ' Display the first submission
                DisplaySubmission(currentIndex)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving submissions: " & ex.Message)
        End Try
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        ' Display the submission at the given index
        Dim submission As Submission = submissions(index)
        TextBox1.Text = submission.Name
        email.Text = submission.Email
        phone.Text = submission.Phone
        link.Text = submission.github_link
        txtstp.Text = submission.stopwatch_time
    End Sub

    Private Sub nxt_Click(sender As Object, e As EventArgs) Handles nxt.Click
        ' Display the next submission
        MoveToNextSubmission()
    End Sub

    Private Sub previous_Click(sender As Object, e As EventArgs) Handles previous.Click
        ' Display the previous submission
        MoveToPreviousSubmission()
    End Sub

    Private Sub MoveToNextSubmission()
        currentIndex += 1

        If currentIndex >= submissions.Count Then
            ' If at the end, loop back to the first submission
            currentIndex = 0
        End If
        DisplaySubmission(currentIndex)
    End Sub

    Private Sub MoveToPreviousSubmission()
        currentIndex -= 1
        If currentIndex < 0 Then
            ' If at the beginning, loop back to the last submission
            currentIndex = submissions.Count - 1
        End If
        DisplaySubmission(currentIndex)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ' Handle label click if needed
    End Sub
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property github_link As String
    Public Property stopwatch_time As String
End Class

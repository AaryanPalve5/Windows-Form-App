Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Diagnostics

Public Class Form2
    Private stopwatch As New Stopwatch

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize timer
        Timer1.Interval = 1000 ' 1 second interval
        Me.KeyPreview = True
    End Sub

    ' Toggle Stopwatch Button Click
    Private Sub btntogglex_Click(sender As Object, e As EventArgs) Handles btntogglex.Click
        ToggleStopwatch()
    End Sub

    ' Timer Tick Event
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateStopwatchLabel()
    End Sub

    ' Update Stopwatch Label
    Private Sub UpdateStopwatchLabel()
        lbltoggle.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    ' Toggle Stopwatch Method
    Private Sub ToggleStopwatch()
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            Timer1.Stop()
        Else
            stopwatch.Start()
            Timer1.Start()
        End If
        UpdateStopwatchLabel()
    End Sub

    ' Start Stopwatch Method
    Private Sub StartStopwatch()
        If Not stopwatch.IsRunning Then
            stopwatch.Start()
            Timer1.Start()
        End If
        UpdateStopwatchLabel()
    End Sub

    ' Stop Stopwatch Method
    Private Sub StopStopwatch()
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            Timer1.Stop()
        End If
        UpdateStopwatchLabel()
    End Sub

    ' Form KeyDown Event
    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            ToggleStopwatch()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnsubmit3.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.R Then
            StartStopwatch()
        ElseIf e.Control AndAlso e.KeyCode = Keys.P Then
            StopStopwatch()
        End If
    End Sub

    ' Submit Button Click
    Private Async Sub btnsubmit3_Click(sender As Object, e As EventArgs) Handles btnsubmit3.Click
        Dim client As New HttpClient()
        Dim submission As New With {
            .name = txtname.Text,
            .email = txtemail.Text,
            .phone = txtnum.Text,
            .github_link = txtlink.Text,
            .stopwatch_time = lbltoggle.Text
        }

        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Try
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
            Dim responseString As String = Await response.Content.ReadAsStringAsync()
            MessageBox.Show(responseString)
        Catch ex As Exception
            MessageBox.Show("Error submitting data: " & ex.Message)
        End Try
    End Sub

    ' Handle text change events if needed
    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged
        ' Handle text change event if needed
    End Sub

    Private Sub txtemail_TextChanged(sender As Object, e As EventArgs) Handles txtemail.TextChanged
        ' Handle text change event if needed
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class

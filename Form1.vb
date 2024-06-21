Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure the form can capture key events
        Me.KeyPreview = True
    End Sub

    ' Create Form Button Click
    Private Sub createForm_Click(sender As Object, e As EventArgs) Handles createForm.Click
        Dim createForm As New Form2()
        createForm.Show()
    End Sub

    ' View Submissions Button Click
    Private Sub ViewSubmissionsButton_Click(sender As Object, e As EventArgs) Handles ViewSubmissionsButton.Click
        Dim createForm As New Form3()
        createForm.Show()
    End Sub

    ' Form KeyDown Event
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            createForm.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.V Then
            ViewSubmissionsButton.PerformClick()
        End If
    End Sub
End Class

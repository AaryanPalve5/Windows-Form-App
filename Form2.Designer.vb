Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Header = New Label()
        Label1 = New Label()
        txtlink = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txtemail = New TextBox()
        Label4 = New Label()
        txtname = New TextBox()
        txtnum = New TextBox()
        btnsubmit3 = New Button()
        Timer1 = New Timer(components)
        btntogglex = New Button()
        lbltoggle = New Label()
        SuspendLayout()
        ' 
        ' Header
        ' 
        Header.AutoSize = True
        Header.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Header.Location = New Point(29, 40)
        Header.Name = "Header"
        Header.Size = New Size(492, 31)
        Header.TabIndex = 1
        Header.Text = "Aaryan Palve, Slidely Task -2 Create Submission"
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(41, 265)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 50)
        Label1.TabIndex = 2
        Label1.Text = "Github Link for Task 2"
        ' 
        ' txtlink
        ' 
        txtlink.Location = New Point(164, 265)
        txtlink.Name = "txtlink"
        txtlink.Size = New Size(334, 27)
        txtlink.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(41, 215)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 40)
        Label2.TabIndex = 5
        Label2.Text = "Phone Num"
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(57, 172)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 40)
        Label3.TabIndex = 7
        Label3.Text = "Email"
        ' 
        ' txtemail
        ' 
        txtemail.Location = New Point(164, 172)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(334, 27)
        txtemail.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(54, 122)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 39)
        Label4.TabIndex = 9
        Label4.Text = "Name"
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(164, 122)
        txtname.Name = "txtname"
        txtname.Size = New Size(334, 27)
        txtname.TabIndex = 8
        ' 
        ' txtnum
        ' 
        txtnum.Location = New Point(164, 215)
        txtnum.Name = "txtnum"
        txtnum.Size = New Size(334, 27)
        txtnum.TabIndex = 10
        ' 
        ' btnsubmit3
        ' 
        btnsubmit3.BackColor = Color.Cyan
        btnsubmit3.Location = New Point(48, 425)
        btnsubmit3.Margin = New Padding(0)
        btnsubmit3.Name = "btnsubmit3"
        btnsubmit3.Size = New Size(473, 55)
        btnsubmit3.TabIndex = 11
        btnsubmit3.Text = "SUBMIT (CTRL + S)"
        btnsubmit3.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        ' 
        ' btntogglex
        ' 
        btntogglex.BackColor = Color.Yellow
        btntogglex.Location = New Point(57, 337)
        btntogglex.Name = "btntogglex"
        btntogglex.Size = New Size(289, 45)
        btntogglex.TabIndex = 12
        btntogglex.Text = "TOGGLE STOPWATCH(CTRL + T)"
        btntogglex.UseVisualStyleBackColor = False
        ' 
        ' lbltoggle
        ' 
        lbltoggle.BackColor = SystemColors.ScrollBar
        lbltoggle.BorderStyle = BorderStyle.FixedSingle
        lbltoggle.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbltoggle.Location = New Point(374, 337)
        lbltoggle.Name = "lbltoggle"
        lbltoggle.Size = New Size(102, 34)
        lbltoggle.TabIndex = 13
        lbltoggle.Text = "00:00:00"
        lbltoggle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(544, 517)
        Controls.Add(lbltoggle)
        Controls.Add(btntogglex)
        Controls.Add(btnsubmit3)
        Controls.Add(txtnum)
        Controls.Add(Label4)
        Controls.Add(txtname)
        Controls.Add(Label3)
        Controls.Add(txtemail)
        Controls.Add(Label2)
        Controls.Add(txtlink)
        Controls.Add(Label1)
        Controls.Add(Header)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Header As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtlink As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtnum As TextBox
    Friend WithEvents btnsubmit3 As Button


    Private Async Sub btnsubmit1_Click(sender As Object, e As EventArgs) Handles btnsubmit3.Click
        Dim client As New HttpClient()
        Dim submission As New With {
            .name = txtname.Text,
            .email = txtemail.Text,
            .phone = txtnum.Text,
            .github_link = txtlink.Text
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

    Friend WithEvents Timer1 As Timer
    Friend WithEvents btntogglex As Button
    Friend WithEvents lbltoggle As Label
End Class

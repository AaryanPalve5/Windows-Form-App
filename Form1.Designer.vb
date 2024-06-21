<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        createForm = New Button()
        ViewSubmissionsButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(471, 31)
        Label1.TabIndex = 0
        Label1.Text = "Aaryan Palve,Slidely Task 2- Slidely Form App"
        ' 
        ' createForm
        ' 
        createForm.BackColor = Color.Cyan
        createForm.Location = New Point(19, 180)
        createForm.Name = "createForm"
        createForm.Size = New Size(464, 54)
        createForm.TabIndex = 2
        createForm.Text = "CREATE NEW SUBMISSIONS(CTRL+N)"
        createForm.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsButton
        ' 
        ViewSubmissionsButton.BackColor = Color.Yellow
        ViewSubmissionsButton.Location = New Point(19, 109)
        ViewSubmissionsButton.Name = "ViewSubmissionsButton"
        ViewSubmissionsButton.Size = New Size(464, 49)
        ViewSubmissionsButton.TabIndex = 3
        ViewSubmissionsButton.Text = "VIEW SUBMISSIONS(CTRL+V)"
        ViewSubmissionsButton.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(499, 265)
        Controls.Add(ViewSubmissionsButton)
        Controls.Add(createForm)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents createForm As Button
    Friend WithEvents ViewSubmissionsButton As Button

End Class

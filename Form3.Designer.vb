<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        view_header = New Label()
        nxt = New Button()
        previous = New Button()
        TextBox1 = New TextBox()
        email = New TextBox()
        phone = New TextBox()
        link = New TextBox()
        Nm = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtstp = New TextBox()
        SuspendLayout()
        ' 
        ' view_header
        ' 
        view_header.AutoSize = True
        view_header.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        view_header.Location = New Point(32, 36)
        view_header.Name = "view_header"
        view_header.Size = New Size(475, 31)
        view_header.TabIndex = 2
        view_header.Text = "Aaryan Palve, Slidely Task -2 View Submission"
        ' 
        ' nxt
        ' 
        nxt.BackColor = SystemColors.ActiveCaption
        nxt.Location = New Point(313, 363)
        nxt.Name = "nxt"
        nxt.Size = New Size(240, 52)
        nxt.TabIndex = 3
        nxt.Text = "NEXT(CTRL+N)"
        nxt.UseVisualStyleBackColor = False
        ' 
        ' previous
        ' 
        previous.BackColor = Color.Yellow
        previous.Location = New Point(42, 363)
        previous.Name = "previous"
        previous.Size = New Size(246, 52)
        previous.TabIndex = 4
        previous.Text = "PREVIOUS (CTRL+P)"
        previous.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ScrollBar
        TextBox1.Location = New Point(204, 107)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(349, 27)
        TextBox1.TabIndex = 5
        ' 
        ' email
        ' 
        email.BackColor = SystemColors.ScrollBar
        email.Location = New Point(204, 159)
        email.Name = "email"
        email.ReadOnly = True
        email.Size = New Size(349, 27)
        email.TabIndex = 6
        ' 
        ' phone
        ' 
        phone.BackColor = SystemColors.ScrollBar
        phone.Location = New Point(204, 211)
        phone.Name = "phone"
        phone.ReadOnly = True
        phone.Size = New Size(349, 27)
        phone.TabIndex = 7
        ' 
        ' link
        ' 
        link.BackColor = SystemColors.ScrollBar
        link.Location = New Point(204, 260)
        link.Name = "link"
        link.ReadOnly = True
        link.Size = New Size(349, 27)
        link.TabIndex = 8
        ' 
        ' Nm
        ' 
        Nm.AutoSize = True
        Nm.Location = New Point(84, 114)
        Nm.Name = "Nm"
        Nm.Size = New Size(49, 20)
        Nm.TabIndex = 9
        Nm.Text = "Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(80, 211)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 20)
        Label1.TabIndex = 10
        Label1.Text = "Phone"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(84, 159)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 11
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(64, 248)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 55)
        Label3.TabIndex = 12
        Label3.Text = "Github Link For Task2"
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(64, 292)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 55)
        Label4.TabIndex = 13
        Label4.Text = "Stopwatch time"
        ' 
        ' txtstp
        ' 
        txtstp.BackColor = SystemColors.ScrollBar
        txtstp.Location = New Point(204, 304)
        txtstp.Name = "txtstp"
        txtstp.ReadOnly = True
        txtstp.Size = New Size(349, 27)
        txtstp.TabIndex = 14
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(597, 450)
        Controls.Add(txtstp)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Nm)
        Controls.Add(link)
        Controls.Add(phone)
        Controls.Add(email)
        Controls.Add(TextBox1)
        Controls.Add(previous)
        Controls.Add(nxt)
        Controls.Add(view_header)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents view_header As Label
    Friend WithEvents nxt As Button
    Friend WithEvents previous As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents phone As TextBox
    Friend WithEvents link As TextBox
    Friend WithEvents Nm As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtstp As TextBox
End Class

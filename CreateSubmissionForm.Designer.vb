<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        btnSubmit = New Button()
        btnToggleStopwatch = New Button()
        txtGithubLink = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        txtName = New TextBox()
        lblStopwatch = New Label()
        lblGithubLink = New Label()
        lblPhone = New Label()
        lblEmail = New Label()
        lblName = New Label()
        SuspendLayout()
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(250, 374)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(326, 64)
        btnSubmit.TabIndex = 23
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.Location = New Point(103, 289)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(268, 33)
        btnToggleStopwatch.TabIndex = 22
        btnToggleStopwatch.Text = "Start/Stop Stopwatch"
        btnToggleStopwatch.UseVisualStyleBackColor = True
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(317, 224)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(380, 27)
        txtGithubLink.TabIndex = 20
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(317, 162)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(380, 27)
        txtPhone.TabIndex = 19
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(317, 96)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(380, 27)
        txtEmail.TabIndex = 18
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(317, 40)
        txtName.Name = "txtName"
        txtName.Size = New Size(380, 27)
        txtName.TabIndex = 17
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Location = New Point(478, 295)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(63, 20)
        lblStopwatch.TabIndex = 16
        lblStopwatch.Text = "00:00:00"
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(143, 224)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(90, 20)
        lblGithubLink.TabIndex = 15
        lblGithubLink.Text = "GitHub Link "
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(160, 162)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(50, 20)
        lblPhone.TabIndex = 14
        lblPhone.Text = "Phone"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(160, 103)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 13
        lblEmail.Text = "Email"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(160, 44)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 12
        lblName.Text = "Name"
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblStopwatch)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        KeyPreview = True
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblName As Label
End Class

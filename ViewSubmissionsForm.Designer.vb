<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        btnNext = New Button()
        txtGithubLink = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        txtName = New TextBox()
        lblStopwatch = New Label()
        lblGithubLink = New Label()
        lblPhone = New Label()
        lblEmail = New Label()
        lblName = New Label()
        btnPrevious = New Button()
        txtStopwatch = New TextBox()
        SuspendLayout()
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(420, 365)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(326, 64)
        btnNext.TabIndex = 34
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(317, 210)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(380, 27)
        txtGithubLink.TabIndex = 32
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(317, 148)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(380, 27)
        txtPhone.TabIndex = 31
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(317, 82)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(380, 27)
        txtEmail.TabIndex = 30
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(317, 26)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(380, 27)
        txtName.TabIndex = 29
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Location = New Point(147, 281)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(116, 20)
        lblStopwatch.TabIndex = 28
        lblStopwatch.Text = "Stopwatch Time"
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(143, 210)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(90, 20)
        lblGithubLink.TabIndex = 27
        lblGithubLink.Text = "GitHub Link "
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(160, 148)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(50, 20)
        lblPhone.TabIndex = 26
        lblPhone.Text = "Phone"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(160, 89)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 25
        lblEmail.Text = "Email"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(160, 30)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 24
        lblName.Text = "Name"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(27, 365)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(326, 64)
        btnPrevious.TabIndex = 35
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.Location = New Point(349, 281)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(302, 27)
        txtStopwatch.TabIndex = 36
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtStopwatch)
        Controls.Add(btnPrevious)
        Controls.Add(btnNext)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblStopwatch)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents txtStopwatch As TextBox
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        btnViewSubmissions = New Button()
        btnCreateSubmission = New Button()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnViewSubmissions.Location = New Point(37, 131)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(280, 138)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "View Submission"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnCreateSubmission.Location = New Point(412, 131)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(285, 138)
        btnCreateSubmission.TabIndex = 1
        btnCreateSubmission.Text = "Create New Submission"
        btnCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCreateSubmission)
        Controls.Add(btnViewSubmissions)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button

End Class

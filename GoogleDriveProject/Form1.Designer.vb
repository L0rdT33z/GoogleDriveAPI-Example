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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Checking = New System.Windows.Forms.Timer(Me.components)
        Me.GetInfo = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.FilePath = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(21, 46)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(345, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Upload on Google Drive"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(21, 174)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(345, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Copy File"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(21, 148)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(345, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "File ID"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Checking
        '
        Me.Checking.Interval = 3000
        '
        'GetInfo
        '
        Me.GetInfo.Interval = 3000
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(21, 84)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(345, 20)
        Me.TextBox4.TabIndex = 15
        Me.TextBox4.Text = "File ID"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(21, 110)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(345, 23)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Delete File"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(21, 203)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(345, 20)
        Me.TextBox8.TabIndex = 26
        Me.TextBox8.Text = "File ID"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(21, 229)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(345, 23)
        Me.Button11.TabIndex = 25
        Me.Button11.Text = "Show File Owner"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'FilePath
        '
        Me.FilePath.Location = New System.Drawing.Point(102, 19)
        Me.FilePath.Name = "FilePath"
        Me.FilePath.Size = New System.Drawing.Size(264, 20)
        Me.FilePath.TabIndex = 27
        Me.FilePath.Text = "File Path"
        Me.FilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 272)
        Me.Controls.Add(Me.FilePath)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Google Drive API Example By Tee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Checking As Timer
    Friend WithEvents GetInfo As Timer
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button11 As Button
    Friend WithEvents FilePath As TextBox
End Class

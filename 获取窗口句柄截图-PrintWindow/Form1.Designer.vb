<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.HandleTextBox = New System.Windows.Forms.TextBox()
        Me.HandleImageBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.HandleImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HandleTextBox
        '
        Me.HandleTextBox.Location = New System.Drawing.Point(67, 13)
        Me.HandleTextBox.Name = "HandleTextBox"
        Me.HandleTextBox.Size = New System.Drawing.Size(159, 21)
        Me.HandleTextBox.TabIndex = 0
        '
        'HandleImageBox
        '
        Me.HandleImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HandleImageBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HandleImageBox.Location = New System.Drawing.Point(0, 0)
        Me.HandleImageBox.Name = "HandleImageBox"
        Me.HandleImageBox.Size = New System.Drawing.Size(284, 261)
        Me.HandleImageBox.TabIndex = 1
        Me.HandleImageBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "句柄："
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(225, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "截图"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HandleTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.HandleImageBox)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "句柄截图"
        CType(Me.HandleImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HandleTextBox As TextBox
    Friend WithEvents HandleImageBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class

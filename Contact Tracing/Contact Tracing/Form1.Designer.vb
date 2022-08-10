<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Labelname = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxAge = New System.Windows.Forms.TextBox()
        Me.LabelAge = New System.Windows.Forms.Label()
        Me.LabelContactNumber = New System.Windows.Forms.Label()
        Me.TextBoxContactnumber = New System.Windows.Forms.TextBox()
        Me.TextBoxaddresss = New System.Windows.Forms.TextBox()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.ButtonSubmit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonMale = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFemale = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Labelname
        '
        Me.Labelname.AutoSize = True
        Me.Labelname.Location = New System.Drawing.Point(27, 30)
        Me.Labelname.Name = "Labelname"
        Me.Labelname.Size = New System.Drawing.Size(38, 13)
        Me.Labelname.TabIndex = 0
        Me.Labelname.Text = "Name:"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(120, 27)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(174, 20)
        Me.TextBoxName.TabIndex = 1
        '
        'TextBoxAge
        '
        Me.TextBoxAge.Location = New System.Drawing.Point(120, 64)
        Me.TextBoxAge.Name = "TextBoxAge"
        Me.TextBoxAge.Size = New System.Drawing.Size(174, 20)
        Me.TextBoxAge.TabIndex = 2
        '
        'LabelAge
        '
        Me.LabelAge.AutoSize = True
        Me.LabelAge.Location = New System.Drawing.Point(27, 64)
        Me.LabelAge.Name = "LabelAge"
        Me.LabelAge.Size = New System.Drawing.Size(29, 13)
        Me.LabelAge.TabIndex = 3
        Me.LabelAge.Text = "Age:"
        '
        'LabelContactNumber
        '
        Me.LabelContactNumber.AutoSize = True
        Me.LabelContactNumber.Location = New System.Drawing.Point(27, 130)
        Me.LabelContactNumber.Name = "LabelContactNumber"
        Me.LabelContactNumber.Size = New System.Drawing.Size(87, 13)
        Me.LabelContactNumber.TabIndex = 7
        Me.LabelContactNumber.Text = "Contact Number:"
        '
        'TextBoxContactnumber
        '
        Me.TextBoxContactnumber.Location = New System.Drawing.Point(120, 127)
        Me.TextBoxContactnumber.Name = "TextBoxContactnumber"
        Me.TextBoxContactnumber.Size = New System.Drawing.Size(174, 20)
        Me.TextBoxContactnumber.TabIndex = 6
        '
        'TextBoxaddresss
        '
        Me.TextBoxaddresss.Location = New System.Drawing.Point(120, 92)
        Me.TextBoxaddresss.Name = "TextBoxaddresss"
        Me.TextBoxaddresss.Size = New System.Drawing.Size(174, 20)
        Me.TextBoxaddresss.TabIndex = 5
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Location = New System.Drawing.Point(27, 99)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(48, 13)
        Me.LabelAddress.TabIndex = 4
        Me.LabelAddress.Text = "Address:"
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.Location = New System.Drawing.Point(155, 241)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSubmit.TabIndex = 8
        Me.ButtonSubmit.Text = "Submit"
        Me.ButtonSubmit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonFemale)
        Me.GroupBox1.Controls.Add(Me.RadioButtonMale)
        Me.GroupBox1.Location = New System.Drawing.Point(64, 175)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 47)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'RadioButtonMale
        '
        Me.RadioButtonMale.AutoSize = True
        Me.RadioButtonMale.Location = New System.Drawing.Point(43, 19)
        Me.RadioButtonMale.Name = "RadioButtonMale"
        Me.RadioButtonMale.Size = New System.Drawing.Size(48, 17)
        Me.RadioButtonMale.TabIndex = 0
        Me.RadioButtonMale.TabStop = True
        Me.RadioButtonMale.Text = "Male"
        Me.RadioButtonMale.UseVisualStyleBackColor = True
        '
        'RadioButtonFemale
        '
        Me.RadioButtonFemale.AutoSize = True
        Me.RadioButtonFemale.Location = New System.Drawing.Point(156, 19)
        Me.RadioButtonFemale.Name = "RadioButtonFemale"
        Me.RadioButtonFemale.Size = New System.Drawing.Size(59, 17)
        Me.RadioButtonFemale.TabIndex = 1
        Me.RadioButtonFemale.TabStop = True
        Me.RadioButtonFemale.Text = "Female"
        Me.RadioButtonFemale.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 351)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonSubmit)
        Me.Controls.Add(Me.LabelContactNumber)
        Me.Controls.Add(Me.TextBoxContactnumber)
        Me.Controls.Add(Me.TextBoxaddresss)
        Me.Controls.Add(Me.LabelAddress)
        Me.Controls.Add(Me.LabelAge)
        Me.Controls.Add(Me.TextBoxAge)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Labelname)
        Me.Name = "Form1"
        Me.Text = "Contact Tracing App"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Labelname As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxAge As TextBox
    Friend WithEvents LabelAge As Label
    Friend WithEvents LabelContactNumber As Label
    Friend WithEvents TextBoxContactnumber As TextBox
    Friend WithEvents TextBoxaddresss As TextBox
    Friend WithEvents LabelAddress As Label
    Friend WithEvents ButtonSubmit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonFemale As RadioButton
    Friend WithEvents RadioButtonMale As RadioButton
End Class

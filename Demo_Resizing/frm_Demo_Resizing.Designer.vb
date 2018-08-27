<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Demo_Resizing
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
        Me.btn_01 = New System.Windows.Forms.Button()
        Me.btn_02 = New System.Windows.Forms.Button()
        Me.btn_04 = New System.Windows.Forms.Button()
        Me.btn_03 = New System.Windows.Forms.Button()
        Me.btn_05 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_01
        '
        Me.btn_01.Location = New System.Drawing.Point(0, 80)
        Me.btn_01.Name = "btn_01"
        Me.btn_01.Size = New System.Drawing.Size(125, 25)
        Me.btn_01.TabIndex = 0
        Me.btn_01.Text = "01"
        Me.btn_01.UseVisualStyleBackColor = True
        '
        'btn_02
        '
        Me.btn_02.Location = New System.Drawing.Point(130, 80)
        Me.btn_02.Name = "btn_02"
        Me.btn_02.Size = New System.Drawing.Size(125, 25)
        Me.btn_02.TabIndex = 1
        Me.btn_02.Text = "02"
        Me.btn_02.UseVisualStyleBackColor = True
        '
        'btn_04
        '
        Me.btn_04.Location = New System.Drawing.Point(85, 118)
        Me.btn_04.Name = "btn_04"
        Me.btn_04.Size = New System.Drawing.Size(80, 25)
        Me.btn_04.TabIndex = 4
        Me.btn_04.Text = "04"
        Me.btn_04.UseVisualStyleBackColor = True
        '
        'btn_03
        '
        Me.btn_03.Location = New System.Drawing.Point(0, 118)
        Me.btn_03.Name = "btn_03"
        Me.btn_03.Size = New System.Drawing.Size(80, 25)
        Me.btn_03.TabIndex = 3
        Me.btn_03.Text = "03"
        Me.btn_03.UseVisualStyleBackColor = True
        '
        'btn_05
        '
        Me.btn_05.Location = New System.Drawing.Point(170, 118)
        Me.btn_05.Name = "btn_05"
        Me.btn_05.Size = New System.Drawing.Size(80, 25)
        Me.btn_05.TabIndex = 5
        Me.btn_05.Text = "05"
        Me.btn_05.UseVisualStyleBackColor = True
        '
        'frm_Demo_Resizing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 193)
        Me.Controls.Add(Me.btn_05)
        Me.Controls.Add(Me.btn_04)
        Me.Controls.Add(Me.btn_03)
        Me.Controls.Add(Me.btn_02)
        Me.Controls.Add(Me.btn_01)
        Me.Name = "frm_Demo_Resizing"
        Me.Text = "Demo: Resizing"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_01 As Button
    Friend WithEvents btn_02 As Button
    Friend WithEvents btn_04 As Button
    Friend WithEvents btn_03 As Button
    Friend WithEvents btn_05 As Button
End Class

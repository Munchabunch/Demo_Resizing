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
        Me.oSplitContainer_01 = New System.Windows.Forms.SplitContainer()
        Me.btn_11 = New System.Windows.Forms.Button()
        Me.btn_12 = New System.Windows.Forms.Button()
        Me.btn_13 = New System.Windows.Forms.Button()
        CType(Me.oSplitContainer_01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.oSplitContainer_01.Panel1.SuspendLayout()
        Me.oSplitContainer_01.Panel2.SuspendLayout()
        Me.oSplitContainer_01.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_01
        '
        Me.btn_01.Location = New System.Drawing.Point(0, 44)
        Me.btn_01.Name = "btn_01"
        Me.btn_01.Size = New System.Drawing.Size(125, 25)
        Me.btn_01.TabIndex = 0
        Me.btn_01.Text = "01"
        Me.btn_01.UseVisualStyleBackColor = True
        '
        'btn_02
        '
        Me.btn_02.Location = New System.Drawing.Point(130, 44)
        Me.btn_02.Name = "btn_02"
        Me.btn_02.Size = New System.Drawing.Size(125, 25)
        Me.btn_02.TabIndex = 1
        Me.btn_02.Text = "02"
        Me.btn_02.UseVisualStyleBackColor = True
        '
        'btn_04
        '
        Me.btn_04.Location = New System.Drawing.Point(85, 82)
        Me.btn_04.Name = "btn_04"
        Me.btn_04.Size = New System.Drawing.Size(80, 25)
        Me.btn_04.TabIndex = 4
        Me.btn_04.Text = "04"
        Me.btn_04.UseVisualStyleBackColor = True
        '
        'btn_03
        '
        Me.btn_03.Location = New System.Drawing.Point(0, 82)
        Me.btn_03.Name = "btn_03"
        Me.btn_03.Size = New System.Drawing.Size(80, 25)
        Me.btn_03.TabIndex = 3
        Me.btn_03.Text = "03"
        Me.btn_03.UseVisualStyleBackColor = True
        '
        'btn_05
        '
        Me.btn_05.Location = New System.Drawing.Point(170, 82)
        Me.btn_05.Name = "btn_05"
        Me.btn_05.Size = New System.Drawing.Size(80, 25)
        Me.btn_05.TabIndex = 5
        Me.btn_05.Text = "05"
        Me.btn_05.UseVisualStyleBackColor = True
        '
        'oSplitContainer_01
        '
        Me.oSplitContainer_01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.oSplitContainer_01.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oSplitContainer_01.Location = New System.Drawing.Point(0, 0)
        Me.oSplitContainer_01.Name = "oSplitContainer_01"
        Me.oSplitContainer_01.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'oSplitContainer_01.Panel1
        '
        Me.oSplitContainer_01.Panel1.Controls.Add(Me.btn_02)
        Me.oSplitContainer_01.Panel1.Controls.Add(Me.btn_05)
        Me.oSplitContainer_01.Panel1.Controls.Add(Me.btn_01)
        Me.oSplitContainer_01.Panel1.Controls.Add(Me.btn_04)
        Me.oSplitContainer_01.Panel1.Controls.Add(Me.btn_03)
        '
        'oSplitContainer_01.Panel2
        '
        Me.oSplitContainer_01.Panel2.Controls.Add(Me.btn_13)
        Me.oSplitContainer_01.Panel2.Controls.Add(Me.btn_12)
        Me.oSplitContainer_01.Panel2.Controls.Add(Me.btn_11)
        Me.oSplitContainer_01.Size = New System.Drawing.Size(296, 292)
        Me.oSplitContainer_01.SplitterDistance = 146
        Me.oSplitContainer_01.TabIndex = 6
        '
        'btn_11
        '
        Me.btn_11.Location = New System.Drawing.Point(0, 0)
        Me.btn_11.Name = "btn_11"
        Me.btn_11.Size = New System.Drawing.Size(75, 25)
        Me.btn_11.TabIndex = 0
        Me.btn_11.Text = "11"
        Me.btn_11.UseVisualStyleBackColor = True
        '
        'btn_12
        '
        Me.btn_12.Location = New System.Drawing.Point(0, 30)
        Me.btn_12.Name = "btn_12"
        Me.btn_12.Size = New System.Drawing.Size(75, 25)
        Me.btn_12.TabIndex = 1
        Me.btn_12.Text = "12"
        Me.btn_12.UseVisualStyleBackColor = True
        '
        'btn_13
        '
        Me.btn_13.Location = New System.Drawing.Point(0, 60)
        Me.btn_13.Name = "btn_13"
        Me.btn_13.Size = New System.Drawing.Size(75, 25)
        Me.btn_13.TabIndex = 2
        Me.btn_13.Text = "13"
        Me.btn_13.UseVisualStyleBackColor = True
        '
        'frm_Demo_Resizing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 292)
        Me.Controls.Add(Me.oSplitContainer_01)
        Me.Name = "frm_Demo_Resizing"
        Me.Text = "Demo: Resizing"
        Me.oSplitContainer_01.Panel1.ResumeLayout(False)
        Me.oSplitContainer_01.Panel2.ResumeLayout(False)
        CType(Me.oSplitContainer_01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.oSplitContainer_01.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_01 As Button
    Friend WithEvents btn_02 As Button
    Friend WithEvents btn_04 As Button
    Friend WithEvents btn_03 As Button
    Friend WithEvents btn_05 As Button
    Friend WithEvents oSplitContainer_01 As SplitContainer
    Friend WithEvents btn_13 As Button
    Friend WithEvents btn_12 As Button
    Friend WithEvents btn_11 As Button
End Class

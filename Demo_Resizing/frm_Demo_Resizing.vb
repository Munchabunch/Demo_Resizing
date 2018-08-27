Public Class frm_Demo_Resizing

    Private Sub frm_Demo_Resizing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeUniformly({btn_01, btn_02}, Me.ClientSize.Width.ToString)
        ResizeUniformly({btn_03, btn_04, btn_05}, Me.ClientSize.Width.ToString)
    End Sub

    Private Sub frm_Demo_Resizing_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        ResizeUniformly({btn_01, btn_02}, Me.ClientSize.Width.ToString)
        ResizeUniformly({btn_03, btn_04, btn_05}, Me.ClientSize.Width.ToString)
    End Sub

    Private Sub ResizeUniformly(ctrls As Control(), TotalWidth_New As Integer)

        Dim ctrl_Working As Control
        Dim ctrl_Previous As Control
        Dim CtrlWidth_Old As Integer
        Dim CtrlWidth_New As Integer
        Dim GutterWidth As Integer
        Dim CombinedGutterWidth As Integer
        Dim TotalWidth_Old As Integer
        Dim i_CtrlNum As Integer


        CtrlWidth_Old = ctrls(0).Width
        GutterWidth = ctrls(1).Left - ctrls(0).Right
        CombinedGutterWidth = GutterWidth * (ctrls.Length - 1)
        TotalWidth_Old = (CtrlWidth_Old * ctrls.Length) + CombinedGutterWidth

        CtrlWidth_New = (TotalWidth_New - CombinedGutterWidth) \ ctrls.Length

        '// Resize the first control:
        ctrls(0).Width = CtrlWidth_New
        ctrl_Previous = ctrls(0)

        '// Move and resize the rest of the controls:
        For i_CtrlNum = 1 To ctrls.Length - 1
            ctrl_Working = ctrls(i_CtrlNum)
            ctrl_Working.Width = CtrlWidth_New
            ctrl_Working.Left = ctrl_Previous.Right + GutterWidth
            ctrl_Previous = ctrl_Working
        Next i_CtrlNum

    End Sub

End Class

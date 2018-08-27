Public Class frm_Demo_Resizing

    Private Sub frm_Demo_Resizing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeUniformly_Horizontal({btn_01, btn_02}, Me.ClientSize.Width)
        ResizeUniformly_Horizontal({btn_03, btn_04, btn_05}, Me.ClientSize.Width)
        ResizeUniformly_Vertical({btn_11, btn_12, btn_13}, oSplitContainer_01.Panel2.Height)
    End Sub

    Private Sub frm_Demo_Resizing_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        ResizeUniformly_Horizontal({btn_01, btn_02}, Me.ClientSize.Width)
        ResizeUniformly_Horizontal({btn_03, btn_04, btn_05}, Me.ClientSize.Width)
    End Sub

    Private Sub oSplitContainer_01_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles oSplitContainer_01.SplitterMoved
        ResizeUniformly_Vertical({btn_11, btn_12, btn_13}, oSplitContainer_01.Panel2.Height)
    End Sub

    Private Sub ResizeUniformly_Horizontal(ctrls As Control(), TotalWidth_New As Integer)

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

    Private Sub ResizeUniformly_Vertical(ctrls As Control(), TotalHeight_New As Integer)

        Dim ctrl_Working As Control
        Dim ctrl_Previous As Control
        Dim CtrlHeight_Old As Integer
        Dim CtrlHeight_New As Integer
        Dim GutterHeight As Integer
        Dim CombinedGutterHeight As Integer
        Dim TotalHeight_Old As Integer
        Dim i_CtrlNum As Integer


        CtrlHeight_Old = ctrls(0).Height
        GutterHeight = ctrls(1).Top - ctrls(0).Bottom
        CombinedGutterHeight = GutterHeight * (ctrls.Length - 1)
        TotalHeight_Old = (CtrlHeight_Old * ctrls.Length) + CombinedGutterHeight

        CtrlHeight_New = (TotalHeight_New - CombinedGutterHeight) \ ctrls.Length

        '// Resize the first control:
        ctrls(0).Height = CtrlHeight_New
        ctrl_Previous = ctrls(0)

        '// Move and resize the rest of the controls:
        For i_CtrlNum = 1 To ctrls.Length - 1
            ctrl_Working = ctrls(i_CtrlNum)
            ctrl_Working.Height = CtrlHeight_New
            ctrl_Working.Top = ctrl_Previous.Bottom + GutterHeight
            ctrl_Previous = ctrl_Working
        Next i_CtrlNum

    End Sub

End Class

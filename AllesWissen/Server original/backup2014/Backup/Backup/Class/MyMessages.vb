Public Class MyMessages
    Public Const RequestConnect As String = "#Hl"
    Public Const Disconnect As String = "#B"
    Public Const AcknowledgeOK As String = "#OK"
    Public Const AcknowledgeCancel As String = "#Cc"
    Public Const SendAnswer As String = "#AH"
    Public Const SendTeamName As String = "#TN"
    Public Const StartNormal As String = "#Nm"
    Public Const StartAnswerOnce As String = "#A1"
    Public Const StopAnswer As String = "#Sp"
    Public Const SendQuestion As String = "#SQuest"
    'New:
    Public Const SendThiSinh As String = "#STS"
    Public Const ShowScore As String = "#ShowScore" 'Send and show score
    Public Const SendScores As String = "#SendScore" ' Send score only
    Public Const ShowWait As String = "#ShowWait" 'Show waiting screen
    Public Const ClientTime As String = "#ClientTime"
    'Giành quyền trả lời:
    Public Const AllowCNV As String = "#AllowCNV" 'Cho phép trả lời CNV
    Public Const AllowVeDich As String = "#AllowVD" 'Cho phép trả lời về đích
    Public Const AnswerCNV As String = "#AnswerCNV"
    Public Const AnswerVeDich As String = "#AnsVeDich"
    Public Const HideCNV As String = "#HideCNV" 'Ẩn nút trả lời CNV
    Public Const HideVeDich As String = "#HideVD"
    Public Const DisableVeDich As String = "#DisVD"
    'Intro Group
    Public Const ShowIntroKD As String = "#InKD"
    Public Const ShowIntroVD As String = "#InVD"
    Public Const ShowIntroVCNV As String = "#InVCNV"
    Public Const ShowIntroTT As String = "#InTT"
End Class

Public Class MsgKhoiDong
    Public Const ShowKhoiDong As String = "#ShowKD"
    Public Const SendFileName As String = "#KDSFile"
    Public Const StartKhoiDong As String = "#StartKD"
End Class

Public Class MsgTangToc
    Public Const StartAnswer As String = "#StartAnsTT"
    Public Const ShowTangToc As String = "#ShowTaTc"
    Public Const ShowTTAnswer As String = "#ShowTTAns"
End Class

Public Class MsgVCNV
    Public Const StartAnswer As String = "#StartAnsVCNV"
    Public Const ShowVCNV As String = "#ShowVCNV"
    Public Const ShowVCNVAnswer As String = "#ShowVCNVAns"
    Public Const IDAnswerCNV As String = "#IDCNV"
    Public Const ShowVCNVPic As String = "#Pic"
End Class

Public Class MsgVeDich
    Public Const ShowVeDich As String = "#ShowVeDich"
    Public Const IDAnswerVeDich As String = "#IDVeDich"
End Class
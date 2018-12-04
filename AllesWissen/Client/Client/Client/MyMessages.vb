Public Class MyMessages

    Public Const RequestConnect As String = "#Hl"
    Public Const RequestMCConnect As String = "#MC" 'upgrate MC seperately
    Public Const Disconnect As String = "#B"
    Public Const DisconnectMC As String = "#DM" 'upgrate MC seperately
    Public Const AcknowledgeOK As String = "#OK"
    Public Const AcknowledgeCancel As String = "#Cc"
    Public Const SendAnswer As String = "#AH"
    Public Const SendTeamName As String = "#TN"
    Public Const RestartRequest As String = "#RQ"
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

    Public Const FormClose As String = "#CloseForm"
    Public Const IDGianh As String = "#IDGianh"
    Public Const StartGianh As String = "#StartGianh"
    Public Const DisGianh As String = "#DisGianh"
End Class

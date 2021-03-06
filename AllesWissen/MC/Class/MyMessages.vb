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
    Public Const SendEasy As String = "#EasyKD"
    Public Const SendMedium As String = "#MediumKD"
    Public Const SendHard As String = "#HardKD"
    Public Const BackQuestKD As String = "#BackKD"
    Public Const NextQuestKD As String = "#NextKD"
    Public Const StartQuestKD As String = "#StartKD"
    Public Const StopQuestKD As String = "#StopKD"
End Class

Public Class MsgTangToc
    Public Const StartAnswer As String = "#StartAnsTT"
    Public Const ShowTangToc As String = "#ShowTaTc"
    Public Const ShowTTAnswer As String = "#ShowTTAns"
    Public Const BackQuest3 As String = "#Back3"
    Public Const NextQuest3 As String = "#Next3"
    Public Const StartQuest3 As String = "#Start3"
    Public Const StopQuest3 As String = "#Stop3"
End Class

Public Class MsgVCNV
    Public Const StartAnswer As String = "#StartAnsVCNV"
    Public Const ShowVCNV As String = "#ShowVCNV"
    Public Const ShowVCNVAnswer As String = "#ShowVCNVAns"
    Public Const IDAnswerCNV As String = "#IDCNV"
    Public Const ShowVCNVPic As String = "#Pic"
    Public Const NextR2 As String = "#NextR2"
End Class

Public Class MsgVeDich
    Public Const ShowVeDich As String = "#ShowVeDich"
    Public Const IDAnswerVeDich As String = "#IDVeDich"
    Public Const ClearVeDich As String = "#ClearVeDich"
    Public Const Sport1 As String = "#Sport1"
    Public Const Sport2 As String = "#Sport2"
    Public Const Sport3 As String = "#Sport3"
    Public Const SportE As String = "#SportE"
    Public Const Music1 As String = "#Music1"
    Public Const Music2 As String = "#Music2"
    Public Const Music3 As String = "#Music3"
    Public Const MusicE As String = "#MusicE"
    Public Const HisGeo1 As String = "#HisGeo1"
    Public Const HisGeo2 As String = "#HisGeo2"
    Public Const HisGeo3 As String = "#HisGeo3"
    Public Const HisGeoE As String = "#HisGeoE"
    Public Const Science1 As String = "#Science1"
    Public Const Science2 As String = "#Science2"
    Public Const Science3 As String = "#Science3"
    Public Const ScienceE As String = "#ScienceE"
    Public Const FA1 As String = "#FA1"
    Public Const FA2 As String = "#FA2"
    Public Const FA3 As String = "#FA3"
    Public Const FAE As String = "#FAE"
    Public Const EEIT1 As String = "#EEIT1"
    Public Const EEIT2 As String = "#EEIT2"
    Public Const EEIT3 As String = "#EEIT3"
    Public Const EEITE As String = "#EEITE"
    Public Const CS1 As String = "#CS1"
    Public Const CS2 As String = "#CS2"
    Public Const CS3 As String = "#CS3"
    Public Const CSE As String = "#CSE"
End Class
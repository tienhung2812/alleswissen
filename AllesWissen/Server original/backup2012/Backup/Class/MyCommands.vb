Public Class MyCommands
    Public Const Normal As Integer = 0
    Public Const StartNormal As Integer = 1
    Public Const StartAnswerOnce As Integer = 2
    Public Const StartAnswerOnceTime As Integer = 3
    Public Const StartTimeTik As Integer = 4
    Public Const SendQuestion As Integer = 5
    Public Const StopAnswer As Integer = 9
    'New:
    Public Const SendClientTime As Integer = 10 'Thời gian trả lời cho máy client
    Public Const SendSpecial As Integer = 99
    Public Const SendThiSinhID As Integer = 98
    Public Const ShowScore As Integer = 97
    Public Const SendScore As Integer = 11
    Public Const ShowWait As Integer = 96 'Hiện form chờ    
    'Tăng tốc:
    Public Const ShowAnswerTangToc As Integer = 95
    Public Const ShowTangToc As Integer = 94
    'Vượt chướng ngại vật:
    Public Const ShowAnswerVCNV As Integer = 93
    Public Const ShowVCNV As Integer = 92
    Public Const AllowCNV As Integer = 91 'Cho phép trả lời CNV
    Public Const HideCNV As Integer = 90 'Ẩn nút trả lời CNV
    Public Const SendIDAnswerCNV As Integer = 89 'Gửi ID thí sinh trả lời CNV
    'Về đích:
    Public Const ShowVeDich As Integer = 88
    Public Const AllowVeDich As Integer = 87
    Public Const SendIDAnswerVeDich As Integer = 86
    Public Const HideVeDich As Integer = 85
    Public Const DisableVeDich As Integer = 84

    'Intro:
    Public Const ShowIntroKD As Integer = 80
    Public Const ShowIntroVCNV As Integer = 79
    Public Const ShowIntroTT As Integer = 78
    Public Const ShowIntroVD As Integer = 77
    'Vượt chướng ngại vật: hình gợi ý
    Public Const ShowVCNVPic As Integer = 76
End Class
Public Class Form2

#Region "プロパティ"
    ''' <summary>
    ''' 中日ドラゴンズ
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property SeCD As Boolean
        Get
            Return Me.chkSeCD.Checked
        End Get
    End Property
    ''' <summary>
    ''' DeNAベイスターズ
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property SeDB As Boolean
        Get
            Return Me.chkSeDB.Checked
        End Get
    End Property
    ''' <summary>
    ''' 阪神タイガース
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property SeHT As Boolean
        Get
            Return Me.chkSeHT.Checked
        End Get
    End Property
    ''' <summary>
    ''' 東洋カープ
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property SeTC As Boolean
        Get
            Return Me.chkSeTC.Checked
        End Get
    End Property
    ''' <summary>
    ''' 読売ジャイアンツ
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property SeYG As Boolean
        Get
            Return Me.chkSeYG.Checked
        End Get
    End Property
    ''' <summary>
    ''' ヤクルトスワローズ
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property SeYS As Boolean
        Get
            Return Me.chkSeYS.Checked
        End Get
    End Property


    ''' <summary>
    ''' ロッテマリーンズ
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property PaLM As Boolean
        Get
            Return Me.chkPaLM.Checked
        End Get
    End Property
    ''' <summary>
    ''' 日本ハムファイターズ
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property PaNF As Boolean
        Get
            Return Me.chkPaNF.Checked
        End Get
    End Property
    ''' <summary>
    ''' オリックスバファローズ
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property PaOB As Boolean
        Get
            Return Me.chkPaOB.Checked
        End Get
    End Property
    ''' <summary>
    ''' 楽天ゴールデンイーグルス
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property PaRE As Boolean
        Get
            Return Me.chkPaRE.Checked
        End Get
    End Property
    ''' <summary>
    ''' ソフトバンクホークス
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property PaSH As Boolean
        Get
            Return Me.chkPaSH.Checked
        End Get
    End Property
    ''' <summary>
    ''' 西武ライオンズ
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property PaSL As Boolean
        Get
            Return Me.chkPaSL.Checked
        End Get
    End Property

    Public ReadOnly Property PosEikyu As Boolean
        Get
            Return Me.chkPosEikyu.Checked
        End Get
    End Property
    Public ReadOnly Property PosGaiya As Boolean
        Get
            Return Me.chkPosGaiya.Checked
        End Get
    End Property
    Public ReadOnly Property PosHoshu As Boolean
        Get
            Return Me.chkPosHoshu.Checked
        End Get
    End Property
    Public ReadOnly Property PosIkuseiGaiya As Boolean
        Get
            Return Me.chkPosIkuseiGaiya.Checked
        End Get
    End Property
    Public ReadOnly Property PosIkuseiHoshu As Boolean
        Get
            Return Me.chkPosIkuseiHoshu.Checked
        End Get
    End Property
    Public ReadOnly Property PosIkuseiNaiya As Boolean
        Get
            Return Me.chkPosIkuseiNaiya.Checked
        End Get
    End Property
    Public ReadOnly Property PosIkuseiToshu As Boolean
        Get
            Return Me.chkPosIkuseiToshu.Checked
        End Get
    End Property
    Public ReadOnly Property PosKantoku As Boolean
        Get
            Return Me.chkPosKantoku.Checked
        End Get
    End Property
    Public ReadOnly Property PosNaiya As Boolean
        Get
            Return Me.chkPosNaiya.Checked
        End Get
    End Property
    Public ReadOnly Property PosStaf As Boolean
        Get
            Return Me.chkPosStaf.Checked
        End Get
    End Property
    Public ReadOnly Property PosToshu As Boolean
        Get
            Return Me.chkPosToshu.Checked
        End Get
    End Property
#End Region

#Region "イベント"
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'リーグ
        Me.chkRgSe.Checked = True
        Me.chkRgPa.Checked = True
        'セリーグ球団
        Me.chkSeCD.Checked = True
        Me.chkSeDB.Checked = True
        Me.chkSeHT.Checked = True
        Me.chkSeTC.Checked = True
        Me.chkSeYG.Checked = True
        Me.chkSeYS.Checked = True
        'パリーグ球団
        Me.chkPaLM.Checked = True
        Me.chkPaNF.Checked = True
        Me.chkPaOB.Checked = True
        Me.chkPaRE.Checked = True
        Me.chkPaSH.Checked = True
        Me.chkPaSL.Checked = True
        'ポジション
        Me.chkPosEikyu.Checked = True
        Me.chkPosGaiya.Checked = True
        Me.chkPosHoshu.Checked = True
        Me.chkPosIkuseiGaiya.Checked = True
        Me.chkPosIkuseiHoshu.Checked = True
        Me.chkPosIkuseiNaiya.Checked = True
        Me.chkPosIkuseiToshu.Checked = True
        Me.chkPosKantoku.Checked = True
        Me.chkPosNaiya.Checked = True
        Me.chkPosStaf.Checked = True
        Me.chkPosToshu.Checked = True
    End Sub

    Private Sub chkRgSe_CheckedChanged(sender As Object, e As EventArgs) Handles chkRgSe.CheckedChanged
        If Me.chkRgSe.Checked = True Then
            Me.chkSeCD.Checked = True
            Me.chkSeDB.Checked = True
            Me.chkSeHT.Checked = True
            Me.chkSeTC.Checked = True
            Me.chkSeYG.Checked = True
            Me.chkSeYS.Checked = True

            Me.chkSeCD.Enabled = True
            Me.chkSeDB.Enabled = True
            Me.chkSeHT.Enabled = True
            Me.chkSeTC.Enabled = True
            Me.chkSeYG.Enabled = True
            Me.chkSeYS.Enabled = True
        Else
            Me.chkSeCD.Checked = False
            Me.chkSeDB.Checked = False
            Me.chkSeHT.Checked = False
            Me.chkSeTC.Checked = False
            Me.chkSeYG.Checked = False
            Me.chkSeYS.Checked = False

            Me.chkSeCD.Enabled = False
            Me.chkSeDB.Enabled = False
            Me.chkSeHT.Enabled = False
            Me.chkSeTC.Enabled = False
            Me.chkSeYG.Enabled = False
            Me.chkSeYS.Enabled = False
        End If
    End Sub

    Private Sub chkRgPa_CheckedChanged(sender As Object, e As EventArgs) Handles chkRgPa.CheckedChanged
        If Me.chkRgPa.Checked = True Then
            Me.chkPaLM.Checked = True
            Me.chkPaNF.Checked = True
            Me.chkPaOB.Checked = True
            Me.chkPaRE.Checked = True
            Me.chkPaSH.Checked = True
            Me.chkPaSL.Checked = True

            Me.chkPaLM.Enabled = True
            Me.chkPaNF.Enabled = True
            Me.chkPaOB.Enabled = True
            Me.chkPaRE.Enabled = True
            Me.chkPaSH.Enabled = True
            Me.chkPaSL.Enabled = True
        Else
            Me.chkPaLM.Checked = False
            Me.chkPaNF.Checked = False
            Me.chkPaOB.Checked = False
            Me.chkPaRE.Checked = False
            Me.chkPaSH.Checked = False
            Me.chkPaSL.Checked = False

            Me.chkPaLM.Enabled = False
            Me.chkPaNF.Enabled = False
            Me.chkPaOB.Enabled = False
            Me.chkPaRE.Enabled = False
            Me.chkPaSH.Enabled = False
            Me.chkPaSL.Enabled = False
        End If
    End Sub

    Private Sub KyudanPos_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeCD.CheckedChanged, chkSeDB.CheckedChanged,
                                                                                   chkSeHT.CheckedChanged, chkSeTC.CheckedChanged,
                                                                                   chkSeYG.CheckedChanged, chkSeYS.CheckedChanged,
                                                                                   chkPaLM.CheckedChanged, chkPaNF.CheckedChanged,
                                                                                   chkPaOB.CheckedChanged, chkPaRE.CheckedChanged,
                                                                                   chkPaSH.CheckedChanged, chkPaSL.CheckedChanged,
                                                                                   chkPosEikyu.CheckedChanged, chkPosGaiya.CheckedChanged,
                                                                                   chkPosHoshu.CheckedChanged, chkPosIkuseiGaiya.CheckedChanged,
                                                                                   chkPosIkuseiHoshu.CheckedChanged, chkPosIkuseiNaiya.CheckedChanged,
                                                                                   chkPosIkuseiToshu.CheckedChanged, chkPosKantoku.CheckedChanged,
                                                                                   chkPosNaiya.CheckedChanged, chkPosStaf.CheckedChanged,
                                                                                   chkPosToshu.CheckedChanged
        If Me.chkSeCD.Checked = False AndAlso Me.chkSeDB.Checked = False AndAlso
           Me.chkSeHT.Checked = False AndAlso Me.chkSeTC.Checked = False AndAlso
           Me.chkSeYG.Checked = False AndAlso Me.chkSeYS.Checked = False AndAlso
           Me.chkPaLM.Checked = False AndAlso Me.chkPaNF.Checked = False AndAlso
           Me.chkPaOB.Checked = False AndAlso Me.chkPaRE.Checked = False AndAlso
           Me.chkPaSH.Checked = False AndAlso Me.chkPaSL.Checked = False AndAlso
           Me.chkPosEikyu.Checked = False AndAlso Me.chkPosGaiya.Checked = False AndAlso
           Me.chkPosHoshu.Checked = False AndAlso Me.chkPosIkuseiGaiya.Checked = False AndAlso
           Me.chkPosIkuseiHoshu.Checked = False AndAlso Me.chkPosIkuseiNaiya.Checked = False AndAlso
           Me.chkPosIkuseiToshu.Checked = False AndAlso Me.chkPosKantoku.Checked = False AndAlso
           Me.chkPosNaiya.Checked = False AndAlso Me.chkPosStaf.Checked = False AndAlso
           Me.chkPosToshu.Checked = False Then
            Me.Button1.Enabled = False
        Else
            Me.Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
#End Region

End Class
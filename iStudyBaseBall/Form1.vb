Imports System.Configuration
Imports System.Text
Imports Microsoft.VisualBasic.FileIO

Public Class Form1

#Region "内部変数・定数"
    Private memberFilter As DataView
    Private qNum As Integer
    Private qRow As DataRowView

    Private Const CSV_COLUMN_0 As String = "連番"
    Private Const CSV_COLUMN_1 As String = "リーグ"
    Private Const CSV_COLUMN_2 As String = "球団"
    Private Const CSV_COLUMN_3 As String = "背番号"
    Private Const CSV_COLUMN_4 As String = "位置"
    Private Const CSV_COLUMN_5 As String = "氏名"
    Private Const CSV_COLUMN_6 As String = "備考１"
    Private Const CSV_COLUMN_7 As String = "備考２"

    Private Const QUESTION_MESSAGE_SEBSNGOU As String = "背番号：{0}"
    Private Const QUESTION_MESSAGE_KYUDAN As String = "球団：{0}"
#End Region

#Region "コンストラクタ"
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Dim dataPath As String
        dataPath = ConfigurationManager.AppSettings.Item("DATA_PATH")

        '選手データ読み込み
        memberFilter = New DataView(ReadCsvData(dataPath))

        '初期化
        qNum = 0
        qRow = Nothing
        Me.Label1.Text = String.Empty
        Me.Label4.Text = String.Empty
        Me.Label5.Text = String.Empty
        Me.Label6.Text = String.Empty
        Me.Label7.Text = String.Empty
        Me.Label8.Text = String.Empty
    End Sub
#End Region

#Region "イベント"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load, Button3.Click
        gamenSetthing()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim randomObj As Random

        '前の問題の答え合わせ
        If Not IsNothing(qRow) Then
            If Me.lstSenshu.Text.Equals(qRow.Item(CSV_COLUMN_5).ToString) AndAlso
               Me.cmbIchi.Text.Equals(qRow.Item(CSV_COLUMN_4).ToString) Then
                Me.Label5.Text = "正解！！"
            Else
                Me.Label5.Text = "不正解！！"
            End If
            Me.Label7.Text = qRow.Item(CSV_COLUMN_4).ToString
            Me.Label6.Text = qRow.Item(CSV_COLUMN_5).ToString
            Me.Label8.Text = qRow.Item(CSV_COLUMN_3).ToString
        End If


        '次の問題を設定
        randomObj = New Random()
        qNum = randomObj.Next(memberFilter.Count)
        qRow = memberFilter.Item(qNum)

        Me.Label1.Text = QUESTION_MESSAGE_SEBSNGOU.Replace("{0}", qRow.Row(CSV_COLUMN_3).ToString)
        Me.Label4.Text = QUESTION_MESSAGE_KYUDAN.Replace("{0}", ConvertKyudan(qRow.Row(CSV_COLUMN_2).ToString))


    End Sub
#End Region

#Region "メソッド"
    Private Sub gamenSetthing()
        '設定画面呼び出し
        Using setting = New Form2
            With setting
                .ShowDialog()

                memberFilter.RowFilter = CreateRowFilterString(.SeCD, .SeDB, .SeHT, .SeTC, .SeYG, .SeYS,
                                                               .PaLM, .PaNF, .PaOB, .PaRE, .PaSH, .PaSL,
                                                               .PosEikyu, .PosGaiya, .PosHoshu, .PosIkuseiGaiya,
                                                               .PosIkuseiHoshu, .PosIkuseiNaiya, .PosIkuseiHoshu,
                                                               .PosKantoku, .PosNaiya, .PosStaf, .postoshu)
            End With
        End Using

        '位置コンボボックスの生成
        With Me.cmbIchi
            .DataSource = memberFilter.ToTable("comboTable", True, New String() {CSV_COLUMN_4})
            .DisplayMember = CSV_COLUMN_4
        End With

        '選手リストの生成
        With Me.lstSenshu
            memberFilter.Sort = CSV_COLUMN_5
            .DataSource = memberFilter.ToTable("listTable", True, New String() {CSV_COLUMN_5})
            .DisplayMember = CSV_COLUMN_5
        End With

    End Sub

    Private Function ReadCsvData(ByVal filePath As String) As DataTable
        Dim csvRow As DataRow
        Dim fields As String()

        Using csvParser As New TextFieldParser(filePath),
              csvRecords As New DataTable

            With csvRecords.Columns
                'カラム作成
                .Add(CSV_COLUMN_0)
                .Add(CSV_COLUMN_1)
                .Add(CSV_COLUMN_2)
                .Add(CSV_COLUMN_3)
                .Add(CSV_COLUMN_4)
                .Add(CSV_COLUMN_5)
                .Add(CSV_COLUMN_6)
                .Add(CSV_COLUMN_7)
            End With

            csvParser.SetDelimiters(vbTab)
            While Not csvParser.EndOfData
                'フィールドを読み込む
                fields = csvParser.ReadFields()
                '保存
                csvRow = csvRecords.NewRow
                With csvRow
                    .Item(CSV_COLUMN_0) = fields(0)
                    .Item(CSV_COLUMN_1) = fields(1)
                    .Item(CSV_COLUMN_2) = fields(2)
                    .Item(CSV_COLUMN_3) = fields(3)
                    .Item(CSV_COLUMN_4) = fields(4)
                    .Item(CSV_COLUMN_5) = fields(5)
                    .Item(CSV_COLUMN_6) = fields(6)
                    .Item(CSV_COLUMN_7) = fields(7)
                End With

                csvRecords.Rows.Add(csvRow)
            End While

            Return csvRecords
        End Using
    End Function

    Private Function CreateRowFilterString(ByVal seCD As Boolean, ByVal seDB As Boolean, ByVal seHT As Boolean,
                                           ByVal seTC As Boolean, ByVal seYG As Boolean, ByVal seYS As Boolean,
                                           ByVal paLM As Boolean, ByVal paNF As Boolean, ByVal paOB As Boolean,
                                           ByVal paRE As Boolean, ByVal paSH As Boolean, ByVal paSL As Boolean,
                                           ByVal posEikyu As Boolean, ByVal posGaiya As Boolean, ByVal posHoshu As Boolean,
                                           ByVal posIkuseiGaiya As Boolean, ByVal posIkuseiHoshu As Boolean, ByVal posIkuseiNaiya As Boolean,
                                           ByVal posIkuseiToshu As Boolean, ByVal posKantoku As Boolean, ByVal posNaiya As Boolean,
                                           ByVal posStaf As Boolean, ByVal posToshu As Boolean) As String

        Dim tmpString As StringBuilder
        Dim kyudanHajimeteFlg As Boolean = True
        Dim posHajimeteFlag As Boolean = True

        tmpString = New StringBuilder(String.Empty)
        With tmpString
            '球団
            CreateRowFilterString_Sub(seCD, CSV_COLUMN_2, "='CD' ", kyudanHajimeteFlg, tmpString)
            CreateRowFilterString_Sub(seDB, CSV_COLUMN_2, "='DB' ", kyudanHajimeteFlg, tmpString)
            CreateRowFilterString_Sub(seHT, CSV_COLUMN_2, "='HT' ", kyudanHajimeteFlg, tmpString)
            CreateRowFilterString_Sub(seTC, CSV_COLUMN_2, "='TC' ", kyudanHajimeteFlg, tmpString)
            CreateRowFilterString_Sub(seYG, CSV_COLUMN_2, "='YG' ", kyudanHajimeteFlg, tmpString)
            CreateRowFilterString_Sub(seYS, CSV_COLUMN_2, "='YS' ", kyudanHajimeteFlg, tmpString)

            CreateRowFilterString_Sub(paLM, CSV_COLUMN_2, "='LM' ", kyudanHajimeteFlg, tmpString)
            CreateRowFilterString_Sub(paNF, CSV_COLUMN_2, "='NF' ", kyudanHajimeteFlg, tmpString)
            CreateRowFilterString_Sub(paOB, CSV_COLUMN_2, "='OB' ", kyudanHajimeteFlg, tmpString)
            CreateRowFilterString_Sub(paRE, CSV_COLUMN_2, "='RE' ", kyudanHajimeteFlg, tmpString)
            CreateRowFilterString_Sub(paSH, CSV_COLUMN_2, "='SH' ", kyudanHajimeteFlg, tmpString)
            CreateRowFilterString_Sub(paSL, CSV_COLUMN_2, "='SL' ", kyudanHajimeteFlg, tmpString)

            .Append(" and (")

            'ポジション
            CreateRowFilterString_Sub(posEikyu, CSV_COLUMN_4, "='永久欠番' ", posHajimeteFlag, tmpString)
            CreateRowFilterString_Sub(posGaiya, CSV_COLUMN_4, "='外野手' ", posHajimeteFlag, tmpString)
            CreateRowFilterString_Sub(posHoshu, CSV_COLUMN_4, "='捕手' ", posHajimeteFlag, tmpString)
            CreateRowFilterString_Sub(posIkuseiGaiya, CSV_COLUMN_4, "='育成外野手' ", posHajimeteFlag, tmpString)
            CreateRowFilterString_Sub(posIkuseiHoshu, CSV_COLUMN_4, "='育成捕手' ", posHajimeteFlag, tmpString)
            CreateRowFilterString_Sub(posIkuseiNaiya, CSV_COLUMN_4, "='育成内野手' ", posHajimeteFlag, tmpString)
            CreateRowFilterString_Sub(posIkuseiToshu, CSV_COLUMN_4, "='育成投手' ", posHajimeteFlag, tmpString)
            CreateRowFilterString_Sub(posKantoku, CSV_COLUMN_4, "='監督・コーチ' ", posHajimeteFlag, tmpString)
            CreateRowFilterString_Sub(posNaiya, CSV_COLUMN_4, "='内野手' ", posHajimeteFlag, tmpString)
            CreateRowFilterString_Sub(posStaf, CSV_COLUMN_4, "='スタッフ' ", posHajimeteFlag, tmpString)
            CreateRowFilterString_Sub(posToshu, CSV_COLUMN_4, "='投手' ", posHajimeteFlag, tmpString)

            .Append(")")
        End With

        Return tmpString.ToString

    End Function

    Private Function ConvertKyudan(ByVal kyudanCode As String) As String
        Dim tmpKyudanName As String

        tmpKyudanName = String.Empty

        Select Case kyudanCode
            Case "DB"
                tmpKyudanName = "DeNAベイスターズ"
            Case "CD"
                tmpKyudanName = "中日ドラゴンズ"
            Case "HT"
                tmpKyudanName = "阪神タイガース"
            Case "TC"
                tmpKyudanName = "東洋カープ"
            Case "YG"
                tmpKyudanName = "読売ジャイアンツ"
            Case "YS"
                tmpKyudanName = "ヤクルトスワローズ"
            Case "LM"
                tmpKyudanName = "ロッテマリーンズ"
            Case "NF"
                tmpKyudanName = "日本ハムファイターズ"
            Case "OB"
                tmpKyudanName = "オリックスバファローズ"
            Case "RE"
                tmpKyudanName = "楽天ゴールデンイーグルス"
            Case "SH"
                tmpKyudanName = "ソフトバンクホークス"
            Case "SL"
                tmpKyudanName = "西武ライオンズ"
        End Select

        Return tmpKyudanName
    End Function

    Private Sub CreateRowFilterString_Sub(ByVal targetFlag As Boolean, ByVal targetColumn As String,
                                          ByVal filterTarget As String, ByRef hajimeteFlag As Boolean,
                                          ByRef filterString As StringBuilder)

        Const KETSUGO_OR As String = " OR "

        With filterString
            If targetFlag Then
                If hajimeteFlag = False Then
                    .Append(KETSUGO_OR)
                End If
                .Append(targetColumn)
                .Append(filterTarget)
                hajimeteFlag = False
            End If
        End With
    End Sub
#End Region

End Class

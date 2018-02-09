<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.grpReague = New System.Windows.Forms.GroupBox()
        Me.chkRgPa = New System.Windows.Forms.CheckBox()
        Me.chkRgSe = New System.Windows.Forms.CheckBox()
        Me.grpKyudan = New System.Windows.Forms.GroupBox()
        Me.chkPaSL = New System.Windows.Forms.CheckBox()
        Me.chkPaOB = New System.Windows.Forms.CheckBox()
        Me.chkPaRE = New System.Windows.Forms.CheckBox()
        Me.chkPaLM = New System.Windows.Forms.CheckBox()
        Me.chkPaSH = New System.Windows.Forms.CheckBox()
        Me.chkPaNF = New System.Windows.Forms.CheckBox()
        Me.chkSeTC = New System.Windows.Forms.CheckBox()
        Me.chkSeDB = New System.Windows.Forms.CheckBox()
        Me.chkSeCD = New System.Windows.Forms.CheckBox()
        Me.chkSeHT = New System.Windows.Forms.CheckBox()
        Me.chkSeYS = New System.Windows.Forms.CheckBox()
        Me.chkSeYG = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkPosEikyu = New System.Windows.Forms.CheckBox()
        Me.chkPosIkuseiGaiya = New System.Windows.Forms.CheckBox()
        Me.chkPosIkuseiHoshu = New System.Windows.Forms.CheckBox()
        Me.chkPosIkuseiNaiya = New System.Windows.Forms.CheckBox()
        Me.chkPosIkuseiToshu = New System.Windows.Forms.CheckBox()
        Me.chkPosStaf = New System.Windows.Forms.CheckBox()
        Me.chkPosKantoku = New System.Windows.Forms.CheckBox()
        Me.chkPosToshu = New System.Windows.Forms.CheckBox()
        Me.chkPosHoshu = New System.Windows.Forms.CheckBox()
        Me.chkPosGaiya = New System.Windows.Forms.CheckBox()
        Me.chkPosNaiya = New System.Windows.Forms.CheckBox()
        Me.grpReague.SuspendLayout()
        Me.grpKyudan.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpReague
        '
        Me.grpReague.Controls.Add(Me.chkRgPa)
        Me.grpReague.Controls.Add(Me.chkRgSe)
        Me.grpReague.Location = New System.Drawing.Point(12, 12)
        Me.grpReague.Name = "grpReague"
        Me.grpReague.Size = New System.Drawing.Size(108, 71)
        Me.grpReague.TabIndex = 0
        Me.grpReague.TabStop = False
        Me.grpReague.Text = "リーグ"
        '
        'chkRgPa
        '
        Me.chkRgPa.AutoSize = True
        Me.chkRgPa.Location = New System.Drawing.Point(6, 40)
        Me.chkRgPa.Name = "chkRgPa"
        Me.chkRgPa.Size = New System.Drawing.Size(66, 16)
        Me.chkRgPa.TabIndex = 2
        Me.chkRgPa.Text = "パ・リーグ"
        Me.chkRgPa.UseVisualStyleBackColor = True
        '
        'chkRgSe
        '
        Me.chkRgSe.AutoSize = True
        Me.chkRgSe.Checked = True
        Me.chkRgSe.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRgSe.Location = New System.Drawing.Point(6, 18)
        Me.chkRgSe.Name = "chkRgSe"
        Me.chkRgSe.Size = New System.Drawing.Size(66, 16)
        Me.chkRgSe.TabIndex = 1
        Me.chkRgSe.Text = "セ・リーグ"
        Me.chkRgSe.UseVisualStyleBackColor = True
        '
        'grpKyudan
        '
        Me.grpKyudan.Controls.Add(Me.chkPaSL)
        Me.grpKyudan.Controls.Add(Me.chkPaOB)
        Me.grpKyudan.Controls.Add(Me.chkPaRE)
        Me.grpKyudan.Controls.Add(Me.chkPaLM)
        Me.grpKyudan.Controls.Add(Me.chkPaSH)
        Me.grpKyudan.Controls.Add(Me.chkPaNF)
        Me.grpKyudan.Controls.Add(Me.chkSeTC)
        Me.grpKyudan.Controls.Add(Me.chkSeDB)
        Me.grpKyudan.Controls.Add(Me.chkSeCD)
        Me.grpKyudan.Controls.Add(Me.chkSeHT)
        Me.grpKyudan.Controls.Add(Me.chkSeYS)
        Me.grpKyudan.Controls.Add(Me.chkSeYG)
        Me.grpKyudan.Location = New System.Drawing.Point(126, 12)
        Me.grpKyudan.Name = "grpKyudan"
        Me.grpKyudan.Size = New System.Drawing.Size(319, 165)
        Me.grpKyudan.TabIndex = 1
        Me.grpKyudan.TabStop = False
        Me.grpKyudan.Text = "球団"
        '
        'chkPaSL
        '
        Me.chkPaSL.AutoSize = True
        Me.chkPaSL.Location = New System.Drawing.Point(153, 128)
        Me.chkPaSL.Name = "chkPaSL"
        Me.chkPaSL.Size = New System.Drawing.Size(93, 16)
        Me.chkPaSL.TabIndex = 14
        Me.chkPaSL.Text = "西武ライオンズ"
        Me.chkPaSL.UseVisualStyleBackColor = True
        '
        'chkPaOB
        '
        Me.chkPaOB.AutoSize = True
        Me.chkPaOB.Location = New System.Drawing.Point(153, 106)
        Me.chkPaOB.Name = "chkPaOB"
        Me.chkPaOB.Size = New System.Drawing.Size(118, 16)
        Me.chkPaOB.TabIndex = 13
        Me.chkPaOB.Text = "オリックスバファローズ"
        Me.chkPaOB.UseVisualStyleBackColor = True
        '
        'chkPaRE
        '
        Me.chkPaRE.AutoSize = True
        Me.chkPaRE.Location = New System.Drawing.Point(153, 84)
        Me.chkPaRE.Name = "chkPaRE"
        Me.chkPaRE.Size = New System.Drawing.Size(143, 16)
        Me.chkPaRE.TabIndex = 12
        Me.chkPaRE.Text = "楽天ゴールデンイーグルス"
        Me.chkPaRE.UseVisualStyleBackColor = True
        '
        'chkPaLM
        '
        Me.chkPaLM.AutoSize = True
        Me.chkPaLM.Location = New System.Drawing.Point(153, 62)
        Me.chkPaLM.Name = "chkPaLM"
        Me.chkPaLM.Size = New System.Drawing.Size(94, 16)
        Me.chkPaLM.TabIndex = 11
        Me.chkPaLM.Text = "ロッテマリーンズ"
        Me.chkPaLM.UseVisualStyleBackColor = True
        '
        'chkPaSH
        '
        Me.chkPaSH.AutoSize = True
        Me.chkPaSH.Location = New System.Drawing.Point(153, 40)
        Me.chkPaSH.Name = "chkPaSH"
        Me.chkPaSH.Size = New System.Drawing.Size(113, 16)
        Me.chkPaSH.TabIndex = 10
        Me.chkPaSH.Text = "ソフトバンクホークス"
        Me.chkPaSH.UseVisualStyleBackColor = True
        '
        'chkPaNF
        '
        Me.chkPaNF.AutoSize = True
        Me.chkPaNF.Location = New System.Drawing.Point(153, 18)
        Me.chkPaNF.Name = "chkPaNF"
        Me.chkPaNF.Size = New System.Drawing.Size(120, 16)
        Me.chkPaNF.TabIndex = 9
        Me.chkPaNF.Text = "日本ハムファイターズ"
        Me.chkPaNF.UseVisualStyleBackColor = True
        '
        'chkSeTC
        '
        Me.chkSeTC.AutoSize = True
        Me.chkSeTC.Location = New System.Drawing.Point(6, 128)
        Me.chkSeTC.Name = "chkSeTC"
        Me.chkSeTC.Size = New System.Drawing.Size(76, 16)
        Me.chkSeTC.TabIndex = 8
        Me.chkSeTC.Text = "東洋カープ"
        Me.chkSeTC.UseVisualStyleBackColor = True
        '
        'chkSeDB
        '
        Me.chkSeDB.AutoSize = True
        Me.chkSeDB.Location = New System.Drawing.Point(6, 106)
        Me.chkSeDB.Name = "chkSeDB"
        Me.chkSeDB.Size = New System.Drawing.Size(110, 16)
        Me.chkSeDB.TabIndex = 7
        Me.chkSeDB.Text = "DeNAベイスターズ"
        Me.chkSeDB.UseVisualStyleBackColor = True
        '
        'chkSeCD
        '
        Me.chkSeCD.AutoSize = True
        Me.chkSeCD.Location = New System.Drawing.Point(6, 84)
        Me.chkSeCD.Name = "chkSeCD"
        Me.chkSeCD.Size = New System.Drawing.Size(93, 16)
        Me.chkSeCD.TabIndex = 6
        Me.chkSeCD.Text = "中日ドラゴンズ"
        Me.chkSeCD.UseVisualStyleBackColor = True
        '
        'chkSeHT
        '
        Me.chkSeHT.AutoSize = True
        Me.chkSeHT.Location = New System.Drawing.Point(6, 62)
        Me.chkSeHT.Name = "chkSeHT"
        Me.chkSeHT.Size = New System.Drawing.Size(94, 16)
        Me.chkSeHT.TabIndex = 5
        Me.chkSeHT.Text = "阪神タイガース"
        Me.chkSeHT.UseVisualStyleBackColor = True
        '
        'chkSeYS
        '
        Me.chkSeYS.AutoSize = True
        Me.chkSeYS.Location = New System.Drawing.Point(6, 40)
        Me.chkSeYS.Name = "chkSeYS"
        Me.chkSeYS.Size = New System.Drawing.Size(107, 16)
        Me.chkSeYS.TabIndex = 4
        Me.chkSeYS.Text = "ヤクルトスワローズ"
        Me.chkSeYS.UseVisualStyleBackColor = True
        '
        'chkSeYG
        '
        Me.chkSeYG.AutoSize = True
        Me.chkSeYG.Location = New System.Drawing.Point(6, 18)
        Me.chkSeYG.Name = "chkSeYG"
        Me.chkSeYG.Size = New System.Drawing.Size(102, 16)
        Me.chkSeYG.TabIndex = 3
        Me.chkSeYG.Text = "読売ジャイアンツ"
        Me.chkSeYG.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 129)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 48)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "設定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkPosEikyu)
        Me.GroupBox1.Controls.Add(Me.chkPosIkuseiGaiya)
        Me.GroupBox1.Controls.Add(Me.chkPosIkuseiHoshu)
        Me.GroupBox1.Controls.Add(Me.chkPosIkuseiNaiya)
        Me.GroupBox1.Controls.Add(Me.chkPosIkuseiToshu)
        Me.GroupBox1.Controls.Add(Me.chkPosStaf)
        Me.GroupBox1.Controls.Add(Me.chkPosKantoku)
        Me.GroupBox1.Controls.Add(Me.chkPosToshu)
        Me.GroupBox1.Controls.Add(Me.chkPosHoshu)
        Me.GroupBox1.Controls.Add(Me.chkPosGaiya)
        Me.GroupBox1.Controls.Add(Me.chkPosNaiya)
        Me.GroupBox1.Location = New System.Drawing.Point(451, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 165)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "位置"
        '
        'chkPosEikyu
        '
        Me.chkPosEikyu.AutoSize = True
        Me.chkPosEikyu.Location = New System.Drawing.Point(110, 106)
        Me.chkPosEikyu.Name = "chkPosEikyu"
        Me.chkPosEikyu.Size = New System.Drawing.Size(72, 16)
        Me.chkPosEikyu.TabIndex = 10
        Me.chkPosEikyu.Text = "永久欠番"
        Me.chkPosEikyu.UseVisualStyleBackColor = True
        '
        'chkPosIkuseiGaiya
        '
        Me.chkPosIkuseiGaiya.AutoSize = True
        Me.chkPosIkuseiGaiya.Location = New System.Drawing.Point(110, 84)
        Me.chkPosIkuseiGaiya.Name = "chkPosIkuseiGaiya"
        Me.chkPosIkuseiGaiya.Size = New System.Drawing.Size(84, 16)
        Me.chkPosIkuseiGaiya.TabIndex = 9
        Me.chkPosIkuseiGaiya.Text = "育成外野手"
        Me.chkPosIkuseiGaiya.UseVisualStyleBackColor = True
        '
        'chkPosIkuseiHoshu
        '
        Me.chkPosIkuseiHoshu.AutoSize = True
        Me.chkPosIkuseiHoshu.Location = New System.Drawing.Point(110, 62)
        Me.chkPosIkuseiHoshu.Name = "chkPosIkuseiHoshu"
        Me.chkPosIkuseiHoshu.Size = New System.Drawing.Size(72, 16)
        Me.chkPosIkuseiHoshu.TabIndex = 8
        Me.chkPosIkuseiHoshu.Text = "育成捕手"
        Me.chkPosIkuseiHoshu.UseVisualStyleBackColor = True
        '
        'chkPosIkuseiNaiya
        '
        Me.chkPosIkuseiNaiya.AutoSize = True
        Me.chkPosIkuseiNaiya.Location = New System.Drawing.Point(110, 40)
        Me.chkPosIkuseiNaiya.Name = "chkPosIkuseiNaiya"
        Me.chkPosIkuseiNaiya.Size = New System.Drawing.Size(84, 16)
        Me.chkPosIkuseiNaiya.TabIndex = 7
        Me.chkPosIkuseiNaiya.Text = "育成内野手"
        Me.chkPosIkuseiNaiya.UseVisualStyleBackColor = True
        '
        'chkPosIkuseiToshu
        '
        Me.chkPosIkuseiToshu.AutoSize = True
        Me.chkPosIkuseiToshu.Location = New System.Drawing.Point(110, 18)
        Me.chkPosIkuseiToshu.Name = "chkPosIkuseiToshu"
        Me.chkPosIkuseiToshu.Size = New System.Drawing.Size(72, 16)
        Me.chkPosIkuseiToshu.TabIndex = 6
        Me.chkPosIkuseiToshu.Text = "育成投手"
        Me.chkPosIkuseiToshu.UseVisualStyleBackColor = True
        '
        'chkPosStaf
        '
        Me.chkPosStaf.AutoSize = True
        Me.chkPosStaf.Location = New System.Drawing.Point(6, 128)
        Me.chkPosStaf.Name = "chkPosStaf"
        Me.chkPosStaf.Size = New System.Drawing.Size(56, 16)
        Me.chkPosStaf.TabIndex = 5
        Me.chkPosStaf.Text = "スタッフ"
        Me.chkPosStaf.UseVisualStyleBackColor = True
        '
        'chkPosKantoku
        '
        Me.chkPosKantoku.AutoSize = True
        Me.chkPosKantoku.Location = New System.Drawing.Point(6, 106)
        Me.chkPosKantoku.Name = "chkPosKantoku"
        Me.chkPosKantoku.Size = New System.Drawing.Size(81, 16)
        Me.chkPosKantoku.TabIndex = 4
        Me.chkPosKantoku.Text = "監督・コーチ"
        Me.chkPosKantoku.UseVisualStyleBackColor = True
        '
        'chkPosToshu
        '
        Me.chkPosToshu.AutoSize = True
        Me.chkPosToshu.Location = New System.Drawing.Point(6, 84)
        Me.chkPosToshu.Name = "chkPosToshu"
        Me.chkPosToshu.Size = New System.Drawing.Size(48, 16)
        Me.chkPosToshu.TabIndex = 3
        Me.chkPosToshu.Text = "投手"
        Me.chkPosToshu.UseVisualStyleBackColor = True
        '
        'chkPosHoshu
        '
        Me.chkPosHoshu.AutoSize = True
        Me.chkPosHoshu.Location = New System.Drawing.Point(6, 62)
        Me.chkPosHoshu.Name = "chkPosHoshu"
        Me.chkPosHoshu.Size = New System.Drawing.Size(48, 16)
        Me.chkPosHoshu.TabIndex = 2
        Me.chkPosHoshu.Text = "捕手"
        Me.chkPosHoshu.UseVisualStyleBackColor = True
        '
        'chkPosGaiya
        '
        Me.chkPosGaiya.AutoSize = True
        Me.chkPosGaiya.Location = New System.Drawing.Point(6, 40)
        Me.chkPosGaiya.Name = "chkPosGaiya"
        Me.chkPosGaiya.Size = New System.Drawing.Size(60, 16)
        Me.chkPosGaiya.TabIndex = 1
        Me.chkPosGaiya.Text = "外野手"
        Me.chkPosGaiya.UseVisualStyleBackColor = True
        '
        'chkPosNaiya
        '
        Me.chkPosNaiya.AutoSize = True
        Me.chkPosNaiya.Location = New System.Drawing.Point(6, 18)
        Me.chkPosNaiya.Name = "chkPosNaiya"
        Me.chkPosNaiya.Size = New System.Drawing.Size(60, 16)
        Me.chkPosNaiya.TabIndex = 0
        Me.chkPosNaiya.Text = "内野手"
        Me.chkPosNaiya.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 186)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grpKyudan)
        Me.Controls.Add(Me.grpReague)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "設定"
        Me.grpReague.ResumeLayout(False)
        Me.grpReague.PerformLayout()
        Me.grpKyudan.ResumeLayout(False)
        Me.grpKyudan.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpReague As GroupBox
    Friend WithEvents chkRgPa As CheckBox
    Friend WithEvents chkRgSe As CheckBox
    Friend WithEvents grpKyudan As GroupBox
    Friend WithEvents chkPaSL As CheckBox
    Friend WithEvents chkPaOB As CheckBox
    Friend WithEvents chkPaRE As CheckBox
    Friend WithEvents chkPaLM As CheckBox
    Friend WithEvents chkPaSH As CheckBox
    Friend WithEvents chkPaNF As CheckBox
    Friend WithEvents chkSeTC As CheckBox
    Friend WithEvents chkSeDB As CheckBox
    Friend WithEvents chkSeCD As CheckBox
    Friend WithEvents chkSeHT As CheckBox
    Friend WithEvents chkSeYS As CheckBox
    Friend WithEvents chkSeYG As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkPosEikyu As CheckBox
    Friend WithEvents chkPosIkuseiGaiya As CheckBox
    Friend WithEvents chkPosIkuseiHoshu As CheckBox
    Friend WithEvents chkPosIkuseiNaiya As CheckBox
    Friend WithEvents chkPosIkuseiToshu As CheckBox
    Friend WithEvents chkPosStaf As CheckBox
    Friend WithEvents chkPosKantoku As CheckBox
    Friend WithEvents chkPosToshu As CheckBox
    Friend WithEvents chkPosHoshu As CheckBox
    Friend WithEvents chkPosGaiya As CheckBox
    Friend WithEvents chkPosNaiya As CheckBox
End Class

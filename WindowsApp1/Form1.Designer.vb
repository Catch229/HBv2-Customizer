<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HotBoxApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HotBoxApp))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ImageSelectBtn = New System.Windows.Forms.Button()
        Me.OLEDImageBox = New System.Windows.Forms.PictureBox()
        Me.UploadImageBtn = New System.Windows.Forms.Button()
        Me.HVSetPoint = New System.Windows.Forms.NumericUpDown()
        Me.LVSetPoint = New System.Windows.Forms.NumericUpDown()
        Me.VoltOffset = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UploadSettingBtn = New System.Windows.Forms.Button()
        Me.PortListBox = New System.Windows.Forms.ListBox()
        Me.PortScanButton = New System.Windows.Forms.Button()
        Me.vOffsetCheck = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkBtn = New System.Windows.Forms.Button()
        CType(Me.OLEDImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HVSetPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LVSetPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VoltOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "BMP|*.bmp"
        '
        'ImageSelectBtn
        '
        Me.ImageSelectBtn.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ImageSelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ImageSelectBtn.ForeColor = System.Drawing.Color.White
        Me.ImageSelectBtn.Location = New System.Drawing.Point(12, 202)
        Me.ImageSelectBtn.Name = "ImageSelectBtn"
        Me.ImageSelectBtn.Size = New System.Drawing.Size(92, 46)
        Me.ImageSelectBtn.TabIndex = 0
        Me.ImageSelectBtn.Text = "Select an Image"
        Me.ImageSelectBtn.UseVisualStyleBackColor = False
        '
        'OLEDImageBox
        '
        Me.OLEDImageBox.BackColor = System.Drawing.Color.Transparent
        Me.OLEDImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OLEDImageBox.Location = New System.Drawing.Point(12, 12)
        Me.OLEDImageBox.Name = "OLEDImageBox"
        Me.OLEDImageBox.Size = New System.Drawing.Size(197, 184)
        Me.OLEDImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.OLEDImageBox.TabIndex = 1
        Me.OLEDImageBox.TabStop = False
        '
        'UploadImageBtn
        '
        Me.UploadImageBtn.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.UploadImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UploadImageBtn.ForeColor = System.Drawing.Color.White
        Me.UploadImageBtn.Location = New System.Drawing.Point(110, 202)
        Me.UploadImageBtn.Name = "UploadImageBtn"
        Me.UploadImageBtn.Size = New System.Drawing.Size(99, 46)
        Me.UploadImageBtn.TabIndex = 4
        Me.UploadImageBtn.Text = "Upload Image to HotBox"
        Me.UploadImageBtn.UseVisualStyleBackColor = False
        '
        'HVSetPoint
        '
        Me.HVSetPoint.DecimalPlaces = 2
        Me.HVSetPoint.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.HVSetPoint.Location = New System.Drawing.Point(523, 124)
        Me.HVSetPoint.Maximum = New Decimal(New Integer() {21, 0, 0, 0})
        Me.HVSetPoint.Name = "HVSetPoint"
        Me.HVSetPoint.Size = New System.Drawing.Size(120, 20)
        Me.HVSetPoint.TabIndex = 5
        Me.HVSetPoint.Value = New Decimal(New Integer() {165, 0, 0, 65536})
        '
        'LVSetPoint
        '
        Me.LVSetPoint.DecimalPlaces = 2
        Me.LVSetPoint.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.LVSetPoint.Location = New System.Drawing.Point(523, 150)
        Me.LVSetPoint.Maximum = New Decimal(New Integer() {21, 0, 0, 0})
        Me.LVSetPoint.Name = "LVSetPoint"
        Me.LVSetPoint.Size = New System.Drawing.Size(120, 20)
        Me.LVSetPoint.TabIndex = 6
        Me.LVSetPoint.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'VoltOffset
        '
        Me.VoltOffset.DecimalPlaces = 2
        Me.VoltOffset.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.VoltOffset.Location = New System.Drawing.Point(523, 176)
        Me.VoltOffset.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.VoltOffset.Minimum = New Decimal(New Integer() {3, 0, 0, -2147483648})
        Me.VoltOffset.Name = "VoltOffset"
        Me.VoltOffset.Size = New System.Drawing.Size(120, 20)
        Me.VoltOffset.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(405, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "High Voltage Set Point"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(405, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Low Voltage Set Point"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(443, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Voltage Offset"
        '
        'UploadSettingBtn
        '
        Me.UploadSettingBtn.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.UploadSettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UploadSettingBtn.ForeColor = System.Drawing.Color.White
        Me.UploadSettingBtn.Location = New System.Drawing.Point(523, 202)
        Me.UploadSettingBtn.Name = "UploadSettingBtn"
        Me.UploadSettingBtn.Size = New System.Drawing.Size(120, 46)
        Me.UploadSettingBtn.TabIndex = 11
        Me.UploadSettingBtn.Text = "Upload Settings to HotBox"
        Me.UploadSettingBtn.UseVisualStyleBackColor = False
        '
        'PortListBox
        '
        Me.PortListBox.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PortListBox.ForeColor = System.Drawing.SystemColors.Window
        Me.PortListBox.FormattingEnabled = True
        Me.PortListBox.Location = New System.Drawing.Point(523, 41)
        Me.PortListBox.Name = "PortListBox"
        Me.PortListBox.Size = New System.Drawing.Size(120, 43)
        Me.PortListBox.TabIndex = 12
        '
        'PortScanButton
        '
        Me.PortScanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PortScanButton.ForeColor = System.Drawing.Color.White
        Me.PortScanButton.Location = New System.Drawing.Point(523, 12)
        Me.PortScanButton.Name = "PortScanButton"
        Me.PortScanButton.Size = New System.Drawing.Size(120, 23)
        Me.PortScanButton.TabIndex = 13
        Me.PortScanButton.Text = "Scan Ports"
        Me.PortScanButton.UseVisualStyleBackColor = True
        '
        'vOffsetCheck
        '
        Me.vOffsetCheck.AutoSize = True
        Me.vOffsetCheck.BackColor = System.Drawing.Color.Transparent
        Me.vOffsetCheck.Location = New System.Drawing.Point(422, 178)
        Me.vOffsetCheck.Name = "vOffsetCheck"
        Me.vOffsetCheck.Size = New System.Drawing.Size(15, 14)
        Me.vOffsetCheck.TabIndex = 14
        Me.vOffsetCheck.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(215, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 221)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'LinkBtn
        '
        Me.LinkBtn.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.LinkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LinkBtn.ForeColor = System.Drawing.Color.White
        Me.LinkBtn.Location = New System.Drawing.Point(380, 202)
        Me.LinkBtn.Name = "LinkBtn"
        Me.LinkBtn.Size = New System.Drawing.Size(120, 46)
        Me.LinkBtn.TabIndex = 17
        Me.LinkBtn.Text = "Free Image Database"
        Me.LinkBtn.UseVisualStyleBackColor = False
        '
        'HotBoxApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(655, 261)
        Me.Controls.Add(Me.LinkBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.vOffsetCheck)
        Me.Controls.Add(Me.PortScanButton)
        Me.Controls.Add(Me.PortListBox)
        Me.Controls.Add(Me.UploadSettingBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VoltOffset)
        Me.Controls.Add(Me.LVSetPoint)
        Me.Controls.Add(Me.HVSetPoint)
        Me.Controls.Add(Me.UploadImageBtn)
        Me.Controls.Add(Me.OLEDImageBox)
        Me.Controls.Add(Me.ImageSelectBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HotBoxApp"
        Me.Text = "HotBox Voltmeter Configuration v1.0"
        CType(Me.OLEDImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HVSetPoint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LVSetPoint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VoltOffset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ImageSelectBtn As Button
    Friend WithEvents OLEDImageBox As PictureBox
    Friend WithEvents UploadImageBtn As Button
    Friend WithEvents HVSetPoint As NumericUpDown
    Friend WithEvents LVSetPoint As NumericUpDown
    Friend WithEvents VoltOffset As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents UploadSettingBtn As Button
    Friend WithEvents PortListBox As ListBox
    Friend WithEvents PortScanButton As Button
    Friend WithEvents vOffsetCheck As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkBtn As Button
End Class

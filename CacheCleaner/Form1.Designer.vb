<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.rbRemote = New System.Windows.Forms.RadioButton()
        Me.rbLocal = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rbSelected = New System.Windows.Forms.RadioButton()
        Me.rbAll = New System.Windows.Forms.RadioButton()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.clbUsers = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clbGlobal = New System.Windows.Forms.CheckedListBox()
        Me.clbPerUser = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.progbarGlobal = New System.Windows.Forms.ProgressBar()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdvanced = New System.Windows.Forms.Button()
        Me.chkCheckValid = New System.Windows.Forms.CheckBox()
        Me.chkDeleteInvalid = New System.Windows.Forms.CheckBox()
        Me.chkDeleteOrphans = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnConnect)
        Me.Panel1.Controls.Add(Me.txtHost)
        Me.Panel1.Controls.Add(Me.rbRemote)
        Me.Panel1.Controls.Add(Me.rbLocal)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(372, 61)
        Me.Panel1.TabIndex = 0
        '
        'btnConnect
        '
        Me.btnConnect.Enabled = False
        Me.btnConnect.Location = New System.Drawing.Point(238, 25)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 3
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'txtHost
        '
        Me.txtHost.Enabled = False
        Me.txtHost.Location = New System.Drawing.Point(92, 28)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(135, 20)
        Me.txtHost.TabIndex = 2
        '
        'rbRemote
        '
        Me.rbRemote.AutoSize = True
        Me.rbRemote.Location = New System.Drawing.Point(14, 28)
        Me.rbRemote.Name = "rbRemote"
        Me.rbRemote.Size = New System.Drawing.Size(82, 17)
        Me.rbRemote.TabIndex = 1
        Me.rbRemote.Text = "Remote PC:"
        Me.rbRemote.UseVisualStyleBackColor = True
        '
        'rbLocal
        '
        Me.rbLocal.AutoSize = True
        Me.rbLocal.Checked = True
        Me.rbLocal.Location = New System.Drawing.Point(14, 4)
        Me.rbLocal.Name = "rbLocal"
        Me.rbLocal.Size = New System.Drawing.Size(68, 17)
        Me.rbLocal.TabIndex = 0
        Me.rbLocal.TabStop = True
        Me.rbLocal.Text = "Local PC"
        Me.rbLocal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(585, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Users"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbSelected)
        Me.Panel2.Controls.Add(Me.rbAll)
        Me.Panel2.Location = New System.Drawing.Point(643, 75)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(185, 27)
        Me.Panel2.TabIndex = 5
        '
        'rbSelected
        '
        Me.rbSelected.AutoSize = True
        Me.rbSelected.Location = New System.Drawing.Point(96, 4)
        Me.rbSelected.Name = "rbSelected"
        Me.rbSelected.Size = New System.Drawing.Size(49, 17)
        Me.rbSelected.TabIndex = 1
        Me.rbSelected.Text = "Clear"
        Me.rbSelected.UseVisualStyleBackColor = True
        '
        'rbAll
        '
        Me.rbAll.AutoSize = True
        Me.rbAll.Checked = True
        Me.rbAll.Location = New System.Drawing.Point(12, 5)
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Size = New System.Drawing.Size(69, 17)
        Me.rbAll.TabIndex = 0
        Me.rbAll.TabStop = True
        Me.rbAll.Text = "Select All"
        Me.rbAll.UseVisualStyleBackColor = True
        '
        'btnClean
        '
        Me.btnClean.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClean.ForeColor = System.Drawing.Color.Green
        Me.btnClean.Location = New System.Drawing.Point(617, 17)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(75, 23)
        Me.btnClean.TabIndex = 6
        Me.btnClean.Text = "Clean!"
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'clbUsers
        '
        Me.clbUsers.FormattingEnabled = True
        Me.clbUsers.HorizontalScrollbar = True
        Me.clbUsers.Location = New System.Drawing.Point(576, 101)
        Me.clbUsers.Name = "clbUsers"
        Me.clbUsers.Size = New System.Drawing.Size(271, 304)
        Me.clbUsers.Sorted = True
        Me.clbUsers.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Global Directories"
        '
        'clbGlobal
        '
        Me.clbGlobal.FormattingEnabled = True
        Me.clbGlobal.Items.AddRange(New Object() {"$Recycle.bin", "PerfLogs", "Program Files\Ford\IBMHOD\HODCCwww.hod.ford.com", "temp", "Windows\Prefetch", "Windows\System32\winevt\Logs", "Windows\System32\spool\PRINTERS", "Windows\temp"})
        Me.clbGlobal.Location = New System.Drawing.Point(12, 101)
        Me.clbGlobal.Name = "clbGlobal"
        Me.clbGlobal.Size = New System.Drawing.Size(211, 304)
        Me.clbGlobal.TabIndex = 10
        '
        'clbPerUser
        '
        Me.clbPerUser.FormattingEnabled = True
        Me.clbPerUser.Items.AddRange(New Object() {"AppData\Local\DirectTV Player", "AppData\Local\Google\Chrome\User Data\Default\Cache", "AppData\Local\Microsoft\Office\12.0\OfficeFileCache", "AppData\Local\Microsoft\Office\14.0\OfficeFileCache", "AppData\Local\Microsoft\Office\16.0\OfficeFileCache", "AppData\Local\Microsoft\Windows\Caches", "AppData\Local\Microsoft\Windows\Temporary Internet Files", "AppData\Local\Microsoft\Windows Media", "AppData\Local\Symantec\Symantec Endpoint Protection\Logs", "AppData\Local\Temp", "AppData\LocalLow\Adobe\Common\Media Cache Files", "AppData\LocalLow\Adobe\Common\Media Cache", "AppData\LocalLow\Sun\Java\Deployment\cache", "AppData\LocalLow\Sun\Java\Deployment\SystemCache", "AppData\LocalLow\Sun\Java\Deployment\tmp", "AppData\Roaming\Adobe\Flash Player\AssetCache", "AppData\Roaming\Adobe\Flash Player\Icon Cache", "AppData\Roaming\Adobe\Flash Player\NativeCache", "AppData\Roaming\Apple Computer\Logs", "AppData\Roaming\Macromedia\Flash Player", "AppData\Roaming\Microsoft\Windows\Cookies"})
        Me.clbPerUser.Location = New System.Drawing.Point(229, 101)
        Me.clbPerUser.Name = "clbPerUser"
        Me.clbPerUser.Size = New System.Drawing.Size(341, 304)
        Me.clbPerUser.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(239, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "User Directories"
        '
        'progbarGlobal
        '
        Me.progbarGlobal.Location = New System.Drawing.Point(12, 410)
        Me.progbarGlobal.Name = "progbarGlobal"
        Me.progbarGlobal.Size = New System.Drawing.Size(835, 15)
        Me.progbarGlobal.Step = 1
        Me.progbarGlobal.TabIndex = 15
        '
        'txtLog
        '
        Me.txtLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLog.Location = New System.Drawing.Point(13, 431)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(834, 200)
        Me.txtLog.TabIndex = 16
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Red
        Me.btnCancel.Location = New System.Drawing.Point(717, 26)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnAdvanced
        '
        Me.btnAdvanced.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdvanced.Location = New System.Drawing.Point(617, 43)
        Me.btnAdvanced.Name = "btnAdvanced"
        Me.btnAdvanced.Size = New System.Drawing.Size(75, 23)
        Me.btnAdvanced.TabIndex = 18
        Me.btnAdvanced.Text = "Advanced"
        Me.btnAdvanced.UseVisualStyleBackColor = True
        '
        'chkCheckValid
        '
        Me.chkCheckValid.AutoSize = True
        Me.chkCheckValid.Location = New System.Drawing.Point(402, 17)
        Me.chkCheckValid.Name = "chkCheckValid"
        Me.chkCheckValid.Size = New System.Drawing.Size(148, 17)
        Me.chkCheckValid.TabIndex = 19
        Me.chkCheckValid.Text = "Validate domain accounts"
        Me.chkCheckValid.UseVisualStyleBackColor = True
        '
        'chkDeleteInvalid
        '
        Me.chkDeleteInvalid.AutoSize = True
        Me.chkDeleteInvalid.Enabled = False
        Me.chkDeleteInvalid.Location = New System.Drawing.Point(423, 41)
        Me.chkDeleteInvalid.Name = "chkDeleteInvalid"
        Me.chkDeleteInvalid.Size = New System.Drawing.Size(126, 17)
        Me.chkDeleteInvalid.TabIndex = 20
        Me.chkDeleteInvalid.Text = "Delete invalid profiles"
        Me.chkDeleteInvalid.UseVisualStyleBackColor = True
        '
        'chkDeleteOrphans
        '
        Me.chkDeleteOrphans.AutoSize = True
        Me.chkDeleteOrphans.Enabled = False
        Me.chkDeleteOrphans.Location = New System.Drawing.Point(423, 65)
        Me.chkDeleteOrphans.Name = "chkDeleteOrphans"
        Me.chkDeleteOrphans.Size = New System.Drawing.Size(98, 17)
        Me.chkDeleteOrphans.TabIndex = 21
        Me.chkDeleteOrphans.Text = "Delete orphans"
        Me.chkDeleteOrphans.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnClean
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 643)
        Me.Controls.Add(Me.chkDeleteOrphans)
        Me.Controls.Add(Me.chkDeleteInvalid)
        Me.Controls.Add(Me.chkCheckValid)
        Me.Controls.Add(Me.btnAdvanced)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.progbarGlobal)
        Me.Controls.Add(Me.btnClean)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.clbPerUser)
        Me.Controls.Add(Me.clbGlobal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.clbUsers)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cache Cleaner 1.4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
    Friend WithEvents rbRemote As System.Windows.Forms.RadioButton
    Friend WithEvents rbLocal As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rbSelected As System.Windows.Forms.RadioButton
    Friend WithEvents rbAll As System.Windows.Forms.RadioButton
    Friend WithEvents btnClean As System.Windows.Forms.Button
    Friend WithEvents clbUsers As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents clbGlobal As System.Windows.Forms.CheckedListBox
    Friend WithEvents clbPerUser As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents progbarGlobal As System.Windows.Forms.ProgressBar
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAdvanced As System.Windows.Forms.Button
    Friend WithEvents chkCheckValid As System.Windows.Forms.CheckBox
    Friend WithEvents chkDeleteInvalid As System.Windows.Forms.CheckBox
    Friend WithEvents chkDeleteOrphans As System.Windows.Forms.CheckBox

End Class

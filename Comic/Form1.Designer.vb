<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblComic = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblGroupSize = New System.Windows.Forms.Label()
        Me.txtGroupSize = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radSuper = New System.Windows.Forms.RadioButton()
        Me.radAuto = New System.Windows.Forms.RadioButton()
        Me.radCon = New System.Windows.Forms.RadioButton()
        Me.txtGroup = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lblRegistration = New System.Windows.Forms.Label()
        Me.lblCostTickets = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(208, 506)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(155, 36)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(564, 504)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(155, 36)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblComic
        '
        Me.lblComic.AllowDrop = True
        Me.lblComic.BackColor = System.Drawing.SystemColors.Control
        Me.lblComic.Font = New System.Drawing.Font("Segoe UI", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblComic.ForeColor = System.Drawing.Color.Peru
        Me.lblComic.Location = New System.Drawing.Point(94, 137)
        Me.lblComic.Name = "lblComic"
        Me.lblComic.Size = New System.Drawing.Size(647, 64)
        Me.lblComic.TabIndex = 2
        Me.lblComic.Text = "Comic Convention Registration"
        Me.lblComic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(801, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblGroupSize
        '
        Me.lblGroupSize.AutoSize = True
        Me.lblGroupSize.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGroupSize.ForeColor = System.Drawing.Color.Peru
        Me.lblGroupSize.Location = New System.Drawing.Point(252, 221)
        Me.lblGroupSize.Name = "lblGroupSize"
        Me.lblGroupSize.Size = New System.Drawing.Size(130, 32)
        Me.lblGroupSize.TabIndex = 4
        Me.lblGroupSize.Text = "Group Size"
        '
        'txtGroupSize
        '
        Me.txtGroupSize.Location = New System.Drawing.Point(418, 230)
        Me.txtGroupSize.Name = "txtGroupSize"
        Me.txtGroupSize.Size = New System.Drawing.Size(100, 23)
        Me.txtGroupSize.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.radCon)
        Me.GroupBox1.Controls.Add(Me.radAuto)
        Me.GroupBox1.Controls.Add(Me.radSuper)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Peru
        Me.GroupBox1.Location = New System.Drawing.Point(233, 276)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 169)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Badge Type"
        '
        'radSuper
        '
        Me.radSuper.AutoSize = True
        Me.radSuper.Location = New System.Drawing.Point(23, 35)
        Me.radSuper.Name = "radSuper"
        Me.radSuper.Size = New System.Drawing.Size(337, 29)
        Me.radSuper.TabIndex = 0
        Me.radSuper.TabStop = True
        Me.radSuper.Text = "Convention + SuperHero Experience"
        Me.radSuper.UseVisualStyleBackColor = True
        '
        'radAuto
        '
        Me.radAuto.AutoSize = True
        Me.radAuto.Location = New System.Drawing.Point(23, 79)
        Me.radAuto.Name = "radAuto"
        Me.radAuto.Size = New System.Drawing.Size(248, 29)
        Me.radAuto.TabIndex = 1
        Me.radAuto.TabStop = True
        Me.radAuto.Text = "Convention + Autographs"
        Me.radAuto.UseVisualStyleBackColor = True
        '
        'radCon
        '
        Me.radCon.AutoSize = True
        Me.radCon.Location = New System.Drawing.Point(23, 123)
        Me.radCon.Name = "radCon"
        Me.radCon.Size = New System.Drawing.Size(127, 29)
        Me.radCon.TabIndex = 2
        Me.radCon.TabStop = True
        Me.radCon.Text = "Convention"
        Me.radCon.UseVisualStyleBackColor = True
        '
        'txtGroup
        '
        Me.txtGroup.AutoClose = False
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.Size = New System.Drawing.Size(61, 4)
        '
        'lblRegistration
        '
        Me.lblRegistration.AutoSize = True
        Me.lblRegistration.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblRegistration.ForeColor = System.Drawing.Color.Peru
        Me.lblRegistration.Location = New System.Drawing.Point(233, 448)
        Me.lblRegistration.Name = "lblRegistration"
        Me.lblRegistration.Size = New System.Drawing.Size(176, 30)
        Me.lblRegistration.TabIndex = 9
        Me.lblRegistration.Text = "Registration Cost"
        '
        'lblCostTickets
        '
        Me.lblCostTickets.AutoSize = True
        Me.lblCostTickets.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCostTickets.ForeColor = System.Drawing.Color.Peru
        Me.lblCostTickets.Location = New System.Drawing.Point(564, 448)
        Me.lblCostTickets.Name = "lblCostTickets"
        Me.lblCostTickets.Size = New System.Drawing.Size(102, 30)
        Me.lblCostTickets.TabIndex = 10
        Me.lblCostTickets.Text = "$0000.00"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.lblCostTickets)
        Me.Controls.Add(Me.lblRegistration)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtGroupSize)
        Me.Controls.Add(Me.lblGroupSize)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblComic)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Comic Con Registration"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblComic As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblGroupSize As Label
    Friend WithEvents txtGroupSize As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radCon As RadioButton
    Friend WithEvents radAuto As RadioButton
    Friend WithEvents radSuper As RadioButton
    Friend WithEvents txtGroup As ContextMenuStrip
    Friend WithEvents lblRegistration As Label
    Friend WithEvents lblCostTickets As Label
End Class

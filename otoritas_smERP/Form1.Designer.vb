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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chx023 = New System.Windows.Forms.CheckBox()
        Me.chx021 = New System.Windows.Forms.CheckBox()
        Me.chx022 = New System.Windows.Forms.CheckBox()
        Me.chx02 = New System.Windows.Forms.CheckBox()
        Me.chx01 = New System.Windows.Forms.CheckBox()
        Me.chx0 = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(134, 210)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1004, 244)
        Me.TabControl1.TabIndex = 13
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chx023)
        Me.TabPage1.Controls.Add(Me.chx021)
        Me.TabPage1.Controls.Add(Me.chx022)
        Me.TabPage1.Controls.Add(Me.chx02)
        Me.TabPage1.Controls.Add(Me.chx01)
        Me.TabPage1.Controls.Add(Me.chx0)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(996, 218)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chx023
        '
        Me.chx023.AutoSize = True
        Me.chx023.Location = New System.Drawing.Point(70, 137)
        Me.chx023.Name = "chx023"
        Me.chx023.Size = New System.Drawing.Size(153, 17)
        Me.chx023.TabIndex = 5
        Me.chx023.Text = "Lokasi Barang Per Cabang"
        Me.chx023.UseVisualStyleBackColor = True
        '
        'chx021
        '
        Me.chx021.AutoSize = True
        Me.chx021.Location = New System.Drawing.Point(70, 91)
        Me.chx021.Name = "chx021"
        Me.chx021.Size = New System.Drawing.Size(93, 17)
        Me.chx021.TabIndex = 4
        Me.chx021.Text = "Setting Lokasi"
        Me.chx021.UseVisualStyleBackColor = True
        '
        'chx022
        '
        Me.chx022.AutoSize = True
        Me.chx022.Location = New System.Drawing.Point(70, 114)
        Me.chx022.Name = "chx022"
        Me.chx022.Size = New System.Drawing.Size(84, 17)
        Me.chx022.TabIndex = 3
        Me.chx022.Text = "Input Lokasi"
        Me.chx022.UseVisualStyleBackColor = True
        '
        'chx02
        '
        Me.chx02.AutoSize = True
        Me.chx02.Location = New System.Drawing.Point(51, 68)
        Me.chx02.Name = "chx02"
        Me.chx02.Size = New System.Drawing.Size(94, 17)
        Me.chx02.TabIndex = 2
        Me.chx02.Text = "Lokasi Barang"
        Me.chx02.UseVisualStyleBackColor = True
        '
        'chx01
        '
        Me.chx01.AutoSize = True
        Me.chx01.Location = New System.Drawing.Point(72, 45)
        Me.chx01.Name = "chx01"
        Me.chx01.Size = New System.Drawing.Size(92, 17)
        Me.chx01.TabIndex = 1
        Me.chx01.Text = "Daftar Barang"
        Me.chx01.UseVisualStyleBackColor = True
        '
        'chx0
        '
        Me.chx0.AutoSize = True
        Me.chx0.Location = New System.Drawing.Point(51, 22)
        Me.chx0.Name = "chx0"
        Me.chx0.Size = New System.Drawing.Size(113, 17)
        Me.chx0.TabIndex = 0
        Me.chx0.Text = "Data Bantu Umum"
        Me.chx0.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(996, 218)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 664)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents chx023 As CheckBox
    Friend WithEvents chx021 As CheckBox
    Friend WithEvents chx022 As CheckBox
    Friend WithEvents chx02 As CheckBox
    Friend WithEvents chx01 As CheckBox
    Friend WithEvents chx0 As CheckBox
    Friend WithEvents TabPage2 As TabPage
End Class

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtgluta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblseltotal = New System.Windows.Forms.Label()
        Me.lblcomgluta = New System.Windows.Forms.Label()
        Me.lblcomcom = New System.Windows.Forms.Label()
        Me.lblcomtotal = New System.Windows.Forms.Label()
        Me.btncal = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(30, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ยอดขาย Vistra Gluta :"
        '
        'txtgluta
        '
        Me.txtgluta.Location = New System.Drawing.Point(308, 82)
        Me.txtgluta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtgluta.Name = "txtgluta"
        Me.txtgluta.Size = New System.Drawing.Size(148, 22)
        Me.txtgluta.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(30, 120)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = " ยอดขาย Computer Toshiba Extra520x :"
        '
        'txtcom
        '
        Me.txtcom.Location = New System.Drawing.Point(308, 118)
        Me.txtcom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcom.Name = "txtcom"
        Me.txtcom.Size = New System.Drawing.Size(148, 22)
        Me.txtcom.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(97, 183)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "  ยอดขายรวม :"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(30, 217)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = " ค่าคอมมิชชั่น   Vistra Gluta :"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(30, 258)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(310, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = " ค่าคอมมิชชั่น    Computer Toshiba Extra520x :"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(92, 300)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = " ค่าคอมมิชชั่นรวม :"
        '
        'lblseltotal
        '
        Me.lblseltotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblseltotal.ForeColor = System.Drawing.Color.Black
        Me.lblseltotal.Location = New System.Drawing.Point(219, 171)
        Me.lblseltotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblseltotal.Name = "lblseltotal"
        Me.lblseltotal.Size = New System.Drawing.Size(154, 28)
        Me.lblseltotal.TabIndex = 2
        Me.lblseltotal.Text = " "
        '
        'lblcomgluta
        '
        Me.lblcomgluta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcomgluta.ForeColor = System.Drawing.Color.Black
        Me.lblcomgluta.Location = New System.Drawing.Point(348, 217)
        Me.lblcomgluta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcomgluta.Name = "lblcomgluta"
        Me.lblcomgluta.Size = New System.Drawing.Size(154, 28)
        Me.lblcomgluta.TabIndex = 2
        Me.lblcomgluta.Text = " "
        '
        'lblcomcom
        '
        Me.lblcomcom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcomcom.ForeColor = System.Drawing.Color.Black
        Me.lblcomcom.Location = New System.Drawing.Point(348, 258)
        Me.lblcomcom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcomcom.Name = "lblcomcom"
        Me.lblcomcom.Size = New System.Drawing.Size(154, 28)
        Me.lblcomcom.TabIndex = 2
        Me.lblcomcom.Text = " "
        '
        'lblcomtotal
        '
        Me.lblcomtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcomtotal.ForeColor = System.Drawing.Color.Black
        Me.lblcomtotal.Location = New System.Drawing.Point(219, 300)
        Me.lblcomtotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcomtotal.Name = "lblcomtotal"
        Me.lblcomtotal.Size = New System.Drawing.Size(154, 28)
        Me.lblcomtotal.TabIndex = 2
        Me.lblcomtotal.Text = " "
        '
        'btncal
        '
        Me.btncal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btncal.ForeColor = System.Drawing.Color.Black
        Me.btncal.Location = New System.Drawing.Point(154, 388)
        Me.btncal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btncal.Name = "btncal"
        Me.btncal.Size = New System.Drawing.Size(112, 28)
        Me.btncal.TabIndex = 2
        Me.btncal.Text = "CALCULATE"
        Me.btncal.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Aqua
        Me.btnclose.ForeColor = System.Drawing.Color.Black
        Me.btnclose.Location = New System.Drawing.Point(311, 388)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(112, 28)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "CLOSE"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(186, 25)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = " โปรเเกรมคำณวนยอดขาย"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 428)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btncal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblcomtotal)
        Me.Controls.Add(Me.lblcomcom)
        Me.Controls.Add(Me.lblcomgluta)
        Me.Controls.Add(Me.lblseltotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcom)
        Me.Controls.Add(Me.txtgluta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = " WELLCOM TO PROGRAME"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtgluta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblseltotal As Label
    Friend WithEvents lblcomgluta As Label
    Friend WithEvents lblcomcom As Label
    Friend WithEvents lblcomtotal As Label
    Friend WithEvents btncal As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents Label7 As Label
End Class

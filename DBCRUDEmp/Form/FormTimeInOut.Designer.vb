<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTimeInOut
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
        components = New ComponentModel.Container()
        EMPLOYEEID = New TextBox()
        BTNTIMEINOUT = New Button()
        LBLEMPID = New Label()
        DataGridView1 = New DataGridView()
        lbldate = New Label()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' EMPLOYEEID
        ' 
        EMPLOYEEID.Location = New Point(23, 66)
        EMPLOYEEID.Multiline = True
        EMPLOYEEID.Name = "EMPLOYEEID"
        EMPLOYEEID.Size = New Size(405, 37)
        EMPLOYEEID.TabIndex = 0
        ' 
        ' BTNTIMEINOUT
        ' 
        BTNTIMEINOUT.Location = New Point(515, 66)
        BTNTIMEINOUT.Name = "BTNTIMEINOUT"
        BTNTIMEINOUT.Size = New Size(243, 37)
        BTNTIMEINOUT.TabIndex = 1
        BTNTIMEINOUT.Text = "TIME IN/OUT"
        BTNTIMEINOUT.UseVisualStyleBackColor = True
        ' 
        ' LBLEMPID
        ' 
        LBLEMPID.AutoSize = True
        LBLEMPID.Location = New Point(23, 34)
        LBLEMPID.Name = "LBLEMPID"
        LBLEMPID.Size = New Size(116, 15)
        LBLEMPID.TabIndex = 2
        LBLEMPID.Text = "ENTER EMPLOYEE ID"' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(23, 136)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(735, 237)
        DataGridView1.TabIndex = 3
        ' 
        ' lbldate
        ' 
        lbldate.AutoSize = True
        lbldate.Location = New Point(689, 24)
        lbldate.Name = "lbldate"
        lbldate.Size = New Size(34, 15)
        lbldate.TabIndex = 4
        lbldate.Text = "DATE"' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 10000
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 10000
        ' 
        ' FormTimeInOut
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lbldate)
        Controls.Add(DataGridView1)
        Controls.Add(LBLEMPID)
        Controls.Add(BTNTIMEINOUT)
        Controls.Add(EMPLOYEEID)
        Name = "FormTimeInOut"
        Text = "FormTimeInOut"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents EMPLOYEEID As TextBox
    Friend WithEvents BTNTIMEINOUT As Button
    Friend WithEvents LBLEMPID As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbldate As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class

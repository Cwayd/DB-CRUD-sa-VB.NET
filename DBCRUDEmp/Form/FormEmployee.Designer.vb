<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmployee
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
        Panel1 = New Panel()
        Label1 = New Label()
        EMPLOYEEID = New TextBox()
        FIRSTNAME = New TextBox()
        LASTNAME = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        INSERTBTN = New Button()
        DataGridView1 = New DataGridView()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 39)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bookman Old Style", 20.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(0, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(198, 32)
        Label1.TabIndex = 0
        Label1.Text = "Employee Info"' 
        ' EMPLOYEEID
        ' 
        EMPLOYEEID.Location = New Point(178, 83)
        EMPLOYEEID.Multiline = True
        EMPLOYEEID.Name = "EMPLOYEEID"
        EMPLOYEEID.Size = New Size(194, 46)
        EMPLOYEEID.TabIndex = 1
        ' 
        ' FIRSTNAME
        ' 
        FIRSTNAME.Location = New Point(178, 163)
        FIRSTNAME.Multiline = True
        FIRSTNAME.Name = "FIRSTNAME"
        FIRSTNAME.Size = New Size(194, 35)
        FIRSTNAME.TabIndex = 2
        ' 
        ' LASTNAME
        ' 
        LASTNAME.Location = New Point(178, 241)
        LASTNAME.Multiline = True
        LASTNAME.Name = "LASTNAME"
        LASTNAME.Size = New Size(194, 38)
        LASTNAME.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 30)
        Label2.TabIndex = 4
        Label2.Text = "Employee ID"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(158, 21)
        Label3.TabIndex = 5
        Label3.Text = "Employee First Name"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(12, 258)
        Label4.Name = "Label4"
        Label4.Size = New Size(156, 21)
        Label4.TabIndex = 6
        Label4.Text = "Employee Last Name"' 
        ' INSERTBTN
        ' 
        INSERTBTN.Location = New Point(12, 299)
        INSERTBTN.Name = "INSERTBTN"
        INSERTBTN.Size = New Size(112, 42)
        INSERTBTN.TabIndex = 8
        INSERTBTN.Text = "Insert"
        INSERTBTN.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(378, 83)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(410, 196)
        DataGridView1.TabIndex = 9
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 10000
        ' 
        ' FormEmployee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(INSERTBTN)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(LASTNAME)
        Controls.Add(FIRSTNAME)
        Controls.Add(EMPLOYEEID)
        Controls.Add(Panel1)
        Name = "FormEmployee"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormEmployee"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents EMPLOYEEID As TextBox
    Friend WithEvents FIRSTNAME As TextBox
    Friend WithEvents LASTNAME As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents INSERTBTN As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Timer1 As Timer
End Class

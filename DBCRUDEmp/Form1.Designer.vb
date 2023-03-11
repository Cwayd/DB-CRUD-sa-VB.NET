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
        Panel1 = New Panel()
        Btntimeinout = New Button()
        BtnNew = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Btntimeinout)
        Panel1.Controls.Add(BtnNew)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(378, 60)
        Panel1.TabIndex = 0
        ' 
        ' Btntimeinout
        ' 
        Btntimeinout.Location = New Point(92, 0)
        Btntimeinout.Name = "Btntimeinout"
        Btntimeinout.Size = New Size(98, 60)
        Btntimeinout.TabIndex = 1
        Btntimeinout.Text = "Time in/out"
        Btntimeinout.UseVisualStyleBackColor = True
        ' 
        ' BtnNew
        ' 
        BtnNew.Location = New Point(0, 0)
        BtnNew.Name = "BtnNew"
        BtnNew.Size = New Size(98, 60)
        BtnNew.TabIndex = 0
        BtnNew.Text = "New Employee "
        BtnNew.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(378, 211)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btntimeinout As Button
    Friend WithEvents BtnNew As Button
End Class

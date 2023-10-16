<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        components = New ComponentModel.Container()
        tmrTimer = New Timer(components)
        btnToggle = New Button()
        SuspendLayout()
        ' 
        ' tmrTimer
        ' 
        tmrTimer.Interval = 50
        ' 
        ' btnToggle
        ' 
        btnToggle.Font = New Font("Museo 700", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        btnToggle.Location = New Point(12, 12)
        btnToggle.Name = "btnToggle"
        btnToggle.Size = New Size(776, 426)
        btnToggle.TabIndex = 0
        btnToggle.Text = "Start"
        btnToggle.UseVisualStyleBackColor = True
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnToggle)
        Name = "frmMain"
        Text = "frmMain"
        ResumeLayout(False)
    End Sub

    Friend WithEvents tmrTimer As Timer
    Friend WithEvents btnToggle As Button
End Class

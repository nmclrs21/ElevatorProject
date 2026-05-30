<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmElevator
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
        Me.pnlShaft = New System.Windows.Forms.Panel()
        Me.pnlCabin = New System.Windows.Forms.Panel()
        Me.pnlRightDoor = New System.Windows.Forms.Panel()
        Me.pnlLeftDoor = New System.Windows.Forms.Panel()
        Me.btnFloor1 = New System.Windows.Forms.Button()
        Me.btnFloor2 = New System.Windows.Forms.Button()
        Me.btnFloor3 = New System.Windows.Forms.Button()
        Me.lblFloor = New System.Windows.Forms.Label()
        Me.tmrMove = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDoor = New System.Windows.Forms.Timer(Me.components)
        Me.btnFloor4 = New System.Windows.Forms.Button()
        Me.pnlShaft.SuspendLayout()
        Me.pnlCabin.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlShaft
        '
        Me.pnlShaft.BackColor = System.Drawing.Color.Maroon
        Me.pnlShaft.Controls.Add(Me.pnlCabin)
        Me.pnlShaft.Location = New System.Drawing.Point(292, 27)
        Me.pnlShaft.Name = "pnlShaft"
        Me.pnlShaft.Size = New System.Drawing.Size(144, 518)
        Me.pnlShaft.TabIndex = 0
        '
        'pnlCabin
        '
        Me.pnlCabin.BackColor = System.Drawing.Color.Silver
        Me.pnlCabin.Controls.Add(Me.pnlRightDoor)
        Me.pnlCabin.Controls.Add(Me.pnlLeftDoor)
        Me.pnlCabin.Location = New System.Drawing.Point(12, 402)
        Me.pnlCabin.Name = "pnlCabin"
        Me.pnlCabin.Size = New System.Drawing.Size(120, 80)
        Me.pnlCabin.TabIndex = 0
        '
        'pnlRightDoor
        '
        Me.pnlRightDoor.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.pnlRightDoor.BackColor = System.Drawing.Color.DeepPink
        Me.pnlRightDoor.Location = New System.Drawing.Point(60, 0)
        Me.pnlRightDoor.Name = "pnlRightDoor"
        Me.pnlRightDoor.Size = New System.Drawing.Size(60, 80)
        Me.pnlRightDoor.TabIndex = 1
        '
        'pnlLeftDoor
        '
        Me.pnlLeftDoor.BackColor = System.Drawing.Color.DeepPink
        Me.pnlLeftDoor.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeftDoor.Name = "pnlLeftDoor"
        Me.pnlLeftDoor.Size = New System.Drawing.Size(60, 80)
        Me.pnlLeftDoor.TabIndex = 0
        '
        'btnFloor1
        '
        Me.btnFloor1.BackColor = System.Drawing.Color.Blue
        Me.btnFloor1.Location = New System.Drawing.Point(575, 429)
        Me.btnFloor1.Name = "btnFloor1"
        Me.btnFloor1.Size = New System.Drawing.Size(75, 23)
        Me.btnFloor1.TabIndex = 1
        Me.btnFloor1.Text = "Floor 1"
        Me.btnFloor1.UseVisualStyleBackColor = False
        '
        'btnFloor2
        '
        Me.btnFloor2.BackColor = System.Drawing.Color.Green
        Me.btnFloor2.Location = New System.Drawing.Point(575, 356)
        Me.btnFloor2.Name = "btnFloor2"
        Me.btnFloor2.Size = New System.Drawing.Size(75, 23)
        Me.btnFloor2.TabIndex = 2
        Me.btnFloor2.Text = "Floor 2"
        Me.btnFloor2.UseVisualStyleBackColor = False
        '
        'btnFloor3
        '
        Me.btnFloor3.BackColor = System.Drawing.Color.Goldenrod
        Me.btnFloor3.Location = New System.Drawing.Point(575, 279)
        Me.btnFloor3.Name = "btnFloor3"
        Me.btnFloor3.Size = New System.Drawing.Size(75, 23)
        Me.btnFloor3.TabIndex = 3
        Me.btnFloor3.Text = "Floor 3"
        Me.btnFloor3.UseVisualStyleBackColor = False
        '
        'lblFloor
        '
        Me.lblFloor.AutoSize = True
        Me.lblFloor.BackColor = System.Drawing.Color.Pink
        Me.lblFloor.Location = New System.Drawing.Point(586, 132)
        Me.lblFloor.Name = "lblFloor"
        Me.lblFloor.Size = New System.Drawing.Size(48, 16)
        Me.lblFloor.TabIndex = 4
        Me.lblFloor.Text = "Ready"
        '
        'tmrMove
        '
        Me.tmrMove.Interval = 20
        '
        'tmrDoor
        '
        Me.tmrDoor.Interval = 20
        '
        'btnFloor4
        '
        Me.btnFloor4.BackColor = System.Drawing.Color.Yellow
        Me.btnFloor4.Location = New System.Drawing.Point(575, 203)
        Me.btnFloor4.Name = "btnFloor4"
        Me.btnFloor4.Size = New System.Drawing.Size(75, 23)
        Me.btnFloor4.TabIndex = 5
        Me.btnFloor4.Text = "Floor 4"
        Me.btnFloor4.UseVisualStyleBackColor = False
        '
        'frmElevator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.btnFloor4)
        Me.Controls.Add(Me.lblFloor)
        Me.Controls.Add(Me.btnFloor3)
        Me.Controls.Add(Me.btnFloor2)
        Me.Controls.Add(Me.btnFloor1)
        Me.Controls.Add(Me.pnlShaft)
        Me.Name = "frmElevator"
        Me.Text = "Naomi Elevator Simulation"
        Me.pnlShaft.ResumeLayout(False)
        Me.pnlCabin.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlShaft As Panel
    Friend WithEvents pnlCabin As Panel
    Friend WithEvents pnlLeftDoor As Panel
    Friend WithEvents pnlRightDoor As Panel
    Friend WithEvents btnFloor1 As Button
    Friend WithEvents btnFloor2 As Button
    Friend WithEvents btnFloor3 As Button
    Friend WithEvents lblFloor As Label
    Friend WithEvents tmrMove As Timer
    Friend WithEvents tmrDoor As Timer
    Friend WithEvents btnFloor4 As Button
End Class

Public Class frmElevator
    ' Variables for Movement
    Dim targetTop As Integer
    Dim moveSpeed As Integer = 3
    Dim floor1 As Integer
    Dim floor2 As Integer
    Dim floor3 As Integer
    Dim floor4 As Integer
    Dim totalHeight As Integer
    Dim stepHeight As Integer
    Dim currentFloor As Integer = 1


    ' Variables for Doors
    Dim doorSpeed As Integer = 5
    Dim doorState As String = "Closed"
    Dim pendingFloor As Integer = 0

    ' Door positions
    Dim originalDoorLeft As Integer
    Dim doorGap As Integer = 60

    Private Sub frmElevator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalHeight = pnlShaft.Height - pnlCabin.Height
        stepHeight = totalHeight \ 3
        floor1 = totalHeight - 10
        floor2 = totalHeight - stepHeight
        floor3 = totalHeight - (stepHeight * 2)
        floor4 = 10


    End Sub

    ' --- BUTTONS ---

    Private Sub btnFloor1_Click(sender As Object, e As EventArgs) Handles btnFloor1.Click
        Call MoveToFloor(1, floor1)
    End Sub

    Private Sub btnFloor2_Click(sender As Object, e As EventArgs) Handles btnFloor2.Click
        Call MoveToFloor(2, floor2)
    End Sub

    Private Sub btnFloor3_Click(sender As Object, e As EventArgs) Handles btnFloor3.Click
        Call MoveToFloor(3, floor3)
    End Sub

    Private Sub MoveToFloor(floorNum As Integer, topPos As Integer)
        lblFloor.Text = "Going to Floor " & floorNum
        targetTop = topPos

        If doorState <> "Closed" Then
            pendingFloor = floorNum
            doorState = "Closing"
            tmrDoor.Start()
        Else
            pendingFloor = 0
            tmrMove.Start()
        End If
    End Sub

    ' --- MOVEMENT TIMER ---

    Private Sub tmrMove_Tick(sender As Object, e As EventArgs) Handles tmrMove.Tick
        If Math.Abs(pnlCabin.Top - targetTop) <= 5 Then
            pnlCabin.Top = targetTop
            tmrMove.Stop()
            currentFloor = GetFloorNumber(targetTop)
            lblFloor.Text = "CURRENT FLOOR: " & currentFloor
            doorState = "Opening"
            tmrDoor.Start()
        ElseIf pnlCabin.Top > targetTop Then
            pnlCabin.Top -= moveSpeed
        Else
            pnlCabin.Top += moveSpeed
        End If
    End Sub

    ' --- DOOR TIMER ---

    Private Sub tmrDoor_Tick(sender As Object, e As EventArgs) Handles tmrDoor.Tick

        If doorState = "Opening" Then
            If pnlLeftDoor.Left > originalDoorLeft - doorGap Then
                pnlLeftDoor.Left -= doorSpeed
                pnlRightDoor.Left += doorSpeed
            Else
                tmrDoor.Stop()
                doorState = "Open"
            End If

        ElseIf doorState = "Closing" Then
            If pnlLeftDoor.Left < originalDoorLeft Then
                pnlLeftDoor.Left += doorSpeed
                pnlRightDoor.Left -= doorSpeed
            Else
                tmrDoor.Stop()
                doorState = "Closed"

                Select Case pendingFloor
                    Case 1
                        targetTop = floor1
                    Case 2
                        targetTop = floor2
                    Case 3
                        targetTop = floor3
                    Case 4
                        targetTop = floor4

                End Select
                pendingFloor = 0
                    tmrMove.Start()
                End If
            End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pnlShaft_Paint(sender As Object, e As PaintEventArgs) Handles pnlShaft.Paint

    End Sub
    Private Sub btnFloor4_Click(sender As Object, e As EventArgs) Handles btnFloor4.Click
        Call MoveToFloor(4, floor4)
    End Sub




    Private Function GetFloorNumber(pos As Integer) As Integer
        If pos = floor1 Then Return 1
        If pos = floor2 Then Return 2
        If pos = floor3 Then Return 3
        If pos = floor4 Then Return 4
        Return 0
    End Function

End Class


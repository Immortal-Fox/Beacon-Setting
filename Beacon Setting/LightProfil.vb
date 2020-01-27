''' <summary>
''' It's a customizable light profil
''' </summary>
Public Class LightProfil
    Inherits PictureBox

    ' Fields for light information
    Private title As String
    Private colorLight1 As String
    Private colorLight2 As String
    Private colorLight3 As String
    Private colorLight4 As String
    Private colorLight5 As String
    Private numberOfBeacon As Byte

    ' Fields for graphic
    Private ReadOnly graphicSize As Size = New Size(120, 200)
    Private g As Graphics
    Private bmp As Bitmap
    Private ReadOnly beaconRectSize As Size = New Size(30, 30)

    Sub New()
        ' Create bitmap and its graphic
        SetImageSize(graphicSize)
    End Sub

    ''' <summary>
    ''' Set image size
    ''' </summary>
    ''' <param name="imgSize">Image size</param>
    Private Sub SetImageSize(ByVal imgSize As Size)
        If Not IsNothing(bmp) Then
            bmp.Dispose()
            g.Dispose()
        End If
        bmp = New Bitmap(imgSize.Width, imgSize.Height)
        g = Graphics.FromImage(bmp)
        Me.Size = imgSize
    End Sub

    ''' <summary>
    ''' Actualize this graphic
    ''' </summary>
    Private Sub RefreshGraphic()
        ' Text format to center text and center alignement
        Dim formatText As StringFormat = New StringFormat()
        formatText.Alignment = StringAlignment.Center
        formatText.LineAlignment = StringAlignment.Center
        Dim titleFont As New Font("Consolas", 9, FontStyle.Bold)
        ' Set image size
        SetImageSize(New Size(Me.Width, 25 + (beaconRectSize.Height * numberOfBeacon) + 2))

        ' Clear
        g.Clear(Color.Gainsboro)
        ' Title
        Dim rectTitle As New Rectangle(0, 0, Me.Width, 25)
        g.FillRectangle(New SolidBrush(Color.LightGray), rectTitle)
        g.DrawString(title, titleFont, New SolidBrush(Color.Black), rectTitle, formatText)
        ' Beacon
        Dim rectBeacon As New Rectangle(New Point(CInt(Me.Width / 2 - beaconRectSize.Width / 2), rectTitle.Y + rectTitle.Height + beaconRectSize.Height * (numberOfBeacon - 1)), beaconRectSize)
        If numberOfBeacon >= 1 Then
            g.FillRectangle(New SolidBrush(FormMain.GetBeaconColorJSON(colorLight1)), rectBeacon)
            g.DrawRectangle(New Pen(New SolidBrush(Color.Black), 2), rectBeacon)
        End If
        If numberOfBeacon > 1 Then
            rectBeacon.Location = New Point(rectBeacon.X, rectBeacon.Y - beaconRectSize.Height)
            g.FillRectangle(New SolidBrush(FormMain.GetBeaconColorJSON(colorLight2)), rectBeacon)
            g.DrawRectangle(New Pen(New SolidBrush(Color.Black), 2), rectBeacon)
        End If
        If numberOfBeacon > 2 Then
            rectBeacon.Location = New Point(rectBeacon.X, rectBeacon.Y - beaconRectSize.Height)
            g.FillRectangle(New SolidBrush(FormMain.GetBeaconColorJSON(colorLight3)), rectBeacon)
            g.DrawRectangle(New Pen(New SolidBrush(Color.Black), 2), rectBeacon)
        End If
        If numberOfBeacon > 3 Then
            rectBeacon.Location = New Point(rectBeacon.X, rectBeacon.Y - beaconRectSize.Height)
            g.FillRectangle(New SolidBrush(FormMain.GetBeaconColorJSON(colorLight4)), rectBeacon)
            g.DrawRectangle(New Pen(New SolidBrush(Color.Black), 2), rectBeacon)
        End If
        If numberOfBeacon > 4 Then
            rectBeacon.Location = New Point(rectBeacon.X, rectBeacon.Y - beaconRectSize.Height)
            g.FillRectangle(New SolidBrush(FormMain.GetBeaconColorJSON(colorLight5)), rectBeacon)
            g.DrawRectangle(New Pen(New SolidBrush(Color.Black), 2), rectBeacon)
        End If

        ' Add image
        Me.Image = bmp
    End Sub

    ''' <summary>
    ''' Set light color for this profil
    ''' </summary>
    ''' <param name="light1"></param>
    ''' <param name="light2"></param>
    ''' <param name="light3"></param>
    ''' <param name="light4"></param>
    ''' <param name="light5"></param>
    Public Sub SetLights(Optional light1 As String = Nothing, Optional light2 As String = Nothing, Optional light3 As String = Nothing, Optional light4 As String = Nothing, Optional light5 As String = Nothing)
        ' Light 1
        If Not IsNothing(light1) Then
            colorLight1 = light1
            ' Light 2
            If Not IsNothing(light2) Then
                colorLight2 = light2
                ' Light 3
                If Not IsNothing(light3) Then
                    colorLight3 = light3
                    ' Light 4
                    If Not IsNothing(light4) Then
                        colorLight4 = light4
                        ' Light 5
                        If Not IsNothing(light5) Then
                            colorLight5 = light5
                            numberOfBeacon = 5
                        Else
                            numberOfBeacon = 4
                        End If
                    Else
                        numberOfBeacon = 3
                    End If
                Else
                    numberOfBeacon = 2
                End If
            Else
                numberOfBeacon = 1
            End If
        End If
        RefreshGraphic()
    End Sub

    Sub ControlCLick() Handles Me.DoubleClick
        FormMain.SetLightsButton(colorLight1, colorLight2, colorLight3, colorLight4, colorLight5)
    End Sub

    ''' <summary>
    ''' Get or Set the title field
    ''' </summary>
    ''' <returns>Title</returns>
    Public Property GetTitle As String
        Get
            Return title
        End Get
        Set(value As String)
            title = value
            RefreshGraphic()
        End Set
    End Property

End Class

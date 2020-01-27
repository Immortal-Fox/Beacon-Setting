Public Class FormLightProfils

    Private Const JSN_COLOR_GREEN As String = "Green"
    Private Const JSN_COLOR_RED As String = "Red"
    Private Const JSN_COLOR_ORANGE As String = "Orange"
    Private Const JSN_COLOR_BLUE As String = "Blue"
    '    Private Const JSN_COLOR_WHITE As String = "White"

    ''' <summary>
    ''' Load light profil
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FormLightProfils_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Create profil
        Dim profil1 As New LightProfil
        profil1.SetLights(JSN_COLOR_GREEN, JSN_COLOR_ORANGE)
        profil1.GetTitle = "Minimal"
        panelLightProfils.Controls.Add(profil1)

        Dim profil4 As New LightProfil
        profil4.SetLights(JSN_COLOR_GREEN, JSN_COLOR_ORANGE, JSN_COLOR_RED)
        profil4.GetTitle = "Standard"
        panelLightProfils.Controls.Add(profil4)

        Dim profil2 As New LightProfil
        profil2.SetLights(JSN_COLOR_GREEN, JSN_COLOR_ORANGE, JSN_COLOR_RED, JSN_COLOR_BLUE)
        profil2.GetTitle = "Standard +"
        panelLightProfils.Controls.Add(profil2)
    End Sub

End Class
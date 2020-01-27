Public Class FormLightProfils

    Private Const JSN_COLOR_GREEN As String = "Green"
    Private Const JSN_COLOR_RED As String = "Red"
    Private Const JSN_COLOR_ORANGE As String = "Orange"
    Private Const JSN_COLOR_BLUE As String = "Blue"
    Private Const JSN_COLOR_WHITE As String = "White"

    Private Sub FormLightProfils_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Create profil
        Dim profil1 As New LightProfil
        profil1.SetLights(JSN_COLOR_GREEN, JSN_COLOR_ORANGE, JSN_COLOR_RED)
        profil1.GetTitle = "Standard"
        panelLightProfils.Controls.Add(profil1)

        Dim profil2 As New LightProfil
        profil2.SetLights(JSN_COLOR_BLUE, JSN_COLOR_GREEN, JSN_COLOR_ORANGE, JSN_COLOR_RED)
        profil2.GetTitle = "Standard +"
        panelLightProfils.Controls.Add(profil2)

        Dim profil3 As New LightProfil
        profil3.SetLights(JSN_COLOR_GREEN, JSN_COLOR_RED)
        profil3.GetTitle = "Minimal"
        panelLightProfils.Controls.Add(profil3)

        Dim profil4 As New LightProfil
        profil4.SetLights(JSN_COLOR_GREEN, JSN_COLOR_ORANGE)
        profil4.GetTitle = "Minimal 2"
        panelLightProfils.Controls.Add(profil4)

    End Sub

End Class
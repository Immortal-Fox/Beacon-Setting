'Description :  Cette classe permet de lire les données d'un fichier de configuration au format
'               parametername=parametervalue

'Auteur :       Charmillot Ludovic
'Date :         02.02.2017
'Version :      1

Imports System.Globalization
Imports System.IO

''' <summary>
''' Permet d'intéragir avec un fichier de paramètres
''' </summary>
Public Class ParameterFileReader
    'Listes des relations " nom / valeur "
    Private ReadOnly parameter_table As List(Of ParameterRelation)
    'Private commentary_table As List(Of String)

    Sub New()
        parameter_table = New List(Of ParameterRelation)
    End Sub

    ''' <summary>
    ''' Lit le fichier contenant les paramètres et les récupère dans parameter_table
    ''' </summary>
    ''' <param name="path">Chemin d'accès au fichier</param>
    ''' <param name="clearparameters">true si il faut supprimer les paramètres actuels</param>
    Public Sub ReadFile(ByVal path As String, Optional clearparameters As Boolean = False)

        'Vide la table des paramètres si clearparameters
        If clearparameters Then
            parameter_table.Clear()
        End If

        'Si le fichier de paramètres existe
        If File.Exists(path) Then
            'sr permet de lire les lignes du fichier
            Dim sr As New StreamReader(path)

            'Lit chaque ligne du fichier jusqu'à en trouver une vide
            Do
                Dim line = sr.ReadLine()

                'Sinon on cherche un paramètre avec sa valeur
                If line = "" Then

                Else
                    Dim parametername As String = ""
                    Dim parametervalue As String
                    'Si la ligne est un commentaire on l'ignore
                    If line.First = "#" Then
                        Exit Do
                        'Si la ligne contient un = on tente de récupérer le nom du paramètre
                    ElseIf line.Contains("=") And line.First <> "#" Then

                        'Récupère le nom du paramètre
                        For Each c As Char In line
                            If c <> "=" Then
                                parametername &= c
                            Else
                                Exit For
                            End If
                        Next

                        'Tente de récupérer la valeur
                        parametervalue = line.Remove(0, parametername.Length + 1)

                        parameter_table.Add(New ParameterRelation(parametername.ToString(CultureInfo.CurrentCulture), parametervalue.ToString(CultureInfo.CurrentCulture)))
                    End If
                End If

                'Fin du fichier alors on quitte la boucle
                If sr.EndOfStream Then
                    Exit Do
                End If
            Loop

            'Ferme le streamreader du fichier
            sr.Close()
        End If
    End Sub

    ''' <summary>
    ''' Réinitialise la liste des paramètres
    ''' </summary>
    Public Sub ResetParameter()
        parameter_table.Clear()
    End Sub

    ''' <summary>
    ''' Retourne le nombre de paramètres
    ''' </summary>
    ''' <returns>Nombre de paramètre(s) enregistré(s)</returns>
    Public Function ParameterCount() As Integer
        Return parameter_table.Count
    End Function

    ''' <summary>
    ''' Modifie le paramètre avec la valeur
    ''' </summary>
    ''' <param name="name">Nom du paramètre à modifier</param>
    ''' <param name="value">Valeur</param>
    Public Sub SetParameter(ByVal name As String, ByVal value As String)
        If Me.Exist(name) Then
            For Each item As ParameterRelation In parameter_table
                If item.GetName = name Then
                    item.GetValue = value
                End If
            Next
        Else
            'Sinon on ajoute le paramètre
            AddParameter(name, value)
        End If
    End Sub

    ''' <summary>
    ''' Ecrit dans le fichier tous les paramètres enregistrés
    ''' </summary>
    ''' <param name="path">Chemin d'accès au fichier</param>
    Public Sub WriteFile(ByVal path As String)
        If parameter_table.Count > 0 Then
            Dim sw As New StreamWriter(path, False)
            For Each item As ParameterRelation In parameter_table
                sw.WriteLine(item.GetName & "=" & item.GetValue)
            Next
            sw.Close()
        End If
    End Sub

    ''' <summary>
    ''' Ajouter un paramètre avec sa valeur
    ''' </summary>
    ''' <param name="name">Nom du paramètre</param>
    ''' <param name="value">Valeur du paramètre</param>
    Public Sub AddParameter(ByVal name As String, ByVal value As String)
        'Si les 2 paramètres ne sont pas vide
        If Not IsNothing(name) And Not IsNothing(value) Then
            parameter_table.Add(New ParameterRelation(name, value))
        End If
    End Sub

    ''' <summary>
    ''' Supprime un paramètre
    ''' </summary>
    ''' <param name="name">nom du paramètre</param>
    Public Sub DeleteParameter(ByVal name As String)
        For Each item As ParameterRelation In parameter_table
            If item.GetName = name Then
                parameter_table.Remove(item)
            End If
        Next
    End Sub

    ''' <summary>
    ''' Retourne vrai si le paramètre existe
    ''' </summary>
    ''' <param name="name">Nom du paramètre</param>
    ''' <returns>True si le paramètre existe sinon retourne false </returns>
    Public Function Exist(ByVal name As String) As Boolean
        For Each item As ParameterRelation In parameter_table
            If item.GetName = name Then
                Return True
            End If
        Next
        Return False
    End Function

    ''' <summary>
    ''' Récupère la valeur d'un paramètre
    ''' </summary>
    ''' <param name="name">nom du paramètre</param>
    ''' <returns>Valeur du paramètre</returns>
    Public Function GetParameter(ByVal name As String) As String
        'Parcours la table des paramètres enregistrés
        For Each item As ParameterRelation In parameter_table
            'si il y a une correspondance on retourne la valeur du paramètre recherché
            If item.GetName = name Then
                Return item.GetValue
            End If
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' Récupère la valeur d'un paramètre au format Boolean
    ''' </summary>
    ''' <param name="name">Nom du paramètre</param>
    ''' <param name="defaultparameter">Paramètre retourné si le paramètre n'existe pas ou qu'une erreur se produise</param>
    ''' <returns></returns>
    Public Function GetBoolParameter(ByVal name As String, Optional defaultparameter As Boolean = False) As Boolean
        For Each item As ParameterRelation In parameter_table
            'si il y a une correspondance on retourne la valeur du paramètre recherché
            If item.GetName = name Then
                If item.GetValue = "True" Or item.GetValue = "true" Or item.GetValue = "1" Then
                    Return True
                ElseIf item.GetValue = "False" Or item.GetValue = "false" Or item.GetValue = "0" Then
                    Return False
                Else
                    Return defaultparameter
                End If
            End If
        Next
        Return defaultparameter
    End Function

    ''' <summary>
    ''' Récupère la valeur d'un paramètre au format integer
    ''' </summary>
    ''' <param name="name">Nom du paramètre</param>
    ''' <param name="defaultparameter">Paramètre retourné en cas d'erreur ou si le paramètre n'existe pas</param>
    ''' <returns></returns>
    Public Function GetIntParameter(ByVal name As String, Optional defaultparameter As Integer = 1) As Integer
        For Each item As ParameterRelation In parameter_table
            'si il y a une correspondance on retourne la valeur du paramètre recherché
            If item.GetName = name Then
                If IsNumeric(item.GetValue) Then
                    Return CInt(item.GetValue)
                Else
                    Return defaultparameter
                End If
            End If
        Next
        Return defaultparameter
    End Function

    ''' <summary>
    ''' Relation entre un nom et une valeur
    ''' </summary>
    Protected Class ParameterRelation
        'Variables de la classe
        Private ParameterName As String
        Private ParameterValue As String

        Sub New(ByVal name As String, ByVal value As String)
            ParameterName = name
            ParameterValue = value
        End Sub

        Public Property GetName As String
            Get
                Return ParameterName
            End Get
            Set(value As String)
                ParameterName = value
            End Set
        End Property

        Public Property GetValue As String
            Get
                Return ParameterValue
            End Get
            Set(value As String)
                ParameterValue = value
            End Set
        End Property

    End Class
End Class

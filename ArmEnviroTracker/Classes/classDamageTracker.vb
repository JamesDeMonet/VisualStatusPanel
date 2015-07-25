Public Class classDamageTracker

#Region "Variables"
    'Damage Variables
    Private damageTracker(-1) As DamageSlot
    Private headWoundsMinor(,) As String = {{"bloody nose", 30}, {"black eye", 20}, {"fat lip", 20}, {"broken nose", 5}, {"swollen shut eye", 5}, {"lost tooth", 5}, {"nothing", 15}}
    Private headWoundsMajor(,) As String = {{"split scalp", 10}, {"broken jaw", 10}, {"lost eye", 10}, {"lost ear", 10}, {"broken cheekbone", 10}, {"lost nose", 10}, {"lost multiple teeth", 10}, {"damaged face", 10}, {"nothing", 20}}

    ' A two-dimensional matrix won't work to hold two-dimensional matricies divided by body part and wond severity.
    Private woundsMatrix(,) As String
#End Region

#Region "Enums"

    Public Enum enumBodyParts
        Head = 0
        Neck = 1
        Body = 2
        Arm = 3
        Wrist = 4
        Hand = 5
        Waist = 6
        Leg = 7
        Foot = 8
    End Enum

    Public Enum enumWoundLevels
        Minor = 0
        Major = 1
    End Enum

#End Region ' Enums

#Region "Structures"

    Private Structure DamageSlot
        Dim bodyPart As enumBodyParts ' Later, this may be stored as a string instead of as an enum so that it isn't specific to one game
        Dim currentDamagePercentage As Double
        Dim injuryType As Integer
        Dim timeLeftToHeal As DateTime
        Dim numberOfMinorWounds As Integer
        Dim numberOfMajorWounds As Integer
    End Structure

    Private Structure Wound
        Dim woundName As String
        Dim occurrencePercentage As Double
    End Structure

#End Region ' Structures

End Class

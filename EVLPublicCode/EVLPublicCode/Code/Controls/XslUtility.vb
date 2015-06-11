Imports System.Numerics

''' <summary>
''' Contains a small number of static (shared) utility functions for use in the XSLT scripts
''' </summary>
Public NotInheritable Class XslUtility
    Private Sub New()
    End Sub

    Shared _instance As XslUtility

    Public Shared ReadOnly Property Instance() As XslUtility
        Get
            If _instance Is Nothing Then
                _instance = New XslUtility()
            End If

            Return _instance
        End Get
    End Property

    ''' <summary>
    ''' Formats dates into a user-friendly format
    ''' </summary>
    ''' <param name="xmlDate"></param>
    ''' <param name="format"></param>
    Public Shared Function GetFormattedDate(ByVal xmlDate As String, ByVal format As String) As String
        Dim dt As Date = Nothing
        Dim returnValue As String = String.Empty

        If DateTime.TryParse(xmlDate, System.Globalization.CultureInfo.CurrentUICulture, Globalization.DateTimeStyles.None, dt) Then
            returnValue = dt.ToString(format, System.Globalization.CultureInfo.CurrentUICulture)
        End If

        Return returnValue

    End Function

    ''' <summary>
    ''' Formats 16 digit reference numbers into 4 block of 4 digits
    ''' </summary>
    ''' <param name="refNumber"></param>
    Public Shared Function FormatRefNumber(ByVal refNumber As String) As String
        Dim l As Long = Nothing
        Dim returnValue As String = String.Empty

        If Long.TryParse(refNumber, System.Globalization.NumberStyles.None, System.Globalization.CultureInfo.CurrentUICulture, l) Then
            returnValue = l.ToString("####-####-####-####", System.Globalization.CultureInfo.CurrentUICulture)
        End If

        Return returnValue
    End Function

    ''' <summary>
    ''' Formats 21 digit DDMandateID into 3 blocks of 6 digits and 1 block of 3
    ''' </summary>
    ''' <param name="refNumber"></param>
    Public Shared Function FormatMandateID(ByVal refNumber As String) As String
        Dim l As BigInteger = Nothing
        Dim returnValue As String = String.Empty

        If BigInteger.TryParse(refNumber, System.Globalization.NumberStyles.None, System.Globalization.CultureInfo.CurrentUICulture, l) Then
            returnValue = l.ToString("0#####-######-######-###", System.Globalization.CultureInfo.CurrentUICulture)
        End If

        Return returnValue

    End Function

    ''' <summary>
    ''' Adds the spacing in the VRM so it is formatted correctly
    ''' </summary>
    ''' <param name="VRM">Pass the VRM</param>
    ''' <returns>Formatted VRM with spacing</returns>
    ''' <remarks></remarks>
    Public Shared Function FormatVRM(ByVal VRM As String) As String

        Dim regex2 As Regex = New Regex(".[A-Z][A-Z][A-Z]")
        Dim regex3 As Regex = New Regex("[A-Z][A-Z][A-Z].")
        VRM = Regex.Replace(VRM, "\s", "").ToUpper()

        Dim VrmLen As Integer = VRM.Length
        If regex2.Match(VRM).Success Then Return String.Format("{0} {1}", Left(VRM, VrmLen - 3), Right(VRM, 3))
        If regex3.Match(VRM).Success Then Return String.Format("{0} {1}", Left(VRM, 3), Mid(VRM, 4, 100))

        Dim isNumb As Boolean = IsNumeric(Left(VRM, 1))
        Dim VRM2 As String = String.Empty

        For i = 1 To VrmLen
            If isNumb = IsNumeric(Mid(VRM, i, 1)) Then
                VRM2 = VRM2 & Mid(VRM, i, 1)
            Else
                VRM2 = String.Format("{0} {1}", VRM2, Mid(VRM, i, 1))
                isNumb = IsNumeric(Mid(VRM, i, 1))
            End If
        Next i

        If Not String.IsNullOrWhiteSpace(VRM2) Then
            Return VRM2
        Else
            Return VRM
        End If
    End Function

    ''' <summary>
    ''' Trim the spaces
    ''' </summary>
    ''' <param name="val"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function TrimMySpace(ByVal val As String) As String
        Return val.Trim
    End Function

    Public Shared Function GetDate() As Date
        Return Date.Now
    End Function

End Class

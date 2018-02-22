Imports System.Text.RegularExpressions

Public Class Validation
    Private _xmlPath As String



    Public Enum numericType
        _integer = 1
        _decimal = 2
    End Enum

    Public Enum dateType
        _date = 1
        _datetime = 2
    End Enum

    Public Property xmlPath() As String
        Get
            Return _xmlPath
        End Get
        Set(ByVal value As String)
            _xmlPath = value
        End Set
    End Property
    Public Function is_valid_url(ByVal str_url As String) As Boolean
        Dim matchRegex As New Regex("(http|https)://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?")
        Dim matches As MatchCollection = matchRegex.Matches(str_url)
        If matches.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function is_valid_email(ByVal email_id As String) As Boolean
        Dim matchRegex As New Regex("[a-zA-Z0-9_\-\.]+@[a-zA-Z0-9_\-\.]+\.[a-zA-Z]{2,5}")
        Dim matches As MatchCollection = matchRegex.Matches(email_id)
        If matches.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function


    Public Function ValidateNumeric(ByVal FieldName As String, _
                                     ByVal Value As String, _
                                     ByVal Type As numericType, _
                                     Optional ByVal checkRange As Boolean = False, _
                                     Optional ByVal minValue As Double = intPadrao, _
                                     Optional ByVal maxvalue As Double = intPadrao, _
                                     Optional ByVal required As Boolean = False, _
                                     Optional ByVal allowedValues As String = "", _
                                     Optional ByVal forceInvalidation As Boolean = False, _
                                     Optional ByVal addFieldNameToMessage As Boolean = False) As String

        Dim ret As String = ""
        Dim obj As New Globalization
        Dim dt As DataTable = obj.getData(_xmlPath, "validate")

        If Value Is Nothing Then Value = ""

        If required Then
            If Value.Trim.Length = 0 Or forceInvalidation Then
                If ret.Trim.Length > 0 Then ret += chrPulaLinhaGen
                ret = IIf(addFieldNameToMessage, FieldName & ": ", "") & obj.getValue(dt, "required")
                If Not forceInvalidation Then Return ret
            End If
        End If


        If Value.Trim.Length > 0 Then
            If Not IsNumeric(Value) Or forceInvalidation Then
                If ret.Trim.Length > 0 Then ret += chrPulaLinhaGen
                ret = IIf(addFieldNameToMessage, FieldName & ": ", "") & obj.getValue(dt, "num")
                If Not forceInvalidation Then Return ret
            End If

            If checkRange Then

                If minValue <> intPadrao Then
                    If CDbl(Value) < minValue Or forceInvalidation Then
                        If ret.Trim.Length > 0 Then ret += chrPulaLinhaGen
                        ret += IIf(addFieldNameToMessage, FieldName & ": ", "") & String.Format(obj.getValue(dt, "ranmin"), CStr(minValue))
                    End If
                End If

                If maxvalue <> intPadrao Then
                    If CDbl(Value) > maxvalue Or forceInvalidation Then
                        If ret.Trim.Length > 0 Then ret += chrPulaLinhaGen
                        ret += IIf(addFieldNameToMessage, FieldName & ": ", "") & String.Format(obj.getValue(dt, "ranmax"), CStr(maxvalue))
                    End If
                End If


            End If
        End If

        If allowedValues IsNot Nothing Then
            If allowedValues.Trim.Length > 0 Then
                Dim achou As Boolean = False
                Dim delimAllowed As String = "|"
                Dim values() As String = Split(allowedValues, delimAllowed)
                If values.Length > 0 Then
                    For Each val As String In values
                        If Value.Trim = val Then
                            achou = True
                            Exit For
                        End If
                    Next
                    If Not achou Or forceInvalidation Then
                        If ret.Trim.Length > 0 Then ret += chrPulaLinhaGen
                        ret += IIf(addFieldNameToMessage, FieldName & ": ", "") & String.Format(obj.getValue(dt, "allowed"), Replace(allowedValues, delimAllowed, ","))
                        If Not forceInvalidation Then Return ret
                    End If
                End If
            End If
        End If

        Return ret
    End Function

    Public Function ValidateString(ByVal FieldName As String, _
                                     ByVal Value As String, _
                                     Optional ByVal checkSize As Boolean = False, _
                                     Optional ByVal minSize As Integer = intPadrao, _
                                     Optional ByVal maxSize As Integer = intPadrao, _
                                     Optional ByVal required As Boolean = False, _
                                     Optional ByVal allowedValues As String = "", _
                                     Optional ByVal forceInvalidation As Boolean = False, _
                                     Optional ByVal addFieldNameToMessage As Boolean = True) As String

        Dim ret As String = ""
        Dim obj As New Globalization
        Dim dt As DataTable = obj.getData(_xmlPath, "validate")

        If Value Is Nothing Then Value = ""

        If required Then
            If Value.Trim.Length = 0 Or forceInvalidation Then
                If ret.Trim.Length > 0 Then ret += chrPulaLinhaGen
                ret = IIf(addFieldNameToMessage, FieldName & ": ", "") & obj.getValue(dt, "required")
                If Not forceInvalidation Then Return ret
            End If
        End If



        If checkSize Then


            If minSize <> strPadrao And maxSize <> strPadrao Then
                If minSize = maxSize Then
                    If Value.Trim.Length <> minSize Or forceInvalidation Then
                        If ret.Trim.Length > 0 Then ret += chrPulaLinhaGen
                        ret += IIf(addFieldNameToMessage, FieldName & ": ", "") & String.Format(obj.getValue(dt, "len"), CStr(maxSize))
                        If Not forceInvalidation Then Return ret
                    End If
                End If
            End If

            If minSize <> strPadrao Then
                If Value.Trim.Length < minSize Or forceInvalidation Then
                    If ret.Trim.Length > 0 Then ret += chrPulaLinhaGen
                    ret += IIf(addFieldNameToMessage, FieldName & ": ", "") & String.Format(obj.getValue(dt, "lenmin"), CStr(minSize))
                End If
            End If

            If maxSize <> strPadrao Then
                If Value.Trim.Length > maxSize Or forceInvalidation Then
                    If ret.Trim.Length > 0 Then ret += chrPulaLinhaGen
                    ret += IIf(addFieldNameToMessage, FieldName & ": ", "") & String.Format(obj.getValue(dt, "lenmax"), CStr(maxSize))
                End If
            End If


        End If

        If allowedValues IsNot Nothing Then
            If allowedValues.Trim.Length > 0 Then
                Dim achou As Boolean = False
                Dim delimAllowed As String = "|"
                Dim values() As String = Split(allowedValues, delimAllowed)
                If values.Length > 0 Then
                    For Each val As String In values
                        If Value.Trim = val Then
                            achou = True
                            Exit For
                        End If
                    Next
                    If Not achou Or forceInvalidation Then
                        If ret.Trim.Length > 0 Then ret += chrPulaLinhaGen
                        ret += IIf(addFieldNameToMessage, FieldName & ": ", "") & String.Format(obj.getValue(dt, "allowed"), Replace(allowedValues, delimAllowed, ","))
                        If Not forceInvalidation Then Return ret
                    End If
                End If
            End If
        End If

        Return ret
    End Function

    Public Function ValidateDate(ByVal FieldName As String, _
                                 ByVal Value As String, _
                                 ByVal type As dateType, _
                                      ByVal checkPeriod As Boolean, _
                                      ByVal minDate As DateTime, _
                                      ByVal maxDate As DateTime, _
                                      ByVal required As Boolean, _
                                      Optional ByVal forceInvalidation As Boolean = False, _
                                     Optional ByVal addFieldNameToMessage As Boolean = False) As String

        Dim ret As String = ""
        Dim obj As New Globalization
        Dim dt As DataTable = obj.getData(_xmlPath, "validate")

        If Value Is Nothing Then Value = ""

        If required Then
            If Value.Trim.Length = 0 Or forceInvalidation Then
                If ret.Trim.Length > 0 Then ret += chrPulaLinhaGen
                ret = IIf(addFieldNameToMessage, FieldName & ": ", "") & obj.getValue(dt, "required")
                If Not forceInvalidation Then Return ret
            End If
        End If

        If Value.Trim.Length > 0 Then
            If Not IsDate(Value) Or forceInvalidation Then
                If ret.Trim.Length > 0 Then ret += chrPulaLinhaGen
                Select Case type
                    Case dateType._date : ret = IIf(addFieldNameToMessage, FieldName & ": ", "") & obj.getValue(dt, "date")
                    Case dateType._datetime : ret = IIf(addFieldNameToMessage, FieldName & ": ", "") & obj.getValue(dt, "datetime")
                End Select
                Return ret
            End If
        End If



        If checkPeriod Then

            If minDate <> datPadrao Then
                If CDate(Value) < minDate Or forceInvalidation Then
                    If ret.Trim.Length > 0 Then ret += chrPulaLinhaGen
                    ret += IIf(addFieldNameToMessage, FieldName & ": ", "") & String.Format(obj.getValue(dt, "datmin"), CStr(minDate))
                End If
            End If

            If maxDate <> datPadrao Then
                If CDate(Value) > maxDate Or forceInvalidation Then
                    If ret.Trim.Length > 0 Then ret += chrPulaLinhaGen
                    ret += IIf(addFieldNameToMessage, FieldName & ": ", "") & String.Format(obj.getValue(dt, "datmax"), CStr(maxDate))
                End If
            End If


        End If



        Return ret
    End Function

End Class

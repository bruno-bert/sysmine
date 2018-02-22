Public Class Filter


    Private intPadrao As Integer = -1111111111
    Private strPadrao As String = Nothing
    Private datPadrao As DateTime = CDate("00:00:00")
    Private datNull As DateTime = CDate("00:00:01")
    Private chrPulaLinha As String = "<br />"

    Private stdNull As String = "is null"
    Private stdNotNull As String = "is not null"
    Private ListDelimiter As String = "|"
    Private ErrorStmt As String = "#ERROR#"
    Private NULO As String = "NULL"

    
    Public Function IncludeFilter(ByVal WhereClause As String, _
                                ByVal FieldName As String, _
                                ByVal TypeName As String, _
                                ByVal _Value As String, _
                                ByVal _Operator As String, _
                                ByVal _ValueEnd As String, _
                                ByVal _OperatorEnd As String, _
                                ByRef retError As String) As String

        Dim obj As New Filter

        Dim tempClause As String = ""
        Dim OriginalValue As String = _Value
        Dim OriginalValueEnd As String = _ValueEnd

        If WhereClause.Trim.Length > 0 Then tempClause += " and "

        _Operator = obj.ConvertOperator(_Value, _Operator)
        _Value = obj.ConvertValue(FieldName, _Value, _Operator, TypeName)

        _OperatorEnd = obj.ConvertOperator(_ValueEnd, _OperatorEnd)
        _ValueEnd = obj.ConvertValue(FieldName, _ValueEnd, _OperatorEnd, TypeName)

        If _Value.Contains(ErrorStmt) Then
            retError = _Value.Replace(ErrorStmt, "")
            Return ""
        End If

        If _ValueEnd IsNot Nothing Then
            If _ValueEnd.Contains(ErrorStmt) Then
                retError = _ValueEnd.Replace(ErrorStmt, "")
                Return ""
            End If
        End If


        If (_Operator = "=" Or _Operator = "<>") And OriginalValue = NULO Then _Operator = ""
        If (_OperatorEnd = "=" Or _OperatorEnd = "<>") And OriginalValueEnd = NULO Then _OperatorEnd = ""

        tempClause += FieldName & " " & _Operator & " " & _Value

        If _OperatorEnd IsNot Nothing And _ValueEnd IsNot Nothing Then
            If _OperatorEnd <> "" Then
                If tempClause.Trim.Length > 0 Then tempClause += " and "
                tempClause += FieldName & " " & _OperatorEnd & " " & _ValueEnd
            End If
        End If


        Return tempClause
    End Function
    Public Function ConvertOperator(ByVal _Value As String, ByVal _Operator As String) As String
        Dim NULO As String = "NULL"

        'Para SQL não tem diferença
        Select Case _Operator
            Case "IN" : Return _Operator
            Case "LIKE" : Return _Operator
            Case "=" : Return _Operator
            Case "<>" : Return _Operator
            Case ">=" : Return _Operator
            Case "<=" : Return _Operator
            Case ">" : Return _Operator
            Case "<" : Return _Operator
        End Select

        Return _Operator
    End Function
    Public Function ConvertValue(ByVal FieldName As String, ByVal _Value As String, ByVal _Operator As String, ByVal TypeName As String) As String
        Dim Aspas As String = "'"
        Dim LikeDelimiter As String = "%%"
        Dim ConvertedValue As String = ""
        Dim NULO As String = "NULL"
        Dim retStr As String = ""
        Dim ErrorStmt As String = "#ERROR#"
        Dim ListBeginChar As String = "("
        Dim ListEndChar As String = ")"


        Select Case TypeName

            Case "Integer"

                If _Value = intPadrao.ToString.Trim Then
                    Select Case _Operator
                        Case "=" : Return stdNull
                        Case "<>" : Return stdNotNull
                        Case Else : Return ErrorStmt & FieldName & " - Operador inválido para o tipo Integer - NULL"
                    End Select
                End If

                Select Case _Operator
                    Case "LIKE" : Return ErrorStmt & FieldName & " - Operador LIKE inválido para o tipo Integer"
                    Case "IN" : ConvertedValue = ListBeginChar & ListToSQLList(_Value, ListDelimiter, TypeName) & ListEndChar
                    Case Else : ConvertedValue = _Value
                End Select

            Case "Double"

                If _Value = intPadrao.ToString.Trim Then
                    Select Case _Operator
                        Case "=" : Return stdNull
                        Case "<>" : Return stdNotNull
                        Case Else : Return ErrorStmt & FieldName & " - Operador inválido para o tipo Double - NULL"
                    End Select
                End If

                Select Case _Operator
                    Case "LIKE" : Return ErrorStmt & FieldName & " - Operador LIKE inválido para o tipo Double"
                    Case "IN" : ConvertedValue = ListBeginChar & ListToSQLList(_Value, ListDelimiter, TypeName) & ListEndChar
                    Case Else : ConvertedValue = Replace(_Value, ",", ".")
                End Select

            Case "DateTime"

                If _Value = NULO Then
                    Select Case _Operator
                        Case "=" : Return stdNull
                        Case "<>" : Return stdNotNull
                        Case Else : Return ErrorStmt & FieldName & " - Operador inválido para o tipo DateTime - NULL"
                    End Select
                End If

                Select Case _Operator
                    Case "LIKE" : ConvertedValue = Aspas & Replace(_Value, "%", LikeDelimiter) & Aspas
                    Case "IN" : ConvertedValue = ListBeginChar & ListToSQLList(_Value, ListDelimiter, TypeName) & ListEndChar
                    Case Else : ConvertedValue = Aspas & _Value & Aspas
                End Select

            Case "String"

                If _Value = NULO Then
                    Select Case _Operator
                        Case "=" : Return stdNull
                        Case "<>" : Return stdNotNull
                        Case Else : Return ErrorStmt & FieldName & " - Operador inválido para o tipo String - NULL"
                    End Select
                End If

                Select Case _Operator
                    Case "LIKE" : ConvertedValue = Aspas & Replace(_Value, "%", LikeDelimiter) & Aspas
                    Case "IN" : ConvertedValue = ListBeginChar & ListToSQLList(_Value, ListDelimiter, TypeName) & ListEndChar
                    Case Else : ConvertedValue = Aspas & _Value & Aspas
                End Select

        End Select

        Return ConvertedValue
    End Function

    Public Function ListToSQLList(ByVal _Value As String, ByVal ListDemiliter As String, ByVal TypeName As String) As String
        'converte lista do tipo DADO1|DADO2|DADO3 para 'DADO1','DADO2','DADO3'

        Dim Lista As String = ""
        Dim Aspas As String = ""
        Dim Separador As String = ""
        Dim Tam As Integer = 0

        Select Case TypeName
            Case "Integer", "Double"
                Aspas = ""
                Separador = ","
            Case Else
                Aspas = "'"
                Separador = ","
                If _Value Is Nothing Then Return ""
        End Select

        Tam = Separador.Length

        Dim vLista() As String = _Value.Split(ListDemiliter)

        For Each item As String In vLista
            Lista += Aspas & item & Aspas & Separador
        Next

        'tira última vírgula
        If Lista.Trim.Length > 0 Then Lista = Lista.Substring(0, Lista.Length - Tam)

        Return Lista
    End Function

End Class

Public Class FilterField
    Public _Operator As String
    Public _OperatorEnd As String = Nothing
    Public _Value As String
    Public _ValueEnd As String = Nothing
    Sub New()

    End Sub
    Sub New(ByVal pOperator As String, ByVal pValue As String)
        _Operator = pOperator
        _OperatorEnd = Nothing
        _Value = pValue
        _ValueEnd = Nothing
    End Sub
    Sub New(ByVal pOperator As String, ByVal pValue As String, _
            ByVal pOperatorEnd As String, ByVal pValueEnd As String)
        _Operator = pOperator
        _OperatorEnd = pOperatorEnd
        _Value = pValue
        _ValueEnd = pValueEnd
    End Sub
End Class


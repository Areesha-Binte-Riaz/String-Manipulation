Module Module1

    Sub Main()
        Dim STR As String
        Dim AlphaNum, DIgitNum, ASCII As Integer
        Dim nextChar As Char
        nextChar = " "
        STR = " "
        AlphaNum = 0
        ASCII = 0
        DIgitNum = 0
        Console.WriteLine("Enter String : ")
        STR = Console.ReadLine
        STR = UCase(STR)
        For count = 1 To Len(STR)
            nextChar = Mid(STR, count, 1)
            ASCII = Asc(nextChar)
            If ASCII >= 65 And ASCII <= 90 Then
                AlphaNum = AlphaNum + 1
            Else
                If ASCII >= 48 And ASCII <= 57 Then
                    DIgitNum = DIgitNum + 1
                Else
                    Console.WriteLine("The character entered contains more than just digits and alpabets : " & nextChar)
                End If
            End If
        Next
        Console.WriteLine("The number of alphabets entered : " & AlphaNum)
        Console.WriteLine("The number of digits entered : " & DIgitNum)
        Console.ReadKey()
    End Sub

End Module

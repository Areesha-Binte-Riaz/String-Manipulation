Module Module1

    Sub Main()
        Dim STR1, STR2 As String
        Dim nextChar1, nextChar2 As Char
        Dim ASCII1, ASCII2 As Integer
        ASCII1 = 0
        ASCII1 = 0
        STR1 = " "
        STR2 = " "
        nextChar1 = " "
        nextChar2 = " "
        Console.WriteLine("Enter first string : ")
        STR1 = Console.ReadLine
        Console.WriteLine("Enter second string : ")
        STR2 = Console.ReadLine
        If Len(STR1) = Len(STR2) Then
            For Count = 1 To Len(STR1)
                nextChar1 = Mid(STR1, Count, 1)
                ASCII1 = Asc(nextChar1) + ASCII1
            Next
            For count = 1 To Len(STR2)
                nextChar2 = Mid(STR2, count, 1)
                ASCII2 = Asc(nextChar2) + ASCII2
            Next
            If ASCII1 = ASCII2 Then
                Console.Write("Strings entered are Anagrams")
            End If
        Else
            Console.WriteLine("Strings entered aren't Anagrams")
        End If
        Console.ReadKey()
    End Sub

End Module

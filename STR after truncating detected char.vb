Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim rChar, nextChar As Char
        Dim count As Integer
        Str1 = " "
        Str2 = " "
        rChar = " "
        nextChar = " "
        count = 0
        Console.WriteLine("Enter String:")
        Str1 = Console.ReadLine
        Console.WriteLine("Enter character to remove:")
        rChar = Console.ReadLine
        For count = 1 To Len(Str1)
            nextChar = Mid(Str1, count, 1)
            If nextChar <> rChar Then
                Str2 = Str2 & nextChar
            End If
        Next
        Console.WriteLine("Final String: " & Str2)
        Console.ReadKey()
    End Sub

End Module

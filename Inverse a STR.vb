Module Module1

    Sub Main()
        Dim STR, MyWord As String
        Dim nextChar As Char
        Dim count As Integer
        count = 0
        nextChar = " "
        MyWord = " "
        STR = " "
        Console.WriteLine("Enter your String: ")
        STR = Console.ReadLine
        For count = 1 To Len(STR)
            nextChar = Mid(STR, count, 1)
            MyWord = nextChar & MyWord
        Next
        Console.WriteLine(MyWord)
        Console.ReadKey()
    End Sub

End Module

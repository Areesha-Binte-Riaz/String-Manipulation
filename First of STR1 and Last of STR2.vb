Module Module1

    Sub Main()
        Dim SpacePos As Integer
        Dim STR1, STR2, W1, W2, MyWord As String
        SpacePos = 0
        STR1 = " "
        STR2 = " "
        W1 = " "
        W2 = " "
        MyWord = " "
        Console.WriteLine("Enter 1st String")
        STR1 = Console.ReadLine
        Console.WriteLine("Enter 2nd String")
        STR2 = Console.ReadLine
        SpacePos = InStr(STR1, " ")
        W1 = Left(STR1, SpacePos - 1)
        SpacePos = InStr(STR2, " ")
        W2 = Right(STR2, Len(STR2) - SpacePos)
        MyWord = W1 & " " & W2
        Console.WriteLine(MyWord)
        Console.ReadKey()

    End Sub

End Module

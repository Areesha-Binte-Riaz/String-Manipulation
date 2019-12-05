Module Module1

    Sub Main()
        Dim String1, MyWord As String
        Dim count As Integer
        Dim nextChar As Char
        String1 = " "
        MyWord = " "
        count = 0
        nextChar = " "
        Console.WriteLine("Enter Your String : ")
        String1 = Console.ReadLine
        For count = 1 To Len(String1)
            nextChar = Mid(String1, count, 1)
            If nextChar = " " Then
                Console.WriteLine(MyWord)
                MyWord = " "
            Else
                MyWord = MyWord & nextChar
            End If
        Next
        Console.WriteLine(MyWord)
        Console.ReadKey()
    End Sub

End Module

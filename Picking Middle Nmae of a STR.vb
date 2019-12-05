Module Module1

    Sub Main()
        Dim NameX, MN As String
        Dim FPos, SPos As Integer
        NameX = " "
        MN = " "
        FPos = 0
        SPos = 0
        Console.WriteLine("Input Name : ")
        NameX = Console.ReadLine
        FPos = InStr(NameX, " ")
        SPos = InStr(FPos + 1, NameX, " ")
        MN = Mid(NameX, FPos + 1, SPos - FPos - 1)
        Console.WriteLine("Middle Name: " & MN)
        Console.ReadKey()
    End Sub

End Module

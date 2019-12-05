Module Module1

    Sub Main()
        Dim STR1 As String
        Dim Counter As Integer
        Dim A As Integer
        Dim Found As Boolean
        Found = False
        STR1 = " "
        Counter = 0
        A = 0
        Console.Write("Enter String: ")
        STR1 = Console.ReadLine
        STR1 = UCase(STR1)
        For Counter = 0 To 25
            If InStr(STR1, Chr(65 + Counter)) > 0 Then
                Found = True
            Else
                Found = False
                Console.WriteLine("Sentence entered is not a pangram.")
            End If
        Next Counter
        Console.WriteLine("Sentence entered is a pangram.")
        Console.ReadKey()


    End Sub

End Module

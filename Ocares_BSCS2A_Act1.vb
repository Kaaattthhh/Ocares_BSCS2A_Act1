Imports System
Imports System.Threading

Module Ocares_BSCS2A_Act1
    Sub Main(args As String())
        Dim firstNumber, terminationNumber, product As Double

        Console.WriteLine(" Let's solve it! ")
        Console.WriteLine(" Input first number: ")
        firstNumber = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine(" Input termination number: ")
        terminationNumber = Convert.ToDouble(Console.ReadLine)

        For i = 1 To terminationNumber
            product = firstNumber * i
            Console.WriteLine(firstNumber & " X " & i & " = " & product)

        Next
        Console.WriteLine("Do you want to input another number? (Yes/Else): Y or N")
        Dim restart As String = Console.ReadLine()
        If (restart.ToUpper() = "Y" Or restart.ToLower() = "N") Then
            System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName)
            Environment.Exit(0)
        End If
        Console.WriteLine(" Thank you ")

        Console.ReadKey()

    End Sub
End Module

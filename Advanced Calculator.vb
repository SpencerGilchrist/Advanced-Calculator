'Spencer Gilchrist
'RCET0265
'Spring 2021
'Advanced Calculator
Module Module1
    Sub Main()

        Dim FirstNumber As String
        Dim SecondNumber As String
        Dim UserInput As String
        Dim Problem As Boolean

Line1:
        Console.WriteLine("Enter First Number!")

        'These Try Catch Statements Will Catch any letters enterd into the program and clear the calculator

        Try
            UserInput = Console.ReadLine
            FirstNumber = CInt(UserInput)
            Problem = False

        Catch e As Exception
            Console.WriteLine("You Entered a Letter in a calculator?")
            System.Threading.Thread.Sleep(1500)
            Console.WriteLine("Try a number this time")
            System.Threading.Thread.Sleep(2500)
            Console.Clear()
            GoTo Line1

        End Try

        Console.WriteLine("If You wish to Quit Press Q! If Not Press A and Continue!")

        'These Select cases alow the user to quit when prompted

        Select Case Console.ReadKey.Key
            Case ConsoleKey.Q
                Console.WriteLine("Very Well, Have a nice Day!")
                System.Threading.Thread.Sleep(2500)
                Console.Clear()
                GoTo Line2

            Case ConsoleKey.A
                Console.Clear()
                Console.WriteLine("Please Enter another Number!")

        End Select

        'Another Try Catch Function

        Try
            UserInput = Console.ReadLine
            SecondNumber = CInt(UserInput)
            Problem = False

        Catch e As Exception
            Console.WriteLine("You Entered a Letter in a calculator?")
            System.Threading.Thread.Sleep(1500)
            Console.WriteLine("Try a number this time")
            System.Threading.Thread.Sleep(2500)
            Console.Clear()
            GoTo Line1

        End Try

        'Another Quit Prompt

        Console.WriteLine("If You wish to Quit Press Q! If not Press A")

        Select Case Console.ReadKey.Key
            Case ConsoleKey.Q
                Console.WriteLine("Very Well, Have a nice Day!")
                System.Threading.Thread.Sleep(2500)
                Console.Clear()
                GoTo Line2

            Case ConsoleKey.A
                Console.Clear()
        End Select

        Console.WriteLine("Please choose a function")
        Console.WriteLine("Press W to Add, E to Subtract, R to Divide, and T to Multiply! Or if you wish to Quit Press Q.")

        'This allows the user to choose a function and quit if they want.

        Select Case Console.ReadKey.Key
            Case ConsoleKey.W
                Console.Clear()
                Console.WriteLine(Int(FirstNumber) + Int(SecondNumber))
                System.Threading.Thread.Sleep(1500)
                Console.WriteLine("Press enter")
                Console.ReadLine()

            Case ConsoleKey.E
                Console.Clear()
                Console.WriteLine(Int(FirstNumber) - Int(SecondNumber))
                System.Threading.Thread.Sleep(1500)
                Console.WriteLine("Press enter")
                Console.ReadLine()

            Case ConsoleKey.R
                Console.Clear()
                Console.WriteLine(Int(FirstNumber) / Int(SecondNumber))
                System.Threading.Thread.Sleep(1500)
                Console.WriteLine("Press enter")
                Console.ReadLine()

            Case ConsoleKey.T
                Console.Clear()
                Console.WriteLine(Int(FirstNumber) * Int(SecondNumber))
                System.Threading.Thread.Sleep(1500)
                Console.WriteLine("Press enter")
                Console.ReadLine()

            Case ConsoleKey.Q
                Console.Clear()
                Console.WriteLine("Very Well Have a nice Day!")
                System.Threading.Thread.Sleep(2500)
                GoTo Line2

        End Select

        'This allows the user to go back to the top and restart or lets the user quit!

        Console.WriteLine("Would you Like to keep using the calculator or Exit?")
        System.Threading.Thread.Sleep(1500)
        Console.WriteLine("Press Y for Yes or N for No.")

        Select Case Console.ReadKey.Key

            Case ConsoleKey.Y
                Console.Clear()
                GoTo Line1

            Case ConsoleKey.N
                Console.Clear()
        End Select

Line2:

    End Sub

End Module

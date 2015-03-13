Module Module1

    Class companyinfo
        Public CompanyName As String
        Public CompanyOwner As String
        Public CompanyAddress As String
        Public CompanyContactNumber As String
        Public HourlyRate As String

    End Class

    Dim Company As companyinfo


    Sub ViewIncompleteBooking()

    End Sub
    Sub AddBooking()

        Console.Write("Adding a new booking, enter the details below: ")

    End Sub
    Sub Menu()


        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("Welcome")
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("---------------------------------------------")
        Console.ForegroundColor = ConsoleColor.DarkRed
        Console.WriteLine("Total complete hour:                        -")
        Console.WriteLine("Total Income:                               -")
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("---------------------------------------------")
        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("Select from one of the following menu options:")
        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.DarkRed
        Console.WriteLine(" (A) Add a booking")
        Console.WriteLine(" (B) View all incomplete bookings")
        Console.WriteLine(" (C) View all complete bookings")
        Console.WriteLine(" (D) Check incomplete bookings for the next 7 days")
        Console.WriteLine()
        Console.WriteLine(" (E) View incomplete booking's details")
        Console.WriteLine(" (F) Edit incomplete booking details")
        Console.WriteLine()
        Console.WriteLine(" (G) Remove a booking")
        Console.WriteLine(" (H) Complete a booking")
        Console.WriteLine()
        Console.WriteLine(" (I) View business card")
        Console.WriteLine()
        Console.WriteLine(" (X) Exit")

        Select Case Console.ReadKey.KeyChar



            Case "A"

                AddBooking()

        End Select
        ' Console.ReadLine()

    End Sub
    Sub CompainyInfoCreation()

        '2nd Page

        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("No company information has been found. We'll setup a profile before we begin.")
        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")

        Console.ReadKey()
        Console.Clear()

        '3rd Page

        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("Here you need to enter the details for your new company profile.")
        Console.WriteLine()
        Console.Write("Company name: ")
        Console.ReadLine()
        Console.Write("Company owner's name: ")
        Console.ReadLine()
        Console.Write("Company contact number: ")
        Console.ReadLine()
        Console.Write("Company address: ")
        Console.ReadLine()
        Console.Write("Company hourly rate: $")
        Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine("Setup is complete!")
        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadKey()

    End Sub
    Sub Main()

        Console.ForegroundColor = ConsoleColor.Green

        Console.SetCursorPosition(23, 0)
        Console.Write("Welcome to Fun With Laws v0.1")
        Console.SetCursorPosition(18, 1)
        Console.Write("Your all on one lawn management system.")
        Console.SetCursorPosition(25, 3)
        Console.ForegroundColor = ConsoleColor.Blue
        Console.Write("Press any key to continue...")

        Console.ReadKey()
        Console.Clear()



        CompainyInfoCreation()

        Menu()






    End Sub

End Module

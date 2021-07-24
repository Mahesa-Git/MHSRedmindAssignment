MHSRedmindAssignment
Testanswer for Redminds backend developer assignment by Mattias Hermansson Salmi ITHS .NET 2020
Instructions for building source code, executing application and run the unit test using the commandline (cmd.exe):

*Launch cmd.exe

*Navigate to the directory of the repository: MHSRedmindAssignment

*Compile source code and execute application:
- Navigate to directory MHSRedmindAssignment located inside rootfolder with the same name.
- Use the command: dotnet build
- Use the commant: dotnet run

*Run test built using xUnit:
- Navigate to the folder MHSRedmindAssignment.Tests located in the folder MHSRedmindAssignment.
- The test are for testing the ATMDepositCheck-method.
- Use the command: dotnet test --logger "console;verbosity=detailed" to run it.

The program can also be launched using Visual Studio by running the .sln file. To run the test in the IDE you can use the Test Explorer.
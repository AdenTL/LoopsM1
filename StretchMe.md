# Plot Twist
A previous developer left a 5th possible menu option. The code indicates some sort of integration with ZingBot from the We Can Code It - Guessing Game

## Helpful Documents

- Start by researching [Project References](https://docs.microsoft.com/en-us/visualstudio/ide/managing-references-in-a-project?view=vs-2019#project-to-project-references). Really pay attention to the parts about a DLL.
- Now that we are on the right track, we should research [Dynamic-Link Libraries](https://docs.microsoft.com/en-us/windows/win32/dlls/dynamic-link-libraries)
- A quick reminder to review your [Access Modifiers](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers)

## Code for Thought

> Once you have added the appropriate DLL into the lib folder you should notice that ZingBot is accessible but your Guessing Game static method may not be. You can use intellisense to check once you using added the appropriate 'using' statement. What makes ZingBot accessible? Could something be added to make your Guessing Game method accessible?

## Tips and Tricks

> Running a program builds the files and generates a .exe file and a .dll file. The .exe is the executable application and the .dll file is the compiled code. By passing a .dll file off to another developer they have access to your <em>public</em> methods.

## Hints

- External project references via .dll are usually located in the lib folder
- Start by trying to add a Project Reference and using the browse

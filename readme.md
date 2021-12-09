# TimeFlo+
Copyright &copy; 2021 Gabriel Sampang, Daniel Trang, Zachary Springer, Elspeth Anderson, and Sam Khodakovskiy.
 
TimeFlo+ is a more flushed out implementation of a
[Pomodoro&reg;](https://en.wikipedia.org/wiki/Pomodoro_Technique)-like
timer for breaking out of flow state. It is an improvement upon TimeFlo.
 
TimeFlo+ is used to help manage time and provide assistance in breaking out of flow state. It times productive sessions and break sessions, and keeps track of the number of full sessions (1 productive session and 1 break session) completed. The length of both of these sessions are user configurable, with a range of 10-60 minutes for the productive session and 5-60 minutes for the break session. The break session starts automatically after the productive session. There is an audio notification for the user at the end of each session.
 
Each full session starts automatically after the previous one has finished. For the 4th session, the break will be extended by 10 minutes. The timer will not stop unless the user stops it.
 
TimeFlo+ was written in C# and was developed on Visual Studio 2022 (Community Edition). This was done in order to take advantage of Windows Forms application development. This allows for the use of a simple GUI.
 
## Build and Run
In order to build and run TimeFlo+ properly, the folder that the project solution "TimeFlo_Team_Windows_B.sln" is in must be downloaded. Then the solution file itself must be opened as a project in Visual Studio. From there, it can be built and run using the Local Windows Debugger.
 
Running it will make the TimeFlo+ window GUI appear. From here the user may customize the length of the sessions, and interact with the application using the different buttons.
 
## Test
Testing involves manual unit testing of different methods that are in the file Form1.cs as this is where most of the programming was done manually. These are the methods that correspond to the various buttons (Start, Pause, and Reset) and the different displays (countdown display and session tracker).
 
## Link to Meeting Notes Document
https://docs.google.com/document/d/1rY4klADmndvr89s4SE9cg8ig9UrIq1CEG-WbyxWBj4s/edit?usp=sharing 
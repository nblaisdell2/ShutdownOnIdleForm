# ShutdownOnIdleForm

This program is a Windows Form application built in VB.NET, in order to automate the process of shutting down my PC when I haven't used it in a while.

Often times, when I use my PC, I almost always forget to shut it down, which I know would save money and PC resources if it wasn't running constantly. 
I'm not running a server on my PC, and it boots up fairly quickly from being shutdown, so there's not really a benefit to having it run all the time.

So that I don't have to always do it myself, or in case I leave and forget to turn it off, this program will automatically take care of that for me!
The program starts with a default time of 2 hours, which can be adjusted by the user, and is constantly keeping track of when the user's last input came through.
* That's not necessarily input that's being entered in this particular program, but rather it's whether or not the user has moved their mouse, or hit their keyboard, at any time, even if they are using a different application.

This will automatically create a Task Scheduler task to automatically start up the program on Log on, and will start minimized so the user doesn't even have to start it up every time they use thier PC!

<hr>

* I built this project to enhance the version of this program I had previously written, but to make use of Windows Forms instead. 
* I also switched the langugage from C++ to VB.NET, to re-familiarize myself with the language.
* Lastly, the main reason I switched to a Windows Form was so that I could make use of the System Tray (notification area) of Windows, to be able to see that the program is running in the background.

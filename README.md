# SmoothieBoard Host Controller
  -  Demo Video : http://youtu.be/NI9NCI0UJYs
  
# Overview

The goal is to support through a GUI, all the functionality of the smoothie board.  This includes the 3-axis, 4-axis, and 5-axis boards. 
  * Being able to move each axis incrementally using keyboard, mouse, or typed input. (arrow keys, buttons, or typing the number in), This includes using a user settable feed rate
  * Display the current position of all the axes
  * Display the current state of any connected limit switches
  * Set the home position
  * Type in and send commands directly  to the smoothieboard
  * Display both the commands sent and the results returned from the smoothieboard
  * View and Edit the settings on the smoothieboard through the UI
  * Play/Pause a G-Code file and see the progress
For CNC:
  * Set the spindle speed
For 3d Printing:
  * Set the extrude speed
  * read temperature probes
  * Set Hot plate temperature
  * Set Hot end temperature
  * Turn fan on/off or set the speed. (not sure if the fan speed is configurable)

Future work will include functionality for other machining processes.  There may be capabilities that I have missed that will also be added.  Also, potentially cleanup the config verbage to be more consistent and clear.

# Requirments for build
  - Visual Studio Express 2013
  - PInvoke -- https://github.com/slacker247/PInvoke/tree/integration
  - SerialComms -- https://github.com/slacker247/SerialComms/tree/integration
  - Utilities -- https://github.com/slacker247/Utilities/tree/integration

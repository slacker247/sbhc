using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoothieInterface
{
    /// <summary>
    /// http://smoothieware.org/supported-g-codes
    /// </summary>
    class GCode
    {
        /// <summary>
        /// G0
        /// Move to the given coordinates. To the contrary of G1, if there is a tool
        /// it will most of the time be off during this kind of move. This is a
        /// "go to" move rather than a "do while going to" move. The F parameter
        /// defines speed and is remembered by subsequent commands ( specified in
        /// millimetres/minute ) (command is modal)
        /// G0 X10 Y-5 F100
        /// </summary>
        /// <param name="x">x position</param>
        /// <param name="y">y position</param>
        /// <param name="z">z position</param>
        /// <param name="speed">feed rate</param>
        /// <returns></returns>
        public static String move(float x, float y, float z, int speed)
        {
            return String.Format("G0 X%.3f Y%.3f Z%.3f F%d", x, y, z, speed);
        }

        /// <summary>
        /// Move to the given coordinates. To the contrary of G1, if there is a tool
        /// it will most of the time be off during this kind of move. This is a
        /// "go to" move rather than a "do while going to" move.
        /// </summary>
        /// <param name="axis">2 letters, xy, yx, zx, xz, zy, yz, etc.</param>
        /// <param name="pos1">position for the first axis letter</param>
        /// <param name="pos2">position for the second axis letter</param>
        /// <param name="speed">feed rate</param>
        /// <returns></returns>
        public static String move2d(String axis, float pos1, float pos2, int speed)
        {
            char a1 = Char.ToUpper(axis[0]);
            char a2 = Char.ToUpper(axis[1]);
            return String.Format("G0 %s%.3f %s%.3f F%d", a1, pos1, a2, pos2, speed);
        }

        /// <summary>
        /// Move to the given coordinates. To the contrary of G1, if there is a tool
        /// it will most of the time be off during this kind of move. This is a
        /// "go to" move rather than a "do while going to" move.
        /// </summary>
        /// <param name="axis">a letter representing x, y, or z axis</param>
        /// <param name="pos">position for the given axis letter</param>
        /// <param name="speed">feed rate</param>
        /// <returns></returns>
        public static String move1d(char axis, float pos, int speed)
        {
            axis = Char.ToUpper(axis);
            return String.Format("G0 %s%.3f F%d", axis, pos, speed);
        }

        /// <summary>
        /// G1
        /// Move to the given coordinates. Takes the
        /// same F parameter as G0.
        /// </summary>
        /// <param name="x">x position</param>
        /// <param name="y">y position</param>
        /// <param name="z">z position</param>
        /// <param name="speed">feed rate</param>
        /// <returns></returns>
        public static String absMove(float x, float y, float z, int speed)
        {
            return String.Format("G1 X%.3f Y%.3f Z%.3f F%d", x, y, z, speed);
        }

        /// <summary>
        /// G1
        /// Move to the given coordinates. Takes the
        /// same F parameter as G0.
        /// G1 X20 Y-2.3 F200
        /// </summary>
        /// <param name="axis">2 letters, xy, yx, zx, xz, zy, yz, etc.</param>
        /// <param name="pos1">position for the first axis letter</param>
        /// <param name="pos2">position for the second axis letter</param>
        /// <param name="speed">feed rate</param>
        /// <returns></returns>
        public static String absMove2d(String axis, float pos1, float pos2, int speed)
        {
            char a1 = Char.ToUpper(axis[0]);
            char a2 = Char.ToUpper(axis[1]);
            return String.Format("G1 %s%.3f %s%.3f F%d", a1, pos1, a2, pos2, speed);
        }

        /// <summary>
        /// G1
        /// Move to the given coordinates. Takes the
        /// same F parameter as G0.
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="pos">position for the given axis letter</param>
        /// <param name="speed">feed rate</param>
        /// <returns></returns>
        public static String absMove1d(char axis, float pos, int speed)
        {
            axis = Char.ToUpper(axis);
            return String.Format("G1 %s%.3f F%d", axis, pos, speed);
        }

        /**
          G2
        * Clockwise circular motion : go to point with coordinates XYZ while
        * rotating around point with relative coordinates IJ (command is not modal)
          G2 X10 J5
        * 
          G3
        * Counter-clockwise motion : see above (command is not modal)
          G3 Y5 X10 I2
        * 
          G4
        * Dwell S<seconds> or P<milliseconds>
          G4 P1000
        */

        /// <summary>
        /// Do firmware extruder retract
        /// G10
        /// </summary>
        /// <returns></returns>
        public static String extruderRetract()
        {
            return "G10";
        }

        /// <summary>
        /// Do firmware extruder un-retract
        /// G11
        /// </summary>
        /// <returns></returns>
        public static String extruderExtend()
        {
            return "G11";
        }

        /**
          G17
        * Select XYZ plane (command is modal)
          G17
        * 
          G18
        * Select XZY plane (command is modal)
          G18
        * 
          G19
        * Select YZX plane (command is modal)
          G19
        */

        /// <summary>
        /// passed coordinates will be considered as Inches
        /// G20
        /// </summary>
        /// <returns></returns>
        public static String inchMode()
        {
            return "G20";
        }

        /// <summary>
        /// Sets the device to millimeter mode.  All coordinates will be interpreted
        /// as millimeters
        /// G21
        /// </summary>
        /// <returns></returns>
        public static String millimeterMode()
        {
            return "G21";
        }

        /// <summary>
        /// Probes down in the z direction at the current xy until probe triggers
        /// or reaches zero at the current machines feed rate.
        /// G30 - G30 F100
        /// </summary>
        /// <returns></returns>
        public static String zProbe()
        {
            return zProbe(-1);
        }

        /// <summary>
        /// Probes down in the z direction at the current xy until probe triggers
        /// or reaches zero.
        /// </summary>
        /// <param name="speed">Feed Rate, -1 leaves off feed rate option</param>
        /// <returns></returns>
        public static String zProbe(int speed)
        {
            String cmd = "G30";
            if (speed > -1)
                cmd += String.Format(" F%d", speed);
            return cmd;
        }

        /**
          G32
        * Uses Z probe to calibrate delta endstops and arm radius, use R parameter
        * to select only arm radius calibration and E to select only endstop
        * calibration. I to set target precision, J to set probe_radius, K to keep
        * current endstop trim settings
          G32 - G32 R - G32 E - G32 EK - G32 I0.02
        */

        /// <summary>
        /// home all axis at the same
        /// </summary>
        /// <returns></returns>
        public static String homeAxis()
        {
            return homeAxis("G28");
        }

        /// <summary>
        /// Home The given axis
        /// </summary>
        /// <param name="axis"></param>
        /// <returns></returns>
        public static String homeAxis(String axis)
        {
            String cmd = "G28";
            if (axis != null && axis.Length > 0)
                cmd += " " + axis;
            return cmd;
        }

        /// <summary>
        /// Sets the device to Absolute position mode.
        /// G90
        /// </summary>
        /// <returns></returns>
        public static String setAbsoluteMode()
        {
            return "G90";
        }

        /// <summary>
        /// Sets the device to Relative position mode.
        /// G91
        /// </summary>
        /// <returns></returns>
        public static String setRelativeMode()
        {
            return "G91";
        }

        /// <summary>
        /// Set current position to specified coordinates
        /// G92
        /// G92 X0 Y0 Z0
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public static String setCoords(float x, float y, float z)
        {
            String cmd = "G92 X%d Y%d Z%d";
            cmd = String.Format(cmd, x, y, z);
            return cmd;
        }

        /**
            M-Code	Description	Example
            M17	Enable stepper motors	M17
            M18	Disable stepper motors	M18
            M24	Start or resume SD card print	M24
            M25	Pause SD card print	M25
            M82	Set absolute mode for extruder only	M82
            M83	Set relative mode for extruder only	M83
            M84	Disable steppers	M84
            M92	Set axis steps per mm	M92 E200
         */

        /// <summary>
        /// M104	Set Extruder Temperature - S<temperature>	M104 S190
        /// </summary>
        /// <param name="temp"></param>
        /// <returns></returns>
        public static String setExtruderTemp(int temp)
        {
            String cmd = "M104 S%d";
            cmd = String.Format(cmd, temp);
            return cmd;
        }

        /// <summary>
        /// M105	Read current temp	M105
        /// </summary>
        /// <returns></returns>
        public static String readCurrentTemp()
        {
            String cmd = "M105";
            return cmd;
        }

        /*
            M109	Set Extruder Temperature and Wait - S<temperature>	M109 S190
            M112	Halt all operations, turn off heaters, go into Halt state	
        *    M114	Show current position of all axes, XYZ will be the last requested position, whereas ABC is actual current position of the actuators	M114
            M117	Display message on LCD, blank message will clear it	M117 hello world or M117
        *    M119	Show limit switch status	M119
            M140	Set Bed Temperature - S<temperature>	M140 S55
            M190	Set Bed Temperature and Wait - S<temperature>	M190 S55
            M200	Set E units for volumetric extrusion - D<filament diameter> set to 0 to disable volumetric extrusion	M200 D3.0
            M203	Set maximum feedrate your machine can sustain <mm/sec>	M203 X100 Y100 Z100 E10
            M204	S<acceleration> Set acceleration in mm/sec^2 Z<acceleration> NB Z only applies to Z only moves E<nnn> Set extruder only move acceleration	M204 S1000 Z100 E500
            M205	X<junction deviation> S<minimum planner speed>	M205 X0.05 S30.0 edge only
            M206	Set homing offsets	M206 X10 Y3 Z0.5
        *    M207	set retract length S[positive mm] F[feedrate mm/min] Z[additional zlift/hop] Q[zlift feedrate mm/min]	M207 S4 F30 Z1
        *    M208	set retract recover length S[positive mm surplus to the M207 S*] F[feedrate mm/min]	M208 S0 F8
            M220	S<factor in percent>- set speed factor override percentage	M220 S50
            M221	S<flow rate factor in percent>- set flow rate factor override percentage for current extruder	M221 S50
        *    M301	Edit temperature control PID parameters	M301 S0 P30 I10 D10
        *    M303	Begin PID auto-tune cycle E<hotendid> S<temperature>	M303 E0 S185 - Tune extruder - M303 E1 S100 - Tune printbed -
        *    M304	Abort PID auto-tuning	M304
            M306	Set homing offsets based on current position, subtracts current position from homing offset for specified axis	M306 Z0
        *    M400	Wait for the queue to be empty before answering "OK"	M400
            M500	Save some volatile settings to an override file	M500
            M501	load config-override file optionally specifying the extension	M501 - loads config-override, M501 test1 - loads config-override.test1
            M502	Delete the override file, reverting to config settings at next reset	M502
            M503	Display overridden settings if any	M503
            M504	Save the settings to an override file with specified extension	M504 test1 - saves to config-override.test1 edge only
            M665	set arm solution specific settings: Delta - L<arm length> R<arm radius> Z<max height>	M665 L341.0 R350 Z430
            M666	On a delta sets trim values for the endstops. (Positive values will crash the endstops)	M666 X-0.1 Y-0.2 Z-0.3
            M907	Set Current control for each axis	M907 X1.0 Y1.0 Z1.0 E1.5
        *    M999	reset from a halted state caused by limit switch, M112 or kill switch
         */
    }
}

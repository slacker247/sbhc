using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoothieInterface
{
    public class Smoothieboard
    {
        protected const String END = "\r\n";

        public static String getCmd()
        {
            String cmd = "";
            return cmd;
        }

        //version
        public static String getVersion()
        {
            return "version" + END;
        }

        /// <summary>
        /// Returns information about RAM usage
        /// mem [-v]
        /// </summary>
        /// <param name="verbose"></param>
        /// <returns></returns>
        public static String getMem(bool verbose)
        {
            String cmd = "mem";
            if(verbose)
            {
                cmd += " -v";
            }
            cmd += END;
            return cmd;
        }

        /// <summary>
        /// List the files in the current folder ( if no folder parameter is passed ) or list them in the folder passed as a parameter ( can be absolute or relative ).
        ///
        /// The -s parameter will also return the file sizes.
        /// ls [-s] [folder]
        /// </summary>
        /// <returns></returns>
        public static String getDirListing(String path = "", bool showSizes = false)
        {
            String cmd = "ls";
            if(showSizes)
            {
                cmd += " -s";
            }

            if(path.Length > 0)
            {
                cmd += " " + path;
            }
            cmd += END;
            return cmd;
        }

        /// <summary>
        /// Change the current folder to the folder passed as a parameter ( can be absolute or relative ).
        /// cd folder
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static String cdFolder(String path)
        {
            String cmd = "cd";
            if(path.Length > 0)
            {
                cmd += " " + path;
            }
            cmd += END;
            return cmd;
        }

        /// <summary>
        /// Shows the current folder
        /// pwd
        /// </summary>
        /// <returns></returns>
        public static String getCurrentPath()
        {
            return "pwd" + END;
        }

        /// <summary>
        /// Outputs the content of the file given as a parameter to the standard output ( limited to number of limit lines if that parameter is passed ).
        /// cat file [limit]
        /// </summary>
        /// <param name="pathFileName">the full path and file name.</param>
        /// <param name="limit">The number of lines to show.</param>
        /// <returns></returns>
        public static String showFileContents(String pathFileName, int limit = -1)
        {
            String cmd = "cat";
            if(pathFileName.Length > 0)
            {
                cmd += " " + pathFileName;
            }
            if(limit > -1)
            {
                cmd += " " + limit;
            }
            cmd += END;
            return cmd;
        }
        /// <summary>
        /// Removes a file
        /// rm file
        /// </summary>
        /// <param name="pathFileName">the full path and file name.</param>
        /// <returns></returns>
        public static String deleteFile(String pathFileName)
        {
            String cmd = "rm";
            if(pathFileName.Length > 0)
            {
                cmd += " " + pathFileName;
            }
            cmd += END;
            return cmd;
        }
        //remount
        public static String remount()
        {
            throw new NotImplementedException("Unknown Command");
        }

        /// <summary>
        /// Executes a file line by line as if each line were received on the serial console, and sends any output to the standard output.
        /// appending -v will print the commands executed to the console.
        /// play file [-v]
        /// </summary>
        /// <param name="pathFileName">the full path and file name.</param>
        /// <param name="verbose"></param>
        /// <returns></returns>
        public static String playFile(String pathFileName, bool verbose = false)
        {
            String cmd = "play";
            if(pathFileName.Length > 0)
            {
                cmd += " " + pathFileName;
            }
            if(verbose)
            {
                cmd += " -v";
            }
            cmd += END;
            return cmd;
        }

        /// <summary>
        /// Displays the current status of execution of the play command
        /// progress - shows progress of current play
        /// </summary>
        /// <returns></returns>
        public static String progress()
        {
            String cmd = "progress";
            cmd += END;
            return cmd;
        }

        /// <summary>
        /// Stops an execution of play
        /// abort - abort currently playing file
        /// </summary>
        /// <returns></returns>
        public static String abort()
        {
            String cmd = "abort";
            cmd += END;
            return cmd;
        }

        /// <summary>
        /// Same as pushing the reset button on the smoothie board
        /// reset - reset smoothie
        /// </summary>
        /// <returns></returns>
        public static String reset()
        {
            String cmd = "reset";
            cmd += END;
            return cmd;
        }

        //dfu - enter dfu boot loader
        public static String dfu()
        {
            throw new NotImplementedException("Command not allowed!");
        }

        //break - break into debugger
        public static String breakID()
        {
            throw new NotImplementedException("Command not allowed!");
        }

        //config-get []
        /// <summary>
        /// The config module is in charge of storing and retrieving configuration values ( in/from the config file,
        /// see Configuring Smoothie ).  It also provides a few commands to manipulate those values.
        /// </summary>
        /// <param name="configParam">This parameter selects which value should be read.</param>
        /// <param name="configSource">This optional parameter selects where to read the value from. Valid sources
        /// are 'local' and 'sd'. Leaving this parameter out will read the current live settings in use.</param>
        /// <returns></returns>
        public static String getConfig(String configParam, String configSource = "")
        {
            String cmd = "config-get";
            if(configSource.Length > 0)
            {
                cmd += " " + configSource;
            }
            if(configParam.Length > 0)
            {
                cmd += " " + configParam;
            }
            cmd += END;
            return cmd;
        }

        //config-set []
        /// <summary>
        /// Changes the value of this configuration setting to the value passed as a parameter.
        /// Note: This command cannot currently "insert" characters, and just replaces ones that
        /// are already present. So if the new value has a length that would require inserting
        /// characters not to go over the end of the line, it will be refused. This is why all
        /// the lines in your config file must have extra whitespace ( which are very useful to
        /// get nicely formated comment columns, see Configuring Smoothie ).
        /// </summary>
        /// <param name="configParam">This parameter selects which value should be set.</param>
        /// <param name="configValue">The value to write.</param>
        /// <param name="configSource">This parameter selects where to write the value to.
        /// Valid sources are 'firm' and 'sd'.</param>
        /// <returns></returns>
        public static String setConfig(String configParam, String configValue, String configSource = "")
        {
            String cmd = "config-set";
            if(configSource.Length > 0)
            {
                cmd += " " + configSource;
            }
            if(configParam.Length > 0)
            {
                cmd += " " + configParam;
            }
            if(configValue.Length > 0)
            {
                cmd += " " + configValue;
            }
            cmd += END;
            return cmd;
        }
        //get temp [bed|hotend]
        public enum TEMP { BED, HOTEND};
        public static String getTemp(TEMP t)
        {
            String cmd = "get temp";
            if(t == TEMP.BED)
            {
                cmd += " bed";
            }
            if(t == TEMP.HOTEND)
            {
                cmd += " hotend";
            }
            cmd += END;
            return cmd;
        }
        //set_temp bed|hotend 185
        public static String setTemp(TEMP t, int value)
        {
            String cmd = "set_temp";
            if(t == TEMP.BED)
            {
                cmd += " bed";
            }
            if(t == TEMP.HOTEND)
            {
                cmd += " hotend";
            }
            cmd += " " + value;
            cmd += END;
            return cmd;
        }
        //get pos
        public static String getPos()
        {
            String cmd = "get pos";
            cmd += END;
            return cmd;
        }
        //net
        public static String getNet()
        {
            String cmd = "net";
            cmd += END;
            return cmd;
        }
        //load [file] - loads a configuration override file from soecified name or config-override
        public static String loadConfig(String pathFileName = "")
        {
            String cmd = "load";
            if(pathFileName.Length > 0)
            {
                cmd += " " + pathFileName;
            }
            cmd += END;
            return cmd;
        }
        //save [file] - saves a configuration override file as specified filename or as config-override
        public static String saveConfig(String pathFileName = "")
        {
            String cmd = "save";
            if (pathFileName.Length > 0)
            {
                cmd += " " + pathFileName;
            }
            cmd += END;
            return cmd;
        }
    }
}

/*
 *   Developer : Matt Smith (matt@matt40k.co.uk)
 *   All code (c) Matthew Smith all rights reserved
 * 
 *   This software is released under Microsoft Reciprocal License (MS-RL).
 *   The license and further copyright text can be found in the file
 *   LICENSE.TXT at the root directory of the distribution.
 */

using System;
using System.IO;
using System.Windows.Forms;

namespace Matt40k.Spelling
{
    public class Log
    {
        private string logPath = @"c:\programdata\";
        private string logName = Application.ProductName + "_log.txt";
        private string logDateFormat = "yyyy-MM-dd HH:mm:ss";

        public void Message(string message)
        {
            using (StreamWriter file = new StreamWriter(GetLogFilePath, true))
            {
                file.Write(DateTime.Now.ToString(logDateFormat) + "|" + GetUser + "|" + message);
            }
        }

        private string GetLogFilePath
        {
            get { return Path.Combine(logPath, logName); }
        }

        private string GetUser
        {
            get { return Environment.UserName; }
        }
    }
}

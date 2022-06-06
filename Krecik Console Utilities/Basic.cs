﻿/*
 *  KCU -- Krecik C[#]onsole Utilities
 *      (name subject to change)
 *      
 *      a library for some console magic we want to separate from main code
 */
using System.Text;

namespace KCU
{
    public partial class ConsoleToolkit
    {
        /// <summary>
        /// ClearLine -- write whitespaces for full (or not) console row
        /// </summary>
        /// <param name="fromBeginning">should we start at beginning of line? (left: 0) default: true</param>
        /// <param name="goBackToStart">should the cursor go back to where we started? default: true</param>
        /// <param name="offsetStart">where should we start in line (from left)</param>
        /// <param name="offsetStop">where should we stop? (from right)</param>
        public static void ClearLine(bool fromBeginning = true, bool goBackToStart = true, int offsetStart = 0, int offsetStop = 0)
        {
            if (fromBeginning) Console.SetCursorPosition(0, Console.CursorTop);
            int x = Console.CursorLeft, y = Console.CursorTop;
            Console.SetCursorPosition(x+offsetStart, y);
            int maxWidth = Console.BufferWidth - x - offsetStop;
            StringBuilder sb = new StringBuilder();
            sb.Append(Characters.whitespace, maxWidth);
            Console.Write(sb.ToString());
            if (goBackToStart) Console.SetCursorPosition(x, y);
        }
    }
}
/*
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
            int maxWidth = Console.WindowWidth - x - offsetStop;
            Console.SetCursorPosition(x+offsetStart, y);
            StringBuilder sb = new StringBuilder();
            sb.Append(Characters.whitespace, maxWidth);
            Console.Write(sb.ToString());
            if (goBackToStart) Console.SetCursorPosition(x, y);
        }

        /// <summary>
        /// WriteAt - Console.Write() but at given position (basically a wrapper)
        /// </summary>
        /// <param name="text">text to write</param>
        /// <param name="returnToPos">should the cursor go back to where it was before running this method?</param>
        public static void WriteAt(string text, int left, int top, bool returnToPos = false)
        {
            int prevleft = Console.CursorLeft,
                prevtop  = Console.CursorTop;

            Console.SetCursorPosition(left, top);
            Console.Write(text);

            if (returnToPos) Console.SetCursorPosition(prevleft, prevtop);
        }

        public static void WriteAt(string text, int left, int top, ConsoleColor color, bool returnToPos = false)
        {
            Console.ForegroundColor = color;
            WriteAt(text, left, top, returnToPos);
        }
    }
}
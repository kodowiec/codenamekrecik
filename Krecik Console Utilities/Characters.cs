namespace KCU
{
    public class Characters
    {
        public static readonly char player = '☺';
        public static readonly char whitespace = ' ';

        /// <summary>
        ///<para>╔══╦══╗</para>
        ///<para>╠══╬══╣</para>
        ///<para>╚══╩══╝</para>
        /// </summary>
        public class BoxDrawing
        {
            /// <summary>
            ///<para>╔ ╗</para>
            ///<para>╚ ╝</para>
            /// </summary>
            public class Corners
            {
                public static readonly char TopLeft = '╔',
                                            TopRight = '╗',
                                            BottomLeft = '╚',
                                            BottomRight = '╝';
            }

            /// <summary>
            ///<para> ══╦══ </para>
            ///<para> ══╩══ </para>
            ///<para>╠══╬══╣</para>
            /// </summary>
            public class Walls
            {
            //  ╔══╦══╗
            //  ║  ║  ║ 
            //  ╠══╬══╣
            //  ║  ║  ║
            //  ╚══╩══╝
                public static readonly char Vertical = '║',
                                            VerticalRightEntrance = '╠',
                                            VerticalLeftEntrance = '╣',
                                            VerticalTwoEntrances = '╬';

                public static readonly char Horizontal = '═',
                                            HorizontalBottomEntrance = '╦',
                                            HorizontalTopEntrance = '╩';
            }
        }
    }
}

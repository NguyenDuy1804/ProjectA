using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_project
{
    class DTOSeat
    {
        public static int WIDTH = 68;
        public static int HEIGHT = 66;
        private int row;
        private int column;
        private Point position;
        private bool confirm;

        public int Row { get => row; set => row = value; }
        public int Column { get => column; set => column = value; }
        public Point Position { get => position; set => position = value; }
        public bool Confirm { get => confirm; set => confirm = value; }

        public DTOSeat()
        {

        }
        public DTOSeat(int row, int column, Point position, bool confirm)
        {
            this.Row = row;
            this.Column = column;
            this.Position = position;
            this.Confirm = confirm;
        }
    }
}

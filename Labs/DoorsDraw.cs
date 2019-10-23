using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class DoorsDraw : IDoors
    {
        public void DrawElipseDoors(Doors doors, Graphics g, float x, float y)
        {
            Brush brBlack = new SolidBrush(Color.Black);
            switch (doors)
            {
                case Doors.Five:
                    g.FillRectangle(brBlack, x + 67, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 54, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 41, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 28, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 15, y + 25, 8, 10);
                    break;
                case Doors.Four:
                    g.FillRectangle(brBlack, x + 67, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 54, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 28, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 15, y + 25, 8, 10);
                    break;
                case Doors.Three:
                    g.FillRectangle(brBlack, x + 54, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 41, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 28, y + 25, 8, 10);
                    break;
            }
        }

        public void DrawRectDoors(Doors doors, Graphics g, float x, float y)
        {
            Brush brBlack = new SolidBrush(Color.Black);
            switch (doors)
            {
                case Doors.Five:
                    g.FillRectangle(brBlack, x + 67, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 54, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 41, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 28, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 15, y + 25, 8, 10);
                    break;
                case Doors.Four:
                    g.FillRectangle(brBlack, x + 67, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 54, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 28, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 15, y + 25, 8, 10);
                    break;
                case Doors.Three:
                    g.FillRectangle(brBlack, x + 54, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 41, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 28, y + 25, 8, 10);
                    break;
            }
        }

        public void DrawTriangleDoors(Doors doors, Graphics g, float x, float y)
        {
            Brush brBlack = new SolidBrush(Color.Black);
            switch (doors)
            {
                case Doors.Five:
                    g.FillRectangle(brBlack, x + 67, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 54, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 41, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 28, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 15, y + 25, 8, 10);
                    break;
                case Doors.Four:
                    g.FillRectangle(brBlack, x + 67, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 54, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 28, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 15, y + 25, 8, 10);
                    break;
                case Doors.Three:
                    g.FillRectangle(brBlack, x + 54, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 41, y + 25, 8, 10);
                    g.FillRectangle(brBlack, x + 28, y + 25, 8, 10);
                    break;
            }
        }
    }
}

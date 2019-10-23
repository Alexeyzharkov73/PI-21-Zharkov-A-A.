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
                    g.FillEllipse(brBlack, x + 67, y + 25, 8, 10);
                    g.FillEllipse(brBlack, x + 54, y + 25, 8, 10);
                    g.FillEllipse(brBlack, x + 41, y + 25, 8, 10);
                    g.FillEllipse(brBlack, x + 28, y + 25, 8, 10);
                    g.FillEllipse(brBlack, x + 15, y + 25, 8, 10);
                    break;
                case Doors.Four:
                    g.FillEllipse(brBlack, x + 67, y + 25, 8, 10);
                    g.FillEllipse(brBlack, x + 54, y + 25, 8, 10);
                    g.FillEllipse(brBlack, x + 28, y + 25, 8, 10);
                    g.FillEllipse(brBlack, x + 15, y + 25, 8, 10);
                    break;
                case Doors.Three:
                    g.FillEllipse(brBlack, x + 54, y + 25, 8, 10);
                    g.FillEllipse(brBlack, x + 41, y + 25, 8, 10);
                    g.FillEllipse(brBlack, x + 28, y + 25, 8, 10);
                    break;
            }
        }

        public void DrawTriangleDoors(Doors doors, Graphics g, float x, float y)
        {
            Brush brBlack = new SolidBrush(Color.Black);
            switch (doors)
            {
                case Doors.Five:
                    Point point1 = new Point((int)x + 71, (int)y + 25);
                    Point point2 = new Point((int)x + 67, (int)y + 35);
                    Point point3 = new Point((int)x + 75, (int)y + 35);
                    Point[] curvePoints = {
                             point1,
                             point2,
                             point3
                         };
                    g.FillPolygon(brBlack, curvePoints);

                    point1 = new Point((int)x + 58, (int)y + 25);
                    point2 = new Point((int)x + 54, (int)y + 35);
                    point3 = new Point((int)x + 62, (int)y + 35);
                    Point[] curvePoints1 = {
                             point1,
                             point2,
                             point3
                         };
                    g.FillPolygon(brBlack, curvePoints1);

                    point1 = new Point((int)x + 45, (int)y + 25);
                    point2 = new Point((int)x + 41, (int)y + 35);
                    point3 = new Point((int)x + 49, (int)y + 35);
                    Point[] curvePoints2 = {
                             point1,
                             point2,
                             point3
                         };
                    g.FillPolygon(brBlack, curvePoints2);

                    point1 = new Point((int)x + 32, (int)y + 25);
                    point2 = new Point((int)x + 28, (int)y + 35);
                    point3 = new Point((int)x + 36, (int)y + 35);
                    Point[] curvePoints3 = {
                             point1,
                             point2,
                             point3
                         };
                    g.FillPolygon(brBlack, curvePoints3);

                    point1 = new Point((int)x + 19, (int)y + 25);
                    point2 = new Point((int)x + 15, (int)y + 35);
                    point3 = new Point((int)x + 23, (int)y + 35);
                    Point[] curvePoints4 = {
                             point1,
                             point2,
                             point3
                         };
                    g.FillPolygon(brBlack, curvePoints4);
                    break;
                case Doors.Four:
                    point1 = new Point((int)x + 71, (int)y + 25);
                    point2 = new Point((int)x + 67, (int)y + 35);
                    point3 = new Point((int)x + 75, (int)y + 35);
                    Point[] curvePoints8 = {
                             point1,
                             point2,
                             point3
                         };
                    g.FillPolygon(brBlack, curvePoints8);

                    point1 = new Point((int)x + 58, (int)y + 25);
                    point2 = new Point((int)x + 54, (int)y + 35);
                    point3 = new Point((int)x + 62, (int)y + 35);
                    Point[] curvePoints9 = {
                             point1,
                             point2,
                             point3
                         };
                    g.FillPolygon(brBlack, curvePoints9);

                    point1 = new Point((int)x + 32, (int)y + 25);
                    point2 = new Point((int)x + 28, (int)y + 35);
                    point3 = new Point((int)x + 36, (int)y + 35);
                    Point[] curvePoints10 = {
                             point1,
                             point2,
                             point3
                         };
                    g.FillPolygon(brBlack, curvePoints10);

                    point1 = new Point((int)x + 19, (int)y + 25);
                    point2 = new Point((int)x + 15, (int)y + 35);
                    point3 = new Point((int)x + 23, (int)y + 35);
                    Point[] curvePoints11 = {
                             point1,
                             point2,
                             point3
                         };
                    g.FillPolygon(brBlack, curvePoints11);
                    break;
                case Doors.Three:
                    point1 = new Point((int)x + 58, (int)y + 25);
                    point2 = new Point((int)x + 54, (int)y + 35);
                    point3 = new Point((int)x + 62, (int)y + 35);
                    Point[] curvePoints5 = {
                             point1,
                             point2,
                             point3
                         };
                    g.FillPolygon(brBlack, curvePoints5);

                    point1 = new Point((int)x + 45, (int)y + 25);
                    point2 = new Point((int)x + 41, (int)y + 35);
                    point3 = new Point((int)x + 49, (int)y + 35);
                    Point[] curvePoints6 = {
                             point1,
                             point2,
                             point3
                         };
                    g.FillPolygon(brBlack, curvePoints6);

                    point1 = new Point((int)x + 32, (int)y + 25);
                    point2 = new Point((int)x + 28, (int)y + 35);
                    point3 = new Point((int)x + 36, (int)y + 35);
                    Point[] curvePoints7 = {
                             point1,
                             point2,
                             point3
                         };
                    g.FillPolygon(brBlack, curvePoints7);
                    break;
            }
        }
    }
}
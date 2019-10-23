using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    public class BaseBus : Vehicle
    {
        protected const int busWidth = 100;

        protected const int busHeight = 60;

        public BaseBus(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - busWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - busHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawBus(Graphics g, DoorsDraw draw)
        {
            Pen pen = new Pen(Color.Black);

            Brush br = new SolidBrush(this.MainColor); // кузов 
            g.FillRectangle(br, _startPosX, _startPosY + 15, 90, 30);
            g.DrawRectangle(pen, _startPosX, _startPosY + 15, 90, 30);
            g.FillRectangle(br, _startPosX + 90, _startPosY + 30, 13, 15);


            Brush brBrown = new SolidBrush(Color.Brown); // колеса
            g.FillEllipse(brBrown, _startPosX, _startPosY + 35, 25, 20);
            g.FillEllipse(brBrown, _startPosX + 65, _startPosY + 35, 25, 20);

            Brush brBlue = new SolidBrush(Color.Blue); // окна
            g.FillRectangle(brBlue, _startPosX, _startPosY + 17, 10, 10);
            g.FillRectangle(brBlue, _startPosX + 20, _startPosY + 17, 10, 10);
            g.FillRectangle(brBlue, _startPosX + 40, _startPosY + 17, 10, 10);
            g.FillRectangle(brBlue, _startPosX + 60, _startPosY + 17, 10, 10);
            g.FillRectangle(brBlue, _startPosX + 80, _startPosY + 17, 10, 10);

            draw.DrawTriangleDoors(Doors.Three, g, _startPosX, _startPosY); //Двери

        }

        public static Boolean operator >=(BaseBus baseBus, BaseBus secondBus)
        {
            return baseBus.MaxSpeed >= secondBus.MaxSpeed;
        }

        public static Boolean operator <=(BaseBus baseBus, BaseBus secondBus)
        {
            return baseBus.MaxSpeed <= secondBus.MaxSpeed;
        }
    }
}

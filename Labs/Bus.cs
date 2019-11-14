using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Bus
    {
        private float _startPosX;

        private float _startPosY;

        private int _pictureWidth;

        private int _pictureHeight;

        private const int carWidth = 100;

        private const int carHeight = 60;

        private Doors DoorsCount;

        public int MaxSpeed { private set; get; }

        public float Weight { private set; get; }

        public Color MainColor { private set; get; }

        public Color DopColor { private set; get; }

        public bool IsBigBus { private set; get; }

        public bool IsDoorsDraw { private set; get; }

        public Bus(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool doorsDraw, bool isBigBus, Doors doorsCount)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            IsDoorsDraw = doorsDraw;
            DoorsCount = doorsCount;
            IsBigBus = isBigBus;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
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
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawBus(Graphics g)
        {
            if(this.IsBigBus)
            {
                Pen pen = new Pen(Color.Black);

                Brush brRed = new SolidBrush(Color.Red);
                g.FillRectangle(brRed, _startPosX, _startPosY, 75, 15);
                g.FillRectangle(brRed, _startPosX, _startPosY + 15, 90, 20);
                g.DrawRectangle(pen, _startPosX, _startPosY, 75, 15);
                g.DrawRectangle(pen, _startPosX, _startPosY + 15, 90, 20);
                Brush brBlue = new SolidBrush(Color.Blue);
                g.FillRectangle(brBlue, _startPosX, _startPosY + 8, 10, 9);
                g.FillRectangle(brBlue, _startPosX + 20, _startPosY + 8, 10, 9);
                g.FillRectangle(brBlue, _startPosX + 40, _startPosY + 8, 10, 9);
                g.FillRectangle(brBlue, _startPosX + 60, _startPosY + 8, 10, 9);

                Brush brBrown = new SolidBrush(Color.Brown);
                g.FillEllipse(brBrown, _startPosX, _startPosY + 30, 25, 20);
                g.FillEllipse(brBrown, _startPosX + 70, _startPosY + 30, 25, 20);

            }
            else
            {
                Pen pen = new Pen(Color.Black);

                Brush br = new SolidBrush(this.MainColor); // кузов 
                g.FillRectangle(br, _startPosX, _startPosY + 15, 90, 30);
                g.DrawRectangle(pen, _startPosX, _startPosY + 15, 90, 30);
                g.FillRectangle(br, _startPosX + 90, _startPosY + 30, 13, 15);

                Brush brBrown = new SolidBrush(Color.Brown);
                g.FillEllipse(brBrown, _startPosX, _startPosY + 40, 25, 20);
                g.FillEllipse(brBrown, _startPosX + 70, _startPosY + 40, 25, 20);
            }

            if (IsDoorsDraw)
            {
                DoorsDraw draw = new DoorsDraw(DoorsCount);
                draw.draw(g, _startPosX, _startPosY);

            }



        }
           

        
    }
}

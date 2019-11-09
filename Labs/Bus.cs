using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Bus : BaseBus
    {
        private Doors DoorsCount;

        public Color DopColor { private set; get; }

        public bool IsDoorsDraw { private set; get; }

        private int _doorsForm;

        public int DoorsForm
        {
            set
            {
                if (value > 0 && value < 4) _doorsForm = value;
            }
            get { return _doorsForm; }
        }


        public Bus(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool doorsDraw, Doors doorsCount) : base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            IsDoorsDraw = doorsDraw;
            DoorsCount = doorsCount;
            Random rnd = new Random();
            DoorsForm = rnd.Next(1, 4);
        }

        public override void DrawBus(Graphics g, DoorsDraw draw)
        {
            Pen pen = new Pen(Color.Black);

            Brush br = new SolidBrush(this.MainColor);
            g.FillRectangle(br, _startPosX, _startPosY, 75, 15);
            g.DrawRectangle(pen, _startPosX, _startPosY, 75, 15);



            g.FillRectangle(br, _startPosX + 60, _startPosY + 17, 10, 10);




            br = new SolidBrush(this.DopColor);

            g.FillRectangle(br, _startPosX, _startPosY + 15, 90, 20);
            g.DrawRectangle(pen, _startPosX, _startPosY + 15, 90, 20);

            Brush brBrown = new SolidBrush(Color.Brown);
            g.FillEllipse(brBrown, _startPosX, _startPosY + 30, 25, 20);
            g.FillEllipse(brBrown, _startPosX + 70, _startPosY + 30, 25, 20);

            if (IsDoorsDraw)
            {
                switch (this.DoorsForm)
                {
                    case 1:
                        draw.DrawRectDoors(DoorsCount, g, _startPosX, _startPosY);
                        break;
                    case 2:
                        draw.DrawTriangleDoors(DoorsCount, g, _startPosX, _startPosY);
                        break;
                    case 3:
                        draw.DrawElipseDoors(DoorsCount, g, _startPosX, _startPosY);
                        break;
                }

            }

            Brush brBlue = new SolidBrush(Color.Blue);
            g.FillRectangle(brBlue, _startPosX, _startPosY + 8, 10, 9);
            g.FillRectangle(brBlue, _startPosX + 20, _startPosY + 8, 10, 9);
            g.FillRectangle(brBlue, _startPosX + 40, _startPosY + 8, 10, 9);
            g.FillRectangle(brBlue, _startPosX + 60, _startPosY + 8, 10, 9);


        }



    }
}

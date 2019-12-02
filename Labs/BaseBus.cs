using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    public class BaseBus : Vehicle, IComparable<BaseBus>, IEquatable<BaseBus>
    {
        protected const int busWidth = 100;

        protected const int busHeight = 60;

        public BaseBus(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public BaseBus(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
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

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }

        public int CompareTo(BaseBus other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }

        public bool Equals(BaseBus other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is BaseBus busObj))
            {
                return false;
            }
            else
            {
                return Equals(busObj);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

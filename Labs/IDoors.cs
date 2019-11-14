using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    interface IDoors
    {
        void DrawRectDoors(Doors doors, Graphics g, float x, float y);
        void DrawTriangleDoors(Doors doors, Graphics g, float x, float y);
        void DrawElipseDoors(Doors doors, Graphics g, float x, float y);
    }
}

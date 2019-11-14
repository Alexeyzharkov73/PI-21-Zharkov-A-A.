using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class MultiLevelParking
    {
        List<Parking<ITransport, DoorsDraw>> parkingStages;
        private const int countPlaces = 20;

        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITransport, DoorsDraw>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<ITransport, DoorsDraw>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }        public Parking<ITransport, DoorsDraw> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }        public ITransport this[int ind, int secInd]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    if (secInd > -1 && secInd < countPlaces)
                    return parkingStages[ind] - secInd;
                }
                return null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class MultiLevelParking
    {
        List<Parking<ITransport, DoorsDraw>> parkingStages;
        private const int countPlaces = 20;
        private int PictureWidth;
        private int PictureHeight;


        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
            parkingStages = new List<Parking<ITransport, DoorsDraw>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<ITransport, DoorsDraw>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }

        public Parking<ITransport, DoorsDraw> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }

        public ITransport this[int ind, int secInd]
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


        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("CountLeveles:" + parkingStages.Count);
                foreach (var level in parkingStages)
                {
                    sw.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        try
                        {
                            var car = level[i];
                            if (car != null)
                            {
                                if (car.GetType().Name == "BaseBus")
                                {
                                    sw.Write(i + ":BaseBus:");
                                }
                                if (car.GetType().Name == "Bus")
                                {
                                    sw.Write(i + ":Bus:");
                                }
                                sw.WriteLine(car);
                            }
                        }
                        finally { }
                    }
                }
                return true;
            }
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();            }
            string buffer = "";
            using (StreamReader sr = new StreamReader(filename))
            {
                if ((buffer = sr.ReadLine()).Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(buffer.Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<Parking<ITransport, DoorsDraw>>(count);
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    throw new Exception("Неверный формат файла");
                }
                int counter = -1;
                ITransport bus = null;
                while ((buffer = sr.ReadLine()) != null)
                {
                    if (buffer == "Level")
                    {
                        counter++;
                        parkingStages.Add(new Parking<ITransport, DoorsDraw>(countPlaces, PictureWidth, PictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(buffer))
                    {
                        continue;
                    }
                    if (buffer.Split(':')[1] == "BaseBus")
                    {
                        bus = new BaseBus(buffer.Split(':')[2]);
                    }
                    else if (buffer.Split(':')[1] == "Bus")
                    {
                        bus = new Bus(buffer.Split(':')[2]);
                    }
                    parkingStages[counter][Convert.ToInt32(buffer.Split(':')[0])] = bus;
                }
            }
            return true;
        }


    }
}

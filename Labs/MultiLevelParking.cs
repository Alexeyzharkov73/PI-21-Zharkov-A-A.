using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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

        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                
                WriteToFile("CountLeveles:" + parkingStages.Count +
                Environment.NewLine, fs);
                foreach (var level in parkingStages)
                {
                    
                    WriteToFile("Level" + Environment.NewLine, fs);
                    foreach (ITransport bus in level)
                    {
                        
                        if (bus.GetType().Name == "BaseBus")
                        {
                            WriteToFile(level.GetKey + ":BaseBus:", fs);
                        }
                        if (bus.GetType().Name == "Bus")
                        {
                            WriteToFile(level.GetKey + ":Bus:", fs);
                        }
                        
                        WriteToFile(bus + Environment.NewLine, fs);
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                byte[] b = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    bufferTextFromFile += temp.GetString(b);
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("CountLeveles"))
            {
                int count = Convert.ToInt32(strs[0].Split(':')[1]);
                if (parkingStages != null)
                {
                    parkingStages.Clear();
                }
                parkingStages = new List<Parking<ITransport, DoorsDraw>>(count);
            }
            else
            {
                return false;
            }
            int counter = -1;
            ITransport bus = null;
            for (int i = 1; i < strs.Length; ++i)
            {
                if (strs[i] == "Level")
                {
                    counter++;
                    parkingStages.Add(new Parking<ITransport, DoorsDraw>(countPlaces,
                        PictureWidth, PictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }
                if (strs[i].Split(':')[1] == "BaseBus")
                {
                    bus = new BaseBus(strs[i].Split(':')[2]);
                }
                else if (strs[i].Split(':')[1] == "Bus")
                {
                    bus = new Bus(strs[i].Split(':')[2]);
                }
                parkingStages[counter][Convert.ToInt32(strs[i].Split(':')[0])] = bus;
            }
            return true;
        }
        public void Sort()
        {
            parkingStages.Sort();
        }
    }
}

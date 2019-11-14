using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs
{
    public partial class FormBusConfig : Form
    {
        ITransport bus = null;

        private event busDelegate eventAddBus;
        private void DrawBus()
        {
            if (bus != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                bus.SetPosition(5, 5, pictureBox1.Width, pictureBox1.Height);
                bus.DrawBus(gr, new DoorsDraw());
                pictureBox1.Image = bmp;
            }

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        public void AddEvent(busDelegate ev)
        {
            if (eventAddBus == null)
            {
                eventAddBus = new busDelegate(ev);
            }
            else
            {
                eventAddBus += ev;
            }
        }

        public FormBusConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGold.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
           DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBaseBus_MouseDown(object sender, MouseEventArgs e)
        {
            labelBaseBus.DoDragDrop(labelBaseBus.Text, DragDropEffects.Move |
                DragDropEffects.Copy);
        }

        private void labelBus_MouseDown(object sender, MouseEventArgs e)
        {
            labelBus.DoDragDrop(labelBus.Text, DragDropEffects.Move |
                DragDropEffects.Copy);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "BaseBus":
                    bus = new BaseBus(100, 500, Color.White);
                    break;
                case "Bus":
                    bus = new Bus(100, 500, Color.White, Color.Black, true, Doors.Five);
                    break;
            }
            DrawBus();
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (bus != null)
            {
                bus.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawBus();
            }
        }

        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (bus != null)
            {
                if (bus is Bus)
                {
                    (bus as
                   Bus).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawBus();
                }
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            eventAddBus?.Invoke(bus);
            Close();
        }
    }
}

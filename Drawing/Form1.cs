using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Form1 : Form
    {

        // Pindala  = 571 x 434

        bool Drawing = false;
        Point LastPosition;

        Pen Pliiats = new Pen(Color.Maroon, 2);
        SolidBrush Pintsel = new SolidBrush(Color.Maroon);

        Graphics G;
        Random r = new Random();

        int Laius, Korgus;

        public Form1()
        {
            InitializeComponent();

            Laius = TA_Pindala1.Width;
            Korgus = TA_Pindala1.Height;

            G = Graphics.FromHwnd(TA_Pindala1.Handle);

        }

        private void TATimer1_Tick(object sender, EventArgs e)
        {
            TATimer1.Interval = 1;

            if (TA_Automaat_CBx.Text == "Jooned")
            {
                Jooned();
            }

            else if (TA_Automaat_CBx.Text == "Tühi Ristkülik")
            {
                TuhiristKulik();
            }

            else if (TA_Automaat_CBx.Text == "Värvitud Ristkülik")
            {
                VarvitudRistkulik();
            }

            else if (TA_Automaat_CBx.Text == "Kontuuriga Ristkülik")
            {
                KontuurigaRistkulik();
            }

            else if (TA_Automaat_CBx.Text == "Ellips")
            {
                Ellips();
            }
        }

        private void TA_JoonAutomaat_Click(object sender, EventArgs e)
        {
            /*
           TA_Timer1.Enabled = !TA_Timer1.Enabled;
           if (TA_Timer.Enabled) TA.Timer1.Text = "Timer Off"; Else TA_Timer.Text = "Timer On
           */

            TATimer1.Interval = 1;

            if (TATimer1.Enabled)
            {
                TA_JoonAutomaat.Text = "Automaat Sisse";
                TATimer1.Stop();
            }
            else
            {
                TA_JoonAutomaat.Text = "Automaat Välja";
                TATimer1.Start();
            }
        }
        private void TA_Puhasta_Click(object sender, EventArgs e)
        {
            TA_Pindala1.Image = null;
        }
        private void TA_Lisa_Click(object sender, EventArgs e)
        {
            if (TA_Lisa_CBx.Text == "Joon")
            {
                Joon();
            }

            else if (TA_Lisa_CBx.Text == "Suvaline Joon")
            {
                Jooned();
            }

            else if (TA_Lisa_CBx.Text == "Tühi Ristkülik")
            {
                TuhiristKulik();
            }

            else if (TA_Lisa_CBx.Text == "Värvitud Ristkülik")
            {
                VarvitudRistkulik();
            }

            else if (TA_Lisa_CBx.Text == "Kontuuriga Ristkülik")
            {
                KontuurigaRistkulik();
            }

            else if (TA_Lisa_CBx.Text == "Ellips")
            {
                Ellips();
            }
        }

        private void KontuurigaRistkulik()
        {

            int x1, y1, x2, y2;

            x1 = r.Next(Laius);
            y1 = r.Next(Korgus);
            x2 = r.Next(Laius);
            y2 = r.Next(Korgus);

            int paksus = r.Next(1, 10);
            int varv = r.Next(54);

            int punane = r.Next(256);
            int roheline = r.Next(256);
            int sinine = r.Next(256);

            Pintsel.Color = Color.FromArgb(punane, roheline, sinine);



            G.FillRectangle(Pintsel, x1, y1, x2, y2);

            Pliiats.Width = r.Next(1, 10);
            Pliiats.Color = Color.FromArgb(punane / 3, roheline / 3, sinine / 3);
            G.DrawRectangle(Pliiats, x1, y1, x2, y2);
        }
        private void VarvitudRistkulik()
        {
            int x1, y1, x2, y2;

            x1 = r.Next(Laius);
            y1 = r.Next(Korgus);
            x2 = r.Next(Laius);
            y2 = r.Next(Korgus);

            int paksus = r.Next(1, 10);
            int varv = r.Next(54);

            int punane = r.Next(256);
            int roheline = r.Next(256);
            int sinine = r.Next(256);

            Pintsel.Color = Color.FromArgb(punane, roheline, sinine);

            G.FillRectangle(Pintsel, x1, y1, x2, y2);
        }
        private void TuhiristKulik()
        {
            int x1, y1;

            x1 = r.Next(Laius * 8 / 10);
            y1 = r.Next(Korgus * 8 / 10);

            int dx = r.Next(5, Laius - x1);
            int dy = r.Next(5, Korgus - y1);

            int punane = r.Next(256);
            int roheline = r.Next(256);
            int sinine = r.Next(256);

            Pliiats.Color = Color.FromArgb(punane, roheline, sinine);
            G.DrawRectangle(Pliiats, x1, y1, dx, dy);
        }
        private void Ellips()
        {
            int x1, y1;

            x1 = r.Next(Laius * 8 / 10);
            y1 = r.Next(Korgus * 8 / 10);

            int dx = r.Next(5, Laius - x1);
            int dy = r.Next(5, Korgus - y1);

            int punane = r.Next(256);
            int roheline = r.Next(256);
            int sinine = r.Next(256);

            Pliiats.Color = Color.FromArgb(punane, roheline, sinine);
            G.DrawEllipse(Pliiats, x1, y1, dx, dy);
        }
        private void Jooned()
        {
            int x1, y1, x2, y2;
            int paksus, varv, punane, roheline, sinine;

            x1 = r.Next(Laius);
            y1 = r.Next(Korgus);
            x2 = r.Next(Laius);
            y2 = r.Next(Korgus);

            paksus = r.Next(1, 10);
            varv = r.Next(54);

            Pliiats.Width = r.Next(1, 10);

            punane = r.Next(256);
            roheline = r.Next(256);
            sinine = r.Next(256);

            Pliiats.Color = Color.FromArgb(punane, roheline, sinine);

            G.DrawLine(Pliiats, x1, y1, x2, y2);
        }
        private void Joon()
        {
            G.DrawLine(Pliiats, 100, 200, 100, 500);
        }

        private void TA_Pindala1_MouseDown(object sender, MouseEventArgs e)
        {
            Drawing = true;
            LastPosition = new Point(e.X, e.Y);
        }
        private void TA_Pindala1_MouseMove(object sender, MouseEventArgs e)
        {
            TA_Status.Text = e.X.ToString() + ", " + e.Y.ToString();

            if (Drawing)
            {
                DrawLine(LastPosition, e.Location);
                LastPosition = e.Location;
            }
        }
        private void TA_Pindala1_MouseUp(object sender, MouseEventArgs e)
        {
            Drawing = false;
        }
        private void TA_Pindala1_MouseLeave(object sender, EventArgs e)
        {
            TA_Status.Text = "-";
        }

        private void DrawLine(Point lastPosition, Point point)
        {
            Graphics GD = TA_Pindala1.CreateGraphics();
            GD.DrawLine(Pliiats, LastPosition, point);
        }
    }
}

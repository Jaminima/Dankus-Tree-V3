using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DankusTreeV3
{
    public partial class DankusTree : Form
    {
        const int FCount = 1000;

        Image tree;

        public DankusTree()
        {
            this.DoubleBuffered = true;

            InitializeComponent();

            tree = Image.FromFile("./tree.png");

            Grp = BufferedGraphicsManager.Current.Allocate(this.CreateGraphics(),
                 new Rectangle(0, 0, this.Width, this.Height));

            for (int i = 0; i < FCount; i++)
            {
                Flakes[i] = new SnowFlake();
                Flakes[i].point = new Point(Program.rnd.Next(0, Width), Program.rnd.Next(-Height,0));
            }
        }

        SnowFlake[] Flakes = new SnowFlake[FCount];

        BufferedGraphics Grp;

        Font font = new Font(FontFamily.GenericSerif, 50);

        private void tmr_Snow_Tick(object sender, EventArgs e)
        {
            Grp.Graphics.Clear(Color.Transparent);

            DrawFlakes(false);

            Grp.Graphics.DrawImage(tree, (Width - tree.Width) / 2, (Height - tree.Height) / 4);

            TimeSpan Remaining = new DateTime(DateTime.Now.Year, 12, 25) - DateTime.Now;

            string Message = $"{(int)Remaining.TotalDays} D {Remaining.Hours} H {Remaining.Minutes} M {Remaining.Seconds} S";

            Grp.Graphics.DrawString(Message, font, new SolidBrush(Color.White), (Width - Grp.Graphics.MeasureString(Message, font).Width) / 2, Height / 5 * 4);

            DrawFlakes(true);

            Grp.Render();
        }

        private void DrawFlakes(bool InFront)
        {
            for (int i = 0; i < FCount && Flakes[i] != null; i++)
            {
                if (Flakes[i].IsBig == InFront)
                {
                    Flakes[i].X += Program.rnd.Next(-1, 2);
                    Flakes[i].Y += Flakes[i].W * Flakes[i].H / 5;

                    if (Flakes[i].Y > Height) Flakes[i].Y = 0;
                    if (Math.Abs(Flakes[i].X) > Width * 2) { Flakes[i].point = new Point(Program.rnd.Next(0, Width), 0); }

                    Grp.Graphics.FillEllipse(new SolidBrush(Color.White), Flakes[i].X, Flakes[i].Y, Flakes[i].W, Flakes[i].H);
                }
            }
        }
    }

    class SnowFlake
    {
        public int X { get { return point.X; } set { point.X = value; } }
        public int Y { get { return point.Y; } set { point.Y = value; } }

        public Point point;
        public int H = Program.rnd.Next(0, 5), W = Program.rnd.Next(0, 5);

        public bool IsBig;

        public SnowFlake()
        {
            IsBig = H * W > 10;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DankusTreeV3
{
    public partial class TreeLight : UserControl
    {
        public static Color[] Colors = new Color[] { Color.Green, Color.Red, Color.Blue, Color.White };

        public TreeLight()
        {
            InitializeComponent();
        }

        private void TreeLight_Load(object sender, EventArgs e)
        {
            tmr_Flash.Interval = Program.rnd.Next(150, 300);
        }

        private void tmr_Flash_Tick(object sender, EventArgs e)
        {
            BackColor = Colors[Program.rnd.Next(0, Colors.Length)];
        }
    }
}

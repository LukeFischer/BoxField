using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxField
{
    public partial class PauseScreen : UserControl
    {
        public static int pause;
        public PauseScreen()
        {
            InitializeComponent();
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            pause = 1;
            
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            pause = 2;
        }
    }
}

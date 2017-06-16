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
    public partial class InstructionScreen : UserControl
    {
        public InstructionScreen()
        {
            InitializeComponent();
            arrowInstructionLabel.Text = "Move with the arrow keys";
            mouseInstructionsLabel.Text = "Left click on mouse to shoot bullets";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainMenu ms = new MainMenu();
            f.Controls.Add(ms);
        }
    }
}

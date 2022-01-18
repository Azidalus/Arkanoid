using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Арканоид
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }


        private void start_button_Click(object sender, EventArgs e)
        {
            GameForm game = new GameForm();
            game.Show();           
        }
    }
}

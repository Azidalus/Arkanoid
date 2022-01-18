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
    public partial class WinOrLoseForm : Form
    {
        // флаги
        bool f1 = false;
        bool f2 = false;

        public WinOrLoseForm()
        {
            InitializeComponent();
        }      

        // обработчик событий кнопки "играть снова"
        private void PlayAgain_Click(object sender, EventArgs e)
        {
            f1 = true;
            Close();            
        }

        // обработчик событий кнопки "в меню"
        private void GoToMenu_Click(object sender, EventArgs e)
        {
            f2 = true;
            Close();          
        }

        // обработчик события закрытия окна
        private void WinOrLoseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // играть снова
            if (f1)
            {               
                GameForm game = new GameForm();
                game.Show();
            }

            // выйти в меню
            if (f2)
            {
                Form menu = Application.OpenForms[0];
                menu.Show();
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace GetThePolynom
{
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
        }

        private void btToMenu_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.Show();
            this.Hide();
        }
    }
}

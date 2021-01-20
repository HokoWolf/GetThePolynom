using System;
using System.Windows.Forms;

namespace GetThePolynom
{
    public partial class SpeedChoice : Form
    {
        Menu menu;
        SpeedByGraphic speedByGraphic;
        ValuesForSpeed valuesForSpeed;

        public SpeedChoice(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void SpeedChoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void btGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void btToByGraphic_Click(object sender, EventArgs e)
        {
            speedByGraphic = new SpeedByGraphic(this);
            speedByGraphic.Show();
            this.Enabled = false;
        }

        private void btToByValues_Click(object sender, EventArgs e)
        {
            if (valuesForSpeed == null)
                valuesForSpeed = new ValuesForSpeed(this);
            valuesForSpeed.Show();
            this.Hide();
        }
    }
}

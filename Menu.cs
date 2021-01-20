using System;
using System.Windows.Forms;

namespace GetThePolynom
{
    public partial class Menu : Form
    {
        Theory theory;
        BuildChoice buildChoice;
        ValuesForFault valuesForFault;
        SpeedChoice speedChoice;

        public Menu()
        {
            InitializeComponent();
        }

        private void btToBuild_Click(object sender, EventArgs e)
        {
            if(buildChoice == null)
                buildChoice = new BuildChoice(this);
            buildChoice.Show();
            this.Hide();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void btToFault_Click(object sender, EventArgs e)
        {
            if (valuesForFault == null)
                valuesForFault = new ValuesForFault(this);
            valuesForFault.Show();
            this.Hide();
        }

        private void btToSpeed_Click(object sender, EventArgs e)
        {
            if (speedChoice == null)
                speedChoice = new SpeedChoice(this);
            speedChoice.Show();
            this.Hide();
        }

        private void btToTheory_Click(object sender, EventArgs e)
        {
            if (theory == null)
                theory = new Theory(this);
            theory.Show();
            this.Hide();
        }
    }
}

using System;
using System.Windows.Forms;

namespace GetThePolynom
{
    public partial class BuildChoice : Form
    {
        BuildByGraphic buildByGraphic;
        ValuesForBuild valuesForBuild;
        Menu menu;

        public BuildChoice(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void BuildChoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void btToByGraphic_Click(object sender, EventArgs e)
        {
            if(buildByGraphic == null)
                buildByGraphic = new BuildByGraphic(this);
            buildByGraphic.Show();
            this.Enabled = false;
        }

        private void btGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void btToByValues_Click(object sender, EventArgs e)
        {
            if (valuesForBuild == null)
                valuesForBuild = new ValuesForBuild(this);
            valuesForBuild.Show();
            this.Hide();
        }
    }
}

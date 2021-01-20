using System;
using System.Windows.Forms;

namespace GetThePolynom
{
    public partial class Theory : Form
    {
        Menu menu;

        public Theory(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void Theory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void btGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void treeViewTheory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = Application.StartupPath;
            string st1 = treeViewTheory.SelectedNode.Text;
            int sqq = treeViewTheory.SelectedNode.Index;

            if (st1 == "Загальні відомості про інтерполяцію")
                wbTheory.Navigate(path + "\\theory\\interpolation.html");
            if (st1 == "Многочлен Лагранжа")
                wbTheory.Navigate(path + "\\theory\\lagrange.html");
            if (st1 == "Многочлен Ньютона")
                wbTheory.Navigate(path + "\\theory\\newton.html");
        }

        private void Theory_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            wbTheory.Navigate(path + "\\texts\\interpolation.html");
        }
    }
}

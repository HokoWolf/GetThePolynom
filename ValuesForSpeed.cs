using System;
using System.Drawing;
using System.Windows.Forms;

namespace GetThePolynom
{
    public partial class ValuesForSpeed : Form
    {
        SpeedChoice speedChoice;
        double[,] values, extraValues;

        public ValuesForSpeed(SpeedChoice speedChoice)
        {
            InitializeComponent();
            this.speedChoice = speedChoice;
        }

        private void ValuesForSpeed_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void btGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            speedChoice.Show();
        }

        private void ValuesForSpeed_Load(object sender, EventArgs e)
        {
            #region
            dataGridValues.RowCount = 2;
            dataGridValues.ColumnCount = 3;

            dataGridValues.Rows[0].HeaderCell.Value = "X";
            dataGridValues.Rows[1].HeaderCell.Value = "Y";
            dataGridValues.Columns[0].HeaderText = "X0";
            dataGridValues.Columns[1].HeaderText = "X1";
            dataGridValues.Columns[2].HeaderText = "X2";

            dataGridValues.Rows[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridValues.Rows[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridValues.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridValues.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridValues.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridValues.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            dataGridValues.RowHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);

            dataGridValues.Rows[0].Height = 80;
            dataGridValues.Rows[1].Height = 80;
            dataGridValues.Columns[0].Width = 120;
            dataGridValues.Columns[1].Width = 120;
            dataGridValues.Columns[2].Width = 120;

            dataGridValues.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridValues.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridValues.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            dataGridValues.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridValues.Rows[0].Cells[0].Value = 0;
            dataGridValues.Rows[1].Cells[0].Value = 0;
            dataGridValues.Rows[0].Cells[1].Value = 1;
            dataGridValues.Rows[1].Cells[1].Value = 1;
            dataGridValues.Rows[0].Cells[2].Value = 2;
            dataGridValues.Rows[1].Cells[2].Value = 4;

            dataGridValues.Rows[0].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
            dataGridValues.Rows[1].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);

            values = new double[3, 2];
            values[0, 0] = 0;
            values[0, 1] = 0;
            values[1, 0] = 1;
            values[1, 1] = 1;
            values[2, 0] = 2;
            values[2, 1] = 4;
            #endregion

            #region
            dataGridExtraValues.RowCount = 2;
            dataGridExtraValues.ColumnCount = 2;

            dataGridExtraValues.Rows[0].HeaderCell.Value = "X";
            dataGridExtraValues.Rows[1].HeaderCell.Value = "Y";
            dataGridExtraValues.Columns[0].HeaderText = "X0";
            dataGridExtraValues.Columns[1].HeaderText = "X1";

            dataGridExtraValues.Rows[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridExtraValues.Rows[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridExtraValues.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridExtraValues.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridExtraValues.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            dataGridExtraValues.RowHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);

            dataGridExtraValues.Rows[0].Height = 80;
            dataGridExtraValues.Rows[1].Height = 80;
            dataGridExtraValues.Columns[0].Width = 120;
            dataGridExtraValues.Columns[1].Width = 120;

            dataGridExtraValues.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridExtraValues.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

            dataGridExtraValues.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridExtraValues.Rows[0].Cells[0].Value = 3;
            dataGridExtraValues.Rows[1].Cells[0].Value = 1;
            dataGridExtraValues.Rows[0].Cells[1].Value = 4;
            dataGridExtraValues.Rows[1].Cells[1].Value = 0;

            dataGridExtraValues.Rows[0].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
            dataGridExtraValues.Rows[1].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);

            extraValues = new double[2, 2];
            extraValues[0, 0] = 3;
            extraValues[0, 1] = 1;
            extraValues[1, 0] = 4;
            extraValues[1, 1] = 0;
            #endregion
        }

        private void btAddColumn_Click(object sender, EventArgs e)
        {
            dataGridValues.Columns.Add("", "X" + dataGridValues.Columns.Count);
            if (dataGridValues.ColumnCount <= 1)
            {
                dataGridValues.RowCount = 2;
                dataGridValues.Rows[0].HeaderCell.Value = "X";
                dataGridValues.Rows[1].HeaderCell.Value = "Y";
                dataGridValues.Rows[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridValues.Rows[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridValues.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridValues.Rows[0].Height = 80;
                dataGridValues.Rows[1].Height = 80;
                dataGridValues.Columns[0].Width = 120;
                dataGridValues.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridValues.Rows[0].Cells[0].Value = 0;
                dataGridValues.Rows[1].Cells[0].Value = 0;
            }
            else
            {
                dataGridValues.Columns[dataGridValues.Columns.Count - 1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridValues.Columns[dataGridValues.Columns.Count - 1].Width = 120;
                dataGridValues.Columns[dataGridValues.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.NotSortable;

                double max = -1000;
                for (int i = 0; i < dataGridValues.Columns.Count - 1; i++)
                    max = Math.Max(values[i, 0], max);

                dataGridValues.Rows[0].Cells[dataGridValues.Columns.Count - 1].Value = max + 1;
                dataGridValues.Rows[1].Cells[dataGridValues.Columns.Count - 1].Value = 0;
            }

            values = new double[dataGridValues.Columns.Count, 2];
            for (int i = 0; i < dataGridValues.Columns.Count; i++)
                for (int j = 0; j < dataGridValues.Rows.Count; j++)
                    values[i, j] = Convert.ToDouble(dataGridValues.Rows[j].Cells[i].Value);
        }

        private void btAddColExtra_Click(object sender, EventArgs e)
        {
            dataGridExtraValues.Columns.Add("", "X" + dataGridExtraValues.Columns.Count);
            if (dataGridExtraValues.ColumnCount <= 1)
            {
                dataGridExtraValues.RowCount = 2;
                dataGridExtraValues.Rows[0].HeaderCell.Value = "X";
                dataGridExtraValues.Rows[1].HeaderCell.Value = "Y";
                dataGridExtraValues.Rows[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridExtraValues.Rows[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridExtraValues.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridExtraValues.Rows[0].Height = 80;
                dataGridExtraValues.Rows[1].Height = 80;
                dataGridExtraValues.Columns[0].Width = 120;
                dataGridExtraValues.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridExtraValues.Rows[0].Cells[0].Value = 0;
                dataGridExtraValues.Rows[1].Cells[0].Value = 0;
            }
            else
            {
                dataGridExtraValues.Columns[dataGridExtraValues.Columns.Count - 1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridExtraValues.Columns[dataGridExtraValues.Columns.Count - 1].Width = 120;
                dataGridExtraValues.Columns[dataGridExtraValues.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.NotSortable;

                double max = -1000;
                for (int i = 0; i < dataGridExtraValues.Columns.Count - 1; i++)
                    max = Math.Max(extraValues[i, 0], max);

                dataGridExtraValues.Rows[0].Cells[dataGridExtraValues.Columns.Count - 1].Value = max + 1;
                dataGridExtraValues.Rows[1].Cells[dataGridExtraValues.Columns.Count - 1].Value = 0;
            }

            extraValues = new double[dataGridExtraValues.Columns.Count, 2];
            for (int i = 0; i < dataGridExtraValues.Columns.Count; i++)
                for (int j = 0; j < dataGridExtraValues.Rows.Count; j++)
                    extraValues[i, j] = Convert.ToDouble(dataGridExtraValues.Rows[j].Cells[i].Value);
        }

        private void dataGridValues_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double prevValue = values[e.ColumnIndex, e.RowIndex];
            double value;
            try
            {
                if (double.TryParse(dataGridValues.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out value) == false)
                {
                    throw new Exception("Задане значення не є числом!");
                }
                values[e.ColumnIndex, e.RowIndex] = Convert.ToDouble(dataGridValues.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridValues.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = prevValue;
            }
        }

        private void dataGridExtraValues_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double prevValue = extraValues[e.ColumnIndex, e.RowIndex];
            double value;
            try
            {
                if (double.TryParse(dataGridExtraValues.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out value) == false)
                {
                    throw new Exception("Задане значення не є числом!");
                }
                extraValues[e.ColumnIndex, e.RowIndex] = Convert.ToDouble(dataGridExtraValues.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridExtraValues.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = prevValue;
            }
        }

        private void btDeleteCol_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridValues.Columns.RemoveAt(Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox(
                "Введіть індекс стовпчика, який потрібно видалити (індекс стовпчика - це індекс біля X)",
                "Виберіть, який стовпчик видалити",
                (dataGridValues.Columns.Count - 1).ToString())));
            }
            catch { }

            for (int i = 0; i < dataGridValues.Columns.Count; i++)
                dataGridValues.Columns[i].HeaderText = "X" + i;

            values = new double[dataGridValues.Columns.Count, 2];
            for (int i = 0; i < dataGridValues.Columns.Count; i++)
                for (int j = 0; j < dataGridValues.Rows.Count; j++)
                    values[i, j] = Convert.ToDouble(dataGridValues.Rows[j].Cells[i].Value);
        }

        private void btDeleteColExtra_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridExtraValues.Columns.RemoveAt(Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox(
                "Введіть індекс стовпчика, який потрібно видалити (індекс стовпчика - це індекс біля X)",
                "Виберіть, який стовпчик видалити",
                (dataGridExtraValues.Columns.Count - 1).ToString())));
            }
            catch { }

            for (int i = 0; i < dataGridExtraValues.Columns.Count; i++)
                dataGridExtraValues.Columns[i].HeaderText = "X" + i;

            extraValues = new double[dataGridExtraValues.Columns.Count, 2];
            for (int i = 0; i < dataGridExtraValues.Columns.Count; i++)
                for (int j = 0; j < dataGridExtraValues.Rows.Count; j++)
                    extraValues[i, j] = Convert.ToDouble(dataGridExtraValues.Rows[j].Cells[i].Value);
        }

        private void btToByValues_Click(object sender, EventArgs e)
        {
            if (values.GetLength(0) <= 1)
                MessageBox.Show("Недостатньо введено початкових точок (потрібно, як мінімум, 2)!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (extraValues.GetLength(0) < 1)
                MessageBox.Show("Недостатньо введено початкових точок (потрібно, як мінімум, 2)!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SpeedByValues speedByValues = new SpeedByValues(this, values, extraValues);
                speedByValues.Show();
                this.Enabled = false;
            }
        }
    }
}

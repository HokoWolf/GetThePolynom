namespace GetThePolynom
{
    partial class ValuesForBuild
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValuesForBuild));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btGoBack = new System.Windows.Forms.Button();
            this.btAddColumn = new System.Windows.Forms.Button();
            this.btDeleteCol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridValues = new System.Windows.Forms.DataGridView();
            this.btToByValues = new System.Windows.Forms.Button();
            this.cmbPolynom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridValues)).BeginInit();
            this.SuspendLayout();
            // 
            // btGoBack
            // 
            this.btGoBack.BackColor = System.Drawing.Color.Transparent;
            this.btGoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btGoBack.BackgroundImage")));
            this.btGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGoBack.Location = new System.Drawing.Point(85, 635);
            this.btGoBack.Name = "btGoBack";
            this.btGoBack.Size = new System.Drawing.Size(125, 67);
            this.btGoBack.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btGoBack, "Повернутися назад до меню вибору побудови функції");
            this.btGoBack.UseVisualStyleBackColor = false;
            this.btGoBack.Click += new System.EventHandler(this.btGoBack_Click);
            // 
            // btAddColumn
            // 
            this.btAddColumn.BackColor = System.Drawing.Color.White;
            this.btAddColumn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAddColumn.BackgroundImage")));
            this.btAddColumn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAddColumn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddColumn.Location = new System.Drawing.Point(998, 469);
            this.btAddColumn.Name = "btAddColumn";
            this.btAddColumn.Size = new System.Drawing.Size(64, 64);
            this.btAddColumn.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btAddColumn, "Додати нову точку");
            this.btAddColumn.UseVisualStyleBackColor = false;
            this.btAddColumn.Click += new System.EventHandler(this.btAddColumn_Click);
            // 
            // btDeleteCol
            // 
            this.btDeleteCol.BackColor = System.Drawing.Color.White;
            this.btDeleteCol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDeleteCol.BackgroundImage")));
            this.btDeleteCol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDeleteCol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDeleteCol.Location = new System.Drawing.Point(915, 469);
            this.btDeleteCol.Name = "btDeleteCol";
            this.btDeleteCol.Size = new System.Drawing.Size(64, 64);
            this.btDeleteCol.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btDeleteCol, "Видалити точку");
            this.btDeleteCol.UseVisualStyleBackColor = false;
            this.btDeleteCol.Click += new System.EventHandler(this.btDeleteCol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(368, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 64);
            this.label1.TabIndex = 3;
            this.label1.Text = "Задайте значення:";
            // 
            // dataGridValues
            // 
            this.dataGridValues.AllowUserToAddRows = false;
            this.dataGridValues.AllowUserToResizeRows = false;
            this.dataGridValues.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridValues.ColumnHeadersHeight = 80;
            this.dataGridValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridValues.Location = new System.Drawing.Point(162, 201);
            this.dataGridValues.Name = "dataGridValues";
            this.dataGridValues.RowHeadersWidth = 120;
            this.dataGridValues.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridValues.Size = new System.Drawing.Size(900, 262);
            this.dataGridValues.TabIndex = 9;
            this.dataGridValues.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridValues_CellEndEdit);
            // 
            // btToByValues
            // 
            this.btToByValues.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btToByValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btToByValues.Location = new System.Drawing.Point(877, 596);
            this.btToByValues.Name = "btToByValues";
            this.btToByValues.Size = new System.Drawing.Size(198, 65);
            this.btToByValues.TabIndex = 12;
            this.btToByValues.Text = "Побудувати";
            this.btToByValues.UseVisualStyleBackColor = false;
            this.btToByValues.Click += new System.EventHandler(this.btToByValues_Click);
            // 
            // cmbPolynom
            // 
            this.cmbPolynom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbPolynom.FormattingEnabled = true;
            this.cmbPolynom.ItemHeight = 25;
            this.cmbPolynom.Items.AddRange(new object[] {
            "Лагранжа",
            "Ньютона"});
            this.cmbPolynom.Location = new System.Drawing.Point(620, 484);
            this.cmbPolynom.Name = "cmbPolynom";
            this.cmbPolynom.Size = new System.Drawing.Size(254, 33);
            this.cmbPolynom.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(425, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Оберіть алгоритм";
            // 
            // ValuesForBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 714);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPolynom);
            this.Controls.Add(this.btToByValues);
            this.Controls.Add(this.btDeleteCol);
            this.Controls.Add(this.btAddColumn);
            this.Controls.Add(this.dataGridValues);
            this.Controls.Add(this.btGoBack);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ValuesForBuild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get The Polynom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ValuesForBuild_FormClosing);
            this.Load += new System.EventHandler(this.ValuesForBuild_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridValues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGoBack;
        private System.Windows.Forms.DataGridView dataGridValues;
        private System.Windows.Forms.Button btAddColumn;
        private System.Windows.Forms.Button btDeleteCol;
        private System.Windows.Forms.Button btToByValues;
        private System.Windows.Forms.ComboBox cmbPolynom;
        private System.Windows.Forms.Label label2;
    }
}
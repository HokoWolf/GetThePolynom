namespace GetThePolynom
{
    partial class ValuesForFault
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValuesForFault));
            this.btToFault = new System.Windows.Forms.Button();
            this.btDeleteCol = new System.Windows.Forms.Button();
            this.btAddColumn = new System.Windows.Forms.Button();
            this.dataGridValues = new System.Windows.Forms.DataGridView();
            this.btGoBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPreviousFunction = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridValues)).BeginInit();
            this.SuspendLayout();
            // 
            // btToFault
            // 
            this.btToFault.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btToFault.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btToFault.Location = new System.Drawing.Point(913, 637);
            this.btToFault.Name = "btToFault";
            this.btToFault.Size = new System.Drawing.Size(198, 65);
            this.btToFault.TabIndex = 20;
            this.btToFault.Text = "Побудувати";
            this.btToFault.UseVisualStyleBackColor = false;
            this.btToFault.Click += new System.EventHandler(this.btToFault_Click);
            // 
            // btDeleteCol
            // 
            this.btDeleteCol.BackColor = System.Drawing.Color.White;
            this.btDeleteCol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDeleteCol.BackgroundImage")));
            this.btDeleteCol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDeleteCol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDeleteCol.Location = new System.Drawing.Point(896, 448);
            this.btDeleteCol.Name = "btDeleteCol";
            this.btDeleteCol.Size = new System.Drawing.Size(64, 64);
            this.btDeleteCol.TabIndex = 19;
            this.btDeleteCol.UseVisualStyleBackColor = false;
            this.btDeleteCol.Click += new System.EventHandler(this.btDeleteCol_Click);
            // 
            // btAddColumn
            // 
            this.btAddColumn.BackColor = System.Drawing.Color.White;
            this.btAddColumn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAddColumn.BackgroundImage")));
            this.btAddColumn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAddColumn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddColumn.Location = new System.Drawing.Point(981, 448);
            this.btAddColumn.Name = "btAddColumn";
            this.btAddColumn.Size = new System.Drawing.Size(64, 64);
            this.btAddColumn.TabIndex = 18;
            this.btAddColumn.UseVisualStyleBackColor = false;
            this.btAddColumn.Click += new System.EventHandler(this.btAddColumn_Click);
            // 
            // dataGridValues
            // 
            this.dataGridValues.AllowUserToAddRows = false;
            this.dataGridValues.AllowUserToResizeColumns = false;
            this.dataGridValues.AllowUserToResizeRows = false;
            this.dataGridValues.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridValues.ColumnHeadersHeight = 80;
            this.dataGridValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridValues.Location = new System.Drawing.Point(164, 179);
            this.dataGridValues.Name = "dataGridValues";
            this.dataGridValues.RowHeadersWidth = 120;
            this.dataGridValues.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridValues.Size = new System.Drawing.Size(900, 263);
            this.dataGridValues.TabIndex = 17;
            this.dataGridValues.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridValues_CellEndEdit);
            // 
            // btGoBack
            // 
            this.btGoBack.BackColor = System.Drawing.Color.Transparent;
            this.btGoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btGoBack.BackgroundImage")));
            this.btGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGoBack.Location = new System.Drawing.Point(65, 626);
            this.btGoBack.Name = "btGoBack";
            this.btGoBack.Size = new System.Drawing.Size(125, 67);
            this.btGoBack.TabIndex = 16;
            this.btGoBack.UseVisualStyleBackColor = false;
            this.btGoBack.Click += new System.EventHandler(this.btGoBack_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(196, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(789, 128);
            this.label1.TabIndex = 15;
            this.label1.Text = "Задайте значення\r\nдля знаходження похибки:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(73, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 87);
            this.label2.TabIndex = 22;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPreviousFunction
            // 
            this.txtPreviousFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPreviousFunction.Location = new System.Drawing.Point(367, 456);
            this.txtPreviousFunction.Multiline = true;
            this.txtPreviousFunction.Name = "txtPreviousFunction";
            this.txtPreviousFunction.Size = new System.Drawing.Size(510, 69);
            this.txtPreviousFunction.TabIndex = 23;
            this.txtPreviousFunction.Text = "sin(Pi*x)\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(54, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Напишіть первинну функцію:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(636, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(535, 56);
            this.label4.TabIndex = 25;
            this.label4.Text = "Не пропускайте оператор множення!\r\nРоздільник між цілою і дробовою частинами - ко" +
    "ма \",\"";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ValuesForFault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 714);
            this.Controls.Add(this.btGoBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPreviousFunction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btToFault);
            this.Controls.Add(this.btDeleteCol);
            this.Controls.Add(this.btAddColumn);
            this.Controls.Add(this.dataGridValues);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ValuesForFault";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get The Polynom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FaultChoice_FormClosing);
            this.Load += new System.EventHandler(this.ValuesForFault_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridValues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btToFault;
        private System.Windows.Forms.Button btDeleteCol;
        private System.Windows.Forms.Button btAddColumn;
        private System.Windows.Forms.DataGridView dataGridValues;
        private System.Windows.Forms.Button btGoBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPreviousFunction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
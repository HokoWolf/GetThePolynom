namespace GetThePolynom
{
    partial class Theory
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Загальні відомості про інтерполяцію");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Многочлен Лагранжа");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Многочлен Ньютона");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Методи інтерполяції", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Theory));
            this.label1 = new System.Windows.Forms.Label();
            this.treeViewTheory = new System.Windows.Forms.TreeView();
            this.btGoBack = new System.Windows.Forms.Button();
            this.wbTheory = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(518, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 64);
            this.label1.TabIndex = 9;
            this.label1.Text = "Теорія";
            // 
            // treeViewTheory
            // 
            this.treeViewTheory.Location = new System.Drawing.Point(56, 131);
            this.treeViewTheory.Name = "treeViewTheory";
            treeNode1.Name = "inter";
            treeNode1.Text = "Загальні відомості про інтерполяцію";
            treeNode2.Name = "lanPol";
            treeNode2.Text = "Многочлен Лагранжа";
            treeNode3.Name = "newtPol";
            treeNode3.Text = "Многочлен Ньютона";
            treeNode4.Name = "intMethods";
            treeNode4.Text = "Методи інтерполяції";
            this.treeViewTheory.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4});
            this.treeViewTheory.Size = new System.Drawing.Size(317, 118);
            this.treeViewTheory.TabIndex = 10;
            this.treeViewTheory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTheory_AfterSelect);
            // 
            // btGoBack
            // 
            this.btGoBack.BackColor = System.Drawing.Color.Transparent;
            this.btGoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btGoBack.BackgroundImage")));
            this.btGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGoBack.Location = new System.Drawing.Point(93, 639);
            this.btGoBack.Name = "btGoBack";
            this.btGoBack.Size = new System.Drawing.Size(125, 67);
            this.btGoBack.TabIndex = 14;
            this.btGoBack.UseVisualStyleBackColor = false;
            this.btGoBack.Click += new System.EventHandler(this.btGoBack_Click);
            // 
            // wbTheory
            // 
            this.wbTheory.Location = new System.Drawing.Point(379, 100);
            this.wbTheory.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbTheory.Name = "wbTheory";
            this.wbTheory.Size = new System.Drawing.Size(738, 602);
            this.wbTheory.TabIndex = 15;
            // 
            // Theory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 714);
            this.Controls.Add(this.wbTheory);
            this.Controls.Add(this.btGoBack);
            this.Controls.Add(this.treeViewTheory);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Theory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Theory_FormClosing);
            this.Load += new System.EventHandler(this.Theory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeViewTheory;
        private System.Windows.Forms.Button btGoBack;
        private System.Windows.Forms.WebBrowser wbTheory;
    }
}
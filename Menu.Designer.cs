namespace GetThePolynom
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btToTheory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btToBuild = new System.Windows.Forms.Button();
            this.btToFault = new System.Windows.Forms.Button();
            this.btToSpeed = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btToTheory
            // 
            this.btToTheory.BackColor = System.Drawing.Color.White;
            this.btToTheory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btToTheory.BackgroundImage")));
            this.btToTheory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btToTheory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btToTheory.Location = new System.Drawing.Point(170, 247);
            this.btToTheory.Name = "btToTheory";
            this.btToTheory.Size = new System.Drawing.Size(200, 200);
            this.btToTheory.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btToTheory, "Перейти до теорії випускної роботи");
            this.btToTheory.UseVisualStyleBackColor = false;
            this.btToTheory.Click += new System.EventHandler(this.btToTheory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(367, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Головне меню";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(196, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Теорія";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(778, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Практика";
            // 
            // btToBuild
            // 
            this.btToBuild.BackColor = System.Drawing.Color.White;
            this.btToBuild.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btToBuild.BackgroundImage")));
            this.btToBuild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btToBuild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btToBuild.Location = new System.Drawing.Point(695, 196);
            this.btToBuild.Name = "btToBuild";
            this.btToBuild.Size = new System.Drawing.Size(150, 150);
            this.btToBuild.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btToBuild, "Перейти до побудови графіків різними алгоритмами");
            this.btToBuild.UseVisualStyleBackColor = false;
            this.btToBuild.Click += new System.EventHandler(this.btToBuild_Click);
            // 
            // btToFault
            // 
            this.btToFault.BackColor = System.Drawing.Color.White;
            this.btToFault.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btToFault.BackgroundImage")));
            this.btToFault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btToFault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btToFault.Location = new System.Drawing.Point(905, 196);
            this.btToFault.Name = "btToFault";
            this.btToFault.Size = new System.Drawing.Size(150, 150);
            this.btToFault.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btToFault, "Перейти до порівняння похибки різних алгоритмів");
            this.btToFault.UseVisualStyleBackColor = false;
            this.btToFault.Click += new System.EventHandler(this.btToFault_Click);
            // 
            // btToSpeed
            // 
            this.btToSpeed.BackColor = System.Drawing.Color.White;
            this.btToSpeed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btToSpeed.BackgroundImage")));
            this.btToSpeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btToSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btToSpeed.Location = new System.Drawing.Point(799, 362);
            this.btToSpeed.Name = "btToSpeed";
            this.btToSpeed.Size = new System.Drawing.Size(150, 150);
            this.btToSpeed.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btToSpeed, "Перейти до порівняння алгоритмів за швидкістю");
            this.btToSpeed.UseVisualStyleBackColor = false;
            this.btToSpeed.Click += new System.EventHandler(this.btToSpeed_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 714);
            this.Controls.Add(this.btToSpeed);
            this.Controls.Add(this.btToFault);
            this.Controls.Add(this.btToBuild);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btToTheory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get The Polynom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btToTheory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btToBuild;
        private System.Windows.Forms.Button btToFault;
        private System.Windows.Forms.Button btToSpeed;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
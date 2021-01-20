namespace GetThePolynom
{
    partial class SpeedChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpeedChoice));
            this.btGoBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btToByValues = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btToByGraphic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btGoBack
            // 
            this.btGoBack.BackColor = System.Drawing.Color.Transparent;
            this.btGoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btGoBack.BackgroundImage")));
            this.btGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGoBack.Location = new System.Drawing.Point(149, 586);
            this.btGoBack.Name = "btGoBack";
            this.btGoBack.Size = new System.Drawing.Size(125, 67);
            this.btGoBack.TabIndex = 13;
            this.btGoBack.UseVisualStyleBackColor = false;
            this.btGoBack.Click += new System.EventHandler(this.btGoBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(894, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 46);
            this.label3.TabIndex = 12;
            this.label3.Text = "Таблично";
            // 
            // btToByValues
            // 
            this.btToByValues.BackColor = System.Drawing.Color.White;
            this.btToByValues.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btToByValues.BackgroundImage")));
            this.btToByValues.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btToByValues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btToByValues.Location = new System.Drawing.Point(865, 183);
            this.btToByValues.Name = "btToByValues";
            this.btToByValues.Size = new System.Drawing.Size(250, 250);
            this.btToByValues.TabIndex = 11;
            this.btToByValues.UseVisualStyleBackColor = false;
            this.btToByValues.Click += new System.EventHandler(this.btToByValues_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(280, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 46);
            this.label2.TabIndex = 10;
            this.label2.Text = "Графічно";
            // 
            // btToByGraphic
            // 
            this.btToByGraphic.BackColor = System.Drawing.Color.White;
            this.btToByGraphic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btToByGraphic.BackgroundImage")));
            this.btToByGraphic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btToByGraphic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btToByGraphic.Location = new System.Drawing.Point(251, 183);
            this.btToByGraphic.Name = "btToByGraphic";
            this.btToByGraphic.Size = new System.Drawing.Size(250, 250);
            this.btToByGraphic.TabIndex = 9;
            this.btToByGraphic.UseVisualStyleBackColor = false;
            this.btToByGraphic.Click += new System.EventHandler(this.btToByGraphic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(316, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 64);
            this.label1.TabIndex = 8;
            this.label1.Text = "Порівняти за швидкістю:";
            // 
            // SpeedChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 714);
            this.Controls.Add(this.btGoBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btToByValues);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btToByGraphic);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SpeedChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get The Polynom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpeedChoice_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGoBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btToByValues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btToByGraphic;
        private System.Windows.Forms.Label label1;
    }
}
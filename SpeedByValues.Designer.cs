namespace GetThePolynom
{
    partial class SpeedByValues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpeedByValues));
            this.btMoveCentre = new System.Windows.Forms.Button();
            this.wbResult = new System.Windows.Forms.WebBrowser();
            this.btMoveDown = new System.Windows.Forms.Button();
            this.btMoveUp = new System.Windows.Forms.Button();
            this.btMoveLeft = new System.Windows.Forms.Button();
            this.btMoveRight = new System.Windows.Forms.Button();
            this.btZoomOut = new System.Windows.Forms.Button();
            this.btZoomIn = new System.Windows.Forms.Button();
            this.PBMain = new System.Windows.Forms.PictureBox();
            this.timZoomIn = new System.Windows.Forms.Timer(this.components);
            this.timZoomOut = new System.Windows.Forms.Timer(this.components);
            this.timMoveLeft = new System.Windows.Forms.Timer(this.components);
            this.timMoveRight = new System.Windows.Forms.Timer(this.components);
            this.timMoveUp = new System.Windows.Forms.Timer(this.components);
            this.timMoveDown = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PBMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btMoveCentre
            // 
            this.btMoveCentre.BackColor = System.Drawing.Color.White;
            this.btMoveCentre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btMoveCentre.BackgroundImage")));
            this.btMoveCentre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btMoveCentre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMoveCentre.Location = new System.Drawing.Point(865, 621);
            this.btMoveCentre.Name = "btMoveCentre";
            this.btMoveCentre.Size = new System.Drawing.Size(37, 35);
            this.btMoveCentre.TabIndex = 57;
            this.btMoveCentre.UseVisualStyleBackColor = false;
            this.btMoveCentre.Click += new System.EventHandler(this.btMoveCentre_Click);
            // 
            // wbResult
            // 
            this.wbResult.Location = new System.Drawing.Point(922, 5);
            this.wbResult.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbResult.Name = "wbResult";
            this.wbResult.Size = new System.Drawing.Size(330, 580);
            this.wbResult.TabIndex = 50;
            // 
            // btMoveDown
            // 
            this.btMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMoveDown.Location = new System.Drawing.Point(388, 631);
            this.btMoveDown.Name = "btMoveDown";
            this.btMoveDown.Size = new System.Drawing.Size(150, 25);
            this.btMoveDown.TabIndex = 56;
            this.btMoveDown.Text = "▼";
            this.btMoveDown.UseVisualStyleBackColor = true;
            this.btMoveDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMoveDown_MouseDown);
            this.btMoveDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMoveDown_MouseUp);
            // 
            // btMoveUp
            // 
            this.btMoveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMoveUp.Location = new System.Drawing.Point(388, 15);
            this.btMoveUp.Name = "btMoveUp";
            this.btMoveUp.Size = new System.Drawing.Size(150, 25);
            this.btMoveUp.TabIndex = 55;
            this.btMoveUp.Text = "▲";
            this.btMoveUp.UseVisualStyleBackColor = true;
            this.btMoveUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMoveUp_MouseDown);
            this.btMoveUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMoveUp_MouseUp);
            // 
            // btMoveLeft
            // 
            this.btMoveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMoveLeft.Location = new System.Drawing.Point(22, 260);
            this.btMoveLeft.Name = "btMoveLeft";
            this.btMoveLeft.Size = new System.Drawing.Size(25, 150);
            this.btMoveLeft.TabIndex = 54;
            this.btMoveLeft.Text = "<";
            this.btMoveLeft.UseVisualStyleBackColor = true;
            this.btMoveLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMoveLeft_MouseDown);
            this.btMoveLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMoveLeft_MouseUp);
            // 
            // btMoveRight
            // 
            this.btMoveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMoveRight.Location = new System.Drawing.Point(878, 260);
            this.btMoveRight.Name = "btMoveRight";
            this.btMoveRight.Size = new System.Drawing.Size(25, 150);
            this.btMoveRight.TabIndex = 53;
            this.btMoveRight.Text = ">";
            this.btMoveRight.UseVisualStyleBackColor = true;
            this.btMoveRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMoveRight_MouseDown);
            this.btMoveRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMoveRight_MouseUp);
            // 
            // btZoomOut
            // 
            this.btZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btZoomOut.Location = new System.Drawing.Point(22, 50);
            this.btZoomOut.Name = "btZoomOut";
            this.btZoomOut.Size = new System.Drawing.Size(30, 29);
            this.btZoomOut.TabIndex = 52;
            this.btZoomOut.Text = "-";
            this.btZoomOut.UseVisualStyleBackColor = true;
            this.btZoomOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btZoomOut_MouseDown);
            this.btZoomOut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btZoomOut_MouseUp);
            // 
            // btZoomIn
            // 
            this.btZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btZoomIn.Location = new System.Drawing.Point(22, 15);
            this.btZoomIn.Name = "btZoomIn";
            this.btZoomIn.Size = new System.Drawing.Size(30, 29);
            this.btZoomIn.TabIndex = 51;
            this.btZoomIn.Text = "+";
            this.btZoomIn.UseVisualStyleBackColor = true;
            this.btZoomIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btZoomIn_MouseDown);
            this.btZoomIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btZoomIn_MouseUp);
            // 
            // PBMain
            // 
            this.PBMain.BackColor = System.Drawing.Color.White;
            this.PBMain.Location = new System.Drawing.Point(12, 5);
            this.PBMain.Name = "PBMain";
            this.PBMain.Size = new System.Drawing.Size(900, 660);
            this.PBMain.TabIndex = 45;
            this.PBMain.TabStop = false;
            // 
            // timZoomIn
            // 
            this.timZoomIn.Interval = 10;
            this.timZoomIn.Tick += new System.EventHandler(this.timZoomIn_Tick);
            // 
            // timZoomOut
            // 
            this.timZoomOut.Interval = 10;
            this.timZoomOut.Tick += new System.EventHandler(this.timZoomOut_Tick);
            // 
            // timMoveLeft
            // 
            this.timMoveLeft.Interval = 10;
            this.timMoveLeft.Tick += new System.EventHandler(this.timMoveLeft_Tick);
            // 
            // timMoveRight
            // 
            this.timMoveRight.Interval = 10;
            this.timMoveRight.Tick += new System.EventHandler(this.timMoveRight_Tick);
            // 
            // timMoveUp
            // 
            this.timMoveUp.Interval = 10;
            this.timMoveUp.Tick += new System.EventHandler(this.timMoveUp_Tick);
            // 
            // timMoveDown
            // 
            this.timMoveDown.Interval = 10;
            this.timMoveDown.Tick += new System.EventHandler(this.timMoveDown_Tick);
            // 
            // SpeedByValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 674);
            this.Controls.Add(this.btMoveCentre);
            this.Controls.Add(this.wbResult);
            this.Controls.Add(this.btMoveDown);
            this.Controls.Add(this.btMoveUp);
            this.Controls.Add(this.btMoveLeft);
            this.Controls.Add(this.btMoveRight);
            this.Controls.Add(this.btZoomOut);
            this.Controls.Add(this.btZoomIn);
            this.Controls.Add(this.PBMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SpeedByValues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SpeedByValues";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpeedByValues_FormClosing);
            this.Load += new System.EventHandler(this.SpeedByValues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btMoveCentre;
        private System.Windows.Forms.WebBrowser wbResult;
        private System.Windows.Forms.Button btMoveDown;
        private System.Windows.Forms.Button btMoveUp;
        private System.Windows.Forms.Button btMoveLeft;
        private System.Windows.Forms.Button btMoveRight;
        private System.Windows.Forms.Button btZoomOut;
        private System.Windows.Forms.Button btZoomIn;
        private System.Windows.Forms.PictureBox PBMain;
        private System.Windows.Forms.Timer timZoomIn;
        private System.Windows.Forms.Timer timZoomOut;
        private System.Windows.Forms.Timer timMoveLeft;
        private System.Windows.Forms.Timer timMoveRight;
        private System.Windows.Forms.Timer timMoveUp;
        private System.Windows.Forms.Timer timMoveDown;
    }
}
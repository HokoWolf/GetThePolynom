namespace GetThePolynom
{
    partial class FaultByValues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaultByValues));
            this.wbResult = new System.Windows.Forms.WebBrowser();
            this.btMoveCentre = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBMain)).BeginInit();
            this.SuspendLayout();
            // 
            // wbResult
            // 
            this.wbResult.Location = new System.Drawing.Point(929, 27);
            this.wbResult.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbResult.Name = "wbResult";
            this.wbResult.Size = new System.Drawing.Size(323, 562);
            this.wbResult.TabIndex = 44;
            // 
            // btMoveCentre
            // 
            this.btMoveCentre.BackColor = System.Drawing.Color.White;
            this.btMoveCentre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btMoveCentre.BackgroundImage")));
            this.btMoveCentre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btMoveCentre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMoveCentre.Location = new System.Drawing.Point(865, 643);
            this.btMoveCentre.Name = "btMoveCentre";
            this.btMoveCentre.Size = new System.Drawing.Size(37, 35);
            this.btMoveCentre.TabIndex = 43;
            this.btMoveCentre.UseVisualStyleBackColor = false;
            this.btMoveCentre.Click += new System.EventHandler(this.btMoveCentre_Click);
            // 
            // btMoveDown
            // 
            this.btMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMoveDown.Location = new System.Drawing.Point(388, 653);
            this.btMoveDown.Name = "btMoveDown";
            this.btMoveDown.Size = new System.Drawing.Size(150, 25);
            this.btMoveDown.TabIndex = 42;
            this.btMoveDown.Text = "▼";
            this.btMoveDown.UseVisualStyleBackColor = true;
            this.btMoveDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMoveDown_MouseDown);
            this.btMoveDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMoveDown_MouseUp);
            // 
            // btMoveUp
            // 
            this.btMoveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMoveUp.Location = new System.Drawing.Point(388, 37);
            this.btMoveUp.Name = "btMoveUp";
            this.btMoveUp.Size = new System.Drawing.Size(150, 25);
            this.btMoveUp.TabIndex = 41;
            this.btMoveUp.Text = "▲";
            this.btMoveUp.UseVisualStyleBackColor = true;
            this.btMoveUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMoveUp_MouseDown);
            this.btMoveUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMoveUp_MouseUp);
            // 
            // btMoveLeft
            // 
            this.btMoveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMoveLeft.Location = new System.Drawing.Point(22, 282);
            this.btMoveLeft.Name = "btMoveLeft";
            this.btMoveLeft.Size = new System.Drawing.Size(25, 150);
            this.btMoveLeft.TabIndex = 40;
            this.btMoveLeft.Text = "<";
            this.btMoveLeft.UseVisualStyleBackColor = true;
            this.btMoveLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMoveLeft_MouseDown);
            this.btMoveLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMoveLeft_MouseUp);
            // 
            // btMoveRight
            // 
            this.btMoveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMoveRight.Location = new System.Drawing.Point(878, 282);
            this.btMoveRight.Name = "btMoveRight";
            this.btMoveRight.Size = new System.Drawing.Size(25, 150);
            this.btMoveRight.TabIndex = 39;
            this.btMoveRight.Text = ">";
            this.btMoveRight.UseVisualStyleBackColor = true;
            this.btMoveRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMoveRight_MouseDown);
            this.btMoveRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMoveRight_MouseUp);
            // 
            // btZoomOut
            // 
            this.btZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btZoomOut.Location = new System.Drawing.Point(22, 72);
            this.btZoomOut.Name = "btZoomOut";
            this.btZoomOut.Size = new System.Drawing.Size(30, 29);
            this.btZoomOut.TabIndex = 38;
            this.btZoomOut.Text = "-";
            this.btZoomOut.UseVisualStyleBackColor = true;
            this.btZoomOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btZoomOut_MouseDown);
            this.btZoomOut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btZoomOut_MouseUp);
            // 
            // btZoomIn
            // 
            this.btZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btZoomIn.Location = new System.Drawing.Point(22, 37);
            this.btZoomIn.Name = "btZoomIn";
            this.btZoomIn.Size = new System.Drawing.Size(30, 29);
            this.btZoomIn.TabIndex = 37;
            this.btZoomIn.Text = "+";
            this.btZoomIn.UseVisualStyleBackColor = true;
            this.btZoomIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btZoomIn_MouseDown);
            this.btZoomIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btZoomIn_MouseUp);
            // 
            // PBMain
            // 
            this.PBMain.BackColor = System.Drawing.Color.White;
            this.PBMain.Location = new System.Drawing.Point(12, 27);
            this.PBMain.Name = "PBMain";
            this.PBMain.Size = new System.Drawing.Size(900, 660);
            this.PBMain.TabIndex = 36;
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(925, 602);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 85);
            this.label1.TabIndex = 45;
            this.label1.Text = "Увага: похибка рахується лише за значеннями функції на проміжку від X0 до Xn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FaultByValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 714);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wbResult);
            this.Controls.Add(this.btMoveCentre);
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
            this.Name = "FaultByValues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Get The Polynom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FaultByValues_FormClosing);
            this.Load += new System.EventHandler(this.FaultByValues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbResult;
        private System.Windows.Forms.Button btMoveCentre;
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
        private System.Windows.Forms.Label label1;
    }
}
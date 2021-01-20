namespace GetThePolynom
{
    partial class SpeedByGraphic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpeedByGraphic));
            this.timZoomIn = new System.Windows.Forms.Timer(this.components);
            this.timZoomOut = new System.Windows.Forms.Timer(this.components);
            this.timMoveLeft = new System.Windows.Forms.Timer(this.components);
            this.timMoveRight = new System.Windows.Forms.Timer(this.components);
            this.timMoveUp = new System.Windows.Forms.Timer(this.components);
            this.timMoveDown = new System.Windows.Forms.Timer(this.components);
            this.btMoveCentre = new System.Windows.Forms.Button();
            this.txtPtX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPtY = new System.Windows.Forms.TextBox();
            this.wbResult = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            this.btMoveDown = new System.Windows.Forms.Button();
            this.btMoveUp = new System.Windows.Forms.Button();
            this.btMoveLeft = new System.Windows.Forms.Button();
            this.btMoveRight = new System.Windows.Forms.Button();
            this.btZoomOut = new System.Windows.Forms.Button();
            this.btZoomIn = new System.Windows.Forms.Button();
            this.PBMain = new System.Windows.Forms.PictureBox();
            this.btStart = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.btAddDots = new System.Windows.Forms.Button();
            this.btFinish = new System.Windows.Forms.Button();
            this.lblAddDots = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBMain)).BeginInit();
            this.SuspendLayout();
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
            // btMoveCentre
            // 
            this.btMoveCentre.BackColor = System.Drawing.Color.White;
            this.btMoveCentre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btMoveCentre.BackgroundImage")));
            this.btMoveCentre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btMoveCentre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMoveCentre.Location = new System.Drawing.Point(865, 628);
            this.btMoveCentre.Name = "btMoveCentre";
            this.btMoveCentre.Size = new System.Drawing.Size(37, 35);
            this.btMoveCentre.TabIndex = 37;
            this.btMoveCentre.UseVisualStyleBackColor = false;
            this.btMoveCentre.Click += new System.EventHandler(this.btMoveCentre_Click);
            // 
            // txtPtX
            // 
            this.txtPtX.Enabled = false;
            this.txtPtX.Location = new System.Drawing.Point(822, 21);
            this.txtPtX.Name = "txtPtX";
            this.txtPtX.Size = new System.Drawing.Size(80, 26);
            this.txtPtX.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(783, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "X =";
            // 
            // txtPtY
            // 
            this.txtPtY.Enabled = false;
            this.txtPtY.Location = new System.Drawing.Point(822, 53);
            this.txtPtY.Name = "txtPtY";
            this.txtPtY.Size = new System.Drawing.Size(80, 26);
            this.txtPtY.TabIndex = 26;
            // 
            // wbResult
            // 
            this.wbResult.Location = new System.Drawing.Point(922, 12);
            this.wbResult.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbResult.Name = "wbResult";
            this.wbResult.Size = new System.Drawing.Size(330, 459);
            this.wbResult.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(783, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Y =";
            // 
            // btMoveDown
            // 
            this.btMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMoveDown.Location = new System.Drawing.Point(388, 638);
            this.btMoveDown.Name = "btMoveDown";
            this.btMoveDown.Size = new System.Drawing.Size(150, 25);
            this.btMoveDown.TabIndex = 34;
            this.btMoveDown.Text = "▼";
            this.btMoveDown.UseVisualStyleBackColor = true;
            this.btMoveDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMoveDown_MouseDown);
            this.btMoveDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMoveDown_MouseUp);
            // 
            // btMoveUp
            // 
            this.btMoveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMoveUp.Location = new System.Drawing.Point(388, 22);
            this.btMoveUp.Name = "btMoveUp";
            this.btMoveUp.Size = new System.Drawing.Size(150, 25);
            this.btMoveUp.TabIndex = 33;
            this.btMoveUp.Text = "▲";
            this.btMoveUp.UseVisualStyleBackColor = true;
            this.btMoveUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMoveUp_MouseDown);
            this.btMoveUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMoveUp_MouseUp);
            // 
            // btMoveLeft
            // 
            this.btMoveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMoveLeft.Location = new System.Drawing.Point(22, 267);
            this.btMoveLeft.Name = "btMoveLeft";
            this.btMoveLeft.Size = new System.Drawing.Size(25, 150);
            this.btMoveLeft.TabIndex = 32;
            this.btMoveLeft.Text = "<";
            this.btMoveLeft.UseVisualStyleBackColor = true;
            this.btMoveLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMoveLeft_MouseDown);
            this.btMoveLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMoveLeft_MouseUp);
            // 
            // btMoveRight
            // 
            this.btMoveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMoveRight.Location = new System.Drawing.Point(878, 267);
            this.btMoveRight.Name = "btMoveRight";
            this.btMoveRight.Size = new System.Drawing.Size(25, 150);
            this.btMoveRight.TabIndex = 31;
            this.btMoveRight.Text = ">";
            this.btMoveRight.UseVisualStyleBackColor = true;
            this.btMoveRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMoveRight_MouseDown);
            this.btMoveRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMoveRight_MouseUp);
            // 
            // btZoomOut
            // 
            this.btZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btZoomOut.Location = new System.Drawing.Point(22, 57);
            this.btZoomOut.Name = "btZoomOut";
            this.btZoomOut.Size = new System.Drawing.Size(30, 29);
            this.btZoomOut.TabIndex = 30;
            this.btZoomOut.Text = "-";
            this.btZoomOut.UseVisualStyleBackColor = true;
            this.btZoomOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btZoomOut_MouseDown);
            this.btZoomOut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btZoomOut_MouseUp);
            // 
            // btZoomIn
            // 
            this.btZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btZoomIn.Location = new System.Drawing.Point(22, 22);
            this.btZoomIn.Name = "btZoomIn";
            this.btZoomIn.Size = new System.Drawing.Size(30, 29);
            this.btZoomIn.TabIndex = 29;
            this.btZoomIn.Text = "+";
            this.btZoomIn.UseVisualStyleBackColor = true;
            this.btZoomIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btZoomIn_MouseDown);
            this.btZoomIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btZoomIn_MouseUp);
            // 
            // PBMain
            // 
            this.PBMain.BackColor = System.Drawing.Color.White;
            this.PBMain.Location = new System.Drawing.Point(12, 12);
            this.PBMain.Name = "PBMain";
            this.PBMain.Size = new System.Drawing.Size(900, 660);
            this.PBMain.TabIndex = 23;
            this.PBMain.TabStop = false;
            this.PBMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PBMain_MouseClick);
            this.PBMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PBMain_MouseMove);
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(987, 491);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(204, 81);
            this.btStart.TabIndex = 39;
            this.btStart.Text = "Розпочати";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lblStart
            // 
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStart.Location = new System.Drawing.Point(922, 588);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(330, 125);
            this.lblStart.TabIndex = 40;
            this.lblStart.Text = "Натисніть кнопку \"Розпочати\" для того, щоб порівняти швидкості алгоритмів";
            // 
            // btAddDots
            // 
            this.btAddDots.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddDots.Location = new System.Drawing.Point(987, 491);
            this.btAddDots.Name = "btAddDots";
            this.btAddDots.Size = new System.Drawing.Size(204, 81);
            this.btAddDots.TabIndex = 41;
            this.btAddDots.Text = "Додати точки";
            this.btAddDots.UseVisualStyleBackColor = true;
            this.btAddDots.Click += new System.EventHandler(this.btAddDots_Click);
            // 
            // btFinish
            // 
            this.btFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btFinish.Location = new System.Drawing.Point(987, 491);
            this.btFinish.Name = "btFinish";
            this.btFinish.Size = new System.Drawing.Size(204, 81);
            this.btFinish.TabIndex = 42;
            this.btFinish.Text = "Закінчити";
            this.btFinish.UseVisualStyleBackColor = true;
            this.btFinish.Click += new System.EventHandler(this.btFinish_Click);
            // 
            // lblAddDots
            // 
            this.lblAddDots.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddDots.Location = new System.Drawing.Point(922, 588);
            this.lblAddDots.Name = "lblAddDots";
            this.lblAddDots.Size = new System.Drawing.Size(330, 125);
            this.lblAddDots.TabIndex = 43;
            this.lblAddDots.Text = "Поставте на координатній площині перші точки та нажміть кнопку \"Додати точки\" (по" +
    "тім будуть додаватися додаткові точки для знахождення швидкості перебудови много" +
    "члена).";
            // 
            // lblFinish
            // 
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFinish.Location = new System.Drawing.Point(922, 588);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(330, 128);
            this.lblFinish.TabIndex = 44;
            this.lblFinish.Text = "Поставте на координатній площині додаткові точки для знаходженян швидкості перебу" +
    "дови многчолена та нажміть кнопку \"Закінчити\".";
            // 
            // SpeedByGraphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 725);
            this.Controls.Add(this.lblAddDots);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btMoveCentre);
            this.Controls.Add(this.txtPtX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPtY);
            this.Controls.Add(this.wbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btMoveDown);
            this.Controls.Add(this.btMoveUp);
            this.Controls.Add(this.btMoveLeft);
            this.Controls.Add(this.btMoveRight);
            this.Controls.Add(this.btZoomOut);
            this.Controls.Add(this.btZoomIn);
            this.Controls.Add(this.PBMain);
            this.Controls.Add(this.btFinish);
            this.Controls.Add(this.btAddDots);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lblFinish);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SpeedByGraphic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Get The Polynom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpeedByGraphic_FormClosing);
            this.Load += new System.EventHandler(this.SpeedByGraphic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timZoomIn;
        private System.Windows.Forms.Timer timZoomOut;
        private System.Windows.Forms.Timer timMoveLeft;
        private System.Windows.Forms.Timer timMoveRight;
        private System.Windows.Forms.Timer timMoveUp;
        private System.Windows.Forms.Timer timMoveDown;
        private System.Windows.Forms.Button btMoveCentre;
        private System.Windows.Forms.TextBox txtPtX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPtY;
        private System.Windows.Forms.WebBrowser wbResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btMoveDown;
        private System.Windows.Forms.Button btMoveUp;
        private System.Windows.Forms.Button btMoveLeft;
        private System.Windows.Forms.Button btMoveRight;
        private System.Windows.Forms.Button btZoomOut;
        private System.Windows.Forms.Button btZoomIn;
        private System.Windows.Forms.PictureBox PBMain;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button btAddDots;
        private System.Windows.Forms.Button btFinish;
        private System.Windows.Forms.Label lblAddDots;
        private System.Windows.Forms.Label lblFinish;
    }
}
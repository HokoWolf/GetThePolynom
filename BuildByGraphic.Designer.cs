namespace GetThePolynom
{
    partial class BuildByGraphic
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildByGraphic));
            this.PBMain = new System.Windows.Forms.PictureBox();
            this.txtPtX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPtY = new System.Windows.Forms.TextBox();
            this.wbResult = new System.Windows.Forms.WebBrowser();
            this.btZoomIn = new System.Windows.Forms.Button();
            this.btZoomOut = new System.Windows.Forms.Button();
            this.btMoveRight = new System.Windows.Forms.Button();
            this.btMoveLeft = new System.Windows.Forms.Button();
            this.btMoveUp = new System.Windows.Forms.Button();
            this.btMoveDown = new System.Windows.Forms.Button();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.langrangePolynomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newtonPolynomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btFinishPolynom = new System.Windows.Forms.Button();
            this.btMoveCentre = new System.Windows.Forms.Button();
            this.timZoomIn = new System.Windows.Forms.Timer(this.components);
            this.timZoomOut = new System.Windows.Forms.Timer(this.components);
            this.timMoveLeft = new System.Windows.Forms.Timer(this.components);
            this.timMoveRight = new System.Windows.Forms.Timer(this.components);
            this.timMoveUp = new System.Windows.Forms.Timer(this.components);
            this.timMoveDown = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PBMain)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBMain
            // 
            this.PBMain.BackColor = System.Drawing.Color.White;
            this.PBMain.Location = new System.Drawing.Point(12, 41);
            this.PBMain.Name = "PBMain";
            this.PBMain.Size = new System.Drawing.Size(900, 660);
            this.PBMain.TabIndex = 0;
            this.PBMain.TabStop = false;
            this.PBMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PBLangrange_MouseClick);
            this.PBMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PBLangrange_MouseDown);
            this.PBMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PBLangrange_MouseMove);
            this.PBMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PBLangrange_MouseUp);
            // 
            // txtPtX
            // 
            this.txtPtX.Enabled = false;
            this.txtPtX.Location = new System.Drawing.Point(822, 50);
            this.txtPtX.Name = "txtPtX";
            this.txtPtX.Size = new System.Drawing.Size(80, 26);
            this.txtPtX.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(783, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "X =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(783, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y =";
            // 
            // txtPtY
            // 
            this.txtPtY.Enabled = false;
            this.txtPtY.Location = new System.Drawing.Point(822, 82);
            this.txtPtY.Name = "txtPtY";
            this.txtPtY.Size = new System.Drawing.Size(80, 26);
            this.txtPtY.TabIndex = 8;
            // 
            // wbResult
            // 
            this.wbResult.Location = new System.Drawing.Point(929, 41);
            this.wbResult.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbResult.Name = "wbResult";
            this.wbResult.Size = new System.Drawing.Size(323, 356);
            this.wbResult.TabIndex = 14;
            // 
            // btZoomIn
            // 
            this.btZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btZoomIn.Location = new System.Drawing.Point(22, 51);
            this.btZoomIn.Name = "btZoomIn";
            this.btZoomIn.Size = new System.Drawing.Size(30, 29);
            this.btZoomIn.TabIndex = 14;
            this.btZoomIn.Text = "+";
            this.btZoomIn.UseVisualStyleBackColor = true;
            this.btZoomIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btZoomIn_MouseDown);
            this.btZoomIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btZoomIn_MouseUp);
            // 
            // btZoomOut
            // 
            this.btZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btZoomOut.Location = new System.Drawing.Point(22, 86);
            this.btZoomOut.Name = "btZoomOut";
            this.btZoomOut.Size = new System.Drawing.Size(30, 29);
            this.btZoomOut.TabIndex = 15;
            this.btZoomOut.Text = "-";
            this.btZoomOut.UseVisualStyleBackColor = true;
            this.btZoomOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btZoomOut_MouseDown);
            this.btZoomOut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btZoomOut_MouseUp);
            // 
            // btMoveRight
            // 
            this.btMoveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMoveRight.Location = new System.Drawing.Point(878, 296);
            this.btMoveRight.Name = "btMoveRight";
            this.btMoveRight.Size = new System.Drawing.Size(25, 150);
            this.btMoveRight.TabIndex = 16;
            this.btMoveRight.Text = ">";
            this.btMoveRight.UseVisualStyleBackColor = true;
            this.btMoveRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMoveRight_MouseDown);
            this.btMoveRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMoveRight_MouseUp);
            // 
            // btMoveLeft
            // 
            this.btMoveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMoveLeft.Location = new System.Drawing.Point(22, 296);
            this.btMoveLeft.Name = "btMoveLeft";
            this.btMoveLeft.Size = new System.Drawing.Size(25, 150);
            this.btMoveLeft.TabIndex = 17;
            this.btMoveLeft.Text = "<";
            this.btMoveLeft.UseVisualStyleBackColor = true;
            this.btMoveLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMoveLeft_MouseDown);
            this.btMoveLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMoveLeft_MouseUp);
            // 
            // btMoveUp
            // 
            this.btMoveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMoveUp.Location = new System.Drawing.Point(388, 51);
            this.btMoveUp.Name = "btMoveUp";
            this.btMoveUp.Size = new System.Drawing.Size(150, 25);
            this.btMoveUp.TabIndex = 18;
            this.btMoveUp.Text = "▲";
            this.btMoveUp.UseVisualStyleBackColor = true;
            this.btMoveUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMoveUp_MouseDown);
            this.btMoveUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMoveUp_MouseUp);
            // 
            // btMoveDown
            // 
            this.btMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMoveDown.Location = new System.Drawing.Point(388, 667);
            this.btMoveDown.Name = "btMoveDown";
            this.btMoveDown.Size = new System.Drawing.Size(150, 25);
            this.btMoveDown.TabIndex = 19;
            this.btMoveDown.Text = "▼";
            this.btMoveDown.UseVisualStyleBackColor = true;
            this.btMoveDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMoveDown_MouseDown);
            this.btMoveDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMoveDown_MouseUp);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.newToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1264, 25);
            this.menuStripMain.TabIndex = 20;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.clearToolStripMenuItem.Text = "Очистити";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.langrangePolynomToolStripMenuItem,
            this.newtonPolynomToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.newToolStripMenuItem.Text = "Новий";
            // 
            // langrangePolynomToolStripMenuItem
            // 
            this.langrangePolynomToolStripMenuItem.Name = "langrangePolynomToolStripMenuItem";
            this.langrangePolynomToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.langrangePolynomToolStripMenuItem.Text = "Многочлен Лагранжа";
            this.langrangePolynomToolStripMenuItem.Click += new System.EventHandler(this.langrangePolynomToolStripMenuItem_Click);
            // 
            // newtonPolynomToolStripMenuItem
            // 
            this.newtonPolynomToolStripMenuItem.Name = "newtonPolynomToolStripMenuItem";
            this.newtonPolynomToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.newtonPolynomToolStripMenuItem.Text = "Многочлен Ньютона";
            this.newtonPolynomToolStripMenuItem.Click += new System.EventHandler(this.newtonPolynomToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btFinishPolynom
            // 
            this.btFinishPolynom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btFinishPolynom.Location = new System.Drawing.Point(989, 585);
            this.btFinishPolynom.Name = "btFinishPolynom";
            this.btFinishPolynom.Size = new System.Drawing.Size(204, 81);
            this.btFinishPolynom.TabIndex = 21;
            this.btFinishPolynom.Text = "Закінчити многочлен";
            this.btFinishPolynom.UseVisualStyleBackColor = true;
            this.btFinishPolynom.Click += new System.EventHandler(this.btFinishPolynom_Click);
            // 
            // btMoveCentre
            // 
            this.btMoveCentre.BackColor = System.Drawing.Color.White;
            this.btMoveCentre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btMoveCentre.BackgroundImage")));
            this.btMoveCentre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btMoveCentre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMoveCentre.Location = new System.Drawing.Point(865, 657);
            this.btMoveCentre.Name = "btMoveCentre";
            this.btMoveCentre.Size = new System.Drawing.Size(37, 35);
            this.btMoveCentre.TabIndex = 22;
            this.btMoveCentre.UseVisualStyleBackColor = false;
            this.btMoveCentre.Click += new System.EventHandler(this.btMoveCentre_Click);
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
            // BuildByGraphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 714);
            this.Controls.Add(this.btMoveCentre);
            this.Controls.Add(this.txtPtX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btFinishPolynom);
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
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "BuildByGraphic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Get The Polynom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuildByGraphic_FormClosing);
            this.Load += new System.EventHandler(this.LangrangePolynomial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBMain)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBMain;
        private System.Windows.Forms.TextBox txtPtX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPtY;
        private System.Windows.Forms.WebBrowser wbResult;
        private System.Windows.Forms.Button btZoomIn;
        private System.Windows.Forms.Button btZoomOut;
        private System.Windows.Forms.Button btMoveRight;
        private System.Windows.Forms.Button btMoveLeft;
        private System.Windows.Forms.Button btMoveUp;
        private System.Windows.Forms.Button btMoveDown;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem langrangePolynomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newtonPolynomToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btFinishPolynom;
        private System.Windows.Forms.Button btMoveCentre;
        private System.Windows.Forms.Timer timZoomIn;
        private System.Windows.Forms.Timer timZoomOut;
        private System.Windows.Forms.Timer timMoveLeft;
        private System.Windows.Forms.Timer timMoveRight;
        private System.Windows.Forms.Timer timMoveUp;
        private System.Windows.Forms.Timer timMoveDown;
    }
}


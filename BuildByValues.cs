using System;
using System.Drawing;
using System.Windows.Forms;

namespace GetThePolynom
{
    public partial class BuildByValues : Form
    {
        ValuesForBuild valuesForBuild;

        // Global variables
        Graphics gr;
        Bitmap bmp;

        CoordinateSystem coordSys;
        Polynom polynom;
        PointF[] newGraph;
        double[] graphDecardX;
        double[] graphDecardY;

        //int langpol = 0, newtpol = 1, chebpol = 2;
        PolynomialType polyType;

        // initializing components and Form_Load
        public BuildByValues(ValuesForBuild valuesForBuild, double[,] nodes, PolynomialType polynomialType)
        {
            InitializeComponent();
            this.valuesForBuild = valuesForBuild;

            graphDecardX = new double[nodes.GetLength(0)];
            graphDecardY = new double[nodes.GetLength(0)];
            for (int i = 0; i < nodes.GetLength(0); i++)
            {
                graphDecardX[i] = nodes[i, 0];
                graphDecardY[i] = nodes[i, 1];
            }

            polyType = polynomialType;
        }

        private void BuildByValues_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                valuesForBuild.Enabled = true;
                valuesForBuild.BringToFront();
                this.Close();
                this.Hide();
            }
        }

        private void BuildByValues_Load(object sender, EventArgs e)
        {
            coordSys = new CoordinateSystem(PBMain);
            bmp = new Bitmap(PBMain.Width, PBMain.Height);
            gr = Graphics.FromImage(bmp);
            
            newGraph = new PointF[graphDecardX.Length];
            for(int i = 0; i < graphDecardX.Length; i++)
            {
                newGraph[i].X = coordSys.XToContainer(graphDecardX[i]);
                newGraph[i].Y = coordSys.YToContainer(graphDecardY[i]);
            }

            // output polynomial and build graphic by this polynomial after setting point
            polynom = new Polynom(coordSys, polyType, new Pen(Color.Red, 3), points: newGraph);

            if (polynom.ContainerGraphic != null)
            {
                gr.DrawCurve(polynom.GraphicPen, polynom.ContainerGraphic);
                wbResult.DocumentText = polynom.PolynomHtml;
                PBMain.Image = bmp;
            }

            foreach (PointF pt in newGraph)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);
        }

        // Make graphic rebuiling (moving or zooming)
        private void btZoomOut_MouseDown(object sender, MouseEventArgs e)
        {
            timZoomOut.Start();
        }

        private void timZoomOut_Tick(object sender, EventArgs e)
        {
            coordSys.ZoomOut();
            gr.Clear(Color.Transparent);

            polynom.CoordSys = coordSys;
            gr.DrawCurve(polynom.GraphicPen, polynom.ContainerGraphic);
            foreach (PointF pt in polynom.Nodes)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

            PBMain.Image = bmp;

            if (coordSys.XRight - coordSys.XLeft >= coordSys.ZoomOutMax)
            {
                btZoomOut.Enabled = false;
                timZoomOut.Stop();
            }
            if (coordSys.XRight - coordSys.XLeft >= coordSys.ZoomInMax && btZoomIn.Enabled == false)
            {
                btZoomIn.Enabled = true;
            }
        }

        private void btZoomOut_MouseUp(object sender, MouseEventArgs e)
        {
            timZoomOut.Stop();
        }


        private void btZoomIn_MouseDown(object sender, MouseEventArgs e)
        {
            timZoomIn.Start();
        }

        private void timZoomIn_Tick(object sender, EventArgs e)
        {
            coordSys.ZoomIn();
            gr.Clear(Color.Transparent);

            polynom.CoordSys = coordSys;
            gr.DrawCurve(polynom.GraphicPen, polynom.ContainerGraphic);
            foreach (PointF pt in polynom.Nodes)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

            PBMain.Image = bmp;

            if (coordSys.XRight - coordSys.XLeft <= coordSys.ZoomInMax)
            {
                btZoomIn.Enabled = false;
                timZoomIn.Stop();
            }
            if (coordSys.XRight - coordSys.XLeft <= coordSys.ZoomOutMax && btZoomOut.Enabled == false)
            {
                btZoomOut.Enabled = true;
            }
        }

        private void btZoomIn_MouseUp(object sender, MouseEventArgs e)
        {
            timZoomIn.Stop();
        }


        private void btMoveRight_MouseDown(object sender, MouseEventArgs e)
        {
            timMoveRight.Start();
        }

        private void timMoveRight_Tick(object sender, EventArgs e)
        {
            coordSys.MoveRight();
            gr.Clear(Color.Transparent);

            polynom.CoordSys = coordSys;
            gr.DrawCurve(polynom.GraphicPen, polynom.ContainerGraphic);
            foreach (PointF pt in polynom.Nodes)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

            PBMain.Image = bmp;

            if (coordSys.XRight >= coordSys.XRightMax)
            {
                btMoveRight.Enabled = false;
                timMoveRight.Stop();
            }
            if (coordSys.XLeft >= coordSys.XLeftMin && btMoveLeft.Enabled == false)
            {
                btMoveLeft.Enabled = true;
            }
        }

        private void btMoveRight_MouseUp(object sender, MouseEventArgs e)
        {
            timMoveRight.Stop();
        }


        private void btMoveUp_MouseDown(object sender, MouseEventArgs e)
        {
            timMoveUp.Start();
        }

        private void timMoveUp_Tick(object sender, EventArgs e)
        {
            coordSys.MoveUp();
            gr.Clear(Color.Transparent);

            polynom.CoordSys = coordSys;
            gr.DrawCurve(polynom.GraphicPen, polynom.ContainerGraphic);
            foreach (PointF pt in polynom.Nodes)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

            PBMain.Image = bmp;

            if (coordSys.YUp >= coordSys.YUpMax)
            {
                btMoveUp.Enabled = false;
                timMoveUp.Stop();
            }
            if (coordSys.YDown >= coordSys.YDownMin && btMoveDown.Enabled == false)
            {
                btMoveDown.Enabled = true;
            }
        }

        private void btMoveUp_MouseUp(object sender, MouseEventArgs e)
        {
            timMoveUp.Stop();
        }


        private void btMoveLeft_MouseDown(object sender, MouseEventArgs e)
        {
            timMoveLeft.Start();
        }

        private void timMoveLeft_Tick(object sender, EventArgs e)
        {
            coordSys.MoveLeft();
            gr.Clear(Color.Transparent);

            polynom.CoordSys = coordSys;
            gr.DrawCurve(polynom.GraphicPen, polynom.ContainerGraphic);
            foreach (PointF pt in polynom.Nodes)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

            PBMain.Image = bmp;

            if (coordSys.XLeft <= coordSys.XLeftMin)
            {
                btMoveLeft.Enabled = false;
                timMoveLeft.Stop();
            }
            if (coordSys.XRight <= coordSys.XRightMax && btMoveRight.Enabled == false)
            {
                btMoveRight.Enabled = true;
            }
        }

        private void btMoveLeft_MouseUp(object sender, MouseEventArgs e)
        {
            timMoveLeft.Stop();
        }


        private void btMoveDown_MouseDown(object sender, MouseEventArgs e)
        {
            timMoveDown.Start();
        }

        private void timMoveDown_Tick(object sender, EventArgs e)
        {
            coordSys.MoveDown();
            gr.Clear(Color.Transparent);

            polynom.CoordSys = coordSys;
            gr.DrawCurve(polynom.GraphicPen, polynom.ContainerGraphic);
            foreach (PointF pt in polynom.Nodes)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

            PBMain.Image = bmp;

            if (coordSys.XRight >= coordSys.XRightMax)
            {
                btMoveRight.Enabled = false;
                timMoveRight.Stop();
            }
            if (coordSys.XLeft >= coordSys.XLeftMin && btMoveLeft.Enabled == false)
            {
                btMoveLeft.Enabled = true;
            }
        }

        private void btMoveDown_MouseUp(object sender, MouseEventArgs e)
        {
            timMoveDown.Stop();
        }


        private void btMoveCentre_Click(object sender, EventArgs e)
        {
            coordSys = new CoordinateSystem(PBMain);
            gr.Clear(Color.Transparent);

            polynom.CoordSys = coordSys;
            gr.DrawCurve(polynom.GraphicPen, polynom.ContainerGraphic);
            foreach (PointF pt in polynom.Nodes)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

            PBMain.Image = bmp;

            btZoomIn.Enabled = true;
            btZoomOut.Enabled = true;
            btMoveLeft.Enabled = true;
            btMoveRight.Enabled = true;
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace GetThePolynom
{
    public partial class SpeedByValues : Form
    {
        ValuesForSpeed valuesForSpeed;

        // Global variables
        Graphics gr;
        Bitmap bmp;

        CoordinateSystem coordSys;
        Polynom polynomLagrangeNew, polynomNewtonNew;
        Polynom polynomLagrange, polynomNewton;

        PointF[] newGraph, extraPoints;
        double[] graphDecardX, graphDecardY;
        double[] graphDecardXExtra, graphDecardYExtra;

        //timer
        Stopwatch stopwatch;
        double buildLagrange = 0, buildNewton = 0;
        double rebuildLagrange = 0, rebuildNewton = 0;


        // initializing components and Form_Load
        public SpeedByValues(ValuesForSpeed valuesForSpeed, double[,] nodes, double[,] nodesExtra)
        {
            InitializeComponent();
            this.valuesForSpeed = valuesForSpeed;

            graphDecardX = new double[nodes.GetLength(0)];
            graphDecardY = new double[nodes.GetLength(0)];
            for (int i = 0; i < nodes.GetLength(0); i++)
            {
                graphDecardX[i] = nodes[i, 0];
                graphDecardY[i] = nodes[i, 1];
            }

            graphDecardXExtra = new double[nodesExtra.GetLength(0)];
            graphDecardYExtra = new double[nodesExtra.GetLength(0)];
            for (int i = 0; i < nodesExtra.GetLength(0); i++)
            {
                graphDecardXExtra[i] = nodesExtra[i, 0];
                graphDecardYExtra[i] = nodesExtra[i, 1];
            }
        }

        private void SpeedByValues_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                valuesForSpeed.Enabled = true;
                valuesForSpeed.BringToFront();
                this.Close();
                this.Hide();
            }
        }

        private void SpeedByValues_Load(object sender, EventArgs e)
        {
            // creating main objects
            coordSys = new CoordinateSystem(PBMain);
            bmp = new Bitmap(PBMain.Width, PBMain.Height);
            gr = Graphics.FromImage(bmp);
            stopwatch = new Stopwatch();

            newGraph = new PointF[graphDecardX.Length];
            for (int i = 0; i < graphDecardX.Length; i++)
            {
                newGraph[i].X = coordSys.XToContainer(graphDecardX[i]);
                newGraph[i].Y = coordSys.YToContainer(graphDecardY[i]);
            }

            extraPoints = new PointF[graphDecardXExtra.Length];
            for (int i = 0; i < graphDecardXExtra.Length; i++)
            {
                extraPoints[i].X = coordSys.XToContainer(graphDecardXExtra[i]);
                extraPoints[i].Y = coordSys.YToContainer(graphDecardYExtra[i]);
            }


            stopwatch.Start();
            polynomLagrange = new Polynom(coordSys, PolynomialType.Lagrange, new Pen(Color.Red, 6), points: newGraph);
            stopwatch.Stop();
            buildLagrange = (double)stopwatch.ElapsedTicks / 10000;

            stopwatch.Restart();
            polynomNewton = new Polynom(coordSys, PolynomialType.Newton, new Pen(Color.Blue, 2), points: newGraph);
            stopwatch.Stop();
            buildNewton = (double)stopwatch.ElapsedTicks / 10000;


            gr.DrawCurve(polynomLagrange.GraphicPen, polynomLagrange.ContainerGraphic);
            gr.DrawCurve(polynomNewton.GraphicPen, polynomNewton.ContainerGraphic);


            polynomLagrangeNew = new Polynom(coordSys, PolynomialType.Lagrange, new Pen(Color.DeepPink, 6), points: newGraph);
            polynomNewtonNew = new Polynom(coordSys, PolynomialType.Newton, new Pen(Color.Cyan, 2), points: newGraph);


            string langInfo = "<span style='font-family: Arial, sans-serif; font-size: 18px;'><span style='color: #ff0000;'>Початковий Многочлен Лагранжа:</span><br>";
            langInfo += polynomLagrange.PolynomHtml + "<br>";
            langInfo += "Час побудови: " + buildLagrange.ToString() + "мс<br><br>";

            string newtInfo = "<span style='font-family: Arial, sans-serif; font-size: 18px;'><span style='color: #0000ff;'>Початковий Многочлен Ньютона:</span><br>";
            newtInfo += polynomNewton.PolynomHtml + "<br>";
            newtInfo += "Час побудови: " + buildNewton.ToString() + "мс<br><br>";


            stopwatch.Restart();
            polynomLagrangeNew.AddPoints(extraPoints);
            stopwatch.Stop();
            rebuildLagrange = (double)stopwatch.ElapsedTicks / 10000;

            stopwatch.Restart();
            polynomNewtonNew.AddPoints(extraPoints);
            stopwatch.Stop();
            rebuildNewton = (double)stopwatch.ElapsedTicks / 10000;

            gr.DrawCurve(polynomLagrangeNew.GraphicPen, polynomLagrangeNew.ContainerGraphic);
            gr.DrawCurve(polynomNewtonNew.GraphicPen, polynomNewtonNew.ContainerGraphic);


            langInfo += "<span style='color: #ff1493;'>Новий Многочлен Лагранжа:</span><br>";
            langInfo += polynomLagrangeNew.PolynomHtml + "<br>";
            langInfo += "Час перебудови: " + rebuildLagrange.ToString() + "мс</span>";

            newtInfo += "<span style='color: #00ffff;'>Новий Многочлен Ньютона:</span><br>";
            newtInfo += polynomNewtonNew.PolynomHtml + "<br>";
            newtInfo += "Час перебудови: " + rebuildNewton.ToString() + "мс</span>";

            string output = langInfo + "<br><br><br>" + newtInfo;
            wbResult.DocumentText = output;

            foreach (PointF pt in polynomLagrange.Nodes)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

            foreach (PointF pt in extraPoints)
                gr.FillEllipse(Brushes.Green, pt.X - 4, pt.Y - 4, 8, 8);

            PBMain.Image = bmp;
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

            if (polynomNewtonNew != null)
            {
                polynomLagrange.CoordSys = coordSys;
                gr.DrawCurve(polynomLagrange.GraphicPen, polynomLagrange.ContainerGraphic);

                polynomNewton.CoordSys = coordSys;
                gr.DrawCurve(polynomNewton.GraphicPen, polynomNewton.ContainerGraphic);

                polynomLagrangeNew.CoordSys = coordSys;
                gr.DrawCurve(polynomLagrangeNew.GraphicPen, polynomLagrangeNew.ContainerGraphic);

                polynomNewtonNew.CoordSys = coordSys;
                gr.DrawCurve(polynomNewtonNew.GraphicPen, polynomNewtonNew.ContainerGraphic);
            }


            for (int i = 0; i < graphDecardXExtra.Length; i++)
                gr.FillEllipse(Brushes.Green, coordSys.XToContainer(graphDecardXExtra[i]) - 4, coordSys.YToContainer(graphDecardYExtra[i]) - 4, 8, 8);

            for (int i = 0; i < graphDecardX.Length; i++)
                gr.FillEllipse(Brushes.Black, coordSys.XToContainer(graphDecardX[i]) - 4, coordSys.YToContainer(graphDecardY[i]) - 4, 8, 8);

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

            if (polynomNewtonNew != null)
            {
                polynomLagrange.CoordSys = coordSys;
                gr.DrawCurve(polynomLagrange.GraphicPen, polynomLagrange.ContainerGraphic);

                polynomNewton.CoordSys = coordSys;
                gr.DrawCurve(polynomNewton.GraphicPen, polynomNewton.ContainerGraphic);

                polynomLagrangeNew.CoordSys = coordSys;
                gr.DrawCurve(polynomLagrangeNew.GraphicPen, polynomLagrangeNew.ContainerGraphic);

                polynomNewtonNew.CoordSys = coordSys;
                gr.DrawCurve(polynomNewtonNew.GraphicPen, polynomNewtonNew.ContainerGraphic);
            }


            for (int i = 0; i < graphDecardXExtra.Length; i++)
                gr.FillEllipse(Brushes.Green, coordSys.XToContainer(graphDecardXExtra[i]) - 4, coordSys.YToContainer(graphDecardYExtra[i]) - 4, 8, 8);

            for (int i = 0; i < graphDecardX.Length; i++)
                gr.FillEllipse(Brushes.Black, coordSys.XToContainer(graphDecardX[i]) - 4, coordSys.YToContainer(graphDecardY[i]) - 4, 8, 8);

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

            if (polynomNewtonNew != null)
            {
                polynomLagrange.CoordSys = coordSys;
                gr.DrawCurve(polynomLagrange.GraphicPen, polynomLagrange.ContainerGraphic);

                polynomNewton.CoordSys = coordSys;
                gr.DrawCurve(polynomNewton.GraphicPen, polynomNewton.ContainerGraphic);

                polynomLagrangeNew.CoordSys = coordSys;
                gr.DrawCurve(polynomLagrangeNew.GraphicPen, polynomLagrangeNew.ContainerGraphic);

                polynomNewtonNew.CoordSys = coordSys;
                gr.DrawCurve(polynomNewtonNew.GraphicPen, polynomNewtonNew.ContainerGraphic);
            }


            for (int i = 0; i < graphDecardXExtra.Length; i++)
                gr.FillEllipse(Brushes.Green, coordSys.XToContainer(graphDecardXExtra[i]) - 4, coordSys.YToContainer(graphDecardYExtra[i]) - 4, 8, 8);

            for (int i = 0; i < graphDecardX.Length; i++)
                gr.FillEllipse(Brushes.Black, coordSys.XToContainer(graphDecardX[i]) - 4, coordSys.YToContainer(graphDecardY[i]) - 4, 8, 8);

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

            if (polynomNewtonNew != null)
            {
                polynomLagrange.CoordSys = coordSys;
                gr.DrawCurve(polynomLagrange.GraphicPen, polynomLagrange.ContainerGraphic);

                polynomNewton.CoordSys = coordSys;
                gr.DrawCurve(polynomNewton.GraphicPen, polynomNewton.ContainerGraphic);

                polynomLagrangeNew.CoordSys = coordSys;
                gr.DrawCurve(polynomLagrangeNew.GraphicPen, polynomLagrangeNew.ContainerGraphic);

                polynomNewtonNew.CoordSys = coordSys;
                gr.DrawCurve(polynomNewtonNew.GraphicPen, polynomNewtonNew.ContainerGraphic);
            }


            for (int i = 0; i < graphDecardXExtra.Length; i++)
                gr.FillEllipse(Brushes.Green, coordSys.XToContainer(graphDecardXExtra[i]) - 4, coordSys.YToContainer(graphDecardYExtra[i]) - 4, 8, 8);

            for (int i = 0; i < graphDecardX.Length; i++)
                gr.FillEllipse(Brushes.Black, coordSys.XToContainer(graphDecardX[i]) - 4, coordSys.YToContainer(graphDecardY[i]) - 4, 8, 8);

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

            if (polynomNewtonNew != null)
            {
                polynomLagrange.CoordSys = coordSys;
                gr.DrawCurve(polynomLagrange.GraphicPen, polynomLagrange.ContainerGraphic);

                polynomNewton.CoordSys = coordSys;
                gr.DrawCurve(polynomNewton.GraphicPen, polynomNewton.ContainerGraphic);

                polynomLagrangeNew.CoordSys = coordSys;
                gr.DrawCurve(polynomLagrangeNew.GraphicPen, polynomLagrangeNew.ContainerGraphic);

                polynomNewtonNew.CoordSys = coordSys;
                gr.DrawCurve(polynomNewtonNew.GraphicPen, polynomNewtonNew.ContainerGraphic);
            }


            for (int i = 0; i < graphDecardXExtra.Length; i++)
                gr.FillEllipse(Brushes.Green, coordSys.XToContainer(graphDecardXExtra[i]) - 4, coordSys.YToContainer(graphDecardYExtra[i]) - 4, 8, 8);

            for (int i = 0; i < graphDecardX.Length; i++)
                gr.FillEllipse(Brushes.Black, coordSys.XToContainer(graphDecardX[i]) - 4, coordSys.YToContainer(graphDecardY[i]) - 4, 8, 8);

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

            if (polynomNewtonNew != null)
            {
                polynomLagrange.CoordSys = coordSys;
                gr.DrawCurve(polynomLagrange.GraphicPen, polynomLagrange.ContainerGraphic);

                polynomNewton.CoordSys = coordSys;
                gr.DrawCurve(polynomNewton.GraphicPen, polynomNewton.ContainerGraphic);

                polynomLagrangeNew.CoordSys = coordSys;
                gr.DrawCurve(polynomLagrangeNew.GraphicPen, polynomLagrangeNew.ContainerGraphic);

                polynomNewtonNew.CoordSys = coordSys;
                gr.DrawCurve(polynomNewtonNew.GraphicPen, polynomNewtonNew.ContainerGraphic);
            }

            for (int i = 0; i < graphDecardXExtra.Length; i++)
                gr.FillEllipse(Brushes.Green, coordSys.XToContainer(graphDecardXExtra[i]) - 4, coordSys.YToContainer(graphDecardYExtra[i]) - 4, 8, 8);

            for (int i = 0; i < graphDecardX.Length; i++)
                gr.FillEllipse(Brushes.Black, coordSys.XToContainer(graphDecardX[i]) - 4, coordSys.YToContainer(graphDecardY[i]) - 4, 8, 8);

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

            if (polynomNewtonNew != null)
            {
                polynomLagrange.CoordSys = coordSys;
                gr.DrawCurve(polynomLagrange.GraphicPen, polynomLagrange.ContainerGraphic);

                polynomNewton.CoordSys = coordSys;
                gr.DrawCurve(polynomNewton.GraphicPen, polynomNewton.ContainerGraphic);

                polynomLagrangeNew.CoordSys = coordSys;
                gr.DrawCurve(polynomLagrangeNew.GraphicPen, polynomLagrangeNew.ContainerGraphic);

                polynomNewtonNew.CoordSys = coordSys;
                gr.DrawCurve(polynomNewtonNew.GraphicPen, polynomNewtonNew.ContainerGraphic);
            }


            for (int i = 0; i < graphDecardXExtra.Length; i++)
                gr.FillEllipse(Brushes.Green, coordSys.XToContainer(graphDecardXExtra[i]) - 4, coordSys.YToContainer(graphDecardYExtra[i]) - 4, 8, 8);

            for (int i = 0; i < graphDecardX.Length; i++)
                gr.FillEllipse(Brushes.Black, coordSys.XToContainer(graphDecardX[i]) - 4, coordSys.YToContainer(graphDecardY[i]) - 4, 8, 8);

            PBMain.Image = bmp;

            btZoomIn.Enabled = true;
            btZoomOut.Enabled = true;
            btMoveLeft.Enabled = true;
            btMoveRight.Enabled = true;
        }
    }
}

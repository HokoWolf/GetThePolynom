using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace GetThePolynom
{
    public partial class SpeedByGraphic : Form
    {
        SpeedChoice speedChoice;

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

        // doesn't matter now
        int count, countExtra;
        bool allow_start = false, allow_add_dots = false, graph_finish = true;


        // initializing components and Form_Load
        public SpeedByGraphic(SpeedChoice speedChoice)
        {
            InitializeComponent();
            this.speedChoice = speedChoice;
        }

        private void SpeedByGraphic_Load(object sender, EventArgs e)
        {
            coordSys = new CoordinateSystem(PBMain);
            bmp = new Bitmap(PBMain.Width, PBMain.Height);
            gr = Graphics.FromImage(bmp);

            stopwatch = new Stopwatch();

            lblStart.Visible = true;
            lblAddDots.Visible = false;
            lblFinish.Visible = false;

            btStart.Visible = true;
            btAddDots.Visible = false;
            btFinish.Visible = false;
            
            newGraph = new PointF[0];
            extraPoints = new PointF[0];
            graphDecardX = new double[0];
            graphDecardY = new double[0];
            graphDecardXExtra = new double[0];
            graphDecardYExtra = new double[0];
        }

        private void SpeedByGraphic_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                speedChoice.Enabled = true;
                speedChoice.BringToFront();
            }
        }

        // buttons events
        private void btStart_Click(object sender, EventArgs e)
        {
            gr.Clear(Color.Transparent);
            PBMain.Image = bmp;

            wbResult.DocumentText = "";
            txtPtX.Text = "";
            txtPtY.Text = "";
            count = -1;
            countExtra = -1;

            graph_finish = false;
            allow_start = true;

            btStart.Visible = false;
            btAddDots.Visible = true;
            btAddDots.Enabled = false;

            lblStart.Visible = false;
            lblAddDots.Visible = true;

            txtPtX.Text = "";
            txtPtY.Text = "";

            Array.Clear(newGraph, 0, newGraph.Length);
            Array.Resize(ref newGraph, 0);

            Array.Clear(extraPoints, 0, extraPoints.Length);
            Array.Resize(ref extraPoints, 0);

            Array.Clear(graphDecardX, 0, graphDecardX.Length);
            Array.Resize(ref graphDecardX, 0);

            Array.Clear(graphDecardY, 0, graphDecardY.Length);
            Array.Resize(ref graphDecardY, 0);

            Array.Clear(graphDecardXExtra, 0, graphDecardXExtra.Length);
            Array.Resize(ref graphDecardXExtra, 0);

            Array.Clear(graphDecardYExtra, 0, graphDecardYExtra.Length);
            Array.Resize(ref graphDecardYExtra, 0);

            count = 0;
            countExtra = 0;
        }

        private void btAddDots_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            polynomLagrange = new Polynom(coordSys, PolynomialType.Lagrange, new Pen(Color.Red, 6), points: newGraph);
            stopwatch.Stop();
            buildLagrange = (double)stopwatch.ElapsedTicks / 10000;

            stopwatch.Restart();
            polynomNewton = new Polynom(coordSys, PolynomialType.Newton, new Pen(Color.Blue, 2), points: newGraph);
            stopwatch.Stop();
            buildNewton = (double)stopwatch.ElapsedTicks / 10000;

            allow_start = false;
            allow_add_dots = true;
            btAddDots.Visible = false;
            btFinish.Visible = true;
            btFinish.Enabled = false;
        }

        private void btFinish_Click(object sender, EventArgs e)
        {
            if (!graph_finish)
            {
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

                allow_add_dots = false;
                graph_finish = true;
                btFinish.Visible = false;
                btStart.Visible = true;
                txtPtX.Text = "";
                txtPtY.Text = "";
            }
        }


        // pictureBox events
        private void PBMain_MouseMove(object sender, MouseEventArgs e)
        {
            // cursor navigation by coordinates
            if (!graph_finish)
            {
                txtPtX.Text = Math.Round(coordSys.XToDecard(e.X), 3).ToString();
                txtPtY.Text = Math.Round(coordSys.YToDecard(e.Y), 3).ToString();
            }
        }

        private void PBMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (allow_start)
            {
                count++;
                if (count > 1)
                    btAddDots.Enabled = true;

                Array.Resize(ref newGraph, count);
                newGraph[count - 1].X = e.X;
                newGraph[count - 1].Y = e.Y;
                gr.FillEllipse(Brushes.Black, newGraph[count - 1].X - 4, newGraph[count - 1].Y - 4, 8, 8);

                Array.Resize(ref graphDecardX, count);
                graphDecardX[count - 1] = coordSys.XToDecard(e.X);

                Array.Resize(ref graphDecardY, count);
                graphDecardY[count - 1] = coordSys.YToDecard(e.Y);

                PBMain.Image = bmp;
            }

            if (allow_add_dots)
            {
                countExtra++;
                if (countExtra > 0)
                    btFinish.Enabled = true;

                Array.Resize(ref extraPoints, countExtra);
                extraPoints[countExtra - 1].X = e.X;
                extraPoints[countExtra - 1].Y = e.Y;
                gr.FillEllipse(Brushes.Green, extraPoints[countExtra - 1].X - 4, extraPoints[countExtra - 1].Y - 4, 8, 8);

                Array.Resize(ref graphDecardXExtra, countExtra);
                graphDecardXExtra[countExtra - 1] = coordSys.XToDecard(e.X);

                Array.Resize(ref graphDecardYExtra, countExtra);
                graphDecardYExtra[countExtra - 1] = coordSys.YToDecard(e.Y);

                PBMain.Image = bmp;
            }
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

            if(polynomNewtonNew != null)
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

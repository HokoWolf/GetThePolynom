using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GetThePolynom
{
    // Основной код программы
    /*
     * The CoordinateSystem class is responsible for the coordinate plane
     * The polynomials themselves are objects of the Polynom class
     * The PolynomialType enumeration is responsible for the polynomial type
     */

    public partial class BuildByGraphic : Form
    {
        BuildChoice buildChoice;

        // Global variables
        Graphics gr;
        Bitmap bmp;

        CoordinateSystem coordSys;
        List<Polynom> polynoms;
        PointF[] newGraph;
        double[] graphDecardX;
        double[] graphDecardY;
        string name;

        // doesn't matter now
        int current = -1, count;
        float firstX, firstY;
        bool drawing_allow = false, graph_finish = true, move_point = false;

        //int langpol = 0, newtpol = 1, chebpol = 2;
        PolynomialType polyType;

        // initializing components and Form_Load
        public BuildByGraphic(BuildChoice buildChoice)
        {
            InitializeComponent();
            this.buildChoice = buildChoice;
        }

        private void LangrangePolynomial_Load(object sender, EventArgs e)
        {
            coordSys = new CoordinateSystem(PBMain);
            polynoms = new List<Polynom>();

            bmp = new Bitmap(PBMain.Width, PBMain.Height);
            gr = Graphics.FromImage(bmp);

            btFinishPolynom.Visible = false;
        }

        private void BuildByGraphic_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                buildChoice.Enabled = true;
                buildChoice.BringToFront();
            }
        }


        // Menu events
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gr.Clear(Color.Transparent);
            PBMain.Image = bmp;

            wbResult.DocumentText = "";
            txtPtX.Text = "";
            txtPtY.Text = "";

            polynoms.Clear();
            Array.Resize(ref newGraph, 0);
            Array.Resize(ref graphDecardX, 0);
            Array.Resize(ref graphDecardY, 0);
            count = -1;

            graph_finish = true;
            drawing_allow = false;
            move_point = false;
            btFinishPolynom.Visible = false;
        }

        private void langrangePolynomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int k = 1;
            foreach (Polynom pol in polynoms)
                if (pol.PolynomType == PolynomialType.Lagrange) k++;

            name = Microsoft.VisualBasic.Interaction.InputBox("Set name for new Polynom", "Create your polynom", "Lagrange" + k);

            if(name != "")
            {
                drawing_allow = true;
                graph_finish = false;
                move_point = false;
                current = -1;
                btFinishPolynom.Visible = true;

                txtPtX.Text = "";
                txtPtY.Text = "";

                polyType = PolynomialType.Lagrange;
                newGraph = new PointF[0];
                Array.Clear(newGraph, 0, newGraph.Length);
                Array.Resize(ref newGraph, 0);

                graphDecardX = new double[0];
                Array.Clear(graphDecardX, 0, graphDecardX.Length);
                Array.Resize(ref graphDecardX, 0);

                graphDecardY = new double[0];
                Array.Clear(graphDecardY, 0, graphDecardY.Length);
                Array.Resize(ref graphDecardY, 0);
                count = 0;
            }
        }

        private void newtonPolynomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int k = 1;
            foreach (Polynom pol in polynoms)
                if (pol.PolynomType == PolynomialType.Newton) k++;

            name = Microsoft.VisualBasic.Interaction.InputBox("Set name for new Polynom", "Create your polynom", "Newton" + k);

            if (name != "")
            {
                drawing_allow = true;
                graph_finish = false;
                move_point = false;
                current = -1;
                btFinishPolynom.Visible = true;

                txtPtX.Text = "";
                txtPtY.Text = "";

                polyType = PolynomialType.Newton;
                newGraph = new PointF[0];
                Array.Clear(newGraph, 0, newGraph.Length);
                Array.Resize(ref newGraph, 0);

                graphDecardX = new double[0];
                Array.Clear(graphDecardX, 0, graphDecardX.Length);
                Array.Resize(ref graphDecardX, 0);

                graphDecardY = new double[0];
                Array.Clear(graphDecardY, 0, graphDecardY.Length);
                Array.Resize(ref graphDecardY, 0);
                count = 0;
            }
        }

        private void btFinishPolynom_Click(object sender, EventArgs e)
        {
            // output polynomial and build graphic by this polynomial after setting point
            if (drawing_allow)
            {
                Random rand = new Random();
                int red, green, blue;
                while (true)
                {
                    red = rand.Next(255);
                    green = rand.Next(255);
                    blue = rand.Next(255);

                    if (red > 200 && green > 200 && blue > 200 &&
                        Math.Abs(red - green) < 10 && Math.Abs(red - blue) < 10 && Math.Abs(green - blue) < 10)
                        continue;
                    else
                        break;
                }

                polynoms.Add(new Polynom(coordSys, polyType, new Pen(Color.FromArgb(red, green, blue), 3), name, newGraph));

                if (polynoms[polynoms.Count() - 1].ContainerGraphic == null)
                {
                    polynoms.RemoveAt(polynoms.Count() - 1);
                    gr.Clear(Color.Transparent);
                    PBMain.Image = bmp;

                    foreach (Polynom pol in polynoms)
                    {
                        pol.CoordSys = coordSys;
                        gr.DrawCurve(pol.GraphicPen, pol.ContainerGraphic);
                        foreach (PointF pt in pol.Nodes)
                            gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

                        PBMain.Image = bmp;
                    }
                }
                else
                {
                    gr.DrawCurve(polynoms[polynoms.Count() - 1].GraphicPen, polynoms[polynoms.Count() - 1].ContainerGraphic);
                    wbResult.DocumentText += "<span style='font-family: Arial, sans-serif; font-size: 18px;'>" 
                        + polynoms[polynoms.Count() - 1].Name + " <span style='width: 30px; height: 20px; border: 1px solid black; background-color: rgb("
                        + polynoms[polynoms.Count() - 1].GraphicPen.Color.R + ", " + polynoms[polynoms.Count() - 1].GraphicPen.Color.G 
                        + ", " + polynoms[polynoms.Count() - 1].GraphicPen.Color.B + ");'></span>:</span><br>" + polynoms[polynoms.Count() - 1].PolynomHtml + "<br><br>";
                    Array.Resize(ref newGraph, 0);
                    Array.Resize(ref graphDecardX, 0);
                    Array.Resize(ref graphDecardY, 0);
                    count = 0;
                    PBMain.Image = bmp;
                }

                drawing_allow = false;
                graph_finish = true;
                txtPtX.Text = "";
                txtPtY.Text = "";
                btFinishPolynom.Visible = false;
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

            if (graph_finish != true)
            {
                for (int i = 0; i < newGraph.Length; i++)
                {
                    newGraph[i].X = coordSys.XToContainer(graphDecardX[i]);
                    newGraph[i].Y = coordSys.YToContainer(graphDecardY[i]);

                    gr.FillEllipse(Brushes.Black, newGraph[i].X - 4, newGraph[i].Y - 4, 8, 8);
                }
            }

            foreach (Polynom pol in polynoms)
            {
                pol.CoordSys = coordSys;
                gr.DrawCurve(pol.GraphicPen, pol.ContainerGraphic);
                foreach(PointF pt in pol.Nodes)
                    gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);
                
                PBMain.Image = bmp;
            }

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

            if (graph_finish != true)
            {
                for (int i = 0; i < newGraph.Length; i++)
                {
                    newGraph[i].X = coordSys.XToContainer(graphDecardX[i]);
                    newGraph[i].Y = coordSys.YToContainer(graphDecardY[i]);

                    gr.FillEllipse(Brushes.Black, newGraph[i].X - 4, newGraph[i].Y - 4, 8, 8);
                }
            }

            foreach (Polynom pol in polynoms)
            {
                pol.CoordSys = coordSys;
                gr.DrawCurve(pol.GraphicPen, pol.ContainerGraphic);
                foreach (PointF pt in pol.Nodes)
                    gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

                PBMain.Image = bmp;
            }

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

            if (graph_finish != true)
            {
                for (int i = 0; i < newGraph.Length; i++)
                {
                    newGraph[i].X = coordSys.XToContainer(graphDecardX[i]);
                    newGraph[i].Y = coordSys.YToContainer(graphDecardY[i]);

                    gr.FillEllipse(Brushes.Black, newGraph[i].X - 4, newGraph[i].Y - 4, 8, 8);
                }
            }

            foreach (Polynom pol in polynoms)
            {
                pol.CoordSys = coordSys;
                gr.DrawCurve(pol.GraphicPen, pol.ContainerGraphic);
                foreach (PointF pt in pol.Nodes)
                    gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);
                
                PBMain.Image = bmp;
            }

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

            if (graph_finish != true)
            {
                for (int i = 0; i < newGraph.Length; i++)
                {
                    newGraph[i].X = coordSys.XToContainer(graphDecardX[i]);
                    newGraph[i].Y = coordSys.YToContainer(graphDecardY[i]);

                    gr.FillEllipse(Brushes.Black, newGraph[i].X - 4, newGraph[i].Y - 4, 8, 8);
                }
            }

            foreach (Polynom pol in polynoms)
            {
                pol.CoordSys = coordSys;
                gr.DrawCurve(pol.GraphicPen, pol.ContainerGraphic);
                foreach (PointF pt in pol.Nodes)
                    gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

                PBMain.Image = bmp;
            }

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

            if (graph_finish != true)
            {
                for (int i = 0; i < newGraph.Length; i++)
                {
                    newGraph[i].X = coordSys.XToContainer(graphDecardX[i]);
                    newGraph[i].Y = coordSys.YToContainer(graphDecardY[i]);

                    gr.FillEllipse(Brushes.Black, newGraph[i].X - 4, newGraph[i].Y - 4, 8, 8);
                }
            }

            foreach (Polynom pol in polynoms)
            {
                pol.CoordSys = coordSys;
                gr.DrawCurve(pol.GraphicPen, pol.ContainerGraphic);
                foreach (PointF pt in pol.Nodes)
                    gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

                PBMain.Image = bmp;
            }

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

            if (graph_finish != true)
            {
                for (int i = 0; i < newGraph.Length; i++)
                {
                    newGraph[i].X = coordSys.XToContainer(graphDecardX[i]);
                    newGraph[i].Y = coordSys.YToContainer(graphDecardY[i]);

                    gr.FillEllipse(Brushes.Black, newGraph[i].X - 4, newGraph[i].Y - 4, 8, 8);
                }
            }

            foreach (Polynom pol in polynoms)
            {
                pol.CoordSys = coordSys;
                gr.DrawCurve(pol.GraphicPen, pol.ContainerGraphic);
                foreach (PointF pt in pol.Nodes)
                    gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

                PBMain.Image = bmp;
            }

            if (coordSys.YDown <= coordSys.YDownMin)
            {
                btMoveDown.Enabled = false;
                timMoveDown.Stop();
            }
            if (coordSys.YUp <= coordSys.YUpMax && btMoveUp.Enabled == false)
            {
                btMoveUp.Enabled = true;
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

            if (graph_finish != true)
            {
                for (int i = 0; i < newGraph.Length; i++)
                {
                    newGraph[i].X = coordSys.XToContainer(graphDecardX[i]);
                    newGraph[i].Y = coordSys.YToContainer(graphDecardY[i]);

                    gr.FillEllipse(Brushes.Black, newGraph[i].X - 4, newGraph[i].Y - 4, 8, 8);
                }
            }

            foreach (Polynom pol in polynoms)
            {
                pol.CoordSys = coordSys;
                gr.DrawCurve(pol.GraphicPen, pol.ContainerGraphic);
                foreach (PointF pt in pol.Nodes)
                    gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

                PBMain.Image = bmp;
            }

            btZoomIn.Enabled = true;
            btZoomOut.Enabled = true;
            btMoveLeft.Enabled = true;
            btMoveRight.Enabled = true;
        }



        // picturebox events
        private void PBLangrange_MouseClick(object sender, MouseEventArgs e)
        {
            if (drawing_allow && !move_point)
            {
                count++;
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
        }

        private void PBLangrange_MouseMove(object sender, MouseEventArgs e)
        {
            // cursor navigation by coordinates
            if (!graph_finish)
            {
                if ((!move_point && drawing_allow) || (!drawing_allow && move_point && e.Button == MouseButtons.Left))
                {
                    txtPtX.Text = Math.Round(coordSys.XToDecard(e.X), 3).ToString();
                    txtPtY.Text = Math.Round(coordSys.YToDecard(e.Y), 3).ToString();
                }
            }

            // point`s moving
            if (!graph_finish && move_point && e.Button == MouseButtons.Left)
            {
                gr.Clear(Color.Transparent);
                newGraph[current] = e.Location;

                foreach (PointF point in newGraph)
                    gr.FillEllipse(Brushes.Black, point.X - 4, point.Y - 4, 8, 8);

                PBMain.Image = bmp;
            }
        }

        private void PBLangrange_MouseDown(object sender, MouseEventArgs e)
        {
            // point`s moving allow
            if (!graph_finish && !drawing_allow)
            {
                current = -1;
                move_point = false;
                for (int i = 0; i < count; i++)
                {
                    if (Math.Abs(newGraph[i].X - e.X) < 5 && Math.Abs(newGraph[i].Y - e.Y) < 5)
                    {
                        current = i;
                        move_point = true;
                        firstX = newGraph[i].X;
                        firstY = newGraph[i].Y;
                        break;
                    }
                }
            }
        }
        
        private void PBLangrange_MouseUp(object sender, MouseEventArgs e)
        {
            if (!graph_finish && move_point)
            {
                // new coordinates confirmation and correcting
                try
                {
                    newGraph[current].X = coordSys.XToContainer(Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Set the coordinate X", "Confirm your changes",
                        Math.Round(coordSys.XToDecard(newGraph[current].X), 3).ToString())));

                    newGraph[current].Y = coordSys.YToContainer(Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Set the coordinate Y", "Confirm your changes",
                        Math.Round(coordSys.YToDecard(newGraph[current].Y), 3).ToString())));
                }
                catch (FormatException)
                {
                    newGraph[current].X = firstX;
                    newGraph[current].Y = firstY;
                }

                // graphic`s redrawing
                txtPtX.Text = "";
                txtPtY.Text = "";
                gr.Clear(Color.Transparent);

                foreach (PointF point in newGraph)
                    gr.FillEllipse(Brushes.Black, point.X - 4, point.Y - 4, 8, 8);

                PBMain.Image = bmp;
            }
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace GetThePolynom
{
    public partial class FaultByValues : Form
    {
        ValuesForFault valuesForFault;

        // Global variables
        Graphics gr;
        Bitmap bmp;
        CoordinateSystem coordSys;

        Polynom polynomLagrange;
        Polynom polynomNewton;

        PointF[] newGraph;
        double[] graphDecardX;
        double[] graphDecardY;

        string previousFunction;
        string previousFunctionHtml;
        double[,] funcOrigDec;
        PointF[] funcOrigCont;

        // initializing components and Form_Load
        public FaultByValues(ValuesForFault valuesForFault, double[,] nodes, string previousFunction)
        {
            InitializeComponent();
            this.valuesForFault = valuesForFault;
            this.previousFunction = previousFunction.Replace(Environment.NewLine, "");

            graphDecardX = new double[nodes.GetLength(0)];
            graphDecardY = new double[nodes.GetLength(0)];
            for (int i = 0; i < nodes.GetLength(0); i++)
            {
                graphDecardX[i] = nodes[i, 0];
                graphDecardY[i] = nodes[i, 1];
            }
        }

        private void FaultByValues_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                valuesForFault.Enabled = true;
                valuesForFault.BringToFront();
                this.Close();
                this.Hide();
            }
        }

        private void FaultByValues_Load(object sender, EventArgs e)
        {
            // creating main objects
            coordSys = new CoordinateSystem(PBMain);
            bmp = new Bitmap(PBMain.Width, PBMain.Height);
            gr = Graphics.FromImage(bmp);

            newGraph = new PointF[graphDecardX.Length];
            for (int i = 0; i < graphDecardX.Length; i++)
            {
                newGraph[i].X = coordSys.XToContainer(graphDecardX[i]);
                newGraph[i].Y = coordSys.YToContainer(graphDecardY[i]);
            }

            // output polynomial and build graphic by this polynomial after setting point
            polynomLagrange = new Polynom(coordSys, PolynomialType.Lagrange, new Pen(Color.Red, 6), points: newGraph);
            polynomNewton = new Polynom(coordSys, PolynomialType.Newton, new Pen(Color.Blue, 2), points: newGraph);

            if(polynomLagrange.ContainerGraphic != null || polynomNewton.ContainerGraphic != null)
            {
                if (polynomLagrange.ContainerGraphic != null)
                {
                    gr.DrawCurve(polynomLagrange.GraphicPen, polynomLagrange.ContainerGraphic);
                    PBMain.Image = bmp;
                }

                funcOrigDec = returnOriginalFunction(coordSys, previousFunction);
                funcOrigCont = returnContainerGraphic(coordSys, funcOrigDec);
                gr.DrawCurve(new Pen(Color.Green, 4), funcOrigCont);

                if (polynomNewton.ContainerGraphic != null)
                {
                    gr.DrawCurve(polynomNewton.GraphicPen, polynomNewton.ContainerGraphic);
                    PBMain.Image = bmp;
                }

                foreach (PointF pt in newGraph)
                    gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);


                // output into webBrowser
                previousFunctionHtml = returnHtmlPolynom(previousFunction);
                string output = "<span style='font-family: Arial, sans-serif; font-size: 18px;'><span style='color: #008000;'>Оригінальна функція:</span><br>";
                output += previousFunctionHtml + "<br><br>";
                output += "Вузли інтерполяції:<br>";

                string nodesStr = "";
                for (int i = 0; i < graphDecardX.Length; i++)
                {
                    nodesStr += "(" + graphDecardX[i] + "; " + graphDecardY[i] + ")<br>";
                }
                output += nodesStr + "<br><br>";

                output += "<span style='color: #ff0000;'>Многочлен Лагранжа</span> за цими вузлами:<br>" + polynomLagrange.PolynomHtml + "<br>";
                output += "Максимальна похибка:<br>" +
                    fault(previousFunction + "-(" + polynomLagrange.PolynomString + ")", graphDecardX.Min(), graphDecardX.Max()) + "<br><br>";

                output += "<span style='color: #0000ff;'>Многочлен Ньютона</span> за цими вузлами:<br>" + polynomNewton.PolynomHtml + "<br>";
                output += "Максимальна похибка:<br>" +
                    fault(previousFunction + "-(" + polynomNewton.PolynomString + ")", graphDecardX.Min(), graphDecardX.Max()) + "<br><br>";

                output += "</span>";
                wbResult.DocumentText = output;
            }
        }


        // functions for building original function and finding the fault
        double[,] returnOriginalFunction(CoordinateSystem coordSys, string polynomString)
        {
            int n = Convert.ToInt32(coordSys.XToContainer(20)) / 5;
            double h = Math.Round((double)40 / n, 3);
            double x = -20;
            double[,] func = new double[n, 2];

            for (int i = 0; i < n; i++)
            {
                func[i, 0] = x;

                double y;
                MathParser.Parser parser = new MathParser.Parser(MathParser.Mode.RAD);
                if (parser.Evaluate(polynomString.Replace("x", x.ToString())))
                    y = parser.Result;
                else
                {
                    y = 0;
                    MessageBox.Show("Функція була введена невірно!");
                    valuesForFault.Enabled = true;
                    valuesForFault.BringToFront();
                    this.Close();
                    this.Hide();
                    break;
                }

                if (y > coordSys.YUpMax + 10)
                    y = 100;
                if (y < coordSys.YDownMin - 10)
                    y = -100;

                func[i, 1] = y;
                x += Convert.ToSingle(h);
            }
            return func;
        }

        PointF[] returnContainerGraphic(CoordinateSystem coordSys, double[,] decartGraphic)
        {
            PointF[] func = new PointF[decartGraphic.GetLength(0)];
            for (int i = 0; i < func.Length; i++)
            {
                func[i].X = coordSys.XToContainer(decartGraphic[i, 0]);
                func[i].Y = coordSys.YToContainer(decartGraphic[i, 1]);
            }
            return func;
        }

        string returnHtmlPolynom(string polynom)
        {
            // prepearing for html
            polynom = polynom.Replace("+", " + ");

            bool isFirstMinus = polynom[0] == '-' ? true : false;
            polynom = polynom.Replace("-", " - ");
            if (isFirstMinus)
            {
                polynom = polynom.Substring(3);
                polynom = "-" + polynom;
            }

            polynom = "<span style='font-family: Arial, sans-serif; font-size: 18px;'>" + polynom + "</span>";
            return polynom;
        }

        double fault(string faultFunc, double xstart, double xfinish)
        {
            double fault = 0;
            int n = Convert.ToInt32(coordSys.XToContainer(xfinish)) / 5;
            double h = Math.Round((double) (xfinish - xstart) / (double)n, 3);
            double x = xstart;

            for (int i = 0; i < n; i++)
            {
                MathParser.Parser parser = new MathParser.Parser(MathParser.Mode.RAD);
                if (parser.Evaluate(faultFunc.Replace("x", x.ToString())))
                    fault = Math.Max((double)fault, (double)Math.Abs((double)parser.Result));

                x += Convert.ToSingle(h);
            }
            return Math.Round(fault, 6);
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

            polynomLagrange.CoordSys = coordSys;
            gr.DrawCurve(polynomLagrange.GraphicPen, polynomLagrange.ContainerGraphic);
            foreach (PointF pt in polynomLagrange.Nodes)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

            polynomNewton.CoordSys = coordSys;
            gr.DrawCurve(polynomNewton.GraphicPen, polynomNewton.ContainerGraphic);
            foreach (PointF pt in polynomNewton.Nodes)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

            funcOrigCont = returnContainerGraphic(coordSys, funcOrigDec);
            gr.DrawCurve(new Pen(Color.Green, 3), funcOrigCont);

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

            polynomLagrange.CoordSys = coordSys;
            gr.DrawCurve(polynomLagrange.GraphicPen, polynomLagrange.ContainerGraphic);
            foreach (PointF pt in polynomLagrange.Nodes)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

            polynomNewton.CoordSys = coordSys;
            gr.DrawCurve(polynomNewton.GraphicPen, polynomNewton.ContainerGraphic);
            foreach (PointF pt in polynomNewton.Nodes)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

            funcOrigCont = returnContainerGraphic(coordSys, funcOrigDec);
            gr.DrawCurve(new Pen(Color.Green, 3), funcOrigCont);

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

            polynomLagrange.CoordSys = coordSys;
            gr.DrawCurve(polynomLagrange.GraphicPen, polynomLagrange.ContainerGraphic);
            foreach (PointF pt in polynomLagrange.Nodes)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

            polynomNewton.CoordSys = coordSys;
            gr.DrawCurve(polynomNewton.GraphicPen, polynomNewton.ContainerGraphic);
            foreach (PointF pt in polynomNewton.Nodes)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

            funcOrigCont = returnContainerGraphic(coordSys, funcOrigDec);
            gr.DrawCurve(new Pen(Color.Green, 3), funcOrigCont);

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

            polynomLagrange.CoordSys = coordSys;
            gr.DrawCurve(polynomLagrange.GraphicPen, polynomLagrange.ContainerGraphic);
            foreach (PointF pt in polynomLagrange.Nodes)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

            polynomNewton.CoordSys = coordSys;
            gr.DrawCurve(polynomNewton.GraphicPen, polynomNewton.ContainerGraphic);
            foreach (PointF pt in polynomNewton.Nodes)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

            funcOrigCont = returnContainerGraphic(coordSys, funcOrigDec);
            gr.DrawCurve(new Pen(Color.Green, 3), funcOrigCont);

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

            polynomLagrange.CoordSys = coordSys;
            gr.DrawCurve(polynomLagrange.GraphicPen, polynomLagrange.ContainerGraphic);
            foreach (PointF pt in polynomLagrange.Nodes)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

            polynomNewton.CoordSys = coordSys;
            gr.DrawCurve(polynomNewton.GraphicPen, polynomNewton.ContainerGraphic);
            foreach (PointF pt in polynomNewton.Nodes)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

            funcOrigCont = returnContainerGraphic(coordSys, funcOrigDec);
            gr.DrawCurve(new Pen(Color.Green, 3), funcOrigCont);

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

            polynomLagrange.CoordSys = coordSys;
            gr.DrawCurve(polynomLagrange.GraphicPen, polynomLagrange.ContainerGraphic);
            foreach (PointF pt in polynomLagrange.Nodes)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

            polynomNewton.CoordSys = coordSys;
            gr.DrawCurve(polynomNewton.GraphicPen, polynomNewton.ContainerGraphic);
            foreach (PointF pt in polynomNewton.Nodes)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

            funcOrigCont = returnContainerGraphic(coordSys, funcOrigDec);
            gr.DrawCurve(new Pen(Color.Green, 3), funcOrigCont);

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

            polynomLagrange.CoordSys = coordSys;
            gr.DrawCurve(polynomLagrange.GraphicPen, polynomLagrange.ContainerGraphic);
            foreach (PointF pt in polynomLagrange.Nodes)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

            polynomNewton.CoordSys = coordSys;
            gr.DrawCurve(polynomNewton.GraphicPen, polynomNewton.ContainerGraphic);
            foreach (PointF pt in polynomNewton.Nodes)
                gr.FillEllipse(Brushes.Black, pt.X - 4, pt.Y - 4, 8, 8);

            funcOrigCont = returnContainerGraphic(coordSys, funcOrigDec);
            gr.DrawCurve(new Pen(Color.Green, 3), funcOrigCont);

            PBMain.Image = bmp;

            btZoomIn.Enabled = true;
            btZoomOut.Enabled = true;
            btMoveLeft.Enabled = true;
            btMoveRight.Enabled = true;
        }
    }
}

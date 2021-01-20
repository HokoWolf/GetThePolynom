using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GetThePolynom
{
    /*
     * The class that is responsible for the coordinate plane, its movement and zoom, as well as translation of coordinates (previous functions xtoi, ytoj, itox, jtoy)
     */
    public class CoordinateSystem
    {
        PictureBox pictureBox;
        Graphics graphics;
        Bitmap bitmap;
        double xLeft, xRight, yDown, yUp;
        double xLeftMin = -20, xRightMax = 20, yDownMin = -30, yUpMax = 30, zoomInMax = 3, zoomOutMax = 30; // zoomMax - diff between xRight and xLeft

        // Constructors
        private CoordinateSystem() { }

        public CoordinateSystem(PictureBox pct)
        {
            pictureBox = pct;
            xLeft = -7.5;
            xRight = 7.5;
            yDown = -5.5;
            yUp = 5.5;
            DrawCoordinateSystem(xLeft, xRight, yDown, yUp);
        }

        public CoordinateSystem(PictureBox pct, double x1, double x2, double y1, double y2)
        {
            pictureBox = pct;
            xLeft = x1;
            xRight = x2;
            yDown = y1;
            yUp = y2;
            DrawCoordinateSystem(xLeft, xRight, yDown, yUp);
        }

        
        // Properties
        public double XLeft
        {
            get
            {
                return xLeft;
            }
        }

        public double XRight
        {
            get
            {
                return xRight;
            }
        }

        public double YUp
        {
            get
            {
                return yUp;
            }
        }

        public double YDown
        {
            get
            {
                return yDown;
            }
        }

        public double XLeftMin
        {
            get
            {
                return xLeftMin;
            }
        }

        public double XRightMax
        {
            get
            {
                return xRightMax;
            }
        }

        public double YDownMin
        {
            get
            {
                return yDownMin;
            }
        }

        public double YUpMax
        {
            get
            {
                return yUpMax;
            }
        }

        public double ZoomInMax
        {
            get
            {
                return zoomInMax;
            }
        }

        public double ZoomOutMax
        {
            get
            {
                return zoomOutMax;
            }
        }


        // Convertation
        public float XToContainer(double x)
        {
            float ii;
            ii = (int)((x - xLeft) * ((pictureBox.Width - 1) / (xRight - xLeft)));
            return ii;
        }

        public float YToContainer(double y)
        {
            float jj;
            jj = (pictureBox.Height - 1) + (int)((y - yDown) * (1 - pictureBox.Height) / (yUp - yDown));
            return jj;
        }

        public double XToDecard(float i)
        {
            double xx;
            xx = (double)(xLeft + i * (xRight - xLeft) / (pictureBox.Width - 1));

            if (XToContainer(Math.Round(xx)) == i)
                return Math.Round(xx);
            else
                return xx;
        }

        public double YToDecard(float j)
        {
            double yy;
            yy = (double)(yDown + (j - (pictureBox.Height - 1)) * (yUp - yDown) / (1 - pictureBox.Height));

            if (YToContainer(Math.Round(yy)) == j)
                return Math.Round(yy);
            else
                return yy;
        }


        // Drawing
        void DrawCoordinateSystem (double x1, double x2, double y1, double y2)
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            Pen pen_setka = new Pen(Brushes.LightGray, 1);
            pen_setka.DashStyle = DashStyle.Dash;

            for (int p = (int)x1; p <= (int)x2; p++)
                graphics.DrawLine(pen_setka, XToContainer(p), YToContainer(y2), XToContainer(p), YToContainer(y1));
            for (int p = (int)y1; p <= (int)y2; p++)
                graphics.DrawLine(pen_setka, XToContainer(x1), YToContainer(p), XToContainer(x2), YToContainer(p));

            Pen pen_os = new Pen(Brushes.DarkGray, 1);
            pen_os.EndCap = LineCap.ArrowAnchor;
            pen_os.StartCap = LineCap.Triangle;

            graphics.DrawLine(pen_os, XToContainer(x1), YToContainer(0), XToContainer(x2), YToContainer(0));
            graphics.DrawLine(pen_os, XToContainer(0), YToContainer(y1), XToContainer(0), YToContainer(y2));

            Font koord_numbers = new Font("arial", 8, FontStyle.Regular);
            for (int p = 1; p <= x2; p++)
                graphics.DrawString(Convert.ToString(p), koord_numbers, Brushes.DarkBlue, new PointF(XToContainer(p - 0.2), YToContainer(-0.05)));
            for (int p = -1; p >= x1; p--)
                graphics.DrawString(Convert.ToString(p), koord_numbers, Brushes.DarkBlue, new PointF(XToContainer(p - 0.2), YToContainer(-0.05)));
            for (int p = 0; p <= y2; p++)
                graphics.DrawString(Convert.ToString(p), koord_numbers, Brushes.DarkBlue, new PointF(XToContainer(-0.5), YToContainer(p + 0.1)));
            for (int p = -1; p >= y1; p--)
                graphics.DrawString(Convert.ToString(p), koord_numbers, Brushes.DarkBlue, new PointF(XToContainer(-0.6), YToContainer(p + 0.1)));

            pictureBox.BackgroundImage = bitmap;
        }

        public void Clear()
        {
            graphics.Clear(Color.White);
            pictureBox.BackgroundImage = bitmap;
        }

        public void ZoomIn()
        {
            xLeft += 0.075;
            xRight -= 0.075;
            yDown += 0.055;
            yUp -= 0.055;
            DrawCoordinateSystem(xLeft, xRight, yDown, yUp);
        }

        public void ZoomOut()
        {
            xLeft -= 0.075;
            xRight += 0.075;
            yDown -= 0.055;
            yUp += 0.055;
            DrawCoordinateSystem(xLeft, xRight, yDown, yUp);
        }

        public void MoveLeft()
        {
            xLeft -= 0.05;
            xRight -= 0.05;
            DrawCoordinateSystem(xLeft, xRight, yDown, yUp);
        }

        public void MoveRight()
        {
            xLeft += 0.05;
            xRight += 0.05;
            DrawCoordinateSystem(xLeft, xRight, yDown, yUp);
        }

        public void MoveDown()
        {
            yDown -= 0.05;
            yUp -= 0.05;
            DrawCoordinateSystem(xLeft, xRight, yDown, yUp);
        }

        public void MoveUp()
        {
            yDown += 0.05;
            yUp += 0.05;
            DrawCoordinateSystem(xLeft, xRight, yDown, yUp);
        }
    }
}

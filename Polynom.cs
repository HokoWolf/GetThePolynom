using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GetThePolynom
{
    /*
     * The class whose object is the polynomial itself 
     * (its nodes and graph in Cartesian and computer coordinate systems, name and color,
     * and polynomial in plain text and in HTML form for nice output)
     */
    public class Polynom
    {
        PointF[] containerGraphic, containerNodes;
        double[,] decartGraphic, decartNodes;
        double[] polynomCoeffs, polynomPartsCoeffs;
        string polynomString, polynomHtml, name;
        
        PolynomialType polynomType;
        CoordinateSystem coordSys;
        Pen graphicPen;


        // Constructors
        private Polynom() { }

        // Main Constructor
        public Polynom(CoordinateSystem coordinates, PolynomialType type, Pen pen, string str = "", params PointF[] points)
        {
            coordSys = coordinates;
            polynomType = type;
            name = str;
            graphicPen = pen;
            
            containerNodes = new PointF[points.Length];
            Array.Copy(points, containerNodes, containerNodes.Length);

            decartNodes = new double[points.Length, 2];
            for (int i = 0; i < points.Length; i++)
            {
                decartNodes[i, 0] = coordSys.XToDecard(points[i].X);
                decartNodes[i, 1] = coordSys.YToDecard(points[i].Y);
            }

            switch (polynomType)
            {
                case PolynomialType.Lagrange:
                    polynomCoeffs = returnLagrangePolynomial(containerNodes);
                    break;
                case PolynomialType.Newton:
                    (polynomCoeffs, polynomPartsCoeffs) = returnNewtonPolynomial(containerNodes);
                    break;
                default:
                    break;
            }

            if(polynomCoeffs != null)
            {
                polynomString = returnStringPolynom(polynomCoeffs);
                polynomHtml = returnHtmlPolynom(polynomString, containerNodes.Length - 1);
            }

            if (polynomString != null)
            {
                decartGraphic = returnFunction(coordSys, polynomString);
                containerGraphic = returnContainerGraphic(coordSys, decartGraphic);
            }
        }


        // Properties
        public PointF[] Nodes
        {
            get
            {
                return containerNodes;
            }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    for (int j = value.Length - 1; j > i; j--)
                    {
                        if (value[j].X < value[j - 1].X)
                        {
                            PointF t = value[j];
                            value[j] = value[j - 1];
                            value[j - 1] = t;
                        }
                    }
                }

                containerNodes = new PointF[value.Length];
                Array.Copy(value, containerNodes, containerNodes.Length);

                decartNodes = new double[value.Length, 2];
                for (int i = 0; i < value.Length; i++)
                {
                    decartNodes[i, 0] = coordSys.XToDecard(value[i].X);
                    decartNodes[i, 1] = coordSys.YToDecard(value[i].Y);
                }

                switch (polynomType)
                {
                    case PolynomialType.Lagrange:
                        polynomCoeffs = returnLagrangePolynomial(containerNodes);
                        break;
                    case PolynomialType.Newton:
                        (polynomCoeffs, polynomPartsCoeffs) = returnNewtonPolynomial(containerNodes);
                        break;
                    default:
                        break;
                }

                polynomString = returnStringPolynom(polynomCoeffs);
                polynomHtml = returnHtmlPolynom(polynomString, containerNodes.Length - 1);
                if (polynomString != "")
                {
                    decartGraphic = returnFunction(coordSys, polynomString);
                    containerGraphic = returnContainerGraphic(coordSys, decartGraphic);
                }
            }
        }

        public double[] PolynomCoeffs
        {
            get
            {
                return polynomCoeffs;
            }
        }

        public string PolynomString
        {
            get
            {
                return polynomString;
            }
        }

        public string PolynomHtml
        {
            get
            {
                return polynomHtml;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public PolynomialType PolynomType
        {
            get
            {
                return polynomType;
            }
            set
            {
                polynomType = value;

                switch (polynomType)
                {
                    case PolynomialType.Lagrange:
                        polynomCoeffs = returnLagrangePolynomial(containerNodes);
                        break;
                    case PolynomialType.Newton:
                        (polynomCoeffs, polynomPartsCoeffs) = returnNewtonPolynomial(containerNodes);
                        break;
                    default:
                        break;
                }

                polynomString = returnStringPolynom(polynomCoeffs);
                polynomHtml = returnHtmlPolynom(polynomString, containerNodes.Length - 1);
                if (polynomString != "")
                {
                    decartGraphic = returnFunction(coordSys, polynomString);
                    containerGraphic = returnContainerGraphic(coordSys, decartGraphic);
                }
            }
        }

        public PointF[] ContainerGraphic
        {
            get
            {
                return containerGraphic;
            }
        }

        public double[,] DecardGraphic
        {
            get
            {
                return decartGraphic;
            }
        }

        public CoordinateSystem CoordSys
        {
            set
            {
                coordSys = value;

                if (polynomString != "")
                {
                    for (int i = 0; i < containerNodes.Length; i++)
                    {
                        containerNodes[i].X = coordSys.XToContainer(decartNodes[i, 0]);
                        containerNodes[i].Y = coordSys.YToContainer(decartNodes[i, 1]);
                    }
                    containerGraphic = returnContainerGraphic(coordSys, decartGraphic);
                }
            }
        }

        public Pen GraphicPen
        {
            get
            {
                return graphicPen;
            }
            set
            {
                graphicPen = value;
            }
        }


        // mathematician functions for getting polynomials
        double[] returnLagrangePolynomial(PointF[] pt)
        {
            try
            {
                if (pt.Length < 2)
                {
                    throw new Exception("Недостатньо точок (потрібно як мінімум 2)");
                }

                int k = 0;
                for(int i = 1; i < pt.Length; i++)
                    if (pt[0].X == pt[i].X) k++;

                if (k >= pt.Length - 1)
                {
                    throw new Exception("Усі X в заданих точках рівні => вирішення поставленої задачі: x = " +
                        Math.Round(coordSys.XToDecard(pt[0].X), 3) + ", і це рішення не є многочленом потрібного виду!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            double[] coeffs = new double[pt.Length];
            int count = 0;
            double[,] factors = new double[pt.Length, pt.Length - 1];

            // counting coefficients before each bracket like {K}*(x-1)(x-2) and determination of all factors
            for (int i = 0; i < pt.Length; i++)
            {
                double xi, yi;
                xi = coordSys.XToDecard(pt[i].X);
                yi = coordSys.YToDecard(pt[i].Y);

                double coef = yi;

                int q = 0;
                for (int j = 0; j < pt.Length; j++)
                {
                    if (j != i)
                    {
                        double xj = -1 * coordSys.XToDecard(pt[j].X);
                        coef /= (xi + xj);
                        factors[count, q] = xj;
                        q++;
                    }
                }

                coeffs[count] = coef;
                count++;
            }

            double[] final_coeffs = new double[pt.Length];
            // counting coefs
            for(int i = 0; i < pt.Length; i++)
            {
                for(int j = 0; j < Math.Pow(2, pt.Length - 1); j++)
                {
                    string combination = Convert.ToString(j, 2).PadLeft(pt.Length - 1, '0');
                    int q = 0;
                    double p = 1;
                    for(int k = 0; k < pt.Length - 1; k++)
                    {
                        if (combination[k] == '0') q++;
                        else p *= factors[i, k];
                    }
                    final_coeffs[q] += (p * coeffs[i]);
                }
            }

            for(int i = 0; i < final_coeffs.Length; i++)
                final_coeffs[i] = Math.Round(final_coeffs[i], 3);
            
            return final_coeffs;
        }

        (double[], double[]) returnNewtonPolynomial(PointF[] pt)
        {
            try
            {
                if (pt.Length < 2)
                {
                    throw new Exception("Недостатньо точок (потрібно як мінімум 2)");
                }

                int k = 0;
                for (int i = 1; i < pt.Length; i++)
                    if (pt[0].X == pt[i].X) k++;

                if (k >= pt.Length - 1)
                {
                    throw new Exception("Усі X в заданих точках рівні => вирішення поставленої задачі: x = " +
                        Math.Round(coordSys.XToDecard(pt[0].X), 3) + ", і це рішення не є многочленом потрібного виду!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (null, null);
            }

            double[] coeffs = new double[pt.Length];

            for (int i = 0; i < coeffs.Length; i++)
            {
                for(int k = 0; k <= i; k++)
                {
                    double c = coordSys.YToDecard(pt[k].Y);
                    for(int j = 0; j <= i; j++)
                        if (j != k) c /= (coordSys.XToDecard(pt[k].X) - coordSys.XToDecard(pt[j].X));

                    coeffs[i] += c;
                }
            }

            double[] final_coeffs = new double[pt.Length];
            // counting coefs
            final_coeffs[0] = coeffs[0] + coeffs[1] * (-1) * coordSys.XToDecard(pt[0].X);
            final_coeffs[1] = coeffs[1];

            for(int i = 2; i < coeffs.Length; i++)
            {
                for (int j = 0; j < Math.Pow(2, i); j++)
                {
                    string combination = Convert.ToString(j, 2).PadLeft(i, '0'); ;
                    int q = 0;
                    double p = 1;
                    for (int k = 0; k < i; k++)
                    {
                        if (combination[k] == '0') q++;
                        else p *= (coordSys.XToDecard(pt[k].X) * (-1));
                    }
                    final_coeffs[q] += (p * coeffs[i]);
                }
            }

            for (int i = 0; i < final_coeffs.Length; i++)
                final_coeffs[i] = Math.Round(final_coeffs[i], 3);

            return (final_coeffs, coeffs);
        }

        string returnStringPolynom(double[] coeffs)
        {
            string polynom = "";

            for (int i = coeffs.Length - 1; i >= 0; i--)
            {
                if (coeffs[i] == 1 && i > 0)
                    polynom += "x^" + i + "+";
                else if (coeffs[i] == -1 && i > 0)
                    polynom += "-x^" + i + "+";
                else if (coeffs[i] != 0)
                    polynom += coeffs[i] + "*x^" + i + "+";
            }

            if (polynom == "") polynom = "0+";
            polynom = polynom.Remove(polynom.Length - 1);
            polynom = polynom.Replace("+-", "-");
            polynom = polynom.Replace("*x^0", "");
            polynom = polynom.Replace("x^1", "x");
            return polynom;
        }

        string returnHtmlPolynom(string polynom, int exponent)
        {
            // prepearing for html
            polynom = polynom.Replace("*", "");
            polynom = polynom.Replace("+", " + ");

            bool isFirstMinus = polynom[0] == '-' ? true : false;
            polynom = polynom.Replace("-", " - ");
            if (isFirstMinus)
            {
                polynom = polynom.Substring(3);
                polynom = "-" + polynom;
            }

            for (int i = exponent; i >= 2; i--)
            {
                string st = "^" + i;
                if (polynom.Contains(st))
                {
                    string st_replace = "<sup>" + i + "</sup>";
                    polynom = polynom.Replace(st, st_replace);
                }
            }
            polynom = "<span style='font-family: Arial, sans-serif; font-size: 18px;'>" + polynom + "</span>";
            return polynom;
        }

        /// <summary>
        /// Build graphics by the txtResult.Text polynomial
        /// </summary>
        double[,] returnFunction(CoordinateSystem coordSys, string polynomString)
        {
            int n = Convert.ToInt32(coordSys.XToContainer(20)) / 5;
            double h = Math.Round((double)40 / n, 3);
            double x = -20;
            double[,] func = new double[n, 2];

            for (int i = 0; i < n; i++)
            {
                func[i, 0] = x;

                double y = 0;
                for(int j = polynomCoeffs.Length - 1; j >= 0; j--)
                {
                    y += polynomCoeffs[j] * Math.Pow(x, j);
                }

                if (y > coordSys.YUpMax + 10000)
                    y = 100000;
                if (y < coordSys.YDownMin - 100000)
                    y = -100000;

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

        public void AddPoints(params PointF[] extraNodes)
        {
            switch (polynomType)
            {
                case PolynomialType.Lagrange:
                    #region
                    containerNodes = containerNodes.Concat(extraNodes).ToArray();

                    decartNodes = new double[containerNodes.Length, 2];
                    for (int i = 0; i < containerNodes.Length; i++)
                    {
                        decartNodes[i, 0] = coordSys.XToDecard(containerNodes[i].X);
                        decartNodes[i, 1] = coordSys.YToDecard(containerNodes[i].Y);
                    }

                    polynomCoeffs = returnLagrangePolynomial(containerNodes);
                    polynomString = returnStringPolynom(polynomCoeffs);
                    polynomHtml = returnHtmlPolynom(polynomString, containerNodes.Length - 1);
                    if (polynomString != "")
                    {
                        decartGraphic = returnFunction(coordSys, polynomString);
                        containerGraphic = returnContainerGraphic(coordSys, decartGraphic);
                    }
                    #endregion
                    break;

                case PolynomialType.Newton:
                    #region
                    containerNodes = containerNodes.Concat(extraNodes).ToArray();
                    Array.Resize(ref polynomPartsCoeffs, polynomPartsCoeffs.Length + extraNodes.Length);
                    Array.Resize(ref polynomCoeffs, polynomCoeffs.Length + extraNodes.Length);

                    decartNodes = new double[containerNodes.Length, 2];
                    for (int i = 0; i < containerNodes.Length; i++)
                    {
                        decartNodes[i, 0] = coordSys.XToDecard(containerNodes[i].X);
                        decartNodes[i, 1] = coordSys.YToDecard(containerNodes[i].Y);
                    }

                    for (int i = containerNodes.Length - extraNodes.Length; i < containerNodes.Length; i++)
                    {
                        for (int k = 0; k <= i; k++)
                        {
                            double c = coordSys.YToDecard(containerNodes[k].Y);
                    
                            for (int j = 0; j <= i; j++)
                                if (j != k) c /= (coordSys.XToDecard(containerNodes[k].X) - coordSys.XToDecard(containerNodes[j].X));
                    
                            polynomPartsCoeffs[i] += c;
                        }
                    }

                    for (int i = polynomPartsCoeffs.Length - extraNodes.Length; i < polynomPartsCoeffs.Length; i++)
                    {
                        for (int j = 0; j < Math.Pow(2, i); j++)
                        {
                            string combination = Convert.ToString(j, 2).PadLeft(i, '0'); ;
                            int q = 0;
                            double p = 1;
                            for (int k = 0; k < i; k++)
                            {
                                if (combination[k] == '0') q++;
                                else p *= (coordSys.XToDecard(containerNodes[k].X) * (-1));
                            }
                            polynomCoeffs[q] += (p * polynomPartsCoeffs[i]);
                        }
                    }

                    for (int i = 0; i < polynomCoeffs.Length; i++)
                        polynomCoeffs[i] = Math.Round(polynomCoeffs[i], 3);

                    //(polynomCoeffs, polynomPartsCoeffs) = returnNewtonPolynomial(containerNodes);

                    polynomString = returnStringPolynom(polynomCoeffs);
                    polynomHtml = returnHtmlPolynom(polynomString, containerNodes.Length - 1);
                    if (polynomString != "")
                    {
                        decartGraphic = returnFunction(coordSys, polynomString);
                        containerGraphic = returnContainerGraphic(coordSys, decartGraphic);
                    }
                    #endregion
                    break;
                default:
                    break;
            }
        }
    }
}

using System;
using System.Windows.Forms;
using System.Globalization;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot.Axes; 
using NCalc;

namespace Calculator_Project
{
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();

            if (this.plotView != null)
            {
                var plotModel = new PlotModel { Title = "Graph" };

                
                plotModel.Axes.Add(new LinearAxis
                {
                    Position = AxisPosition.Bottom,
                    Minimum = -50,
                    Maximum = 50,
                    Title = "X",
                    MajorGridlineStyle = LineStyle.Solid, 
                    MinorGridlineStyle = LineStyle.Dot    
                });

                
                plotModel.Axes.Add(new LinearAxis
                {
                    Position = AxisPosition.Left,
                    Minimum = -50,
                    Maximum = 50,
                    Title = "Y",
                    MajorGridlineStyle = LineStyle.Solid, 
                    MinorGridlineStyle = LineStyle.Dot    
                });

                this.plotView.Model = plotModel;
            }

            this.Text = "Function Plotter";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BtnPlot_Click(object sender, EventArgs e)
        {
            string exprText = txtExpression.Text;
            if (string.IsNullOrWhiteSpace(exprText))
            {
                MessageBox.Show("Enter a valid expression (e.g., Sin(x) or x^2)");
                return;
            }

            try
            {
                
                double minX = -50;  
                double maxX = 50;   
                
                int numberOfPoints = 2000;

                double[] xs = new double[numberOfPoints];
                double[] ys = new double[numberOfPoints];
                double step = (maxX - minX) / (numberOfPoints - 1);

                for (int i = 0; i < xs.Length; i++)
                {
                    xs[i] = minX + i * step;
                }

                Func<double, double> evaluate = CreateEvaluator(exprText);

                for (int i = 0; i < xs.Length; i++)
                {
                    ys[i] = evaluate(xs[i]);
                }

                var lineSeries = new LineSeries { Title = exprText, StrokeThickness = 2 }; 
                for (int i = 0; i < xs.Length; i++)
                {
                    if (!double.IsNaN(ys[i]) && !double.IsInfinity(ys[i]))
                    {
                        lineSeries.Points.Add(new DataPoint(xs[i], ys[i]));
                    }
                }

                
                if (plotView.Model == null)
                {
                    
                    plotView.Model = new PlotModel();
                    
                    plotView.Model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Minimum = -50, Maximum = 50, Title = "X", MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot });
                    plotView.Model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Minimum = -50, Maximum = 50, Title = "Y", MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot });
                }

                plotView.Model.Series.Clear(); 
                plotView.Model.Title = $"y = {exprText}";
                plotView.Model.Series.Add(lineSeries);
                plotView.InvalidatePlot(true); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error evaluating or plotting expression:\n" + ex.Message);
            }
        }

        private Func<double, double> CreateEvaluator(string expressionString)
        {
            try
            {
                Expression expression = new Expression(expressionString, EvaluateOptions.IgnoreCase);

                expression.EvaluateFunction += (name, args) =>
                {
                    string lowerName = name.ToLower();
                    if (args.Parameters.Length == 1)
                    {
                        double val = Convert.ToDouble(args.EvaluateParameters()[0], CultureInfo.InvariantCulture);
                        switch (lowerName)
                        {
                            case "sinh": args.Result = Math.Sinh(val); break;
                            case "cosh": args.Result = Math.Cosh(val); break;
                            case "tanh": args.Result = Math.Tanh(val); break;
                            case "asinh": args.Result = Math.Asinh(val); break;
                            case "acosh": args.Result = Math.Acosh(val); break;
                            case "atanh": args.Result = Math.Atanh(val); break;
                            case "ln": args.Result = Math.Log(val); break;
                        }
                    }
                };

                if (expression.HasErrors())
                {
                    throw new ArgumentException("Expression has syntax errors: " + expression.Error);
                }

                return (x_val) =>
                {
                    expression.Parameters["x"] = x_val;
                    try
                    {
                        object result = expression.Evaluate();
                        return Convert.ToDouble(result, CultureInfo.InvariantCulture);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error evaluating NCalc expression for x={x_val} ('{expressionString}'): {ex.Message}");
                        return double.NaN;
                    }
                };
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Invalid expression syntax or setup ('{expressionString}'): {ex.Message}", ex);
            }
        }
    }
}
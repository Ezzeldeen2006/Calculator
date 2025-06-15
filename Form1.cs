using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;



namespace Calculator_Project
{
    public partial class Form1 : Form
    {
        double firstnum, secondnum;
        string operation;
        bool opPressed;
        bool isInverse;
        public Form1()
        {
            InitializeComponent();
            opPressed = false;
            isInverse = false;
        }

        private void PressingNum(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            if (Resulttext.Text == "0")
                Resulttext.Text = "";
            {
                if (x.Text == ".")
                {
                    if (!Resulttext.Text.Contains("."))
                        Resulttext.Text = Resulttext.Text + x.Text;

                }
                else
                {
                    Resulttext.Text = Resulttext.Text + x.Text;
                }
            }

        }

        private void Operations(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Resulttext.Text) || Resulttext.Text == "0")
                {
                    MessageBox.Show("Cannot enter an operator as the first input");
                    return;
                }

                if (opPressed == false)
                {
                    opPressed = true;
                    try
                    {
                        firstnum = double.Parse(Resulttext.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Invalid number format");
                        Resulttext.Text = "0";
                        opPressed = false;
                        return;
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("Number is too large or too small");
                        Resulttext.Text = "0";
                        opPressed = false;
                        return;
                    }
                    Resulttext.Clear();

                    operation = (sender as Button)?.Text ?? "";
                    if (string.IsNullOrEmpty(operation))
                    {
                        MessageBox.Show("Invalid operation");
                        opPressed = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error performing operation: " + ex.Message);
                Resulttext.Text = "0";
                opPressed = false;
            }
        }




        private void buttonequal_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if there's any input to process
                if (string.IsNullOrEmpty(Resulttext.Text))
                {
                    MessageBox.Show("Please enter a number");
                    return;
                }

                secondnum = double.Parse(Resulttext.Text);
                double result = 0;
                bool validOperation = true;

                switch (operation)
                {
                    case "Mod":
                        result = (firstnum % secondnum);
                        break;
                    case "Exp":
                        result = firstnum * Math.Pow(10, secondnum);

                        break;

                    case "+":
                        result = firstnum + secondnum;
                        break;
                    case "-":
                        result = firstnum - secondnum;
                        break;
                    case "*":
                        result = firstnum * secondnum;
                        break;
                    case "/":
                        if (secondnum == 0)
                        {
                            MessageBox.Show("Cannot divide by zero");
                            validOperation = false;
                        }
                        else
                        {
                            result = firstnum / secondnum;
                        }
                        break;
                    case "^":
                        try
                        {
                            result = Math.Pow(firstnum, secondnum);
                            if (double.IsInfinity(result) || double.IsNaN(result))
                            {
                                MessageBox.Show("The result is too large or undefined");
                                validOperation = false;
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error calculating power");
                            validOperation = false;
                        }
                        break;



                    default:
                        MessageBox.Show("Invalid operation");
                        validOperation = false;
                        break;
                }

                if (validOperation)
                {
                    if (double.IsInfinity(result) || double.IsNaN(result))
                    {
                        Resulttext.Text = "Error";
                    }
                    else
                    {
                        Resulttext.Text = result.ToString();
                    }
                }
                else
                {
                    Resulttext.Text = "0";
                }

                opPressed = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid number format");
                Resulttext.Text = "0";
            }
            catch (OverflowException)
            {
                MessageBox.Show("Number is too large or too small");
                Resulttext.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating result: " + ex.Message);
                Resulttext.Text = "0";
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            Resulttext.Text = "0";
            opPressed = false;
            isInverse = false;

        }

        private void btnclearentry_Click(object sender, EventArgs e)
        {
            Resulttext.Text = "0";
            string x, y;
            x = Convert.ToString(firstnum);
            y = Convert.ToString(secondnum);
            x = "";
            y = "";
        }

        private void buttonplusminus_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Resulttext.Text) || Resulttext.Text == "0")
                {
                    return;
                }

                double x = double.Parse(Resulttext.Text);
                Resulttext.Text = (-1 * x).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error toggling sign: " + ex.Message);
                Resulttext.Text = "0";
            }
        }

        private void buttonbackspace_Click(object sender, EventArgs e)
        {
            if (Resulttext.Text.Length > 0)
            {
                Resulttext.Text = Resulttext.Text.Remove(Resulttext.TextLength - 1, 1);
            }
            if (Resulttext.Text == "")
                Resulttext.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 400;
            Resulttext.Width = 327;

        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 400;
            Resulttext.Width = 327;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 800;
            Resulttext.Width = 724;
        }
        void Pie(object sender, EventArgs e)
        {
            Resulttext.Text = "3.141592653589793238462643383279502884197";
        }
        void log(object sender, EventArgs e)
        {
            double x = double.Parse(Resulttext.Text);
            x = Math.Log10(x);
            Resulttext.Text = x.ToString();

        }
        void Squareroot(object sender, EventArgs e)
        {
            double x = double.Parse(Resulttext.Text);
            x = Math.Sqrt(x);
            Resulttext.Text = x.ToString();
        }
        void squaring(object sender, EventArgs e)
        {
            double x = double.Parse(Resulttext.Text);
            x = Math.Pow(x, 2);
            Resulttext.Text = x.ToString();
        }

        private void sinh_Click(object sender, EventArgs e)
        {
            double x = double.Parse(Resulttext.Text);
            x = Math.Sinh(x);
            Resulttext.Text = x.ToString();
        }

        private void sin_Click(object sender, EventArgs e)
        {
            double value = double.Parse(Resulttext.Text);
            double result;

            if (isInverse)
            {
                result = Math.Asin(value);
            }
            else
            {
                result = Math.Sin(value);
            }

            Resulttext.Text = result.ToString();
        }

        private void cosh_Click(object sender, EventArgs e)
        {
            double value = double.Parse(Resulttext.Text);
            double result;

            if (isInverse)
            {
                result = Math.Acosh(value);
            }
            else
            {
                result = Math.Cosh(value);
            }

            Resulttext.Text = result.ToString();
        }

        private void cos_Click(object sender, EventArgs e)
        {
            double value = double.Parse(Resulttext.Text);
            double result;

            if (isInverse)
            {
                result = Math.Acos(value);
            }
            else
            {
                result = Math.Cos(value);
            }

            Resulttext.Text = result.ToString();
        }

        private void tanh_Click(object sender, EventArgs e)
        {
            double value = double.Parse(Resulttext.Text);
            double result;

            if (isInverse)
            {
                result = Math.Atanh(value);
            }
            else
            {
                result = Math.Tanh(value);
            }

            Resulttext.Text = result.ToString();
        }

        private void tan_Click(object sender, EventArgs e)
        {
            double value = double.Parse(Resulttext.Text);
            double result;

            if (isInverse)
            {
                result = Math.Atan(value);
            }
            else
            {
                result = Math.Tan(value);
            }

            Resulttext.Text = result.ToString();
        }

        private void percentage_Click(object sender, EventArgs e)
        {
            double x = double.Parse(Resulttext.Text);
            x = x / 100;
            Resulttext.Text = x.ToString();
        }

        private void ln_Click(object sender, EventArgs e)
        {
            double x = double.Parse(Resulttext.Text);
            x = Math.Log(x);
            Resulttext.Text = x.ToString();
        }

        private void Inv(object sender, EventArgs e)
        {
            isInverse = !isInverse;
            sin.Text = isInverse ? "arcsin" : "sin";
            cos.Text = isInverse ? "arccos" : "cos";
            tan.Text = isInverse ? "arctan" : "tan";
            sinh.Text = isInverse ? "arcsinh" : "sinh";
            cosh.Text = isInverse ? "arccosh" : "cosh";
            tanh.Text = isInverse ? "arctanh" : "tanh";
            Inverse.BackColor = isInverse ? Color.LightBlue : Color.SlateGray;


        }

        private void e_Click(object sender, EventArgs e)
        {
            Resulttext.Text = "2.71828182846";
        }


        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                double input = double.Parse(Resulttext.Text);


                if (input < 0 || input != Math.Floor(input))
                {
                    MessageBox.Show("Enter +ve Number");
                    Resulttext.Text = "0";
                    return;
                }

                double result = 1;
                for (int i = 1; i <= (int)input; i++)
                {
                    result *= i;
                }

                Resulttext.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid number format");
                Resulttext.Text = "0";
            }
            catch (OverflowException)
            {
                MessageBox.Show("Number is too large for factorial calculation");
                Resulttext.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating factorial: " + ex.Message);
                Resulttext.Text = "0";
            }
        }

        private void graphicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraphForm graphForm = new GraphForm();
            graphForm.Show();
        }
    }
}

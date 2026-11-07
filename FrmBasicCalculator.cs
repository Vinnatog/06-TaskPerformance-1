using System;
using CalculatorPrivateAssembly;
namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtA.Text);
            float num2 = float.Parse(txtB.Text);
            float result = 0;
            switch (comboBox1.SelectedItem.ToString())
            {
                case "+":
                    result = BasicComputation.Add(num1, num2);
                    txtA.Clear();
                    txtB.Clear();
                    comboBox1.SelectedIndex = -1;
                    break;
                case "-":
                    result = BasicComputation.Subtract(num1, num2);
                    txtA.Clear();
                    txtB.Clear();
                    comboBox1.SelectedIndex = -1;
                    break;
                case "*":
                    result = BasicComputation.Multiply(num1, num2);
                    txtA.Clear();
                    txtB.Clear();
                    comboBox1.SelectedIndex = -1;
                    break;
                case "/ ":
                    try
                    {
                        result = BasicComputation.Divide(num1, num2);
                        txtA.Clear();
                        txtB.Clear();
                        comboBox1.SelectedIndex = -11;
                    }
                    catch (DivideByZeroException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                default:
                    MessageBox.Show("Please select a valid operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

            }
            lblValue.Text = result.ToString();


        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/ ");
            comboBox1.SelectedIndex = -1;

        }
    }
}

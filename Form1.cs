namespace Calculator
{
	public partial class Form1 : Form
	{
		string input = string.Empty;
		string operand1 = string.Empty;
		string operand2 = string.Empty;
		char operation;
		double result = 0.0;

		public Form1()
		{
			InitializeComponent();
		}

		private void seven_Click(object sender, EventArgs e)
		{
			this.textBox.Text = "";
			input += "7";
			this.textBox.Text += input;
		}

		private void division_Click(object sender, EventArgs e)
		{
			operand1 = input;
			operation = '/';
			input = string.Empty;
		}

		private void equals_Click(object sender, EventArgs e)
		{
			operand2 = input;
			double num1, num2;
			double.TryParse(operand1, out num1);
			double.TryParse(operand2, out num2);

			this.textBox.Text = "";
			this.input = string.Empty;
			this.operand1 = string.Empty;
			this.operand2 = string.Empty;

			if (operation == '+')
			{
				result = num1 + num2;
				textBox.Text = result.ToString();
			}

			else if (operation == '-')
			{
				result = num1 - num2;
				textBox.Text = result.ToString();
			}

			else if (operation == '*')
			{
				result = num1 * num2;
				textBox.Text = result.ToString();
			}

			else if (operation == '/')
			{
				if (num2 != 0)
				{
					result = num1 / num2;
					textBox.Text = result.ToString();
				}

				else
				{
					textBox.Text = "DIV/Zero!!!!";
				}
			}
		}

		private void clear_Click(object sender, EventArgs e)
		{
			this.textBox.Text = "";
			this.input = string.Empty;
			this.operand1 = string.Empty;
			this.operand2 = string.Empty;
		}

		private void dot_Click(object sender, EventArgs e)
		{
			this.textBox.Text = "";
			input += ".";
			this.textBox.Text += input;
		}

		private void zero_Click(object sender, EventArgs e)
		{
			this.textBox.Text = "";
			input += "0";
			this.textBox.Text += input;
		}

		private void eight_Click(object sender, EventArgs e)
		{
			this.textBox.Text = "";
			input += "8";
			this.textBox.Text += input;
		}

		private void nine_Click(object sender, EventArgs e)
		{
			this.textBox.Text = "";
			input += "9";
			this.textBox.Text += input;
		}

		private void multiply_Click(object sender, EventArgs e)
		{
			operand1 = input;
			operation = '*';
			input = string.Empty;
		}

		private void addition_Click(object sender, EventArgs e)
		{
			operand1 = input;
			operation = '+';
			input = string.Empty;
		}

		private void four_Click(object sender, EventArgs e)
		{
			this.textBox.Text = "";
			input += "4";
			this.textBox.Text += input;
		}

		private void six_Click(object sender, EventArgs e)
		{
			this.textBox.Text = "";
			input += "6";
			this.textBox.Text += input;
		}

		private void five_Click(object sender, EventArgs e)
		{
			this.textBox.Text = "";
			input += "5";
			this.textBox.Text += input;
		}

		private void subtraction_Click(object sender, EventArgs e)
		{
			operand1 = input;
			operation = '-';
			input = string.Empty;
		}

		private void one_Click(object sender, EventArgs e)
		{
			this.textBox.Text = "";
			input += "1";
			this.textBox.Text += input;
		}

		private void three_Click(object sender, EventArgs e)
		{
			this.textBox.Text = "";
			input += "3";
			this.textBox.Text += input;
		}

		private void two_Click(object sender, EventArgs e)
		{
			this.textBox.Text = "";
			input += "2";
			this.textBox.Text += input;
		}

		private void textBox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
using System.Windows.Forms;

namespace calculator
{
    public partial class Calculator_App : Form
    {
        private NotifyIcon notifyIcon;
        private bool isOn = false;
        private Size originalSize;
        private Point originalLocation;
        public Calculator_App()
        {

            InitializeComponent();

            originalSize = this.Size; // Lưu kích thước ban đầu của form
            originalLocation = this.Location; // Lưu vị trí ban đầu của form



        }


        private void btnthunho_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                // Trả về kích thước ban đầu
                isOn = false;
                this.Size = originalSize;
                this.Location = originalLocation;
                this.CenterToScreen();

            }
            else
            {
                // Phóng to form
                isOn = true;
                this.Size = new Size(800, 500); // Kích thước phóng to mong muốn
                this.CenterToScreen(); // Tùy chọn: di chuyển form vào giữa màn hình

            }
        }
        double result = 0;
        string operation = string.Empty;
        string fstNum, secNum;
        bool enterValaue = false;
        private void Btnnumberclick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textboxhienthi1.Text == "0" || enterValaue)
            {
                textboxhienthi1.Text = button.Text;
                enterValaue = false;
            }
            else
            {
                textboxhienthi1.Text += button.Text;
            }
        }

        private void PnlTitile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Iterate over all controls in the form
            foreach (var control in this.Controls)
            {
                // Check if the control is a TextBox
                if (control is TextBox textBox)
                {
                    // Clear the text of the TextBox
                    textBox.Text = string.Empty;
                }
            }

            // Additionally, reset any other relevant variables and states
            result = 0;
            operation = string.Empty;
            fstNum = string.Empty;
            secNum = string.Empty;
            enterValaue = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnanapp_SizeChanged(object sender, EventArgs e)
        {


        }

        private void btnanapp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = true;
        }

        private void textboxhienthi2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateTextBox()
        {


        }

        private void number1_Click(object sender, EventArgs e)
        {



        }

        private void number2_Click(object sender, EventArgs e)
        {

        }

        private void number3_Click(object sender, EventArgs e)
        {

        }

        private void number4_Click(object sender, EventArgs e)
        {

        }

        private void number5_Click(object sender, EventArgs e)
        {

        }

        private void number6_Click(object sender, EventArgs e)
        {

        }

        private void number7_Click(object sender, EventArgs e)
        {

        }

        private void number8_Click(object sender, EventArgs e)
        {

        }

        private void number9_Click(object sender, EventArgs e)
        {

        }

        private void xoaphantutronglist()
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textboxhienthi1.Text))
            {
                textboxhienthi1.Text = textboxhienthi1.Text.Substring(0, textboxhienthi1.Text.Length - 1);
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void math(object sender, EventArgs e)
        {
            if (result != 0) button11.PerformClick();
            else result = double.Parse(textboxhienthi1.Text);


            Button button = (Button)sender;
            operation = button.Text;

            enterValaue = true;
            if (textboxhienthi1.Text != "0")
            {
                textboxhienthi2.Text = fstNum = $"{result} {operation}";
                textboxhienthi1.Text = string.Empty;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            secNum = textboxhienthi1.Text;
            textboxhienthi2.Text = $"{textboxhienthi2.Text} {textboxhienthi1.Text} = ";

            if (!string.IsNullOrEmpty(textboxhienthi1.Text) && double.TryParse(textboxhienthi1.Text, out double currentNumber))
            {
                switch (operation)
                {
                    case "+":
                        result += currentNumber;
                        textboxhienthi1.Text = result.ToString();
                        break;
                    case "-":
                        result -= currentNumber;
                        textboxhienthi1.Text = result.ToString();
                        break;
                    case "*":
                        result *= currentNumber;
                        textboxhienthi1.Text = result.ToString();
                        break;
                    case "/":

                        result /= currentNumber;
                        textboxhienthi1.Text = result.ToString();

                        break;
                    case "%":

                        result = (result * currentNumber) / 100;
                        textboxhienthi1.Text = result.ToString() + "%";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                // Handle the case where the input is not valid or empty
                textboxhienthi1.Text = "Invalid input";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (result != 0) button11.PerformClick();
            else result = double.Parse(textboxhienthi1.Text);

            Button button = (Button)sender;
            operation = button.Text;

            enterValaue = true;
            if (textboxhienthi1.Text != "0")
            {
                textboxhienthi2.Text = fstNum = $"{result} {operation}";
                textboxhienthi1.Text = string.Empty;

            }
        }

        private void Calculator_App_Load(object sender, EventArgs e)
        {

        }
    }
}


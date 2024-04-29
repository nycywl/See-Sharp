namespace SimpleCalculator01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(Button1_Click);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /* MessageBox.Show("«ö¤Ubutton 1");*/
            Calculate(true);
        }

        /* private void Calculate(bool isAdd)
         {
             int x = int.Parse(textBox1.Text);
             int y = int.Parse(textBox2.Text);

             if (isAdd) 
             {
                 label1.Text = (x + y).ToString();
             }
             else 
             {
                 label1.Text = (x - y).ToString();
             }

         }*/

        private void Calculate(bool isAdd)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

            if (!isAdd)
            {
                y = -y;
            }
            else
            {
                label1.Text = (x - y).ToString();
            }

        }

        private void Button2_Click(object sender, EventArgs e) 
        {
            Calculate(false);
        }
    }
}

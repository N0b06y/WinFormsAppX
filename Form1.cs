namespace WinFormsAppX
{
    public partial class Form1 : Form
    {
        Function function = new Function();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            function.setA(textBoxA.Text);


        }
        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
            function.setB(textBoxB.Text);
        }
        private void textBoxC_TextChanged(object sender, EventArgs e)
        {
            function.setC(textBoxC.Text);
        }

        private void textBoxX_TextChanged(object sender, EventArgs e)
        {
            if(function.isComplete())
            {
                textBoxY.Text = function.getY(textBoxX.Text);
            }
        }
        private void textBoxY_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxScheitelX_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxScheitelY_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRechnePotenz_Click(object sender, EventArgs e)
        {

        }
    }
}
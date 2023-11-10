namespace Práctica_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, cua, cub, z;                //Se declaran las variables a usar.
                                               
            for (i = 1; i <= 50; i++)          //Se declara que "i" sea 1, y se empiece un ciclo con todos los procedimientos, hasta terminar en 50.
            {
                cua = i * i;                   //Se declaran laas fórmulas para el cubo el cuadrado y la z.
                cub = i * i * i;
                z = cua + cub;                 
                listBox1.Items.Add(i);          //Se declara que cada resultado aparecerá en su respectiva listbox.
                listBox2.Items.Add(cua);
                listBox3.Items.Add(cub);
                listBox4.Items.Add(z);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
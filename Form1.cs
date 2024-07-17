namespace stajornek7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi, faktoriyel;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtsayi.Text == "")
            {
                MessageBox.Show("Lütfen bir sayý giriniz");
            }
            else
            {

            
            sayi = Convert.ToInt32(txtsayi.Text);
            faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel = faktoriyel * i;
                lstfaktoriyel.Items.Add(faktoriyel);
                lblsonuc.Text = faktoriyel.ToString();
            }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtsayi.Clear();
            lstfaktoriyel.Items.Clear();
            lblsonuc.Text = "Sonuç";
        }
    }
}
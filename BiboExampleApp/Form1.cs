namespace BiboExampleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var buch = new BibBuch("Mein Buch");

            List<BibMedium> list = new List<BibMedium>();

            list.Add(buch);


            foreach (var item in list)
            {
                MessageBox.Show(item.Name);

            }
        }
    }
}

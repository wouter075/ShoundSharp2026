namespace ShoundSharp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //SmartPhone newPhone = new SmartPhone(1, "Google", "Pixel 10 Pro", 256000, 599.99m);
            //MessageBox.Show(newPhone.Brand);

            //List<SmartPhone> phones = new List<SmartPhone>();
            //phones.Add(newPhone);

            //phones.Add(
            //    new SmartPhone(2, "Apple", "iPhone 15 Pro Max", 512000, 1099.99m)
            //    );

            //foreach (SmartPhone phone in phones)
            //{
            //    MessageBox.Show(phone.Brand);
            //}


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Edit button clicked!");
            MessageBox.Show("Edit button clicked!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}

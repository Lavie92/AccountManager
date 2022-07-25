namespace AccountManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountNumber.Text) || string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtRemainder.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!");
            }
            else
            {
                ListViewItem item = new ListViewItem();
                for (int i = 1; i < lvwInformation.Items.Count + 2; i++)
                {
                    item.Text = i.ToString();
                }
                lvwInformation.Items.Add(item);
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, (txtAccountNumber.Text));
                item.SubItems.Add(subItem);
                subItem = new ListViewItem.ListViewSubItem(item, (txtCustomerName.Text));
                item.SubItems.Add(subItem);
                subItem = new ListViewItem.ListViewSubItem(item, (txtAddress.Text));
                item.SubItems.Add(subItem);
                subItem = new ListViewItem.ListViewSubItem(item, (txtRemainder.Text));
                item.SubItems.Add(subItem);
            }
        }
    }
}
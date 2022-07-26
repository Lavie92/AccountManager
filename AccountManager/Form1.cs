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
            ListViewItem item = new ListViewItem();
            if (string.IsNullOrEmpty(txtAccountNumber.Text) || string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtRemainder.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!");
            }
            else if (lvwInformation.FindItemWithText(txtAccountNumber.Text) != null) {
                MessageBox.Show("Có rồi");
            }
            {
                item.Text = (lvwInformation.Items.Count + 1).ToString();
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
namespace AccountManager
{
    public partial class FAccountManager : Form
    {
        float total = 0;
        public FAccountManager()
        {
            InitializeComponent();
        }


        private void UpdateAccount()
        {

            // here your code goes
            lvwInformation.SelectedItems[0].SubItems[0].Text = txtCustomerName.Text;
            lvwInformation.SelectedItems[0].SubItems[1].Text = txtCustomerName.Text;
            lvwInformation.SelectedItems[0].SubItems[2].Text = txtCustomerName.Text;
            lvwInformation.SelectedItems[0].SubItems[3].Text = txtCustomerName.Text;
            lvwInformation.SelectedItems[0].SubItems[4].Text = txtCustomerName.Text;
            lvwInformation.SelectedItems[0].SubItems[5].Text = txtCustomerName.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwInformation.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sủe?", "", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    lvwInformation.Items.Remove(lvwInformation.SelectedItems[0]);
                }
                else
                {
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sủe about that", "", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                Close();
            }
        }

        private void lvwInformation_Click(object sender, EventArgs e)
        {
            string accountNumber = lvwInformation.SelectedItems[0].SubItems[1].Text;
            txtAccountNumber.Text = accountNumber;
            string customerName = lvwInformation.SelectedItems[0].SubItems[2].Text;
            txtCustomerName.Text = customerName;
            string customerAddress = lvwInformation.SelectedItems[0].SubItems[3].Text;
            txtAddress.Text = customerAddress;
            string remainder = lvwInformation.SelectedItems[0].SubItems[4].Text;
            txtRemainder.Text = remainder;
        }
        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            if (string.IsNullOrEmpty(txtAccountNumber.Text) || string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtRemainder.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!");
            }
            
             else if (lvwInformation.FindItemWithText(txtAccountNumber.Text) != null)
                {
                MessageBox.Show("Tài khoản đã tồn tại!!");
            }
            else
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
                total += float.Parse(txtRemainder.Text);
                MessageBox.Show("Thêm tài khoản thành công!!");
                txtAccountNumber.Text = null; txtRemainder.Text = null;
                txtAddress.Text = null; txtCustomerName.Text = null;
            }
            txtTotal.Text = total.ToString();
        }
    }
}
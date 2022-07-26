namespace AccountManager
{
    public partial class Form1 : Form
    {
        float total = 0;
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
                //if (lvwInformation.SelectedItems.Count > 0)
                //{
                //    // here your code goes
                //    lvwInformation.SelectedItems[0].SubItems[0].Text = txtCustomerName.Text;
                //    lvwInformation.SelectedItems[0].SubItems[1].Text = txtCustomerName.Text;
                //    lvwInformation.SelectedItems[0].SubItems[2].Text = txtCustomerName.Text;
                //    lvwInformation.SelectedItems[0].SubItems[3].Text = txtCustomerName.Text;
                //    lvwInformation.SelectedItems[0].SubItems[4].Text = txtCustomerName.Text;
                //    lvwInformation.SelectedItems[0].SubItems[5].Text = txtCustomerName.Text;
                //    
                //}
                //else
                //{
                //    return;
                //}
                MessageBox.Show("Tài khoản đã tồn tại!!");
                return;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwInformation.SelectedItems.Count > 0)
            {
                MessageBox.Show("Bạn chắc chứ?", "", MessageBoxButtons.OKCancel);
                lvwInformation.Items.Remove(lvwInformation.SelectedItems[0]);
            }
        }
    }
}
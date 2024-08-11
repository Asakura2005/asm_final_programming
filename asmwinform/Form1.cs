using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace asmwinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightBlue;
            //
            cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;
            //
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            //
            listView1.Columns.Add("STT", 35);
            listView1.Columns.Add("Name", 120);
            listView1.Columns.Add("Phone", 120);
            listView1.Columns.Add("Type Of Custumer", 140);
            listView1.Columns.Add("Water last month(m³)", 140);
            listView1.Columns.Add("Water this month(m³)", 140);
            listView1.Columns.Add("Water used(m³)", 105);
            listView1.Columns.Add("Number Human (Only Type Family)", 215);
            listView1.Columns.Add("Total price(With tax)", 140);
            //
            btEdit.Visible = false;
            btDelete.Visible = false;
            btClear.Visible = false;
            btPrBill.Visible = false;
            //
            lbHuman.Visible = false;
            tbHuman.Visible = false;
        }

        private void btResult_Click(object sender, EventArgs e)
        {
            string Name = tbName.Text;
            string Phone = tbPhone.Text;
            string LastM = tbLastM.Text;
            string ThisM = tbThisM.Text;
            string Type = cbType.Text;
            string numberhuman = tbHuman.Text;
            //check
            if (CheckNumber(ThisM, LastM, Phone,Type) && !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(ThisM) 
                && !string.IsNullOrEmpty(LastM) && !string.IsNullOrEmpty(Type) && !string.IsNullOrEmpty(Phone))
            {

                ListViewItem item = new ListViewItem((listView1.Items.Count + 1).ToString());
                listView1.Items.Add(item);
                item.SubItems.Add(Name);
                item.SubItems.Add(Phone);
                item.SubItems.Add(Type);
                item.SubItems.Add(LastM);
                item.SubItems.Add(ThisM);
                double consume = double.Parse(ThisM) - double.Parse(LastM);
                item.SubItems.Add(consume.ToString());
                lbAOWB.Text = string.Format("Amount of water used: {0} m³", consume);
                if (Type == "Family")
                {
                    if (!numberhuman.All(char.IsDigit))
                    {
                        MessageBox.Show("The number of members can only be entered numerically!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    item.SubItems.Add(numberhuman);
                }
                else
                {
                    item.SubItems.Add("");
                }
                double result = funsion_result(Type, consume);
                item.SubItems.Add(result.ToString("F3"));
                lbTotalWaterB.Text = string.Format("Total water bill: {0:F3} VND", result);
                btEdit.Visible = true;
                btDelete.Visible = true;
                btClear.Visible = true;
                btPrBill.Visible = true;
                btResult.Visible = true;
                clearAll();
            }
            else
            {
                MessageBox.Show("Please fill in the correct information!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckNumber(string thisMonth, string lastMonth, string phone, string Type)
        {
            double thisMonthValue, lastMonthValue;
            if (!double.TryParse(thisMonth, out thisMonthValue) || !double.TryParse(lastMonth, out lastMonthValue))
            {
                MessageBox.Show("Please enter the correct format for this month or last month!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (lastMonthValue > thisMonthValue)
            {
                MessageBox.Show("Last Month cannot be greater than This Month", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            int phoneNumber;
            if (phone.Length < 10 || !int.TryParse(phone, out phoneNumber))
            {
                MessageBox.Show("Please enter a valid phone number with at least 10 digits!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!cbType.Items.Contains(Type))
            {
                MessageBox.Show("Invalid customer type! Please select a type from the list.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string Name = tbName.Text;
                string Phone = tbPhone.Text;
                string LastM = tbLastM.Text;
                string ThisM = tbThisM.Text;
                string Type = cbType.Text;
                string numberhuman = tbHuman.Text;
                //check
                CheckNumber(ThisM, LastM, Phone, Type);
                double consume = double.Parse(ThisM) - double.Parse(LastM);
                item.SubItems[1].Text = Name;
                item.SubItems[2].Text = Phone;
                item.SubItems[3].Text = Type;
                item.SubItems[4].Text = LastM;
                item.SubItems[5].Text = ThisM;
                if (Type == "Family")
                {
                    if (!numberhuman.All(char.IsDigit))
                    {
                        MessageBox.Show("The number of people can only be entered numerically", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    item.SubItems[7].Text = numberhuman;
                }
                else
                {
                    item.SubItems[7].Text = "";
                }
                double result = funsion_result(Type, consume);
                item.SubItems[6].Text = consume.ToString();
                lbAOWB.Text = string.Format("Amount of water used: {0} m³", consume);
                item.SubItems[8].Text = result.ToString("F3");
                lbTotalWaterB.Text = string.Format("Total water bill: {0:F3} VND", result);
                clearAll();
            }
            else
            {
                MessageBox.Show("Please select an item to edit!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                btResult.Visible = false;
                btEdit.Visible = true;
                btDelete.Visible = true;
                btClear.Visible = true;
                btPrBill.Visible = true;
                ListViewItem seleted_Item = listView1.SelectedItems[0];
                string STT = seleted_Item.SubItems[0].Text;
                string Name = seleted_Item.SubItems[1].Text;
                string Phone = seleted_Item.SubItems[2].Text;
                string Type = seleted_Item.SubItems[3].Text;
                string LastM = seleted_Item.SubItems[4].Text;
                string ThisM = seleted_Item.SubItems[5].Text;
                string Consume = seleted_Item.SubItems[6].Text;
                string numberHm = seleted_Item.SubItems[7].Text;
                string result = seleted_Item.SubItems[8].Text;

                tbName.Text = Name;
                tbLastM.Text = LastM;
                tbThisM.Text = ThisM;
                tbHuman.Text = numberHm;
                tbPhone.Text = Phone;
                lbAOWB.Text = string.Format("Amount of water used: {0} m³", Consume);
                lbTotalWaterB.Text = string.Format("Total water bill: {0:F3} VND", result);

                if (Type == "Family")
                { cbType.SelectedIndex = 0; }
                else if (Type == "Administrative agency")
                { cbType.SelectedIndex = 1; }
                else if (Type == "Public services")
                { cbType.SelectedIndex = 2; }
                else if (Type == "Production units")
                { cbType.SelectedIndex = 3; }
                else if (Type == "Business services")
                { cbType.SelectedIndex = 4; }
            }
            else
            {
                btResult.Visible = true;
                btEdit.Visible = false;
                btDelete.Visible = false;
                btClear.Visible = true;
                btPrBill.Visible = false;
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedItem != null && cbType.SelectedItem.ToString() == "Family")
            {
                lbHuman.Visible = true;
                tbHuman.Visible = true;
            }
            else
            {
                lbHuman.Visible = false;
                tbHuman.Visible = false;
            }
        }

        private double funsion_result(string type, double consume)
        {
            double waterBill = 0;
            switch (type)
            {
                case "Family":
                    if (consume <= 10)
                    {
                        waterBill = consume * 5.973;
                    }
                    else if (consume <= 20)
                    {
                        waterBill = 10 * 5.973 + (consume - 10) * 7.052;
                    }
                    else if (consume <= 30)
                    {
                        waterBill = 10 * 5.973 + 10 * 7.052 + (consume - 20) * 8.699;
                    }
                    else
                    {
                        waterBill = 10 * 5.973 + 10 * 7.052 + 10 * 8.699 + (consume - 30) * 15.929;
                    }
                    break;
                case "Administrative agency":
                case "Public services":
                    waterBill = consume * 9.955;
                    break;
                case "Production units":
                    waterBill = consume * 11.615;
                    break;
                case "Business services":
                    waterBill = consume * 22.068;
                    break;
                default:
                    throw new ArgumentException("Invalid type");
            }
            double environmentProtectionFee = waterBill / 10;
            double result = waterBill + environmentProtectionFee;
            return result;
        }

        private void clearAll()
        {
            tbName.Clear();
            tbThisM.Clear();
            tbLastM.Clear();
            tbPhone.Clear();
            cbType.SelectedIndex = -1;
            tbHuman.Clear();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            clearAll();
            lbAOWB.Text = string.Format("Amount of water used: ");
            lbTotalWaterB.Text = string.Format("Total water bill: ");
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && MessageBox.Show("Do you want to delete the selected information?", 
                "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int selectedIndex = listView1.SelectedItems[0].Index;
                listView1.Items.Remove(listView1.SelectedItems[0]);

                // Update STT for remaining items
                for (int i = selectedIndex; i < listView1.Items.Count; i++)
                {
                    listView1.Items[i].SubItems[0].Text = (i + 1).ToString();
                }
                lbAOWB.Text = string.Format("Amount of water used: ");
                lbTotalWaterB.Text = string.Format("Total water bill: ");
                clearAll();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the program?", "Warning!", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btPrBill_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string type = item.SubItems[3].Text;
                double consume = double.Parse(item.SubItems[6].Text);
                double typePrice = 0;
                double environmentProtectionFee = funsion_result(type, consume) / 10;

                switch (type)
                {
                    case "Family":
                        if (consume <= 10)
                        {
                            typePrice = 5.973;
                        }
                        else if (consume <= 20)
                        {
                            typePrice = 7.052;
                        }
                        else if (consume <= 30)
                        {
                            typePrice = 8.699;
                        }
                        else
                        {
                            typePrice = 15.929;
                        }
                        break;
                    case "Administrative agency":
                    case "Public services":
                        typePrice = 9.955;
                        break;
                    case "Production units":
                        typePrice = 11.615;
                        break;
                    case "Business services":
                        typePrice = 22.068;
                        break;
                }

                PrintBill form2 = new PrintBill();
                form2.ReceiveData(item, typePrice, environmentProtectionFee);
                form2.Show();

            }
        }
    }
}

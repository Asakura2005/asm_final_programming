using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asmwinform
{
    public partial class PrintBill : Form
    {
        public PrintBill()
        {
            InitializeComponent();
        }
        public void ReceiveData(ListViewItem item, double typePrice, double environmentProtectionFee)
        {
            {
                // add information
                string name = item.SubItems[1].Text;
                string phone = item.SubItems[2].Text;
                string type = item.SubItems[3].Text;
                string lastM = item.SubItems[4].Text;
                string thisM = item.SubItems[5].Text;
                string consume = item.SubItems[6].Text;
                string result = item.SubItems[8].Text;

                // view all label to form2
                lbName.Text = string.Format(": {0}", name);
                lbPhone.Text = string.Format(": {0}", phone);
                lbType.Text = string.Format(": {0}", type);
                lbLastMonth.Text = string.Format(": {0} m³", lastM);
                lbThisMonth.Text = string.Format(": {0} m³", thisM);
                lbWaterUsed.Text = string.Format(": {0} m³", consume); ;
                lbTotalPrice.Text = string.Format(": {0} VND", result);
                lbPrice.Text = string.Format(": {0} VND", typePrice);
                lbFeeEn.Text = string.Format(": {0:F3} VND", environmentProtectionFee);
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintPageEventHandler;
            printDocument.Print();
        }

        private void PrintPageEventHandler(object sender, PrintPageEventArgs e)
        {
            int width = grbBILL.Width;
            int height = grbBILL.Height;

            Bitmap grbBillBitmap = new Bitmap(width, height);
            grbBILL.DrawToBitmap(grbBillBitmap, new Rectangle(0, 0, width, height));

            float scaleFactor = Math.Min((float)e.PageBounds.Width / width,
                (float)e.PageBounds.Height / height);

            e.Graphics.DrawImage(grbBillBitmap, 0, 0,
                width * scaleFactor, height * scaleFactor);
        }
    }
}

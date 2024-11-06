using Companysystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Companysystem.PurchasesBillsForm
{
    public partial class AddPurchasesBill : Form
    {
        private readonly StoreContext context;
        public AddPurchasesBill()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            context = new StoreContext();
            CustomizeUI();
        }

        private void CustomizeUI()
        {
            // Customize Form
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            // Customize NumericUpDown controls
            CustomizeNumericUpDown(priceNum);
            CustomizeNumericUpDown(quantitynum);
            CustomizeNumericUpDown(discountnum);
            CustomizeNumericUpDown(transportandshippingnum);
            CustomizeNumericUpDown(CustomsNum);
            CustomizeNumericUpDown(OtherNum);

            // Customize ListBox controls
            CustomizeListBox(listsuppliersname);
            CustomizeListBox(listitemsname);

            // Customize Buttons
            CustomizeButton(btnadd);

            // Customize Labels
            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    CustomizeLabel((Label)control);
                }
            }

            // Customize DateTimePicker
            CustomizeDateTimePicker(dateTimePicker1);

            // Customize TextBox controls
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    CustomizeTextBox((TextBox)control);
                }
            }

            // Customize PictureBox
            CustomizePictureBox(pictureBox1);
        }

        private void CustomizeNumericUpDown(NumericUpDown numericUpDown)
        {
            numericUpDown.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            numericUpDown.ForeColor = Color.FromArgb(45, 45, 48);
            numericUpDown.BackColor = Color.White;
            numericUpDown.BorderStyle = BorderStyle.FixedSingle;

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(numericUpDown, "Enter a value");
        }

        private void CustomizeListBox(ListBox listBox)
        {
            listBox.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            listBox.ForeColor = Color.FromArgb(45, 45, 48);
            listBox.BackColor = Color.White;
        }

        private void CustomizeButton(Button button)
        {
            button.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            button.ForeColor = Color.White;
            button.BackColor = Color.FromArgb(0, 122, 204);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 151, 234);
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 102, 204);
        }

        private void CustomizeLabel(Label label)
        {
            label.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            label.ForeColor = Color.FromArgb(45, 45, 48);
        }

        private void CustomizeDateTimePicker(DateTimePicker dateTimePicker)
        {
            dateTimePicker.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            dateTimePicker.CalendarForeColor = Color.FromArgb(45, 45, 48);
            dateTimePicker.CalendarMonthBackground = Color.White;
        }

        private void CustomizeTextBox(TextBox textBox)
        {
            textBox.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            textBox.ForeColor = Color.FromArgb(45, 45, 48);
            textBox.BackColor = Color.White;
            textBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void CustomizePictureBox(PictureBox pictureBox)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void AddPurchasesBill_Load(object sender, EventArgs e)
        {
            var suppliers = context.Suppliers.ToList();
            listsuppliersname.DataSource = suppliers;
            listsuppliersname.DisplayMember = "Name";
            listsuppliersname.ValueMember = "Id";

            var items = context.items.ToList();
            listitemsname.DataSource = items;
            listitemsname.DisplayMember = "Name";
            listitemsname.ValueMember = "Id";

            listsuppliersname.SelectedIndexChanged += listsuppliersname_SelectedIndexChanged;
            listitemsname.SelectedIndexChanged += listitemsname_SelectedIndexChanged;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {
                int selectedId = (int)listsuppliersname.SelectedValue;
                int itemfk = (int)listitemsname.SelectedValue;

                var value = priceNum.Value * quantitynum.Value;
                var netpricevalue = value - discountnum.Value + (transportandshippingnum.Value + CustomsNum.Value + OtherNum.Value);

                var data = new Purchases
                {
                    Date = dateTimePicker1.Value,
                    month = dateTimePicker1.Value.Month.ToString(),
                    SupplierId = selectedId,
                    ItemId = itemfk,
                    quantity = (int)quantitynum.Value,
                    Price = priceNum.Value,
                    PriceValue = value,
                    deduct = discountnum.Value,
                    TransportAndShipping = transportandshippingnum.Value,
                    Customs = CustomsNum.Value,
                    others = OtherNum.Value,
                    NetPriceValue = netpricevalue,
                    priceUnit = ((decimal)Math.Pow(Convert.ToDouble(quantitynum.Value), -1.00)) * netpricevalue
                };

                context.Purchases.Add(data);
                context.SaveChanges();

                var name = context.items.FirstOrDefault(p => p.Id == itemfk).Name;

                var store = new Store
                {
                    PurchasesBillId = data.Id,
                    price = data.Price * 1.5m,
                    BeginingStore = (int)addbrginingstore.Value,
                    incoming = data.quantity,
                    EndingStore = data.quantity+(int)addbrginingstore.Value,
                    InventoryCost = (data.quantity +(int)addbrginingstore.Value)* data.priceUnit,
                    item = name , 
                    priceUnit = data.priceUnit
                };

                context.Stores.Add(store);
                context.SaveChanges();
                MessageBox.Show("تمت الاضافة بنجاح");
                var purchaseb = new PurchsesBillForm();
                purchaseb.Show();
                Hide();
            }
        }

        private void listsuppliersname_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle supplier selection change
        }

        private void listitemsname_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle item selection change
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var purchaseb = new PurchsesBillForm();
            purchaseb.Show();
            Hide();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {


        }
    }
}

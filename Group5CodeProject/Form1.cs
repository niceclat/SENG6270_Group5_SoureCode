using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group5CodeProject
{
    public partial class Form1 : Form
    {
        //The state machine class for the orders
        public MainProgram orderList;
        //The order number that we are currently on
        private int OrderID = 0;

        private const string SIZE = "size";
        private const string FINISH = "finish";
        private const string PROCESSINGTIME = "processingTime";
        private const string QUANTITY = "quantity";
        private const string TOTAL = "total";


        //Entry into the form
        public Form1()
        {
            InitializeComponent();
            orderList = new MainProgram();
            AddOrder();
        }

        //Add a default order to the list
        public void AddOrder()
        {
            orderList.AddNewOrder(++OrderID);
            AddNewPanel();
            UpdateTotals();
        }

        //Create a new order panel and add it to the list
        public void AddNewPanel()
        {
            //create the panel
            FlowLayoutPanel p = new FlowLayoutPanel();
            p.AutoSize = true;
            p.AutoSizeMode = AutoSizeMode.GrowOnly;

            //Create the combo box controls
            ComboBox size = new ComboBox();
            ComboBox finish = new ComboBox();
            ComboBox processing = new ComboBox();
            ComboBox quantity = new ComboBox();

            //Order Total box
            TextBox total = new TextBox();
            total.ReadOnly = true;
            total.Name = TOTAL;

            //The remove order button
            Button btnRemoveOrder = new Button();
            btnRemoveOrder.Text = "Delete Order";
            btnRemoveOrder.Click += RemoveOrder;

            //get the order
            Order lastOrder = orderList.orders.Last();

            //set all the combo box options
            size.Items.AddRange(lastOrder.SizeOptions.items.ToArray());
            size.SelectedIndex = 0;
            lastOrder.SizeOptions.SelectedItem = size.SelectedItem.ToString();
            size.SelectedIndexChanged += UpdateSelectedItem;
            size.Name = SIZE;

            finish.Items.AddRange(lastOrder.FinishOptions.items.ToArray());
            finish.SelectedIndex = 0;
            lastOrder.FinishOptions.SelectedItem = finish.SelectedItem.ToString();
            finish.SelectedIndexChanged += UpdateSelectedItem;
            finish.Name = FINISH;

            processing.Items.AddRange(lastOrder.ProcessingOptions.items.ToArray());
            processing.SelectedIndex = 0;
            lastOrder.ProcessingOptions.SelectedItem = processing.SelectedItem.ToString();
            processing.SelectedIndexChanged += UpdateSelectedItem;
            processing.Name = PROCESSINGTIME;

            quantity.Items.AddRange(lastOrder.QuantityOptions.items.ToArray());
            quantity.SelectedIndex = 0;
            lastOrder.QuantityOptions.SelectedItem = quantity.SelectedItem.ToString();
            quantity.SelectedIndexChanged += UpdateSelectedItem;
            quantity.Name = QUANTITY;

            //Set the panel ID
            p.Name = lastOrder.OrderID.ToString();

            //Add all items to the housing panel
            p.Controls.Add(size);
            p.Controls.Add(finish);
            p.Controls.Add(processing);
            p.Controls.Add(quantity);
            p.Controls.Add(total);
            p.Controls.Add(btnRemoveOrder);

            //Add the new panel to the master panel
            MasterPanel.Controls.Add(p);
        }

        //adds an order to the master panel
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AddOrder();
        }

        //removes an order from the master panel
        private void RemoveOrder(object sender, EventArgs e)
        {
            //get the button that activated the control
            Button b = (Button)sender;
            //Get the order id from the parent container
            string OrderID = ((FlowLayoutPanel)b.Parent).Name;
            //set a temp panel because we cannot remove while iterating
            FlowLayoutPanel tempPanel = null;
            //Look through each panel and get the id of the one to remove
            foreach (FlowLayoutPanel flp in MasterPanel.Controls)
            {
                if (flp.Name == OrderID)
                {
                    tempPanel = flp;
                }
            }
            //If we found a panel then remove it
            if (tempPanel != null)
            {
                MasterPanel.Controls.Remove(tempPanel);
                Order tempOrder = null;
                foreach (Order o in orderList.orders)
                {
                    if (o.OrderID.ToString() == OrderID)
                    {
                        tempOrder = o;
                    }
                }
                if (orderList != null)
                    orderList.orders.Remove(tempOrder);
            }
            //If that order was the last order then generate a blank order
            if (MasterPanel.Controls.Count == 0)
                AddOrder();
            else
                UpdateTotals();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Remove all orders
            MasterPanel.Controls.Clear();
            //Remove all orders
            orderList.orders.Clear();
            //Add a new order
            AddOrder();
        }

        //updates the totals for the program
        private void UpdateTotals()
        {
            //Update all the order totals
            orderList.UpdateTotalAndDiscount(tbPromo.Text.ToUpper());

            //Updat the main total for all orders
            tbTotal.Text = "$" + orderList.TotalPrice.ToString();

            //Look through each order panel
            foreach (FlowLayoutPanel flp in MasterPanel.Controls)
            {
                //Look thorugh each order and find the matching panel
                foreach (Order o in orderList.orders)
                {
                    if (flp.Name == o.OrderID.ToString())
                    {
                        TextBox tb = (TextBox)flp.Controls.Find(TOTAL, false)[0];
                        tb.Text = "$" + o.OrderTotal.ToString();
                    }
                }
            }
        }

        //updates the selected value for each combo box
        private void UpdateSelectedItem(object sender, EventArgs e)
        {
            //get the combo box that fired the event 
            ComboBox cb = (ComboBox)sender;
            //get the order id from the combo box parent
            string OrderID = ((FlowLayoutPanel)cb.Parent).Name;

            Order temp = null;
            //Find the order that matches the order id
            foreach (Order o in orderList.orders)
            {
                if (o.OrderID.ToString() == OrderID)
                    temp = o;
            }
            //If the order was found then process the change
            if (temp != null)
            {
                //Update the selected item for each combo box
                switch (cb.Name)
                {
                    case SIZE:
                        {
                            temp.SizeOptions.SelectedItem = cb.SelectedItem.ToString();
                            break;
                        }
                    case FINISH:
                        {
                            temp.FinishOptions.SelectedItem = cb.SelectedItem.ToString();
                            break;
                        }
                    case PROCESSINGTIME:
                        {
                            temp.ProcessingOptions.SelectedItem = cb.SelectedItem.ToString();
                            break;
                        }
                    case QUANTITY:
                        {
                            temp.QuantityOptions.SelectedItem = cb.SelectedItem.ToString();
                            break;
                        }
                }
            }
            //Trigger the state change to update all totals
            UpdateTotals();
        }

        private void tbPromo_TextChanged(object sender, EventArgs e)
        {
            if (tbPromo.Text == MainProgram.PROMOCODE_1)
            {
                UpdateTotals();
            }
        }
    }
}

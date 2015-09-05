using RadGridViewEFCodeFirst.Data;
using RadGridViewEFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace RadGridViewEFCodeFirst.WinFormsClient
{
    public partial class Form1 : Form
    {
        private RadGridViewEFCodeFirstData data;

        public Form1()
        {
            InitializeComponent();

            this.data = new RadGridViewEFCodeFirstData();
            //Uncomment to load data
            //this.PopulateData();
            this.SetUpGrid();
        }

        private void SetUpGrid()
        {
            GridViewComboBoxColumn orderTypeColumn = new GridViewComboBoxColumn();
            orderTypeColumn.Name = "OrderTypeColumn";
            orderTypeColumn.HeaderText = "OrderType";
            orderTypeColumn.DataSource = this.data.OrderTypes.All().ToList();
            orderTypeColumn.ValueMember = "Description";
            orderTypeColumn.DisplayMember = "Description";
            orderTypeColumn.FieldName = "Orders";
            orderTypeColumn.Width = 200;
            this.radGridView1.Columns.Add(orderTypeColumn);
        }

        private void PopulateData()
        {
            for (int i = 1; i <= 100; i++)
            {
                OrderType orderType = new OrderType()
                    {
                        OrderTypeId = i,
                        Description = "Test" + i
                    };

                this.data.OrderTypes.Add(orderType);

                Order order = new Order()
                    {
                        OrderId = i,
                        Description = "Description" + i,
                        OrderTypeId = orderType.OrderTypeId
                    };

                this.data.Orders.Add(order);

                if (i % 10 == 0)
                {
                    this.data.SaveChanges();
                }
            }
        }
    }
}

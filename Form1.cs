using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Linq;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace Homework7
{
  public partial class Form1 : Form
  {
    OrderModelContainer1 context = new OrderModelContainer1();       
        public Form1()    
        {      
            InitializeComponent();    
        }

        private void Form1_Load(object sender, EventArgs e)    
        {
        //supplierCmb, partCmb, quantityInp, idInp, grid       
            Populate();    
        }    
        private void orderBtn_Click(object sender, EventArgs e)    
        {      
            InsertOrder();    
        }
    
        private void Populate()    
        {      
            //grid      
            var gridQuery = from eachOrder in context.Orders
                      select new
                      {
                        ID = eachOrder.OrderID,
                        NAME = eachOrder.Supplier.CompanyName,
                        PHONE = eachOrder.Supplier.PhoneNumber,
                        DATE = eachOrder.OrderDate,                        
                        QUANTITY = eachOrder.Quantity,
                        PART = eachOrder.Part.PartName
                      };
      
            grid.DataSource = gridQuery.ToList();

            supplierCmb.DataSource = context.Suppliers.ToList();
            supplierCmb.DisplayMember = "CompanyName";
            supplierCmb.ValueMember = "supplierID";
            
            partCmb.DataSource = context.Parts.ToList();
            partCmb.DisplayMember = "PartName";
            partCmb.ValueMember = "PartID";
      
            grid.AutoResizeColumns();      
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;            
        }
        private void GetIdValue()
        {
            var r = grid.Rows.Count;
            //var d = grid.Rows[r];
            var s = r.ToString();
            var t = int.Parse(s) - 1;
            var w = grid.Rows[t].Cells[0].Value.ToString();
            idInp.Text = w.ToString();
        }

        private void InsertOrder()    
        {      
            var sQuery = (int)supplierCmb.SelectedValue;
            var pQuery = (int)(partCmb.SelectedValue);

            var newOrder = new Order 
            { 
                OrderDate= DateTime.Now, 
                Quantity = int.Parse(quantityInp.Text), 
                SupplierID = sQuery, 
                PartID = pQuery 
            };
            context.Orders.Add(newOrder);      
            context.SaveChanges();      
            Populate();
            GetIdValue();
        }


    private void txt_TextChanged(object sender, EventArgs e)
    {

    }

    private void btn_Click(object sender, EventArgs e)
    {


    }

    private void label6_Click(object sender, EventArgs e)
    {

    }
  }
}

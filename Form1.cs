using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
                            id = eachOrder.OrderID,
                            sup_id = eachOrder.SupplierID,
                            date = eachOrder.OrderDate,
                            part_id = eachOrder.PartID,
                            qty = eachOrder.Quantity
                        };
            grid.DataSource = gridQuery.ToList();

           
            var suppComboQuery = from eachSupplier in context.Suppliers
                                 select new
                                 {
                                     eachSupplier.SupplierID,
                                     eachSupplier.CompanyName,
                                     phone = eachSupplier.PhoneNumber
                                 };
            
            supplierCmb.DataSource= suppComboQuery.ToList();
            
            
            //partCmb
            var partComboQuery = from eachPart in context.Parts
                                 select new
                                 {
                                     id = eachPart.PartID,
                                     eachPart.PartName,
                                     price = eachPart.Price
                                 };            
            partCmb.DataSource = partComboQuery.ToList();


            //quantityInp



            //idInp
            var orderId = from eachPart in context.Orders
                          select eachPart.OrderID;

                               /*{
                                   id = eachPart.OrderID,
                                   date = DateTime.Now//eachPart.OrderDate,
                                   qty = eachPart.Quantity,
                                   part_id = eachPart.PartID,
                                   supp_id = eachPart.SupplierID
                               };*/
            //idInp.DataSource = orderIdInput;

        }

        private void InsertOrder() 
        {
            var sQuery = (from eachOrder in context.Orders
                          where supplierCmb.Text == eachOrder.Supplier.CompanyName
                          select eachOrder.SupplierID).First();

            var pQuery = (from eachOrder in context.Orders
                          where partCmb.Text == eachOrder.Part.PartName
                          select eachOrder.PartID).First();


            var newOrder = new Order { OrderDate= DateTime.Now, Quantity = int.Parse(quantityInp.Text), SupplierID = sQuery, PartID = pQuery };
            context.Orders.Add(newOrder);
            context.SaveChanges();
           
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {

            
        }
    }
}

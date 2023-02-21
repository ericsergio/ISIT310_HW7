using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Homework7
{
    public partial class Form1 : Form
    {
        OrderModelContainer1 orderData = new OrderModelContainer1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //supplierCmb, partCmb, quantityInp, idInp, grid 
            Populate();

            Practice();
        }

        private void Practice() 
        {
            //OrderModelContainer context = new OrderModelContainer();
            //var selected = (from row in context.Parts 
             //               where row)
        }



        private void orderBtn_Click(object sender, EventArgs e)
        {

        }
        
        private void Populate()
        {
            //grid
            var gridQuery = from eachOrder in orderData.Orders
                        select new
                        {
                            id = eachOrder.OrderID,
                            sup_id = eachOrder.SupplierID,
                            date = eachOrder.OrderDate,
                            part_id = eachOrder.PartID,
                            qty = eachOrder.Quantity
                        };
            grid.DataSource = gridQuery.ToList();
            /*
            //supplierCmb
            var suppComboQuery = from eachSupplier in orderData.Suppliers
                                 select new
                                 {
                                     //id = eachSupplier.SupplierID,
                                     eachSupplier.CompanyName
                                     //phone = eachSupplier.PhoneNumber
                                 };
            supplierCmb.DataSource = suppComboQuery.ToList();

            //partCmb
            var partComboQuery = from eachPart in orderData.Parts
                                 select new
                                 {
                                     //id = eachPart.PartID,
                                     eachPart.PartName
                                     //price = eachPart.Price,
                                     //supp_id = eachPart.SupplierID
                                     //order_id = eachPart.OrderID
                                 };            
            partCmb.DataSource = partComboQuery.ToList();


            //quantityInp



            //idInp*/

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

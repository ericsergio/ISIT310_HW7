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
        OrderModelContainer orderData = new OrderModelContainer();
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

            //supplierCmb
            var suppComboQuery = from eachSupplier in orderData.Suppliers
                                 select new
                                 {
                                     id = eachSupplier.SupplierID,
                                     company = eachSupplier.CompanyName,
                                     phone = eachSupplier.PhoneNumber
                                 };
            supplierCmb.DataSource = suppComboQuery.ToList();

            //partCmb
            var partComboQuery = from eachPart in orderData.Parts
                                 select new
                                 {
                                     id = eachPart.PartID,
                                     name = eachPart.PartName,
                                     //price = eachPart.Price,
                                     //supp_id = eachPart.SupplierID,
                                     //order_id = eachPart.OrderID
                                 };            
            partCmb.DataSource = partComboQuery.ToList();


            //quantityInp



            //idInp

        }
    }
}

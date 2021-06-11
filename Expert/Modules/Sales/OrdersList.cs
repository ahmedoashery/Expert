﻿using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Expert.Modules.Sales
{
    public partial class OrdersList : DevExpress.XtraEditors.XtraForm
    {
        public OrdersList()
        {
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            Expert.Data.ExpertContext dbContext = new Expert.Data.ExpertContext();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Orders.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                ordersBindingSource.DataSource = dbContext.Orders.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

            dbContext.Employees.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                employeeBindingSource.DataSource = dbContext.Employees.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

            dbContext.Customers.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                customerBindingSource.DataSource = dbContext.Customers.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

            dbContext.Shippers.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                shipperBindingSource.DataSource = dbContext.Shippers.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

            dbContext.Orders_tax_status.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                orderTaxStatusBindingSource.DataSource = dbContext.Orders_tax_status.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

            dbContext.Orders_status.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                orderStatusBindingSource.DataSource = dbContext.Orders_status.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void BbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
    }
}
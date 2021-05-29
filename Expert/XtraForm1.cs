using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expert
{
    public partial class XtraForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        XtraUserControl employeesUserControl;
        XtraUserControl customersUserControl;
        XtraUserControl suppliersUserControl;
        XtraUserControl usersUserControl;
        public XtraForm1()
        {
            InitializeComponent();
            employeesUserControl = CreateUserControl("Employees");
            customersUserControl = CreateUserControl("Customers");
            suppliersUserControl = CreateUserControl("Suppliers");
            usersUserControl = CreateUserControl("Users");
            accordionControl.SelectedElement = employeesAccordionControlElement;
        }
        XtraUserControl CreateUserControl(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            LabelControl label = new LabelControl();
            label.Parent = result;
            label.Appearance.Font = new Font("Tahoma", 25.25F);
            label.Appearance.ForeColor = Color.Gray;
            label.Dock = System.Windows.Forms.DockStyle.Fill;
            label.AutoSizeMode = LabelAutoSizeMode.None;
            label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            label.Text = text;
            return result;
        }
        void accordionControl_SelectedElementChanged(object sender, SelectedElementChangedEventArgs e)
        {
            if (e.Element == null) return;
            XtraUserControl userControl = null;
            switch (e.Element.Text)
            {
                case "Employees":
                    userControl = employeesUserControl;
                    break;
                case "Suppliers":
                    userControl = suppliersUserControl;
                    break;
                case "Customers":
                    userControl = customersUserControl;
                    break;
                case "Users":
                    userControl = usersUserControl;
                    break;
                default:
                    break;
            }
            //XtraUserControl userControl = e.Element.Text == "Employees" ? employeesUserControl : customersUserControl;
            tabbedView.AddDocument(userControl);
            tabbedView.ActivateDocument(userControl);
        }
        void barButtonNavigation_ItemClick(object sender, ItemClickEventArgs e)
        {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            accordionControl.SelectedElement = mainAccordionGroup.Elements[barItemIndex];
        }
        void tabbedView_DocumentClosed(object sender, DocumentEventArgs e)
        {
            RecreateUserControls(e);
            SetAccordionSelectedElement(e);
        }
        void SetAccordionSelectedElement(DocumentEventArgs e)
        {
            if (tabbedView.Documents.Count != 0)
            {
                switch (e.Document.Caption)
                {
                    case "Employees":
                        accordionControl.SelectedElement = employeesAccordionControlElement;
                        break;
                    case "Suppliers":
                        accordionControl.SelectedElement = suppliersAccordionControl;
                        break;
                    case "Customers":
                        accordionControl.SelectedElement = customersAccordionControlElement;
                        break;
                    case "Users":
                        accordionControl.SelectedElement = usersAccordionControl;
                        break;
                    default:
                        break;
                }

                //if (e.Document.Caption == "Employees") accordionControl.SelectedElement = customersAccordionControlElement;
                //else accordionControl.SelectedElement = employeesAccordionControlElement;
            }
            else
            {
                accordionControl.SelectedElement = null;
            }
        }
        void RecreateUserControls(DocumentEventArgs e)
        {
            switch (e.Document.Caption)
            {
                case "Employees":
                    employeesUserControl = CreateUserControl("Employees");
                    break;
                case "Suppliers":
                    suppliersUserControl = CreateUserControl("Suppliers");
                    break;
                case "Customers":
                    customersUserControl = CreateUserControl("Customers");
                    break;
                case "Users":
                    usersUserControl = CreateUserControl("Users");
                    break;
                default:
                    break;
            }

            //if (e.Document.Caption == "Employees") employeesUserControl = CreateUserControl("Employees");
            //else customersUserControl = CreateUserControl("Customers");
        }
    }
}
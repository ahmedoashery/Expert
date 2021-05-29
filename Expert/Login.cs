using DevExpress.Utils.Menu;
using Expert.Services;
using System;
using System.Windows.Forms;

namespace Expert
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
            InitUiElements();
        }

        private void CultureButton_Click(object sender, System.EventArgs e)
        {
            DXPopupMenu popupMenu = new DXPopupMenu();
            popupMenu.Items.Add(new DXMenuItem() { Caption = "EN" });
            popupMenu.Items.Add(new DXMenuCheckItem() { Caption = "AR" });
            CultureButton.DropDownControl = popupMenu;

            popupMenu.ItemClick += PopupMenu_ItemClick;
        }

        private void PopupMenu_ItemClick(object sender, DXMenuItemEventArgs e)
        {
            if (e.Item.Caption == CultureButton.Tag.ToString())
                return;
            CultureHandler.ChangeCultre(e.Item.Caption);
        }

        private void InitUiElements()
        {
            if (Properties.Settings.Default.Language == "AR")
            {
                CultureButton.Tag = "AR";
                CultureButton.Text = "العربية";
                Text = "تسجيل الدخول";
                LoginButton.Text = "موافق";
                checkKeepMe.Text = "تذكرني ";
                RightToLeft = RightToLeft.Yes;
            }
            else
            {
                CultureButton.Tag = "EN";
                CultureButton.Text = "English";
            }
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            Authenticate auth = new Authenticate();
            if (auth.Check(textUserName.Text, textPassword.Text))
            {
                MessageBox.Show("Authenticated Successfully.");
                Properties.Settings.Default.Authenticated = true;
                Properties.Settings.Default.AuthenticatedUser = textUserName.Text;
                Properties.Settings.Default.Save();
                Application.Restart();
                Environment.Exit(0);
            }
        }
    }
}
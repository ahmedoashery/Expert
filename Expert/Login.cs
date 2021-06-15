using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Expert.Core;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Expert
{
    public partial class Login : XtraForm
    {
        public Login()
        {
            InitializeComponent();
            // initialize ui debending on culture
            InitUiElements();
        }

        private void CultureButton_Click(object sender, EventArgs e)
        {
            DXPopupMenu popupMenu = new DXPopupMenu();
            popupMenu.Items.Add(new DXMenuItem() { Caption = "English", Tag = "EN" });
            popupMenu.Items.Add(new DXMenuCheckItem() { Caption = "العربية", Tag = "AR" });
            CultureButton.DropDownControl = popupMenu;

            popupMenu.ItemClick += PopupMenu_ItemClick;
        }

        private void PopupMenu_ItemClick(object sender, DXMenuItemEventArgs e)
        {
            if (e.Item.Tag.ToString() == CultureButton.Tag.ToString())
                return;
            CultureHandler.ChangeCultre(e.Item.Tag.ToString());
        }

        private void InitUiElements()
        {
            if (Properties.Settings.Default.Language == "AR")
            {
                RightToLeft = RightToLeft.Yes;
                layoutControlGroup2.Text = "دخول المستخدمين";
                Text = "تسجيل الدخول";
                usernameText.Properties.AdvancedModeOptions.Label = "اسم المستخدم";
                passwordText.Properties.AdvancedModeOptions.Label = "كلمة المرور";
                LoginButton.Text = "موافق";
                checkKeepMe.Text = "تذكرني ";
                CultureButton.Tag = "AR";
                CultureButton.Text = "العربية";
            }
            else
            {
                CultureButton.Tag = "EN";
                CultureButton.Text = "English";
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Authenticate auth = new Authenticate();
            if (auth.Check(usernameText.Text, passwordText.Text))
            {
                Properties.Settings.Default.Authenticated = true;
                Properties.Settings.Default.AuthenticatedUser = usernameText.Text;
                Properties.Settings.Default.Save();
                Application.Restart();
                Environment.Exit(0);
            }
            else
            {
                ErrorMessage.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                ErrorMessage.Text = Properties.Settings.Default.Language == "AR" ? "خطأ فى اسم المستخدم او كلمة المرور" : "Wrong username or password.";
                HighlightError();
            }
        }

        private void HighlightError()
        {
            usernameText.Properties.Appearance.Options.UseBorderColor = true;
            usernameText.Properties.BorderStyle = BorderStyles.Simple;
            usernameText.Properties.Appearance.BorderColor = Color.Red;

            passwordText.Properties.Appearance.Options.UseBorderColor = true;
            passwordText.Properties.BorderStyle = BorderStyles.Simple;
            passwordText.Properties.Appearance.BorderColor = Color.Red;
        }

        // reset apperance
        private void usernameText_EditValueChanged(object sender, EventArgs e)
        {
            usernameText.Properties.Appearance.Reset();
            passwordText.Properties.Appearance.Reset();

            ErrorMessage.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            ErrorMessage.Text = "";
        }
    }
}
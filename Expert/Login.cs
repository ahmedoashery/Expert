using System.Windows.Forms;

namespace Expert
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
            // change orientation for arabic culture.
            if (Properties.Settings.Default.Language == "AR") RightToLeft = RightToLeft.Yes;
        }
    }
}
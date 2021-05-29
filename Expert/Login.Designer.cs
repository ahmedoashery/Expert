
namespace Expert
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.usernameText = new DevExpress.XtraEditors.TextEdit();
            this.passwordText = new DevExpress.XtraEditors.TextEdit();
            this.checkKeepMe = new DevExpress.XtraEditors.CheckEdit();
            this.LoginButton = new DevExpress.XtraEditors.SimpleButton();
            this.CultureButton = new DevExpress.XtraEditors.DropDownButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ErrorMessage = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usernameText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkKeepMe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.usernameText);
            this.layoutControl1.Controls.Add(this.passwordText);
            this.layoutControl1.Controls.Add(this.checkKeepMe);
            this.layoutControl1.Controls.Add(this.LoginButton);
            this.layoutControl1.Controls.Add(this.CultureButton);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(285, 221, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(534, 220);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // usernameText
            // 
            this.usernameText.EditValue = "";
            this.usernameText.Location = new System.Drawing.Point(23, 41);
            this.usernameText.Name = "usernameText";
            this.usernameText.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.usernameText.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.usernameText.Properties.AdvancedModeOptions.Label = "username";
            this.usernameText.Properties.MaxLength = 255;
            this.usernameText.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.usernameText.Size = new System.Drawing.Size(488, 34);
            this.usernameText.StyleController = this.layoutControl1;
            this.usernameText.TabIndex = 4;
            this.usernameText.EditValueChanged += new System.EventHandler(this.usernameText_EditValueChanged);
            // 
            // passwordText
            // 
            this.passwordText.EditValue = "";
            this.passwordText.Location = new System.Drawing.Point(24, 78);
            this.passwordText.Name = "passwordText";
            this.passwordText.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.passwordText.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.passwordText.Properties.AdvancedModeOptions.Label = "password";
            this.passwordText.Properties.PasswordChar = '*';
            this.passwordText.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.passwordText.Size = new System.Drawing.Size(486, 34);
            this.passwordText.StyleController = this.layoutControl1;
            this.passwordText.TabIndex = 5;
            this.passwordText.EditValueChanged += new System.EventHandler(this.usernameText_EditValueChanged);
            // 
            // checkKeepMe
            // 
            this.checkKeepMe.Location = new System.Drawing.Point(24, 118);
            this.checkKeepMe.Name = "checkKeepMe";
            this.checkKeepMe.Properties.Caption = "Keep me signed in";
            this.checkKeepMe.Size = new System.Drawing.Size(486, 19);
            this.checkKeepMe.StyleController = this.layoutControl1;
            this.checkKeepMe.TabIndex = 6;
            // 
            // LoginButton
            // 
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.ImageOptions.SvgImageSize = new System.Drawing.Size(0, 25);
            this.LoginButton.Location = new System.Drawing.Point(12, 153);
            this.LoginButton.MinimumSize = new System.Drawing.Size(0, 38);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(117, 38);
            this.LoginButton.StyleController = this.layoutControl1;
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Sign in";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // CultureButton
            // 
            this.CultureButton.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.CultureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CultureButton.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
            this.CultureButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CultureButton.ImageOptions.Image")));
            this.CultureButton.Location = new System.Drawing.Point(429, 153);
            this.CultureButton.Margin = new System.Windows.Forms.Padding(0);
            this.CultureButton.Name = "CultureButton";
            this.CultureButton.Size = new System.Drawing.Size(93, 38);
            this.CultureButton.StyleController = this.layoutControl1;
            this.CultureButton.TabIndex = 8;
            this.CultureButton.Click += new System.EventHandler(this.CultureButton_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.ErrorMessage});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(534, 220);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.simpleSeparator1,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(514, 141);
            this.layoutControlGroup2.Text = "Users Login";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.checkKeepMe;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 76);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(490, 23);
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 74);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(490, 2);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.usernameText;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutControlItem1.Size = new System.Drawing.Size(490, 36);
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.passwordText;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(490, 38);
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.LoginButton;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 141);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(121, 42);
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AllowHotTrack = false;
            this.ErrorMessage.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
            this.ErrorMessage.AppearanceItemCaption.Options.UseForeColor = true;
            this.ErrorMessage.CustomizationFormText = "Error";
            this.ErrorMessage.Location = new System.Drawing.Point(0, 183);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(514, 17);
            this.ErrorMessage.TextSize = new System.Drawing.Size(91, 13);
            this.ErrorMessage.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.CultureButton;
            this.layoutControlItem5.Location = new System.Drawing.Point(417, 141);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(97, 42);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(121, 141);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(296, 42);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 220);
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usernameText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkKeepMe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit usernameText;
        private DevExpress.XtraEditors.TextEdit passwordText;
        private DevExpress.XtraEditors.CheckEdit checkKeepMe;
        private DevExpress.XtraEditors.SimpleButton LoginButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraEditors.DropDownButton CultureButton;
        private DevExpress.XtraLayout.SimpleLabelItem ErrorMessage;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
namespace MacAddress_Changer
{
    partial class MainForm
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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.Page_Control = new MaterialSkin.Controls.MaterialTabControl();
            this.MacListPage = new System.Windows.Forms.TabPage();
            this.ChangeMac_Page = new System.Windows.Forms.TabPage();
            this.InterInfoListView = new MaterialSkin.Controls.MaterialListView();
            this.ChooseNetworkInterfaceCard = new System.Windows.Forms.ComboBox();
            this.MacAddressChange_Btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MacAddressClear_Btn = new MaterialSkin.Controls.MaterialFlatButton();
            this.InternetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InternetDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InternetMac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InternetIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InternetNetmask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Page_Control.SuspendLayout();
            this.MacListPage.SuspendLayout();
            this.ChangeMac_Page.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.Page_Control;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(800, 23);
            this.materialTabSelector1.TabIndex = 6;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // Page_Control
            // 
            this.Page_Control.Controls.Add(this.MacListPage);
            this.Page_Control.Controls.Add(this.ChangeMac_Page);
            this.Page_Control.Depth = 0;
            this.Page_Control.Location = new System.Drawing.Point(0, 93);
            this.Page_Control.MouseState = MaterialSkin.MouseState.HOVER;
            this.Page_Control.Name = "Page_Control";
            this.Page_Control.SelectedIndex = 0;
            this.Page_Control.Size = new System.Drawing.Size(800, 356);
            this.Page_Control.TabIndex = 7;
            // 
            // MacListPage
            // 
            this.MacListPage.Controls.Add(this.InterInfoListView);
            this.MacListPage.Location = new System.Drawing.Point(4, 22);
            this.MacListPage.Name = "MacListPage";
            this.MacListPage.Padding = new System.Windows.Forms.Padding(3);
            this.MacListPage.Size = new System.Drawing.Size(792, 330);
            this.MacListPage.TabIndex = 0;
            this.MacListPage.Text = "MAC LIST";
            this.MacListPage.UseVisualStyleBackColor = true;
            // 
            // ChangeMac_Page
            // 
            this.ChangeMac_Page.Controls.Add(this.ChooseNetworkInterfaceCard);
            this.ChangeMac_Page.Controls.Add(this.MacAddressChange_Btn);
            this.ChangeMac_Page.Controls.Add(this.MacAddressClear_Btn);
            this.ChangeMac_Page.Location = new System.Drawing.Point(4, 22);
            this.ChangeMac_Page.Name = "ChangeMac_Page";
            this.ChangeMac_Page.Padding = new System.Windows.Forms.Padding(3);
            this.ChangeMac_Page.Size = new System.Drawing.Size(792, 330);
            this.ChangeMac_Page.TabIndex = 1;
            this.ChangeMac_Page.Text = "Change Mac";
            this.ChangeMac_Page.UseVisualStyleBackColor = true;
            // 
            // InterInfoListView
            // 
            this.InterInfoListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InterInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.InternetName,
            this.InternetDescription,
            this.InternetMac,
            this.InternetIP,
            this.InternetNetmask});
            this.InterInfoListView.Depth = 0;
            this.InterInfoListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.InterInfoListView.FullRowSelect = true;
            this.InterInfoListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.InterInfoListView.Location = new System.Drawing.Point(0, 0);
            this.InterInfoListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.InterInfoListView.MouseState = MaterialSkin.MouseState.OUT;
            this.InterInfoListView.Name = "InterInfoListView";
            this.InterInfoListView.OwnerDraw = true;
            this.InterInfoListView.Size = new System.Drawing.Size(796, 334);
            this.InterInfoListView.TabIndex = 9;
            this.InterInfoListView.UseCompatibleStateImageBehavior = false;
            this.InterInfoListView.View = System.Windows.Forms.View.Details;
            // 
            // ChooseNetworkInterfaceCard
            // 
            this.ChooseNetworkInterfaceCard.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ChooseNetworkInterfaceCard.FormattingEnabled = true;
            this.ChooseNetworkInterfaceCard.Location = new System.Drawing.Point(295, 120);
            this.ChooseNetworkInterfaceCard.Name = "ChooseNetworkInterfaceCard";
            this.ChooseNetworkInterfaceCard.Size = new System.Drawing.Size(201, 35);
            this.ChooseNetworkInterfaceCard.TabIndex = 9;
            // 
            // MacAddressChange_Btn
            // 
            this.MacAddressChange_Btn.AutoSize = true;
            this.MacAddressChange_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MacAddressChange_Btn.Depth = 0;
            this.MacAddressChange_Btn.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MacAddressChange_Btn.Icon = null;
            this.MacAddressChange_Btn.Location = new System.Drawing.Point(269, 174);
            this.MacAddressChange_Btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.MacAddressChange_Btn.Name = "MacAddressChange_Btn";
            this.MacAddressChange_Btn.Primary = true;
            this.MacAddressChange_Btn.Size = new System.Drawing.Size(109, 36);
            this.MacAddressChange_Btn.TabIndex = 11;
            this.MacAddressChange_Btn.Text = "CHANGE MAC";
            this.MacAddressChange_Btn.UseVisualStyleBackColor = true;
            // 
            // MacAddressClear_Btn
            // 
            this.MacAddressClear_Btn.AutoSize = true;
            this.MacAddressClear_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MacAddressClear_Btn.Depth = 0;
            this.MacAddressClear_Btn.Icon = null;
            this.MacAddressClear_Btn.Location = new System.Drawing.Point(418, 174);
            this.MacAddressClear_Btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MacAddressClear_Btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.MacAddressClear_Btn.Name = "MacAddressClear_Btn";
            this.MacAddressClear_Btn.Primary = false;
            this.MacAddressClear_Btn.Size = new System.Drawing.Size(106, 36);
            this.MacAddressClear_Btn.TabIndex = 10;
            this.MacAddressClear_Btn.Text = "RETURN MAC";
            this.MacAddressClear_Btn.UseVisualStyleBackColor = true;
            // 
            // InternetName
            // 
            this.InternetName.Text = "Name";
            this.InternetName.Width = 150;
            // 
            // InternetDescription
            // 
            this.InternetDescription.Text = "Description";
            this.InternetDescription.Width = 200;
            // 
            // InternetMac
            // 
            this.InternetMac.Text = "Mac";
            this.InternetMac.Width = 150;
            // 
            // InternetIP
            // 
            this.InternetIP.Text = "IP";
            this.InternetIP.Width = 150;
            // 
            // InternetNetmask
            // 
            this.InternetNetmask.Text = "Netmask";
            this.InternetNetmask.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Page_Control);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "MainForm";
            this.Text = "MacChanger";
            this.Page_Control.ResumeLayout(false);
            this.MacListPage.ResumeLayout(false);
            this.ChangeMac_Page.ResumeLayout(false);
            this.ChangeMac_Page.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl Page_Control;
        private System.Windows.Forms.TabPage MacListPage;
        private System.Windows.Forms.TabPage ChangeMac_Page;
        private MaterialSkin.Controls.MaterialListView InterInfoListView;
        private System.Windows.Forms.ComboBox ChooseNetworkInterfaceCard;
        private MaterialSkin.Controls.MaterialRaisedButton MacAddressChange_Btn;
        private MaterialSkin.Controls.MaterialFlatButton MacAddressClear_Btn;
        private System.Windows.Forms.ColumnHeader InternetName;
        private System.Windows.Forms.ColumnHeader InternetDescription;
        private System.Windows.Forms.ColumnHeader InternetMac;
        private System.Windows.Forms.ColumnHeader InternetIP;
        private System.Windows.Forms.ColumnHeader InternetNetmask;
    }
}
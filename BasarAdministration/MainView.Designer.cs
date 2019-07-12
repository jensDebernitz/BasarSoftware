namespace BasarAdministration
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.tabControlBase = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.textFieldAdminClientPort = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textFieldIp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textFieldSellerEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelSellerCount = new MaterialSkin.Controls.MaterialLabel();
            this.textFieldSellerId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.textFieldVillage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.textFieldPostalCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.textFieldHouseNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.textFieldStreet = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.textFieldSureName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.textFieldGivenName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonCommit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listViewSearchResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Search = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelSecondFilter = new MaterialSkin.Controls.MaterialLabel();
            this.labelFirstFilter = new MaterialSkin.Controls.MaterialLabel();
            this.textFieldSecondFilter = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textFieldFirstFilter = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.buttonClose = new MaterialSkin.Controls.MaterialRaisedButton();
            this.timerHeartBeat = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabControlBase.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlBase
            // 
            this.tabControlBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlBase.Controls.Add(this.tabPage1);
            this.tabControlBase.Controls.Add(this.tabPage2);
            this.tabControlBase.Controls.Add(this.tabPage3);
            this.tabControlBase.Controls.Add(this.tabPage4);
            this.tabControlBase.Controls.Add(this.tabPage5);
            this.tabControlBase.Depth = 0;
            this.tabControlBase.Location = new System.Drawing.Point(12, 100);
            this.tabControlBase.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlBase.Name = "tabControlBase";
            this.tabControlBase.SelectedIndex = 0;
            this.tabControlBase.Size = new System.Drawing.Size(935, 427);
            this.tabControlBase.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialLabel10);
            this.tabPage1.Controls.Add(this.textFieldAdminClientPort);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.textFieldIp);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(927, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Einstellungen";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Enabled = false;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(6, 55);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(84, 19);
            this.materialLabel10.TabIndex = 5;
            this.materialLabel10.Text = "Client Port:";
            // 
            // textFieldAdminClientPort
            // 
            this.textFieldAdminClientPort.Depth = 0;
            this.textFieldAdminClientPort.Hint = "";
            this.textFieldAdminClientPort.Location = new System.Drawing.Point(202, 51);
            this.textFieldAdminClientPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldAdminClientPort.Name = "textFieldAdminClientPort";
            this.textFieldAdminClientPort.PasswordChar = '\0';
            this.textFieldAdminClientPort.SelectedText = "";
            this.textFieldAdminClientPort.SelectionLength = 0;
            this.textFieldAdminClientPort.SelectionStart = 0;
            this.textFieldAdminClientPort.Size = new System.Drawing.Size(260, 23);
            this.textFieldAdminClientPort.TabIndex = 4;
            this.textFieldAdminClientPort.Text = "51949";
            this.textFieldAdminClientPort.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Enabled = false;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 26);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Server IP:";
            // 
            // textFieldIp
            // 
            this.textFieldIp.Depth = 0;
            this.textFieldIp.Hint = "192.168.0.15";
            this.textFieldIp.Location = new System.Drawing.Point(202, 22);
            this.textFieldIp.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldIp.Name = "textFieldIp";
            this.textFieldIp.PasswordChar = '\0';
            this.textFieldIp.SelectedText = "";
            this.textFieldIp.SelectionLength = 0;
            this.textFieldIp.SelectionStart = 0;
            this.textFieldIp.Size = new System.Drawing.Size(260, 23);
            this.textFieldIp.TabIndex = 0;
            this.textFieldIp.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.textFieldSellerEmail);
            this.tabPage2.Controls.Add(this.materialLabel2);
            this.tabPage2.Controls.Add(this.materialRaisedButton1);
            this.tabPage2.Controls.Add(this.labelSellerCount);
            this.tabPage2.Controls.Add(this.textFieldSellerId);
            this.tabPage2.Controls.Add(this.materialLabel9);
            this.tabPage2.Controls.Add(this.textFieldVillage);
            this.tabPage2.Controls.Add(this.materialLabel8);
            this.tabPage2.Controls.Add(this.textFieldPostalCode);
            this.tabPage2.Controls.Add(this.materialLabel7);
            this.tabPage2.Controls.Add(this.textFieldHouseNumber);
            this.tabPage2.Controls.Add(this.materialLabel6);
            this.tabPage2.Controls.Add(this.textFieldStreet);
            this.tabPage2.Controls.Add(this.materialLabel5);
            this.tabPage2.Controls.Add(this.textFieldSureName);
            this.tabPage2.Controls.Add(this.materialLabel4);
            this.tabPage2.Controls.Add(this.textFieldGivenName);
            this.tabPage2.Controls.Add(this.materialLabel3);
            this.tabPage2.Controls.Add(this.buttonCommit);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(927, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Verkäufer Neu Erfassen";
            // 
            // textFieldSellerEmail
            // 
            this.textFieldSellerEmail.Depth = 0;
            this.textFieldSellerEmail.Hint = "";
            this.textFieldSellerEmail.Location = new System.Drawing.Point(154, 212);
            this.textFieldSellerEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldSellerEmail.Name = "textFieldSellerEmail";
            this.textFieldSellerEmail.PasswordChar = '\0';
            this.textFieldSellerEmail.SelectedText = "";
            this.textFieldSellerEmail.SelectionLength = 0;
            this.textFieldSellerEmail.SelectionStart = 0;
            this.textFieldSellerEmail.Size = new System.Drawing.Size(365, 23);
            this.textFieldSellerEmail.TabIndex = 102;
            this.textFieldSellerEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Enabled = false;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 216);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(51, 19);
            this.materialLabel2.TabIndex = 103;
            this.materialLabel2.Text = "EMail:";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(761, 55);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(160, 35);
            this.materialRaisedButton1.TabIndex = 101;
            this.materialRaisedButton1.Text = "Excel Tabelle Einlesen";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // labelSellerCount
            // 
            this.labelSellerCount.Depth = 0;
            this.labelSellerCount.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelSellerCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSellerCount.Location = new System.Drawing.Point(6, 360);
            this.labelSellerCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSellerCount.Name = "labelSellerCount";
            this.labelSellerCount.Size = new System.Drawing.Size(356, 27);
            this.labelSellerCount.TabIndex = 100;
            this.labelSellerCount.Text = "materialLabel11";
            // 
            // textFieldSellerId
            // 
            this.textFieldSellerId.Depth = 0;
            this.textFieldSellerId.Hint = "";
            this.textFieldSellerId.Location = new System.Drawing.Point(154, 183);
            this.textFieldSellerId.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldSellerId.Name = "textFieldSellerId";
            this.textFieldSellerId.PasswordChar = '\0';
            this.textFieldSellerId.SelectedText = "";
            this.textFieldSellerId.SelectionLength = 0;
            this.textFieldSellerId.SelectionStart = 0;
            this.textFieldSellerId.Size = new System.Drawing.Size(365, 23);
            this.textFieldSellerId.TabIndex = 6;
            this.textFieldSellerId.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Enabled = false;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(6, 187);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(90, 19);
            this.materialLabel9.TabIndex = 99;
            this.materialLabel9.Text = "VerkäuferId:";
            // 
            // textFieldVillage
            // 
            this.textFieldVillage.Depth = 0;
            this.textFieldVillage.Hint = "";
            this.textFieldVillage.Location = new System.Drawing.Point(154, 154);
            this.textFieldVillage.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldVillage.Name = "textFieldVillage";
            this.textFieldVillage.PasswordChar = '\0';
            this.textFieldVillage.SelectedText = "";
            this.textFieldVillage.SelectionLength = 0;
            this.textFieldVillage.SelectionStart = 0;
            this.textFieldVillage.Size = new System.Drawing.Size(365, 23);
            this.textFieldVillage.TabIndex = 5;
            this.textFieldVillage.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Enabled = false;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(6, 158);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(70, 19);
            this.materialLabel8.TabIndex = 99;
            this.materialLabel8.Text = "Wohnort:";
            // 
            // textFieldPostalCode
            // 
            this.textFieldPostalCode.Depth = 0;
            this.textFieldPostalCode.Hint = "";
            this.textFieldPostalCode.Location = new System.Drawing.Point(154, 125);
            this.textFieldPostalCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldPostalCode.Name = "textFieldPostalCode";
            this.textFieldPostalCode.PasswordChar = '\0';
            this.textFieldPostalCode.SelectedText = "";
            this.textFieldPostalCode.SelectionLength = 0;
            this.textFieldPostalCode.SelectionStart = 0;
            this.textFieldPostalCode.Size = new System.Drawing.Size(365, 23);
            this.textFieldPostalCode.TabIndex = 4;
            this.textFieldPostalCode.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Enabled = false;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(6, 129);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(39, 19);
            this.materialLabel7.TabIndex = 99;
            this.materialLabel7.Text = "PLZ:";
            // 
            // textFieldHouseNumber
            // 
            this.textFieldHouseNumber.Depth = 0;
            this.textFieldHouseNumber.Hint = "";
            this.textFieldHouseNumber.Location = new System.Drawing.Point(154, 96);
            this.textFieldHouseNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldHouseNumber.Name = "textFieldHouseNumber";
            this.textFieldHouseNumber.PasswordChar = '\0';
            this.textFieldHouseNumber.SelectedText = "";
            this.textFieldHouseNumber.SelectionLength = 0;
            this.textFieldHouseNumber.SelectionStart = 0;
            this.textFieldHouseNumber.Size = new System.Drawing.Size(365, 23);
            this.textFieldHouseNumber.TabIndex = 3;
            this.textFieldHouseNumber.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Enabled = false;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(6, 100);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(103, 19);
            this.materialLabel6.TabIndex = 99;
            this.materialLabel6.Text = "Hausnummer:";
            // 
            // textFieldStreet
            // 
            this.textFieldStreet.Depth = 0;
            this.textFieldStreet.Hint = "";
            this.textFieldStreet.Location = new System.Drawing.Point(154, 67);
            this.textFieldStreet.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldStreet.Name = "textFieldStreet";
            this.textFieldStreet.PasswordChar = '\0';
            this.textFieldStreet.SelectedText = "";
            this.textFieldStreet.SelectionLength = 0;
            this.textFieldStreet.SelectionStart = 0;
            this.textFieldStreet.Size = new System.Drawing.Size(365, 23);
            this.textFieldStreet.TabIndex = 2;
            this.textFieldStreet.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Enabled = false;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(6, 71);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(64, 19);
            this.materialLabel5.TabIndex = 99;
            this.materialLabel5.Text = "Strasse:";
            // 
            // textFieldSureName
            // 
            this.textFieldSureName.Depth = 0;
            this.textFieldSureName.Hint = "";
            this.textFieldSureName.Location = new System.Drawing.Point(154, 38);
            this.textFieldSureName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldSureName.Name = "textFieldSureName";
            this.textFieldSureName.PasswordChar = '\0';
            this.textFieldSureName.SelectedText = "";
            this.textFieldSureName.SelectionLength = 0;
            this.textFieldSureName.SelectionStart = 0;
            this.textFieldSureName.Size = new System.Drawing.Size(365, 23);
            this.textFieldSureName.TabIndex = 1;
            this.textFieldSureName.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Enabled = false;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(6, 42);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(85, 19);
            this.materialLabel4.TabIndex = 99;
            this.materialLabel4.Text = "Nachname:";
            // 
            // textFieldGivenName
            // 
            this.textFieldGivenName.Depth = 0;
            this.textFieldGivenName.Hint = "";
            this.textFieldGivenName.Location = new System.Drawing.Point(154, 9);
            this.textFieldGivenName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldGivenName.Name = "textFieldGivenName";
            this.textFieldGivenName.PasswordChar = '\0';
            this.textFieldGivenName.SelectedText = "";
            this.textFieldGivenName.SelectionLength = 0;
            this.textFieldGivenName.SelectionStart = 0;
            this.textFieldGivenName.Size = new System.Drawing.Size(365, 23);
            this.textFieldGivenName.TabIndex = 0;
            this.textFieldGivenName.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Enabled = false;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 13);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(74, 19);
            this.materialLabel3.TabIndex = 99;
            this.materialLabel3.Text = "Vorname:";
            // 
            // buttonCommit
            // 
            this.buttonCommit.Depth = 0;
            this.buttonCommit.Location = new System.Drawing.Point(761, 6);
            this.buttonCommit.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCommit.Name = "buttonCommit";
            this.buttonCommit.Primary = true;
            this.buttonCommit.Size = new System.Drawing.Size(160, 35);
            this.buttonCommit.TabIndex = 7;
            this.buttonCommit.Text = "Erfassen";
            this.buttonCommit.UseVisualStyleBackColor = true;
            this.buttonCommit.Click += new System.EventHandler(this.buttonErfassen_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.listViewSearchResult);
            this.tabPage3.Controls.Add(this.Search);
            this.tabPage3.Controls.Add(this.labelSecondFilter);
            this.tabPage3.Controls.Add(this.labelFirstFilter);
            this.tabPage3.Controls.Add(this.textFieldSecondFilter);
            this.tabPage3.Controls.Add(this.textFieldFirstFilter);
            this.tabPage3.Controls.Add(this.materialLabel11);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(927, 401);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Suchen";
            // 
            // listViewSearchResult
            // 
            this.listViewSearchResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewSearchResult.Location = new System.Drawing.Point(14, 104);
            this.listViewSearchResult.Name = "listViewSearchResult";
            this.listViewSearchResult.Size = new System.Drawing.Size(907, 291);
            this.listViewSearchResult.TabIndex = 7;
            this.listViewSearchResult.UseCompatibleStateImageBehavior = false;
            this.listViewSearchResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Verkäufer Id";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Vorname";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nachname";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.Width = 155;
            // 
            // Search
            // 
            this.Search.Depth = 0;
            this.Search.Location = new System.Drawing.Point(453, 43);
            this.Search.MouseState = MaterialSkin.MouseState.HOVER;
            this.Search.Name = "Search";
            this.Search.Primary = true;
            this.Search.Size = new System.Drawing.Size(190, 43);
            this.Search.TabIndex = 6;
            this.Search.Text = "Suchen";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // labelSecondFilter
            // 
            this.labelSecondFilter.AutoSize = true;
            this.labelSecondFilter.Depth = 0;
            this.labelSecondFilter.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelSecondFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSecondFilter.Location = new System.Drawing.Point(10, 67);
            this.labelSecondFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSecondFilter.Name = "labelSecondFilter";
            this.labelSecondFilter.Size = new System.Drawing.Size(85, 19);
            this.labelSecondFilter.TabIndex = 5;
            this.labelSecondFilter.Text = "Nachname:";
            // 
            // labelFirstFilter
            // 
            this.labelFirstFilter.AutoSize = true;
            this.labelFirstFilter.Depth = 0;
            this.labelFirstFilter.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelFirstFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFirstFilter.Location = new System.Drawing.Point(10, 43);
            this.labelFirstFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFirstFilter.Name = "labelFirstFilter";
            this.labelFirstFilter.Size = new System.Drawing.Size(74, 19);
            this.labelFirstFilter.TabIndex = 4;
            this.labelFirstFilter.Text = "Vorname:";
            // 
            // textFieldSecondFilter
            // 
            this.textFieldSecondFilter.Depth = 0;
            this.textFieldSecondFilter.Hint = "";
            this.textFieldSecondFilter.Location = new System.Drawing.Point(230, 63);
            this.textFieldSecondFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldSecondFilter.Name = "textFieldSecondFilter";
            this.textFieldSecondFilter.PasswordChar = '\0';
            this.textFieldSecondFilter.SelectedText = "";
            this.textFieldSecondFilter.SelectionLength = 0;
            this.textFieldSecondFilter.SelectionStart = 0;
            this.textFieldSecondFilter.Size = new System.Drawing.Size(191, 23);
            this.textFieldSecondFilter.TabIndex = 3;
            this.textFieldSecondFilter.UseSystemPasswordChar = false;
            // 
            // textFieldFirstFilter
            // 
            this.textFieldFirstFilter.Depth = 0;
            this.textFieldFirstFilter.Hint = "";
            this.textFieldFirstFilter.Location = new System.Drawing.Point(230, 34);
            this.textFieldFirstFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldFirstFilter.Name = "textFieldFirstFilter";
            this.textFieldFirstFilter.PasswordChar = '\0';
            this.textFieldFirstFilter.SelectedText = "";
            this.textFieldFirstFilter.SelectionLength = 0;
            this.textFieldFirstFilter.SelectionStart = 0;
            this.textFieldFirstFilter.Size = new System.Drawing.Size(191, 23);
            this.textFieldFirstFilter.TabIndex = 2;
            this.textFieldFirstFilter.UseSystemPasswordChar = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(6, 8);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(218, 19);
            this.materialLabel11.TabIndex = 1;
            this.materialLabel11.Text = "nach was möchten sie suchen?";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "VerkäuferId",
            "Name"});
            this.comboBox1.Location = new System.Drawing.Point(230, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.materialRaisedButton2);
            this.tabPage4.Controls.Add(this.chart1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(927, 401);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Statistik";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.tabControlBase;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(12, 71);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(935, 23);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // buttonClose
            // 
            this.buttonClose.Depth = 0;
            this.buttonClose.Location = new System.Drawing.Point(783, 549);
            this.buttonClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Primary = true;
            this.buttonClose.Size = new System.Drawing.Size(160, 35);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Beenden";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // timerHeartBeat
            // 
            this.timerHeartBeat.Enabled = true;
            this.timerHeartBeat.Interval = 10000;
            this.timerHeartBeat.Tick += new System.EventHandler(this.timerHeartBeat_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(915, 313);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(761, 360);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(160, 35);
            this.materialRaisedButton2.TabIndex = 1;
            this.materialRaisedButton2.Text = "Aktualisieren";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.materialSingleLineTextField1);
            this.tabPage5.Controls.Add(this.materialLabel12);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(927, 401);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Abrechnung";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(6, 14);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(128, 19);
            this.materialLabel12.TabIndex = 0;
            this.materialLabel12.Text = "Verkaufsnummer:";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(140, 10);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(232, 23);
            this.materialSingleLineTextField1.TabIndex = 1;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 596);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tabControlBase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.Text = "Basar Administration";
            this.tabControlBase.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControlBase;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialRaisedButton buttonClose;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldIp;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialRaisedButton buttonCommit;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldVillage;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldPostalCode;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldHouseNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldStreet;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldSureName;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldGivenName;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldSellerId;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldAdminClientPort;
        private MaterialSkin.Controls.MaterialLabel labelSellerCount;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel labelSecondFilter;
        private MaterialSkin.Controls.MaterialLabel labelFirstFilter;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldSecondFilter;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldFirstFilter;
        private System.Windows.Forms.ListView listViewSearchResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialRaisedButton Search;
        private System.Windows.Forms.Timer timerHeartBeat;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldSellerEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage5;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
    }
}


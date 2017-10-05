namespace SearchService
{
    partial class FrmSearch
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
            this.lblOrgType = new System.Windows.Forms.Label();
            this.cbxOrgType = new System.Windows.Forms.ComboBox();
            this.lblOrgName = new System.Windows.Forms.Label();
            this.txtOrgName = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.cbxState = new System.Windows.Forms.ComboBox();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.btnResults = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pgrBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrgType
            // 
            this.lblOrgType.AutoSize = true;
            this.lblOrgType.Location = new System.Drawing.Point(36, 20);
            this.lblOrgType.Name = "lblOrgType";
            this.lblOrgType.Size = new System.Drawing.Size(93, 13);
            this.lblOrgType.TabIndex = 0;
            this.lblOrgType.Text = "Organization Type";
            // 
            // cbxOrgType
            // 
            this.cbxOrgType.FormattingEnabled = true;
            this.cbxOrgType.Location = new System.Drawing.Point(135, 17);
            this.cbxOrgType.Name = "cbxOrgType";
            this.cbxOrgType.Size = new System.Drawing.Size(128, 21);
            this.cbxOrgType.TabIndex = 1;
            // 
            // lblOrgName
            // 
            this.lblOrgName.AutoSize = true;
            this.lblOrgName.Location = new System.Drawing.Point(36, 45);
            this.lblOrgName.Name = "lblOrgName";
            this.lblOrgName.Size = new System.Drawing.Size(97, 13);
            this.lblOrgName.TabIndex = 2;
            this.lblOrgName.Text = "Organization Name";
            // 
            // txtOrgName
            // 
            this.txtOrgName.Location = new System.Drawing.Point(135, 42);
            this.txtOrgName.Name = "txtOrgName";
            this.txtOrgName.Size = new System.Drawing.Size(128, 20);
            this.txtOrgName.TabIndex = 3;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(36, 67);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 4;
            this.lblState.Text = "State";
            // 
            // cbxState
            // 
            this.cbxState.FormattingEnabled = true;
            this.cbxState.Items.AddRange(new object[] {
            "AK",
            "AL",
            "AR",
            "AZ",
            "CA",
            "CO",
            "CT",
            "DC",
            "DE",
            "FL",
            "GA",
            "HI",
            "IA",
            "ID",
            "IL",
            "IN",
            "KS",
            "KY",
            "LA",
            "MA",
            "MD",
            "ME",
            "MI",
            "MN",
            "MO",
            "MS",
            "MT",
            "NC",
            "ND",
            "NE",
            "NH",
            "NJ",
            "NM",
            "NV",
            "NY",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VA",
            "VT",
            "WA",
            "WI",
            "WV",
            "WY"});
            this.cbxState.Location = new System.Drawing.Point(74, 64);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(121, 21);
            this.cbxState.TabIndex = 5;
            this.cbxState.SelectedValueChanged += new System.EventHandler(this.cbxState_SelectedValueChanged);
            // 
            // cbxCity
            // 
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(201, 64);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(121, 21);
            this.cbxCity.TabIndex = 6;
            // 
            // btnResults
            // 
            this.btnResults.Location = new System.Drawing.Point(39, 140);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(88, 23);
            this.btnResults.TabIndex = 7;
            this.btnResults.Text = "Show Results";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(135, 140);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(36, 91);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(40, 13);
            this.lblCounty.TabIndex = 9;
            this.lblCounty.Text = "County";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(36, 117);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(50, 13);
            this.lblZip.TabIndex = 10;
            this.lblZip.Text = "Zip Code";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(82, 88);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(100, 20);
            this.txtCounty.TabIndex = 11;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(92, 114);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 20);
            this.txtZip.TabIndex = 12;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToOrderColumns = true;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colType,
            this.colName,
            this.colCity,
            this.colZip,
            this.colCountry,
            this.colState});
            this.dgvResults.Location = new System.Drawing.Point(39, 169);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.Size = new System.Drawing.Size(744, 186);
            this.dgvResults.TabIndex = 13;
            this.dgvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellContentClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colCity
            // 
            this.colCity.HeaderText = "City";
            this.colCity.Name = "colCity";
            this.colCity.ReadOnly = true;
            // 
            // colZip
            // 
            this.colZip.HeaderText = "Zip";
            this.colZip.Name = "colZip";
            this.colZip.ReadOnly = true;
            // 
            // colCountry
            // 
            this.colCountry.HeaderText = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.ReadOnly = true;
            // 
            // colState
            // 
            this.colState.HeaderText = "State";
            this.colState.Name = "colState";
            this.colState.ReadOnly = true;
            // 
            // pgrBar
            // 
            this.pgrBar.Location = new System.Drawing.Point(39, 361);
            this.pgrBar.Name = "pgrBar";
            this.pgrBar.Size = new System.Drawing.Size(744, 16);
            this.pgrBar.TabIndex = 14;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 390);
            this.Controls.Add(this.pgrBar);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtCounty);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.cbxCity);
            this.Controls.Add(this.cbxState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtOrgName);
            this.Controls.Add(this.lblOrgName);
            this.Controls.Add(this.cbxOrgType);
            this.Controls.Add(this.lblOrgType);
            this.Name = "FrmSearch";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrgType;
        private System.Windows.Forms.ComboBox cbxOrgType;
        private System.Windows.Forms.Label lblOrgName;
        private System.Windows.Forms.TextBox txtOrgName;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cbxState;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colState;
        private System.Windows.Forms.ProgressBar pgrBar;
    }
}


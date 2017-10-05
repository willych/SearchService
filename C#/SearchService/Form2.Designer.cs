namespace SearchService
{
    partial class FrmResults
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabGen = new System.Windows.Forms.TabPage();
            this.tabLoc = new System.Windows.Forms.TabPage();
            this.tabTreat = new System.Windows.Forms.TabPage();
            this.tabTrain = new System.Windows.Forms.TabPage();
            this.tabFac = new System.Windows.Forms.TabPage();
            this.tabPhys = new System.Windows.Forms.TabPage();
            this.tabPeo = new System.Windows.Forms.TabPage();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhys = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLicense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFacil = new System.Windows.Forms.DataGridView();
            this.colTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTrain = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbbr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTreat = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.lblLoc = new System.Windows.Forms.Label();
            this.cbxLoc = new System.Windows.Forms.ComboBox();
            this.tabs.SuspendLayout();
            this.tabGen.SuspendLayout();
            this.tabLoc.SuspendLayout();
            this.tabTreat.SuspendLayout();
            this.tabTrain.SuspendLayout();
            this.tabFac.SuspendLayout();
            this.tabPhys.SuspendLayout();
            this.tabPeo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreat)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabGen);
            this.tabs.Controls.Add(this.tabLoc);
            this.tabs.Controls.Add(this.tabTreat);
            this.tabs.Controls.Add(this.tabTrain);
            this.tabs.Controls.Add(this.tabFac);
            this.tabs.Controls.Add(this.tabPhys);
            this.tabs.Controls.Add(this.tabPeo);
            this.tabs.Location = new System.Drawing.Point(28, 29);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(571, 255);
            this.tabs.TabIndex = 0;
            // 
            // tabGen
            // 
            this.tabGen.Controls.Add(this.lblGeneral);
            this.tabGen.Location = new System.Drawing.Point(4, 22);
            this.tabGen.Name = "tabGen";
            this.tabGen.Padding = new System.Windows.Forms.Padding(3);
            this.tabGen.Size = new System.Drawing.Size(563, 229);
            this.tabGen.TabIndex = 0;
            this.tabGen.Text = "General";
            this.tabGen.UseVisualStyleBackColor = true;
            // 
            // tabLoc
            // 
            this.tabLoc.Controls.Add(this.cbxLoc);
            this.tabLoc.Controls.Add(this.lblLoc);
            this.tabLoc.Location = new System.Drawing.Point(4, 22);
            this.tabLoc.Name = "tabLoc";
            this.tabLoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoc.Size = new System.Drawing.Size(563, 229);
            this.tabLoc.TabIndex = 1;
            this.tabLoc.Text = "Location";
            this.tabLoc.UseVisualStyleBackColor = true;
            // 
            // tabTreat
            // 
            this.tabTreat.Controls.Add(this.dgvTreat);
            this.tabTreat.Location = new System.Drawing.Point(4, 22);
            this.tabTreat.Name = "tabTreat";
            this.tabTreat.Padding = new System.Windows.Forms.Padding(3);
            this.tabTreat.Size = new System.Drawing.Size(563, 229);
            this.tabTreat.TabIndex = 2;
            this.tabTreat.Text = "Treatment";
            this.tabTreat.UseVisualStyleBackColor = true;
            // 
            // tabTrain
            // 
            this.tabTrain.Controls.Add(this.dgvTrain);
            this.tabTrain.Location = new System.Drawing.Point(4, 22);
            this.tabTrain.Name = "tabTrain";
            this.tabTrain.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrain.Size = new System.Drawing.Size(563, 229);
            this.tabTrain.TabIndex = 3;
            this.tabTrain.Text = "Training";
            this.tabTrain.UseVisualStyleBackColor = true;
            // 
            // tabFac
            // 
            this.tabFac.Controls.Add(this.dgvFacil);
            this.tabFac.Location = new System.Drawing.Point(4, 22);
            this.tabFac.Name = "tabFac";
            this.tabFac.Padding = new System.Windows.Forms.Padding(3);
            this.tabFac.Size = new System.Drawing.Size(563, 229);
            this.tabFac.TabIndex = 4;
            this.tabFac.Text = "Facilities";
            this.tabFac.UseVisualStyleBackColor = true;
            // 
            // tabPhys
            // 
            this.tabPhys.Controls.Add(this.dgvPhys);
            this.tabPhys.Location = new System.Drawing.Point(4, 22);
            this.tabPhys.Name = "tabPhys";
            this.tabPhys.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhys.Size = new System.Drawing.Size(563, 229);
            this.tabPhys.TabIndex = 5;
            this.tabPhys.Text = "Physicians";
            this.tabPhys.UseVisualStyleBackColor = true;
            // 
            // tabPeo
            // 
            this.tabPeo.Controls.Add(this.dgvPeople);
            this.tabPeo.Location = new System.Drawing.Point(4, 22);
            this.tabPeo.Name = "tabPeo";
            this.tabPeo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPeo.Size = new System.Drawing.Size(563, 229);
            this.tabPeo.TabIndex = 6;
            this.tabPeo.Text = "People";
            this.tabPeo.UseVisualStyleBackColor = true;
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.AllowUserToOrderColumns = true;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFirstName,
            this.colMiddleName,
            this.colLastName,
            this.colRole});
            this.dgvPeople.Location = new System.Drawing.Point(9, 6);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.Size = new System.Drawing.Size(548, 215);
            this.dgvPeople.TabIndex = 0;
            // 
            // colFirstName
            // 
            this.colFirstName.HeaderText = "First Name";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            // 
            // colMiddleName
            // 
            this.colMiddleName.HeaderText = "Middle Name";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.ReadOnly = true;
            // 
            // colLastName
            // 
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            // 
            // colRole
            // 
            this.colRole.HeaderText = "Role";
            this.colRole.Name = "colRole";
            this.colRole.ReadOnly = true;
            // 
            // dgvPhys
            // 
            this.dgvPhys.AllowUserToAddRows = false;
            this.dgvPhys.AllowUserToDeleteRows = false;
            this.dgvPhys.AllowUserToOrderColumns = true;
            this.dgvPhys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colPhone,
            this.colLicense});
            this.dgvPhys.Location = new System.Drawing.Point(7, 7);
            this.dgvPhys.Name = "dgvPhys";
            this.dgvPhys.ReadOnly = true;
            this.dgvPhys.Size = new System.Drawing.Size(548, 215);
            this.dgvPhys.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.HeaderText = "Person Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colLicense
            // 
            this.colLicense.HeaderText = "License";
            this.colLicense.Name = "colLicense";
            this.colLicense.ReadOnly = true;
            // 
            // dgvFacil
            // 
            this.dgvFacil.AllowUserToAddRows = false;
            this.dgvFacil.AllowUserToDeleteRows = false;
            this.dgvFacil.AllowUserToOrderColumns = true;
            this.dgvFacil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTypeId,
            this.colType,
            this.colQuantity,
            this.colDesc});
            this.dgvFacil.Location = new System.Drawing.Point(7, 7);
            this.dgvFacil.Name = "dgvFacil";
            this.dgvFacil.ReadOnly = true;
            this.dgvFacil.Size = new System.Drawing.Size(548, 215);
            this.dgvFacil.TabIndex = 1;
            // 
            // colTypeId
            // 
            this.colTypeId.HeaderText = "TypeId";
            this.colTypeId.Name = "colTypeId";
            this.colTypeId.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colDesc
            // 
            this.colDesc.HeaderText = "Description";
            this.colDesc.Name = "colDesc";
            this.colDesc.ReadOnly = true;
            // 
            // dgvTrain
            // 
            this.dgvTrain.AllowUserToAddRows = false;
            this.dgvTrain.AllowUserToDeleteRows = false;
            this.dgvTrain.AllowUserToOrderColumns = true;
            this.dgvTrain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.colAbbr});
            this.dgvTrain.Location = new System.Drawing.Point(7, 7);
            this.dgvTrain.Name = "dgvTrain";
            this.dgvTrain.ReadOnly = true;
            this.dgvTrain.Size = new System.Drawing.Size(548, 215);
            this.dgvTrain.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "TypeId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // colAbbr
            // 
            this.colAbbr.HeaderText = "Abbreviation";
            this.colAbbr.Name = "colAbbr";
            this.colAbbr.ReadOnly = true;
            // 
            // dgvTreat
            // 
            this.dgvTreat.AllowUserToAddRows = false;
            this.dgvTreat.AllowUserToDeleteRows = false;
            this.dgvTreat.AllowUserToOrderColumns = true;
            this.dgvTreat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvTreat.Location = new System.Drawing.Point(7, 7);
            this.dgvTreat.Name = "dgvTreat";
            this.dgvTreat.ReadOnly = true;
            this.dgvTreat.Size = new System.Drawing.Size(548, 215);
            this.dgvTreat.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "TypeId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Abbreviation";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // lblGeneral
            // 
            this.lblGeneral.AutoSize = true;
            this.lblGeneral.Location = new System.Drawing.Point(51, 37);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(44, 13);
            this.lblGeneral.TabIndex = 0;
            this.lblGeneral.Text = "General";
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Location = new System.Drawing.Point(28, 34);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(48, 13);
            this.lblLoc.TabIndex = 1;
            this.lblLoc.Text = "Location";
            // 
            // cbxLoc
            // 
            this.cbxLoc.FormattingEnabled = true;
            this.cbxLoc.Location = new System.Drawing.Point(31, 10);
            this.cbxLoc.Name = "cbxLoc";
            this.cbxLoc.Size = new System.Drawing.Size(121, 21);
            this.cbxLoc.TabIndex = 2;
            // 
            // FrmResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 302);
            this.Controls.Add(this.tabs);
            this.Name = "FrmResults";
            this.Text = "Form2";
            this.tabs.ResumeLayout(false);
            this.tabGen.ResumeLayout(false);
            this.tabGen.PerformLayout();
            this.tabLoc.ResumeLayout(false);
            this.tabLoc.PerformLayout();
            this.tabTreat.ResumeLayout(false);
            this.tabTrain.ResumeLayout(false);
            this.tabFac.ResumeLayout(false);
            this.tabPhys.ResumeLayout(false);
            this.tabPeo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabGen;
        private System.Windows.Forms.TabPage tabLoc;
        private System.Windows.Forms.TabPage tabTreat;
        private System.Windows.Forms.TabPage tabTrain;
        private System.Windows.Forms.TabPage tabFac;
        private System.Windows.Forms.TabPage tabPhys;
        private System.Windows.Forms.TabPage tabPeo;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.DataGridView dgvTreat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView dgvTrain;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbbr;
        private System.Windows.Forms.DataGridView dgvFacil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridView dgvPhys;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLicense;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.Label lblGeneral;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.ComboBox cbxLoc;
    }
}
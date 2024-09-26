namespace MainAdmin
{
    partial class AdminForm
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
            this.dgvProperties = new System.Windows.Forms.DataGridView();
            this.propertyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.houseEstateDataSet3 = new EstateAgency.HouseEstateDataSet3();
            this.propertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.houseEstateDataSet = new EstateAgency.HouseEstateDataSet();
            this.dgvAgents = new System.Windows.Forms.DataGridView();
            this.agentIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.houseEstateDataSet4 = new EstateAgency.HouseEstateDataSet4();
            this.agentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.houseEstateDataSet1 = new EstateAgency.HouseEstateDataSet1();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.houseEstateDataSet5 = new EstateAgency.HouseEstateDataSet5();
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.houseEstateDataSet2 = new EstateAgency.HouseEstateDataSet2();
            this.PropertyType = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.TextBox();
            this.AgentName = new System.Windows.Forms.TextBox();
            this.AgentPhoneNumber = new System.Windows.Forms.TextBox();
            this.RequestStatus = new System.Windows.Forms.TextBox();
            this.btnAddProperty = new System.Windows.Forms.Button();
            this.btnAddAgent = new System.Windows.Forms.Button();
            this.btnDeleteProperty = new System.Windows.Forms.Button();
            this.btnDeleteAgent = new System.Windows.Forms.Button();
            this.btnDeleteRequest = new System.Windows.Forms.Button();
            this.btnEditProperty = new System.Windows.Forms.Button();
            this.btnEditRequest = new System.Windows.Forms.Button();
            this.propertiesTableAdapter = new EstateAgency.HouseEstateDataSetTableAdapters.PropertiesTableAdapter();
            this.agentsTableAdapter = new EstateAgency.HouseEstateDataSet1TableAdapters.AgentsTableAdapter();
            this.requestsTableAdapter = new EstateAgency.HouseEstateDataSet2TableAdapters.RequestsTableAdapter();
            this.AgentID = new System.Windows.Forms.TextBox();
            this.propertiesTableAdapter1 = new EstateAgency.HouseEstateDataSet3TableAdapters.PropertiesTableAdapter();
            this.agentsTableAdapter1 = new EstateAgency.HouseEstateDataSet4TableAdapters.AgentsTableAdapter();
            this.requestsTableAdapter1 = new EstateAgency.HouseEstateDataSet5TableAdapters.RequestsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseEstateDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseEstateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseEstateDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseEstateDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseEstateDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseEstateDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProperties
            // 
            this.dgvProperties.AutoGenerateColumns = false;
            this.dgvProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProperties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.propertyIDDataGridViewTextBoxColumn,
            this.propertyTypeDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.agentIDDataGridViewTextBoxColumn});
            this.dgvProperties.DataSource = this.propertiesBindingSource1;
            this.dgvProperties.Location = new System.Drawing.Point(12, 224);
            this.dgvProperties.Name = "dgvProperties";
            this.dgvProperties.Size = new System.Drawing.Size(554, 150);
            this.dgvProperties.TabIndex = 0;
            // 
            // propertyIDDataGridViewTextBoxColumn
            // 
            this.propertyIDDataGridViewTextBoxColumn.DataPropertyName = "PropertyID";
            this.propertyIDDataGridViewTextBoxColumn.HeaderText = "PropertyID";
            this.propertyIDDataGridViewTextBoxColumn.Name = "propertyIDDataGridViewTextBoxColumn";
            this.propertyIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // propertyTypeDataGridViewTextBoxColumn
            // 
            this.propertyTypeDataGridViewTextBoxColumn.DataPropertyName = "PropertyType";
            this.propertyTypeDataGridViewTextBoxColumn.HeaderText = "PropertyType";
            this.propertyTypeDataGridViewTextBoxColumn.Name = "propertyTypeDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // agentIDDataGridViewTextBoxColumn
            // 
            this.agentIDDataGridViewTextBoxColumn.DataPropertyName = "AgentID";
            this.agentIDDataGridViewTextBoxColumn.HeaderText = "AgentID";
            this.agentIDDataGridViewTextBoxColumn.Name = "agentIDDataGridViewTextBoxColumn";
            // 
            // propertiesBindingSource1
            // 
            this.propertiesBindingSource1.DataMember = "Properties";
            this.propertiesBindingSource1.DataSource = this.houseEstateDataSet3;
            // 
            // houseEstateDataSet3
            // 
            this.houseEstateDataSet3.DataSetName = "HouseEstateDataSet3";
            this.houseEstateDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propertiesBindingSource
            // 
            this.propertiesBindingSource.DataMember = "Properties";
            this.propertiesBindingSource.DataSource = this.houseEstateDataSet;
            // 
            // houseEstateDataSet
            // 
            this.houseEstateDataSet.DataSetName = "HouseEstateDataSet";
            this.houseEstateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvAgents
            // 
            this.dgvAgents.AutoGenerateColumns = false;
            this.dgvAgents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agentIDDataGridViewTextBoxColumn1,
            this.agentPhoneDataGridViewTextBoxColumn,
            this.requestCountDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.dgvAgents.DataSource = this.agentsBindingSource1;
            this.dgvAgents.Location = new System.Drawing.Point(21, 486);
            this.dgvAgents.Name = "dgvAgents";
            this.dgvAgents.Size = new System.Drawing.Size(448, 150);
            this.dgvAgents.TabIndex = 1;
            // 
            // agentIDDataGridViewTextBoxColumn1
            // 
            this.agentIDDataGridViewTextBoxColumn1.DataPropertyName = "AgentID";
            this.agentIDDataGridViewTextBoxColumn1.HeaderText = "AgentID";
            this.agentIDDataGridViewTextBoxColumn1.Name = "agentIDDataGridViewTextBoxColumn1";
            this.agentIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // agentPhoneDataGridViewTextBoxColumn
            // 
            this.agentPhoneDataGridViewTextBoxColumn.DataPropertyName = "AgentPhone";
            this.agentPhoneDataGridViewTextBoxColumn.HeaderText = "AgentPhone";
            this.agentPhoneDataGridViewTextBoxColumn.Name = "agentPhoneDataGridViewTextBoxColumn";
            // 
            // requestCountDataGridViewTextBoxColumn
            // 
            this.requestCountDataGridViewTextBoxColumn.DataPropertyName = "RequestCount";
            this.requestCountDataGridViewTextBoxColumn.HeaderText = "RequestCount";
            this.requestCountDataGridViewTextBoxColumn.Name = "requestCountDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // agentsBindingSource1
            // 
            this.agentsBindingSource1.DataMember = "Agents";
            this.agentsBindingSource1.DataSource = this.houseEstateDataSet4;
            // 
            // houseEstateDataSet4
            // 
            this.houseEstateDataSet4.DataSetName = "HouseEstateDataSet4";
            this.houseEstateDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agentsBindingSource
            // 
            this.agentsBindingSource.DataMember = "Agents";
            this.agentsBindingSource.DataSource = this.houseEstateDataSet1;
            // 
            // houseEstateDataSet1
            // 
            this.houseEstateDataSet1.DataSetName = "HouseEstateDataSet1";
            this.houseEstateDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvRequests
            // 
            this.dgvRequests.AutoGenerateColumns = false;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn1,
            this.requestDateDataGridViewTextBoxColumn,
            this.propertyIDDataGridViewTextBoxColumn1,
            this.requestStatusDataGridViewTextBoxColumn,
            this.agentIDDataGridViewTextBoxColumn2});
            this.dgvRequests.DataSource = this.requestsBindingSource1;
            this.dgvRequests.Location = new System.Drawing.Point(485, 486);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.Size = new System.Drawing.Size(483, 150);
            this.dgvRequests.TabIndex = 2;
            // 
            // requestIDDataGridViewTextBoxColumn
            // 
            this.requestIDDataGridViewTextBoxColumn.DataPropertyName = "RequestID";
            this.requestIDDataGridViewTextBoxColumn.HeaderText = "RequestID";
            this.requestIDDataGridViewTextBoxColumn.Name = "requestIDDataGridViewTextBoxColumn";
            this.requestIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn1
            // 
            this.userIDDataGridViewTextBoxColumn1.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn1.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn1.Name = "userIDDataGridViewTextBoxColumn1";
            // 
            // requestDateDataGridViewTextBoxColumn
            // 
            this.requestDateDataGridViewTextBoxColumn.DataPropertyName = "RequestDate";
            this.requestDateDataGridViewTextBoxColumn.HeaderText = "RequestDate";
            this.requestDateDataGridViewTextBoxColumn.Name = "requestDateDataGridViewTextBoxColumn";
            // 
            // propertyIDDataGridViewTextBoxColumn1
            // 
            this.propertyIDDataGridViewTextBoxColumn1.DataPropertyName = "PropertyID";
            this.propertyIDDataGridViewTextBoxColumn1.HeaderText = "PropertyID";
            this.propertyIDDataGridViewTextBoxColumn1.Name = "propertyIDDataGridViewTextBoxColumn1";
            // 
            // requestStatusDataGridViewTextBoxColumn
            // 
            this.requestStatusDataGridViewTextBoxColumn.DataPropertyName = "RequestStatus";
            this.requestStatusDataGridViewTextBoxColumn.HeaderText = "RequestStatus";
            this.requestStatusDataGridViewTextBoxColumn.Name = "requestStatusDataGridViewTextBoxColumn";
            // 
            // agentIDDataGridViewTextBoxColumn2
            // 
            this.agentIDDataGridViewTextBoxColumn2.DataPropertyName = "AgentID";
            this.agentIDDataGridViewTextBoxColumn2.HeaderText = "AgentID";
            this.agentIDDataGridViewTextBoxColumn2.Name = "agentIDDataGridViewTextBoxColumn2";
            // 
            // requestsBindingSource1
            // 
            this.requestsBindingSource1.DataMember = "Requests";
            this.requestsBindingSource1.DataSource = this.houseEstateDataSet5;
            // 
            // houseEstateDataSet5
            // 
            this.houseEstateDataSet5.DataSetName = "HouseEstateDataSet5";
            this.houseEstateDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestsBindingSource
            // 
            this.requestsBindingSource.DataMember = "Requests";
            this.requestsBindingSource.DataSource = this.houseEstateDataSet2;
            // 
            // houseEstateDataSet2
            // 
            this.houseEstateDataSet2.DataSetName = "HouseEstateDataSet2";
            this.houseEstateDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PropertyType
            // 
            this.PropertyType.Location = new System.Drawing.Point(66, 179);
            this.PropertyType.Name = "PropertyType";
            this.PropertyType.Size = new System.Drawing.Size(100, 20);
            this.PropertyType.TabIndex = 3;
            this.PropertyType.Text = "PropertyType";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(189, 179);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(100, 20);
            this.Address.TabIndex = 4;
            this.Address.Text = "Address";
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(313, 179);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(100, 20);
            this.Cost.TabIndex = 5;
            this.Cost.Text = "Cost";
            // 
            // AgentName
            // 
            this.AgentName.Location = new System.Drawing.Point(66, 460);
            this.AgentName.Name = "AgentName";
            this.AgentName.Size = new System.Drawing.Size(100, 20);
            this.AgentName.TabIndex = 6;
            this.AgentName.Text = "AgentName";
            // 
            // AgentPhoneNumber
            // 
            this.AgentPhoneNumber.Location = new System.Drawing.Point(189, 460);
            this.AgentPhoneNumber.Name = "AgentPhoneNumber";
            this.AgentPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.AgentPhoneNumber.TabIndex = 7;
            // 
            // RequestStatus
            // 
            this.RequestStatus.Location = new System.Drawing.Point(625, 460);
            this.RequestStatus.Name = "RequestStatus";
            this.RequestStatus.Size = new System.Drawing.Size(100, 20);
            this.RequestStatus.TabIndex = 8;
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Location = new System.Drawing.Point(66, 150);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(146, 23);
            this.btnAddProperty.TabIndex = 9;
            this.btnAddProperty.Text = "btnAddProperty";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            this.btnAddProperty.Click += new System.EventHandler(this.btnAddProperty_Click);
            // 
            // btnAddAgent
            // 
            this.btnAddAgent.Location = new System.Drawing.Point(326, 428);
            this.btnAddAgent.Name = "btnAddAgent";
            this.btnAddAgent.Size = new System.Drawing.Size(82, 23);
            this.btnAddAgent.TabIndex = 10;
            this.btnAddAgent.Text = "btnAddAgent";
            this.btnAddAgent.UseVisualStyleBackColor = true;
            this.btnAddAgent.Click += new System.EventHandler(this.btnAddAgent_Click);
            // 
            // btnDeleteProperty
            // 
            this.btnDeleteProperty.Location = new System.Drawing.Point(357, 150);
            this.btnDeleteProperty.Name = "btnDeleteProperty";
            this.btnDeleteProperty.Size = new System.Drawing.Size(112, 23);
            this.btnDeleteProperty.TabIndex = 11;
            this.btnDeleteProperty.Text = "btnDeleteProperty";
            this.btnDeleteProperty.UseVisualStyleBackColor = true;
            this.btnDeleteProperty.Click += new System.EventHandler(this.btnDeleteProperty_Click);
            // 
            // btnDeleteAgent
            // 
            this.btnDeleteAgent.Location = new System.Drawing.Point(313, 457);
            this.btnDeleteAgent.Name = "btnDeleteAgent";
            this.btnDeleteAgent.Size = new System.Drawing.Size(95, 23);
            this.btnDeleteAgent.TabIndex = 12;
            this.btnDeleteAgent.Text = "btnDeleteAgent";
            this.btnDeleteAgent.UseVisualStyleBackColor = true;
            this.btnDeleteAgent.Click += new System.EventHandler(this.btnDeleteAgent_Click);
            // 
            // btnDeleteRequest
            // 
            this.btnDeleteRequest.Location = new System.Drawing.Point(808, 457);
            this.btnDeleteRequest.Name = "btnDeleteRequest";
            this.btnDeleteRequest.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteRequest.TabIndex = 13;
            this.btnDeleteRequest.Text = "btnDeleteRequest";
            this.btnDeleteRequest.UseVisualStyleBackColor = true;
            // 
            // btnEditProperty
            // 
            this.btnEditProperty.Location = new System.Drawing.Point(238, 150);
            this.btnEditProperty.Name = "btnEditProperty";
            this.btnEditProperty.Size = new System.Drawing.Size(90, 23);
            this.btnEditProperty.TabIndex = 14;
            this.btnEditProperty.Text = "btnEditProperty";
            this.btnEditProperty.UseVisualStyleBackColor = true;
            this.btnEditProperty.Click += new System.EventHandler(this.btnEditProperty_Click);
            // 
            // btnEditRequest
            // 
            this.btnEditRequest.Location = new System.Drawing.Point(825, 428);
            this.btnEditRequest.Name = "btnEditRequest";
            this.btnEditRequest.Size = new System.Drawing.Size(97, 23);
            this.btnEditRequest.TabIndex = 15;
            this.btnEditRequest.Text = "btnEditRequest";
            this.btnEditRequest.UseVisualStyleBackColor = true;
            // 
            // propertiesTableAdapter
            // 
            this.propertiesTableAdapter.ClearBeforeFill = true;
            // 
            // agentsTableAdapter
            // 
            this.agentsTableAdapter.ClearBeforeFill = true;
            // 
            // requestsTableAdapter
            // 
            this.requestsTableAdapter.ClearBeforeFill = true;
            // 
            // AgentID
            // 
            this.AgentID.Location = new System.Drawing.Point(438, 179);
            this.AgentID.Name = "AgentID";
            this.AgentID.Size = new System.Drawing.Size(100, 20);
            this.AgentID.TabIndex = 16;
            this.AgentID.Text = "AgentID";
            // 
            // propertiesTableAdapter1
            // 
            this.propertiesTableAdapter1.ClearBeforeFill = true;
            // 
            // agentsTableAdapter1
            // 
            this.agentsTableAdapter1.ClearBeforeFill = true;
            // 
            // requestsTableAdapter1
            // 
            this.requestsTableAdapter1.ClearBeforeFill = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 692);
            this.Controls.Add(this.AgentID);
            this.Controls.Add(this.btnEditRequest);
            this.Controls.Add(this.btnEditProperty);
            this.Controls.Add(this.btnDeleteRequest);
            this.Controls.Add(this.btnDeleteAgent);
            this.Controls.Add(this.btnDeleteProperty);
            this.Controls.Add(this.btnAddAgent);
            this.Controls.Add(this.btnAddProperty);
            this.Controls.Add(this.RequestStatus);
            this.Controls.Add(this.AgentPhoneNumber);
            this.Controls.Add(this.AgentName);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.PropertyType);
            this.Controls.Add(this.dgvRequests);
            this.Controls.Add(this.dgvAgents);
            this.Controls.Add(this.dgvProperties);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseEstateDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseEstateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseEstateDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseEstateDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseEstateDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseEstateDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProperties;
        private System.Windows.Forms.DataGridView dgvAgents;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.TextBox PropertyType;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.TextBox AgentName;
        private System.Windows.Forms.TextBox AgentPhoneNumber;
        private System.Windows.Forms.TextBox RequestStatus;
        private System.Windows.Forms.Button btnAddProperty;
        private System.Windows.Forms.Button btnAddAgent;
        private System.Windows.Forms.Button btnDeleteProperty;
        private System.Windows.Forms.Button btnDeleteAgent;
        private System.Windows.Forms.Button btnDeleteRequest;
        private System.Windows.Forms.Button btnEditProperty;
        private System.Windows.Forms.Button btnEditRequest;
        private EstateAgency.HouseEstateDataSet houseEstateDataSet;
        private System.Windows.Forms.BindingSource propertiesBindingSource;
        private EstateAgency.HouseEstateDataSetTableAdapters.PropertiesTableAdapter propertiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentIDDataGridViewTextBoxColumn;
        private EstateAgency.HouseEstateDataSet1 houseEstateDataSet1;
        private System.Windows.Forms.BindingSource agentsBindingSource;
        private EstateAgency.HouseEstateDataSet1TableAdapters.AgentsTableAdapter agentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private EstateAgency.HouseEstateDataSet2 houseEstateDataSet2;
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private EstateAgency.HouseEstateDataSet2TableAdapters.RequestsTableAdapter requestsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox AgentID;
        private EstateAgency.HouseEstateDataSet3 houseEstateDataSet3;
        private System.Windows.Forms.BindingSource propertiesBindingSource1;
        private EstateAgency.HouseEstateDataSet3TableAdapters.PropertiesTableAdapter propertiesTableAdapter1;
        private EstateAgency.HouseEstateDataSet4 houseEstateDataSet4;
        private System.Windows.Forms.BindingSource agentsBindingSource1;
        private EstateAgency.HouseEstateDataSet4TableAdapters.AgentsTableAdapter agentsTableAdapter1;
        private EstateAgency.HouseEstateDataSet5 houseEstateDataSet5;
        private System.Windows.Forms.BindingSource requestsBindingSource1;
        private EstateAgency.HouseEstateDataSet5TableAdapters.RequestsTableAdapter requestsTableAdapter1;
    }
}
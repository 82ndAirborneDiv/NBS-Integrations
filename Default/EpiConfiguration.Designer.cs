﻿namespace Default
{
    partial class EpiConfiguration
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
            this.btn_Browse = new System.Windows.Forms.Button();
            this.txtExConditions = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustodianId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAuthorId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStateId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFormName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtApiUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvConfig = new System.Windows.Forms.DataGridView();
            this.clmSelectq = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmConfigId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFormName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Browse.ForeColor = System.Drawing.Color.White;
            this.btn_Browse.Location = new System.Drawing.Point(425, 624);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(168, 45);
            this.btn_Browse.TabIndex = 0;
            this.btn_Browse.Text = "Edit";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtExConditions
            // 
            this.txtExConditions.Location = new System.Drawing.Point(164, 256);
            this.txtExConditions.Multiline = true;
            this.txtExConditions.Name = "txtExConditions";
            this.txtExConditions.Size = new System.Drawing.Size(395, 62);
            this.txtExConditions.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(16, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Conditions to exclude: ";
            // 
            // txtCustodianId
            // 
            this.txtCustodianId.Location = new System.Drawing.Point(164, 218);
            this.txtCustodianId.Name = "txtCustodianId";
            this.txtCustodianId.Size = new System.Drawing.Size(395, 22);
            this.txtCustodianId.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(16, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Custodian ID: ";
            // 
            // txtAuthorId
            // 
            this.txtAuthorId.Location = new System.Drawing.Point(164, 179);
            this.txtAuthorId.Name = "txtAuthorId";
            this.txtAuthorId.Size = new System.Drawing.Size(395, 22);
            this.txtAuthorId.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(16, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Author ID: ";
            // 
            // txtStateId
            // 
            this.txtStateId.Location = new System.Drawing.Point(164, 140);
            this.txtStateId.Name = "txtStateId";
            this.txtStateId.Size = new System.Drawing.Size(395, 22);
            this.txtStateId.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(16, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "State OID: ";
            // 
            // txtFormName
            // 
            this.txtFormName.Enabled = false;
            this.txtFormName.Location = new System.Drawing.Point(164, 101);
            this.txtFormName.Name = "txtFormName";
            this.txtFormName.Size = new System.Drawing.Size(395, 22);
            this.txtFormName.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(16, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Form Name: ";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(228, 624);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 45);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtApiUrl
            // 
            this.txtApiUrl.Enabled = false;
            this.txtApiUrl.Location = new System.Drawing.Point(164, 64);
            this.txtApiUrl.Name = "txtApiUrl";
            this.txtApiUrl.Size = new System.Drawing.Size(395, 22);
            this.txtApiUrl.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(16, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "DataSource:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "EPI INFO CONFIGURATION";
            // 
            // dgvConfig
            // 
            this.dgvConfig.AllowUserToAddRows = false;
            this.dgvConfig.AllowUserToDeleteRows = false;
            this.dgvConfig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConfig.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvConfig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSelectq,
            this.clmConfigId,
            this.clmFormName});
            this.dgvConfig.EnableHeadersVisualStyles = false;
            this.dgvConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvConfig.Location = new System.Drawing.Point(16, 337);
            this.dgvConfig.Name = "dgvConfig";
            this.dgvConfig.RowHeadersVisible = false;
            this.dgvConfig.RowTemplate.Height = 24;
            this.dgvConfig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConfig.Size = new System.Drawing.Size(780, 281);
            this.dgvConfig.TabIndex = 36;
            this.dgvConfig.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConfig_CellClick);
            // 
            // clmSelectq
            // 
            this.clmSelectq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmSelectq.HeaderText = "";
            this.clmSelectq.Name = "clmSelectq";
            this.clmSelectq.Width = 5;
            // 
            // clmConfigId
            // 
            this.clmConfigId.HeaderText = "Config ID";
            this.clmConfigId.Name = "clmConfigId";
            // 
            // clmFormName
            // 
            this.clmFormName.HeaderText = "Form Name";
            this.clmFormName.Name = "clmFormName";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(612, 624);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(173, 45);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(35, 624);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(173, 45);
            this.btnAddNew.TabIndex = 38;
            this.btnAddNew.Text = "Create";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 259;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Config ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 259;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Form Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 259;
            // 
            // EpiConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 688);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvConfig);
            this.Controls.Add(this.txtExConditions);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCustodianId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAuthorId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStateId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFormName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtApiUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Browse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EpiConfiguration";
            this.Text = "EpiConfiguration";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.TextBox txtExConditions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustodianId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAuthorId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStateId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFormName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtApiUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvConfig;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmSelectq;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmConfigId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFormName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
namespace quiet_attick_production
{
    partial class viewform
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
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quiet_Attic_FilmsDataSet1 = new quiet_attick_production.Quiet_Attic_FilmsDataSet1();
            this.clientTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.film_productionDataSet = new quiet_attick_production.film_productionDataSet();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.client_TableTableAdapter = new quiet_attick_production.film_productionDataSetTableAdapters.Client_TableTableAdapter();
            this.clientTableAdapter = new quiet_attick_production.Quiet_Attic_FilmsDataSet1TableAdapters.ClientTableAdapter();
            this.dgv_client = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiet_Attic_FilmsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.film_productionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).BeginInit();
            this.SuspendLayout();
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.quiet_Attic_FilmsDataSet1;
            // 
            // quiet_Attic_FilmsDataSet1
            // 
            this.quiet_Attic_FilmsDataSet1.DataSetName = "Quiet_Attic_FilmsDataSet1";
            this.quiet_Attic_FilmsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableBindingSource
            // 
            this.clientTableBindingSource.DataMember = "Client_Table";
            this.clientTableBindingSource.DataSource = this.film_productionDataSet;
            // 
            // film_productionDataSet
            // 
            this.film_productionDataSet.DataSetName = "film_productionDataSet";
            this.film_productionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(25, 18);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(108, 31);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "<-- Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(833, 402);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(108, 31);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "<EXIT>";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // client_TableTableAdapter
            // 
            this.client_TableTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_client
            // 
            this.dgv_client.AllowUserToAddRows = false;
            this.dgv_client.AllowUserToDeleteRows = false;
            this.dgv_client.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_client.Location = new System.Drawing.Point(25, 79);
            this.dgv_client.Name = "dgv_client";
            this.dgv_client.ReadOnly = true;
            this.dgv_client.RowHeadersWidth = 51;
            this.dgv_client.RowTemplate.Height = 24;
            this.dgv_client.Size = new System.Drawing.Size(902, 305);
            this.dgv_client.TabIndex = 2;
            this.dgv_client.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_client_CellContentClick);
            // 
            // viewform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 442);
            this.Controls.Add(this.dgv_client);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_back);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "viewform";
            this.Text = "View Clients";
            this.Load += new System.EventHandler(this.viewform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiet_Attic_FilmsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.film_productionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_exit;
        private film_productionDataSet film_productionDataSet;
        private System.Windows.Forms.BindingSource clientTableBindingSource;
        private film_productionDataSetTableAdapters.Client_TableTableAdapter client_TableTableAdapter;
        private Quiet_Attic_FilmsDataSet1 quiet_Attic_FilmsDataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private Quiet_Attic_FilmsDataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridView dgv_client;
    }
}
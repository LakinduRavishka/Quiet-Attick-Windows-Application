namespace quiet_attick_production
{
    partial class staff
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_actor = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_pay = new System.Windows.Forms.Button();
            this.btn_loca = new System.Windows.Forms.Button();
            this.btn_clients = new System.Windows.Forms.Button();
            this.actoruc1 = new quiet_attick_production.actoruc();
            this.paymentuc1 = new quiet_attick_production.paymentuc();
            this.locationuc1 = new quiet_attick_production.locationuc();
            this.clientuc1 = new quiet_attick_production.clientuc();
            this.staffuc1 = new quiet_attick_production.staffuc();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btn_actor);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_pay);
            this.panel1.Controls.Add(this.btn_loca);
            this.panel1.Controls.Add(this.btn_clients);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 548);
            this.panel1.TabIndex = 0;
            // 
            // btn_actor
            // 
            this.btn_actor.BackColor = System.Drawing.Color.White;
            this.btn_actor.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actor.Location = new System.Drawing.Point(3, 374);
            this.btn_actor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_actor.Name = "btn_actor";
            this.btn_actor.Size = new System.Drawing.Size(276, 58);
            this.btn_actor.TabIndex = 3;
            this.btn_actor.Text = "Actors";
            this.btn_actor.UseVisualStyleBackColor = false;
            this.btn_actor.Click += new System.EventHandler(this.btn_actor_Click_1);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Red;
            this.btn_logout.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(195, 460);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(84, 30);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_pay
            // 
            this.btn_pay.BackColor = System.Drawing.Color.White;
            this.btn_pay.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.Location = new System.Drawing.Point(3, 277);
            this.btn_pay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(276, 58);
            this.btn_pay.TabIndex = 1;
            this.btn_pay.Text = "Payment";
            this.btn_pay.UseVisualStyleBackColor = false;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // btn_loca
            // 
            this.btn_loca.BackColor = System.Drawing.Color.White;
            this.btn_loca.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loca.Location = new System.Drawing.Point(3, 180);
            this.btn_loca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_loca.Name = "btn_loca";
            this.btn_loca.Size = new System.Drawing.Size(276, 66);
            this.btn_loca.TabIndex = 0;
            this.btn_loca.Text = "Locations";
            this.btn_loca.UseVisualStyleBackColor = false;
            this.btn_loca.Click += new System.EventHandler(this.btn_loca_Click);
            // 
            // btn_clients
            // 
            this.btn_clients.BackColor = System.Drawing.Color.White;
            this.btn_clients.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clients.Location = new System.Drawing.Point(3, 82);
            this.btn_clients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.Size = new System.Drawing.Size(276, 66);
            this.btn_clients.TabIndex = 0;
            this.btn_clients.Text = "Clients";
            this.btn_clients.UseVisualStyleBackColor = false;
            this.btn_clients.Click += new System.EventHandler(this.btn_clients_Click);
            // 
            // actoruc1
            // 
            this.actoruc1.Location = new System.Drawing.Point(285, 0);
            this.actoruc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.actoruc1.Name = "actoruc1";
            this.actoruc1.Size = new System.Drawing.Size(925, 582);
            this.actoruc1.TabIndex = 5;
            this.actoruc1.Load += new System.EventHandler(this.actoruc1_Load);
            // 
            // paymentuc1
            // 
            this.paymentuc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentuc1.Location = new System.Drawing.Point(284, 0);
            this.paymentuc1.Margin = new System.Windows.Forms.Padding(2);
            this.paymentuc1.Name = "paymentuc1";
            this.paymentuc1.Size = new System.Drawing.Size(960, 576);
            this.paymentuc1.TabIndex = 4;
            this.paymentuc1.Load += new System.EventHandler(this.paymentuc1_Load);
            // 
            // locationuc1
            // 
            this.locationuc1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.locationuc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationuc1.Location = new System.Drawing.Point(285, 0);
            this.locationuc1.Margin = new System.Windows.Forms.Padding(2);
            this.locationuc1.Name = "locationuc1";
            this.locationuc1.Size = new System.Drawing.Size(944, 576);
            this.locationuc1.TabIndex = 3;
            // 
            // clientuc1
            // 
            this.clientuc1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.clientuc1.Location = new System.Drawing.Point(284, 0);
            this.clientuc1.Margin = new System.Windows.Forms.Padding(2);
            this.clientuc1.Name = "clientuc1";
            this.clientuc1.Size = new System.Drawing.Size(946, 578);
            this.clientuc1.TabIndex = 2;
            // 
            // staffuc1
            // 
            this.staffuc1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.staffuc1.Location = new System.Drawing.Point(284, 2);
            this.staffuc1.Margin = new System.Windows.Forms.Padding(2);
            this.staffuc1.Name = "staffuc1";
            this.staffuc1.Size = new System.Drawing.Size(944, 574);
            this.staffuc1.TabIndex = 1;
            // 
            // staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 548);
            this.Controls.Add(this.actoruc1);
            this.Controls.Add(this.paymentuc1);
            this.Controls.Add(this.locationuc1);
            this.Controls.Add(this.clientuc1);
            this.Controls.Add(this.staffuc1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1162, 599);
            this.Name = "staff";
            this.Text = "Staff Use";
            this.Load += new System.EventHandler(this.staff_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_loca;
        private System.Windows.Forms.Button btn_clients;
        private staffuc staffuc1;
        private clientuc clientuc1;
        private locationuc locationuc1;
        private paymentuc paymentuc1;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_actor;
        private actoruc actoruc1;
    }
}
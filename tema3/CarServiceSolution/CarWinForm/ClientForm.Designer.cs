namespace CarWinForm
{
    partial class ClientForm
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
            this.dgvAutoes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblClientSurname = new System.Windows.Forms.Label();
            this.lblClientAddress = new System.Windows.Forms.Label();
            this.lblClientCity = new System.Windows.Forms.Label();
            this.lblClientCounty = new System.Windows.Forms.Label();
            this.lblClientTelephone = new System.Windows.Forms.Label();
            this.lblClientEmail = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutoes
            // 
            this.dgvAutoes.AllowUserToAddRows = false;
            this.dgvAutoes.AllowUserToDeleteRows = false;
            this.dgvAutoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutoes.Location = new System.Drawing.Point(12, 12);
            this.dgvAutoes.Name = "dgvAutoes";
            this.dgvAutoes.ReadOnly = true;
            this.dgvAutoes.Size = new System.Drawing.Size(428, 397);
            this.dgvAutoes.TabIndex = 0;
            this.dgvAutoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutoes_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(428, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Car";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Client Surname: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Address: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "City: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(500, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "County";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(500, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Telephone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(503, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Email: ";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(584, 12);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(27, 13);
            this.lblClientName.TabIndex = 15;
            this.lblClientName.Text = "N/A";
            // 
            // lblClientSurname
            // 
            this.lblClientSurname.AutoSize = true;
            this.lblClientSurname.Location = new System.Drawing.Point(584, 38);
            this.lblClientSurname.Name = "lblClientSurname";
            this.lblClientSurname.Size = new System.Drawing.Size(27, 13);
            this.lblClientSurname.TabIndex = 16;
            this.lblClientSurname.Text = "N/A";
            // 
            // lblClientAddress
            // 
            this.lblClientAddress.AutoSize = true;
            this.lblClientAddress.Location = new System.Drawing.Point(584, 64);
            this.lblClientAddress.Name = "lblClientAddress";
            this.lblClientAddress.Size = new System.Drawing.Size(27, 13);
            this.lblClientAddress.TabIndex = 17;
            this.lblClientAddress.Text = "N/A";
            // 
            // lblClientCity
            // 
            this.lblClientCity.AutoSize = true;
            this.lblClientCity.Location = new System.Drawing.Point(584, 90);
            this.lblClientCity.Name = "lblClientCity";
            this.lblClientCity.Size = new System.Drawing.Size(27, 13);
            this.lblClientCity.TabIndex = 18;
            this.lblClientCity.Text = "N/A";
            // 
            // lblClientCounty
            // 
            this.lblClientCounty.AutoSize = true;
            this.lblClientCounty.Location = new System.Drawing.Point(584, 116);
            this.lblClientCounty.Name = "lblClientCounty";
            this.lblClientCounty.Size = new System.Drawing.Size(27, 13);
            this.lblClientCounty.TabIndex = 19;
            this.lblClientCounty.Text = "N/A";
            // 
            // lblClientTelephone
            // 
            this.lblClientTelephone.AutoSize = true;
            this.lblClientTelephone.Location = new System.Drawing.Point(584, 142);
            this.lblClientTelephone.Name = "lblClientTelephone";
            this.lblClientTelephone.Size = new System.Drawing.Size(27, 13);
            this.lblClientTelephone.TabIndex = 20;
            this.lblClientTelephone.Text = "N/A";
            // 
            // lblClientEmail
            // 
            this.lblClientEmail.AutoSize = true;
            this.lblClientEmail.Location = new System.Drawing.Point(584, 176);
            this.lblClientEmail.Name = "lblClientEmail";
            this.lblClientEmail.Size = new System.Drawing.Size(27, 13);
            this.lblClientEmail.TabIndex = 21;
            this.lblClientEmail.Text = "N/A";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(587, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Edit Client";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Client Id:";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(554, 420);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(27, 13);
            this.lblClientID.TabIndex = 24;
            this.lblClientID.Text = "N/A";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblClientEmail);
            this.Controls.Add(this.lblClientTelephone);
            this.Controls.Add(this.lblClientCounty);
            this.Controls.Add(this.lblClientCity);
            this.Controls.Add(this.lblClientAddress);
            this.Controls.Add(this.lblClientSurname);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAutoes);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutoes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblClientSurname;
        private System.Windows.Forms.Label lblClientAddress;
        private System.Windows.Forms.Label lblClientCity;
        private System.Windows.Forms.Label lblClientCounty;
        private System.Windows.Forms.Label lblClientTelephone;
        private System.Windows.Forms.Label lblClientEmail;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClientID;
    }
}
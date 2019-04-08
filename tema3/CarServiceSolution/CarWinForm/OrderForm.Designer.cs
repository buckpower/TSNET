namespace CarWinForm
{
    partial class OrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblAutoNr = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.cbxOrderStatus = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pbxAuto = new System.Windows.Forms.PictureBox();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.btnUploadImg = new System.Windows.Forms.Button();
            this.btnImgPrev = new System.Windows.Forms.Button();
            this.btnImgNxt = new System.Windows.Forms.Button();
            this.cbxLeft = new System.Windows.Forms.CheckBox();
            this.lblKm = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Auto Nr:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(85, 12);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(27, 13);
            this.lblClientName.TabIndex = 2;
            this.lblClientName.Text = "N/A";
            // 
            // lblAutoNr
            // 
            this.lblAutoNr.AutoSize = true;
            this.lblAutoNr.Location = new System.Drawing.Point(214, 12);
            this.lblAutoNr.Name = "lblAutoNr";
            this.lblAutoNr.Size = new System.Drawing.Size(27, 13);
            this.lblAutoNr.TabIndex = 3;
            this.lblAutoNr.Text = "N/A";
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Location = new System.Drawing.Point(276, 12);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(37, 13);
            this.lblOrderStatus.TabIndex = 4;
            this.lblOrderStatus.Text = "Status";
            // 
            // cbxOrderStatus
            // 
            this.cbxOrderStatus.FormattingEnabled = true;
            this.cbxOrderStatus.Location = new System.Drawing.Point(319, 9);
            this.cbxOrderStatus.Name = "cbxOrderStatus";
            this.cbxOrderStatus.Size = new System.Drawing.Size(121, 21);
            this.cbxOrderStatus.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 48);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(428, 163);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Appointment Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 252);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // pbxAuto
            // 
            this.pbxAuto.Location = new System.Drawing.Point(528, 64);
            this.pbxAuto.Name = "pbxAuto";
            this.pbxAuto.Size = new System.Drawing.Size(187, 130);
            this.pbxAuto.TabIndex = 10;
            this.pbxAuto.TabStop = false;
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList.ImageSize = new System.Drawing.Size(16, 16);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnUploadImg
            // 
            this.btnUploadImg.Location = new System.Drawing.Point(567, 200);
            this.btnUploadImg.Name = "btnUploadImg";
            this.btnUploadImg.Size = new System.Drawing.Size(106, 23);
            this.btnUploadImg.TabIndex = 11;
            this.btnUploadImg.Text = "Upload Image";
            this.btnUploadImg.UseVisualStyleBackColor = true;
            // 
            // btnImgPrev
            // 
            this.btnImgPrev.Location = new System.Drawing.Point(493, 114);
            this.btnImgPrev.Name = "btnImgPrev";
            this.btnImgPrev.Size = new System.Drawing.Size(29, 29);
            this.btnImgPrev.TabIndex = 12;
            this.btnImgPrev.Text = "<<";
            this.btnImgPrev.UseVisualStyleBackColor = true;
            // 
            // btnImgNxt
            // 
            this.btnImgNxt.Location = new System.Drawing.Point(721, 114);
            this.btnImgNxt.Name = "btnImgNxt";
            this.btnImgNxt.Size = new System.Drawing.Size(29, 29);
            this.btnImgNxt.TabIndex = 13;
            this.btnImgNxt.Text = ">>";
            this.btnImgNxt.UseVisualStyleBackColor = true;
            // 
            // cbxLeft
            // 
            this.cbxLeft.AutoSize = true;
            this.cbxLeft.Location = new System.Drawing.Point(298, 289);
            this.cbxLeft.Name = "cbxLeft";
            this.cbxLeft.Size = new System.Drawing.Size(142, 17);
            this.cbxLeft.TabIndex = 15;
            this.cbxLeft.Text = "Auto remained in service";
            this.cbxLeft.UseVisualStyleBackColor = true;
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Location = new System.Drawing.Point(9, 292);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(80, 13);
            this.lblKm.TabIndex = 16;
            this.lblKm.Text = "Dashboard Km:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(493, 402);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save Order";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(217, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.cbxLeft);
            this.Controls.Add(this.btnImgNxt);
            this.Controls.Add(this.btnImgPrev);
            this.Controls.Add(this.btnUploadImg);
            this.Controls.Add(this.pbxAuto);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cbxOrderStatus);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.lblAutoNr);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderForm";
            this.Text = "Order Form";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblAutoNr;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.ComboBox cbxOrderStatus;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pbxAuto;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Button btnUploadImg;
        private System.Windows.Forms.Button btnImgPrev;
        private System.Windows.Forms.Button btnImgNxt;
        private System.Windows.Forms.CheckBox cbxLeft;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
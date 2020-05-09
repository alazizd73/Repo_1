namespace Groep9_SE7
{
    partial class ConfirmationForm
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
            this.title_lbl = new System.Windows.Forms.Label();
            this.dest_lbl = new System.Windows.Forms.Label();
            this.dest_out_lbl = new System.Windows.Forms.Label();
            this.start_date_lbl = new System.Windows.Forms.Label();
            this.end_date_lbl = new System.Windows.Forms.Label();
            this.endDate_out_lbl = new System.Windows.Forms.Label();
            this.Cust_lbl = new System.Windows.Forms.Label();
            this.Cust_out_lbl = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.start_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.excur_out_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.price_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tprice_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Sitka Small", 14F, System.Drawing.FontStyle.Bold);
            this.title_lbl.ForeColor = System.Drawing.Color.Maroon;
            this.title_lbl.Location = new System.Drawing.Point(35, 26);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(242, 28);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Booking Confirmation ";
            // 
            // dest_lbl
            // 
            this.dest_lbl.AutoSize = true;
            this.dest_lbl.Location = new System.Drawing.Point(51, 83);
            this.dest_lbl.Name = "dest_lbl";
            this.dest_lbl.Size = new System.Drawing.Size(65, 13);
            this.dest_lbl.TabIndex = 1;
            this.dest_lbl.Text = "Destination:";
            this.dest_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // dest_out_lbl
            // 
            this.dest_out_lbl.AutoSize = true;
            this.dest_out_lbl.Location = new System.Drawing.Point(150, 83);
            this.dest_out_lbl.Name = "dest_out_lbl";
            this.dest_out_lbl.Size = new System.Drawing.Size(35, 13);
            this.dest_out_lbl.TabIndex = 2;
            this.dest_out_lbl.Text = "label1";
            // 
            // start_date_lbl
            // 
            this.start_date_lbl.AutoSize = true;
            this.start_date_lbl.Location = new System.Drawing.Point(51, 113);
            this.start_date_lbl.Name = "start_date_lbl";
            this.start_date_lbl.Size = new System.Drawing.Size(60, 13);
            this.start_date_lbl.TabIndex = 3;
            this.start_date_lbl.Text = "Start date:";
            // 
            // end_date_lbl
            // 
            this.end_date_lbl.AutoSize = true;
            this.end_date_lbl.Location = new System.Drawing.Point(51, 141);
            this.end_date_lbl.Name = "end_date_lbl";
            this.end_date_lbl.Size = new System.Drawing.Size(54, 13);
            this.end_date_lbl.TabIndex = 5;
            this.end_date_lbl.Text = "End date:";
            // 
            // endDate_out_lbl
            // 
            this.endDate_out_lbl.AutoSize = true;
            this.endDate_out_lbl.Location = new System.Drawing.Point(150, 141);
            this.endDate_out_lbl.Name = "endDate_out_lbl";
            this.endDate_out_lbl.Size = new System.Drawing.Size(35, 13);
            this.endDate_out_lbl.TabIndex = 6;
            this.endDate_out_lbl.Text = "label3";
            // 
            // Cust_lbl
            // 
            this.Cust_lbl.AutoSize = true;
            this.Cust_lbl.Location = new System.Drawing.Point(50, 248);
            this.Cust_lbl.Name = "Cust_lbl";
            this.Cust_lbl.Size = new System.Drawing.Size(66, 13);
            this.Cust_lbl.TabIndex = 7;
            this.Cust_lbl.Text = "Customer/s:";
            this.Cust_lbl.Click += new System.EventHandler(this.Cust_lbl_Click);
            // 
            // Cust_out_lbl
            // 
            this.Cust_out_lbl.AutoSize = true;
            this.Cust_out_lbl.Location = new System.Drawing.Point(150, 248);
            this.Cust_out_lbl.Name = "Cust_out_lbl";
            this.Cust_out_lbl.Size = new System.Drawing.Size(35, 13);
            this.Cust_out_lbl.TabIndex = 8;
            this.Cust_out_lbl.Text = "label2";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(289, 103);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(132, 32);
            this.save_btn.TabIndex = 9;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(289, 160);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(132, 32);
            this.edit_btn.TabIndex = 10;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(289, 218);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(132, 32);
            this.Cancel_btn.TabIndex = 11;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // start_lbl
            // 
            this.start_lbl.AutoSize = true;
            this.start_lbl.Location = new System.Drawing.Point(150, 113);
            this.start_lbl.Name = "start_lbl";
            this.start_lbl.Size = new System.Drawing.Size(35, 13);
            this.start_lbl.TabIndex = 12;
            this.start_lbl.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Excursion/s:";
            // 
            // excur_out_lbl
            // 
            this.excur_out_lbl.AutoSize = true;
            this.excur_out_lbl.Location = new System.Drawing.Point(150, 197);
            this.excur_out_lbl.Name = "excur_out_lbl";
            this.excur_out_lbl.Size = new System.Drawing.Size(35, 13);
            this.excur_out_lbl.TabIndex = 14;
            this.excur_out_lbl.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Price:";
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.Location = new System.Drawing.Point(150, 170);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(35, 13);
            this.price_lbl.TabIndex = 16;
            this.price_lbl.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Totale price:";
            // 
            // tprice_lbl
            // 
            this.tprice_lbl.AutoSize = true;
            this.tprice_lbl.Location = new System.Drawing.Point(153, 448);
            this.tprice_lbl.Name = "tprice_lbl";
            this.tprice_lbl.Size = new System.Drawing.Size(35, 13);
            this.tprice_lbl.TabIndex = 18;
            this.tprice_lbl.Text = "label4";
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 561);
            this.Controls.Add(this.tprice_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.excur_out_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start_lbl);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.Cust_out_lbl);
            this.Controls.Add(this.Cust_lbl);
            this.Controls.Add(this.endDate_out_lbl);
            this.Controls.Add(this.end_date_lbl);
            this.Controls.Add(this.start_date_lbl);
            this.Controls.Add(this.dest_out_lbl);
            this.Controls.Add(this.dest_lbl);
            this.Controls.Add(this.title_lbl);
            this.Name = "ConfirmationForm";
            this.Text = "ConfirmationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label dest_lbl;
        private System.Windows.Forms.Label dest_out_lbl;
        private System.Windows.Forms.Label start_date_lbl;
        private System.Windows.Forms.Label end_date_lbl;
        private System.Windows.Forms.Label endDate_out_lbl;
        private System.Windows.Forms.Label Cust_lbl;
        private System.Windows.Forms.Label Cust_out_lbl;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Label start_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label excur_out_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tprice_lbl;
    }
}
namespace Groep9_SE7
{
    partial class ReisForm
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
            this.reistype_lbl = new System.Windows.Forms.Label();
            this.reis_type_cb = new System.Windows.Forms.ComboBox();
            this.Travel_product_details_lbl = new System.Windows.Forms.Label();
            this.start_d_lbl = new System.Windows.Forms.Label();
            this.start_date = new System.Windows.Forms.DateTimePicker();
            this.end_d_lbl = new System.Windows.Forms.Label();
            this.end_date = new System.Windows.Forms.DateTimePicker();
            this.cust_listBox = new System.Windows.Forms.ListBox();
            this.CC_lbl = new System.Windows.Forms.Label();
            this.SC_lbl = new System.Windows.Forms.Label();
            this.undo_btn = new System.Windows.Forms.Button();
            this.last_listbox = new System.Windows.Forms.ListBox();
            this.conf_btn = new System.Windows.Forms.Button();
            this.exu1_lbl = new System.Windows.Forms.Label();
            this.excu_listbox = new System.Windows.Forms.ListBox();
            this.sExcu_listbox = new System.Windows.Forms.ListBox();
            this.excu2_lbl = new System.Windows.Forms.Label();
            this.undo2_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reistype_lbl
            // 
            this.reistype_lbl.AutoSize = true;
            this.reistype_lbl.Location = new System.Drawing.Point(93, 65);
            this.reistype_lbl.Name = "reistype_lbl";
            this.reistype_lbl.Size = new System.Drawing.Size(64, 13);
            this.reistype_lbl.TabIndex = 0;
            this.reistype_lbl.Text = "Description:";
            this.reistype_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // reis_type_cb
            // 
            this.reis_type_cb.FormattingEnabled = true;
            this.reis_type_cb.Location = new System.Drawing.Point(186, 62);
            this.reis_type_cb.Name = "reis_type_cb";
            this.reis_type_cb.Size = new System.Drawing.Size(170, 21);
            this.reis_type_cb.TabIndex = 1;
            this.reis_type_cb.SelectedIndexChanged += new System.EventHandler(this.reis_type_cb_SelectedIndexChanged);
            // 
            // Travel_product_details_lbl
            // 
            this.Travel_product_details_lbl.AutoSize = true;
            this.Travel_product_details_lbl.Location = new System.Drawing.Point(96, 111);
            this.Travel_product_details_lbl.Name = "Travel_product_details_lbl";
            this.Travel_product_details_lbl.Size = new System.Drawing.Size(35, 13);
            this.Travel_product_details_lbl.TabIndex = 2;
            this.Travel_product_details_lbl.Text = "label1";
            this.Travel_product_details_lbl.Click += new System.EventHandler(this.T_pro_lbl_Click);
            // 
            // start_d_lbl
            // 
            this.start_d_lbl.AutoSize = true;
            this.start_d_lbl.Location = new System.Drawing.Point(93, 168);
            this.start_d_lbl.Name = "start_d_lbl";
            this.start_d_lbl.Size = new System.Drawing.Size(60, 13);
            this.start_d_lbl.TabIndex = 3;
            this.start_d_lbl.Text = "Start date:";
            // 
            // start_date
            // 
            this.start_date.Location = new System.Drawing.Point(96, 196);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(200, 20);
            this.start_date.TabIndex = 4;
            this.start_date.ValueChanged += new System.EventHandler(this.start_date_ValueChanged);
            // 
            // end_d_lbl
            // 
            this.end_d_lbl.AutoSize = true;
            this.end_d_lbl.Location = new System.Drawing.Point(345, 168);
            this.end_d_lbl.Name = "end_d_lbl";
            this.end_d_lbl.Size = new System.Drawing.Size(54, 13);
            this.end_d_lbl.TabIndex = 5;
            this.end_d_lbl.Text = "End date:";
            // 
            // end_date
            // 
            this.end_date.Location = new System.Drawing.Point(348, 196);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(200, 20);
            this.end_date.TabIndex = 6;
            this.end_date.ValueChanged += new System.EventHandler(this.end_date_ValueChanged);
            // 
            // cust_listBox
            // 
            this.cust_listBox.FormattingEnabled = true;
            this.cust_listBox.Location = new System.Drawing.Point(96, 260);
            this.cust_listBox.Name = "cust_listBox";
            this.cust_listBox.Size = new System.Drawing.Size(211, 95);
            this.cust_listBox.TabIndex = 7;
            this.cust_listBox.SelectedIndexChanged += new System.EventHandler(this.cust_listBox_SelectedIndexChanged);
            // 
            // CC_lbl
            // 
            this.CC_lbl.AutoSize = true;
            this.CC_lbl.Location = new System.Drawing.Point(93, 233);
            this.CC_lbl.Name = "CC_lbl";
            this.CC_lbl.Size = new System.Drawing.Size(96, 13);
            this.CC_lbl.TabIndex = 8;
            this.CC_lbl.Text = "Current customers";
            // 
            // SC_lbl
            // 
            this.SC_lbl.AutoSize = true;
            this.SC_lbl.Location = new System.Drawing.Point(345, 233);
            this.SC_lbl.Name = "SC_lbl";
            this.SC_lbl.Size = new System.Drawing.Size(100, 13);
            this.SC_lbl.TabIndex = 10;
            this.SC_lbl.Text = "Selected customers";
            // 
            // undo_btn
            // 
            this.undo_btn.Location = new System.Drawing.Point(473, 228);
            this.undo_btn.Name = "undo_btn";
            this.undo_btn.Size = new System.Drawing.Size(75, 23);
            this.undo_btn.TabIndex = 12;
            this.undo_btn.Text = "Undo";
            this.undo_btn.UseVisualStyleBackColor = true;
            this.undo_btn.Click += new System.EventHandler(this.undo_btn_Click);
            // 
            // last_listbox
            // 
            this.last_listbox.FormattingEnabled = true;
            this.last_listbox.Location = new System.Drawing.Point(348, 260);
            this.last_listbox.Name = "last_listbox";
            this.last_listbox.Size = new System.Drawing.Size(200, 95);
            this.last_listbox.TabIndex = 13;
            this.last_listbox.SelectedIndexChanged += new System.EventHandler(this.last_listbox_SelectedIndexChanged);
            // 
            // conf_btn
            // 
            this.conf_btn.Location = new System.Drawing.Point(96, 500);
            this.conf_btn.Name = "conf_btn";
            this.conf_btn.Size = new System.Drawing.Size(101, 23);
            this.conf_btn.TabIndex = 14;
            this.conf_btn.Text = "Book";
            this.conf_btn.UseVisualStyleBackColor = true;
            this.conf_btn.Click += new System.EventHandler(this.conf_btn_Click);
            // 
            // exu1_lbl
            // 
            this.exu1_lbl.AutoSize = true;
            this.exu1_lbl.Location = new System.Drawing.Point(96, 375);
            this.exu1_lbl.Name = "exu1_lbl";
            this.exu1_lbl.Size = new System.Drawing.Size(57, 13);
            this.exu1_lbl.TabIndex = 15;
            this.exu1_lbl.Text = "Excursion:";
            // 
            // excu_listbox
            // 
            this.excu_listbox.FormattingEnabled = true;
            this.excu_listbox.Location = new System.Drawing.Point(96, 403);
            this.excu_listbox.Name = "excu_listbox";
            this.excu_listbox.Size = new System.Drawing.Size(200, 82);
            this.excu_listbox.TabIndex = 16;
            this.excu_listbox.SelectedIndexChanged += new System.EventHandler(this.excu_listbox_SelectedIndexChanged);
            // 
            // sExcu_listbox
            // 
            this.sExcu_listbox.FormattingEnabled = true;
            this.sExcu_listbox.Location = new System.Drawing.Point(351, 403);
            this.sExcu_listbox.Name = "sExcu_listbox";
            this.sExcu_listbox.Size = new System.Drawing.Size(200, 82);
            this.sExcu_listbox.TabIndex = 17;
            this.sExcu_listbox.SelectedIndexChanged += new System.EventHandler(this.sExcu_listbox_SelectedIndexChanged);
            // 
            // excu2_lbl
            // 
            this.excu2_lbl.AutoSize = true;
            this.excu2_lbl.Location = new System.Drawing.Point(348, 375);
            this.excu2_lbl.Name = "excu2_lbl";
            this.excu2_lbl.Size = new System.Drawing.Size(97, 13);
            this.excu2_lbl.TabIndex = 18;
            this.excu2_lbl.Text = "Selected Excursion";
            // 
            // undo2_btn
            // 
            this.undo2_btn.Location = new System.Drawing.Point(473, 375);
            this.undo2_btn.Name = "undo2_btn";
            this.undo2_btn.Size = new System.Drawing.Size(75, 23);
            this.undo2_btn.TabIndex = 19;
            this.undo2_btn.Text = "Undo";
            this.undo2_btn.UseVisualStyleBackColor = true;
            this.undo2_btn.Click += new System.EventHandler(this.undo2_btn_Click);
            // 
            // ReisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 553);
            this.Controls.Add(this.undo2_btn);
            this.Controls.Add(this.excu2_lbl);
            this.Controls.Add(this.sExcu_listbox);
            this.Controls.Add(this.excu_listbox);
            this.Controls.Add(this.exu1_lbl);
            this.Controls.Add(this.conf_btn);
            this.Controls.Add(this.last_listbox);
            this.Controls.Add(this.undo_btn);
            this.Controls.Add(this.SC_lbl);
            this.Controls.Add(this.CC_lbl);
            this.Controls.Add(this.cust_listBox);
            this.Controls.Add(this.end_date);
            this.Controls.Add(this.end_d_lbl);
            this.Controls.Add(this.start_date);
            this.Controls.Add(this.start_d_lbl);
            this.Controls.Add(this.Travel_product_details_lbl);
            this.Controls.Add(this.reis_type_cb);
            this.Controls.Add(this.reistype_lbl);
            this.Name = "ReisForm";
            this.Text = "ReisForm";
            this.Load += new System.EventHandler(this.ReisForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reistype_lbl;
        private System.Windows.Forms.ComboBox reis_type_cb;
        private System.Windows.Forms.Label Travel_product_details_lbl;
        private System.Windows.Forms.Label start_d_lbl;
        private System.Windows.Forms.DateTimePicker start_date;
        private System.Windows.Forms.Label end_d_lbl;
        private System.Windows.Forms.DateTimePicker end_date;
        private System.Windows.Forms.ListBox cust_listBox;
        private System.Windows.Forms.Label CC_lbl;
        private System.Windows.Forms.Label SC_lbl;
        private System.Windows.Forms.Button undo_btn;
        private System.Windows.Forms.ListBox last_listbox;
        private System.Windows.Forms.Button conf_btn;
        private System.Windows.Forms.Label exu1_lbl;
        private System.Windows.Forms.ListBox excu_listbox;
        private System.Windows.Forms.ListBox sExcu_listbox;
        private System.Windows.Forms.Label excu2_lbl;
        private System.Windows.Forms.Button undo2_btn;
    }
}
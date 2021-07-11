
namespace login_and_Register_System.Forms
{
    partial class Form_LED
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
            this.textBox_Clock = new System.Windows.Forms.TextBox();
            this.label_Clock = new System.Windows.Forms.Label();
            this.textBox_NumberData = new System.Windows.Forms.TextBox();
            this.label_NumberData = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Update = new System.Windows.Forms.Button();
            this.textBox_Time = new System.Windows.Forms.TextBox();
            this.textBox_Device = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_Time = new System.Windows.Forms.Label();
            this.lable_Device = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.Data_lable = new System.Windows.Forms.Label();
            this.button_Retrieve = new System.Windows.Forms.Button();
            this.button_ShowData = new System.Windows.Forms.Button();
            this.button_Insert = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Clock
            // 
            this.textBox_Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Clock.Location = new System.Drawing.Point(69, 253);
            this.textBox_Clock.Name = "textBox_Clock";
            this.textBox_Clock.Size = new System.Drawing.Size(312, 22);
            this.textBox_Clock.TabIndex = 75;
            // 
            // label_Clock
            // 
            this.label_Clock.AutoSize = true;
            this.label_Clock.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Clock.Location = new System.Drawing.Point(-1, 256);
            this.label_Clock.Name = "label_Clock";
            this.label_Clock.Size = new System.Drawing.Size(64, 24);
            this.label_Clock.TabIndex = 74;
            this.label_Clock.Text = "Clock";
            // 
            // textBox_NumberData
            // 
            this.textBox_NumberData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NumberData.Location = new System.Drawing.Point(3, 333);
            this.textBox_NumberData.Name = "textBox_NumberData";
            this.textBox_NumberData.Size = new System.Drawing.Size(139, 29);
            this.textBox_NumberData.TabIndex = 73;
            // 
            // label_NumberData
            // 
            this.label_NumberData.AutoSize = true;
            this.label_NumberData.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NumberData.Location = new System.Drawing.Point(0, 298);
            this.label_NumberData.Name = "label_NumberData";
            this.label_NumberData.Size = new System.Drawing.Size(142, 24);
            this.label_NumberData.TabIndex = 72;
            this.label_NumberData.Text = "Number_Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(522, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(460, 334);
            this.dataGridView1.TabIndex = 71;
            // 
            // button_Update
            // 
            this.button_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(1047, 443);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(100, 35);
            this.button_Update.TabIndex = 65;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            // 
            // textBox_Time
            // 
            this.textBox_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Time.Location = new System.Drawing.Point(97, 180);
            this.textBox_Time.Name = "textBox_Time";
            this.textBox_Time.Size = new System.Drawing.Size(182, 26);
            this.textBox_Time.TabIndex = 64;
            // 
            // textBox_Device
            // 
            this.textBox_Device.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Device.Location = new System.Drawing.Point(97, 125);
            this.textBox_Device.Name = "textBox_Device";
            this.textBox_Device.Size = new System.Drawing.Size(182, 26);
            this.textBox_Device.TabIndex = 63;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID.Location = new System.Drawing.Point(97, 74);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(182, 26);
            this.textBox_ID.TabIndex = 62;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time.Location = new System.Drawing.Point(-1, 180);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(59, 24);
            this.label_Time.TabIndex = 61;
            this.label_Time.Text = "Time";
            // 
            // lable_Device
            // 
            this.lable_Device.AutoSize = true;
            this.lable_Device.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_Device.Location = new System.Drawing.Point(-1, 125);
            this.lable_Device.Name = "lable_Device";
            this.lable_Device.Size = new System.Drawing.Size(73, 24);
            this.lable_Device.TabIndex = 60;
            this.lable_Device.Text = "Device";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Location = new System.Drawing.Point(-1, 77);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(36, 24);
            this.label_ID.TabIndex = 59;
            this.label_ID.Text = "ID";
            // 
            // Data_lable
            // 
            this.Data_lable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Data_lable.AutoSize = true;
            this.Data_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_lable.Location = new System.Drawing.Point(518, 39);
            this.Data_lable.Name = "Data_lable";
            this.Data_lable.Size = new System.Drawing.Size(107, 24);
            this.Data_lable.TabIndex = 68;
            this.Data_lable.Text = "Label_Led";
            // 
            // button_Retrieve
            // 
            this.button_Retrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Retrieve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Retrieve.Location = new System.Drawing.Point(3, 409);
            this.button_Retrieve.Name = "button_Retrieve";
            this.button_Retrieve.Size = new System.Drawing.Size(100, 35);
            this.button_Retrieve.TabIndex = 80;
            this.button_Retrieve.Text = "Retrieve";
            this.button_Retrieve.UseVisualStyleBackColor = true;
            this.button_Retrieve.Click += new System.EventHandler(this.button_Retrieve_Click);
            // 
            // button_ShowData
            // 
            this.button_ShowData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ShowData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ShowData.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ShowData.Location = new System.Drawing.Point(872, 36);
            this.button_ShowData.Name = "button_ShowData";
            this.button_ShowData.Size = new System.Drawing.Size(110, 35);
            this.button_ShowData.TabIndex = 79;
            this.button_ShowData.Text = "Show_Data";
            this.button_ShowData.UseVisualStyleBackColor = true;
            this.button_ShowData.Click += new System.EventHandler(this.button_ShowData_Click);
            // 
            // button_Insert
            // 
            this.button_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Insert.Location = new System.Drawing.Point(3, 465);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(100, 35);
            this.button_Insert.TabIndex = 78;
            this.button_Insert.Text = "Insert";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(134, 409);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(100, 35);
            this.button_Delete.TabIndex = 77;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(134, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 76;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Device",
            "Time",
            "Clock"});
            this.comboBox1.Location = new System.Drawing.Point(862, 458);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 26);
            this.comboBox1.TabIndex = 82;
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.Location = new System.Drawing.Point(523, 458);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(310, 26);
            this.textBox_search.TabIndex = 81;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Device";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Time";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Clock";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 300;
            // 
            // Form_LED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 498);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.button_Retrieve);
            this.Controls.Add(this.button_ShowData);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Clock);
            this.Controls.Add(this.label_Clock);
            this.Controls.Add(this.textBox_NumberData);
            this.Controls.Add(this.label_NumberData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.textBox_Time);
            this.Controls.Add(this.textBox_Device);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.lable_Device);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.Data_lable);
            this.Name = "Form_LED";
            this.Text = "LED";
            this.Load += new System.EventHandler(this.Form_LED_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Clock;
        private System.Windows.Forms.Label label_Clock;
        private System.Windows.Forms.TextBox textBox_NumberData;
        private System.Windows.Forms.Label label_NumberData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.TextBox textBox_Time;
        private System.Windows.Forms.TextBox textBox_Device;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label lable_Device;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label Data_lable;
        private System.Windows.Forms.Button button_Retrieve;
        private System.Windows.Forms.Button button_ShowData;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_search;
    }
}
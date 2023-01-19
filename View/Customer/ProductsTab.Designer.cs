namespace FuelDeliverySystem
{
    partial class ProductsTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inputQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.ordernowBtn = new System.Windows.Forms.Button();
            this.inputGas = new System.Windows.Forms.TextBox();
            this.inputPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputLocation = new System.Windows.Forms.TextBox();
            this.inputStation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gasPanel = new System.Windows.Forms.Panel();
            this.unleadedBtn = new System.Windows.Forms.RadioButton();
            this.premiumBtn = new System.Windows.Forms.RadioButton();
            this.dieselBtn = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputQuantity
            // 
            this.inputQuantity.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputQuantity.Font = new System.Drawing.Font("Lucida Bright", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputQuantity.Location = new System.Drawing.Point(15, 450);
            this.inputQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputQuantity.Name = "inputQuantity";
            this.inputQuantity.Size = new System.Drawing.Size(193, 22);
            this.inputQuantity.TabIndex = 147;
            this.inputQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputQuantity_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 148;
            this.label7.Text = "Quantity";
            // 
            // error
            // 
            this.error.Font = new System.Drawing.Font("Lucida Bright", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Maroon;
            this.error.Location = new System.Drawing.Point(15, 510);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(195, 36);
            this.error.TabIndex = 146;
            this.error.Text = " ";
            // 
            // ordernowBtn
            // 
            this.ordernowBtn.AutoSize = true;
            this.ordernowBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ordernowBtn.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordernowBtn.Location = new System.Drawing.Point(17, 545);
            this.ordernowBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ordernowBtn.Name = "ordernowBtn";
            this.ordernowBtn.Size = new System.Drawing.Size(192, 39);
            this.ordernowBtn.TabIndex = 145;
            this.ordernowBtn.Text = "Order Now!";
            this.ordernowBtn.UseVisualStyleBackColor = true;
            this.ordernowBtn.Click += new System.EventHandler(this.ordernowBtn_Click);
            // 
            // inputGas
            // 
            this.inputGas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputGas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputGas.Cursor = System.Windows.Forms.Cursors.No;
            this.inputGas.Enabled = false;
            this.inputGas.Font = new System.Drawing.Font("Lucida Bright", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputGas.Location = new System.Drawing.Point(15, 251);
            this.inputGas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputGas.Name = "inputGas";
            this.inputGas.Size = new System.Drawing.Size(193, 22);
            this.inputGas.TabIndex = 141;
            this.inputGas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputPrice
            // 
            this.inputPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputPrice.Cursor = System.Windows.Forms.Cursors.No;
            this.inputPrice.Enabled = false;
            this.inputPrice.Font = new System.Drawing.Font("Lucida Bright", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPrice.Location = new System.Drawing.Point(15, 401);
            this.inputPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(193, 22);
            this.inputPrice.TabIndex = 142;
            this.inputPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 143;
            this.label6.Text = "Gas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 144;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 140;
            this.label4.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 139;
            this.label3.Text = "Station";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Righteous", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 31);
            this.label2.TabIndex = 37;
            this.label2.Text = "ORDER DETAILS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputLocation
            // 
            this.inputLocation.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputLocation.Cursor = System.Windows.Forms.Cursors.No;
            this.inputLocation.Enabled = false;
            this.inputLocation.Font = new System.Drawing.Font("Lucida Bright", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLocation.Location = new System.Drawing.Point(15, 352);
            this.inputLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputLocation.Name = "inputLocation";
            this.inputLocation.Size = new System.Drawing.Size(193, 22);
            this.inputLocation.TabIndex = 137;
            this.inputLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputStation
            // 
            this.inputStation.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputStation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputStation.Cursor = System.Windows.Forms.Cursors.No;
            this.inputStation.Enabled = false;
            this.inputStation.Font = new System.Drawing.Font("Lucida Bright", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputStation.Location = new System.Drawing.Point(15, 302);
            this.inputStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputStation.Name = "inputStation";
            this.inputStation.Size = new System.Drawing.Size(193, 22);
            this.inputStation.TabIndex = 136;
            this.inputStation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "Gas Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gasPanel
            // 
            this.gasPanel.Controls.Add(this.unleadedBtn);
            this.gasPanel.Controls.Add(this.premiumBtn);
            this.gasPanel.Controls.Add(this.dieselBtn);
            this.gasPanel.Controls.Add(this.label1);
            this.gasPanel.Location = new System.Drawing.Point(15, 54);
            this.gasPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gasPanel.Name = "gasPanel";
            this.gasPanel.Size = new System.Drawing.Size(193, 167);
            this.gasPanel.TabIndex = 135;
            // 
            // unleadedBtn
            // 
            this.unleadedBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.unleadedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unleadedBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.unleadedBtn.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unleadedBtn.Location = new System.Drawing.Point(0, 79);
            this.unleadedBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unleadedBtn.Name = "unleadedBtn";
            this.unleadedBtn.Size = new System.Drawing.Size(193, 39);
            this.unleadedBtn.TabIndex = 34;
            this.unleadedBtn.Text = "UNLEADED";
            this.unleadedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.unleadedBtn.UseVisualStyleBackColor = true;
            this.unleadedBtn.CheckedChanged += new System.EventHandler(this.unleadedBtn_CheckedChanged);
            // 
            // premiumBtn
            // 
            this.premiumBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.premiumBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.premiumBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.premiumBtn.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premiumBtn.Location = new System.Drawing.Point(0, 124);
            this.premiumBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.premiumBtn.Name = "premiumBtn";
            this.premiumBtn.Size = new System.Drawing.Size(193, 39);
            this.premiumBtn.TabIndex = 35;
            this.premiumBtn.Text = "PREMIUM";
            this.premiumBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.premiumBtn.UseVisualStyleBackColor = true;
            this.premiumBtn.CheckedChanged += new System.EventHandler(this.premiumBtn_CheckedChanged);
            // 
            // dieselBtn
            // 
            this.dieselBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.dieselBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dieselBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dieselBtn.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dieselBtn.Location = new System.Drawing.Point(0, 37);
            this.dieselBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dieselBtn.Name = "dieselBtn";
            this.dieselBtn.Size = new System.Drawing.Size(193, 39);
            this.dieselBtn.TabIndex = 33;
            this.dieselBtn.Text = "DIESEL";
            this.dieselBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dieselBtn.UseVisualStyleBackColor = true;
            this.dieselBtn.CheckedChanged += new System.EventHandler(this.dieselBtn_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("JetBrains Mono NL SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 476);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 1, 11, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 29);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2023, 1, 11, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 60;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("JetBrains Mono NL", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(231, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(741, 590);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ProductsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputQuantity);
            this.Controls.Add(this.error);
            this.Controls.Add(this.ordernowBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputPrice);
            this.Controls.Add(this.inputGas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputLocation);
            this.Controls.Add(this.inputStation);
            this.Controls.Add(this.gasPanel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductsTab";
            this.Size = new System.Drawing.Size(972, 592);
            this.gasPanel.ResumeLayout(false);
            this.gasPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button ordernowBtn;
        private System.Windows.Forms.TextBox inputGas;
        private System.Windows.Forms.TextBox inputPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputLocation;
        private System.Windows.Forms.TextBox inputStation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel gasPanel;
        private System.Windows.Forms.RadioButton unleadedBtn;
        private System.Windows.Forms.RadioButton premiumBtn;
        private System.Windows.Forms.RadioButton dieselBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

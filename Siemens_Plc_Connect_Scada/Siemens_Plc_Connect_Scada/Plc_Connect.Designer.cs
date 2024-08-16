namespace Siemens_Plc_Connect_Scada
{
    partial class Plc_Connect
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox8 = new TextBox();
            textBox_Plc_Ip_2 = new TextBox();
            textBox6 = new TextBox();
            textBox3 = new TextBox();
            textBox_Plc_Ip_3 = new TextBox();
            textBox_Plc_Ip_1 = new TextBox();
            textBox_Plc_Ip_4 = new TextBox();
            comboBox_Plc_Slot = new ComboBox();
            comboBox_Plc_Rack = new ComboBox();
            comboBox_Plc_Type = new ComboBox();
            button_Connect = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 1);
            label1.Name = "label1";
            label1.Size = new Size(142, 32);
            label1.TabIndex = 0;
            label1.Text = "Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(4, 34);
            label2.Name = "label2";
            label2.Size = new Size(142, 32);
            label2.TabIndex = 1;
            label2.Text = "IP Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(4, 67);
            label3.Name = "label3";
            label3.Size = new Size(142, 32);
            label3.TabIndex = 2;
            label3.Text = "Rack:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(4, 100);
            label4.Name = "label4";
            label4.Size = new Size(142, 32);
            label4.TabIndex = 3;
            label4.Text = "Slot:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.66571F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.33429F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(comboBox_Plc_Slot, 1, 3);
            tableLayoutPanel1.Controls.Add(comboBox_Plc_Rack, 1, 2);
            tableLayoutPanel1.Controls.Add(comboBox_Plc_Type, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(540, 133);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853012F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853069F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853041F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853069F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853069F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853088F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2881632F));
            tableLayoutPanel2.Controls.Add(textBox8, 4, 0);
            tableLayoutPanel2.Controls.Add(textBox_Plc_Ip_2, 2, 0);
            tableLayoutPanel2.Controls.Add(textBox6, 1, 0);
            tableLayoutPanel2.Controls.Add(textBox3, 3, 0);
            tableLayoutPanel2.Controls.Add(textBox_Plc_Ip_3, 4, 0);
            tableLayoutPanel2.Controls.Add(textBox_Plc_Ip_1, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox_Plc_Ip_4, 6, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(150, 34);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(389, 32);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // textBox8
            // 
            textBox8.Dock = DockStyle.Fill;
            textBox8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox8.Location = new Point(275, 0);
            textBox8.Margin = new Padding(0);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(55, 32);
            textBox8.TabIndex = 13;
            textBox8.Text = ".";
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_Plc_Ip_2
            // 
            textBox_Plc_Ip_2.Dock = DockStyle.Fill;
            textBox_Plc_Ip_2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_Plc_Ip_2.Location = new Point(110, 0);
            textBox_Plc_Ip_2.Margin = new Padding(0);
            textBox_Plc_Ip_2.Multiline = true;
            textBox_Plc_Ip_2.Name = "textBox_Plc_Ip_2";
            textBox_Plc_Ip_2.Size = new Size(55, 32);
            textBox_Plc_Ip_2.TabIndex = 12;
            textBox_Plc_Ip_2.Text = "168";
            textBox_Plc_Ip_2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.Dock = DockStyle.Fill;
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.Location = new Point(55, 0);
            textBox6.Margin = new Padding(0);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ScrollBars = ScrollBars.Horizontal;
            textBox6.Size = new Size(55, 32);
            textBox6.TabIndex = 11;
            textBox6.Text = ".";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(165, 0);
            textBox3.Margin = new Padding(0);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(55, 32);
            textBox3.TabIndex = 8;
            textBox3.Text = ".";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_Plc_Ip_3
            // 
            textBox_Plc_Ip_3.Dock = DockStyle.Fill;
            textBox_Plc_Ip_3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_Plc_Ip_3.Location = new Point(220, 0);
            textBox_Plc_Ip_3.Margin = new Padding(0);
            textBox_Plc_Ip_3.Multiline = true;
            textBox_Plc_Ip_3.Name = "textBox_Plc_Ip_3";
            textBox_Plc_Ip_3.Size = new Size(55, 32);
            textBox_Plc_Ip_3.TabIndex = 9;
            textBox_Plc_Ip_3.Text = "45";
            textBox_Plc_Ip_3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_Plc_Ip_1
            // 
            textBox_Plc_Ip_1.Dock = DockStyle.Fill;
            textBox_Plc_Ip_1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_Plc_Ip_1.Location = new Point(0, 0);
            textBox_Plc_Ip_1.Margin = new Padding(0);
            textBox_Plc_Ip_1.Multiline = true;
            textBox_Plc_Ip_1.Name = "textBox_Plc_Ip_1";
            textBox_Plc_Ip_1.Size = new Size(55, 32);
            textBox_Plc_Ip_1.TabIndex = 6;
            textBox_Plc_Ip_1.Text = "192";
            textBox_Plc_Ip_1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_Plc_Ip_4
            // 
            textBox_Plc_Ip_4.Dock = DockStyle.Fill;
            textBox_Plc_Ip_4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_Plc_Ip_4.Location = new Point(330, 0);
            textBox_Plc_Ip_4.Margin = new Padding(0);
            textBox_Plc_Ip_4.Name = "textBox_Plc_Ip_4";
            textBox_Plc_Ip_4.Size = new Size(59, 29);
            textBox_Plc_Ip_4.TabIndex = 14;
            textBox_Plc_Ip_4.Text = "16";
            textBox_Plc_Ip_4.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBox_Plc_Slot
            // 
            comboBox_Plc_Slot.Dock = DockStyle.Fill;
            comboBox_Plc_Slot.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox_Plc_Slot.FormattingEnabled = true;
            comboBox_Plc_Slot.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            comboBox_Plc_Slot.Location = new Point(150, 100);
            comboBox_Plc_Slot.Margin = new Padding(0);
            comboBox_Plc_Slot.Name = "comboBox_Plc_Slot";
            comboBox_Plc_Slot.Size = new Size(389, 28);
            comboBox_Plc_Slot.TabIndex = 7;
            // 
            // comboBox_Plc_Rack
            // 
            comboBox_Plc_Rack.Dock = DockStyle.Fill;
            comboBox_Plc_Rack.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox_Plc_Rack.FormattingEnabled = true;
            comboBox_Plc_Rack.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            comboBox_Plc_Rack.Location = new Point(150, 67);
            comboBox_Plc_Rack.Margin = new Padding(0);
            comboBox_Plc_Rack.Name = "comboBox_Plc_Rack";
            comboBox_Plc_Rack.Size = new Size(389, 28);
            comboBox_Plc_Rack.TabIndex = 6;
            // 
            // comboBox_Plc_Type
            // 
            comboBox_Plc_Type.Dock = DockStyle.Fill;
            comboBox_Plc_Type.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox_Plc_Type.FormattingEnabled = true;
            comboBox_Plc_Type.Items.AddRange(new object[] { "S71500", "S71200", "S7400", "S7300", "S7200Smart", "S7200", "Logo", "", "", "" });
            comboBox_Plc_Type.Location = new Point(150, 1);
            comboBox_Plc_Type.Margin = new Padding(0);
            comboBox_Plc_Type.Name = "comboBox_Plc_Type";
            comboBox_Plc_Type.Size = new Size(389, 28);
            comboBox_Plc_Type.TabIndex = 6;
            comboBox_Plc_Type.SelectedIndexChanged += comboBox_Plc_Type_SelectedIndexChanged;
            // 
            // button_Connect
            // 
            button_Connect.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_Connect.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_Connect.Location = new Point(549, 3);
            button_Connect.Name = "button_Connect";
            button_Connect.Size = new Size(131, 133);
            button_Connect.TabIndex = 6;
            button_Connect.Text = "Connect";
            button_Connect.UseVisualStyleBackColor = true;
            button_Connect.Click += button_Connect_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel3.Controls.Add(button_Connect, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(683, 139);
            tableLayoutPanel3.TabIndex = 7;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // Plc_Connect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(683, 139);
            Controls.Add(tableLayoutPanel3);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            HelpButton = true;
            Name = "Plc_Connect";
            Text = "Plc_Connect";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox comboBox_Plc_Slot;
        private ComboBox comboBox_Plc_Rack;
        private TextBox textBox_Plc_Ip_1;
        private ComboBox comboBox_Plc_Type;
        private Button button_Connect;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox8;
        private TextBox textBox_Plc_Ip_2;
        private TextBox textBox6;
        private TextBox textBox_Plc_Ip_3;
        private TextBox textBox3;
        private TextBox textBox_Plc_Ip_4;
        private TableLayoutPanel tableLayoutPanel3;
    }
}

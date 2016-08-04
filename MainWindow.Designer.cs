namespace PortScanner
{
    partial class MainWindow
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
            this.scan_button = new System.Windows.Forms.Button();
            this.listview_scanner = new System.Windows.Forms.ListView();
            this.port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.condition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.hostBox = new System.Windows.Forms.TextBox();
            this.portsTo = new System.Windows.Forms.NumericUpDown();
            this.portsFrom = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progress_bar = new System.Windows.Forms.ProgressBar();
            this.isScanAllPorts = new System.Windows.Forms.CheckBox();
            this.isJustOpenPorts = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.portsTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portsFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // scan_button
            // 
            this.scan_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scan_button.Location = new System.Drawing.Point(185, 125);
            this.scan_button.Name = "scan_button";
            this.scan_button.Size = new System.Drawing.Size(147, 23);
            this.scan_button.TabIndex = 2;
            this.scan_button.Text = "СКАНИРОВАТЬ!";
            this.scan_button.UseVisualStyleBackColor = true;
            this.scan_button.Click += new System.EventHandler(this.scan_button_Click);
            // 
            // listview_scanner
            // 
            this.listview_scanner.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.port,
            this.condition});
            this.listview_scanner.Location = new System.Drawing.Point(12, 40);
            this.listview_scanner.Name = "listview_scanner";
            this.listview_scanner.Size = new System.Drawing.Size(164, 333);
            this.listview_scanner.TabIndex = 3;
            this.listview_scanner.UseCompatibleStateImageBehavior = false;
            this.listview_scanner.View = System.Windows.Forms.View.Details;
            // 
            // port
            // 
            this.port.Text = "Порт";
            this.port.Width = 69;
            // 
            // condition
            // 
            this.condition.Text = "Состояние";
            this.condition.Width = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Хост";
            // 
            // hostBox
            // 
            this.hostBox.Location = new System.Drawing.Point(46, 13);
            this.hostBox.Name = "hostBox";
            this.hostBox.Size = new System.Drawing.Size(130, 20);
            this.hostBox.TabIndex = 5;
            // 
            // portsTo
            // 
            this.portsTo.Location = new System.Drawing.Point(242, 14);
            this.portsTo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.portsTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.portsTo.Name = "portsTo";
            this.portsTo.Size = new System.Drawing.Size(90, 20);
            this.portsTo.TabIndex = 6;
            this.portsTo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // portsFrom
            // 
            this.portsFrom.Location = new System.Drawing.Point(242, 40);
            this.portsFrom.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.portsFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.portsFrom.Name = "portsFrom";
            this.portsFrom.Size = new System.Drawing.Size(90, 20);
            this.portsFrom.TabIndex = 7;
            this.portsFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Порты от";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "до";
            // 
            // progress_bar
            // 
            this.progress_bar.Location = new System.Drawing.Point(12, 379);
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(320, 23);
            this.progress_bar.TabIndex = 10;
            // 
            // isScanAllPorts
            // 
            this.isScanAllPorts.AutoSize = true;
            this.isScanAllPorts.Location = new System.Drawing.Point(185, 66);
            this.isScanAllPorts.Name = "isScanAllPorts";
            this.isScanAllPorts.Size = new System.Drawing.Size(147, 17);
            this.isScanAllPorts.TabIndex = 11;
            this.isScanAllPorts.Text = "Сканировать все порты";
            this.isScanAllPorts.UseVisualStyleBackColor = true;
            this.isScanAllPorts.CheckedChanged += new System.EventHandler(this.isScanAllPorts_CheckedChanged);
            // 
            // isJustOpenPorts
            // 
            this.isJustOpenPorts.AutoSize = true;
            this.isJustOpenPorts.Location = new System.Drawing.Point(185, 89);
            this.isJustOpenPorts.Name = "isJustOpenPorts";
            this.isJustOpenPorts.Size = new System.Drawing.Size(127, 30);
            this.isJustOpenPorts.TabIndex = 12;
            this.isJustOpenPorts.Text = "Показывать только\r\nоткрытые порты";
            this.isJustOpenPorts.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 414);
            this.Controls.Add(this.isJustOpenPorts);
            this.Controls.Add(this.isScanAllPorts);
            this.Controls.Add(this.progress_bar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portsFrom);
            this.Controls.Add(this.portsTo);
            this.Controls.Add(this.hostBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listview_scanner);
            this.Controls.Add(this.scan_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сканер портов";
            ((System.ComponentModel.ISupportInitialize)(this.portsTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portsFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scan_button;
        private System.Windows.Forms.ListView listview_scanner;
        private System.Windows.Forms.ColumnHeader port;
        private System.Windows.Forms.ColumnHeader condition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hostBox;
        private System.Windows.Forms.NumericUpDown portsTo;
        private System.Windows.Forms.NumericUpDown portsFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progress_bar;
        private System.Windows.Forms.CheckBox isScanAllPorts;
        private System.Windows.Forms.CheckBox isJustOpenPorts;
    }
}


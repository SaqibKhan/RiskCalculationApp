namespace RiskCalculationApp
{
    partial class MainForm
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
            this.tabCustomers = new System.Windows.Forms.TabControl();
            this.TabSattled = new System.Windows.Forms.TabPage();
            this.GvsattledCustomer = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUnUsualWiners = new System.Windows.Forms.Button();
            this.TabUnSattled = new System.Windows.Forms.TabPage();
            this.gvUnsattledCustomers = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabCustomers.SuspendLayout();
            this.TabSattled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvsattledCustomer)).BeginInit();
            this.panel2.SuspendLayout();
            this.TabUnSattled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnsattledCustomers)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.TabSattled);
            this.tabCustomers.Controls.Add(this.TabUnSattled);
            this.tabCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCustomers.Location = new System.Drawing.Point(0, 41);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.SelectedIndex = 0;
            this.tabCustomers.Size = new System.Drawing.Size(972, 430);
            this.tabCustomers.TabIndex = 0;
            this.tabCustomers.SelectedIndexChanged += new System.EventHandler(this.tabCustomers_SelectedIndexChanged);
            // 
            // TabSattled
            // 
            this.TabSattled.BackColor = System.Drawing.Color.White;
            this.TabSattled.Controls.Add(this.GvsattledCustomer);
            this.TabSattled.Controls.Add(this.panel2);
            this.TabSattled.Location = new System.Drawing.Point(4, 22);
            this.TabSattled.Name = "TabSattled";
            this.TabSattled.Padding = new System.Windows.Forms.Padding(3);
            this.TabSattled.Size = new System.Drawing.Size(964, 404);
            this.TabSattled.TabIndex = 0;
            this.TabSattled.Text = "Sattled ";
            // 
            // GvsattledCustomer
            // 
            this.GvsattledCustomer.AllowUserToAddRows = false;
            this.GvsattledCustomer.AllowUserToDeleteRows = false;
            this.GvsattledCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GvsattledCustomer.ColumnHeadersHeight = 20;
            this.GvsattledCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GvsattledCustomer.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GvsattledCustomer.Location = new System.Drawing.Point(3, 38);
            this.GvsattledCustomer.MultiSelect = false;
            this.GvsattledCustomer.Name = "GvsattledCustomer";
            this.GvsattledCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvsattledCustomer.Size = new System.Drawing.Size(958, 363);
            this.GvsattledCustomer.TabIndex = 0;
            this.GvsattledCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvsattledCustomer_CellDoubleClick);
            this.GvsattledCustomer.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.GvsattledCustomer_RowsAdded);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnUnUsualWiners);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 35);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer winning at an unusual rate ( 60% or greater)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tomato;
            this.panel3.Location = new System.Drawing.Point(859, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(27, 13);
            this.panel3.TabIndex = 1;
            // 
            // btnUnUsualWiners
            // 
            this.btnUnUsualWiners.BackColor = System.Drawing.Color.White;
            this.btnUnUsualWiners.Location = new System.Drawing.Point(18, 6);
            this.btnUnUsualWiners.Name = "btnUnUsualWiners";
            this.btnUnUsualWiners.Size = new System.Drawing.Size(82, 23);
            this.btnUnUsualWiners.TabIndex = 0;
            this.btnUnUsualWiners.Text = "View Details";
            this.btnUnUsualWiners.UseVisualStyleBackColor = false;
            this.btnUnUsualWiners.Click += new System.EventHandler(this.btnUnUsualWiners_Click);
            // 
            // TabUnSattled
            // 
            this.TabUnSattled.BackColor = System.Drawing.Color.White;
            this.TabUnSattled.Controls.Add(this.gvUnsattledCustomers);
            this.TabUnSattled.Controls.Add(this.panel4);
            this.TabUnSattled.Location = new System.Drawing.Point(4, 22);
            this.TabUnSattled.Name = "TabUnSattled";
            this.TabUnSattled.Padding = new System.Windows.Forms.Padding(3);
            this.TabUnSattled.Size = new System.Drawing.Size(964, 404);
            this.TabUnSattled.TabIndex = 1;
            this.TabUnSattled.Text = "UnSattled";
            // 
            // gvUnsattledCustomers
            // 
            this.gvUnsattledCustomers.AllowUserToAddRows = false;
            this.gvUnsattledCustomers.AllowUserToDeleteRows = false;
            this.gvUnsattledCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvUnsattledCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvUnsattledCustomers.Location = new System.Drawing.Point(3, 38);
            this.gvUnsattledCustomers.Name = "gvUnsattledCustomers";
            this.gvUnsattledCustomers.ReadOnly = true;
            this.gvUnsattledCustomers.RowTemplate.ReadOnly = true;
            this.gvUnsattledCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvUnsattledCustomers.Size = new System.Drawing.Size(958, 363);
            this.gvUnsattledCustomers.TabIndex = 1;
       
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(958, 35);
            this.panel4.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkRed;
            this.panel7.Location = new System.Drawing.Point(739, 10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(27, 13);
            this.panel7.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stack 30 Times OR Higher  then Avg Stack";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stack 10 Times OR Higher then Avg Stack";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Red;
            this.panel6.Location = new System.Drawing.Point(429, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(27, 13);
            this.panel6.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stack = $1000 or Higher";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSalmon;
            this.panel5.Location = new System.Drawing.Point(148, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(27, 13);
            this.panel5.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 41);
            this.panel1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(972, 471);
            this.Controls.Add(this.tabCustomers);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabCustomers.ResumeLayout(false);
            this.TabSattled.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GvsattledCustomer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TabUnSattled.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvUnsattledCustomers)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCustomers;
        private System.Windows.Forms.TabPage TabSattled;
        private System.Windows.Forms.DataGridView GvsattledCustomer;
        private System.Windows.Forms.TabPage TabUnSattled;
        private System.Windows.Forms.Button btnUnUsualWiners;
        private System.Windows.Forms.DataGridView gvUnsattledCustomers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
    }
}


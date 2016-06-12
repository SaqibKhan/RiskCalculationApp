namespace RiskCalculationApp.Forms
{
    partial class FormSattledWinner
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
            this.GvsattledWinners = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GvsattledWinners)).BeginInit();
            this.SuspendLayout();
            // 
            // GvsattledWinners
            // 
            this.GvsattledWinners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GvsattledWinners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvsattledWinners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GvsattledWinners.Location = new System.Drawing.Point(0, 0);
            this.GvsattledWinners.Name = "GvsattledWinners";
            this.GvsattledWinners.Size = new System.Drawing.Size(709, 337);
            this.GvsattledWinners.TabIndex = 1;
            // 
            // FormSattledWinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 337);
            this.Controls.Add(this.GvsattledWinners);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSattledWinner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unusual winner hostory";
            this.Load += new System.EventHandler(this.FormSattledWinner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvsattledWinners)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GvsattledWinners;
    }
}
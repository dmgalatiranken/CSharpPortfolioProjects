namespace ResortCost
{
    partial class frmResortCost
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
            this.lblNightsStayed = new System.Windows.Forms.Label();
            this.lblNightlyRate = new System.Windows.Forms.Label();
            this.lblNightlyCost = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.txtNightsStayed = new System.Windows.Forms.TextBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.txtNightlyCost = new System.Windows.Forms.TextBox();
            this.txtNightlyRate = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNightsStayed
            // 
            this.lblNightsStayed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblNightsStayed.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNightsStayed.Location = new System.Drawing.Point(75, 63);
            this.lblNightsStayed.Name = "lblNightsStayed";
            this.lblNightsStayed.Size = new System.Drawing.Size(178, 43);
            this.lblNightsStayed.TabIndex = 7;
            this.lblNightsStayed.Text = "Nights Stayed";
            this.lblNightsStayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNightlyRate
            // 
            this.lblNightlyRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblNightlyRate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNightlyRate.Location = new System.Drawing.Point(298, 63);
            this.lblNightlyRate.Name = "lblNightlyRate";
            this.lblNightlyRate.Size = new System.Drawing.Size(178, 43);
            this.lblNightlyRate.TabIndex = 8;
            this.lblNightlyRate.Text = "Nightly Rate";
            this.lblNightlyRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNightlyCost
            // 
            this.lblNightlyCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblNightlyCost.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNightlyCost.Location = new System.Drawing.Point(526, 63);
            this.lblNightlyCost.Name = "lblNightlyCost";
            this.lblNightlyCost.Size = new System.Drawing.Size(178, 43);
            this.lblNightlyCost.TabIndex = 9;
            this.lblNightlyCost.Text = "Nightly Cost";
            this.lblNightlyCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTotalCost.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(751, 63);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(223, 43);
            this.lblTotalCost.TabIndex = 10;
            this.lblTotalCost.Text = "Total Cost Of Stay";
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNightsStayed
            // 
            this.txtNightsStayed.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNightsStayed.Location = new System.Drawing.Point(79, 129);
            this.txtNightsStayed.Name = "txtNightsStayed";
            this.txtNightsStayed.Size = new System.Drawing.Size(174, 30);
            this.txtNightsStayed.TabIndex = 0;
            this.txtNightsStayed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCost.Location = new System.Drawing.Point(777, 129);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(174, 30);
            this.txtTotalCost.TabIndex = 6;
            this.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNightlyCost
            // 
            this.txtNightlyCost.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNightlyCost.Location = new System.Drawing.Point(530, 129);
            this.txtNightlyCost.Name = "txtNightlyCost";
            this.txtNightlyCost.ReadOnly = true;
            this.txtNightlyCost.Size = new System.Drawing.Size(174, 30);
            this.txtNightlyCost.TabIndex = 5;
            this.txtNightlyCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNightlyRate
            // 
            this.txtNightlyRate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNightlyRate.Location = new System.Drawing.Point(302, 129);
            this.txtNightlyRate.Name = "txtNightlyRate";
            this.txtNightlyRate.ReadOnly = true;
            this.txtNightlyRate.Size = new System.Drawing.Size(174, 30);
            this.txtNightlyRate.TabIndex = 4;
            this.txtNightlyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(79, 250);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(226, 77);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(403, 250);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(226, 77);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(748, 250);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(226, 77);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmResortCost
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1052, 380);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNightlyRate);
            this.Controls.Add(this.txtNightlyCost);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.txtNightsStayed);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblNightlyCost);
            this.Controls.Add(this.lblNightlyRate);
            this.Controls.Add(this.lblNightsStayed);
            this.Name = "frmResortCost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resort Cost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNightsStayed;
        private System.Windows.Forms.Label lblNightlyRate;
        private System.Windows.Forms.Label lblNightlyCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.TextBox txtNightsStayed;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.TextBox txtNightlyCost;
        private System.Windows.Forms.TextBox txtNightlyRate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}


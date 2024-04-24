namespace OrderValidator
{
    partial class OrderValidator
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
            this.lblItenNumber = new System.Windows.Forms.Label();
            this.lblQualtity = new System.Windows.Forms.Label();
            this.lblEstimatedDelivery = new System.Windows.Forms.Label();
            this.lblOrderIs = new System.Windows.Forms.Label();
            this.txtItemNumber = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtEstimatedDelivery = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblItenNumber
            // 
            this.lblItenNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblItenNumber.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItenNumber.Location = new System.Drawing.Point(326, 54);
            this.lblItenNumber.Name = "lblItenNumber";
            this.lblItenNumber.Size = new System.Drawing.Size(265, 42);
            this.lblItenNumber.TabIndex = 6;
            this.lblItenNumber.Text = "Item Number [100, 999]";
            this.lblItenNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQualtity
            // 
            this.lblQualtity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblQualtity.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualtity.Location = new System.Drawing.Point(385, 136);
            this.lblQualtity.Name = "lblQualtity";
            this.lblQualtity.Size = new System.Drawing.Size(206, 42);
            this.lblQualtity.TabIndex = 7;
            this.lblQualtity.Text = "Quantity [1, 12]";
            this.lblQualtity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEstimatedDelivery
            // 
            this.lblEstimatedDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblEstimatedDelivery.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimatedDelivery.Location = new System.Drawing.Point(249, 219);
            this.lblEstimatedDelivery.Name = "lblEstimatedDelivery";
            this.lblEstimatedDelivery.Size = new System.Drawing.Size(342, 42);
            this.lblEstimatedDelivery.TabIndex = 8;
            this.lblEstimatedDelivery.Text = "Estimated Delivery Days [1, 30]";
            this.lblEstimatedDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderIs
            // 
            this.lblOrderIs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblOrderIs.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderIs.Location = new System.Drawing.Point(285, 418);
            this.lblOrderIs.Name = "lblOrderIs";
            this.lblOrderIs.Size = new System.Drawing.Size(265, 42);
            this.lblOrderIs.TabIndex = 9;
            this.lblOrderIs.Text = "Order is";
            this.lblOrderIs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemNumber.Location = new System.Drawing.Point(615, 63);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.Size = new System.Drawing.Size(193, 30);
            this.txtItemNumber.TabIndex = 0;
            this.txtItemNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(615, 142);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(193, 30);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEstimatedDelivery
            // 
            this.txtEstimatedDelivery.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstimatedDelivery.Location = new System.Drawing.Point(615, 225);
            this.txtEstimatedDelivery.Name = "txtEstimatedDelivery";
            this.txtEstimatedDelivery.Size = new System.Drawing.Size(193, 30);
            this.txtEstimatedDelivery.TabIndex = 2;
            this.txtEstimatedDelivery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnValidate
            // 
            this.btnValidate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.Location = new System.Drawing.Point(604, 284);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(220, 70);
            this.btnValidate.TabIndex = 3;
            this.btnValidate.Text = "&Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(23, 404);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(220, 70);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(23, 302);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(220, 70);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // OrderValidator
            // 
            this.AcceptButton = this.btnValidate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(868, 492);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtEstimatedDelivery);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtItemNumber);
            this.Controls.Add(this.lblOrderIs);
            this.Controls.Add(this.lblEstimatedDelivery);
            this.Controls.Add(this.lblQualtity);
            this.Controls.Add(this.lblItenNumber);
            this.Name = "OrderValidator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItenNumber;
        private System.Windows.Forms.Label lblQualtity;
        private System.Windows.Forms.Label lblEstimatedDelivery;
        private System.Windows.Forms.Label lblOrderIs;
        private System.Windows.Forms.TextBox txtItemNumber;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtEstimatedDelivery;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}


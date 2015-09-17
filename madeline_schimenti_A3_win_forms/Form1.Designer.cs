namespace madeline_schimenti_A3_win_forms
{
    partial class Form1
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
            this.summary = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.instructText = new System.Windows.Forms.Label();
            this.numOrdered = new System.Windows.Forms.TextBox();
            this.addToOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // summary
            // 
            this.summary.Location = new System.Drawing.Point(103, 110);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(75, 23);
            this.summary.TabIndex = 0;
            this.summary.Text = "Summary";
            this.summary.UseVisualStyleBackColor = true;
            this.summary.Click += new System.EventHandler(this.summary_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(206, 110);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 1;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // instructText
            // 
            this.instructText.AutoSize = true;
            this.instructText.Location = new System.Drawing.Point(12, 38);
            this.instructText.Name = "instructText";
            this.instructText.Size = new System.Drawing.Size(166, 13);
            this.instructText.TabIndex = 2;
            this.instructText.Text = "Enter Number of Tickets Ordered:";
            this.instructText.Click += new System.EventHandler(this.label1_Click);
            // 
            // numOrdered
            // 
            this.numOrdered.Location = new System.Drawing.Point(195, 35);
            this.numOrdered.Name = "numOrdered";
            this.numOrdered.Size = new System.Drawing.Size(59, 20);
            this.numOrdered.TabIndex = 3;
            // 
            // addToOrder
            // 
            this.addToOrder.Location = new System.Drawing.Point(271, 33);
            this.addToOrder.Name = "addToOrder";
            this.addToOrder.Size = new System.Drawing.Size(75, 23);
            this.addToOrder.TabIndex = 4;
            this.addToOrder.Text = "Add to Order";
            this.addToOrder.UseVisualStyleBackColor = true;
            this.addToOrder.Click += new System.EventHandler(this.addToOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 188);
            this.Controls.Add(this.addToOrder);
            this.Controls.Add(this.numOrdered);
            this.Controls.Add(this.instructText);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.summary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button summary;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label instructText;
        private System.Windows.Forms.TextBox numOrdered;
        private System.Windows.Forms.Button addToOrder;
    }
}


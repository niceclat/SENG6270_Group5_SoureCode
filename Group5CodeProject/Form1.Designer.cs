namespace Group5CodeProject
{
    partial class Form1
    {
        #region SystemCode
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
            this.tbPromo = new System.Windows.Forms.TextBox();
            this.lblPromo = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.MasterPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPromo
            // 
            this.tbPromo.Location = new System.Drawing.Point(812, 388);
            this.tbPromo.Name = "tbPromo";
            this.tbPromo.Size = new System.Drawing.Size(143, 22);
            this.tbPromo.TabIndex = 1;
            this.tbPromo.TextChanged += new System.EventHandler(this.tbPromo_TextChanged);
            // 
            // lblPromo
            // 
            this.lblPromo.AutoSize = true;
            this.lblPromo.Location = new System.Drawing.Point(722, 394);
            this.lblPromo.Name = "lblPromo";
            this.lblPromo.Size = new System.Drawing.Size(84, 16);
            this.lblPromo.TabIndex = 2;
            this.lblPromo.Text = "Promo Code";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(812, 358);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(143, 24);
            this.btnAddOrder.TabIndex = 4;
            this.btnAddOrder.Text = "Add Another Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(812, 417);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(143, 22);
            this.tbTotal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(730, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order Total";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(812, 445);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(143, 27);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit Order";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // MasterPanel
            // 
            this.MasterPanel.AutoScroll = true;
            this.MasterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MasterPanel.Location = new System.Drawing.Point(12, 34);
            this.MasterPanel.Name = "MasterPanel";
            this.MasterPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.MasterPanel.Size = new System.Drawing.Size(943, 318);
            this.MasterPanel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Print Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Print Finish";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Order Processing Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Print Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(696, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Order Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 486);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MasterPanel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.lblPromo);
            this.Controls.Add(this.tbPromo);
            this.Name = "Form1";
            this.Text = "Copio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPromo;
        private System.Windows.Forms.Label lblPromo;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        #endregion

        private System.Windows.Forms.FlowLayoutPanel MasterPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


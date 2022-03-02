
namespace Plutus
{
    partial class ContaintForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnGO = new System.Windows.Forms.Button();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.lblCatagoryName = new System.Windows.Forms.Label();
            this.lblProNum = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.pnlTop);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1562, 839);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnGO);
            this.pnlTop.Controls.Add(this.txtC);
            this.pnlTop.Controls.Add(this.lblC);
            this.pnlTop.Controls.Add(this.lblCatagoryName);
            this.pnlTop.Location = new System.Drawing.Point(3, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1559, 100);
            this.pnlTop.TabIndex = 0;
            // 
            // btnGO
            // 
            this.btnGO.BackColor = System.Drawing.Color.Transparent;
            this.btnGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGO.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGO.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGO.FlatAppearance.BorderSize = 0;
            this.btnGO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGO.ForeColor = System.Drawing.Color.White;
            this.btnGO.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGO.Location = new System.Drawing.Point(435, 73);
            this.btnGO.Name = "btnGO";
            this.btnGO.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGO.Size = new System.Drawing.Size(56, 27);
            this.btnGO.TabIndex = 3;
            this.btnGO.Text = "Go";
            this.btnGO.UseVisualStyleBackColor = false;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // txtC
            // 
            this.txtC.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(335, 73);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 26);
            this.txtC.TabIndex = 2;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.lblC.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblC.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblC.ForeColor = System.Drawing.Color.White;
            this.lblC.Location = new System.Drawing.Point(0, 73);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(335, 27);
            this.lblC.TabIndex = 1;
            this.lblC.Text = "Chose the product by its number:";
            this.lblC.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCatagoryName
            // 
            this.lblCatagoryName.AutoSize = true;
            this.lblCatagoryName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCatagoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
            this.lblCatagoryName.Location = new System.Drawing.Point(0, 0);
            this.lblCatagoryName.Name = "lblCatagoryName";
            this.lblCatagoryName.Size = new System.Drawing.Size(204, 73);
            this.lblCatagoryName.TabIndex = 0;
            this.lblCatagoryName.Text = "label1";
            // 
            // lblProNum
            // 
            this.lblProNum.Location = new System.Drawing.Point(0, 0);
            this.lblProNum.Name = "lblProNum";
            this.lblProNum.Size = new System.Drawing.Size(100, 23);
            this.lblProNum.TabIndex = 0;
            // 
            // ContaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1562, 840);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContaintForm";
            this.Text = "ContaintForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblCatagoryName;
        private System.Windows.Forms.Label lblProName;
        private System.Windows.Forms.Label lblProNum;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnGO;
    }
}
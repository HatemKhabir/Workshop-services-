namespace Homework
{
    partial class CustomControl1
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
            this.serviceName = new System.Windows.Forms.Label();
            this.materialCost = new System.Windows.Forms.Label();
            this.expectedTime = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timeCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serviceName
            // 
            this.serviceName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceName.AutoSize = true;
            this.serviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.serviceName.Location = new System.Drawing.Point(15, 0);
            this.serviceName.Name = "serviceName";
            this.serviceName.Size = new System.Drawing.Size(47, 15);
            this.serviceName.TabIndex = 0;
            this.serviceName.Text = "label1";
            // 
            // materialCost
            // 
            this.materialCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCost.AutoSize = true;
            this.materialCost.Location = new System.Drawing.Point(303, 0);
            this.materialCost.Name = "materialCost";
            this.materialCost.Size = new System.Drawing.Size(38, 15);
            this.materialCost.TabIndex = 1;
            this.materialCost.Text = "label1";
            // 
            // expectedTime
            // 
            this.expectedTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expectedTime.AutoSize = true;
            this.expectedTime.Location = new System.Drawing.Point(495, 0);
            this.expectedTime.Name = "expectedTime";
            this.expectedTime.Size = new System.Drawing.Size(38, 15);
            this.expectedTime.TabIndex = 2;
            this.expectedTime.Text = "label1";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(601, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timeCost
            // 
            this.timeCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeCost.AutoSize = true;
            this.timeCost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeCost.Location = new System.Drawing.Point(648, -3);
            this.timeCost.Name = "timeCost";
            this.timeCost.Size = new System.Drawing.Size(0, 17);
            this.timeCost.TabIndex = 4;
            // 
            // CustomControl1
            // 
            this.Controls.Add(this.timeCost);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.expectedTime);
            this.Controls.Add(this.materialCost);
            this.Controls.Add(this.serviceName);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CustomControl1";
            this.Size = new System.Drawing.Size(765, 25);
            this.Load += new System.EventHandler(this.CustomControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label serviceName;
        private Label materialCost;
        private Label expectedTime;
        private CheckBox checkBox1;
        private Label timeCost;
    }
}

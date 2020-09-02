namespace InkTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReturnToPool = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDemo2 = new System.Windows.Forms.Button();
            this.btnDemo3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(11, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 150);
            this.panel1.TabIndex = 2;
            // 
            // btnReturnToPool
            // 
            this.btnReturnToPool.Location = new System.Drawing.Point(111, 10);
            this.btnReturnToPool.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReturnToPool.Name = "btnReturnToPool";
            this.btnReturnToPool.Size = new System.Drawing.Size(90, 19);
            this.btnReturnToPool.TabIndex = 3;
            this.btnReturnToPool.Text = "Return to Pool";
            this.btnReturnToPool.UseVisualStyleBackColor = true;
            this.btnReturnToPool.Click += new System.EventHandler(this.btnDisposeAndClear_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(11, 10);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(90, 19);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDemo2
            // 
            this.btnDemo2.Location = new System.Drawing.Point(206, 140);
            this.btnDemo2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDemo2.Name = "btnDemo2";
            this.btnDemo2.Size = new System.Drawing.Size(90, 19);
            this.btnDemo2.TabIndex = 6;
            this.btnDemo2.Text = "Demo 1 Time";
            this.btnDemo2.UseVisualStyleBackColor = true;
            this.btnDemo2.Click += new System.EventHandler(this.btnDemo2_Click);
            // 
            // btnDemo3
            // 
            this.btnDemo3.Location = new System.Drawing.Point(206, 164);
            this.btnDemo3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDemo3.Name = "btnDemo3";
            this.btnDemo3.Size = new System.Drawing.Size(90, 19);
            this.btnDemo3.TabIndex = 7;
            this.btnDemo3.Text = "Demo 10 Times";
            this.btnDemo3.UseVisualStyleBackColor = true;
            this.btnDemo3.Click += new System.EventHandler(this.btnDemo3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 205);
            this.Controls.Add(this.btnDemo3);
            this.Controls.Add(this.btnDemo2);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnReturnToPool);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReturnToPool;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDemo2;
        private System.Windows.Forms.Button btnDemo3;
    }
}


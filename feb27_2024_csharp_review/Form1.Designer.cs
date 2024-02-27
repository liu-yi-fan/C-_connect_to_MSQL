namespace feb27_2024_csharp_review
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxInTabCreateObjects = new System.Windows.Forms.ListBox();
            this.buttonReview0 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(711, 375);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxInTabCreateObjects);
            this.tabPage1.Controls.Add(this.buttonReview0);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(703, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "產生物件";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxInTabCreateObjects
            // 
            this.listBoxInTabCreateObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxInTabCreateObjects.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxInTabCreateObjects.FormattingEnabled = true;
            this.listBoxInTabCreateObjects.ItemHeight = 19;
            this.listBoxInTabCreateObjects.Location = new System.Drawing.Point(3, 2);
            this.listBoxInTabCreateObjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxInTabCreateObjects.Name = "listBoxInTabCreateObjects";
            this.listBoxInTabCreateObjects.Size = new System.Drawing.Size(697, 300);
            this.listBoxInTabCreateObjects.TabIndex = 1;
            // 
            // buttonReview0
            // 
            this.buttonReview0.BackColor = System.Drawing.Color.Yellow;
            this.buttonReview0.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonReview0.Location = new System.Drawing.Point(3, 302);
            this.buttonReview0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReview0.Name = "buttonReview0";
            this.buttonReview0.Size = new System.Drawing.Size(697, 42);
            this.buttonReview0.TabIndex = 0;
            this.buttonReview0.Text = "複習#0";
            this.buttonReview0.UseVisualStyleBackColor = false;
            this.buttonReview0.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 375);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBoxInTabCreateObjects;
        private System.Windows.Forms.Button buttonReview0;
    }
}


namespace WindowsFormsApp1
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
            this.btn_go = new System.Windows.Forms.Button();
            this.RTB1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(99, 105);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(146, 89);
            this.btn_go.TabIndex = 0;
            this.btn_go.Text = "GO";
            this.btn_go.UseVisualStyleBackColor = true;
            // 
            // RTB1
            // 
            this.RTB1.Location = new System.Drawing.Point(51, 234);
            this.RTB1.Name = "RTB1";
            this.RTB1.Size = new System.Drawing.Size(242, 96);
            this.RTB1.TabIndex = 1;
            this.RTB1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 395);
            this.Controls.Add(this.RTB1);
            this.Controls.Add(this.btn_go);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.RichTextBox RTB1;
    }
}


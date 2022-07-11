
namespace WOL
{
    partial class fMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWakeUp = new System.Windows.Forms.Button();
            this.tBoxLog = new System.Windows.Forms.RichTextBox();
            this.tBoxMacAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWakeUp
            // 
            this.btnWakeUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWakeUp.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWakeUp.Location = new System.Drawing.Point(12, 12);
            this.btnWakeUp.Name = "btnWakeUp";
            this.btnWakeUp.Size = new System.Drawing.Size(776, 58);
            this.btnWakeUp.TabIndex = 0;
            this.btnWakeUp.Text = "일어나라~! 용사여~!";
            this.btnWakeUp.UseVisualStyleBackColor = true;
            this.btnWakeUp.Click += new System.EventHandler(this.btnWakeUp_Click);
            // 
            // tBoxLog
            // 
            this.tBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxLog.Location = new System.Drawing.Point(13, 108);
            this.tBoxLog.Name = "tBoxLog";
            this.tBoxLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tBoxLog.Size = new System.Drawing.Size(775, 334);
            this.tBoxLog.TabIndex = 1;
            this.tBoxLog.Text = "";
            // 
            // tBoxMacAddress
            // 
            this.tBoxMacAddress.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tBoxMacAddress.Location = new System.Drawing.Point(145, 76);
            this.tBoxMacAddress.Name = "tBoxMacAddress";
            this.tBoxMacAddress.Size = new System.Drawing.Size(178, 26);
            this.tBoxMacAddress.TabIndex = 2;
            this.tBoxMacAddress.Text = "6C-4B-90-70-1C-B5";
            this.tBoxMacAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tBoxMacAddress_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(13, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "MAC address :: ";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxMacAddress);
            this.Controls.Add(this.tBoxLog);
            this.Controls.Add(this.btnWakeUp);
            this.Name = "fMain";
            this.Text = "Wake On Lan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWakeUp;
        private System.Windows.Forms.RichTextBox tBoxLog;
        private System.Windows.Forms.TextBox tBoxMacAddress;
        private System.Windows.Forms.Label label1;
    }
}


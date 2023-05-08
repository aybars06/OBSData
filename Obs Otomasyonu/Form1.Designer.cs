
namespace Obs_Otomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ogr_btn = new System.Windows.Forms.Button();
            this.ogret_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(235, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Bilgi Sistemi";
            // 
            // ogr_btn
            // 
            this.ogr_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ogr_btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogr_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ogr_btn.Location = new System.Drawing.Point(112, 178);
            this.ogr_btn.Name = "ogr_btn";
            this.ogr_btn.Size = new System.Drawing.Size(174, 103);
            this.ogr_btn.TabIndex = 1;
            this.ogr_btn.Text = "Öğrenci Girişi ";
            this.ogr_btn.UseVisualStyleBackColor = false;
            this.ogr_btn.Click += new System.EventHandler(this.ogr_btn_Click);
            // 
            // ogret_btn
            // 
            this.ogret_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ogret_btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogret_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ogret_btn.Location = new System.Drawing.Point(532, 178);
            this.ogret_btn.Name = "ogret_btn";
            this.ogret_btn.Size = new System.Drawing.Size(174, 103);
            this.ogret_btn.TabIndex = 2;
            this.ogret_btn.Text = "Akademisyen Girişi";
            this.ogret_btn.UseVisualStyleBackColor = false;
            this.ogret_btn.Click += new System.EventHandler(this.ogret_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ogret_btn);
            this.Controls.Add(this.ogr_btn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
//            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ogr_btn;
        private System.Windows.Forms.Button ogret_btn;
    }
}


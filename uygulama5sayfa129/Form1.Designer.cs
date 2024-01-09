namespace uygulama5sayfa129
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
            this.listeAsil = new System.Windows.Forms.ListBox();
            this.listeKopyala = new System.Windows.Forms.ListBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.btnKopyala = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listeAsil
            // 
            this.listeAsil.FormattingEnabled = true;
            this.listeAsil.Location = new System.Drawing.Point(103, 58);
            this.listeAsil.Name = "listeAsil";
            this.listeAsil.Size = new System.Drawing.Size(120, 147);
            this.listeAsil.TabIndex = 0;
            // 
            // listeKopyala
            // 
            this.listeKopyala.FormattingEnabled = true;
            this.listeKopyala.Location = new System.Drawing.Point(251, 58);
            this.listeKopyala.Name = "listeKopyala";
            this.listeKopyala.Size = new System.Drawing.Size(120, 147);
            this.listeKopyala.TabIndex = 1;
            // 
            // btnOlustur
            // 
            this.btnOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.Location = new System.Drawing.Point(12, 122);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(75, 23);
            this.btnOlustur.TabIndex = 2;
            this.btnOlustur.Text = "Olustur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKopyala.Location = new System.Drawing.Point(377, 122);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(75, 23);
            this.btnKopyala.TabIndex = 3;
            this.btnKopyala.Text = "Kopyala";
            this.btnKopyala.UseVisualStyleBackColor = true;
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 274);
            this.Controls.Add(this.btnKopyala);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.listeKopyala);
            this.Controls.Add(this.listeAsil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listeAsil;
        private System.Windows.Forms.ListBox listeKopyala;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Button btnKopyala;
    }
}


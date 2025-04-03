namespace SistemaFacturacion
{
    partial class Home
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
            this.opcion3 = new System.Windows.Forms.PictureBox();
            this.opcion4 = new System.Windows.Forms.PictureBox();
            this.opcion2 = new System.Windows.Forms.PictureBox();
            this.opcion1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.opcion3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcion4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcion2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcion1)).BeginInit();
            this.SuspendLayout();
            // 
            // opcion3
            // 
            this.opcion3.Image = global::SistemaFacturacion.Properties.Resources.pic3;
            this.opcion3.Location = new System.Drawing.Point(66, 273);
            this.opcion3.Name = "opcion3";
            this.opcion3.Size = new System.Drawing.Size(291, 165);
            this.opcion3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opcion3.TabIndex = 3;
            this.opcion3.TabStop = false;
            this.opcion3.Click += new System.EventHandler(this.opcion3_Click);
            // 
            // opcion4
            // 
            this.opcion4.Image = global::SistemaFacturacion.Properties.Resources.pic4;
            this.opcion4.Location = new System.Drawing.Point(417, 273);
            this.opcion4.Name = "opcion4";
            this.opcion4.Size = new System.Drawing.Size(291, 165);
            this.opcion4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opcion4.TabIndex = 2;
            this.opcion4.TabStop = false;
            this.opcion4.Click += new System.EventHandler(this.opcion4_Click);
            // 
            // opcion2
            // 
            this.opcion2.Image = global::SistemaFacturacion.Properties.Resources.pic2;
            this.opcion2.Location = new System.Drawing.Point(417, 79);
            this.opcion2.Name = "opcion2";
            this.opcion2.Size = new System.Drawing.Size(291, 165);
            this.opcion2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opcion2.TabIndex = 1;
            this.opcion2.TabStop = false;
            this.opcion2.Click += new System.EventHandler(this.opcion2_Click);
            // 
            // opcion1
            // 
            this.opcion1.Image = global::SistemaFacturacion.Properties.Resources.pic1;
            this.opcion1.Location = new System.Drawing.Point(66, 79);
            this.opcion1.Name = "opcion1";
            this.opcion1.Size = new System.Drawing.Size(291, 165);
            this.opcion1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opcion1.TabIndex = 0;
            this.opcion1.TabStop = false;
            this.opcion1.Click += new System.EventHandler(this.opcion1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.opcion3);
            this.Controls.Add(this.opcion4);
            this.Controls.Add(this.opcion2);
            this.Controls.Add(this.opcion1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HOME_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opcion3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcion4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcion2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcion1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox opcion1;
        private System.Windows.Forms.PictureBox opcion2;
        private System.Windows.Forms.PictureBox opcion4;
        private System.Windows.Forms.PictureBox opcion3;
    }
}


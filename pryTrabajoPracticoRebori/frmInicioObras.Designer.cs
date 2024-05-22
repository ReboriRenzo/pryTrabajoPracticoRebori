namespace pryTrabajoPracticoRebori
{
    partial class frmInicioObras
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOnas = new System.Windows.Forms.Button();
            this.btnQuenaken = new System.Windows.Forms.Button();
            this.btnTobas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTobas);
            this.groupBox1.Controls.Add(this.btnQuenaken);
            this.groupBox1.Controls.Add(this.btnOnas);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuestras Obras";
            // 
            // btnOnas
            // 
            this.btnOnas.Location = new System.Drawing.Point(137, 82);
            this.btnOnas.Name = "btnOnas";
            this.btnOnas.Size = new System.Drawing.Size(88, 39);
            this.btnOnas.TabIndex = 0;
            this.btnOnas.Text = "Onas";
            this.btnOnas.UseVisualStyleBackColor = true;
            this.btnOnas.Click += new System.EventHandler(this.btnOnas_Click);
            // 
            // btnQuenaken
            // 
            this.btnQuenaken.Location = new System.Drawing.Point(19, 82);
            this.btnQuenaken.Name = "btnQuenaken";
            this.btnQuenaken.Size = new System.Drawing.Size(88, 39);
            this.btnQuenaken.TabIndex = 1;
            this.btnQuenaken.Text = "Quenaken";
            this.btnQuenaken.UseVisualStyleBackColor = true;
            this.btnQuenaken.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTobas
            // 
            this.btnTobas.Location = new System.Drawing.Point(255, 82);
            this.btnTobas.Name = "btnTobas";
            this.btnTobas.Size = new System.Drawing.Size(88, 39);
            this.btnTobas.TabIndex = 2;
            this.btnTobas.Text = "Tobas";
            this.btnTobas.UseVisualStyleBackColor = true;
            this.btnTobas.Click += new System.EventHandler(this.btnTobas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "SELECCIONE LA OBRA PARA RESERVAR TUS ASIENTOS";
            // 
            // frmInicioObras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 168);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmInicioObras";
            this.Text = "frmInicioObras";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTobas;
        private System.Windows.Forms.Button btnQuenaken;
        private System.Windows.Forms.Button btnOnas;
    }
}
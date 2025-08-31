namespace cadastrarVeiculosProva
{
    partial class Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbONIBUS = new System.Windows.Forms.RadioButton();
            this.rbCAMINHAO = new System.Windows.Forms.RadioButton();
            this.lbPLACA = new System.Windows.Forms.Label();
            this.txtPLACA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbASSENTOSEIXOS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtANO = new System.Windows.Forms.TextBox();
            this.txtASSENTOSEIXOS = new System.Windows.Forms.TextBox();
            this.lvONIBUS = new System.Windows.Forms.ListView();
            this.btCADASTRAR = new System.Windows.Forms.Button();
            this.btLIMPAR = new System.Windows.Forms.Button();
            this.lvCAMINHAO = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // rbONIBUS
            // 
            this.rbONIBUS.AutoSize = true;
            this.rbONIBUS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbONIBUS.ForeColor = System.Drawing.Color.Navy;
            this.rbONIBUS.Location = new System.Drawing.Point(58, 36);
            this.rbONIBUS.Name = "rbONIBUS";
            this.rbONIBUS.Size = new System.Drawing.Size(88, 24);
            this.rbONIBUS.TabIndex = 0;
            this.rbONIBUS.TabStop = true;
            this.rbONIBUS.Text = "Onibus";
            this.rbONIBUS.UseVisualStyleBackColor = true;
            this.rbONIBUS.CheckedChanged += new System.EventHandler(this.rbONIBUS_CheckedChanged);
            // 
            // rbCAMINHAO
            // 
            this.rbCAMINHAO.AutoSize = true;
            this.rbCAMINHAO.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCAMINHAO.ForeColor = System.Drawing.Color.Navy;
            this.rbCAMINHAO.Location = new System.Drawing.Point(195, 36);
            this.rbCAMINHAO.Name = "rbCAMINHAO";
            this.rbCAMINHAO.Size = new System.Drawing.Size(113, 24);
            this.rbCAMINHAO.TabIndex = 1;
            this.rbCAMINHAO.TabStop = true;
            this.rbCAMINHAO.Text = "Caminhão";
            this.rbCAMINHAO.UseVisualStyleBackColor = true;
            this.rbCAMINHAO.CheckedChanged += new System.EventHandler(this.rbCAMINHAO_CheckedChanged);
            // 
            // lbPLACA
            // 
            this.lbPLACA.AutoSize = true;
            this.lbPLACA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPLACA.Location = new System.Drawing.Point(58, 112);
            this.lbPLACA.Name = "lbPLACA";
            this.lbPLACA.Size = new System.Drawing.Size(84, 23);
            this.lbPLACA.TabIndex = 2;
            this.lbPLACA.Text = "PLACA:";
            // 
            // txtPLACA
            // 
            this.txtPLACA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPLACA.Location = new System.Drawing.Point(195, 107);
            this.txtPLACA.Name = "txtPLACA";
            this.txtPLACA.Size = new System.Drawing.Size(445, 28);
            this.txtPLACA.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "ANO:";
            // 
            // lbASSENTOSEIXOS
            // 
            this.lbASSENTOSEIXOS.AutoSize = true;
            this.lbASSENTOSEIXOS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbASSENTOSEIXOS.Location = new System.Drawing.Point(58, 223);
            this.lbASSENTOSEIXOS.Name = "lbASSENTOSEIXOS";
            this.lbASSENTOSEIXOS.Size = new System.Drawing.Size(126, 23);
            this.lbASSENTOSEIXOS.TabIndex = 5;
            this.lbASSENTOSEIXOS.Text = "ASSENTOS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 6;
            // 
            // txtANO
            // 
            this.txtANO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtANO.Location = new System.Drawing.Point(195, 161);
            this.txtANO.Name = "txtANO";
            this.txtANO.Size = new System.Drawing.Size(445, 28);
            this.txtANO.TabIndex = 7;
            // 
            // txtASSENTOSEIXOS
            // 
            this.txtASSENTOSEIXOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtASSENTOSEIXOS.Location = new System.Drawing.Point(195, 218);
            this.txtASSENTOSEIXOS.Name = "txtASSENTOSEIXOS";
            this.txtASSENTOSEIXOS.Size = new System.Drawing.Size(445, 28);
            this.txtASSENTOSEIXOS.TabIndex = 8;
            // 
            // lvONIBUS
            // 
            this.lvONIBUS.HideSelection = false;
            this.lvONIBUS.Location = new System.Drawing.Point(58, 316);
            this.lvONIBUS.Name = "lvONIBUS";
            this.lvONIBUS.Size = new System.Drawing.Size(582, 97);
            this.lvONIBUS.TabIndex = 9;
            this.lvONIBUS.UseCompatibleStateImageBehavior = false;
            // 
            // btCADASTRAR
            // 
            this.btCADASTRAR.BackColor = System.Drawing.Color.LightGreen;
            this.btCADASTRAR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCADASTRAR.Location = new System.Drawing.Point(186, 271);
            this.btCADASTRAR.Name = "btCADASTRAR";
            this.btCADASTRAR.Size = new System.Drawing.Size(146, 38);
            this.btCADASTRAR.TabIndex = 10;
            this.btCADASTRAR.Text = "CADASTRAR";
            this.btCADASTRAR.UseVisualStyleBackColor = false;
            this.btCADASTRAR.Click += new System.EventHandler(this.btCADASTRAR_Click);
            // 
            // btLIMPAR
            // 
            this.btLIMPAR.BackColor = System.Drawing.Color.OrangeRed;
            this.btLIMPAR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLIMPAR.Location = new System.Drawing.Point(356, 272);
            this.btLIMPAR.Name = "btLIMPAR";
            this.btLIMPAR.Size = new System.Drawing.Size(146, 38);
            this.btLIMPAR.TabIndex = 11;
            this.btLIMPAR.Text = "LIMPAR";
            this.btLIMPAR.UseVisualStyleBackColor = false;
            // 
            // lvCAMINHAO
            // 
            this.lvCAMINHAO.HideSelection = false;
            this.lvCAMINHAO.Location = new System.Drawing.Point(58, 433);
            this.lvCAMINHAO.Name = "lvCAMINHAO";
            this.lvCAMINHAO.Size = new System.Drawing.Size(582, 97);
            this.lvCAMINHAO.TabIndex = 12;
            this.lvCAMINHAO.UseCompatibleStateImageBehavior = false;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.lvCAMINHAO);
            this.Controls.Add(this.btLIMPAR);
            this.Controls.Add(this.btCADASTRAR);
            this.Controls.Add(this.lvONIBUS);
            this.Controls.Add(this.txtASSENTOSEIXOS);
            this.Controls.Add(this.txtANO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbASSENTOSEIXOS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPLACA);
            this.Controls.Add(this.lbPLACA);
            this.Controls.Add(this.rbCAMINHAO);
            this.Controls.Add(this.rbONIBUS);
            this.Name = "Cadastro";
            this.Text = "Cadastro de Veículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbONIBUS;
        private System.Windows.Forms.RadioButton rbCAMINHAO;
        private System.Windows.Forms.Label lbPLACA;
        private System.Windows.Forms.TextBox txtPLACA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbASSENTOSEIXOS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtANO;
        private System.Windows.Forms.TextBox txtASSENTOSEIXOS;
        private System.Windows.Forms.ListView lvONIBUS;
        private System.Windows.Forms.Button btCADASTRAR;
        private System.Windows.Forms.Button btLIMPAR;
        private System.Windows.Forms.ListView lvCAMINHAO;
    }
}


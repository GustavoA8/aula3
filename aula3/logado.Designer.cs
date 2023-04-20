
namespace aula3
{
    partial class frmLogado
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
            this.lblCep = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnUb = new System.Windows.Forms.Button();
            this.btnBu = new System.Windows.Forms.Button();
            this.btnHoras = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(87, 223);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(86, 20);
            this.lblCep.TabIndex = 0;
            this.lblCep.Text = "Digite o CEP";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(68, 259);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(132, 20);
            this.txtCep.TabIndex = 1;
            this.txtCep.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(91, 295);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnUb
            // 
            this.btnUb.Location = new System.Drawing.Point(36, 176);
            this.btnUb.Name = "btnUb";
            this.btnUb.Size = new System.Drawing.Size(75, 23);
            this.btnUb.TabIndex = 3;
            this.btnUb.Text = "USD-BRL";
            this.btnUb.UseVisualStyleBackColor = true;
            this.btnUb.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBu
            // 
            this.btnBu.Location = new System.Drawing.Point(160, 176);
            this.btnBu.Name = "btnBu";
            this.btnBu.Size = new System.Drawing.Size(75, 23);
            this.btnBu.TabIndex = 4;
            this.btnBu.Text = "BRL-USD";
            this.btnBu.UseVisualStyleBackColor = true;
            this.btnBu.Click += new System.EventHandler(this.btnBu_Click);
            // 
            // btnHoras
            // 
            this.btnHoras.Location = new System.Drawing.Point(36, 77);
            this.btnHoras.Name = "btnHoras";
            this.btnHoras.Size = new System.Drawing.Size(75, 36);
            this.btnHoras.TabIndex = 5;
            this.btnHoras.Text = "Que horas são?";
            this.btnHoras.UseVisualStyleBackColor = true;
            this.btnHoras.Click += new System.EventHandler(this.btnHoras_Click);
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(160, 77);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(75, 36);
            this.btnData.TabIndex = 6;
            this.btnData.Text = "Qual a data de hoje?";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // frmLogado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 345);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.btnHoras);
            this.Controls.Add(this.btnBu);
            this.Controls.Add(this.btnUb);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lblCep);
            this.Name = "frmLogado";
            this.Text = "Logado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogado_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnUb;
        private System.Windows.Forms.Button btnBu;
        private System.Windows.Forms.Button btnHoras;
        private System.Windows.Forms.Button btnData;
    }
}
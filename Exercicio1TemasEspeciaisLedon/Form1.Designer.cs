
namespace Exercicio1TemasEspeciaisLedon
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.rBAV = new System.Windows.Forms.RadioButton();
            this.rBP = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.ValorPago = new System.Windows.Forms.Label();
            this.Parcelas = new System.Windows.Forms.Label();
            this.Desconto = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.ValorPagoR = new System.Windows.Forms.Label();
            this.ParcelasR = new System.Windows.Forms.Label();
            this.DescontoR = new System.Windows.Forms.Label();
            this.TotalR = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelValorR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor a ser pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de parcelas";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(159, 116);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(162, 31);
            this.txt1.TabIndex = 4;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // rBAV
            // 
            this.rBAV.AutoSize = true;
            this.rBAV.Location = new System.Drawing.Point(45, 47);
            this.rBAV.Name = "rBAV";
            this.rBAV.Size = new System.Drawing.Size(90, 29);
            this.rBAV.TabIndex = 6;
            this.rBAV.TabStop = true;
            this.rBAV.Text = "A vista";
            this.rBAV.UseVisualStyleBackColor = true;
            this.rBAV.CheckedChanged += new System.EventHandler(this.rBAV_CheckedChanged);
            // 
            // rBP
            // 
            this.rBP.AutoSize = true;
            this.rBP.Location = new System.Drawing.Point(189, 47);
            this.rBP.Name = "rBP";
            this.rBP.Size = new System.Drawing.Size(113, 29);
            this.rBP.TabIndex = 7;
            this.rBP.TabStop = true;
            this.rBP.Text = "Parcelado";
            this.rBP.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 223);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(315, 34);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ValorPago
            // 
            this.ValorPago.AutoSize = true;
            this.ValorPago.Location = new System.Drawing.Point(12, 281);
            this.ValorPago.Name = "ValorPago";
            this.ValorPago.Size = new System.Drawing.Size(117, 25);
            this.ValorPago.TabIndex = 9;
            this.ValorPago.Text = "Valor a pagar";
            // 
            // Parcelas
            // 
            this.Parcelas.AutoSize = true;
            this.Parcelas.Location = new System.Drawing.Point(12, 316);
            this.Parcelas.Name = "Parcelas";
            this.Parcelas.Size = new System.Drawing.Size(74, 25);
            this.Parcelas.TabIndex = 10;
            this.Parcelas.Text = "Parcelas";
            // 
            // Desconto
            // 
            this.Desconto.AutoSize = true;
            this.Desconto.Location = new System.Drawing.Point(12, 350);
            this.Desconto.Name = "Desconto";
            this.Desconto.Size = new System.Drawing.Size(88, 25);
            this.Desconto.TabIndex = 11;
            this.Desconto.Text = "Desconto";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(12, 383);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(65, 25);
            this.Total.TabIndex = 12;
            this.Total.Text = "TOTAL:";
            // 
            // ValorPagoR
            // 
            this.ValorPagoR.AutoSize = true;
            this.ValorPagoR.Location = new System.Drawing.Point(243, 281);
            this.ValorPagoR.Name = "ValorPagoR";
            this.ValorPagoR.Size = new System.Drawing.Size(0, 25);
            this.ValorPagoR.TabIndex = 13;
            this.ValorPagoR.Click += new System.EventHandler(this.ValorPagoR_Click);
            // 
            // ParcelasR
            // 
            this.ParcelasR.AutoSize = true;
            this.ParcelasR.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ParcelasR.Location = new System.Drawing.Point(243, 316);
            this.ParcelasR.Name = "ParcelasR";
            this.ParcelasR.Size = new System.Drawing.Size(22, 25);
            this.ParcelasR.TabIndex = 14;
            this.ParcelasR.Text = "0";
            this.ParcelasR.Click += new System.EventHandler(this.ParcelasR_Click);
            // 
            // DescontoR
            // 
            this.DescontoR.AutoSize = true;
            this.DescontoR.ForeColor = System.Drawing.Color.Red;
            this.DescontoR.Location = new System.Drawing.Point(243, 350);
            this.DescontoR.Name = "DescontoR";
            this.DescontoR.Size = new System.Drawing.Size(22, 25);
            this.DescontoR.TabIndex = 15;
            this.DescontoR.Text = "0";
            // 
            // TotalR
            // 
            this.TotalR.AutoSize = true;
            this.TotalR.Location = new System.Drawing.Point(243, 383);
            this.TotalR.Name = "TotalR";
            this.TotalR.Size = new System.Drawing.Size(22, 25);
            this.TotalR.TabIndex = 16;
            this.TotalR.Text = "0";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2x",
            "3x",
            "4x",
            "5x",
            "6x",
            "7x",
            "8x",
            "9x",
            "10x",
            "11x",
            "12x"});
            this.comboBox1.Location = new System.Drawing.Point(189, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 33);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelValorR
            // 
            this.labelValorR.AutoSize = true;
            this.labelValorR.ForeColor = System.Drawing.Color.Green;
            this.labelValorR.Location = new System.Drawing.Point(243, 281);
            this.labelValorR.Name = "labelValorR";
            this.labelValorR.Size = new System.Drawing.Size(22, 25);
            this.labelValorR.TabIndex = 18;
            this.labelValorR.Text = "0";
            this.labelValorR.Click += new System.EventHandler(this.labelValorR_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 427);
            this.Controls.Add(this.labelValorR);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TotalR);
            this.Controls.Add(this.DescontoR);
            this.Controls.Add(this.ParcelasR);
            this.Controls.Add(this.ValorPagoR);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Desconto);
            this.Controls.Add(this.Parcelas);
            this.Controls.Add(this.ValorPago);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rBP);
            this.Controls.Add(this.rBAV);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de pagamentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.RadioButton rBAV;
        private System.Windows.Forms.RadioButton rBP;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label ValorPago;
        private System.Windows.Forms.Label Parcelas;
        private System.Windows.Forms.Label Desconto;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label ValorPagoR;
        private System.Windows.Forms.Label ParcelasR;
        private System.Windows.Forms.Label DescontoR;
        private System.Windows.Forms.Label TotalR;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelValorR;
    }
}


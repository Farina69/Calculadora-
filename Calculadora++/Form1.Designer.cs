namespace Calculadora__
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.numOper_1 = new System.Windows.Forms.NumericUpDown();
            this.numOper_2 = new System.Windows.Forms.NumericUpDown();
            this.btMais = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btLimpa = new System.Windows.Forms.Button();
            this.btSegue = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.lbl_Result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numOper_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOper_2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oper. 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numOper_1
            // 
            this.numOper_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOper_1.Location = new System.Drawing.Point(239, 45);
            this.numOper_1.Name = "numOper_1";
            this.numOper_1.Size = new System.Drawing.Size(120, 38);
            this.numOper_1.TabIndex = 1;
            this.numOper_1.ValueChanged += new System.EventHandler(this.numOper_1_ValueChanged);
            // 
            // numOper_2
            // 
            this.numOper_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOper_2.Location = new System.Drawing.Point(239, 216);
            this.numOper_2.Name = "numOper_2";
            this.numOper_2.Size = new System.Drawing.Size(120, 38);
            this.numOper_2.TabIndex = 2;
            // 
            // btMais
            // 
            this.btMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMais.Location = new System.Drawing.Point(6, 127);
            this.btMais.Name = "btMais";
            this.btMais.Size = new System.Drawing.Size(59, 45);
            this.btMais.TabIndex = 3;
            this.btMais.Text = "+";
            this.btMais.UseVisualStyleBackColor = true;
            this.btMais.Click += new System.EventHandler(this.btMais_Click);
            // 
            // btSub
            // 
            this.btSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSub.Location = new System.Drawing.Point(71, 127);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(59, 45);
            this.btSub.TabIndex = 4;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btMult
            // 
            this.btMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMult.Location = new System.Drawing.Point(136, 127);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(59, 45);
            this.btMult.TabIndex = 5;
            this.btMult.Text = "X";
            this.btMult.UseVisualStyleBackColor = true;
            this.btMult.Click += new System.EventHandler(this.button3_Click);
            // 
            // btDiv
            // 
            this.btDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiv.Location = new System.Drawing.Point(201, 127);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(59, 45);
            this.btDiv.TabIndex = 6;
            this.btDiv.Text = "÷";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btLimpa
            // 
            this.btLimpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpa.Location = new System.Drawing.Point(329, 135);
            this.btLimpa.Name = "btLimpa";
            this.btLimpa.Size = new System.Drawing.Size(75, 31);
            this.btLimpa.TabIndex = 7;
            this.btLimpa.Text = "Limpar";
            this.btLimpa.UseVisualStyleBackColor = true;
            this.btLimpa.Click += new System.EventHandler(this.button5_Click);
            // 
            // btSegue
            // 
            this.btSegue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSegue.Location = new System.Drawing.Point(410, 135);
            this.btSegue.Name = "btSegue";
            this.btSegue.Size = new System.Drawing.Size(75, 31);
            this.btSegue.TabIndex = 8;
            this.btSegue.Text = "Segue";
            this.btSegue.UseVisualStyleBackColor = true;
            this.btSegue.Click += new System.EventHandler(this.btSegue_Click);
            // 
            // btIgual
            // 
            this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgual.Location = new System.Drawing.Point(222, 279);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(75, 31);
            this.btIgual.TabIndex = 16;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Oper. 2";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.Location = new System.Drawing.Point(266, 134);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(42, 26);
            this.lblOp.TabIndex = 11;
            this.lblOp.Text = ". . .";
            this.lblOp.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(236, 368);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(0, 13);
            this.lbl_Result.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 406);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btSegue);
            this.Controls.Add(this.btLimpa);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btMais);
            this.Controls.Add(this.numOper_2);
            this.Controls.Add(this.numOper_1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOper_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOper_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numOper_1;
        private System.Windows.Forms.NumericUpDown numOper_2;
        private System.Windows.Forms.Button btMais;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btLimpa;
        private System.Windows.Forms.Button btSegue;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lbl_Result;
    }
}


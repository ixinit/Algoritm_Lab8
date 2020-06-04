namespace StackExpr
{
    partial class StackExprF
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblExpr = new System.Windows.Forms.Label();
            this.tbExpr = new System.Windows.Forms.TextBox();
            this.lblEq = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.dgVal = new System.Windows.Forms.DataGridView();
            this.colVar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnCV = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnEvol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExpr
            // 
            this.lblExpr.AutoSize = true;
            this.lblExpr.Location = new System.Drawing.Point(19, 22);
            this.lblExpr.Name = "lblExpr";
            this.lblExpr.Size = new System.Drawing.Size(75, 15);
            this.lblExpr.TabIndex = 0;
            this.lblExpr.Text = "Выражение";
            // 
            // tbExpr
            // 
            this.tbExpr.Location = new System.Drawing.Point(118, 17);
            this.tbExpr.Name = "tbExpr";
            this.tbExpr.Size = new System.Drawing.Size(214, 20);
            this.tbExpr.TabIndex = 1;
            // 
            // lblEq
            // 
            this.lblEq.AutoSize = true;
            this.lblEq.Location = new System.Drawing.Point(354, 17);
            this.lblEq.Name = "lblEq";
            this.lblEq.Size = new System.Drawing.Size(14, 15);
            this.lblEq.TabIndex = 2;
            this.lblEq.Text = "=";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(435, 22);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 15);
            this.lblRes.TabIndex = 3;
            // 
            // dgVal
            // 
            this.dgVal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVar,
            this.colVal});
            this.dgVal.Location = new System.Drawing.Point(22, 78);
            this.dgVal.Name = "dgVal";
            this.dgVal.Size = new System.Drawing.Size(248, 150);
            this.dgVal.TabIndex = 4;
            // 
            // colVar
            // 
            this.colVar.HeaderText = "Переменная";
            this.colVar.Name = "colVar";
            // 
            // colVal
            // 
            this.colVal.HeaderText = "Значение";
            this.colVal.Name = "colVal";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(317, 88);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(118, 23);
            this.btnInput.TabIndex = 5;
            this.btnInput.Text = "Ввести значения";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnCV
            // 
            this.btnCV.Location = new System.Drawing.Point(316, 152);
            this.btnCV.Name = "btnCV";
            this.btnCV.Size = new System.Drawing.Size(38, 23);
            this.btnCV.TabIndex = 6;
            this.btnCV.Text = "CV";
            this.btnCV.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(316, 197);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(38, 23);
            this.btnC.TabIndex = 7;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnEvol
            // 
            this.btnEvol.Location = new System.Drawing.Point(320, 56);
            this.btnEvol.Name = "btnEvol";
            this.btnEvol.Size = new System.Drawing.Size(114, 22);
            this.btnEvol.TabIndex = 8;
            this.btnEvol.Text = "Преобразовать";
            this.btnEvol.UseVisualStyleBackColor = true;
            this.btnEvol.Click += new System.EventHandler(this.btnEvol_Click);
            // 
            // StackExprF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 374);
            this.Controls.Add(this.btnEvol);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCV);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.dgVal);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblEq);
            this.Controls.Add(this.tbExpr);
            this.Controls.Add(this.lblExpr);
            this.Name = "StackExprF";
            this.Text = "Вычисление значения выражения";
            ((System.ComponentModel.ISupportInitialize)(this.dgVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExpr;
        private System.Windows.Forms.TextBox tbExpr;
        private System.Windows.Forms.Label lblEq;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.DataGridView dgVal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVal;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnCV;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnEvol;
    }
}


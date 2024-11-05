namespace PED
{
    partial class LoansForm
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
            this.dataGridViewLoans = new System.Windows.Forms.DataGridView();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.textBoxBookId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoanBook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLoans
            // 
            this.dataGridViewLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoans.Location = new System.Drawing.Point(50, 240);
            this.dataGridViewLoans.Name = "dataGridViewLoans";
            this.dataGridViewLoans.Size = new System.Drawing.Size(687, 198);
            this.dataGridViewLoans.TabIndex = 0;
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserId.Location = new System.Drawing.Point(158, 101);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(413, 27);
            this.textBoxUserId.TabIndex = 1;
            // 
            // textBoxBookId
            // 
            this.textBoxBookId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookId.Location = new System.Drawing.Point(158, 163);
            this.textBoxBookId.Name = "textBoxBookId";
            this.textBoxBookId.Size = new System.Drawing.Size(413, 27);
            this.textBoxBookId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(151, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "RESERVA DE LIBRO - BINAES";
            // 
            // buttonLoanBook
            // 
            this.buttonLoanBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoanBook.Location = new System.Drawing.Point(312, 202);
            this.buttonLoanBook.Name = "buttonLoanBook";
            this.buttonLoanBook.Size = new System.Drawing.Size(113, 31);
            this.buttonLoanBook.TabIndex = 4;
            this.buttonLoanBook.Text = "Reservar";
            this.buttonLoanBook.UseVisualStyleBackColor = true;
            this.buttonLoanBook.Click += new System.EventHandler(this.buttonLoanBook_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(126, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(126, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre del Libro:";
            // 
            // LoansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLoanBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBookId);
            this.Controls.Add(this.textBoxUserId);
            this.Controls.Add(this.dataGridViewLoans);
            this.Name = "LoansForm";
            this.Text = "LoansForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLoans;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.TextBox textBoxBookId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoanBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
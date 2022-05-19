
namespace Correios
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
            this.cmdConsultarObj = new System.Windows.Forms.Button();
            this.txtObj = new System.Windows.Forms.TextBox();
            this.lstObj = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cmdConsultarObj
            // 
            this.cmdConsultarObj.Location = new System.Drawing.Point(132, 10);
            this.cmdConsultarObj.Name = "cmdConsultarObj";
            this.cmdConsultarObj.Size = new System.Drawing.Size(141, 23);
            this.cmdConsultarObj.TabIndex = 0;
            this.cmdConsultarObj.Text = "Consultar Objeto";
            this.cmdConsultarObj.UseVisualStyleBackColor = true;
            this.cmdConsultarObj.Click += new System.EventHandler(this.cmdConsultarObj_Click);
            // 
            // txtObj
            // 
            this.txtObj.Location = new System.Drawing.Point(4, 12);
            this.txtObj.Name = "txtObj";
            this.txtObj.Size = new System.Drawing.Size(122, 20);
            this.txtObj.TabIndex = 1;
            this.txtObj.Text = "PX998054075BR";
            // 
            // lstObj
            // 
            this.lstObj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstObj.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lstObj.FullRowSelect = true;
            this.lstObj.GridLines = true;
            this.lstObj.HideSelection = false;
            this.lstObj.Location = new System.Drawing.Point(4, 38);
            this.lstObj.Name = "lstObj";
            this.lstObj.Size = new System.Drawing.Size(1118, 305);
            this.lstObj.TabIndex = 2;
            this.lstObj.UseCompatibleStateImageBehavior = false;
            this.lstObj.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Categoria";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Objeto";
            this.columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data";
            this.columnHeader3.Width = 132;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Descrição";
            this.columnHeader4.Width = 238;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Local";
            this.columnHeader5.Width = 125;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "UF/Cidade";
            this.columnHeader6.Width = 132;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tipo";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Destino";
            this.columnHeader8.Width = 117;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 355);
            this.Controls.Add(this.lstObj);
            this.Controls.Add(this.txtObj);
            this.Controls.Add(this.cmdConsultarObj);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdConsultarObj;
        private System.Windows.Forms.TextBox txtObj;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView lstObj;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}


namespace Atividade1
{
    partial class FrmChamado
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
            BtnSair = new ReaLTaiizor.Controls.RibbonButtonLeft();
            SuspendLayout();
            // 
            // BtnSair
            // 
            BtnSair.BackColor = Color.Transparent;
            BtnSair.BaseColorA = Color.FromArgb(203, 201, 205);
            BtnSair.BaseColorB = Color.FromArgb(188, 186, 190);
            BtnSair.BorderColorA = Color.FromArgb(117, 120, 117);
            BtnSair.BorderColorB = Color.FromArgb(75, 255, 255, 255);
            BtnSair.DownBaseColorA = Color.FromArgb(203, 201, 205);
            BtnSair.DownBaseColorB = Color.FromArgb(188, 186, 190);
            BtnSair.DownBorderColorA = Color.FromArgb(117, 120, 117);
            BtnSair.DownBorderColorB = Color.FromArgb(75, 255, 255, 255);
            BtnSair.Font = new Font("Tahoma", 8F, FontStyle.Bold);
            BtnSair.ForeColor = Color.FromArgb(50, 50, 50);
            BtnSair.HoverBaseColorA = Color.FromArgb(193, 191, 195);
            BtnSair.HoverBaseColorB = Color.FromArgb(194, 192, 196);
            BtnSair.HoverBorderColorA = Color.FromArgb(117, 120, 117);
            BtnSair.HoverBorderColorB = Color.FromArgb(75, 255, 255, 255);
            BtnSair.Location = new Point(12, 380);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(148, 58);
            BtnSair.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BtnSair.TabIndex = 4;
            BtnSair.Text = "Voltar";
            BtnSair.Click += BtnSair_Click;
            // 
            // FrmChamado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSair);
            Name = "FrmChamado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmChamado";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.RibbonButtonLeft BtnSair;
    }
}
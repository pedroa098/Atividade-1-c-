namespace Atividade1
{
    partial class FrmPrincipal
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
            BtnUsuarios = new ReaLTaiizor.Controls.RibbonButtonLeft();
            BtnChamado = new ReaLTaiizor.Controls.RibbonButtonLeft();
            BtnSair = new ReaLTaiizor.Controls.RibbonButtonLeft();
            SuspendLayout();
            // 
            // BtnUsuarios
            // 
            BtnUsuarios.BackColor = Color.Transparent;
            BtnUsuarios.BaseColorA = Color.FromArgb(203, 201, 205);
            BtnUsuarios.BaseColorB = Color.FromArgb(188, 186, 190);
            BtnUsuarios.BorderColorA = Color.FromArgb(117, 120, 117);
            BtnUsuarios.BorderColorB = Color.FromArgb(75, 255, 255, 255);
            BtnUsuarios.DownBaseColorA = Color.FromArgb(203, 201, 205);
            BtnUsuarios.DownBaseColorB = Color.FromArgb(188, 186, 190);
            BtnUsuarios.DownBorderColorA = Color.FromArgb(117, 120, 117);
            BtnUsuarios.DownBorderColorB = Color.FromArgb(75, 255, 255, 255);
            BtnUsuarios.Font = new Font("Tahoma", 8F, FontStyle.Bold);
            BtnUsuarios.ForeColor = Color.FromArgb(50, 50, 50);
            BtnUsuarios.HoverBaseColorA = Color.FromArgb(193, 191, 195);
            BtnUsuarios.HoverBaseColorB = Color.FromArgb(194, 192, 196);
            BtnUsuarios.HoverBorderColorA = Color.FromArgb(117, 120, 117);
            BtnUsuarios.HoverBorderColorB = Color.FromArgb(75, 255, 255, 255);
            BtnUsuarios.Location = new Point(85, 106);
            BtnUsuarios.Name = "BtnUsuarios";
            BtnUsuarios.Size = new Size(243, 193);
            BtnUsuarios.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BtnUsuarios.TabIndex = 0;
            BtnUsuarios.Text = "Usuários";
            BtnUsuarios.Click += BtnUsuarios_Click;
            // 
            // BtnChamado
            // 
            BtnChamado.BackColor = Color.Transparent;
            BtnChamado.BaseColorA = Color.FromArgb(203, 201, 205);
            BtnChamado.BaseColorB = Color.FromArgb(188, 186, 190);
            BtnChamado.BorderColorA = Color.FromArgb(117, 120, 117);
            BtnChamado.BorderColorB = Color.FromArgb(75, 255, 255, 255);
            BtnChamado.DownBaseColorA = Color.FromArgb(203, 201, 205);
            BtnChamado.DownBaseColorB = Color.FromArgb(188, 186, 190);
            BtnChamado.DownBorderColorA = Color.FromArgb(117, 120, 117);
            BtnChamado.DownBorderColorB = Color.FromArgb(75, 255, 255, 255);
            BtnChamado.Font = new Font("Tahoma", 8F, FontStyle.Bold);
            BtnChamado.ForeColor = Color.FromArgb(50, 50, 50);
            BtnChamado.HoverBaseColorA = Color.FromArgb(193, 191, 195);
            BtnChamado.HoverBaseColorB = Color.FromArgb(194, 192, 196);
            BtnChamado.HoverBorderColorA = Color.FromArgb(117, 120, 117);
            BtnChamado.HoverBorderColorB = Color.FromArgb(75, 255, 255, 255);
            BtnChamado.Location = new Point(446, 106);
            BtnChamado.Name = "BtnChamado";
            BtnChamado.Size = new Size(243, 193);
            BtnChamado.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BtnChamado.TabIndex = 1;
            BtnChamado.Text = "Chamado";
            BtnChamado.Click += BtnChamado_Click;
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
            BtnSair.TabIndex = 2;
            BtnSair.Text = "Sair";
            BtnSair.Click += BtnSair_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSair);
            Controls.Add(BtnChamado);
            Controls.Add(BtnUsuarios);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.RibbonButtonLeft BtnUsuarios;
        private ReaLTaiizor.Controls.RibbonButtonLeft BtnChamado;
        private ReaLTaiizor.Controls.RibbonButtonLeft BtnSair;
    }
}
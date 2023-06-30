namespace Generador_de_contraseñas
{
    partial class Form1
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
            txtNuevaContra = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtTamanoContra = new TextBox();
            chkMayus = new CheckBox();
            chkMinus = new CheckBox();
            chkNum = new CheckBox();
            chkSimbol = new CheckBox();
            btnGC = new Button();
            SuspendLayout();
            // 
            // txtNuevaContra
            // 
            txtNuevaContra.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNuevaContra.Location = new Point(12, 50);
            txtNuevaContra.Multiline = true;
            txtNuevaContra.Name = "txtNuevaContra";
            txtNuevaContra.Size = new Size(609, 141);
            txtNuevaContra.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(103, 9);
            label1.Name = "label1";
            label1.Size = new Size(412, 38);
            label1.TabIndex = 1;
            label1.Text = "Generador de Contraseñas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(143, 210);
            label2.Name = "label2";
            label2.Size = new Size(326, 24);
            label2.TabIndex = 2;
            label2.Text = "Cantidad de digitos en contraseña";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTamanoContra
            // 
            txtTamanoContra.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtTamanoContra.Location = new Point(14, 204);
            txtTamanoContra.Name = "txtTamanoContra";
            txtTamanoContra.Size = new Size(110, 34);
            txtTamanoContra.TabIndex = 3;
            txtTamanoContra.TextAlign = HorizontalAlignment.Right;
            txtTamanoContra.KeyPress += txtTamanoContra_KeyPress;
            // 
            // chkMayus
            // 
            chkMayus.AutoSize = true;
            chkMayus.Font = new Font("Arial Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            chkMayus.ForeColor = Color.Transparent;
            chkMayus.Location = new Point(109, 254);
            chkMayus.Name = "chkMayus";
            chkMayus.Size = new Size(213, 28);
            chkMayus.TabIndex = 4;
            chkMayus.Text = "   Incluir Mayuscula";
            chkMayus.UseVisualStyleBackColor = true;
            // 
            // chkMinus
            // 
            chkMinus.AutoSize = true;
            chkMinus.Font = new Font("Arial Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            chkMinus.ForeColor = Color.Transparent;
            chkMinus.Location = new Point(109, 288);
            chkMinus.Name = "chkMinus";
            chkMinus.Size = new Size(209, 28);
            chkMinus.TabIndex = 5;
            chkMinus.Text = "   Incluir Minuscula";
            chkMinus.UseVisualStyleBackColor = true;
            // 
            // chkNum
            // 
            chkNum.AutoSize = true;
            chkNum.Font = new Font("Arial Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            chkNum.ForeColor = Color.Transparent;
            chkNum.Location = new Point(109, 322);
            chkNum.Name = "chkNum";
            chkNum.Size = new Size(198, 28);
            chkNum.TabIndex = 6;
            chkNum.Text = "   Incluir Numeros";
            chkNum.UseVisualStyleBackColor = true;
            // 
            // chkSimbol
            // 
            chkSimbol.AutoSize = true;
            chkSimbol.Font = new Font("Arial Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            chkSimbol.ForeColor = Color.Transparent;
            chkSimbol.Location = new Point(109, 356);
            chkSimbol.Name = "chkSimbol";
            chkSimbol.Size = new Size(200, 28);
            chkSimbol.TabIndex = 7;
            chkSimbol.Text = "   Incluir Simbolos";
            chkSimbol.UseVisualStyleBackColor = true;
            // 
            // btnGC
            // 
            btnGC.BackColor = Color.FromArgb(46, 46, 46);
            btnGC.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGC.ForeColor = Color.Transparent;
            btnGC.Location = new Point(374, 270);
            btnGC.Name = "btnGC";
            btnGC.Size = new Size(199, 97);
            btnGC.TabIndex = 8;
            btnGC.Text = "Generar";
            btnGC.UseVisualStyleBackColor = false;
            btnGC.Click += btnGC_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(628, 391);
            Controls.Add(btnGC);
            Controls.Add(chkSimbol);
            Controls.Add(chkNum);
            Controls.Add(chkMinus);
            Controls.Add(chkMayus);
            Controls.Add(txtTamanoContra);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNuevaContra);
            Name = "Form1";
            Text = "Generador de contraseñas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNuevaContra;
        private Label label1;
        private Label label2;
        private TextBox txtTamanoContra;
        private CheckBox chkMayus;
        private CheckBox chkMinus;
        private CheckBox chkNum;
        private CheckBox chkSimbol;
        private Button btnGC;
    }
}
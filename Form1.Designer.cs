namespace Cronometro
{
    partial class frmCronometro
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
            components = new System.ComponentModel.Container();
            btnIniciar = new Button();
            btnDetener = new Button();
            btnReset = new Button();
            tmrCronometro = new System.Windows.Forms.Timer(components);
            lblCronometro = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(192, 255, 192);
            btnIniciar.Location = new Point(58, 213);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnDetener
            // 
            btnDetener.BackColor = Color.FromArgb(255, 255, 128);
            btnDetener.Location = new Point(187, 213);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(75, 23);
            btnDetener.TabIndex = 1;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = false;
            btnDetener.Click += btnDetener_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(255, 128, 128);
            btnReset.Location = new Point(314, 213);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click_1;
            // 
            // tmrCronometro
            // 
            tmrCronometro.Interval = 200;
            tmrCronometro.Tick += tmrCronometro_Tick;
            // 
            // lblCronometro
            // 
            lblCronometro.AutoSize = true;
            lblCronometro.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCronometro.Location = new Point(91, 36);
            lblCronometro.Name = "lblCronometro";
            lblCronometro.Size = new Size(309, 128);
            lblCronometro.TabIndex = 3;
            lblCronometro.Text = "00:00 ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(204, 138);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "m";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(336, 138);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 5;
            label2.Text = "s";
            // 
            // frmCronometro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 287);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCronometro);
            Controls.Add(btnReset);
            Controls.Add(btnDetener);
            Controls.Add(btnIniciar);
            Name = "frmCronometro";
            Text = "Cronometro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private Button btnDetener;
        private Button btnReset;
        private System.Windows.Forms.Timer tmrCronometro;
        private Label lblCronometro;
        private Label label1;
        private Label label2;
    }
}

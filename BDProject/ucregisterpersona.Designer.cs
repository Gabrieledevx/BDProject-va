namespace BDProject
{
    partial class ucregisterpersona
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtape = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcelular
            // 
            this.txtcelular.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtcelular.Location = new System.Drawing.Point(103, 417);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.PlaceholderText = "Ingrese celular";
            this.txtcelular.Size = new System.Drawing.Size(541, 34);
            this.txtcelular.TabIndex = 27;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtcorreo.Location = new System.Drawing.Point(103, 361);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.PlaceholderText = "Ingrese correo";
            this.txtcorreo.Size = new System.Drawing.Size(541, 34);
            this.txtcorreo.TabIndex = 26;
            // 
            // txtedad
            // 
            this.txtedad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtedad.Location = new System.Drawing.Point(103, 306);
            this.txtedad.Name = "txtedad";
            this.txtedad.PlaceholderText = "Ingrese edad";
            this.txtedad.Size = new System.Drawing.Size(541, 34);
            this.txtedad.TabIndex = 25;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtid.Location = new System.Drawing.Point(103, 122);
            this.txtid.Name = "txtid";
            this.txtid.PlaceholderText = "Ingrese ID de persona";
            this.txtid.Size = new System.Drawing.Size(541, 34);
            this.txtid.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(378, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 34);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(527, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 34);
            this.button1.TabIndex = 22;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtape
            // 
            this.txtape.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtape.Location = new System.Drawing.Point(103, 242);
            this.txtape.Name = "txtape";
            this.txtape.PlaceholderText = "Ingrese apellidos";
            this.txtape.Size = new System.Drawing.Size(541, 34);
            this.txtape.TabIndex = 21;
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtnom.Location = new System.Drawing.Point(103, 182);
            this.txtnom.Name = "txtnom";
            this.txtnom.PlaceholderText = "Ingrese nombres";
            this.txtnom.Size = new System.Drawing.Size(541, 34);
            this.txtnom.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 85);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de persona";
            // 
            // ucregisterpersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtape);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.panel1);
            this.Name = "ucregisterpersona";
            this.Size = new System.Drawing.Size(809, 556);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtcelular;
        private TextBox txtcorreo;
        private TextBox txtedad;
        private TextBox txtid;
        private Button button2;
        private Button button1;
        private TextBox txtape;
        private TextBox txtnom;
        private Panel panel1;
        private Label label1;
    }
}

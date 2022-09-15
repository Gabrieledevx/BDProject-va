namespace BDProject.Model
{
    partial class idk
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtdir = new System.Windows.Forms.TextBox();
            this.txtdias = new System.Windows.Forms.TextBox();
            this.txtmet = new System.Windows.Forms.TextBox();
            this.txtidclt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 85);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cree una nueva reservación, agregue el ID de cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(356, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 34);
            this.button2.TabIndex = 36;
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
            this.button1.Location = new System.Drawing.Point(505, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 34);
            this.button1.TabIndex = 35;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtid.Location = new System.Drawing.Point(67, 157);
            this.txtid.Name = "txtid";
            this.txtid.PlaceholderText = "Ingrese ID de reservacion";
            this.txtid.Size = new System.Drawing.Size(541, 34);
            this.txtid.TabIndex = 34;
            // 
            // txtdir
            // 
            this.txtdir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtdir.Location = new System.Drawing.Point(67, 222);
            this.txtdir.Name = "txtdir";
            this.txtdir.PlaceholderText = "Ingrese dirección";
            this.txtdir.Size = new System.Drawing.Size(541, 34);
            this.txtdir.TabIndex = 33;
            // 
            // txtdias
            // 
            this.txtdias.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtdias.Location = new System.Drawing.Point(67, 283);
            this.txtdias.Name = "txtdias";
            this.txtdias.PlaceholderText = "Ingrese días de reservacion";
            this.txtdias.Size = new System.Drawing.Size(541, 34);
            this.txtdias.TabIndex = 37;
            // 
            // txtmet
            // 
            this.txtmet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtmet.Location = new System.Drawing.Point(67, 352);
            this.txtmet.Name = "txtmet";
            this.txtmet.PlaceholderText = "Ingrese metodo de pago - 01 efectivo 02 crédito";
            this.txtmet.Size = new System.Drawing.Size(541, 34);
            this.txtmet.TabIndex = 38;
            // 
            // txtidclt
            // 
            this.txtidclt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtidclt.Location = new System.Drawing.Point(67, 414);
            this.txtidclt.Name = "txtidclt";
            this.txtidclt.PlaceholderText = "Ingrese ID de cliente";
            this.txtidclt.Size = new System.Drawing.Size(541, 34);
            this.txtidclt.TabIndex = 39;
            // 
            // ucreservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtidclt);
            this.Controls.Add(this.txtmet);
            this.Controls.Add(this.txtdias);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtdir);
            this.Controls.Add(this.panel1);
            this.Name = "ucreservaciones";
            this.Size = new System.Drawing.Size(809, 556);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox txtid;
        private TextBox txtdir;
        private TextBox txtdias;
        private TextBox txtmet;
        private TextBox txtidclt;
    }
}

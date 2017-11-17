namespace InyeccionDeDependencias
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMensaje = new System.Windows.Forms.Button();
            this.btnCorreo = new System.Windows.Forms.Button();
            this.brnLog = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMensaje
            // 
            this.btnMensaje.Location = new System.Drawing.Point(258, 172);
            this.btnMensaje.Name = "btnMensaje";
            this.btnMensaje.Size = new System.Drawing.Size(75, 23);
            this.btnMensaje.TabIndex = 0;
            this.btnMensaje.Text = "Mensaje";
            this.btnMensaje.UseVisualStyleBackColor = true;
            this.btnMensaje.Click += new System.EventHandler(this.btnMensaje_Click);
            // 
            // btnCorreo
            // 
            this.btnCorreo.Location = new System.Drawing.Point(258, 107);
            this.btnCorreo.Name = "btnCorreo";
            this.btnCorreo.Size = new System.Drawing.Size(75, 23);
            this.btnCorreo.TabIndex = 1;
            this.btnCorreo.Text = "Correo";
            this.btnCorreo.UseVisualStyleBackColor = true;
            this.btnCorreo.Click += new System.EventHandler(this.btnCorreo_Click);
            // 
            // brnLog
            // 
            this.brnLog.Location = new System.Drawing.Point(258, 42);
            this.brnLog.Name = "brnLog";
            this.brnLog.Size = new System.Drawing.Size(75, 23);
            this.brnLog.TabIndex = 2;
            this.brnLog.Text = "Log";
            this.brnLog.UseVisualStyleBackColor = true;
            this.brnLog.Click += new System.EventHandler(this.brnLog_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(68, 42);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(162, 153);
            this.txtMensaje.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 241);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.brnLog);
            this.Controls.Add(this.btnCorreo);
            this.Controls.Add(this.btnMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMensaje;
        private System.Windows.Forms.Button btnCorreo;
        private System.Windows.Forms.Button brnLog;
        private System.Windows.Forms.TextBox txtMensaje;
    }
}


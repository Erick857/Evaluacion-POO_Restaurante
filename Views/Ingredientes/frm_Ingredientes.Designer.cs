namespace Evaluacion_POO_Restaurante.Views.Ingredientes
{
    partial class frm_Ingredientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.lst_ingredientes = new System.Windows.Forms.ListBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_IDProveedor = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Ingrediente";
            // 
            // lst_ingredientes
            // 
            this.lst_ingredientes.FormattingEnabled = true;
            this.lst_ingredientes.ItemHeight = 29;
            this.lst_ingredientes.Location = new System.Drawing.Point(512, 71);
            this.lst_ingredientes.Name = "lst_ingredientes";
            this.lst_ingredientes.Size = new System.Drawing.Size(486, 439);
            this.lst_ingredientes.TabIndex = 1;
            this.lst_ingredientes.SelectedIndexChanged += new System.EventHandler(this.lst_ingredientes_SelectedIndexChanged);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(115, 187);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(317, 34);
            this.txt_Nombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 263);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Proveedor";
            // 
            // cmb_IDProveedor
            // 
            this.cmb_IDProveedor.FormattingEnabled = true;
            this.cmb_IDProveedor.Location = new System.Drawing.Point(115, 318);
            this.cmb_IDProveedor.Name = "cmb_IDProveedor";
            this.cmb_IDProveedor.Size = new System.Drawing.Size(317, 37);
            this.cmb_IDProveedor.TabIndex = 4;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(94, 516);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(139, 74);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(272, 516);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(139, 74);
            this.btn_eliminar.TabIndex = 6;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(453, 516);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(139, 74);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_Ingredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 611);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.cmb_IDProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lst_ingredientes);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Ingredientes";
            this.Text = "frm_Ingredientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_ingredientes;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_IDProveedor;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}
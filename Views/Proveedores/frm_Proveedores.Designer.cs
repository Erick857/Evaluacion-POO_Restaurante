namespace Evaluacion_POO_Restaurante.Views.Proveedores
{
    partial class frm_Proveedores
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
            this.txt_nombreProveedor = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lst_Proveedores = new System.Windows.Forms.ListBox();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Proveedor";
            // 
            // txt_nombreProveedor
            // 
            this.txt_nombreProveedor.Location = new System.Drawing.Point(50, 166);
            this.txt_nombreProveedor.Name = "txt_nombreProveedor";
            this.txt_nombreProveedor.Size = new System.Drawing.Size(270, 34);
            this.txt_nombreProveedor.TabIndex = 1;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(50, 247);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(128, 71);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(192, 247);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(128, 71);
            this.btn_actualizar.TabIndex = 6;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(50, 350);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(128, 71);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lst_Proveedores
            // 
            this.lst_Proveedores.FormattingEnabled = true;
            this.lst_Proveedores.ItemHeight = 29;
            this.lst_Proveedores.Location = new System.Drawing.Point(365, 97);
            this.lst_Proveedores.Name = "lst_Proveedores";
            this.lst_Proveedores.Size = new System.Drawing.Size(422, 352);
            this.lst_Proveedores.TabIndex = 8;
            this.lst_Proveedores.SelectedIndexChanged += new System.EventHandler(this.lst_Proveedores_SelectedIndexChanged);
            // 
            // btn_reporte
            // 
            this.btn_reporte.Location = new System.Drawing.Point(192, 350);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(128, 71);
            this.btn_reporte.TabIndex = 9;
            this.btn_reporte.Text = "Reporte";
            this.btn_reporte.UseVisualStyleBackColor = true;
            this.btn_reporte.Click += new System.EventHandler(this.btn_reporte_Click);
            // 
            // frm_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 468);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.lst_Proveedores);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_nombreProveedor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Proveedores";
            this.Text = "frm_Proveedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombreProveedor;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ListBox lst_Proveedores;
        private System.Windows.Forms.Button btn_reporte;
    }
}
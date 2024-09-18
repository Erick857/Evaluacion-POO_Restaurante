namespace Evaluacion_POO_Restaurante.Views.Platos
{
    partial class frm_Platos
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombrePlato = new System.Windows.Forms.TextBox();
            this.lst_platos = new System.Windows.Forms.ListBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Plato";
            // 
            // txt_nombrePlato
            // 
            this.txt_nombrePlato.Location = new System.Drawing.Point(59, 156);
            this.txt_nombrePlato.Name = "txt_nombrePlato";
            this.txt_nombrePlato.Size = new System.Drawing.Size(303, 34);
            this.txt_nombrePlato.TabIndex = 2;
            // 
            // lst_platos
            // 
            this.lst_platos.FormattingEnabled = true;
            this.lst_platos.ItemHeight = 29;
            this.lst_platos.Location = new System.Drawing.Point(390, 86);
            this.lst_platos.Name = "lst_platos";
            this.lst_platos.Size = new System.Drawing.Size(459, 352);
            this.lst_platos.TabIndex = 4;
            this.lst_platos.SelectedIndexChanged += new System.EventHandler(this.lst_platos_SelectedIndexChanged);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(59, 221);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(137, 66);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(225, 221);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(137, 66);
            this.btn_actualizar.TabIndex = 6;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(225, 315);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(137, 66);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(59, 315);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(137, 66);
            this.btn_eliminar.TabIndex = 8;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // frm_Platos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 461);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lst_platos);
            this.Controls.Add(this.txt_nombrePlato);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Platos";
            this.Text = "frm_Platos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombrePlato;
        private System.Windows.Forms.ListBox lst_platos;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_eliminar;
    }
}
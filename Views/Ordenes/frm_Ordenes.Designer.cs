namespace Evaluacion_POO_Restaurante.Views.Ordenes
{
    partial class frm_Ordenes
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
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_ordenes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_platos = new System.Windows.Forms.ComboBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(114, 321);
            this.dtp_fecha.Margin = new System.Windows.Forms.Padding(5);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(347, 34);
            this.dtp_fecha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Plato ";
            // 
            // lst_ordenes
            // 
            this.lst_ordenes.FormattingEnabled = true;
            this.lst_ordenes.ItemHeight = 29;
            this.lst_ordenes.Location = new System.Drawing.Point(513, 92);
            this.lst_ordenes.Name = "lst_ordenes";
            this.lst_ordenes.Size = new System.Drawing.Size(459, 381);
            this.lst_ordenes.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha";
            // 
            // cmb_platos
            // 
            this.cmb_platos.FormattingEnabled = true;
            this.cmb_platos.Location = new System.Drawing.Point(114, 186);
            this.cmb_platos.Name = "cmb_platos";
            this.cmb_platos.Size = new System.Drawing.Size(347, 37);
            this.cmb_platos.TabIndex = 4;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(114, 492);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(159, 70);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(302, 492);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(159, 70);
            this.btn_actualizar.TabIndex = 6;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(490, 492);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(159, 70);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 586);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.cmb_platos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_ordenes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_fecha);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Ordenes";
            this.Text = "frm_Ordenes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_ordenes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_platos;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}

namespace WTFBarber
{
    partial class Nomina
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
            this.lbl_Nomina = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Pagar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Comisiones = new System.Windows.Forms.TextBox();
            this.lbl_SueldoBase = new System.Windows.Forms.Label();
            this.txt_SueldoBase = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.lbl_Empleados = new System.Windows.Forms.Label();
            this.btn_MostrarDatos = new System.Windows.Forms.Button();
            this.lbl_Hasta = new System.Windows.Forms.Label();
            this.lbl_Desde = new System.Windows.Forms.Label();
            this.txt_Empleados = new System.Windows.Forms.TextBox();
            this.dtp_Desde = new System.Windows.Forms.DateTimePicker();
            this.dtp_Hasta = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_Nomina
            // 
            this.lbl_Nomina.AutoSize = true;
            this.lbl_Nomina.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nomina.Location = new System.Drawing.Point(269, 27);
            this.lbl_Nomina.Name = "lbl_Nomina";
            this.lbl_Nomina.Size = new System.Drawing.Size(252, 58);
            this.lbl_Nomina.TabIndex = 12;
            this.lbl_Nomina.Text = "Nómina";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Cancelar.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Red;
            this.btn_Cancelar.Location = new System.Drawing.Point(260, 380);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(145, 35);
            this.btn_Cancelar.TabIndex = 22;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Pagar
            // 
            this.btn_Pagar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Pagar.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Pagar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Pagar.Location = new System.Drawing.Point(468, 380);
            this.btn_Pagar.Name = "btn_Pagar";
            this.btn_Pagar.Size = new System.Drawing.Size(145, 35);
            this.btn_Pagar.TabIndex = 21;
            this.btn_Pagar.Text = "Pagar";
            this.btn_Pagar.UseVisualStyleBackColor = true;
            this.btn_Pagar.Click += new System.EventHandler(this.btn_Cobrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(521, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Comisiones";
            // 
            // txt_Comisiones
            // 
            this.txt_Comisiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Comisiones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Comisiones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Comisiones.Enabled = false;
            this.txt_Comisiones.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Comisiones.ForeColor = System.Drawing.Color.Silver;
            this.txt_Comisiones.Location = new System.Drawing.Point(521, 223);
            this.txt_Comisiones.Name = "txt_Comisiones";
            this.txt_Comisiones.PlaceholderText = "%";
            this.txt_Comisiones.Size = new System.Drawing.Size(200, 26);
            this.txt_Comisiones.TabIndex = 29;
            // 
            // lbl_SueldoBase
            // 
            this.lbl_SueldoBase.AutoSize = true;
            this.lbl_SueldoBase.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_SueldoBase.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_SueldoBase.Location = new System.Drawing.Point(521, 110);
            this.lbl_SueldoBase.Name = "lbl_SueldoBase";
            this.lbl_SueldoBase.Size = new System.Drawing.Size(126, 23);
            this.lbl_SueldoBase.TabIndex = 26;
            this.lbl_SueldoBase.Text = "Sueldo Base";
            // 
            // txt_SueldoBase
            // 
            this.txt_SueldoBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_SueldoBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SueldoBase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SueldoBase.Enabled = false;
            this.txt_SueldoBase.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SueldoBase.ForeColor = System.Drawing.Color.Silver;
            this.txt_SueldoBase.Location = new System.Drawing.Point(521, 136);
            this.txt_SueldoBase.Name = "txt_SueldoBase";
            this.txt_SueldoBase.PlaceholderText = "$";
            this.txt_SueldoBase.Size = new System.Drawing.Size(200, 26);
            this.txt_SueldoBase.TabIndex = 25;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Total.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Total.Location = new System.Drawing.Point(293, 313);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(57, 23);
            this.lbl_Total.TabIndex = 32;
            this.lbl_Total.Text = "Total";
            // 
            // txt_Total
            // 
            this.txt_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Total.Enabled = false;
            this.txt_Total.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Total.ForeColor = System.Drawing.Color.Silver;
            this.txt_Total.Location = new System.Drawing.Point(356, 310);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.PlaceholderText = "$";
            this.txt_Total.Size = new System.Drawing.Size(200, 26);
            this.txt_Total.TabIndex = 31;
            // 
            // lbl_Empleados
            // 
            this.lbl_Empleados.AutoSize = true;
            this.lbl_Empleados.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Empleados.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Empleados.Location = new System.Drawing.Point(223, 155);
            this.lbl_Empleados.Name = "lbl_Empleados";
            this.lbl_Empleados.Size = new System.Drawing.Size(118, 23);
            this.lbl_Empleados.TabIndex = 24;
            this.lbl_Empleados.Text = "Empleados";
            // 
            // btn_MostrarDatos
            // 
            this.btn_MostrarDatos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_MostrarDatos.Font = new System.Drawing.Font("Perpetua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MostrarDatos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_MostrarDatos.Location = new System.Drawing.Point(49, 155);
            this.btn_MostrarDatos.Name = "btn_MostrarDatos";
            this.btn_MostrarDatos.Size = new System.Drawing.Size(116, 27);
            this.btn_MostrarDatos.TabIndex = 34;
            this.btn_MostrarDatos.Text = "Mostrar Datos";
            this.btn_MostrarDatos.UseVisualStyleBackColor = true;
            this.btn_MostrarDatos.Click += new System.EventHandler(this.btn_MostrarDatos_Click);
            // 
            // lbl_Hasta
            // 
            this.lbl_Hasta.AutoSize = true;
            this.lbl_Hasta.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Hasta.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Hasta.Location = new System.Drawing.Point(12, 114);
            this.lbl_Hasta.Name = "lbl_Hasta";
            this.lbl_Hasta.Size = new System.Drawing.Size(50, 19);
            this.lbl_Hasta.TabIndex = 38;
            this.lbl_Hasta.Text = "Hasta";
            // 
            // lbl_Desde
            // 
            this.lbl_Desde.AutoSize = true;
            this.lbl_Desde.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Desde.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Desde.Location = new System.Drawing.Point(12, 59);
            this.lbl_Desde.Name = "lbl_Desde";
            this.lbl_Desde.Size = new System.Drawing.Size(56, 19);
            this.lbl_Desde.TabIndex = 37;
            this.lbl_Desde.Text = "Desde";
            // 
            // txt_Empleados
            // 
            this.txt_Empleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Empleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Empleados.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Empleados.Enabled = false;
            this.txt_Empleados.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Empleados.ForeColor = System.Drawing.Color.Silver;
            this.txt_Empleados.Location = new System.Drawing.Point(223, 182);
            this.txt_Empleados.Name = "txt_Empleados";
            this.txt_Empleados.Size = new System.Drawing.Size(200, 26);
            this.txt_Empleados.TabIndex = 39;
            // 
            // dtp_Desde
            // 
            this.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Desde.Location = new System.Drawing.Point(68, 59);
            this.dtp_Desde.Name = "dtp_Desde";
            this.dtp_Desde.Size = new System.Drawing.Size(97, 23);
            this.dtp_Desde.TabIndex = 40;
            // 
            // dtp_Hasta
            // 
            this.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Hasta.Location = new System.Drawing.Point(68, 110);
            this.dtp_Hasta.Name = "dtp_Hasta";
            this.dtp_Hasta.Size = new System.Drawing.Size(97, 23);
            this.dtp_Hasta.TabIndex = 41;
            // 
            // Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtp_Hasta);
            this.Controls.Add(this.dtp_Desde);
            this.Controls.Add(this.txt_Empleados);
            this.Controls.Add(this.lbl_Hasta);
            this.Controls.Add(this.lbl_Desde);
            this.Controls.Add(this.btn_MostrarDatos);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Comisiones);
            this.Controls.Add(this.lbl_SueldoBase);
            this.Controls.Add(this.txt_SueldoBase);
            this.Controls.Add(this.lbl_Empleados);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Pagar);
            this.Controls.Add(this.lbl_Nomina);
            this.Name = "Nomina";
            this.Text = "Nomina";
            this.Load += new System.EventHandler(this.Nomina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nomina;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Pagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Comisiones;
        private System.Windows.Forms.Label lbl_SueldoBase;
        private System.Windows.Forms.TextBox txt_SueldoBase;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label lbl_Empleados;
        private System.Windows.Forms.Button btn_MostrarDatos;
        private System.Windows.Forms.Label lbl_Hasta;
        private System.Windows.Forms.Label lbl_Desde;
        private System.Windows.Forms.TextBox txt_Empleados;
        private System.Windows.Forms.DateTimePicker dtp_Desde;
        private System.Windows.Forms.DateTimePicker dtp_Hasta;
    }
}
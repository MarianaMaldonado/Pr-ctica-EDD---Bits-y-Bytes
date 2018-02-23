namespace práctica_bitsybytes
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEntradaDeDatos = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lblSensores = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblDirección = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblLecturaDeFecha = new System.Windows.Forms.Label();
            this.picboxDirecciónDeMovimiento = new System.Windows.Forms.PictureBox();
            this.picboxNivel = new System.Windows.Forms.PictureBox();
            this.picboxSensor1 = new System.Windows.Forms.PictureBox();
            this.picboxSensor2 = new System.Windows.Forms.PictureBox();
            this.lblSensor1 = new System.Windows.Forms.Label();
            this.lblSensor2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDirecciónDeMovimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxNivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSensor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSensor2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(12, 38);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(132, 18);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Entrada de datos:";
            // 
            // txtEntradaDeDatos
            // 
            this.txtEntradaDeDatos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntradaDeDatos.Location = new System.Drawing.Point(142, 34);
            this.txtEntradaDeDatos.Name = "txtEntradaDeDatos";
            this.txtEntradaDeDatos.Size = new System.Drawing.Size(111, 26);
            this.txtEntradaDeDatos.TabIndex = 1;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.Location = new System.Drawing.Point(271, 27);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(85, 38);
            this.btnProcesar.TabIndex = 2;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // lblSensores
            // 
            this.lblSensores.AutoSize = true;
            this.lblSensores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensores.Location = new System.Drawing.Point(37, 92);
            this.lblSensores.Name = "lblSensores";
            this.lblSensores.Size = new System.Drawing.Size(75, 18);
            this.lblSensores.TabIndex = 3;
            this.lblSensores.Text = "Sensores";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(211, 92);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(42, 18);
            this.lblNivel.TabIndex = 4;
            this.lblNivel.Text = "Nivel";
            // 
            // lblDirección
            // 
            this.lblDirección.AutoSize = true;
            this.lblDirección.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirección.Location = new System.Drawing.Point(301, 92);
            this.lblDirección.Name = "lblDirección";
            this.lblDirección.Size = new System.Drawing.Size(181, 18);
            this.lblDirección.TabIndex = 5;
            this.lblDirección.Text = "Dirección de movimiento";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(143, 299);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 18);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "label1";
            // 
            // lblLecturaDeFecha
            // 
            this.lblLecturaDeFecha.AutoSize = true;
            this.lblLecturaDeFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecturaDeFecha.Location = new System.Drawing.Point(9, 299);
            this.lblLecturaDeFecha.Name = "lblLecturaDeFecha";
            this.lblLecturaDeFecha.Size = new System.Drawing.Size(128, 18);
            this.lblLecturaDeFecha.TabIndex = 11;
            this.lblLecturaDeFecha.Text = "Lectura de fecha:";
            // 
            // picboxDirecciónDeMovimiento
            // 
            this.picboxDirecciónDeMovimiento.Location = new System.Drawing.Point(320, 119);
            this.picboxDirecciónDeMovimiento.Name = "picboxDirecciónDeMovimiento";
            this.picboxDirecciónDeMovimiento.Size = new System.Drawing.Size(123, 79);
            this.picboxDirecciónDeMovimiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxDirecciónDeMovimiento.TabIndex = 9;
            this.picboxDirecciónDeMovimiento.TabStop = false;
            // 
            // picboxNivel
            // 
            this.picboxNivel.Location = new System.Drawing.Point(175, 119);
            this.picboxNivel.Name = "picboxNivel";
            this.picboxNivel.Size = new System.Drawing.Size(126, 79);
            this.picboxNivel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxNivel.TabIndex = 8;
            this.picboxNivel.TabStop = false;
            // 
            // picboxSensor1
            // 
            this.picboxSensor1.Location = new System.Drawing.Point(19, 119);
            this.picboxSensor1.Name = "picboxSensor1";
            this.picboxSensor1.Size = new System.Drawing.Size(125, 79);
            this.picboxSensor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxSensor1.TabIndex = 7;
            this.picboxSensor1.TabStop = false;
            // 
            // picboxSensor2
            // 
            this.picboxSensor2.Location = new System.Drawing.Point(18, 204);
            this.picboxSensor2.Name = "picboxSensor2";
            this.picboxSensor2.Size = new System.Drawing.Size(126, 84);
            this.picboxSensor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxSensor2.TabIndex = 6;
            this.picboxSensor2.TabStop = false;
            // 
            // lblSensor1
            // 
            this.lblSensor1.AutoSize = true;
            this.lblSensor1.Location = new System.Drawing.Point(0, 151);
            this.lblSensor1.Name = "lblSensor1";
            this.lblSensor1.Size = new System.Drawing.Size(13, 13);
            this.lblSensor1.TabIndex = 12;
            this.lblSensor1.Text = "1";
            // 
            // lblSensor2
            // 
            this.lblSensor2.AutoSize = true;
            this.lblSensor2.Location = new System.Drawing.Point(-1, 242);
            this.lblSensor2.Name = "lblSensor2";
            this.lblSensor2.Size = new System.Drawing.Size(13, 13);
            this.lblSensor2.TabIndex = 13;
            this.lblSensor2.Text = "2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 375);
            this.Controls.Add(this.lblSensor2);
            this.Controls.Add(this.lblSensor1);
            this.Controls.Add(this.lblLecturaDeFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.picboxDirecciónDeMovimiento);
            this.Controls.Add(this.picboxNivel);
            this.Controls.Add(this.picboxSensor1);
            this.Controls.Add(this.picboxSensor2);
            this.Controls.Add(this.lblDirección);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblSensores);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtEntradaDeDatos);
            this.Controls.Add(this.lblEstado);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picboxDirecciónDeMovimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxNivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSensor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSensor2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEntradaDeDatos;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label lblSensores;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblDirección;
        private System.Windows.Forms.PictureBox picboxSensor2;
        private System.Windows.Forms.PictureBox picboxSensor1;
        private System.Windows.Forms.PictureBox picboxNivel;
        private System.Windows.Forms.PictureBox picboxDirecciónDeMovimiento;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblLecturaDeFecha;
        private System.Windows.Forms.Label lblSensor1;
        private System.Windows.Forms.Label lblSensor2;
    }
}


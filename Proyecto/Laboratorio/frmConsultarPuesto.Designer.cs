﻿namespace Laboratorio
{
    partial class frmConsultarPuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarPuesto));
            this.grdPuesto = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpActualizar = new System.Windows.Forms.GroupBox();
            this.lblActualizarPuesto = new System.Windows.Forms.Label();
            this.txtActualizarPuesto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdPuesto)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpActualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdPuesto
            // 
            this.grdPuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Puesto});
            this.grdPuesto.Location = new System.Drawing.Point(165, 118);
            this.grdPuesto.Name = "grdPuesto";
            this.grdPuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPuesto.Size = new System.Drawing.Size(506, 221);
            this.grdPuesto.TabIndex = 40;
            this.grdPuesto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPuesto_CellContentClick);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Puesto
            // 
            this.Puesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.Name = "Puesto";
            this.Puesto.ReadOnly = true;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(220, 29);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(453, 20);
            this.txtPuesto.TabIndex = 39;
            this.txtPuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuesto_KeyPress);
            this.txtPuesto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPuesto_KeyUp);
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.BackColor = System.Drawing.Color.Transparent;
            this.lblPuesto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(161, 28);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(53, 19);
            this.lblPuesto.TabIndex = 38;
            this.lblPuesto.Text = "Puesto";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 342);
            this.panel1.TabIndex = 37;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 266);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(110, 50);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(12, 136);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 50);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(12, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 50);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(12, 75);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(110, 50);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(12, 201);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grpActualizar
            // 
            this.grpActualizar.Controls.Add(this.lblActualizarPuesto);
            this.grpActualizar.Controls.Add(this.txtActualizarPuesto);
            this.grpActualizar.Enabled = false;
            this.grpActualizar.Location = new System.Drawing.Point(165, 62);
            this.grpActualizar.Name = "grpActualizar";
            this.grpActualizar.Size = new System.Drawing.Size(483, 50);
            this.grpActualizar.TabIndex = 41;
            this.grpActualizar.TabStop = false;
            this.grpActualizar.Text = "Actualizar";
            // 
            // lblActualizarPuesto
            // 
            this.lblActualizarPuesto.AutoSize = true;
            this.lblActualizarPuesto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarPuesto.Location = new System.Drawing.Point(6, 24);
            this.lblActualizarPuesto.Name = "lblActualizarPuesto";
            this.lblActualizarPuesto.Size = new System.Drawing.Size(57, 19);
            this.lblActualizarPuesto.TabIndex = 1;
            this.lblActualizarPuesto.Text = "Puesto:";
            // 
            // txtActualizarPuesto
            // 
            this.txtActualizarPuesto.Location = new System.Drawing.Point(83, 24);
            this.txtActualizarPuesto.Name = "txtActualizarPuesto";
            this.txtActualizarPuesto.Size = new System.Drawing.Size(203, 20);
            this.txtActualizarPuesto.TabIndex = 0;
            this.txtActualizarPuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActualizarPuesto_KeyPress);
            // 
            // frmConsultarPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(684, 366);
            this.ControlBox = false;
            this.Controls.Add(this.grpActualizar);
            this.Controls.Add(this.grdPuesto);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultarPuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Puesto";
            ((System.ComponentModel.ISupportInitialize)(this.grdPuesto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grpActualizar.ResumeLayout(false);
            this.grpActualizar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPuesto;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.GroupBox grpActualizar;
        private System.Windows.Forms.Label lblActualizarPuesto;
        private System.Windows.Forms.TextBox txtActualizarPuesto;
        private System.Windows.Forms.Button btnHome;
    }
}
﻿namespace VISTA
{
    partial class frmTaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaller));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDatosMant = new System.Windows.Forms.GroupBox();
            this.gbProximo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaqFuturo = new System.Windows.Forms.TextBox();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.rbFinalizado = new System.Windows.Forms.RadioButton();
            this.rbProceso = new System.Windows.Forms.RadioButton();
            this.rbPendiente = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDetallesTrabajo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAvionDatos = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.gbGrillaMant = new System.Windows.Forms.GroupBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.cmbAeronaves = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvReparaciones = new System.Windows.Forms.DataGridView();
            this.gbMantFut = new System.Windows.Forms.GroupBox();
            this.refreshFut = new System.Windows.Forms.Button();
            this.cmbAvionesFut = new System.Windows.Forms.ComboBox();
            this.btnBuscarFut = new System.Windows.Forms.Button();
            this.dgvReparacionesFuturas = new System.Windows.Forms.DataGridView();
            this.gbDatosMant.SuspendLayout();
            this.gbProximo.SuspendLayout();
            this.gbEstado.SuspendLayout();
            this.gbGrillaMant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparaciones)).BeginInit();
            this.gbMantFut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparacionesFuturas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosMant
            // 
            this.gbDatosMant.Controls.Add(this.gbProximo);
            this.gbDatosMant.Controls.Add(this.gbEstado);
            this.gbDatosMant.Controls.Add(this.label2);
            this.gbDatosMant.Controls.Add(this.txtDetallesTrabajo);
            this.gbDatosMant.Controls.Add(this.label7);
            this.gbDatosMant.Controls.Add(this.dtpFin);
            this.gbDatosMant.Controls.Add(this.label5);
            this.gbDatosMant.Controls.Add(this.dtpInicio);
            this.gbDatosMant.Controls.Add(this.label1);
            this.gbDatosMant.Controls.Add(this.cmbAvionDatos);
            this.gbDatosMant.Controls.Add(this.btnCancelar);
            this.gbDatosMant.Controls.Add(this.btnGuardar);
            this.gbDatosMant.Controls.Add(this.label9);
            this.gbDatosMant.Controls.Add(this.txtID);
            this.gbDatosMant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosMant.ForeColor = System.Drawing.Color.White;
            this.gbDatosMant.Location = new System.Drawing.Point(905, 29);
            this.gbDatosMant.Name = "gbDatosMant";
            this.gbDatosMant.Size = new System.Drawing.Size(626, 756);
            this.gbDatosMant.TabIndex = 12;
            this.gbDatosMant.TabStop = false;
            this.gbDatosMant.Text = "Datos mantenimiento";
            // 
            // gbProximo
            // 
            this.gbProximo.Controls.Add(this.label3);
            this.gbProximo.Controls.Add(this.txtTaqFuturo);
            this.gbProximo.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.gbProximo.ForeColor = System.Drawing.Color.White;
            this.gbProximo.Location = new System.Drawing.Point(45, 502);
            this.gbProximo.Name = "gbProximo";
            this.gbProximo.Size = new System.Drawing.Size(528, 110);
            this.gbProximo.TabIndex = 46;
            this.gbProximo.TabStop = false;
            this.gbProximo.Text = "Proximo mantenimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label3.Location = new System.Drawing.Point(177, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 21);
            this.label3.TabIndex = 43;
            this.label3.Text = "Taquimetro (futuro)";
            // 
            // txtTaqFuturo
            // 
            this.txtTaqFuturo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtTaqFuturo.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtTaqFuturo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTaqFuturo.Location = new System.Drawing.Point(181, 62);
            this.txtTaqFuturo.Name = "txtTaqFuturo";
            this.txtTaqFuturo.Size = new System.Drawing.Size(156, 28);
            this.txtTaqFuturo.TabIndex = 42;
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.rbFinalizado);
            this.gbEstado.Controls.Add(this.rbProceso);
            this.gbEstado.Controls.Add(this.rbPendiente);
            this.gbEstado.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.gbEstado.ForeColor = System.Drawing.Color.White;
            this.gbEstado.Location = new System.Drawing.Point(45, 355);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(528, 110);
            this.gbEstado.TabIndex = 45;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado";
            // 
            // rbFinalizado
            // 
            this.rbFinalizado.AutoSize = true;
            this.rbFinalizado.Location = new System.Drawing.Point(356, 52);
            this.rbFinalizado.Name = "rbFinalizado";
            this.rbFinalizado.Size = new System.Drawing.Size(112, 25);
            this.rbFinalizado.TabIndex = 2;
            this.rbFinalizado.TabStop = true;
            this.rbFinalizado.Text = "Finalizado";
            this.rbFinalizado.UseVisualStyleBackColor = true;
            // 
            // rbProceso
            // 
            this.rbProceso.AutoSize = true;
            this.rbProceso.Location = new System.Drawing.Point(196, 52);
            this.rbProceso.Name = "rbProceso";
            this.rbProceso.Size = new System.Drawing.Size(123, 25);
            this.rbProceso.TabIndex = 1;
            this.rbProceso.TabStop = true;
            this.rbProceso.Text = "En proceso";
            this.rbProceso.UseVisualStyleBackColor = true;
            // 
            // rbPendiente
            // 
            this.rbPendiente.AutoSize = true;
            this.rbPendiente.Location = new System.Drawing.Point(40, 52);
            this.rbPendiente.Name = "rbPendiente";
            this.rbPendiente.Size = new System.Drawing.Size(116, 25);
            this.rbPendiente.TabIndex = 0;
            this.rbPendiente.TabStop = true;
            this.rbPendiente.Text = "Pendiente";
            this.rbPendiente.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label2.Location = new System.Drawing.Point(41, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Trabajos a realizar";
            // 
            // txtDetallesTrabajo
            // 
            this.txtDetallesTrabajo.Location = new System.Drawing.Point(45, 197);
            this.txtDetallesTrabajo.Multiline = true;
            this.txtDetallesTrabajo.Name = "txtDetallesTrabajo";
            this.txtDetallesTrabajo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetallesTrabajo.Size = new System.Drawing.Size(528, 127);
            this.txtDetallesTrabajo.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(330, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Fecha fin";
            // 
            // dtpFin
            // 
            this.dtpFin.CustomFormat = "";
            this.dtpFin.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(334, 125);
            this.dtpFin.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dtpFin.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(146, 28);
            this.dtpFin.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Fecha inicio";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "";
            this.dtpInicio.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(172, 125);
            this.dtpInicio.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dtpInicio.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(146, 28);
            this.dtpInicio.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Aeronave";
            // 
            // cmbAvionDatos
            // 
            this.cmbAvionDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cmbAvionDatos.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.cmbAvionDatos.ForeColor = System.Drawing.Color.White;
            this.cmbAvionDatos.FormattingEnabled = true;
            this.cmbAvionDatos.Location = new System.Drawing.Point(269, 65);
            this.cmbAvionDatos.Name = "cmbAvionDatos";
            this.cmbAvionDatos.Size = new System.Drawing.Size(146, 29);
            this.cmbAvionDatos.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(432, 688);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(157, 40);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(22, 688);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(157, 40);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(168, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "ID mant";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtID.Location = new System.Drawing.Point(172, 66);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(73, 28);
            this.txtID.TabIndex = 24;
            // 
            // gbGrillaMant
            // 
            this.gbGrillaMant.Controls.Add(this.btnReload);
            this.gbGrillaMant.Controls.Add(this.cmbAeronaves);
            this.gbGrillaMant.Controls.Add(this.btnConsultar);
            this.gbGrillaMant.Controls.Add(this.btnBuscar);
            this.gbGrillaMant.Controls.Add(this.btnEliminar);
            this.gbGrillaMant.Controls.Add(this.btnEditar);
            this.gbGrillaMant.Controls.Add(this.btnAgregar);
            this.gbGrillaMant.Controls.Add(this.dgvReparaciones);
            this.gbGrillaMant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGrillaMant.ForeColor = System.Drawing.Color.White;
            this.gbGrillaMant.Location = new System.Drawing.Point(50, 29);
            this.gbGrillaMant.Name = "gbGrillaMant";
            this.gbGrillaMant.Size = new System.Drawing.Size(826, 465);
            this.gbGrillaMant.TabIndex = 11;
            this.gbGrillaMant.TabStop = false;
            this.gbGrillaMant.Text = "Listado de mantenimientos";
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(54, 31);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(43, 40);
            this.btnReload.TabIndex = 10;
            this.btnReload.UseVisualStyleBackColor = false;
            // 
            // cmbAeronaves
            // 
            this.cmbAeronaves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cmbAeronaves.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAeronaves.ForeColor = System.Drawing.Color.White;
            this.cmbAeronaves.FormattingEnabled = true;
            this.cmbAeronaves.Location = new System.Drawing.Point(169, 38);
            this.cmbAeronaves.Name = "cmbAeronaves";
            this.cmbAeronaves.Size = new System.Drawing.Size(429, 29);
            this.cmbAeronaves.TabIndex = 9;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(348, 407);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(157, 40);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(621, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(157, 40);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(621, 407);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 40);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(185, 407);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(157, 40);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(22, 407);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(157, 40);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // dgvReparaciones
            // 
            this.dgvReparaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReparaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReparaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvReparaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReparaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReparaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReparaciones.ColumnHeadersHeight = 30;
            this.dgvReparaciones.EnableHeadersVisualStyles = false;
            this.dgvReparaciones.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgvReparaciones.Location = new System.Drawing.Point(23, 77);
            this.dgvReparaciones.Name = "dgvReparaciones";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReparaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReparaciones.RowHeadersVisible = false;
            this.dgvReparaciones.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReparaciones.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReparaciones.RowTemplate.Height = 24;
            this.dgvReparaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReparaciones.Size = new System.Drawing.Size(781, 324);
            this.dgvReparaciones.TabIndex = 0;
            // 
            // gbMantFut
            // 
            this.gbMantFut.Controls.Add(this.refreshFut);
            this.gbMantFut.Controls.Add(this.cmbAvionesFut);
            this.gbMantFut.Controls.Add(this.btnBuscarFut);
            this.gbMantFut.Controls.Add(this.dgvReparacionesFuturas);
            this.gbMantFut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMantFut.ForeColor = System.Drawing.Color.White;
            this.gbMantFut.Location = new System.Drawing.Point(50, 500);
            this.gbMantFut.Name = "gbMantFut";
            this.gbMantFut.Size = new System.Drawing.Size(826, 285);
            this.gbMantFut.TabIndex = 12;
            this.gbMantFut.TabStop = false;
            this.gbMantFut.Text = "Mantenimientos futuros";
            // 
            // refreshFut
            // 
            this.refreshFut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.refreshFut.FlatAppearance.BorderSize = 0;
            this.refreshFut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.refreshFut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.refreshFut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshFut.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshFut.Image = ((System.Drawing.Image)(resources.GetObject("refreshFut.Image")));
            this.refreshFut.Location = new System.Drawing.Point(54, 31);
            this.refreshFut.Name = "refreshFut";
            this.refreshFut.Size = new System.Drawing.Size(43, 40);
            this.refreshFut.TabIndex = 10;
            this.refreshFut.UseVisualStyleBackColor = false;
            // 
            // cmbAvionesFut
            // 
            this.cmbAvionesFut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cmbAvionesFut.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAvionesFut.ForeColor = System.Drawing.Color.White;
            this.cmbAvionesFut.FormattingEnabled = true;
            this.cmbAvionesFut.Location = new System.Drawing.Point(169, 38);
            this.cmbAvionesFut.Name = "cmbAvionesFut";
            this.cmbAvionesFut.Size = new System.Drawing.Size(429, 29);
            this.cmbAvionesFut.TabIndex = 9;
            // 
            // btnBuscarFut
            // 
            this.btnBuscarFut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBuscarFut.FlatAppearance.BorderSize = 0;
            this.btnBuscarFut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBuscarFut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnBuscarFut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFut.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFut.Location = new System.Drawing.Point(621, 31);
            this.btnBuscarFut.Name = "btnBuscarFut";
            this.btnBuscarFut.Size = new System.Drawing.Size(157, 40);
            this.btnBuscarFut.TabIndex = 2;
            this.btnBuscarFut.Text = "Buscar";
            this.btnBuscarFut.UseVisualStyleBackColor = false;
            // 
            // dgvReparacionesFuturas
            // 
            this.dgvReparacionesFuturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReparacionesFuturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReparacionesFuturas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvReparacionesFuturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReparacionesFuturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReparacionesFuturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReparacionesFuturas.ColumnHeadersHeight = 30;
            this.dgvReparacionesFuturas.EnableHeadersVisualStyles = false;
            this.dgvReparacionesFuturas.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgvReparacionesFuturas.Location = new System.Drawing.Point(23, 93);
            this.dgvReparacionesFuturas.Name = "dgvReparacionesFuturas";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReparacionesFuturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReparacionesFuturas.RowHeadersVisible = false;
            this.dgvReparacionesFuturas.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReparacionesFuturas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReparacionesFuturas.RowTemplate.Height = 24;
            this.dgvReparacionesFuturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReparacionesFuturas.Size = new System.Drawing.Size(781, 161);
            this.dgvReparacionesFuturas.TabIndex = 0;
            // 
            // frmTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1580, 815);
            this.Controls.Add(this.gbMantFut);
            this.Controls.Add(this.gbDatosMant);
            this.Controls.Add(this.gbGrillaMant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTaller";
            this.Text = "frmTaller";
            this.gbDatosMant.ResumeLayout(false);
            this.gbDatosMant.PerformLayout();
            this.gbProximo.ResumeLayout(false);
            this.gbProximo.PerformLayout();
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            this.gbGrillaMant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparaciones)).EndInit();
            this.gbMantFut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparacionesFuturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosMant;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox gbGrillaMant;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ComboBox cmbAeronaves;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvReparaciones;
        private System.Windows.Forms.GroupBox gbMantFut;
        private System.Windows.Forms.Button refreshFut;
        private System.Windows.Forms.ComboBox cmbAvionesFut;
        private System.Windows.Forms.Button btnBuscarFut;
        private System.Windows.Forms.DataGridView dgvReparacionesFuturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAvionDatos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDetallesTrabajo;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.RadioButton rbFinalizado;
        private System.Windows.Forms.RadioButton rbProceso;
        private System.Windows.Forms.RadioButton rbPendiente;
        private System.Windows.Forms.TextBox txtTaqFuturo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbProximo;
    }
}

namespace Interfaz_GUI
{
    partial class Bitacora
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
            this.LblElegirFiltro = new System.Windows.Forms.Label();
            this.groupBoxUsuario = new System.Windows.Forms.GroupBox();
            this.comboBoxUsuario = new System.Windows.Forms.ComboBox();
            this.groupBoxRangodefecha = new System.Windows.Forms.GroupBox();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.LblHasta = new System.Windows.Forms.Label();
            this.LblDesde = new System.Windows.Forms.Label();
            this.groupBoxCriticidad = new System.Windows.Forms.GroupBox();
            this.radioButtonBaja = new System.Windows.Forms.RadioButton();
            this.radioButtonMedia = new System.Windows.Forms.RadioButton();
            this.radioButtonAlta = new System.Windows.Forms.RadioButton();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.BtnCancelarfiltro = new System.Windows.Forms.Button();
            this.dataGridViewBitacora = new System.Windows.Forms.DataGridView();
            this.groupBoxUsuario.SuspendLayout();
            this.groupBoxRangodefecha.SuspendLayout();
            this.groupBoxCriticidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // LblElegirFiltro
            // 
            this.LblElegirFiltro.AutoSize = true;
            this.LblElegirFiltro.Location = new System.Drawing.Point(18, 38);
            this.LblElegirFiltro.Name = "LblElegirFiltro";
            this.LblElegirFiltro.Size = new System.Drawing.Size(75, 17);
            this.LblElegirFiltro.TabIndex = 0;
            this.LblElegirFiltro.Tag = "Elegir filtro";
            this.LblElegirFiltro.Text = "Elegir filtro";
            // 
            // groupBoxUsuario
            // 
            this.groupBoxUsuario.Controls.Add(this.comboBoxUsuario);
            this.groupBoxUsuario.Location = new System.Drawing.Point(12, 88);
            this.groupBoxUsuario.Name = "groupBoxUsuario";
            this.groupBoxUsuario.Size = new System.Drawing.Size(322, 119);
            this.groupBoxUsuario.TabIndex = 2;
            this.groupBoxUsuario.TabStop = false;
            this.groupBoxUsuario.Tag = "Usuario";
            this.groupBoxUsuario.Text = "Usuario";
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(20, 53);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(230, 24);
            this.comboBoxUsuario.TabIndex = 4;
            this.comboBoxUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsuario_SelectedIndexChanged);
            // 
            // groupBoxRangodefecha
            // 
            this.groupBoxRangodefecha.Controls.Add(this.dateTimePickerHasta);
            this.groupBoxRangodefecha.Controls.Add(this.dateTimePickerDesde);
            this.groupBoxRangodefecha.Controls.Add(this.LblHasta);
            this.groupBoxRangodefecha.Controls.Add(this.LblDesde);
            this.groupBoxRangodefecha.Enabled = false;
            this.groupBoxRangodefecha.Location = new System.Drawing.Point(12, 422);
            this.groupBoxRangodefecha.Name = "groupBoxRangodefecha";
            this.groupBoxRangodefecha.Size = new System.Drawing.Size(322, 178);
            this.groupBoxRangodefecha.TabIndex = 3;
            this.groupBoxRangodefecha.TabStop = false;
            this.groupBoxRangodefecha.Tag = "Rango de Fecha";
            this.groupBoxRangodefecha.Text = "Rango de Fecha";
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Location = new System.Drawing.Point(79, 119);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerHasta.TabIndex = 3;
            this.dateTimePickerHasta.ValueChanged += new System.EventHandler(this.dateTimePickerHasta_ValueChanged);
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Location = new System.Drawing.Point(79, 55);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDesde.TabIndex = 2;
            // 
            // LblHasta
            // 
            this.LblHasta.AutoSize = true;
            this.LblHasta.Location = new System.Drawing.Point(6, 124);
            this.LblHasta.Name = "LblHasta";
            this.LblHasta.Size = new System.Drawing.Size(45, 17);
            this.LblHasta.TabIndex = 1;
            this.LblHasta.Tag = "Hasta";
            this.LblHasta.Text = "Hasta";
            // 
            // LblDesde
            // 
            this.LblDesde.AutoSize = true;
            this.LblDesde.Location = new System.Drawing.Point(6, 60);
            this.LblDesde.Name = "LblDesde";
            this.LblDesde.Size = new System.Drawing.Size(49, 17);
            this.LblDesde.TabIndex = 0;
            this.LblDesde.Tag = "Desde";
            this.LblDesde.Text = "Desde";
            // 
            // groupBoxCriticidad
            // 
            this.groupBoxCriticidad.Controls.Add(this.radioButtonBaja);
            this.groupBoxCriticidad.Controls.Add(this.radioButtonMedia);
            this.groupBoxCriticidad.Controls.Add(this.radioButtonAlta);
            this.groupBoxCriticidad.Location = new System.Drawing.Point(12, 221);
            this.groupBoxCriticidad.Name = "groupBoxCriticidad";
            this.groupBoxCriticidad.Size = new System.Drawing.Size(322, 177);
            this.groupBoxCriticidad.TabIndex = 3;
            this.groupBoxCriticidad.TabStop = false;
            this.groupBoxCriticidad.Tag = "Criticidad";
            this.groupBoxCriticidad.Text = "Criticidad";
            // 
            // radioButtonBaja
            // 
            this.radioButtonBaja.AutoSize = true;
            this.radioButtonBaja.Location = new System.Drawing.Point(79, 128);
            this.radioButtonBaja.Name = "radioButtonBaja";
            this.radioButtonBaja.Size = new System.Drawing.Size(119, 21);
            this.radioButtonBaja.TabIndex = 2;
            this.radioButtonBaja.TabStop = true;
            this.radioButtonBaja.Tag = "Criticidad Baja";
            this.radioButtonBaja.Text = "Criticidad Baja";
            this.radioButtonBaja.UseVisualStyleBackColor = true;
            this.radioButtonBaja.Click += new System.EventHandler(this.radioButtonBaja_Click);
            // 
            // radioButtonMedia
            // 
            this.radioButtonMedia.AutoSize = true;
            this.radioButtonMedia.Location = new System.Drawing.Point(79, 88);
            this.radioButtonMedia.Name = "radioButtonMedia";
            this.radioButtonMedia.Size = new System.Drawing.Size(129, 21);
            this.radioButtonMedia.TabIndex = 1;
            this.radioButtonMedia.TabStop = true;
            this.radioButtonMedia.Tag = "Criticidad Media";
            this.radioButtonMedia.Text = "Criticidad Media";
            this.radioButtonMedia.UseVisualStyleBackColor = true;
            this.radioButtonMedia.Click += new System.EventHandler(this.radioButtonMedia_Click);
            // 
            // radioButtonAlta
            // 
            this.radioButtonAlta.AutoSize = true;
            this.radioButtonAlta.Location = new System.Drawing.Point(79, 49);
            this.radioButtonAlta.Name = "radioButtonAlta";
            this.radioButtonAlta.Size = new System.Drawing.Size(115, 21);
            this.radioButtonAlta.TabIndex = 0;
            this.radioButtonAlta.TabStop = true;
            this.radioButtonAlta.Tag = "Criticidad Alta";
            this.radioButtonAlta.Text = "Criticidad Alta";
            this.radioButtonAlta.UseVisualStyleBackColor = true;
            this.radioButtonAlta.Click += new System.EventHandler(this.radioButtonAlta_Click);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(374, 31);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(122, 31);
            this.BtnFiltrar.TabIndex = 4;
            this.BtnFiltrar.Tag = "Filtrar";
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Visible = false;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // BtnCancelarfiltro
            // 
            this.BtnCancelarfiltro.Location = new System.Drawing.Point(963, 38);
            this.BtnCancelarfiltro.Name = "BtnCancelarfiltro";
            this.BtnCancelarfiltro.Size = new System.Drawing.Size(122, 31);
            this.BtnCancelarfiltro.TabIndex = 5;
            this.BtnCancelarfiltro.Tag = "Cancelar Filtro";
            this.BtnCancelarfiltro.Text = "Cancelar Filtro";
            this.BtnCancelarfiltro.UseVisualStyleBackColor = true;
            this.BtnCancelarfiltro.Click += new System.EventHandler(this.BtnCancelarfiltro_Click);
            // 
            // dataGridViewBitacora
            // 
            this.dataGridViewBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBitacora.Location = new System.Drawing.Point(370, 88);
            this.dataGridViewBitacora.Name = "dataGridViewBitacora";
            this.dataGridViewBitacora.RowHeadersWidth = 51;
            this.dataGridViewBitacora.RowTemplate.Height = 24;
            this.dataGridViewBitacora.Size = new System.Drawing.Size(715, 513);
            this.dataGridViewBitacora.TabIndex = 6;
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 612);
            this.Controls.Add(this.dataGridViewBitacora);
            this.Controls.Add(this.BtnCancelarfiltro);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.groupBoxCriticidad);
            this.Controls.Add(this.groupBoxRangodefecha);
            this.Controls.Add(this.groupBoxUsuario);
            this.Controls.Add(this.LblElegirFiltro);
            this.Name = "Bitacora";
            this.Tag = "Bitacora";
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.Bitacora_Load);
            this.groupBoxUsuario.ResumeLayout(false);
            this.groupBoxRangodefecha.ResumeLayout(false);
            this.groupBoxRangodefecha.PerformLayout();
            this.groupBoxCriticidad.ResumeLayout(false);
            this.groupBoxCriticidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblElegirFiltro;
        private System.Windows.Forms.GroupBox groupBoxUsuario;
        private System.Windows.Forms.ComboBox comboBoxUsuario;
        private System.Windows.Forms.GroupBox groupBoxRangodefecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.Label LblHasta;
        private System.Windows.Forms.Label LblDesde;
        private System.Windows.Forms.GroupBox groupBoxCriticidad;
        private System.Windows.Forms.RadioButton radioButtonBaja;
        private System.Windows.Forms.RadioButton radioButtonMedia;
        private System.Windows.Forms.RadioButton radioButtonAlta;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Button BtnCancelarfiltro;
        private System.Windows.Forms.DataGridView dataGridViewBitacora;
    }
}
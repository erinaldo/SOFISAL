namespace CapaPresentacion.Consultas
{
    partial class Consulta_Stock_Articulos
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
            this.components = new System.ComponentModel.Container();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_imprimir = new Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo();
            this.data_Listado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lb_total = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.error_icono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tt_mensaje = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Listado)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_icono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.tabPage1.Controls.Add(this.btn_imprimir);
            this.tabPage1.Controls.Add(this.data_Listado);
            this.tabPage1.Controls.Add(this.lb_total);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1066, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BorderColor = System.Drawing.Color.Transparent;
            this.btn_imprimir.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.btn_imprimir.FlatAppearance.BorderSize = 0;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Location = new System.Drawing.Point(925, 17);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_imprimir.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.btn_imprimir.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_imprimir.Size = new System.Drawing.Size(98, 40);
            this.btn_imprimir.TabIndex = 0;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.TextColor = System.Drawing.Color.White;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.boton_Redondo2_Click);
            // 
            // data_Listado
            // 
            this.data_Listado.AllowUserToAddRows = false;
            this.data_Listado.AllowUserToDeleteRows = false;
            this.data_Listado.AllowUserToOrderColumns = true;
            this.data_Listado.BackgroundColor = System.Drawing.Color.White;
            this.data_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.data_Listado.Location = new System.Drawing.Point(24, 74);
            this.data_Listado.Margin = new System.Windows.Forms.Padding(2);
            this.data_Listado.MultiSelect = false;
            this.data_Listado.Name = "data_Listado";
            this.data_Listado.ReadOnly = true;
            this.data_Listado.RowTemplate.Height = 28;
            this.data_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Listado.Size = new System.Drawing.Size(1019, 388);
            this.data_Listado.TabIndex = 1;
            this.data_Listado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Listado_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.lb_total.ForeColor = System.Drawing.Color.White;
            this.lb_total.Location = new System.Drawing.Point(720, 41);
            this.lb_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(57, 16);
            this.lb_total.TabIndex = 6;
            this.lb_total.Text = "Nombre:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(23, 61);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1074, 514);
            this.tabControl1.TabIndex = 9;
            // 
            // error_icono
            // 
            this.error_icono.ContainerControl = this;
            // 
            // tt_mensaje
            // 
            this.tt_mensaje.IsBalloon = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.data_warehouse__1_;
            this.pictureBox1.Location = new System.Drawing.Point(269, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "Stock de Articulos";
            // 
            // Consulta_Stock_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1122, 597);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Consulta_Stock_Articulos";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Consulta_Stock_Articulos_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Listado)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error_icono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView data_Listado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ErrorProvider error_icono;
        private System.Windows.Forms.ToolTip tt_mensaje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo btn_imprimir;
    }
}
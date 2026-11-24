namespace CafeteriaUniversitaria
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpDetalles = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.grpCatalogo = new System.Windows.Forms.GroupBox();
            this.lvCatalogo = new System.Windows.Forms.ListView();
            this.grpOpciones = new System.Windows.Forms.GroupBox();
            this.chkServilletas = new System.Windows.Forms.CheckBox();
            this.chkPostre = new System.Windows.Forms.CheckBox();
            this.rbtnEntrega = new System.Windows.Forms.RadioButton();
            this.rbtnMostrador = new System.Windows.Forms.RadioButton();
            this.grpPedido = new System.Windows.Forms.GroupBox();
            this.lvPedido = new System.Windows.Forms.ListView();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpDetalles.SuspendLayout();
            this.grpCatalogo.SuspendLayout();
            this.grpOpciones.SuspendLayout();
            this.grpPedido.SuspendLayout();
            this.SuspendLayout();
 
            this.grpDetalles.Controls.Add(this.btnAgregar);
            this.grpDetalles.Controls.Add(this.txtCantidad);
            this.grpDetalles.Controls.Add(this.lblCantidad);
            this.grpDetalles.Controls.Add(this.txtProducto);
            this.grpDetalles.Controls.Add(this.lblProducto);
            this.grpDetalles.Controls.Add(this.txtCliente);
            this.grpDetalles.Controls.Add(this.lblCliente);
            this.grpDetalles.Location = new System.Drawing.Point(13, 12);
            this.grpDetalles.Name = "grpDetalles";
            this.grpDetalles.Size = new System.Drawing.Size(838, 76);
            this.grpDetalles.TabIndex = 0;
            this.grpDetalles.TabStop = false;
            this.grpDetalles.Text = "Detalles del Pedido";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.Location = new System.Drawing.Point(662, 35);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(145, 27);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar Ítem";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(557, 39);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(74, 20);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.Validating += new System.ComponentModel.CancelEventHandler(this.txtCantidad_Validating);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(557, 22);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(279, 39);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(258, 20);
            this.txtProducto.TabIndex = 3;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(279, 22);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(15, 39);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(244, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(15, 22);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // grpCatalogo
            // 
            this.grpCatalogo.Controls.Add(this.lvCatalogo);
            this.grpCatalogo.Location = new System.Drawing.Point(13, 98);
            this.grpCatalogo.Name = "grpCatalogo";
            this.grpCatalogo.Size = new System.Drawing.Size(292, 275);
            this.grpCatalogo.TabIndex = 1;
            this.grpCatalogo.TabStop = false;
            this.grpCatalogo.Text = "Catálogo de Productos";
            // 
            // lvCatalogo
            // 
            this.lvCatalogo.FullRowSelect = true;
            this.lvCatalogo.GridLines = true;
            this.lvCatalogo.HideSelection = false;
            this.lvCatalogo.Location = new System.Drawing.Point(11, 21);
            this.lvCatalogo.MultiSelect = false;
            this.lvCatalogo.Name = "lvCatalogo";
            this.lvCatalogo.Size = new System.Drawing.Size(268, 240);
            this.lvCatalogo.TabIndex = 0;
            this.lvCatalogo.UseCompatibleStateImageBehavior = false;
            this.lvCatalogo.View = System.Windows.Forms.View.Details;
            this.lvCatalogo.SelectedIndexChanged += new System.EventHandler(this.lvCatalogo_SelectedIndexChanged);
            // 
            // grpOpciones
            // 
            this.grpOpciones.Controls.Add(this.chkServilletas);
            this.grpOpciones.Controls.Add(this.chkPostre);
            this.grpOpciones.Controls.Add(this.rbtnEntrega);
            this.grpOpciones.Controls.Add(this.rbtnMostrador);
            this.grpOpciones.Location = new System.Drawing.Point(318, 98);
            this.grpOpciones.Name = "grpOpciones";
            this.grpOpciones.Size = new System.Drawing.Size(212, 275);
            this.grpOpciones.TabIndex = 2;
            this.grpOpciones.TabStop = false;
            this.grpOpciones.Text = "Opciones y Extras";
            // 
            // chkServilletas
            // 
            this.chkServilletas.AutoSize = true;
            this.chkServilletas.Location = new System.Drawing.Point(15, 142);
            this.chkServilletas.Name = "chkServilletas";
            this.chkServilletas.Size = new System.Drawing.Size(129, 17);
            this.chkServilletas.TabIndex = 3;
            this.chkServilletas.Text = "Servilletas / Cubiertos";
            this.chkServilletas.UseVisualStyleBackColor = true;
            this.chkServilletas.CheckedChanged += new System.EventHandler(this.chkServilletas_CheckedChanged);
            // 
            // chkPostre
            // 
            this.chkPostre.AutoSize = true;
            this.chkPostre.Location = new System.Drawing.Point(15, 114);
            this.chkPostre.Name = "chkPostre";
            this.chkPostre.Size = new System.Drawing.Size(134, 17);
            this.chkPostre.TabIndex = 2;
            this.chkPostre.Text = "Postre del día (+$1.00)";
            this.chkPostre.UseVisualStyleBackColor = true;
            this.chkPostre.CheckedChanged += new System.EventHandler(this.chkPostre_CheckedChanged);
            // 
            // rbtnEntrega
            // 
            this.rbtnEntrega.AutoSize = true;
            this.rbtnEntrega.Location = new System.Drawing.Point(15, 58);
            this.rbtnEntrega.Name = "rbtnEntrega";
            this.rbtnEntrega.Size = new System.Drawing.Size(142, 17);
            this.rbtnEntrega.TabIndex = 1;
            this.rbtnEntrega.Text = "Entrega en aula (+$0.50)";
            this.rbtnEntrega.UseVisualStyleBackColor = true;
            this.rbtnEntrega.CheckedChanged += new System.EventHandler(this.rbtnEntrega_CheckedChanged);
            // 
            // rbtnMostrador
            // 
            this.rbtnMostrador.AutoSize = true;
            this.rbtnMostrador.Checked = true;
            this.rbtnMostrador.Location = new System.Drawing.Point(15, 30);
            this.rbtnMostrador.Name = "rbtnMostrador";
            this.rbtnMostrador.Size = new System.Drawing.Size(117, 17);
            this.rbtnMostrador.TabIndex = 0;
            this.rbtnMostrador.TabStop = true;
            this.rbtnMostrador.Text = "Retiro en mostrador";
            this.rbtnMostrador.UseVisualStyleBackColor = true;
            this.rbtnMostrador.CheckedChanged += new System.EventHandler(this.rbtnMostrador_CheckedChanged);
            // 
            // grpPedido
            // 
            this.grpPedido.Controls.Add(this.lvPedido);
            this.grpPedido.Location = new System.Drawing.Point(544, 98);
            this.grpPedido.Name = "grpPedido";
            this.grpPedido.Size = new System.Drawing.Size(307, 275);
            this.grpPedido.TabIndex = 3;
            this.grpPedido.TabStop = false;
            this.grpPedido.Text = "Pedido Actual";
            // 
            // lvPedido
            // 
            this.lvPedido.FullRowSelect = true;
            this.lvPedido.GridLines = true;
            this.lvPedido.HideSelection = false;
            this.lvPedido.Location = new System.Drawing.Point(11, 21);
            this.lvPedido.MultiSelect = false;
            this.lvPedido.Name = "lvPedido";
            this.lvPedido.Size = new System.Drawing.Size(283, 240);
            this.lvPedido.TabIndex = 0;
            this.lvPedido.UseCompatibleStateImageBehavior = false;
            this.lvPedido.View = System.Windows.Forms.View.Details;
            this.lvPedido.SelectedIndexChanged += new System.EventHandler(this.lvPedido_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(15, 396);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(162, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado: Seleccione un producto.";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(650, 386);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(198, 22);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total: $0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Enabled = false;
            this.btnQuitar.ForeColor = System.Drawing.Color.IndianRed;
            this.btnQuitar.Location = new System.Drawing.Point(556, 419);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(144, 28);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.Text = "Quitar Seleccionado";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLimpiar.Location = new System.Drawing.Point(710, 419);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(138, 28);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar Pedido";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 461);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.grpPedido);
            this.Controls.Add(this.grpOpciones);
            this.Controls.Add(this.grpCatalogo);
            this.Controls.Add(this.grpDetalles);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor Rápido de Pedidos - Cafetería Universitaria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDetalles.ResumeLayout(false);
            this.grpDetalles.PerformLayout();
            this.grpCatalogo.ResumeLayout(false);
            this.grpOpciones.ResumeLayout(false);
            this.grpOpciones.PerformLayout();
            this.grpPedido.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDetalles;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grpCatalogo;
        private System.Windows.Forms.ListView lvCatalogo;
        private System.Windows.Forms.GroupBox grpOpciones;
        private System.Windows.Forms.RadioButton rbtnMostrador;
        private System.Windows.Forms.RadioButton rbtnEntrega;
        private System.Windows.Forms.CheckBox chkPostre;
        private System.Windows.Forms.CheckBox chkServilletas;
        private System.Windows.Forms.GroupBox grpPedido;
        private System.Windows.Forms.ListView lvPedido;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}
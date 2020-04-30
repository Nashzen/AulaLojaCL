namespace LojaCL
{
    partial class FrmPedidos
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
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEcluirItem = new System.Windows.Forms.Button();
            this.btnEditarItem = new System.Windows.Forms.Button();
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbxCartao = new System.Windows.Forms.ComboBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblIDProduto = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(682, 512);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(157, 27);
            this.btnFinalizar.TabIndex = 34;
            this.btnFinalizar.Text = "Finalizar Pedido";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(743, 547);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(96, 27);
            this.btnSair.TabIndex = 33;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEcluirItem
            // 
            this.btnEcluirItem.Location = new System.Drawing.Point(710, 162);
            this.btnEcluirItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnEcluirItem.Name = "btnEcluirItem";
            this.btnEcluirItem.Size = new System.Drawing.Size(129, 25);
            this.btnEcluirItem.TabIndex = 32;
            this.btnEcluirItem.Text = "Excluir Item";
            this.btnEcluirItem.UseVisualStyleBackColor = true;
            this.btnEcluirItem.Click += new System.EventHandler(this.btnEcluirItem_Click);
            // 
            // btnEditarItem
            // 
            this.btnEditarItem.Location = new System.Drawing.Point(576, 160);
            this.btnEditarItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarItem.Name = "btnEditarItem";
            this.btnEditarItem.Size = new System.Drawing.Size(126, 27);
            this.btnEditarItem.TabIndex = 31;
            this.btnEditarItem.Text = "Editar Item";
            this.btnEditarItem.UseVisualStyleBackColor = true;
            this.btnEditarItem.Click += new System.EventHandler(this.btnEditarItem_Click);
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.Location = new System.Drawing.Point(439, 162);
            this.btnNovoItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(129, 25);
            this.btnNovoItem.TabIndex = 30;
            this.btnNovoItem.Text = "Novo Item";
            this.btnNovoItem.UseVisualStyleBackColor = true;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(628, 447);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(211, 22);
            this.txtValorTotal.TabIndex = 29;
            this.txtValorTotal.TextChanged += new System.EventHandler(this.txtValorTotal_TextChanged);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(149, 117);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(114, 22);
            this.txtQuantidade.TabIndex = 28;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // cbxProduto
            // 
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(149, 85);
            this.cbxProduto.Margin = new System.Windows.Forms.Padding(4);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(368, 24);
            this.cbxProduto.TabIndex = 27;
            this.cbxProduto.SelectedIndexChanged += new System.EventHandler(this.cbxProduto_SelectedIndexChanged);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(532, 452);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(88, 17);
            this.lblValorTotal.TabIndex = 26;
            this.lblValorTotal.Text = "Valor Total";
            this.lblValorTotal.Click += new System.EventHandler(this.lblValorTotal_Click);
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Location = new System.Drawing.Point(47, 150);
            this.lblValorUnitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(94, 17);
            this.lblValorUnitario.TabIndex = 25;
            this.lblValorUnitario.Text = "Valor Unitario";
            this.lblValorUnitario.Click += new System.EventHandler(this.lblValor_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(84, 55);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 17);
            this.lblUsuario.TabIndex = 24;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Click += new System.EventHandler(this.lblQuantidade_Click);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(84, 88);
            this.lblProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(58, 17);
            this.lblProduto.TabIndex = 23;
            this.lblProduto.Text = "Produto";
            this.lblProduto.Click += new System.EventHandler(this.lblProduto_Click);
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(50, 195);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.RowHeadersWidth = 51;
            this.dgvPedido.Size = new System.Drawing.Size(789, 244);
            this.dgvPedido.TabIndex = 22;
            this.dgvPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellClick);
            this.dgvPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenda_CellContentClick);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(149, 55);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(368, 22);
            this.txtUsuario.TabIndex = 21;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(91, 26);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(50, 17);
            this.lblCliente.TabIndex = 20;
            this.lblCliente.Text = "Cartão";
            this.lblCliente.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // cbxCartao
            // 
            this.cbxCartao.FormattingEnabled = true;
            this.cbxCartao.Location = new System.Drawing.Point(149, 23);
            this.cbxCartao.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCartao.Name = "cbxCartao";
            this.cbxCartao.Size = new System.Drawing.Size(368, 24);
            this.cbxCartao.TabIndex = 19;
            this.cbxCartao.SelectedIndexChanged += new System.EventHandler(this.cbxCliente_SelectedIndexChanged);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.Location = new System.Drawing.Point(710, 18);
            this.btnLocalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(119, 29);
            this.btnLocalizar.TabIndex = 18;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(60, 117);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(82, 17);
            this.lblQuantidade.TabIndex = 35;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblIDProduto
            // 
            this.lblIDProduto.AutoSize = true;
            this.lblIDProduto.Location = new System.Drawing.Point(285, 120);
            this.lblIDProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDProduto.Name = "lblIDProduto";
            this.lblIDProduto.Size = new System.Drawing.Size(21, 17);
            this.lblIDProduto.TabIndex = 36;
            this.lblIDProduto.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(314, 117);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(114, 22);
            this.txtID.TabIndex = 37;
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(149, 147);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(114, 22);
            this.txtValor.TabIndex = 38;
            // 
            // btnPedido
            // 
            this.btnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.Location = new System.Drawing.Point(575, 18);
            this.btnPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(119, 29);
            this.btnPedido.TabIndex = 39;
            this.btnPedido.Text = "Abrir Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(682, 477);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(157, 27);
            this.btnAtualizar.TabIndex = 40;
            this.btnAtualizar.Text = "Atualizar Pedido";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 576);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblIDProduto);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEcluirItem);
            this.Controls.Add(this.btnEditarItem);
            this.Controls.Add(this.btnNovoItem);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.cbxProduto);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblValorUnitario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cbxCartao);
            this.Controls.Add(this.btnLocalizar);
            this.Name = "FrmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEcluirItem;
        private System.Windows.Forms.Button btnEditarItem;
        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbxCartao;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblIDProduto;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnAtualizar;
    }
}
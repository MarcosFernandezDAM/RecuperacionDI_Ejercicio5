namespace ejercicio5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnAnhadir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnTraspasar1 = new System.Windows.Forms.Button();
            this.btnTraspasar2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.lblSecundario = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.traspasar1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lista2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traspasar2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(48, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.listBox1, "Lista Principal");
            this.listBox1.Click += new System.EventHandler(this.ListBox1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(418, 72);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 1;
            // 
            // btnAnhadir
            // 
            this.btnAnhadir.Location = new System.Drawing.Point(60, 310);
            this.btnAnhadir.Name = "btnAnhadir";
            this.btnAnhadir.Size = new System.Drawing.Size(75, 23);
            this.btnAnhadir.TabIndex = 3;
            this.btnAnhadir.Text = "Añadir";
            this.toolTip1.SetToolTip(this.btnAnhadir, "Botón Añadir");
            this.btnAnhadir.UseVisualStyleBackColor = true;
            this.btnAnhadir.Click += new System.EventHandler(this.BtnAnhadir_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(191, 310);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.TabStop = false;
            this.btnQuitar.Text = "Quitar";
            this.toolTip1.SetToolTip(this.btnQuitar, "Botón Quitar");
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // btnTraspasar1
            // 
            this.btnTraspasar1.Location = new System.Drawing.Point(319, 310);
            this.btnTraspasar1.Name = "btnTraspasar1";
            this.btnTraspasar1.Size = new System.Drawing.Size(75, 23);
            this.btnTraspasar1.TabIndex = 4;
            this.btnTraspasar1.Text = "Traspasar 1";
            this.toolTip1.SetToolTip(this.btnTraspasar1, "Botón Traspasar 1");
            this.btnTraspasar1.UseVisualStyleBackColor = true;
            this.btnTraspasar1.Click += new System.EventHandler(this.BtnTraspasar1_Click);
            // 
            // btnTraspasar2
            // 
            this.btnTraspasar2.Location = new System.Drawing.Point(449, 310);
            this.btnTraspasar2.Name = "btnTraspasar2";
            this.btnTraspasar2.Size = new System.Drawing.Size(75, 23);
            this.btnTraspasar2.TabIndex = 5;
            this.btnTraspasar2.Text = "Traspasar 2";
            this.toolTip1.SetToolTip(this.btnTraspasar2, "Botón traspasar 2");
            this.btnTraspasar2.UseVisualStyleBackColor = true;
            this.btnTraspasar2.Click += new System.EventHandler(this.BtnTraspasar2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBox1, "TextBox");
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Location = new System.Drawing.Point(60, 53);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(35, 13);
            this.lblPrincipal.TabIndex = 7;
            this.lblPrincipal.Text = "label1";
            // 
            // lblSecundario
            // 
            this.lblSecundario.AutoSize = true;
            this.lblSecundario.Location = new System.Drawing.Point(188, 106);
            this.lblSecundario.Name = "lblSecundario";
            this.lblSecundario.Size = new System.Drawing.Size(35, 13);
            this.lblSecundario.TabIndex = 8;
            this.lblSecundario.Text = "label2";
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowItemReorder = true;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.lista2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem1,
            this.quitarToolStripMenuItem1,
            this.traspasar1ToolStripMenuItem1});
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+1";
            this.añadirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.añadirToolStripMenuItem.Text = "Lista&1";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.BtnAnhadir_Click);
            // 
            // añadirToolStripMenuItem1
            // 
            this.añadirToolStripMenuItem1.Name = "añadirToolStripMenuItem1";
            this.añadirToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.añadirToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.añadirToolStripMenuItem1.Text = "&Añadir";
            this.añadirToolStripMenuItem1.Click += new System.EventHandler(this.BtnAnhadir_Click);
            // 
            // quitarToolStripMenuItem1
            // 
            this.quitarToolStripMenuItem1.Name = "quitarToolStripMenuItem1";
            this.quitarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.quitarToolStripMenuItem1.Tag = "";
            this.quitarToolStripMenuItem1.Text = "&Quitar";
            this.quitarToolStripMenuItem1.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // traspasar1ToolStripMenuItem1
            // 
            this.traspasar1ToolStripMenuItem1.Name = "traspasar1ToolStripMenuItem1";
            this.traspasar1ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.traspasar1ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.traspasar1ToolStripMenuItem1.Text = "&Traspasar1";
            this.traspasar1ToolStripMenuItem1.Click += new System.EventHandler(this.BtnTraspasar1_Click);
            // 
            // lista2ToolStripMenuItem
            // 
            this.lista2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traspasar2ToolStripMenuItem1});
            this.lista2ToolStripMenuItem.Name = "lista2ToolStripMenuItem";
            this.lista2ToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.lista2ToolStripMenuItem.Text = "Lista&2";
            // 
            // traspasar2ToolStripMenuItem1
            // 
            this.traspasar2ToolStripMenuItem1.Name = "traspasar2ToolStripMenuItem1";
            this.traspasar2ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.traspasar2ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.traspasar2ToolStripMenuItem1.Text = "T&raspasar2";
            this.traspasar2ToolStripMenuItem1.Click += new System.EventHandler(this.BtnTraspasar2_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAnhadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSecundario);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTraspasar2);
            this.Controls.Add(this.btnTraspasar1);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAnhadir);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ejercicio5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnAnhadir;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnTraspasar1;
        private System.Windows.Forms.Button btnTraspasar2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lblSecundario;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem traspasar1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lista2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traspasar2ToolStripMenuItem1;
    }
}


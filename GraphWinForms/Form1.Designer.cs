namespace GraphWinForms
{
    partial class Form1
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
            this.tbCiag = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajWęzełToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńWęzełToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picTree = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPrufer = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTree)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCiag
            // 
            this.tbCiag.Location = new System.Drawing.Point(45, 24);
            this.tbCiag.Name = "tbCiag";
            this.tbCiag.Size = new System.Drawing.Size(420, 20);
            this.tbCiag.TabIndex = 0;
            this.tbCiag.Text = "Wpisz ciąg Prufera, oddzielając etykiety przecinkami";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajWęzełToolStripMenuItem,
            this.usuńWęzełToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 48);
            // 
            // dodajWęzełToolStripMenuItem
            // 
            this.dodajWęzełToolStripMenuItem.Name = "dodajWęzełToolStripMenuItem";
            this.dodajWęzełToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.dodajWęzełToolStripMenuItem.Text = "Dodaj węzeł";
            this.dodajWęzełToolStripMenuItem.Click += new System.EventHandler(this.dodajWęzełToolStripMenuItem_Click);
            // 
            // usuńWęzełToolStripMenuItem
            // 
            this.usuńWęzełToolStripMenuItem.Name = "usuńWęzełToolStripMenuItem";
            this.usuńWęzełToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.usuńWęzełToolStripMenuItem.Text = "Usuń węzeł";
            this.usuńWęzełToolStripMenuItem.Click += new System.EventHandler(this.usuńWęzełToolStripMenuItem_Click);
            // 
            // picTree
            // 
            this.picTree.Location = new System.Drawing.Point(45, 69);
            this.picTree.Name = "picTree";
            this.picTree.Size = new System.Drawing.Size(522, 309);
            this.picTree.TabIndex = 2;
            this.picTree.TabStop = false;
            this.picTree.Paint += new System.Windows.Forms.PaintEventHandler(this.picTree_Paint);
            this.picTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picTree_MouseDown);
            this.picTree.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picTree_MouseMove);
            this.picTree.Resize += new System.EventHandler(this.picTree_Resize);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Narysuj drzewo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ciąg Prufera:";
            // 
            // lbPrufer
            // 
            this.lbPrufer.AutoSize = true;
            this.lbPrufer.Location = new System.Drawing.Point(120, 397);
            this.lbPrufer.Name = "lbPrufer";
            this.lbPrufer.Size = new System.Drawing.Size(0, 13);
            this.lbPrufer.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Stwórz Ciąg";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(510, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 33);
            this.button3.TabIndex = 7;
            this.button3.Text = "Czyść";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 443);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbPrufer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picTree);
            this.Controls.Add(this.tbCiag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCiag;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajWęzełToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńWęzełToolStripMenuItem;
        private System.Windows.Forms.PictureBox picTree;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPrufer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}


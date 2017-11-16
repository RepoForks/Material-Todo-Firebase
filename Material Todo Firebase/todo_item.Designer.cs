namespace Material_Todo_Firebase
{
    partial class todo_item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(todo_item));
            this.check = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnDel = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnDel)).BeginInit();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.check.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.check.Checked = true;
            this.check.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check.ForeColor = System.Drawing.Color.White;
            this.check.Location = new System.Drawing.Point(25, 13);
            this.check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(20, 20);
            this.check.TabIndex = 0;
            this.check.OnChange += new System.EventHandler(this.check_OnChange);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(52, 13);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(90, 19);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "todo item";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageActive = null;
            this.btnDel.Location = new System.Drawing.Point(343, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(37, 36);
            this.btnDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDel.TabIndex = 2;
            this.btnDel.TabStop = false;
            this.btnDel.Zoom = 10;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // todo_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.check);
            this.Name = "todo_item";
            this.Size = new System.Drawing.Size(395, 44);
            this.Load += new System.EventHandler(this.todo_item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCheckbox check;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl;
        private Bunifu.Framework.UI.BunifuImageButton btnDel;
    }
}

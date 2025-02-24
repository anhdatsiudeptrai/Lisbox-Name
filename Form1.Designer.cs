namespace Lisbox_Name
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
            this.lstname = new System.Windows.Forms.ListBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstname
            // 
            this.lstname.FormattingEnabled = true;
            this.lstname.ItemHeight = 16;
            this.lstname.Location = new System.Drawing.Point(70, 190);
            this.lstname.Name = "lstname";
            this.lstname.Size = new System.Drawing.Size(120, 148);
            this.lstname.TabIndex = 0;
            this.lstname.SelectedIndexChanged += new System.EventHandler(this.lstname_SelectedIndexChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(70, 136);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(120, 23);
            this.txtname.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(253, 190);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(93, 23);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(253, 239);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(93, 23);
            this.btnedit.TabIndex = 2;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(253, 282);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(93, 23);
            this.btnremove.TabIndex = 2;
            this.btnremove.Text = "REMOVE";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(253, 328);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(93, 23);
            this.btninsert.TabIndex = 2;
            this.btninsert.Text = "INSERT";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(237, 367);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(120, 23);
            this.txtIndex.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lstname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtIndex;
    }
}


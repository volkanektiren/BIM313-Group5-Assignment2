
namespace Plotter
{
    partial class MainForm
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
            this.redirect = new System.Windows.Forms.Button();
            this.shapeMenu = new System.Windows.Forms.ComboBox();
            this.textboxEdge1 = new System.Windows.Forms.TextBox();
            this.labelEdge1 = new System.Windows.Forms.Label();
            this.labelEdge2 = new System.Windows.Forms.Label();
            this.textboxEdge2 = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.textboxRadius = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // redirect
            // 
            this.redirect.Location = new System.Drawing.Point(78, 105);
            this.redirect.Name = "redirect";
            this.redirect.Size = new System.Drawing.Size(121, 23);
            this.redirect.TabIndex = 0;
            this.redirect.Text = "REDIRECT";
            this.redirect.UseVisualStyleBackColor = true;
            this.redirect.Click += new System.EventHandler(this.redirect_Click);
            // 
            // shapeMenu
            // 
            this.shapeMenu.FormattingEnabled = true;
            this.shapeMenu.Items.AddRange(new object[] {
            "Select",
            "Circle",
            "Rectangle"});
            this.shapeMenu.Location = new System.Drawing.Point(78, 38);
            this.shapeMenu.Name = "shapeMenu";
            this.shapeMenu.Size = new System.Drawing.Size(121, 24);
            this.shapeMenu.TabIndex = 1;
            this.shapeMenu.TabStop = false;
            this.shapeMenu.SelectedIndexChanged += new System.EventHandler(this.shapeMenu_SelectedIndexChanged);
            this.shapeMenu.Text = "Select";
            // 
            // textboxEdge1
            // 
            this.textboxEdge1.Location = new System.Drawing.Point(117, 176);
            this.textboxEdge1.Name = "textboxEdge1";
            this.textboxEdge1.Size = new System.Drawing.Size(100, 22);
            this.textboxEdge1.TabIndex = 2;
            this.textboxEdge1.Visible = false;
            // 
            // labelEdge1
            // 
            this.labelEdge1.AutoSize = true;
            this.labelEdge1.Location = new System.Drawing.Point(61, 180);
            this.labelEdge1.Name = "labelEdge1";
            this.labelEdge1.Size = new System.Drawing.Size(49, 17);
            this.labelEdge1.TabIndex = 3;
            this.labelEdge1.Text = "Edge1";
            this.labelEdge1.Visible = false;
            // 
            // labelEdge2
            // 
            this.labelEdge2.AutoSize = true;
            this.labelEdge2.Location = new System.Drawing.Point(61, 229);
            this.labelEdge2.Name = "labelEdge2";
            this.labelEdge2.Size = new System.Drawing.Size(49, 17);
            this.labelEdge2.TabIndex = 5;
            this.labelEdge2.Text = "Edge2";
            this.labelEdge2.Visible = false;
            // 
            // textboxEdge2
            // 
            this.textboxEdge2.Location = new System.Drawing.Point(117, 225);
            this.textboxEdge2.Name = "textboxEdge2";
            this.textboxEdge2.Size = new System.Drawing.Size(100, 22);
            this.textboxEdge2.TabIndex = 4;
            this.textboxEdge2.Visible = false;
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(61, 288);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(52, 17);
            this.labelR.TabIndex = 7;
            this.labelR.Text = "Radius";
            this.labelR.Visible = false;
            // 
            // textboxRadius
            // 
            this.textboxRadius.Location = new System.Drawing.Point(117, 284);
            this.textboxRadius.Name = "textboxRadius";
            this.textboxRadius.Size = new System.Drawing.Size(100, 22);
            this.textboxRadius.TabIndex = 6;
            this.textboxRadius.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 385);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.textboxRadius);
            this.Controls.Add(this.labelEdge2);
            this.Controls.Add(this.textboxEdge2);
            this.Controls.Add(this.labelEdge1);
            this.Controls.Add(this.textboxEdge1);
            this.Controls.Add(this.shapeMenu);
            this.Controls.Add(this.redirect);
            this.Name = "MainForm";
            this.Text = "MAINFORM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button redirect;
        private System.Windows.Forms.ComboBox shapeMenu;
        private System.Windows.Forms.TextBox textboxEdge1;
        private System.Windows.Forms.Label labelEdge1;
        private System.Windows.Forms.Label labelEdge2;
        private System.Windows.Forms.TextBox textboxEdge2;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.TextBox textboxRadius;
    }
}


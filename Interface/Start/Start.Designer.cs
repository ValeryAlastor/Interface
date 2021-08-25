
namespace Interface
{
    partial class Start
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
            this.btnFormAll = new System.Windows.Forms.Button();
            this.btnGenre = new System.Windows.Forms.Button();
            this.closeApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormAll
            // 
            this.btnFormAll.AllowDrop = true;
            this.btnFormAll.BackgroundImage = global::Interface.Properties.Resources._68;
            this.btnFormAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormAll.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnFormAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFormAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.btnFormAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormAll.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnFormAll.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFormAll.Location = new System.Drawing.Point(87, 44);
            this.btnFormAll.Name = "btnFormAll";
            this.btnFormAll.Size = new System.Drawing.Size(122, 42);
            this.btnFormAll.TabIndex = 0;
            this.btnFormAll.Text = "Фильмы";
            this.btnFormAll.UseVisualStyleBackColor = true;
            this.btnFormAll.Click += new System.EventHandler(this.btnFormAll_Click);
            // 
            // btnGenre
            // 
            this.btnGenre.AllowDrop = true;
            this.btnGenre.BackgroundImage = global::Interface.Properties.Resources._68;
            this.btnGenre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenre.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnGenre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.btnGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenre.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnGenre.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenre.Location = new System.Drawing.Point(59, 119);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.Size = new System.Drawing.Size(172, 42);
            this.btnGenre.TabIndex = 1;
            this.btnGenre.Text = "Прочие данные";
            this.btnGenre.UseVisualStyleBackColor = true;
            this.btnGenre.Click += new System.EventHandler(this.btnGenre_Click);
            // 
            // closeApp
            // 
            this.closeApp.AllowDrop = true;
            this.closeApp.BackgroundImage = global::Interface.Properties.Resources._68;
            this.closeApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeApp.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.closeApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.closeApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.closeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeApp.ForeColor = System.Drawing.SystemColors.InfoText;
            this.closeApp.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeApp.Location = new System.Drawing.Point(102, 207);
            this.closeApp.Name = "closeApp";
            this.closeApp.Size = new System.Drawing.Size(76, 31);
            this.closeApp.TabIndex = 2;
            this.closeApp.Text = "Выход";
            this.closeApp.UseVisualStyleBackColor = true;
            this.closeApp.Click += new System.EventHandler(this.closeApp_Click);
            // 
            // Start
            // 
            this.AcceptButton = this.btnFormAll;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 250);
            this.Controls.Add(this.closeApp);
            this.Controls.Add(this.btnGenre);
            this.Controls.Add(this.btnFormAll);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.HelpButton = true;
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormAll;
        private System.Windows.Forms.Button btnGenre;
        private System.Windows.Forms.Button closeApp;
    }
}
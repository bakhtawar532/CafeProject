namespace FinalProject
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
            this.LoginFormbutton = new System.Windows.Forms.Button();
            this.AddPersonalInfobutton = new System.Windows.Forms.Button();
            this.AddItemsbutton = new System.Windows.Forms.Button();
            this.PlaceOrderbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginFormbutton
            // 
            this.LoginFormbutton.BackColor = System.Drawing.Color.White;
            this.LoginFormbutton.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormbutton.ForeColor = System.Drawing.Color.Red;
            this.LoginFormbutton.Location = new System.Drawing.Point(289, 70);
            this.LoginFormbutton.Name = "LoginFormbutton";
            this.LoginFormbutton.Size = new System.Drawing.Size(239, 60);
            this.LoginFormbutton.TabIndex = 0;
            this.LoginFormbutton.Text = "Login Form";
            this.LoginFormbutton.UseVisualStyleBackColor = false;
            this.LoginFormbutton.Click += new System.EventHandler(this.LoginFormbutton_Click);
            // 
            // AddPersonalInfobutton
            // 
            this.AddPersonalInfobutton.BackColor = System.Drawing.Color.White;
            this.AddPersonalInfobutton.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPersonalInfobutton.ForeColor = System.Drawing.Color.Red;
            this.AddPersonalInfobutton.Location = new System.Drawing.Point(289, 176);
            this.AddPersonalInfobutton.Name = "AddPersonalInfobutton";
            this.AddPersonalInfobutton.Size = new System.Drawing.Size(239, 71);
            this.AddPersonalInfobutton.TabIndex = 1;
            this.AddPersonalInfobutton.Text = "Add Personal Information";
            this.AddPersonalInfobutton.UseVisualStyleBackColor = false;
            this.AddPersonalInfobutton.Click += new System.EventHandler(this.AddPersonalInfobutton_Click);
            // 
            // AddItemsbutton
            // 
            this.AddItemsbutton.BackColor = System.Drawing.Color.White;
            this.AddItemsbutton.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemsbutton.ForeColor = System.Drawing.Color.Red;
            this.AddItemsbutton.Location = new System.Drawing.Point(289, 270);
            this.AddItemsbutton.Name = "AddItemsbutton";
            this.AddItemsbutton.Size = new System.Drawing.Size(239, 60);
            this.AddItemsbutton.TabIndex = 2;
            this.AddItemsbutton.Text = "Add Items";
            this.AddItemsbutton.UseVisualStyleBackColor = false;
            this.AddItemsbutton.Click += new System.EventHandler(this.AddItemsbutton_Click);
            // 
            // PlaceOrderbutton
            // 
            this.PlaceOrderbutton.BackColor = System.Drawing.Color.White;
            this.PlaceOrderbutton.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceOrderbutton.ForeColor = System.Drawing.Color.Red;
            this.PlaceOrderbutton.Location = new System.Drawing.Point(300, 371);
            this.PlaceOrderbutton.Name = "PlaceOrderbutton";
            this.PlaceOrderbutton.Size = new System.Drawing.Size(239, 60);
            this.PlaceOrderbutton.TabIndex = 3;
            this.PlaceOrderbutton.Text = "Place Order";
            this.PlaceOrderbutton.UseVisualStyleBackColor = false;
            this.PlaceOrderbutton.Click += new System.EventHandler(this.PlaceOrderbutton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.drew_coffman_jUOaONoXJQk_unsplash1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 601);
            this.Controls.Add(this.PlaceOrderbutton);
            this.Controls.Add(this.AddItemsbutton);
            this.Controls.Add(this.AddPersonalInfobutton);
            this.Controls.Add(this.LoginFormbutton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoginFormbutton;
        private System.Windows.Forms.Button AddPersonalInfobutton;
        private System.Windows.Forms.Button AddItemsbutton;
        private System.Windows.Forms.Button PlaceOrderbutton;
    }
}
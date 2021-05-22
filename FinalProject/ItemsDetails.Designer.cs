namespace FinalProject
{
    partial class ItemsDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ItemNumbertextBox = new System.Windows.Forms.TextBox();
            this.ItemNametextBox = new System.Windows.Forms.TextBox();
            this.ItemPricetextBox = new System.Windows.Forms.TextBox();
            this.AddItembutton = new System.Windows.Forms.Button();
            this.RemoveItembutton = new System.Windows.Forms.Button();
            this.ItemsGV = new System.Windows.Forms.DataGridView();
            this.ExitItemsbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Items Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(427, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Item Price :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FinalProject.Properties.Resources.images__6_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(137, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 193);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ItemNumbertextBox
            // 
            this.ItemNumbertextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNumbertextBox.Location = new System.Drawing.Point(566, 66);
            this.ItemNumbertextBox.Name = "ItemNumbertextBox";
            this.ItemNumbertextBox.Size = new System.Drawing.Size(206, 25);
            this.ItemNumbertextBox.TabIndex = 5;
            // 
            // ItemNametextBox
            // 
            this.ItemNametextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNametextBox.Location = new System.Drawing.Point(566, 116);
            this.ItemNametextBox.Name = "ItemNametextBox";
            this.ItemNametextBox.Size = new System.Drawing.Size(206, 25);
            this.ItemNametextBox.TabIndex = 6;
            // 
            // ItemPricetextBox
            // 
            this.ItemPricetextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemPricetextBox.Location = new System.Drawing.Point(566, 161);
            this.ItemPricetextBox.Name = "ItemPricetextBox";
            this.ItemPricetextBox.Size = new System.Drawing.Size(206, 25);
            this.ItemPricetextBox.TabIndex = 7;
            // 
            // AddItembutton
            // 
            this.AddItembutton.BackColor = System.Drawing.Color.Black;
            this.AddItembutton.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItembutton.ForeColor = System.Drawing.Color.White;
            this.AddItembutton.Location = new System.Drawing.Point(566, 212);
            this.AddItembutton.Name = "AddItembutton";
            this.AddItembutton.Size = new System.Drawing.Size(195, 49);
            this.AddItembutton.TabIndex = 8;
            this.AddItembutton.Text = "Save";
            this.AddItembutton.UseVisualStyleBackColor = false;
            this.AddItembutton.Click += new System.EventHandler(this.AddItembutton_Click);
            // 
            // RemoveItembutton
            // 
            this.RemoveItembutton.BackColor = System.Drawing.Color.Black;
            this.RemoveItembutton.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveItembutton.ForeColor = System.Drawing.Color.White;
            this.RemoveItembutton.Location = new System.Drawing.Point(784, 212);
            this.RemoveItembutton.Name = "RemoveItembutton";
            this.RemoveItembutton.Size = new System.Drawing.Size(197, 49);
            this.RemoveItembutton.TabIndex = 9;
            this.RemoveItembutton.Text = "Reset";
            this.RemoveItembutton.UseVisualStyleBackColor = false;
            this.RemoveItembutton.Click += new System.EventHandler(this.RemoveItembutton_Click);
            // 
            // ItemsGV
            // 
            this.ItemsGV.BackgroundColor = System.Drawing.Color.White;
            this.ItemsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGV.GridColor = System.Drawing.Color.Black;
            this.ItemsGV.Location = new System.Drawing.Point(137, 281);
            this.ItemsGV.Name = "ItemsGV";
            this.ItemsGV.Size = new System.Drawing.Size(663, 95);
            this.ItemsGV.TabIndex = 10;
            // 
            // ExitItemsbutton
            // 
            this.ExitItemsbutton.BackColor = System.Drawing.Color.Red;
            this.ExitItemsbutton.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitItemsbutton.ForeColor = System.Drawing.Color.White;
            this.ExitItemsbutton.Location = new System.Drawing.Point(822, 389);
            this.ExitItemsbutton.Name = "ExitItemsbutton";
            this.ExitItemsbutton.Size = new System.Drawing.Size(157, 49);
            this.ExitItemsbutton.TabIndex = 11;
            this.ExitItemsbutton.Text = "Exit";
            this.ExitItemsbutton.UseVisualStyleBackColor = false;
            this.ExitItemsbutton.Click += new System.EventHandler(this.ExitItemsbutton_Click);
            // 
            // ItemsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.drew_coffman_jUOaONoXJQk_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 450);
            this.Controls.Add(this.ExitItemsbutton);
            this.Controls.Add(this.ItemsGV);
            this.Controls.Add(this.RemoveItembutton);
            this.Controls.Add(this.AddItembutton);
            this.Controls.Add(this.ItemPricetextBox);
            this.Controls.Add(this.ItemNametextBox);
            this.Controls.Add(this.ItemNumbertextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ItemsDetails";
            this.Text = "AddCofee";
            this.Load += new System.EventHandler(this.ItemsDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ItemNumbertextBox;
        private System.Windows.Forms.TextBox ItemNametextBox;
        private System.Windows.Forms.TextBox ItemPricetextBox;
        private System.Windows.Forms.Button AddItembutton;
        private System.Windows.Forms.Button RemoveItembutton;
        private System.Windows.Forms.DataGridView ItemsGV;
        private System.Windows.Forms.Button ExitItemsbutton;
    }
}
namespace FinalProject
{
    partial class DealForm
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
            this.SelectItemscomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemQuantitytextBox = new System.Windows.Forms.TextBox();
            this.ItemPricetextBox = new System.Windows.Forms.TextBox();
            this.AddItemsbutton = new System.Windows.Forms.Button();
            this.RemoveItemsbutton = new System.Windows.Forms.Button();
            this.DealdataGridView = new System.Windows.Forms.DataGridView();
            this.backToMainFormbutton = new System.Windows.Forms.Button();
            this.BacktoItemDetailbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DealdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Items :";
            // 
            // SelectItemscomboBox
            // 
            this.SelectItemscomboBox.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectItemscomboBox.FormattingEnabled = true;
            this.SelectItemscomboBox.Location = new System.Drawing.Point(574, 73);
            this.SelectItemscomboBox.Name = "SelectItemscomboBox";
            this.SelectItemscomboBox.Size = new System.Drawing.Size(199, 25);
            this.SelectItemscomboBox.TabIndex = 1;
            this.SelectItemscomboBox.SelectedIndexChanged += new System.EventHandler(this.SelectItemscomboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price :";
            // 
            // ItemQuantitytextBox
            // 
            this.ItemQuantitytextBox.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQuantitytextBox.Location = new System.Drawing.Point(574, 118);
            this.ItemQuantitytextBox.Name = "ItemQuantitytextBox";
            this.ItemQuantitytextBox.Size = new System.Drawing.Size(199, 24);
            this.ItemQuantitytextBox.TabIndex = 4;
            // 
            // ItemPricetextBox
            // 
            this.ItemPricetextBox.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemPricetextBox.Location = new System.Drawing.Point(574, 164);
            this.ItemPricetextBox.Name = "ItemPricetextBox";
            this.ItemPricetextBox.Size = new System.Drawing.Size(199, 24);
            this.ItemPricetextBox.TabIndex = 5;
            // 
            // AddItemsbutton
            // 
            this.AddItemsbutton.BackColor = System.Drawing.Color.Black;
            this.AddItemsbutton.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemsbutton.ForeColor = System.Drawing.Color.White;
            this.AddItemsbutton.Location = new System.Drawing.Point(574, 223);
            this.AddItemsbutton.Name = "AddItemsbutton";
            this.AddItemsbutton.Size = new System.Drawing.Size(115, 53);
            this.AddItemsbutton.TabIndex = 6;
            this.AddItemsbutton.Text = "Add";
            this.AddItemsbutton.UseVisualStyleBackColor = false;
            this.AddItemsbutton.Click += new System.EventHandler(this.AddItemsbutton_Click);
            // 
            // RemoveItemsbutton
            // 
            this.RemoveItemsbutton.BackColor = System.Drawing.Color.Black;
            this.RemoveItemsbutton.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveItemsbutton.ForeColor = System.Drawing.Color.White;
            this.RemoveItemsbutton.Location = new System.Drawing.Point(695, 223);
            this.RemoveItemsbutton.Name = "RemoveItemsbutton";
            this.RemoveItemsbutton.Size = new System.Drawing.Size(115, 53);
            this.RemoveItemsbutton.TabIndex = 7;
            this.RemoveItemsbutton.Text = "Remove";
            this.RemoveItemsbutton.UseVisualStyleBackColor = false;
            this.RemoveItemsbutton.Click += new System.EventHandler(this.RemoveItemsbutton_Click);
            // 
            // DealdataGridView
            // 
            this.DealdataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DealdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DealdataGridView.Location = new System.Drawing.Point(298, 329);
            this.DealdataGridView.Name = "DealdataGridView";
            this.DealdataGridView.Size = new System.Drawing.Size(503, 106);
            this.DealdataGridView.TabIndex = 8;
            // 
            // backToMainFormbutton
            // 
            this.backToMainFormbutton.BackColor = System.Drawing.Color.Red;
            this.backToMainFormbutton.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMainFormbutton.ForeColor = System.Drawing.Color.White;
            this.backToMainFormbutton.Location = new System.Drawing.Point(-2, -4);
            this.backToMainFormbutton.Name = "backToMainFormbutton";
            this.backToMainFormbutton.Size = new System.Drawing.Size(196, 69);
            this.backToMainFormbutton.TabIndex = 9;
            this.backToMainFormbutton.Text = "back To MainForm";
            this.backToMainFormbutton.UseVisualStyleBackColor = false;
            this.backToMainFormbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BacktoItemDetailbutton
            // 
            this.BacktoItemDetailbutton.BackColor = System.Drawing.Color.Red;
            this.BacktoItemDetailbutton.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacktoItemDetailbutton.ForeColor = System.Drawing.Color.White;
            this.BacktoItemDetailbutton.Location = new System.Drawing.Point(200, -4);
            this.BacktoItemDetailbutton.Name = "BacktoItemDetailbutton";
            this.BacktoItemDetailbutton.Size = new System.Drawing.Size(312, 69);
            this.BacktoItemDetailbutton.TabIndex = 10;
            this.BacktoItemDetailbutton.Text = "Back To itemsDetailForm";
            this.BacktoItemDetailbutton.UseVisualStyleBackColor = false;
            this.BacktoItemDetailbutton.Click += new System.EventHandler(this.BacktoItemDetailbutton_Click);
            // 
            // DealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.images__8_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 466);
            this.Controls.Add(this.BacktoItemDetailbutton);
            this.Controls.Add(this.backToMainFormbutton);
            this.Controls.Add(this.DealdataGridView);
            this.Controls.Add(this.RemoveItemsbutton);
            this.Controls.Add(this.AddItemsbutton);
            this.Controls.Add(this.ItemPricetextBox);
            this.Controls.Add(this.ItemQuantitytextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectItemscomboBox);
            this.Controls.Add(this.label1);
            this.Name = "DealForm";
            this.Text = "DealForm";
            this.Load += new System.EventHandler(this.DealForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DealdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectItemscomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ItemQuantitytextBox;
        private System.Windows.Forms.TextBox ItemPricetextBox;
        private System.Windows.Forms.Button AddItemsbutton;
        private System.Windows.Forms.Button RemoveItemsbutton;
        private System.Windows.Forms.DataGridView DealdataGridView;
        private System.Windows.Forms.Button backToMainFormbutton;
        private System.Windows.Forms.Button BacktoItemDetailbutton;
    }
}
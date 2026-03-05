namespace ShoundSharp
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lstStock = new ListBox();
            lblStock = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(345, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(345, 65);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(124, 29);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Aanpassen";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(345, 100);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Verwijderen";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lstStock
            // 
            lstStock.FormattingEnabled = true;
            lstStock.Location = new Point(5, 30);
            lstStock.Name = "lstStock";
            lstStock.Size = new Size(334, 404);
            lstStock.TabIndex = 3;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(5, 7);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(70, 20);
            lblStock.TabIndex = 4;
            lblStock.Text = "Voorraad";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 450);
            Controls.Add(lblStock);
            Controls.Add(lstStock);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Name = "frmMain";
            Text = "SoundSharp";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private ListBox lstStock;
        private Label lblStock;
    }
}

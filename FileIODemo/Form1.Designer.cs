namespace FileIODemo
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCreatDirectory = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnStreamRead = new System.Windows.Forms.Button();
            this.btnStreamWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(84, 52);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(84, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(84, 138);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 2;
            this.lblSalary.Text = "Salary";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(214, 49);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 3;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(214, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(214, 138);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 5;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(138, 238);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(261, 238);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnCreatDirectory
            // 
            this.btnCreatDirectory.Location = new System.Drawing.Point(352, 52);
            this.btnCreatDirectory.Name = "btnCreatDirectory";
            this.btnCreatDirectory.Size = new System.Drawing.Size(121, 23);
            this.btnCreatDirectory.TabIndex = 8;
            this.btnCreatDirectory.Text = "Create Directory";
            this.btnCreatDirectory.UseVisualStyleBackColor = true;
            this.btnCreatDirectory.Click += new System.EventHandler(this.btnCreatDirectory_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(364, 107);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(75, 23);
            this.btnCreateFile.TabIndex = 9;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(582, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(143, 118);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // btnStreamRead
            // 
            this.btnStreamRead.Location = new System.Drawing.Point(654, 180);
            this.btnStreamRead.Name = "btnStreamRead";
            this.btnStreamRead.Size = new System.Drawing.Size(97, 23);
            this.btnStreamRead.TabIndex = 11;
            this.btnStreamRead.Text = "Stream Read";
            this.btnStreamRead.UseVisualStyleBackColor = true;
            this.btnStreamRead.Click += new System.EventHandler(this.btnStreamRead_Click);
            // 
            // btnStreamWrite
            // 
            this.btnStreamWrite.Location = new System.Drawing.Point(548, 180);
            this.btnStreamWrite.Name = "btnStreamWrite";
            this.btnStreamWrite.Size = new System.Drawing.Size(87, 23);
            this.btnStreamWrite.TabIndex = 12;
            this.btnStreamWrite.Text = "Stream Write";
            this.btnStreamWrite.UseVisualStyleBackColor = true;
            this.btnStreamWrite.Click += new System.EventHandler(this.btnStreamWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStreamWrite);
            this.Controls.Add(this.btnStreamRead);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnCreatDirectory);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCreatDirectory;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnStreamRead;
        private System.Windows.Forms.Button btnStreamWrite;
    }
}


namespace DataBaseLearnnig
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
            this.nameTxTBox = new System.Windows.Forms.TextBox();
            this.gradeTxTBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.FirstButt = new System.Windows.Forms.Button();
            this.LastButt = new System.Windows.Forms.Button();
            this.prevButt = new System.Windows.Forms.Button();
            this.nextButt = new System.Windows.Forms.Button();
            this.elNumber = new System.Windows.Forms.Label();
            this.newButt = new System.Windows.Forms.Button();
            this.addButt = new System.Windows.Forms.Button();
            this.delButt = new System.Windows.Forms.Button();
            this.editButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTxTBox
            // 
            this.nameTxTBox.Location = new System.Drawing.Point(178, 30);
            this.nameTxTBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nameTxTBox.Name = "nameTxTBox";
            this.nameTxTBox.Size = new System.Drawing.Size(309, 29);
            this.nameTxTBox.TabIndex = 0;
            // 
            // gradeTxTBox
            // 
            this.gradeTxTBox.Location = new System.Drawing.Point(178, 103);
            this.gradeTxTBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gradeTxTBox.Name = "gradeTxTBox";
            this.gradeTxTBox.Size = new System.Drawing.Size(309, 29);
            this.gradeTxTBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(24, 35);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(65, 24);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            this.nameLabel.Visible = false;
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLabel.Location = new System.Drawing.Point(24, 108);
            this.gradeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(67, 24);
            this.gradeLabel.TabIndex = 4;
            this.gradeLabel.Text = "Grade";
            // 
            // FirstButt
            // 
            this.FirstButt.Location = new System.Drawing.Point(-1, 229);
            this.FirstButt.Name = "FirstButt";
            this.FirstButt.Size = new System.Drawing.Size(161, 31);
            this.FirstButt.TabIndex = 5;
            this.FirstButt.Text = "First Emelent";
            this.FirstButt.UseVisualStyleBackColor = true;
            this.FirstButt.Click += new System.EventHandler(this.FirstButt_Click);
            // 
            // LastButt
            // 
            this.LastButt.Location = new System.Drawing.Point(610, 229);
            this.LastButt.Name = "LastButt";
            this.LastButt.Size = new System.Drawing.Size(161, 31);
            this.LastButt.TabIndex = 6;
            this.LastButt.Text = "Last Emelent";
            this.LastButt.UseVisualStyleBackColor = true;
            this.LastButt.Click += new System.EventHandler(this.LastButt_Click);
            // 
            // prevButt
            // 
            this.prevButt.Location = new System.Drawing.Point(191, 229);
            this.prevButt.Name = "prevButt";
            this.prevButt.Size = new System.Drawing.Size(104, 31);
            this.prevButt.TabIndex = 7;
            this.prevButt.Text = "Prev";
            this.prevButt.UseVisualStyleBackColor = true;
            this.prevButt.Click += new System.EventHandler(this.prevButt_Click);
            // 
            // nextButt
            // 
            this.nextButt.Location = new System.Drawing.Point(429, 229);
            this.nextButt.Name = "nextButt";
            this.nextButt.Size = new System.Drawing.Size(104, 33);
            this.nextButt.TabIndex = 8;
            this.nextButt.Text = "Next";
            this.nextButt.UseVisualStyleBackColor = true;
            this.nextButt.Click += new System.EventHandler(this.nextButt_Click);
            // 
            // elNumber
            // 
            this.elNumber.AutoSize = true;
            this.elNumber.Location = new System.Drawing.Point(303, 236);
            this.elNumber.Name = "elNumber";
            this.elNumber.Size = new System.Drawing.Size(120, 24);
            this.elNumber.TabIndex = 9;
            this.elNumber.Text = "Result Here";
            // 
            // newButt
            // 
            this.newButt.Location = new System.Drawing.Point(191, 173);
            this.newButt.Name = "newButt";
            this.newButt.Size = new System.Drawing.Size(91, 39);
            this.newButt.TabIndex = 10;
            this.newButt.Text = "New";
            this.newButt.UseVisualStyleBackColor = true;
            this.newButt.Click += new System.EventHandler(this.newButt_Click);
            // 
            // addButt
            // 
            this.addButt.Location = new System.Drawing.Point(332, 173);
            this.addButt.Name = "addButt";
            this.addButt.Size = new System.Drawing.Size(91, 39);
            this.addButt.TabIndex = 11;
            this.addButt.Text = "Add";
            this.addButt.UseVisualStyleBackColor = true;
            this.addButt.Click += new System.EventHandler(this.addButt_Click);
            // 
            // delButt
            // 
            this.delButt.Location = new System.Drawing.Point(467, 173);
            this.delButt.Name = "delButt";
            this.delButt.Size = new System.Drawing.Size(91, 39);
            this.delButt.TabIndex = 12;
            this.delButt.Text = "Delete";
            this.delButt.UseVisualStyleBackColor = true;
            this.delButt.Click += new System.EventHandler(this.delButt_Click);
            // 
            // editButt
            // 
            this.editButt.Location = new System.Drawing.Point(593, 173);
            this.editButt.Name = "editButt";
            this.editButt.Size = new System.Drawing.Size(91, 39);
            this.editButt.TabIndex = 13;
            this.editButt.Text = "Edit";
            this.editButt.UseVisualStyleBackColor = true;
            this.editButt.Click += new System.EventHandler(this.editButt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 637);
            this.Controls.Add(this.editButt);
            this.Controls.Add(this.delButt);
            this.Controls.Add(this.addButt);
            this.Controls.Add(this.newButt);
            this.Controls.Add(this.elNumber);
            this.Controls.Add(this.nextButt);
            this.Controls.Add(this.prevButt);
            this.Controls.Add(this.LastButt);
            this.Controls.Add(this.FirstButt);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.gradeTxTBox);
            this.Controls.Add(this.nameTxTBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxTBox;
        private System.Windows.Forms.TextBox gradeTxTBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Button FirstButt;
        private System.Windows.Forms.Button LastButt;
        private System.Windows.Forms.Button prevButt;
        private System.Windows.Forms.Button nextButt;
        private System.Windows.Forms.Label elNumber;
        private System.Windows.Forms.Button newButt;
        private System.Windows.Forms.Button addButt;
        private System.Windows.Forms.Button delButt;
        private System.Windows.Forms.Button editButt;
    }
}


namespace ToDoApp
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
            txtTitle = new System.Windows.Forms.TextBox();
            txtDesc = new System.Windows.Forms.TextBox();
            dtpduedate = new System.Windows.Forms.DateTimePicker();
            buttonAdd = new System.Windows.Forms.Button();
            buttonUpdate = new System.Windows.Forms.Button();
            buttonDel = new System.Windows.Forms.Button();
            buttonComplete = new System.Windows.Forms.Button();
            buttonshow = new System.Windows.Forms.Button();
            listTasks = new System.Windows.Forms.ListBox();
            labelTitle = new System.Windows.Forms.Label();
            labelDesc = new System.Windows.Forms.Label();
            labelDueDate = new System.Windows.Forms.Label();
            labelTasks = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            txtTitle.Location = new System.Drawing.Point(172, 111);
            txtTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(246, 27);
            txtTitle.TabIndex = 0;
            // 
            // txtDesc
            // 
            txtDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            txtDesc.Location = new System.Drawing.Point(172, 189);
            txtDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new System.Drawing.Size(246, 27);
            txtDesc.TabIndex = 1;
            // 
            // dtpduedate
            // 
            dtpduedate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dtpduedate.Location = new System.Drawing.Point(172, 269);
            dtpduedate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtpduedate.Name = "dtpduedate";
            dtpduedate.Size = new System.Drawing.Size(246, 27);
            dtpduedate.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            buttonAdd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            buttonAdd.Location = new System.Drawing.Point(58, 344);
            buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(124, 51);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = System.Drawing.Color.MediumSeaGreen;
            buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            buttonUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            buttonUpdate.Location = new System.Drawing.Point(193, 344);
            buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new System.Drawing.Size(124, 51);
            buttonUpdate.TabIndex = 4;
            buttonUpdate.Text = "UPDATE";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDel
            // 
            buttonDel.BackColor = System.Drawing.Color.MediumSeaGreen;
            buttonDel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            buttonDel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            buttonDel.Location = new System.Drawing.Point(327, 344);
            buttonDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new System.Drawing.Size(124, 51);
            buttonDel.TabIndex = 5;
            buttonDel.Text = "DELETE";
            buttonDel.UseVisualStyleBackColor = false;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonComplete
            // 
            buttonComplete.BackColor = System.Drawing.Color.MediumSeaGreen;
            buttonComplete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            buttonComplete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            buttonComplete.Location = new System.Drawing.Point(461, 344);
            buttonComplete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new System.Drawing.Size(142, 51);
            buttonComplete.TabIndex = 6;
            buttonComplete.Text = "COMPLETE";
            buttonComplete.UseVisualStyleBackColor = false;
            buttonComplete.Click += buttonComplete_Click;
            // 
            // buttonshow
            // 
            buttonshow.BackColor = System.Drawing.Color.MediumSeaGreen;
            buttonshow.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            buttonshow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            buttonshow.Location = new System.Drawing.Point(615, 344);
            buttonshow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonshow.Name = "buttonshow";
            buttonshow.Size = new System.Drawing.Size(138, 51);
            buttonshow.TabIndex = 7;
            buttonshow.Text = "SHOW ALL";
            buttonshow.UseVisualStyleBackColor = false;
            buttonshow.Click += buttonshow_Click;
            // 
            // listTasks
            // 
            listTasks.BackColor = System.Drawing.Color.WhiteSmoke;
            listTasks.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            listTasks.ForeColor = System.Drawing.SystemColors.InfoText;
            listTasks.FormattingEnabled = true;
            listTasks.ItemHeight = 23;
            listTasks.Location = new System.Drawing.Point(461, 111);
            listTasks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listTasks.Name = "listTasks";
            listTasks.Size = new System.Drawing.Size(307, 188);
            listTasks.TabIndex = 8;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            labelTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            labelTitle.Location = new System.Drawing.Point(89, 107);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(54, 28);
            labelTitle.TabIndex = 9;
            labelTitle.Text = "Title";
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            labelDesc.ForeColor = System.Drawing.Color.DarkSlateGray;
            labelDesc.Location = new System.Drawing.Point(47, 188);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new System.Drawing.Size(119, 28);
            labelDesc.TabIndex = 10;
            labelDesc.Text = "Description";
            // 
            // labelDueDate
            // 
            labelDueDate.AutoSize = true;
            labelDueDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            labelDueDate.ForeColor = System.Drawing.Color.DarkSlateGray;
            labelDueDate.Location = new System.Drawing.Point(60, 269);
            labelDueDate.Name = "labelDueDate";
            labelDueDate.Size = new System.Drawing.Size(100, 28);
            labelDueDate.TabIndex = 11;
            labelDueDate.Text = "Due Date";
            // 
            // labelTasks
            // 
            labelTasks.AutoSize = true;
            labelTasks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            labelTasks.ForeColor = System.Drawing.Color.DarkSlateGray;
            labelTasks.Location = new System.Drawing.Point(562, 79);
            labelTasks.Name = "labelTasks";
            labelTasks.Size = new System.Drawing.Size(65, 28);
            labelTasks.TabIndex = 12;
            labelTasks.Text = "Tasks";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Stencil", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.SeaGreen;
            label1.Location = new System.Drawing.Point(103, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(585, 40);
            label1.TabIndex = 13;
            label1.Text = "To-Do LIST MANAGEMENT SYSTEM";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.MintCream;
            ClientSize = new System.Drawing.Size(800, 562);
            Controls.Add(label1);
            Controls.Add(labelTasks);
            Controls.Add(labelDueDate);
            Controls.Add(labelDesc);
            Controls.Add(labelTitle);
            Controls.Add(listTasks);
            Controls.Add(buttonshow);
            Controls.Add(buttonComplete);
            Controls.Add(buttonDel);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(dtpduedate);
            Controls.Add(txtDesc);
            Controls.Add(txtTitle);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "TO-DO LIST";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.DateTimePicker dtpduedate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonComplete;
        private System.Windows.Forms.Button buttonshow;
        private System.Windows.Forms.ListBox listTasks;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelDueDate;
        private System.Windows.Forms.Label labelTasks;
        private System.Windows.Forms.Label label1;
    }
}


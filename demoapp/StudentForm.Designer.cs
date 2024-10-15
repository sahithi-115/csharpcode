namespace demoapp
{
    partial class StudentForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtMarks = new TextBox();
            btnCreate = new Button();
            btnSet = new Button();
            btnGet = new Button();
            btnClear = new Button();
            btndistroy = new Button();
            btngc = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 38);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 38);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(445, 38);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 4;
            label3.Text = "Marks";
            // 
            // txtId
            // 
            txtId.Location = new Point(25, 95);
            txtId.Name = "txtId";
            txtId.Size = new Size(139, 27);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(190, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(231, 27);
            txtName.TabIndex = 3;
            // 
            // txtMarks
            // 
            txtMarks.Location = new Point(445, 95);
            txtMarks.Name = "txtMarks";
            txtMarks.Size = new Size(98, 27);
            txtMarks.TabIndex = 5;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(50, 179);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(128, 42);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += this.btnCreate_Click;
            // 
            // btnSet
            // 
            btnSet.Location = new Point(219, 179);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(128, 42);
            btnSet.TabIndex = 7;
            btnSet.Text = "Set";
            btnSet.UseVisualStyleBackColor = true;
            btnSet.Click += this.btnSet_Click;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(382, 179);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(128, 42);
            btnGet.TabIndex = 8;
            btnGet.Text = "Get";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += this.btnGet_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(50, 257);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(128, 42);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += this.btnClear_Click;
            // 
            // btndistroy
            // 
            btndistroy.Location = new Point(219, 257);
            btndistroy.Name = "btndistroy";
            btndistroy.Size = new Size(128, 42);
            btndistroy.TabIndex = 10;
            btndistroy.Text = "destroy";
            btndistroy.UseVisualStyleBackColor = true;
            // 
            // btngc
            // 
            btngc.Location = new Point(382, 257);
            btngc.Name = "btngc";
            btngc.Size = new Size(128, 42);
            btngc.TabIndex = 11;
            btngc.Text = "gc";
            btngc.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 325);
            Controls.Add(btngc);
            Controls.Add(btndistroy);
            Controls.Add(btnClear);
            Controls.Add(btnGet);
            Controls.Add(btnSet);
            Controls.Add(btnCreate);
            Controls.Add(txtMarks);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentForm";
            Text = "Student Form";
            Load += this.StudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtMarks;
        private Button btnCreate;
        private Button btnSet;
        private Button btnGet;
        private Button btnClear;
        private Button btndistroy;
        private Button btngc;
    }
}

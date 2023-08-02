namespace HoloGuessForm
{
    partial class Form1
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
            btnChoice1 = new Button();
            btnChoice2 = new Button();
            btnChoice3 = new Button();
            btnChoice4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblCorrect = new Label();
            lblWrong = new Label();
            label4 = new Label();
            tbQuestion = new TextBox();
            tbResult = new TextBox();
            btnNext = new Button();
            SuspendLayout();
            // 
            // btnChoice1
            // 
            btnChoice1.Location = new Point(24, 220);
            btnChoice1.Name = "btnChoice1";
            btnChoice1.Size = new Size(150, 50);
            btnChoice1.TabIndex = 0;
            btnChoice1.UseVisualStyleBackColor = true;
            btnChoice1.Click += btnChoice1_Click;
            // 
            // btnChoice2
            // 
            btnChoice2.Location = new Point(194, 220);
            btnChoice2.Name = "btnChoice2";
            btnChoice2.Size = new Size(150, 50);
            btnChoice2.TabIndex = 1;
            btnChoice2.UseVisualStyleBackColor = true;
            btnChoice2.Click += btnChoice2_Click;
            // 
            // btnChoice3
            // 
            btnChoice3.Location = new Point(24, 288);
            btnChoice3.Name = "btnChoice3";
            btnChoice3.Size = new Size(150, 50);
            btnChoice3.TabIndex = 2;
            btnChoice3.UseVisualStyleBackColor = true;
            btnChoice3.Click += btnChoice3_Click;
            // 
            // btnChoice4
            // 
            btnChoice4.Location = new Point(194, 288);
            btnChoice4.Name = "btnChoice4";
            btnChoice4.Size = new Size(150, 50);
            btnChoice4.TabIndex = 3;
            btnChoice4.UseVisualStyleBackColor = true;
            btnChoice4.Click += btnChoice4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 4;
            label1.Text = "POINTS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 5;
            label2.Text = "Correct:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 39);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 6;
            label3.Text = "Wrong:";
            // 
            // lblCorrect
            // 
            lblCorrect.AutoSize = true;
            lblCorrect.Location = new Point(67, 24);
            lblCorrect.Name = "lblCorrect";
            lblCorrect.Size = new Size(0, 15);
            lblCorrect.TabIndex = 7;
            // 
            // lblWrong
            // 
            lblWrong.AutoSize = true;
            lblWrong.Location = new Point(67, 39);
            lblWrong.Name = "lblWrong";
            lblWrong.Size = new Size(0, 15);
            lblWrong.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 73);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 9;
            label4.Text = "QUESTION";
            // 
            // tbQuestion
            // 
            tbQuestion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbQuestion.Location = new Point(12, 91);
            tbQuestion.Multiline = true;
            tbQuestion.Name = "tbQuestion";
            tbQuestion.Size = new Size(344, 46);
            tbQuestion.TabIndex = 10;
            // 
            // tbResult
            // 
            tbResult.Location = new Point(12, 143);
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(344, 23);
            tbResult.TabIndex = 11;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(144, 174);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(80, 40);
            btnNext.TabIndex = 12;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 351);
            Controls.Add(btnNext);
            Controls.Add(tbResult);
            Controls.Add(tbQuestion);
            Controls.Add(label4);
            Controls.Add(lblWrong);
            Controls.Add(lblCorrect);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnChoice4);
            Controls.Add(btnChoice3);
            Controls.Add(btnChoice2);
            Controls.Add(btnChoice1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChoice1;
        private Button btnChoice2;
        private Button btnChoice3;
        private Button btnChoice4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblCorrect;
        private Label lblWrong;
        private Label label4;
        private TextBox tbQuestion;
        private TextBox tbResult;
        private Button btnNext;
    }
}
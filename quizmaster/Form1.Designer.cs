namespace quizmaster
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
            lblQuestionNumber = new Label();
            lblQuestion = new Label();
            rbOption1 = new RadioButton();
            rbOption2 = new RadioButton();
            rbOption3 = new RadioButton();
            btnNext = new Button();
            lblScore = new Label();
            SuspendLayout();
            // 
            // lblQuestionNumber
            // 
            lblQuestionNumber.AutoSize = true;
            lblQuestionNumber.Location = new Point(60, 60);
            lblQuestionNumber.Name = "lblQuestionNumber";
            lblQuestionNumber.Size = new Size(113, 25);
            lblQuestionNumber.TabIndex = 0;
            lblQuestionNumber.Text = "Soal ke-[1/5]";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(60, 100);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(98, 25);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "Pertanyaan";
            // 
            // rbOption1
            // 
            rbOption1.AutoSize = true;
            rbOption1.Location = new Point(60, 150);
            rbOption1.Name = "rbOption1";
            rbOption1.Size = new Size(146, 29);
            rbOption1.TabIndex = 2;
            rbOption1.TabStop = true;
            rbOption1.Text = "Opsi Jawaban";
            rbOption1.UseVisualStyleBackColor = true;
            // 
            // rbOption2
            // 
            rbOption2.AutoSize = true;
            rbOption2.Location = new Point(60, 185);
            rbOption2.Name = "rbOption2";
            rbOption2.Size = new Size(146, 29);
            rbOption2.TabIndex = 3;
            rbOption2.TabStop = true;
            rbOption2.Text = "Opsi Jawaban";
            rbOption2.UseVisualStyleBackColor = true;
            // 
            // rbOption3
            // 
            rbOption3.AutoSize = true;
            rbOption3.Location = new Point(60, 220);
            rbOption3.Name = "rbOption3";
            rbOption3.Size = new Size(146, 29);
            rbOption3.TabIndex = 4;
            rbOption3.TabStop = true;
            rbOption3.Text = "Opsi Jawaban";
            rbOption3.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(60, 275);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(112, 34);
            btnNext.TabIndex = 5;
            btnNext.Text = "Jawab";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(60, 320);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(141, 25);
            lblScore.TabIndex = 6;
            lblScore.Text = "Skor Sementara:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblScore);
            Controls.Add(btnNext);
            Controls.Add(rbOption3);
            Controls.Add(rbOption2);
            Controls.Add(rbOption1);
            Controls.Add(lblQuestion);
            Controls.Add(lblQuestionNumber);
            Name = "Form1";
            Text = "QuizMaster";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShuffleQuestions();
            ShowQuestion();
        }

        #endregion

        private Label lblQuestionNumber;
        private Label lblQuestion;
        private RadioButton rbOption1;
        private RadioButton rbOption2;
        private RadioButton rbOption3;
        private Button btnNext;
        private Label lblScore;
    }
}

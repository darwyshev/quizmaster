using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace quizmaster
{
    public partial class Form1 : Form
    {
        class Question
        {
            public string Text;
            public string[] Options;
            public string CorrectAnswer;
        }

        List<Question> questions = new List<Question>();
        int currentQuestionIndex = 0;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
            LoadQuestions();
            ShuffleQuestions();
            ShowQuestion();
        }

        void LoadQuestions()
        {
            string[] lines = File.ReadAllLines("soal.txt");
            foreach (var line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 5)
                {
                    questions.Add(new Question
                    {
                        Text = parts[0],
                        Options = new string[] { parts[1], parts[2], parts[3] },
                        CorrectAnswer = parts[4]
                    });
                }
            }
        }

        void ShuffleQuestions()
        {
            Random rng = new Random();
            for (int i = questions.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                var temp = questions[i];
                questions[i] = questions[j];
                questions[j] = temp;
            }
        }

        void ShowQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                var q = questions[currentQuestionIndex];
                lblQuestionNumber.Text = $"Soal ke- [{currentQuestionIndex + 1}/{questions.Count}]";
                lblQuestion.Text = q.Text;
                rbOption1.Text = q.Options[0];
                rbOption2.Text = q.Options[1];
                rbOption3.Text = q.Options[2];
                rbOption1.Checked = rbOption2.Checked = rbOption3.Checked = false;
            }
            else
            {
                MessageBox.Show($"Kuis selesai!\nSkor akhir: {score}/{questions.Count}");
                SaveResultToFile();
                btnNext.Enabled = false;
            }

            lblScore.Text = $"Skor Sementara: {score}";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var q = questions[currentQuestionIndex];
            string selectedAnswer = "";

            if (rbOption1.Checked) selectedAnswer = rbOption1.Text;
            else if (rbOption2.Checked) selectedAnswer = rbOption2.Text;
            else if (rbOption3.Checked) selectedAnswer = rbOption3.Text;

            if (string.IsNullOrEmpty(selectedAnswer))
            {
                MessageBox.Show("Pilih salah satu jawaban terlebih dahulu.");
                return;
            }

            string feedback;

            if (selectedAnswer == q.CorrectAnswer)
            {
                score++;
                feedback = " Benar!";
            }
            else
            {
                feedback = $" Salah! Jawaban benar: {q.CorrectAnswer}";
            }

            MessageBox.Show(feedback);
            currentQuestionIndex++;
            ShowQuestion();
        }

        void SaveResultToFile()
        {
            string filePath = "hasil_kuis.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("=== Hasil Kuis ===");
                writer.WriteLine($"Tanggal: {DateTime.Now}");
                writer.WriteLine($"Skor: {score}/{questions.Count}");
                writer.WriteLine("---------------------");
            }
        }
    }
}

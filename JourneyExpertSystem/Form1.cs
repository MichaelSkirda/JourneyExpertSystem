using JourneyExpertSystem.Models;
using System.Windows.Forms;

namespace JourneyExpertSystem
{
    public partial class Form1 : Form
    {
        private static int QuestionIndex = -1;

        public Form1()
        {
            InitializeComponent();
            LoadNextQuestion();
        }

        private void LoadNextQuestion()
        {
            QuestionIndex++;

            string text;
            List<Answer> answers;

            if(QuestionIndex < AppData.Questions.Count)
            {
                Question question = AppData.Questions[QuestionIndex];
                text = question.Text;
                answers = question.Answers;
            }
            else
            {
                text = "Вопросы закончились. Ответ:";
                answers = [];
                resultLabel.Text = string.Join(", ", AppData.AvailiableCountries.Select(x => x.Name));
            }

            questionLabel.Text = text;

             var buttons = new List<Button>();

            for(int i = 0; i < answers.Count; i++)
            {
                var answer = answers[i];
                var answerButton = new Button();

                answerButton.Location = new Point(x: (ClientSize.Width - answerButton.Width) / 2, 115 + i * 30);
                answerButton.Name = "answerButtonExample" + i;
                answerButton.Size = new Size(75, 25);
                answerButton.TabIndex = 3;
                answerButton.Text = answer.Text;
                answerButton.UseVisualStyleBackColor = true;

                buttons.Add(answerButton);

                answerButton.Click += (_, _) =>
                {
                    answer.ClickCallback();

                    foreach(var button in buttons)
                    {
                        button.Dispose();
                    }

                    LoadNextQuestion();
                };

                Controls.Add(answerButton);
            }
        }
    }
}

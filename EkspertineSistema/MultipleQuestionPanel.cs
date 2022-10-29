using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkspertineSistema
{
    class MultipleQuestionPanel
    {
        private Panel mainPanel;
        private Label mainQuestionLabel;
        private Button acceptButton;
        private DataGridView mainDataGrid;

        private QuestionInfo questionInformation;

        public MultipleQuestionPanel(Panel mainPanel, DataGridView mainDataGrid, Label mainQuestionLabel, Button acceptButton, QuestionInfo questionInformation = null)
        {
            this.mainPanel = mainPanel;
            this.mainQuestionLabel = mainQuestionLabel;
            this.acceptButton = acceptButton;
            this.mainDataGrid = mainDataGrid;

            this.questionInformation = questionInformation;
        }

        public void ActivateQuestion()
        {
            if (questionInformation != null)
            {
                List<Answer> answers = this.questionInformation.GetAnswers();
                int totalAnswers = answers.Count;

                if (totalAnswers < 2)
                {
                    MessageBox.Show("Klausimas turi turėti tik 2 atsakymus!");
                }
                else
                {
                    this.mainDataGrid.Rows.Clear();
                    this.mainDataGrid.Columns.Clear();

                    this.mainQuestionLabel.Text = this.questionInformation.GetQuestion();

                    DataGridViewCheckBoxColumn CheckBoxSelectAnswer = new DataGridViewCheckBoxColumn();
                    CheckBoxSelectAnswer.HeaderText = "Select";

                    this.mainDataGrid.Columns.Add(CheckBoxSelectAnswer);
                    this.mainDataGrid.Columns.Add("Answers", "Atsakymai");

                    DataGridViewColumn nameColumn = this.mainDataGrid.Columns[1];

                    nameColumn.ReadOnly = true;
                    nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    nameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;

                    foreach (Answer answer in answers)
                    {
                        this.mainDataGrid.Rows.Add(false, answer.GetAnswer());
                    }
                }
            }
        }

        public Answer ButtonClick()
        {
            List<Answer> answers = this.questionInformation.GetAnswers();

            foreach (DataGridViewRow row in mainDataGrid.Rows)
            {
                if(Convert.ToBoolean(row.Cells[0].EditedFormattedValue))
                {
                    return answers[row.Index];
                }
            }

            return null;
        }

        public void SetQuestionInformation(QuestionInfo setQuestionInformation)
        {
            this.questionInformation = setQuestionInformation;
        }
    }
}

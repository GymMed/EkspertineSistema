using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkspertineSistema
{
    class QuestionManager
    {
        private MainForm mainForm;

        private MultipleQuestionPanel multipleQuestionPanel;
        private TwoQuestionPanel twoQuestionPanel;
        private ConclusionPanel conclusionPanel;

        private QuestionInfo questionInformation, firstQuestionInformation;

        public QuestionManager(MainForm setMainForm, TwoQuestionPanel setTwoQuestionPanel, MultipleQuestionPanel setMultipleQuestionPanel,
            ConclusionPanel setConclusionPanel, QuestionInfo setQuestionInformation)
        {
            this.mainForm = setMainForm;

            this.twoQuestionPanel = setTwoQuestionPanel;
            this.multipleQuestionPanel = setMultipleQuestionPanel;
            this.conclusionPanel = setConclusionPanel;

            this.firstQuestionInformation = setQuestionInformation;
            this.questionInformation = setQuestionInformation;
        }

        public void SetTwoQuestionPanel(TwoQuestionPanel newTwoQusetionPanel)
        {
            this.twoQuestionPanel = newTwoQusetionPanel;
        }

        public void SetMultipleQuestionPanel(MultipleQuestionPanel newMultipleQuestionPanel)
        {
            this.multipleQuestionPanel = newMultipleQuestionPanel;
        }

        public void SetQuestionInformation(QuestionInfo questionInfo)
        {
            this.questionInformation = questionInfo;
        }

        public TwoQuestionPanel GetTwoQuestionPanel()
        {
            return this.twoQuestionPanel;
        }

        public MultipleQuestionPanel GetMultipleQuestionPanel()
        {
            return this.multipleQuestionPanel;
        }

        public QuestionInfo GetQuestionInformation()
        {
            return this.questionInformation;
        }

        public void StartSystem()
        {
            if(this.questionInformation == null)
            {
                MessageBox.Show("Nenustatyas pirmasis klausimas!", "Klaida");
            }
            else
            {
                mainForm.Set_Panel((int)MainForm.panelIndexes.StartPanel);
            }
        }

        public void ActivateQuestionPanel()
        {
            List<Answer> answers = this.questionInformation.GetAnswers();
            int totalAnswers = answers.Count;

            if (totalAnswers < 2)
            {
                MessageBox.Show("Klausimas turi turėti bent 2 atsakymus!");
            }
            else if(totalAnswers == 2)
            {
                twoQuestionPanel.SetQuestionInformation(this.questionInformation);
                twoQuestionPanel.ActivateQuestion();

                mainForm.Set_Panel((int)MainForm.panelIndexes.TwoAnswers);
            }
            else
            {
                multipleQuestionPanel.SetQuestionInformation(this.questionInformation);
                multipleQuestionPanel.ActivateQuestion();

                mainForm.Set_Panel((int)MainForm.panelIndexes.MultipleAnswers);
            }

        }

        public void ActivateConclusionPanel(Conclusion setConclusion)
        {
            conclusionPanel.ActivateConclusion(setConclusion);
            mainForm.Set_Panel((int)MainForm.panelIndexes.Conclusion);
        }

        public void ReceiveAnswer()
        {
            List<Answer> answers = this.questionInformation.GetAnswers();
            int totalAnswers = answers.Count;

            if (totalAnswers < 2)
            {
                MessageBox.Show("Klausimas turi turėti bent 2 atsakymus!");
            }
            else
            {
                Answer receivedAnswer = multipleQuestionPanel.ButtonClick();

                if (receivedAnswer != null)
                {
                    ActivateAnswer(receivedAnswer);
                }
                else
                {
                    MessageBox.Show("Turite pasirinkti bent vieną atsakymą!");
                }
            }
        }

        public void ReceiveYesAnswer()
        {
            List<Answer> answers = this.questionInformation.GetAnswers();
            int totalAnswers = answers.Count;

            if (totalAnswers < 2)
            {
                MessageBox.Show("Klausimas turi turėti bent 2 atsakymus!");
            }
            else
            {
                ActivateAnswer(twoQuestionPanel.YesButtonClick());
            }
        }

        public void ReceiveNoAnswer()
        {
            List<Answer> answers = this.questionInformation.GetAnswers();
            int totalAnswers = answers.Count;

            if (totalAnswers < 2)
            {
                MessageBox.Show("Klausimas turi turėti bent 2 atsakymus!");
            }
            else
            {
                ActivateAnswer(twoQuestionPanel.NoButtonClick());
            }
        }

        public void Repeat()
        {
            if (firstQuestionInformation != null)
            {
                this.questionInformation = this.firstQuestionInformation;
            }

            ActivateQuestionPanel();
        }

        private void ActivateAnswer(Answer answer)
        {
            if(answer.GetConclusion() == null)
            {
                this.questionInformation = answer.GetQuestionInfo();

                ActivateQuestionPanel();
            }
            else
            {
                ActivateConclusionPanel(answer.GetConclusion());
            }
        }
    }
}

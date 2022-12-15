using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkspertineSistema
{
    public partial class MainForm : Form
    {
        private QuestionManager questionManager;

        private List<Panel> panelList = new List<Panel>();

        private int panelIndex = 0;

        public enum panelIndexes
        {
            StartPanel,
            MultipleAnswers,
            TwoAnswers,
            Conclusion
        }

        public MainForm()
        {
            InitializeComponent();
            Setup_System();

            this.SystemNameLabel.Text = "Programavimo klaidų taisymo\n ekspertinė sistema";

            List<Answer> lastAnswers = new List<Answer>();
            List<Answer> articleAnswers = new List<Answer>();
            List<Answer> googleVideoAnswers = new List<Answer>();
            List<Answer> youtubeVideoAnswers = new List<Answer>();
            List<Answer> fixMySelfAnswers = new List<Answer>();
            List<Answer> canFindProblemAnswers = new List<Answer>();

            List<Answer> understandProblemDescriptionAnswers = new List<Answer>();
            List<Answer> understandTranslatedProblemDescriptionAnswers = new List<Answer>();
            List<Answer> understandProblemFromSimiliarArticlesAnswers = new List<Answer>();
            List<Answer> isTranslationUnderstandableAnswers = new List<Answer>();
            List<Answer> wordByWordTranslationUnderstandableAnswers = new List<Answer>();
            List<Answer> understandProblemAnswers = new List<Answer>();
            List<Answer> findExplanationsOnGoogleAnswers = new List<Answer>();
            List<Answer> similiarArticlesAnswers = new List<Answer>();

            List<Answer> keyWordsArticlesAnswers = new List<Answer>();
            List<Answer> checkKeyWordsArticlesAnswers = new List<Answer>();
            List<Answer> newKeyWordsArticlesAnswers = new List<Answer>();

            List<Answer> lastChangesAnswers = new List<Answer>();
            List<Answer> commentLastChangesAnswers = new List<Answer>();
            List<Answer> commentAllAnswers = new List<Answer>();
            List<Answer> googleVersionsAnswers = new List<Answer>();
            List<Answer> googleKeyWordsVersionsAnswers = new List<Answer>();
            List<Answer> commentPartsOfCodeAnswers = new List<Answer>();
            List<Answer> canDeterminateProblemAnswers = new List<Answer>();
            List<Answer> questioningGoogleAnswers = new List<Answer>();

            lastAnswers.Add(new Answer("Taip", new Conclusion("Problemą išsprendžiu atkartodamas straipsnyje atliktus veiksmus")));
            lastAnswers.Add(new Answer("Ne", new Conclusion("Prašau detalesnio paaiškinimo forumose(pvz.: stack overflow)")));

            QuestionInfo articleSearch = new QuestionInfo("Ar randu straipsnių, kuriuose žingsnis po žingsnio išsprendžiama problema?", lastAnswers);

            //articleAnswers.Add(new Answer("Taip", new Conclusion("Problema išsprendžiu atkartodamas vaizdo įraše atliktus veiksmus")));
            //articleAnswers.Add(new Answer("Ne", articleSearch));

            googleVideoAnswers.Add(new Answer("Taip", new Conclusion("Problemą išsprendžiu atkartodamas vaizdo įraše atliktus veiksmus")));
            googleVideoAnswers.Add(new Answer("Ne", articleSearch));

            QuestionInfo googleVideoSearch = new QuestionInfo("Naudodamas Google vaizdo įrašų paiešką ar randu, kaip problema išsprendžiama?", googleVideoAnswers);

            youtubeVideoAnswers.Add(new Answer("Taip", new Conclusion("Problema pataisau atkartodamas vaizdo įraše atliktus veiksmus")));
            youtubeVideoAnswers.Add(new Answer("Ne", googleVideoSearch));

            QuestionInfo youtubeVideoSearch = new QuestionInfo("Ar randu Youtube svetainėje vaizdo įrašą, kaip problema išsprendžiama?", youtubeVideoAnswers);

            fixMySelfAnswers.Add(new Answer("Taip", new Conclusion("Problema išsprendžiu pats, susiaurindamas paieškos vietą")));
            fixMySelfAnswers.Add(new Answer("Ne", youtubeVideoSearch));

            QuestionInfo fixMySelf = new QuestionInfo("Ar sugebu pats sutvarkyti problemą?", fixMySelfAnswers);

            Conclusion stackOverflow = new Conclusion("Aprašau savo problemą forumuose(pvz.:stackoverflow) ir laukiu atsakymo");

            //change question qoestions/answers name ordering because of uniquenes of answering
            canFindProblemAnswers.Add(new Answer("Taip", fixMySelf));
            canFindProblemAnswers.Add(new Answer("Ne", stackOverflow));

            QuestionInfo canFindProblem = new QuestionInfo("Ar sugebu surasti problemą?", canFindProblemAnswers);

            understandProblemDescriptionAnswers.Add(new Answer("Taip", canFindProblem));

            understandTranslatedProblemDescriptionAnswers.Add(new Answer("Taip", fixMySelf));

            understandProblemFromSimiliarArticlesAnswers.Add(new Answer("Taip", fixMySelf));
            understandProblemFromSimiliarArticlesAnswers.Add(new Answer("Ne", stackOverflow));

            QuestionInfo understandProblemFromSimiliarArticles = new QuestionInfo("Naudodamiesi Google paieškos sistema pateikite problemą. Ar suprantate problemos šaltinį naudodamiesi pateiktais straipsniais?", understandProblemFromSimiliarArticlesAnswers);

            understandTranslatedProblemDescriptionAnswers.Add(new Answer("Ne", understandProblemFromSimiliarArticles));

            QuestionInfo understandTranslatedProblemDescription = new QuestionInfo("Ar suprantu išverstos klaidos aprašymą?", understandTranslatedProblemDescriptionAnswers);

            wordByWordTranslationUnderstandableAnswers.Add(new Answer("Taip", fixMySelf));
            wordByWordTranslationUnderstandableAnswers.Add(new Answer("Ne", understandProblemFromSimiliarArticles));

            QuestionInfo wordByWordTranslationUnderstandable = new QuestionInfo("Ar kiekvieną žodį išverčia suprantamai?", wordByWordTranslationUnderstandableAnswers);

            isTranslationUnderstandableAnswers.Add(new Answer("Taip", understandTranslatedProblemDescription));
            isTranslationUnderstandableAnswers.Add(new Answer("Ne", wordByWordTranslationUnderstandable));

            QuestionInfo isTranslationUnderstandable = new QuestionInfo("Ar Google vertėjas išverčia suprantamai?", isTranslationUnderstandableAnswers);

            understandProblemDescriptionAnswers.Add(new Answer("Nesuprantu, nes nemoku išsiversti iš anglų kalbos", isTranslationUnderstandable));

            understandProblemAnswers.Add(new Answer("Taip", fixMySelf));
            understandProblemAnswers.Add(new Answer("Ne", understandProblemFromSimiliarArticles));

            QuestionInfo understandProblem = new QuestionInfo("Ar suprantu klaidą?", understandProblemAnswers);

            //next branch
            newKeyWordsArticlesAnswers.Add(new Answer("Taip", fixMySelf));
            newKeyWordsArticlesAnswers.Add(new Answer("Taip, bet klaidos panašumų nerandu", stackOverflow));
            newKeyWordsArticlesAnswers.Add(new Answer("Ne", stackOverflow));

            QuestionInfo newKeyWordsArticles = new QuestionInfo("Ar randu, atitinkančių raktinius žodžius, straipsnių remiantis naujais raktiniais žodžiais?", newKeyWordsArticlesAnswers);

            checkKeyWordsArticlesAnswers.Add(new Answer("Taip", stackOverflow));
            checkKeyWordsArticlesAnswers.Add(new Answer("Ne", newKeyWordsArticles));

            QuestionInfo checkKeyWordsArticles = new QuestionInfo("Patikrinus raktinius žodžius nerandu klaidos?", checkKeyWordsArticlesAnswers);

            keyWordsArticlesAnswers.Add(new Answer("Taip", fixMySelf));
            keyWordsArticlesAnswers.Add(new Answer("Taip, bet klaidos panašumų nerandu", checkKeyWordsArticles));
            keyWordsArticlesAnswers.Add(new Answer("Ne", stackOverflow));

            QuestionInfo keyWordsArticles = new QuestionInfo("Ar randu panašių straipsnių remiantis raktiniais žodžiais?", keyWordsArticlesAnswers);

            similiarArticlesAnswers.Add(new Answer("Taip", understandProblemFromSimiliarArticles));
            similiarArticlesAnswers.Add(new Answer("Ne", keyWordsArticles));

            QuestionInfo similiarArticles = new QuestionInfo("Ar galiu surasti panašių straipsnių?", similiarArticlesAnswers);

            findExplanationsOnGoogleAnswers.Add(new Answer("Taip", understandProblem));
            findExplanationsOnGoogleAnswers.Add(new Answer("Ne", similiarArticles));

            QuestionInfo findExplanationsOnGoogle = new QuestionInfo("Ar paieškos sistemoje Google surandu paaiškinimus?", findExplanationsOnGoogleAnswers);

            understandProblemDescriptionAnswers.Add(new Answer("Nesuprantu profesinių žodžių", findExplanationsOnGoogle));
            //On Last

            //end node
            googleKeyWordsVersionsAnswers.Add(new Answer("Taip", fixMySelf));
            googleKeyWordsVersionsAnswers.Add(new Answer("Ne", stackOverflow));

            QuestionInfo googleKeyWordsVersions = new QuestionInfo("Ar įvedus raktinius žodžius, paieškos sistemoje Google, dėl versijų nesuderinamumo sugebu atrasti klaidą?", googleKeyWordsVersionsAnswers);

            //end node
            googleVersionsAnswers.Add(new Answer("Taip", fixMySelf));
            googleVersionsAnswers.Add(new Answer("Ne", googleKeyWordsVersions));

            QuestionInfo googleVersions = new QuestionInfo("Ar pateikiant klausimą paieškos sistemai Google dėl versijų nesuderinamumo sugebu atrasti klaidą?", googleVersionsAnswers);

            //end node
            canDeterminateProblemAnswers.Add(new Answer("Taip", fixMySelf));
            canDeterminateProblemAnswers.Add(new Answer("Ne", stackOverflow));

            QuestionInfo canDeterminateProblem = new QuestionInfo("Ar galiu nustatyti neveikimo priežastį?", canDeterminateProblemAnswers);

            commentPartsOfCodeAnswers.Add(new Answer("Taip", canDeterminateProblem));
            commentPartsOfCodeAnswers.Add(new Answer("Ne", googleVersions));

            QuestionInfo commentPartsOfCode = new QuestionInfo("Ar pavyksta sėkmingai atkomentuoti dalį kodo?", commentPartsOfCodeAnswers);

            commentAllAnswers.Add(new Answer("Taip", googleVersions));
            commentAllAnswers.Add(new Answer("Ne", commentPartsOfCode));

            QuestionInfo commentAll = new QuestionInfo("Ar užkomentuojant visą kodą programa vis tiek neveikia?", commentAllAnswers);

            questioningGoogleAnswers.Add(new Answer("Taip", fixMySelf));
            questioningGoogleAnswers.Add(new Answer("Ne", googleKeyWordsVersions));

            QuestionInfo questioningGoogle = new QuestionInfo("Ar pateikiant klausimą paieškos sistemai Google sugebu atrasti klaidą?", questioningGoogleAnswers);

            commentLastChangesAnswers.Add(new Answer("Taip", canFindProblem));
            commentLastChangesAnswers.Add(new Answer("Ne", commentAll));
            commentLastChangesAnswers.Add(new Answer("Kartais pradingsta, kartais ne", questioningGoogle));

            QuestionInfo commentLastChanges = new QuestionInfo("Ar užkomentuojant paskutinius pakitimus problema pradingsta?", commentLastChangesAnswers);

            lastChangesAnswers.Add(new Answer("Taip", commentLastChanges));
            lastChangesAnswers.Add(new Answer("Ne", commentAll));

            QuestionInfo lastChanges = new QuestionInfo("Ar gali sužinoti paskutinius pakeitimus?", lastChangesAnswers);

            //Parent of most child nodes
            QuestionInfo understandProblemDescription = new QuestionInfo("Ar suprantu klaidos aprašymą?", understandProblemDescriptionAnswers);

            ////////////////////////////////////////////OLD TESTING////////////////////////////////////////////////

            List<Answer> firstAnswers = new List<Answer>();

            firstAnswers.Add(new Answer("Taip", understandProblemDescription));
            firstAnswers.Add(new Answer("Ne", lastChanges));

            QuestionInfo firstQuestion =  new QuestionInfo("Ar klaida pateikiama konsolėje?", firstAnswers);

            MultipleQuestionPanel multipleQuestionPanel = new MultipleQuestionPanel(this.MultiQuestionPanel, this.dataGridQuestion, this.multiQuestionLabel,
                this.multipleButton);

            TwoQuestionPanel twoQuestionPanel = new TwoQuestionPanel(this.QuestionPanel, this.QuestionLabel, this.YesButton, this.NoButton);

            ConclusionPanel conclusionPanel = new ConclusionPanel(this.ConclusionPanel, this.ConclusionLabel, this.AcceptConclusionButton);

            questionManager = new QuestionManager(this, twoQuestionPanel, multipleQuestionPanel, conclusionPanel, firstQuestion);

            questionManager.StartSystem();
        }


        public void Redraw_Menu()
        {
            panelList[panelIndex].BringToFront();

            foreach (Panel panel in panelList)
            {
                panel.Hide();
            }

            panelList[panelIndex].Show();
        }

        public int Get_Panel_Index(string name)
        {
            int totalPanels = panelList.Count;

            for (int currentPanel = 0; currentPanel < totalPanels; currentPanel++)
            {
                if (panelList[currentPanel].Name == name)
                {
                    return currentPanel;
                }
            }

            return 0;
        }

        public void Set_Panel(int index)
        {
            this.panelIndex = index;
            Redraw_Menu();
        }

        public void Set_Panel(string panelName)
        {
            this.panelIndex = Get_Panel_Index(panelName);
            Redraw_Menu();
        }

        // Data Grid Question
        private void dataGridQuestion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                if (Convert.ToBoolean(dataGridQuestion.Rows[e.RowIndex].Cells[0].EditedFormattedValue))
                {
                    foreach (DataGridViewRow row in this.dataGridQuestion.Rows)
                    {
                        if (row.Index != e.RowIndex)
                        {
                            dataGridQuestion.Rows[row.Index].Cells[0].Value = false;
                        }
                    }
                }
            }
        }

        private void dataGridQuestion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                this.dataGridQuestion.EndEdit();
            }
        }

        private void dataGridQuestion_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                this.dataGridQuestion.EndEdit();
            }
        }

        //multiple button
        private void multipleButton_Click(object sender, EventArgs e)
        {
            questionManager.ReceiveAnswer();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            questionManager.ReceiveYesAnswer();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            questionManager.ReceiveNoAnswer();
        }

        private void AcceptConclusionButton_Click(object sender, EventArgs e)
        {
            questionManager.StartSystem();
        }

        private void Setup_System()
        {
            /*
            IMPORTANT !!!
            ORDER MATTERS !!!
            */

            //start panel
            panelList.Add(this.StartPanel);

            //multiple answer question panel
            panelList.Add(this.MultiQuestionPanel);

            //two answers question panel
            panelList.Add(this.QuestionPanel);

            //conclusion panel
            panelList.Add(this.ConclusionPanel);

            Redraw_Menu();
        }

        private void EkspertineSistema_Load(object sender, EventArgs e)
        {
            Setup_System();
        }

        private void StartSystemButton_Click(object sender, EventArgs e)
        {
            questionManager.Repeat();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkspertineSistema
{
    class ConclusionPanel
    {
        private Panel mainPanel;
        private Label mainConclusionLabel;
        private Button repeatButton;

        public ConclusionPanel(Panel setMainPanel, Label setMainConclusionLabel, Button setRepeatButton)
        {
            this.mainPanel = setMainPanel;
            this.mainConclusionLabel = setMainConclusionLabel;
            this.repeatButton = setRepeatButton;
        }

        public void ActivateConclusion(Conclusion activationConclusion)
        {
            mainConclusionLabel.Text = activationConclusion.GetConclusion();
        }
    }
}

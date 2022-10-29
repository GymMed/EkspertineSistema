using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkspertineSistema
{
    class Conclusion
    {
        private string conclusion;

        public Conclusion(string setConclusion)
        {
            SetConclusion(setConclusion);
        }

        public void SetConclusion(string setConclusion)
        {
            setConclusion = TextFixer.Fix_Text(setConclusion);
            this.conclusion = setConclusion;
        }

        public string GetConclusion()
        {
            return this.conclusion;
        }
    }
}

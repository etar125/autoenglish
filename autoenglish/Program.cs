using System.Windows.Forms;

namespace autoenglish {
    class Program {
        public static void Main(string[] args) {
            if(!InputLanguage.CurrentInputLanguage.Culture.Name.Contains("en")) {
                SendKeys.SendWait("%+");
            }
        }
    }
}

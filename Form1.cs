namespace Currency_Berechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EUR -- Euro" + Environment.NewLine +
                           "CHF -- Schweizer Franken" +
                           Environment.NewLine + "GBP -- Britischer Pfund (Pfund Sterling)" +
                           Environment.NewLine + "JPY -- Japanischer Yen" +
                           Environment.NewLine + "USD -- Amerikanischer Dollar (US-Dollar)");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtsourceAmount.Text, out decimal sourceAmount))
            {
                decimal exchangeRate = GetExchangeRate(sourceAmount, targetAmount);
                decimal targetAmount = sourceAmount * exchangeRate;
                
                txttargetAmount.Text = targetAmount.ToString("N2");
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen gültigen Betrag ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static decimal GetExchangeRate(string sourceCurrency, string targetCurrency)
        {
            switch (sourceCurrency)
            {
                case "USD":
                    switch (targetCurrency)
                    {
                        case "USD": return 1;
                        case "EUR": return 0.85m;
                        case "JPY": return 110.2m;
                        case "GBP": return 0.73m;
                        case "AUD": return 1.35m;
                        default: return 1;
                    }
                case "EUR":

                    break;

                default:
                    return 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CHF -- EUR\t1.07\r" +
                "\nCHF -- GBP\t0.92\r" +
                "\nCHF -- JPY\t169.97\r" +
                "\nCHF -- USD\t1.16\r" +
                "\nEUR -- CHF\t0.94\r" +
                "\nEUR -- GBP\t0.86\r" +
                "\nEUR -- JPY\t159.52\r" +
                "\nEUR -- USD\t1.09\r" +
                "\nGBP -- EUR\t1.16\r" +
                "\nGBP -- JPY\t185.14\r" +
                "\nGBP -- CHF\t1.09\r" +
                "\nGBP -- USD\t1.27\r" +
                "\nJPY -- EUR\t0.0063\r" +
                "\nJPY -- GBP\t0.0054\r" +
                "\nJPY -- CHF\t0.0059\r" +
                "\nJPY -- USD\t0.0068\r" +
                "\nUSD -- EUR\t0.92\r" +
                "\nUSD -- GBP\t0.79\r" +
                "\nUSD -- JPY\t146.05\r" +
                "\nUSD -- CHF\t0.86");
        }

        private void Currency1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdEnde_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

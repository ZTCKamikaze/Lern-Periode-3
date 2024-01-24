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
            decimal targetAmount = 0;

            if (decimal.TryParse(txtsourceAmount.Text, out decimal sourceAmount))
            {

                decimal exchangeRate = GetExchangeRate(Convert.ToString(sourceAmount), Convert.ToString(targetAmount));
                targetAmount = sourceAmount * exchangeRate;

                txttargetAmount.Text = targetAmount.ToString("N2"); // txttargetAmount.Text = targetAmount * case USD -- case EUR:
            }                                                       // txttargetAmount.Text = targetAmount.ToString("N2");
            else
            {
                MessageBox.Show("Bitte geben Sie einen gültigen Betrag ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal GetExchangeRate(string sourceCurrency, string targetCurrency)
        {
            if (decimal.TryParse(txtsourceAmount.Text, out decimal sourceAmount))
            {
                switch (sourceCurrency)
                {
                    case "USD":
                        decimal targetAmount;

                        switch (targetCurrency)
                        {
                            case "USD":
                                break;
                            case "EUR":
                                targetAmount = sourceAmount * Convert.ToInt32(0.92); // Hier sollte er am besten Mal rechnen, wenn das funktionieren würde, wäre ich fertig.
                                break;
                            case "JPY":
                                break;
                            case "GBP":
                                break;
                            case "AUD":
                                break;
                            default: return 1;
                        }
                        break;

                    case "EUR":

                        break;

                    default:
                        return 1;
                }
            }
            return 0;
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

namespace KalkulackaFinal
{
    public partial class Form1 : Form
    {
        private KalkulackaFinal kalkulacka;
        private string operace;
        private bool prvniKolo = true;
        private double cislo = 0;


        public Form1()
        {
            kalkulacka = new KalkulackaFinal();
            InitializeComponent();
        }

        //tla��tka ��sel - v�e pod jedni�kou
        private void button1_Click(object sender, EventArgs e)
        {
            //if (aktualniCisloBox.Text == "+" || aktualniCisloBox.Text == "-" || aktualniCisloBox.Text == "*" || aktualniCisloBox.Text == "/" || aktualniCisloBox.Text == "^")
            if (new[] { "+", "-", "*", "/", "^" }.Contains(aktualniCisloBox.Text))
            {
                aktualniCisloBox.Text = ""; 
            }

            Button btn1 = (Button)sender;
            aktualniCisloBox.Text += btn1.Text;
            double.TryParse(aktualniCisloBox.Text, out cislo);
        }



        //tla��tka matematick�ch operac� - v�e pod plusem
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (prvniKolo)
            {
                kalkulacka.Pricti(double.Parse(aktualniCisloBox.Text));
                prvniKolo = false;
            }
            Button btn2 = (Button)sender;
            aktualniCisloBox.Text = btn2.Text;
            operace = aktualniCisloBox.Text;
        }

        //tla��tko rovn� se
        private void buttonRovnaSe_Click(object sender, EventArgs e)
        {
            Button btn3 = (Button)sender;
            double aktualniVysledek = double.Parse(aktualniCisloBox.Text);
            switch (operace)
            {
                case "+":
                    kalkulacka.Pricti(cislo);
                    break;

                case "-":
                    kalkulacka.Odecti(cislo);
                    break;

                case "*":
                    kalkulacka.Nasobeni(cislo);
                    break;

                case "/":
                    kalkulacka.Deleni(cislo);
                    break;

                case "^":
                    kalkulacka.Mocneni(cislo);
                    break;
            }

            aktualniCisloBox.Text = kalkulacka.VratAktualniVysledek().ToString();

        }
    }
}

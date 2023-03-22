using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace projekt2_Karpowicz
{
    public partial class SzeregIndywidualny : Form
    {

        const float SKDgPrzedzialuX = float.MinValue;
        const float SKGgPrzedzialuX = float.MaxValue;

        float[,] SKTWS;
        public SzeregIndywidualny()
        {
            InitializeComponent();
            SKchtWykresSzeregu.Hide();
            SKdgvTWS.Hide();
        }

        private void SzeregIndywidualny_Load(object sender, EventArgs e)
        {

        }

        private void SzeregIndywidualny_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult OknoMessage = MessageBox.Show("Czy napewno chcesz zamknąc ten formularz " +
                "(Szereg Indywidualny) i 'przejść' do formularza głównego?", this.Text, MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (OknoMessage == DialogResult.Yes)
            {
                e.Cancel = false;
                foreach (Form Formularz in Application.OpenForms)
                    if (Formularz.Name == "KokpitProjektu2_Karpowicz")
                    {
                        this.Hide();
                        Formularz.Show();
                        return;
                    }
                KokpitProjektu2_Karpowicz FormularzKokpitProjektu2_Karpowicz = new KokpitProjektu2_Karpowicz();
                FormularzKokpitProjektu2_Karpowicz.Show();
                this.Hide();
            }
            else
                e.Cancel = true;
        }

        private void SKbtnResetuj_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        #region Metody pomocnicze

        bool SKPobierz_X(out float SKX)
        {// dla "potrzeb technicznych" przypisujemy wartosci parametrom wyjsciowym
            SKX = 0.00F;
            //pobranie wartosci zmiennej niezaleznej X
            if (!float.TryParse(SKtxtX.Text, out SKX))
            {// sygnalizujemy zapalajac kontrolke ErrorProvider
                SKerrorProvider1.SetError(SKtxtX, "ERROR: w zapisie wartości zmiennej niezależnej " +
                    "X wystąpił niedozwolony znak");
                //Przerywamy dalsze pobieranie danych wejsciowych
                return false;
            }

            if ((SKX <= -1) || (SKX >=1))
            {//sygnalizacja bledu
                SKerrorProvider1.SetError(SKtxtX, "ERROR: nie jest spełniony warunek " +
                    "wejściowy dla X");

                //zwrotne przekazanie informacji o braku bledu
                return false;

            }
            SKtxtX.Enabled = false;
            return true;
        }

        bool SKPobierz_Eps(out float SKEps)
        {
            SKEps = 0.00F;

            //pobranie dokladnosci obliczen Eps
            if (!float.TryParse(SKtxtEps.Text, out SKEps))
            {//sygnalizacja bledu
                SKerrorProvider1.SetError(SKtxtEps, "ERROR: w zapisie dokladności obliczeń " +
                    "Eps wystąpił niedozwolony znak");
                //Przerywamy dalsze pobieranie danych wejsciowych
                return false;

            }

            //sprawdzenie czy jest spelniony warunek wejsciowy dla Eps
            if ((SKEps <= 0.00F) || (SKEps >= 1.00F))
            {//sygnalizacja bledu
                SKerrorProvider1.SetError(SKtxtEps, "ERROR: nie jest spełniony warunek" +
                    "wejsciowy dla Eps: 0.0 < Eps < 1.0");

                //zwrotne przekazanie informacji o braku bledu
                return false;

            }
            //ustawienie stanu braku aktywnosci dla kontrolki bledu
            SKtxtEps.Enabled = false;
            //zwrotne przekazanie informacji o braku bledu
            return true;
        }

        float SKObliczWartoscSzeregu(float SKX, float SKEps, out ushort SKn)
        {// dla "potrzeb technicznych" przypisujemy wartosc domyslna parametrowi wyjsciowemu
            SKn = 1;
            //deklaracje i ustalenie warunkow brzegowych
            float SKSuma = 0.0F;
            float SKw = 1.0F;
            //iteracyjne sumowanie wyrazow szeregu
            do
            {
                SKSuma = SKSuma + SKw;
                SKn++;
                //obliczenie wartosci ntego wyrazu szeregu
                SKw = (float)Math.Pow(SKX, SKn) * SKw / SKn;
            }
            while (Math.Abs(SKw) > SKEps);

            //zwrocenie obliczonej wartosci szeregu
            return SKSuma;

        } 

        float SKSumaSzereguPotęgowego(float SKX, float SKEps, out ushort SKk)
        {
            SKk = 0;
            float SKw = 1.0F;
            float SKS = SKw;

            while (Math.Abs(SKw) > SKEps)
            {
                SKk++;
                SKw = SKw * (-1) * SKX / SKk;

                SKS = SKS + SKw;
            };
            return SKS;
        }

        bool SKPobranie_SKEps_SKXd_SKXg_SKH(out float SKXd, out float SKXg, out float SKH, out float SKEps)
        {//przypisanie wartosci domyslnychh dla parametru wyjsciowych
            SKXd = SKXg = SKH = SKEps = 0.0F;
            // pobranie Xd
            if (!float.TryParse(SKtxtXd.Text, out SKXd))
            {// byl blad to go sygnalizujemy zapalac kontrolke errorProvider
                SKerrorProvider1.SetError(SKtxtXd, "ERROR: w zapisie Xd wystapil niedozwolony znak");
                //przerwanie pobierania danych
                return false;
            }
            // sprawdzenie czy pobrane Xd nalezy do przedzialu zbieznosci mojego szeregu
            if ((SKXd < SKDgPrzedzialuX) || (SKXg > SKGgPrzedzialuX))
            {//jest blad pobrane XD nie nalezy do przedzialu zbieznosci mojego szeregu
                SKerrorProvider1.SetError(SKtxtXd, "ERROR: podane Xd nie nalezy do przedzialu zbieznosci szeregu" +
                    "float.MinValue < XD < float.MaxValue");
                //przerwanie pobierania danych
                return false;

            }
            //pobranie Xg
            if (!float.TryParse(SKtxtXg.Text, out SKXg))
            {// byl blad to go sygnalizujemy zapalac kontrolke errorProvider
                SKerrorProvider1.SetError(SKtxtXg, "ERROR: w zapisie Xg wystapil niedozwolony znak");
                //przerwanie pobierania danych
                return false;

            }
            // sprawdzenie czy pobrane XD nalezy do przedzialu zbieznosci mojego szeregu
            if ((SKXg < SKDgPrzedzialuX) || (SKXg > SKGgPrzedzialuX))
            {//jest blad pobrane XD nie nalezy do przedzialu zbieznosci mojego szeregu
                SKerrorProvider1.SetError(SKtxtXd, "ERROR: podane XG nie nalezy do przedzialu zbieznosci szeregu" +
                    "float.MinValue < XG < float.MaxValue");
                //przerwanie pobierania danych
                return false;
            }
            // sprawdzanie poprawnosci kolejnosci zapisu granic przedzialu
            if (SKXg < SKXd)
            {// byl blad to go sygnalizujemy zapalac kontrolke errorProvider
                SKerrorProvider1.SetError(SKtxtXg, "ERROR: Granice przedzialu zostaly zapisane odwrotnie: " +
                    "musi byc spelniony tzw. warunek wejsciowy: XD <= XG");
                //przerwanie pobierania danych
                return false;

            }
            //tutaj XD i XG sa OK!
            //ustawienie stanu braku aktywnosci dla kontrolek txtXD oraz txtXG
            SKtxtXd.Enabled = false;
            SKtxtXg.Enabled = false;
            //pobranie przyrostu H zmian wartosci zmiennej niezaleznej X
            if (!float.TryParse(SKtxtH.Text, out SKH))
            {// byl blad to go sygnalizujemy zapalac kontrolke errorProvider
                SKerrorProvider1.SetError(SKtxtH, "ERROR: w zapisie 'H' wystapil niedozwolony znak");
                //przerywamy pobieranie danych
                return false;
            }
            //sprawdzenie tzw. warunku wejsciowego
            if (SKH >= (SKXg - SKXd))
            {// jest blad to go sygnalizujemy
                SKerrorProvider1.SetError(SKtxtH, "ERROR: podana wartosc 'H' nie spelnia warunku wejsciowego: H < (XG - XD)");
                return false;

            }
            // pobranie dokladnosci obliczen Eps
            if (!float.TryParse(SKtxtEps.Text, out SKEps))
            {// jest blad to go sygnalizujemy
                SKerrorProvider1.SetError(SKtxtEps, "ERROR: W zapisie dokladnosci obliczen Eps wystapil niedozwolony znak");
                //przerywamy pobieranie danych
                return false;

            }
            // sprawdzanie tzw. warunku wejsciowego dla dokladnosci obliczen
            if ((SKEps <= 0.0F) || (SKEps >= 1.0F))
            {
                // jest blad to go sygnalizujemy
                SKerrorProvider1.SetError(SKtxtH, "ERROR: podana wartosc 'Eps' nie spelnia warunku wejsciowego: 0.0 < Eps < 1.0");
                return false;
            }


            //zwrotne przekazanie informacji ze nie bylo bledu podczas pobierania danych
            return true;
        }

        void SKTablicowanieWartościSzeregu(float SKXd, float SKXg, float SKH, float SKEps, out float[,] SKTWS)

        {//przypisanie domyslnej wartosci  dla parametru wyjsciowego
            SKTWS = null;
            // wyznaczenie liczby podprzedzialow w przedziale: [XG, XG]
            int SKn = (int)((SKXg - SKXd) / SKH + 1);
            //utworzenie egzemplarza tablicy TWS
            SKTWS = new float[SKn + 1, 3];
            //tablicowanie wartosci szeregu
            // deklaracja zmiennych pomocniczych
            float SKX;
            int SKi;
            ushort SKLicznikZsumowanychWyrazow;
            for (SKX = SKXd, SKi = 0; SKi < SKTWS.GetLength(0); SKi++, SKX = SKXd + SKi * SKH)  // nie piszemy: X= X+h
            {
                // wpisywanie wynikow tablicowania do tablicy TWS
                SKTWS[SKi, 0] = SKX;
                SKTWS[SKi, 1] = SKObliczWartoscSzeregu(SKX, SKEps, out SKLicznikZsumowanychWyrazow);
                SKTWS[SKi, 2] = SKLicznikZsumowanychWyrazow;
            }
        }

        void SKWpisanieWynikówDoKonotrolkiDataGridView(float[,] SKTWS, DataGridView SKdgvTWS)
        {
            //"wyczyszczenie" kontrolki DataGridView
            SKdgvTWS.Rows.Clear();
            //przepisywanie zawartosci tablicy TWS do kontrolki dgvTWS
            for (int SKi = 0; SKi < SKTWS.GetLength(0); SKi++)
            {// dodanie nowego (pustego) wiersza do kontrolki DataGridView
                SKdgvTWS.Rows.Add();
                //wpisywanie kolejnych komorek z tablicy TWS do nowego wiersza
                SKdgvTWS.Rows[SKi].Cells[0].Value = string.Format("{0:0.00}", (float)SKTWS[SKi, 0]);
                SKdgvTWS.Rows[SKi].Cells[1].Value = string.Format("{0:0.0000}", (float)SKTWS[SKi, 1]);
                SKdgvTWS.Rows[SKi].Cells[2].Value = string.Format("{0}", (float)SKTWS[SKi, 2]);
            }
        }

        void SKWpisanieWynikówDoKontrolkiChart(float[,] SKTWS, Chart SKchtWykresSzeregu)
        {// obramowanie kontrolki chart
            SKchtWykresSzeregu.BorderlineWidth = 2;
            SKchtWykresSzeregu.BorderlineColor = Color.Red;
            SKchtWykresSzeregu.BorderlineDashStyle = ChartDashStyle.DashDotDot;
            // tytuł wykresu
            SKchtWykresSzeregu.Titles.Add("Wykres zmian wartości szeregu S(X)");
            // legenda pod wykresem
            SKchtWykresSzeregu.Legends.FindByName("Legend1").Docking = Docking.Bottom;
            // ustawienie koloru tła
            SKchtWykresSzeregu.BackColor = Color.LightSkyBlue;
            SKchtWykresSzeregu.ChartAreas[0].AxisX.Title = "Wartości X";
            SKchtWykresSzeregu.ChartAreas[0].AxisY.Title = "Wartości S(X)";
            // sformatowanie opisu osi X 
            SKchtWykresSzeregu.ChartAreas[0].AxisX.LabelStyle.Format = "{0:f2}";
            //sformatowanie opisu osi y
            SKchtWykresSzeregu.ChartAreas[0].AxisY.LabelStyle.Format = "{0:f2}";

            //formatowanie danych
            SKchtWykresSzeregu.Series.Clear();
            SKchtWykresSzeregu.Series.Add("Seria 0");

            SKchtWykresSzeregu.Series[0].XValueMember = "X";
            SKchtWykresSzeregu.Series[0].YValueMembers = "Y";

            SKchtWykresSzeregu.Series[0].IsVisibleInLegend = true;
            SKchtWykresSzeregu.Series[0].Name = "Wartość szeregu potęgowego S(X)";
            SKchtWykresSzeregu.Series[0].ChartType = SeriesChartType.Line;// wykres liniowy
            SKchtWykresSzeregu.Series[0].Color = Color.Black;
            SKchtWykresSzeregu.Series[0].BorderDashStyle = ChartDashStyle.Solid;
            SKchtWykresSzeregu.Series[0].BorderWidth = 1;

            // wpisanie wspołrzędnych
            for (int SKi = 0; SKi < SKTWS.GetLength(0); SKi++)
               SKchtWykresSzeregu.Series[0].Points.AddXY(SKTWS[SKi, 0], SKTWS[SKi, 1]);

        }

        #endregion

        private void SKbtnWartoscSzeregu_Click(object sender, EventArgs e)
        {
                // zgaszenie kontrolki errorProvider, ktora moglabyc zapalona podczas pobierania danych wejsciowych
                SKerrorProvider1.Dispose();

                // 1) Pobranie danych wejsciowych
                // deklaracje zmiennej dla przechowania danych wejsciowych
                float SKX, SKEps;

                // wywoalanie metody dla pobrania danych wejsciowych
                if (!SKPobierz_X(out SKX))
                {//byl blad, to go sygnalizujemy zapalajac kontrolke ErrorProvider
                    SKerrorProvider1.SetError(SKtxtX, "ERROR: w zapisie wartości X wystąpił " +
                        "niedozwolony znak");
                    //przerwanie dalszej obslugi zdarzenia Click
                    return;
                }


                if (!SKPobierz_Eps(out SKEps))
                {//byl blad, to go sygnalizujemy zapalajac kontrolke ErrorProvider
                    SKerrorProvider1.SetError(SKtxtEps, "ERROR: w zapisie wartości 2Eps wystąpił " +
                        "niedozwolony znak");
                    //przerwanie dalszej obslugi zdarzenia Click
                    return;
                }



                // 2) Obliczenie wartosci szeregu dla podanego X oraz Eps
                //deklaracja zmiennych dla przechowania wyniku obliczen
                float SKSuma;
                ushort SKLicznnikZsumowanychWyrazow;
                // wywoalnie metody dla obliczenia wartosci szeregu
                SKSuma = SKObliczWartoscSzeregu(SKX, SKEps, out SKLicznnikZsumowanychWyrazow);

                //3) wpisanie wyniku obliczen do odpowiednich kontrolek umieszczonych na formularzu
                SKtxtWSzeregu.Text = SKSuma.ToString();
                SKtxtLicznikSW.Text = SKLicznnikZsumowanychWyrazow.ToString();
                //ustawienie stanu braku aktywnosci dla przycisku polecen btnObliczWartoscSzeregu
                //
                SKbtnWartoscSzeregu.Enabled = true;


            
        }

        private void SKbtnTabelarycznaWizualizacja_Click(object sender, EventArgs e)
        {
            SKdgvTWS.Show();
            SKchtWykresSzeregu.Hide();
            SKerrorProvider1.Dispose();

            //deklaracje zmiennych dla przechowania pobranych danych wejsciowych z formularza
            float SKEps, SKXd, SKXg, SKH;

            if (!SKPobranie_SKEps_SKXd_SKXg_SKH(out SKXd, out SKXg, out SKH, out SKEps))
            {
                return;
            }
            // 2) Stablicowanie szeregu w podanych przedziale: [Xd, Xg]
            //sprawdzenie czy egzemplarz tablicy TWS został juz utworzony
            if (SKTWS is null) // nie pisze TWS== null
                SKTablicowanieWartościSzeregu(SKXd, SKXg, SKH, SKEps, out SKTWS);

            // 3) Przepisanie danych z TWS (Tablica Wartosci Szeregu) do kontrolki DataGridView
            SKWpisanieWynikówDoKonotrolkiDataGridView(SKTWS, SKdgvTWS);
            //odsloniecie kontrolkidgvTWS
            SKdgvTWS.Visible = true;
            // ustawienie stanu braku aktywnosci dla przycisku polecen btnWizualizacjaTabelaryczna
            SKbtnTabelarycznaWizualizacja.Enabled = false;
        }

        private void SKbtnGraficznaWizualizacja_Click(object sender, EventArgs e)
        {
            SKchtWykresSzeregu.Show();
            SKdgvTWS.Hide();
            SKerrorProvider1.Dispose();
            float SKXd, SKXg, SKH, SKEps;
            if (!SKPobranie_SKEps_SKXd_SKXg_SKH(out SKXd, out SKXg, out SKH, out SKEps))
                return;
            if (SKTWS is null)
                SKTablicowanieWartościSzeregu(SKXd, SKXg, SKH, SKEps, out SKTWS);

            SKWpisanieWynikówDoKontrolkiChart(SKTWS, SKchtWykresSzeregu);
            SKdgvTWS.Visible = false;
            SKchtWykresSzeregu.Visible = true;
            SKbtnGraficznaWizualizacja.Enabled = false;
        }

        #region pliki
        private void SKzapiszTabelaryczneZestawienieZmianWartościSzereguPotęgowegoWPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SKsaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = SKsaveFileDialog1.FileName;
            }
        }

        private void SKwczytajZPlikuTabelaryczneZestawienieZmianWartościSzereguPotęgowegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SKerrorProvider1.Dispose();

            if (!(SKTWS is null))
            {
                DialogResult SKOknoMessage = MessageBox.Show("UWAGA: egzemplarz tablicy TWS już istnieje!" +
                    "\r\nCzy bieżący egzemplarz tablicy TWS ma być skasowany i w jego miejsce ma być utworzony nowy egzemplarz, " +
                    "do którego mają zostać 'wczytane' elementy TWS z pliku? " +
                    "\r\n - kliknij przycisk poleceń 'Nie' dla skasowania polecenia wczytania elementów " +
                    "tablicy TWS z pliku ", "Okno ostrzeżenia", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (SKOknoMessage == DialogResult.Yes)
                    SKTWS = null;
                else
                {
                    MessageBox.Show("Polecenie odczytania (pobrania) elementów tablicy" +
                        " TWS z pliku zostało anulowane (skasowane!)");
                    return;
                }
            }

            OpenFileDialog SKOknoWyboruPlikuDoOdczytu = new OpenFileDialog();

            SKOknoWyboruPlikuDoOdczytu.Filter = "txtfiles (*.txt)|*.txt|All files(*.*)|*.*";
            SKOknoWyboruPlikuDoOdczytu.FilterIndex = 1;

            SKOknoWyboruPlikuDoOdczytu.RestoreDirectory = true;
            SKOknoWyboruPlikuDoOdczytu.InitialDirectory = "H:\\";
            SKOknoWyboruPlikuDoOdczytu.Title = "Wybór pliku do odczytu TWS (Tabeli Wartości Szeregu)";

            if (SKOknoWyboruPlikuDoOdczytu.ShowDialog() == DialogResult.OK)
            {
                string SKWierszDanych;
                string[] SKDaneWiersza;
                ushort SKLicznikWierszy;
                System.IO.StreamReader SKPlikZnakowy = new
                    System.IO.StreamReader(SKOknoWyboruPlikuDoOdczytu.FileName);
                SKLicznikWierszy = 0;
                while (!((SKWierszDanych = SKPlikZnakowy.ReadLine()) is null))
                    SKLicznikWierszy++;
                SKPlikZnakowy.Close();

                SKTWS = new float[SKLicznikWierszy, 3];
                SKPlikZnakowy = new System.IO.StreamReader(SKOknoWyboruPlikuDoOdczytu.FileName);

                try
                {
                    int SKNrWiersza = 0;
                    while (!((SKWierszDanych = SKPlikZnakowy.ReadLine()) is null))
                    {
                        SKDaneWiersza = SKWierszDanych.Split(';');

                        SKDaneWiersza[0].Trim();
                        SKDaneWiersza[1].Trim();
                        SKDaneWiersza[2].Trim();

                        SKTWS[SKNrWiersza, 0] = float.Parse(SKDaneWiersza[0]);
                        SKTWS[SKNrWiersza, 1] = float.Parse(SKDaneWiersza[1]);
                        SKTWS[SKNrWiersza, 2] = float.Parse(SKDaneWiersza[2]);
                        SKNrWiersza++;
                    }
                    SKWpisanieWynikówDoKonotrolkiDataGridView(SKTWS, SKdgvTWS);
                    SKchtWykresSzeregu.Visible = false;
                    SKdgvTWS.Visible = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: błąd operacji (działania) na pliku " +
                        "(wyświetlony komunikat): --> " + ex.Message);
                }
                finally
                {
                    SKPlikZnakowy.Close();
                    SKPlikZnakowy.Dispose();
                }
            }
            else
                MessageBox.Show("Plik do odczytu tablicy TWS nie został wybrany i obsługa" +
                    " polecenia: 'Odczytanie stablicowanego szeregu z pliku' (z menu poziomowego" +
                    " Plik) nie może być zrealizowana");
        }

        

        private void SKwyjścieExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        #endregion

        #region typy wykresów

        private void SKwykresLiniowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SKchtWykresSzeregu.Series[0].ChartType = SeriesChartType.Line;
        }

        private void SKwykresPunktowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SKchtWykresSzeregu.Series[0].ChartType = SeriesChartType.Point;
        }

        private void SKwykresKolumnowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SKchtWykresSzeregu.Series[0].ChartType = SeriesChartType.Column;
        }

        private void SKwykresSłupkowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SKchtWykresSzeregu.Series[0].ChartType = SeriesChartType.Bar;
        }
        #endregion

        #region kolory
        private void SKkolorTłaWykresuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SKcolorDialog1.ShowDialog() == DialogResult.OK)
            {
                SKchtWykresSzeregu.BackColor = SKcolorDialog1.Color;
            }
        }

        private void SKkolorLiniiWykresuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SKcolorDialog1.ShowDialog() == DialogResult.OK)
            {
                SKchtWykresSzeregu.Series[0].Color = SKcolorDialog1.Color;
            }
        }

        #endregion

        #region styl linii wykresu

        private void SKliniaKreskowaDashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SKchtWykresSzeregu.Series[0].BorderDashStyle = ChartDashStyle.Dash;
        }

        private void SKliniaKreskowoKropkowaDashDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SKchtWykresSzeregu.Series[0].BorderDashStyle = ChartDashStyle.DashDot;
        }

        private void SKliniaKreskowoKropkowaDashDotDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SKchtWykresSzeregu.Series[0].BorderDashStyle = ChartDashStyle.DashDotDot;
        }

        private void SKliniaKropkowaDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SKchtWykresSzeregu.Series[0].BorderDashStyle = ChartDashStyle.Dot;
        }

        private void SKliniaCiagłaSolidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SKchtWykresSzeregu.Series[0].BorderDashStyle = ChartDashStyle.Solid;
        }

        #endregion

        #region grubość linii wykresu

        private void SKtoolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SKchtWykresSzeregu.Series[0].BorderWidth = 1;
        }

        private void SKtoolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SKchtWykresSzeregu.Series[0].BorderWidth = 2;
        }

        private void SKtoolStripMenuItem5_Click(object sender, EventArgs e)
        {
            SKchtWykresSzeregu.Series[0].BorderWidth = 3;
        }

        private void SKtoolStripMenuItem6_Click(object sender, EventArgs e)
        {
            SKchtWykresSzeregu.Series[0].BorderWidth = 4;
        }

        private void SKtoolStripMenuItem7_Click(object sender, EventArgs e)
        {
            SKchtWykresSzeregu.Series[0].BorderWidth = 5;
        }

        #endregion

        #region czcionka
        private void SKczcionkaOpisuWykresukontrolkiChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SKfontDialog1.ShowDialog() == DialogResult.OK)
            {
                SKchtWykresSzeregu.ChartAreas[0].AxisX.LabelStyle.Font = SKfontDialog1.Font;
                SKchtWykresSzeregu.ChartAreas[0].AxisY.LabelStyle.Font = SKfontDialog1.Font;
                SKchtWykresSzeregu.Series[0].Font = SKfontDialog1.Font;
            }
        }

        private void SKczcionkaOpisuKontrolkiDataGridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SKfontDialog1.ShowDialog() == DialogResult.OK)
            {
                SKdgvTWS.Font = SKfontDialog1.Font;
            }
        }

        private void SKczcionkaOpisuFormularzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SKfontDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Font = SKfontDialog1.Font;
                label2.Font = SKfontDialog1.Font;
                label3.Font = SKfontDialog1.Font;
                label4.Font = SKfontDialog1.Font;
                label5.Font = SKfontDialog1.Font;
                label6.Font = SKfontDialog1.Font;
                label7.Font = SKfontDialog1.Font;
                label8.Font = SKfontDialog1.Font;
                SKbtnWartoscSzeregu.Font = SKfontDialog1.Font;
                SKbtnGraficznaWizualizacja.Font = SKfontDialog1.Font;
                SKbtnTabelarycznaWizualizacja.Font = SKfontDialog1.Font;
                SKbtnResetuj.Font = SKfontDialog1.Font;

            }
        }

        #endregion
    }
}

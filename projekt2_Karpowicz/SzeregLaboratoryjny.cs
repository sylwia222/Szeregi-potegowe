using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;

namespace projekt2_Karpowicz
{
    public partial class SzeregLaboratoryjny : Form
    {
        const float DgPrzedzialuX = float.MinValue;
        const float GgPrzedzialuX = float.MaxValue;

        float[,] TWS;

        public SzeregLaboratoryjny()
        {
            InitializeComponent();
            chtWykresSzeregu.Hide();
            dgvTWS.Hide();
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SzeregLaboratoryjny_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult OknoMessage = MessageBox.Show("Czy napewno chcesz zamknąc ten formularz " +
                "(SzeregLaboratoryjny) i 'przejść' do formularza głównego?", this.Text, MessageBoxButtons.YesNoCancel,
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

        private void button1_Click(object sender, EventArgs e)
        {
            // zgaszenie kontrolki errorProvider, ktora moglabyc zapalona podczas pobierania danych wejsciowych
            errorProvider1.Dispose();

            // 1) Pobranie danych wejsciowych
            // deklaracje zmiennej dla przechowania danych wejsciowych
            float X, Eps;

            // wywoalanie metody dla pobrania danych wejsciowych
            if (!Pobierz_X(out X))
            {//byl blad, to go sygnalizujemy zapalajac kontrolke ErrorProvider
                errorProvider1.SetError(txtX, "ERROR: w zapisie wartości X wystąpił " +
                    "niedozwolony znak");
                //przerwanie dalszej obslugi zdarzenia Click
                return;
            }


            if (!Pobierz_Eps(out Eps))
            {//byl blad, to go sygnalizujemy zapalajac kontrolke ErrorProvider
                errorProvider1.SetError(txtEps, "ERROR: w zapisie wartości 2Eps wystąpił " +
                    "niedozwolony znak");
                //przerwanie dalszej obslugi zdarzenia Click
                return;
            }



            // 2) Obliczenie wartosci szeregu dla podanego X oraz Eps
            //deklaracja zmiennych dla przechowania wyniku obliczen
            float Suma;
            ushort LicznnikZsumowanychWyrazow;
            // wywoalnie metody dla obliczenia wartosci szeregu
            Suma = ObliczWartoscSzeregu(X, Eps, out LicznnikZsumowanychWyrazow);

            //3) wpisanie wyniku obliczen do odpowiednich kontrolek umieszczonych na formularzu
            txtSumaSzeregu.Text = Suma.ToString();
            txtLicznikWyrazowSzeregu.Text = LicznnikZsumowanychWyrazow.ToString();
            //ustawienie stanu braku aktywnosci dla przycisku polecen btnObliczWartoscSzeregu
            //
            btnObliczWartoscSzeregu.Enabled = false;


        }



        #region Metody pomocnicze dla obsługi przycisków funkcjonalnych

        bool Pobierz_X(out float X)
        {// dla "potrzeb technicznych" przypisujemy wartosci parametrom wyjsciowym
            X  = 0.00F;
            //pobranie wartosci zmiennej niezaleznej X
            if (!float.TryParse(txtX.Text, out X))
            {// sygnalizujemy zapalajac kontrolke ErrorProvider
                errorProvider1.SetError(txtX, "ERROR: w zapisie wartości zmiennej niezależnej " +
                    "X wystąpił niedozwolony znak");
                //Przerywamy dalsze pobieranie danych wejsciowych
                return false;
            }

            if ((X <= DgPrzedzialuX) || (X >= GgPrzedzialuX))
            {//sygnalizacja bledu
                errorProvider1.SetError(txtX, "ERROR: nie jest spełniony warunek " +
                    "wejściowy dla X");

                //zwrotne przekazanie informacji o braku bledu
                return false;

            }
            txtX.Enabled = false;
            return true;
        }
        bool Pobierz_Eps(out float Eps)
        { 
            Eps = 0.00F;
            
             //pobranie dokladnosci obliczen Eps
            if (!float.TryParse(txtEps.Text, out Eps))
            {//sygnalizacja bledu
                errorProvider1.SetError(txtEps, "ERROR: w zapisie dokladności obliczeń " +
                    "Eps wystąpił niedozwolony znak");
                //Przerywamy dalsze pobieranie danych wejsciowych
                return false;

            }

            //sprawdzenie czy jest spelniony warunek wejsciowy dla Eps
            if ((Eps <= 0.00F) || (Eps >= 1.00F))
            {//sygnalizacja bledu
                errorProvider1.SetError(txtEps, "ERROR: nie jest spełniony warunek" +
                    "wejsciowy dla Eps: 0.0 < Eps < 1.0");

                //zwrotne przekazanie informacji o braku bledu
                return false;

            }
            //ustawienie stanu braku aktywnosci dla kontrolki bledu
            txtEps.Enabled = false;
            //zwrotne przekazanie informacji o braku bledu
            return true;
        }

        float ObliczWartoscSzeregu(float X, float Eps, out ushort n)
        {// dla "potrzeb technicznych" przypisujemy wartosc domyslna parametrowi wyjsciowemu
            n = 0;
            //deklaracje i ustalenie warunkow brzegowych
            float Suma = 0.0F;
            float w = 1.0F;
            //iteracyjne sumowanie wyrazow szeregu
            do
            {
                Suma = Suma + w;
                n++;
                //obliczenie wartosci ntego wyrazu szeregu
                w = w * (-1) * X / n;
            }
            while (Math.Abs(w) > Eps);

            //zwrocenie obliczonej wartosci szeregu
            return Suma;

        }

        float SumaSzereguPotęgowego (float X, float Eps, out ushort k)
        {
            k = 0;
            float w = 1.0F;
            float S = w;

            while (Math.Abs(w) > Eps)
            {
                k++;
                w = w * (-1) * X / k;

                S = S + w;
            };
            return S;
        }

        bool Pobranie_Eps_Xd_Xg_H(out float Xd, out float Xg, out float H, out float Eps)
        {//przypisanie wartosci domyslnychh dla parametru wyjsciowych
            Xd = Xg = H = Eps = 0.0F;
            // pobranie Xd
            if (!float.TryParse(txtXd.Text, out Xd))
            {// byl blad to go sygnalizujemy zapalac kontrolke errorProvider
                errorProvider1.SetError(txtXd, "ERROR: w zapisie Xd wystapil niedozwolony znak");
                //przerwanie pobierania danych
                return false;
            }
            // sprawdzenie czy pobrane Xd nalezy do przedzialu zbieznosci mojego szeregu
            if ((Xd < DgPrzedzialuX) || (Xg > GgPrzedzialuX))
            {//jest blad pobrane XD nie nalezy do przedzialu zbieznosci mojego szeregu
                errorProvider1.SetError(txtXd, "ERROR: podane Xd nie nalezy do przedzialu zbieznosci szeregu" +
                    "float.MinValue < XD < float.MaxValue");
                //przerwanie pobierania danych
                return false;

            }
            //pobranie Xg
            if (!float.TryParse(txtXg.Text, out Xg))
            {// byl blad to go sygnalizujemy zapalac kontrolke errorProvider
                errorProvider1.SetError(txtXg, "ERROR: w zapisie Xg wystapil niedozwolony znak");
                //przerwanie pobierania danych
                return false;

            }
            // sprawdzenie czy pobrane XD nalezy do przedzialu zbieznosci mojego szeregu
            if ((Xg < DgPrzedzialuX) || (Xg > GgPrzedzialuX))
            {//jest blad pobrane XD nie nalezy do przedzialu zbieznosci mojego szeregu
                errorProvider1.SetError(txtXd, "ERROR: podane XG nie nalezy do przedzialu zbieznosci szeregu" +
                    "float.MinValue < XG < float.MaxValue");
                //przerwanie pobierania danych
                return false;
            }
            // sprawdzanie poprawnosci kolejnosci zapisu granic przedzialu
            if (Xg < Xd)
            {// byl blad to go sygnalizujemy zapalac kontrolke errorProvider
                errorProvider1.SetError(txtXg, "ERROR: Granice przedzialu zostaly zapisane odwrotnie: " +
                    "musi byc spelniony tzw. warunek wejsciowy: XD <= XG");
                //przerwanie pobierania danych
                return false;

            }
            //tutaj XD i XG sa OK!
            //ustawienie stanu braku aktywnosci dla kontrolek txtXD oraz txtXG
            txtXd.Enabled = false;
            txtXg.Enabled = false;
            //pobranie przyrostu H zmian wartosci zmiennej niezaleznej X
            if (!float.TryParse(txtH.Text, out H))
            {// byl blad to go sygnalizujemy zapalac kontrolke errorProvider
                errorProvider1.SetError(txtH, "ERROR: w zapisie 'H' wystapil niedozwolony znak");
                //przerywamy pobieranie danych
                return false;
            }
            //sprawdzenie tzw. warunku wejsciowego
            if (H >= (Xg - Xd))
            {// jest blad to go sygnalizujemy
                errorProvider1.SetError(txtH, "ERROR: podana wartosc 'H' nie spelnia warunku wejsciowego: H < (XG - XD)");
                return false;

            }
            // pobranie dokladnosci obliczen Eps
            if (!float.TryParse(txtEps.Text, out Eps))
            {// jest blad to go sygnalizujemy
                errorProvider1.SetError(txtEps, "ERROR: W zapisie dokladnosci obliczen Eps wystapil niedozwolony znak");
                //przerywamy pobieranie danych
                return false;

            }
            // sprawdzanie tzw. warunku wejsciowego dla dokladnosci obliczen
            if ((Eps <= 0.0F) || (Eps >= 1.0F))
            {
                // jest blad to go sygnalizujemy
                errorProvider1.SetError(txtH, "ERROR: podana wartosc 'Eps' nie spelnia warunku wejsciowego: 0.0 < Eps < 1.0");
                return false;
            }


            //zwrotne przekazanie informacji ze nie bylo bledu podczas pobierania danych
            return true;
        }

        void TablicowanieWartościSzeregu(float Xd, float Xg, float H, float Eps, out float[,] TWS)

        {//przypisanie domyslnej wartosci  dla parametru wyjsciowego
            TWS = null;
            // wyznaczenie liczby podprzedzialow w przedziale: [XG, XG]
            int n = (int)((Xg - Xd) / H + 1);
            //utworzenie egzemplarza tablicy TWS
            TWS = new float[n + 1, 3];
            //tablicowanie wartosci szeregu
            // deklaracja zmiennych pomocniczych
            float X;
            int i;
            ushort LicznikZsumowanychWyrazow;
            for (X = Xd, i = 0; i < TWS.GetLength(0); i++, X = Xd + i * H)  // nie piszemy: X= X+h
            {
                // wpisywanie wynikow tablicowania do tablicy TWS
                TWS[i, 0] = X;
                TWS[i, 1] = ObliczWartoscSzeregu(X, Eps, out LicznikZsumowanychWyrazow);
                TWS[i, 2] = LicznikZsumowanychWyrazow;
            }
        }

        void WpisanieWynikówDoKonotrolkiDataGridView(float[,] TWS, DataGridView dgvTWS)
        {
            //"wyczyszczenie" kontrolki DataGridView
            dgvTWS.Rows.Clear();
            //przepisywanie zawartosci tablicy TWS do kontrolki dgvTWS
            for (int i = 0; i < TWS.GetLength(0); i++)
            {// dodanie nowego (pustego) wiersza do kontrolki DataGridView
                dgvTWS.Rows.Add();
                //wpisywanie kolejnych komorek z tablicy TWS do nowego wiersza
                dgvTWS.Rows[i].Cells[0].Value = string.Format("{0:0.00}", (int)TWS[i, 0]);
                dgvTWS.Rows[i].Cells[1].Value = string.Format("{0:0.0000}", (int)TWS[i, 1]);
                dgvTWS.Rows[i].Cells[2].Value = string.Format("{0}", (int)TWS[i, 2]);
            }
        }

        void WpisanieWynikówDoKontrolkiChart(float[,] TWS, Chart chtWykresSzeregu)
        {// obramowanie kontrolki chart
            chtWykresSzeregu.BorderlineWidth = 2;
            chtWykresSzeregu.BorderlineColor = Color.Red;
            chtWykresSzeregu.BorderlineDashStyle = ChartDashStyle.DashDotDot;
            // tytuł wykresu
            chtWykresSzeregu.Titles.Add("Wykres zmian wartości szeregu S(X)");
            // legenda pod wykresem
            chtWykresSzeregu.Legends.FindByName("Legend1").Docking = Docking.Bottom;
            // ustawienie koloru tła
            chtWykresSzeregu.BackColor = Color.LightSkyBlue;
            chtWykresSzeregu.ChartAreas[0].AxisX.Title = "Wartości X";
            chtWykresSzeregu.ChartAreas[0].AxisY.Title = "Wartości S(X)";
            // sformatowanie opisu osi X 
            chtWykresSzeregu.ChartAreas[0].AxisX.LabelStyle.Format = "{0:f2}";
            //sformatowanie opisu osi y
            chtWykresSzeregu.ChartAreas[0].AxisY.LabelStyle.Format = "{0:f2}";

            //formatowanie danych
            chtWykresSzeregu.Series.Clear();
            chtWykresSzeregu.Series.Add("Seria 0");

            chtWykresSzeregu.Series[0].XValueMember = "X";
            chtWykresSzeregu.Series[0].YValueMembers = "Y";

            chtWykresSzeregu.Series[0].IsVisibleInLegend = true;
            chtWykresSzeregu.Series[0].Name = "Wartość szeregu potęgowego S(X)";
            chtWykresSzeregu.Series[0].ChartType = SeriesChartType.Line;// wykres liniowy
            chtWykresSzeregu.Series[0].Color = Color.Black;
            chtWykresSzeregu.Series[0].BorderDashStyle = ChartDashStyle.Solid;
            chtWykresSzeregu.Series[0].BorderWidth = 1;

            // wpisanie wspołrzędnych
            for (int i = 0; i < TWS.GetLength(0); i++)
                chtWykresSzeregu.Series[0].Points.AddXY(TWS[i, 0], TWS[i, 1]);
            
        }


        #endregion

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnResetuj_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnWizualizacjaTabelaryczna_Click(object sender, EventArgs e)
        {
            dgvTWS.Show();
            errorProvider1.Dispose();
     
            //deklaracje zmiennych dla przechowania pobranych danych wejsciowych z formularza
            float Eps, Xd, Xg, H;

            if (!Pobranie_Eps_Xd_Xg_H(out Xd, out Xg, out H, out Eps))
            {
                return;
            }
            // 2) Stablicowanie szeregu w podanych przedziale: [Xd, Xg]
            //sprawdzenie czy egzemplarz tablicy TWS został juz utworzony
            if (TWS is null) // nie pisze TWS== null
                TablicowanieWartościSzeregu(Xd, Xg, H, Eps, out TWS);

            // 3) Przepisanie danych z TWS (Tablica Wartosci Szeregu) do kontrolki DataGridView
            WpisanieWynikówDoKonotrolkiDataGridView(TWS, dgvTWS);
            //odsloniecie kontrolkidgvTWS
            dgvTWS.Visible = true;
            // ustawienie stanu braku aktywnosci dla przycisku polecen btnWizualizacjaTabelaryczna
            btnWizualizacjaTabelaryczna.Enabled = false;
        }

        private void txtSumaSzeregu_TextChanged(object sender, EventArgs e)
        {

        }

        private void zapiszTabelaryczneZestawienieZmianWartościSzereguPotęgowegoWPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
            }
            
           
        }

        private void SzeregLaboratoryjny_Load(object sender, EventArgs e)
        {

        }

        private void btnWizualizacjaGraficzna_Click(object sender, EventArgs e)
        {
            chtWykresSzeregu.Show();
            errorProvider1.Dispose();
            float Xd, Xg, H, Eps;
            if (!Pobranie_Eps_Xd_Xg_H(out Xd, out Xg, out H, out Eps))
                return;
            if (TWS is null)
                TablicowanieWartościSzeregu(Xd, Xg, H, Eps, out TWS);

            WpisanieWynikówDoKontrolkiChart(TWS, chtWykresSzeregu);
            dgvTWS.Visible = false;
            chtWykresSzeregu.Visible = true;
            btnWizualizacjaGraficzna.Enabled = false;

        }

        private void wczytajZPlikuTabelaryczneZestawienieZmianWartościSzereguPotęgowegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();

            if(!(TWS is null))
            {
                DialogResult OknoMessage = MessageBox.Show("UWAGA: egzemplarz tablicy TWS już istnieje!" +
                    "\r\nCzy bieżący egzemplarz tablicy TWS ma być skasowany i w jego miejsce ma być utworzony nowy egzemplarz, " +
                    "do którego mają zostać 'wczytane' elementy TWS z pliku? " +
                    "\r\n - kliknij przycisk poleceń 'Nie' dla skasowania polecenia wczytania elementów " +
                    "tablicy TWS z pliku ", "Okno ostrzeżenia", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (OknoMessage == DialogResult.Yes)
                    TWS = null;
                else
                {
                    MessageBox.Show("Polecenie odczytania (pobrania) elementów tablicy" +
                        " TWS z pliku zostało anulowane (skasowane!)");
                    return;
                }
            }

            OpenFileDialog OknoWyboruPlikuDoOdczytu = new OpenFileDialog();

            OknoWyboruPlikuDoOdczytu.Filter = "txtfiles (*.txt)|*.txt|All files(*.*)|*.*";
            OknoWyboruPlikuDoOdczytu.FilterIndex = 1;

            OknoWyboruPlikuDoOdczytu.RestoreDirectory = true;
            OknoWyboruPlikuDoOdczytu.InitialDirectory = "H:\\";
            OknoWyboruPlikuDoOdczytu.Title = "Wybór pliku do odczytu TWS (Tabeli Wartości Szeregu)";

            if (OknoWyboruPlikuDoOdczytu.ShowDialog() == DialogResult.OK)
            {
                string WierszDanych;
                string[] DaneWiersza;
                ushort LicznikWierszy;
                System.IO.StreamReader PlikZnakowy = new
                    System.IO.StreamReader(OknoWyboruPlikuDoOdczytu.FileName);
                LicznikWierszy = 0;
                while (!((WierszDanych = PlikZnakowy.ReadLine()) is null))
                    LicznikWierszy++;
                PlikZnakowy.Close();

                TWS = new float[LicznikWierszy, 3];
                PlikZnakowy = new System.IO.StreamReader(OknoWyboruPlikuDoOdczytu.FileName);

                try
                {
                    int NrWiersza = 0;
                    while (!((WierszDanych = PlikZnakowy.ReadLine()) is null))
                    {
                        DaneWiersza = WierszDanych.Split(';');

                        DaneWiersza[0].Trim();
                        DaneWiersza[1].Trim();
                        DaneWiersza[2].Trim();

                        TWS[NrWiersza, 0] = float.Parse(DaneWiersza[0]);
                        TWS[NrWiersza, 1] = float.Parse(DaneWiersza[1]);
                        TWS[NrWiersza, 2] = float.Parse(DaneWiersza[2]);
                        NrWiersza++;
                    }
                    WpisanieWynikówDoKonotrolkiDataGridView(TWS, dgvTWS);
                    chtWykresSzeregu.Visible = false;
                    dgvTWS.Visible = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: błąd operacji (działania) na pliku " +
                        "(wyświetlony komunikat): --> " + ex.Message);
                }
                finally
                {
                    PlikZnakowy.Close();
                    PlikZnakowy.Dispose();
                }
            }
            else
                MessageBox.Show("Plik do odczytu tablicy TWS nie został wybrany i obsługa" +
                    " polecenia: 'Odczytanie stablicowanego szeregu z pliku' (z menu poziomowego" +
                    " Plik) nie może być zrealizowana");
        }

        private void wyjścieExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
         

        }

        #region błędna próba 

        private void żółtyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void zielonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void różowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void szaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void białyToolStripMenuItem_Click(object sender, EventArgs e)
        {
       }

        private void czerwonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
      }

        private void pomarańczowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
       }

        private void żółtyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void zielonyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
      }

        private void granatowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
      }

        private void fioletowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
       }
        #endregion

        #region typ wykresu
        private void wykresLiniowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chtWykresSzeregu.Series[0].ChartType = SeriesChartType.Line;
        }

        private void wykresPunktowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chtWykresSzeregu.Series[0].ChartType = SeriesChartType.Point;
        }

        private void wykresKolumnowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chtWykresSzeregu.Series[0].ChartType = SeriesChartType.Column;
        }

        private void wykresSłupkowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chtWykresSzeregu.Series[0].ChartType = SeriesChartType.Bar;
        }


        #endregion

        #region styl linii wykresu

        private void liniaKreskowaDashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chtWykresSzeregu.Series[0].BorderDashStyle = ChartDashStyle.Dash;
        }

        private void liniaKreskowoKropkowaDashDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chtWykresSzeregu.Series[0].BorderDashStyle = ChartDashStyle.DashDot;
        }

        private void liniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chtWykresSzeregu.Series[0].BorderDashStyle = ChartDashStyle.DashDotDot;
        }

        private void liniaKropkowaDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chtWykresSzeregu.Series[0].BorderDashStyle = ChartDashStyle.Dot;
        }

        private void liniaCiaglaSolidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chtWykresSzeregu.Series[0].BorderDashStyle = ChartDashStyle.Solid;
        }



        #endregion

        #region grubosc linii wykresu

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            chtWykresSzeregu.Series[0].BorderWidth = 1;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            chtWykresSzeregu.Series[0].BorderWidth = 2;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            chtWykresSzeregu.Series[0].BorderWidth = 3;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            chtWykresSzeregu.Series[0].BorderWidth = 4;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            chtWykresSzeregu.Series[0].BorderWidth = 5;
        }


        #endregion

        #region błędna próba 2

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void msOutlookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void arialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
     
        }

        private void comicSansToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.dgvTWS.DefaultCellStyle.Font = new Font("Comic Sans MS", 10);
        }

        private void msOutlookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.dgvTWS.DefaultCellStyle.Font = new Font("MsOutlook", 10);
        }

        private void timesNewRomanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void arialToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void comicSansToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void msOutlookToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void timesNewRomanToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region czcionki
        private void czcionkaOpisuWykresuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                chtWykresSzeregu.ChartAreas[0].AxisX.LabelStyle.Font = fontDialog1.Font;
                chtWykresSzeregu.ChartAreas[0].AxisY.LabelStyle.Font = fontDialog1.Font;
                chtWykresSzeregu.Series[0].Font = fontDialog1.Font;
            }

        }

        private void kontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                dgvTWS.Font = fontDialog1.Font;
            }
        }

        private void czcionkaOpisuFormularzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
                label2.Font = fontDialog1.Font;
                label3.Font = fontDialog1.Font;
                label4.Font = fontDialog1.Font;
                label5.Font = fontDialog1.Font;
                label6.Font = fontDialog1.Font;
                label7.Font = fontDialog1.Font;
                label8.Font = fontDialog1.Font;
                btnObliczWartoscSzeregu.Font = fontDialog1.Font;
                btnWizualizacjaGraficzna.Font = fontDialog1.Font;
                btnWizualizacjaTabelaryczna.Font = fontDialog1.Font;
                btnResetuj.Font = fontDialog1.Font;

            }
        }
        #endregion

        #region kolory
        private void kolorTłaWykresuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                chtWykresSzeregu.BackColor = colorDialog1.Color;
            }
        }

        private void kolorLiniiWykresuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                chtWykresSzeregu.Series[0].Color = colorDialog1.Color;
            }
        }

        #endregion
    }

}

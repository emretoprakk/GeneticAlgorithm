using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GenetikAlgoritma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private List<Chromosome> GenerateInitialPopulation(int populationSize) 
        {
            List<Chromosome> population = new List<Chromosome>();
            Random random = new Random();

            for (int i = 0; i < populationSize; i++) 
            {
                double x = random.NextDouble() * 10 - 5; //-5 ≤ x ≤ 5 
                double y = random.NextDouble() * 10 - 5; 
                population.Add(new Chromosome(x, y));
            }

            return population;
        }

        private double EvaluateFitness(Chromosome chromosome) 
        {
            double x = chromosome.X; 
            double y = chromosome.Y;

            double fitness = -20 * Math.Exp(-0.2 * Math.Sqrt(0.5 * (x * x + y * y)))
                             - Math.Exp(0.5 * (Math.Cos(2 * Math.PI * x) + Math.Cos(2 * Math.PI * y)))
                             + Math.E + 20;

            return fitness;
        }

        private Chromosome TournamentSelection(List<Chromosome> population, int tournamentSize) 
        {
            List<Chromosome> tournament = new List<Chromosome>();
            Random random = new Random();

            for (int i = 0; i < tournamentSize; i++) 
            {
                int index = random.Next(population.Count);
                tournament.Add(population[index]);
            }
            //rastgele kromozom seçilir ve en iyi uygunluk değerine sahip olan seçilir.
            return tournament.OrderByDescending(c => EvaluateFitness(c)).First(); 
        }

        private Chromosome Crossover(Chromosome parent1, Chromosome parent2) 
        {
            Random random = new Random();
            int crossoverPoint = random.Next(2); // 0 veya 1

            double x = crossoverPoint == 0 ? parent1.X : parent2.X; 
            double y = crossoverPoint == 0 ? parent2.Y : parent1.Y;

            return new Chromosome(x, y); //Rastgele bir çaprazlama noktası seçilir ve çocuk kromozom oluşturulur.
        }

        private void Mutate(Chromosome chromosome, double mutationRate) 
        {
            Random random = new Random();

            if (random.NextDouble() < mutationRate)
            {
                chromosome.X = random.NextDouble() * 10 - 5; 
            }

            if (random.NextDouble() < mutationRate)
            {
                chromosome.Y = random.NextDouble() * 10 - 5; 
            }
        }

        private List<Chromosome> CreateNewPopulation(List<Chromosome> oldPopulation, int newPopulationSize, double mutationRate) 
        {
            List<Chromosome> newPopulation = new List<Chromosome>();

            while (newPopulation.Count < newPopulationSize)
            {
                Chromosome parent1 = TournamentSelection(oldPopulation, 2);
                Chromosome parent2 = TournamentSelection(oldPopulation, 2);

                Chromosome offspring = Crossover(parent1, parent2);
                Mutate(offspring, mutationRate);

                newPopulation.Add(offspring);
            }

            return newPopulation;
        }

        private void RunGeneticAlgorithm(int populationSize, double crossoverRate, double mutationRate, int elitismCount, int generationCount) 
        {
            List<Chromosome> population = GenerateInitialPopulation(populationSize);

            for (int i = 0; i < generationCount; i++)
            {
                // Uygunluk değerlerini hesapla
                foreach (Chromosome chromosome in population)
                {
                    chromosome.Fitness = EvaluateFitness(chromosome);
                }

                // En iyi bireyleri seç
                List<Chromosome> newPopulation = new List<Chromosome>();
                population = population.OrderByDescending(c => c.Fitness).ToList();
                for (int j = 0; j < elitismCount; j++)
                {
                    newPopulation.Add(population[j]);
                }

                // Yeni popülasyonu oluştur
                newPopulation.AddRange(CreateNewPopulation(population, populationSize - elitismCount, mutationRate));
                population = newPopulation;
            }

            // En iyi çözümü ve uygunluk değerini göster
            Chromosome bestSolution = population.OrderByDescending(c => c.Fitness).First();
            richSonuc.Text = $"En İyi Çözüm:\n\n" +
                 $"x = {bestSolution.X}\n" +
                 $"y = {bestSolution.Y}\n" +
                 $"Fitness = {bestSolution.Fitness}";

            // Yakınsama grafiğini çiz
            DrawConvergenceGraph(population);
        }

        private void DrawConvergenceGraph(List<Chromosome> population)
        {
            chart1.Series[0].Points.Clear();

            for (int i = 0; i < population.Count; i++)
            {
                chart1.Series[0].Points.AddXY(i, population[i].Fitness);
            }

            // Grafik ayarları
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[0].Color = System.Drawing.Color.Blue;

            chart1.ChartAreas[0].AxisX.Title = "Generation";
            chart1.ChartAreas[0].AxisY.Title = "Fitness";
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Interval = 50;

            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;

            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
        }

        public class Chromosome
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Fitness { get; set; }

            public Chromosome(double x, double y)
            {
                X = x;
                Y = y;
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {

            if (numericUpDownPopulasyon.Value == 0 ||
                numericUpDownCaprazlama.Value == 0 ||   
                numericUpDownMutasyon.Value == 0 ||
                numericUpDownSeckinlik.Value == 0 ||
                numericUpDownJenerasyon.Value == 0)
            {
                MessageBox.Show("Lütfen tüm değerleri girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int populationSize = (int)numericUpDownPopulasyon.Value;
            double crossoverRate = (double)numericUpDownCaprazlama.Value;
            double mutationRate = (double)numericUpDownMutasyon.Value;
            int elitismCount = (int)numericUpDownSeckinlik.Value;
            int generationCount = (int)numericUpDownJenerasyon.Value;

            RunGeneticAlgorithm(populationSize, crossoverRate, mutationRate, elitismCount, generationCount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            numericUpDownPopulasyon.Value = 0;
            numericUpDownCaprazlama.Value = 0;
            numericUpDownMutasyon.Value = 0;
            numericUpDownSeckinlik.Value = 0;
            numericUpDownJenerasyon.Value = 0;
            richSonuc.Text = "";
            chart1.Series[0].Points.Clear();
        }

        private void btnIpucu_Click(object sender, EventArgs e)
        {
            string message = "Lütfen aşağıdaki değer aralıklarında değerler giriniz:\n\n" +
                     "Popülasyon Boyutu: 50 - 100\n" +
                     "Çaprazlama Oranı: 0.6 - 0.9\n" +
                     "Mutasyon Oranı: 0.01 - 0.1\n" +
                     "Seçkinlik Oranı veya Adedi: 2 - 5\n" +
                     "Jenerasyon Sayısı: 100 - 500";

    MessageBox.Show(message, "Değer Aralıkları", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

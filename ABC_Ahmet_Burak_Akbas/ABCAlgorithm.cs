using System.Collections.Generic;
using System.Linq;
using System;
using ABC_Ahmet_Burak_Akbas;

public class ABCAlgorithm
{
    public int ColonySize { get; set; }
    public int Dimension { get; set; }
    public int Limit { get; set; }
    public int MaxIterations { get; set; }
    public double LowerBound { get; set; }
    public double UpperBound { get; set; }
    public List<Bee> Bees { get; set; }
    public List<double> Convergence { get; set; }
    public double[] BestSolution { get; set; }
    public double BestFitness { get; set; }
    public List<double[]> BestPositions { get; set; }

    private Random rnd = new Random();

    public ABCAlgorithm(int colonySize, int dimension, int limit, int maxIterations, double lowerBound, double upperBound)
    {
        ColonySize = colonySize;
        Dimension = dimension;
        Limit = limit;
        MaxIterations = maxIterations;
        LowerBound = lowerBound;
        UpperBound = upperBound;
        Bees = new List<Bee>();
        Convergence = new List<double>();
        BestSolution = new double[dimension];
        BestFitness = double.MaxValue;
        BestPositions = new List<double[]>();
    }

    public void Run()
    {
        Initialize();
        for (int iter = 0; iter < MaxIterations; iter++)
        {
            EmployedBeesPhase();
            OnlookerBeesPhase();
            ScoutBeesPhase();
            UpdateBest();
            Convergence.Add(BestFitness);
            BestPositions.Add((double[])BestSolution.Clone());
        }
    }

    private void Initialize()
    {
        Bees.Clear();
        for (int i = 0; i < ColonySize; i++)
        {
            Bee bee = new Bee(Dimension);
            for (int d = 0; d < Dimension; d++)
                bee.Position[d] = LowerBound + rnd.NextDouble() * (UpperBound - LowerBound);
            bee.Fitness = ObjectiveFunction.Evaluate(bee.Position);
            Bees.Add(bee);
        }
        UpdateBest();
    }

    private void EmployedBeesPhase()
    {
        for (int i = 0; i < ColonySize; i++)
        {
            Bee bee = Bees[i];
            double[] newPos = (double[])bee.Position.Clone();
            int k;
            do { k = rnd.Next(ColonySize); } while (k == i);
            int j = rnd.Next(Dimension);
            double phi = rnd.NextDouble() * 2 - 1;
            newPos[j] = bee.Position[j] + phi * (bee.Position[j] - Bees[k].Position[j]);
            newPos[j] = Math.Max(LowerBound, Math.Min(UpperBound, newPos[j]));

            double newFitness = ObjectiveFunction.Evaluate(newPos);
            if (newFitness < bee.Fitness)
            {
                bee.Position = newPos;
                bee.Fitness = newFitness;
                bee.Trial = 0;
            }
            else
            {
                bee.Trial++;
            }
        }
    }

    private void OnlookerBeesPhase()
    {
        double[] fits = Bees.Select(b => 1.0 / (1.0 + b.Fitness)).ToArray();
        double totalFit = fits.Sum();

        for (int t = 0; t < ColonySize; t++)
        {
            double r = rnd.NextDouble() * totalFit;
            double cum = 0.0;
            int iSelected = 0;
            for (; iSelected < ColonySize; iSelected++)
            {
                cum += fits[iSelected];
                if (cum >= r) break;
            }

            Bee bee = Bees[iSelected];
            double[] newPos = (double[])bee.Position.Clone();
            int k;
            do { k = rnd.Next(ColonySize); } while (k == iSelected);
            int j = rnd.Next(Dimension);
            double phi = rnd.NextDouble() * 2.0 - 1.0;

            newPos[j] = bee.Position[j] + phi * (bee.Position[j] - Bees[k].Position[j]);
            newPos[j] = Math.Max(LowerBound, Math.Min(UpperBound, newPos[j]));

            double newFitness = ObjectiveFunction.Evaluate(newPos);
            if (newFitness < bee.Fitness)
            {
                bee.Position = newPos;
                bee.Fitness = newFitness;
                bee.Trial = 0;
            }
            else
            {
                bee.Trial++;
            }
        }
    }

    private void ScoutBeesPhase()
    {
        foreach (var bee in Bees)
        {
            if (bee.Trial >= Limit)
            {
                for (int d = 0; d < Dimension; d++)
                    bee.Position[d] = LowerBound + rnd.NextDouble() * (UpperBound - LowerBound);
                bee.Fitness = ObjectiveFunction.Evaluate(bee.Position);
                bee.Trial = 0;
            }
        }
    }

    private void UpdateBest()
    {
        var bestBee = Bees.OrderBy(b => b.Fitness).First();
        if (bestBee.Fitness < BestFitness)
        {
            BestFitness = bestBee.Fitness;
            Array.Copy(bestBee.Position, BestSolution, Dimension);
        }
    }
}


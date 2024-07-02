using System;
using System.Collections.Generic;

public class SalesForecaster
{
    public List<(string State, decimal Sales)> ApplyPercentageIncrease(List<(string State, decimal Sales)> salesData, decimal percentageIncrease)
    {
        var forecastedSales = new List<(string State, decimal Sales)>();
        foreach (var sale in salesData)
        {
            var increasedSales = sale.Sales + (sale.Sales * percentageIncrease / 100);
            forecastedSales.Add((sale.State, increasedSales));
        }
        return forecastedSales;
    }

    public List<(string State, decimal Sales)> ApplyIndividualPercentageIncrease(List<(string State, decimal Sales)> salesData, Dictionary<string, decimal> percentageIncreases)
    {
        var forecastedSales = new List<(string State, decimal Sales)>();
        foreach (var sale in salesData)
        {
            if (percentageIncreases.TryGetValue(sale.State, out decimal percentageIncrease))
            {
                var increasedSales = sale.Sales + (sale.Sales * percentageIncrease / 100);
                forecastedSales.Add((sale.State, increasedSales));
            }
        }
        return forecastedSales;
    }
}

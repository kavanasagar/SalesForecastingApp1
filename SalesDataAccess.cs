using System;
using System.Data.SqlClient;
using System.Collections.Generic;

public class SalesDataAccess
{
    private string connectionString = "LAPTOP-S3NB9LAS\\SQLEXPRESS02";

    public List<(string State, decimal Sales)> GetSalesByYear(int year)
    {
        var sales = new List<(string State, decimal Sales)>();
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = @"
                SELECT o.State, SUM(p.Sales - ISNULL(r.Sales, 0)) AS Sales
                FROM Orders o
                INNER JOIN Products p ON o.ProductID = p.ProductID
                LEFT JOIN Returns r ON o.OrderID = r.OrderID
                WHERE YEAR(o.OrderDate) = @year
                GROUP BY o.State";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@year", year);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                sales.Add((reader.GetString(0), reader.GetDecimal(1)));
            }
        }
        return sales;
    }

    public void InsertForecastedSales(string state, decimal percentageIncrease, decimal sales)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO ForecastedSales (State, PercentageIncrease, Sales) VALUES (@state, @percentageIncrease, @sales)", conn);
            cmd.Parameters.AddWithValue("@state", state);
            cmd.Parameters.AddWithValue("@percentageIncrease", percentageIncrease);
            cmd.Parameters.AddWithValue("@sales", sales);
            cmd.ExecuteNonQuery();
        }
    }

    public List<string> GetStates()
    {
        var states = new List<string>();
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT DISTINCT State FROM Orders";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                states.Add(reader.GetString(0));
            }
        }
        return states;
    }
}

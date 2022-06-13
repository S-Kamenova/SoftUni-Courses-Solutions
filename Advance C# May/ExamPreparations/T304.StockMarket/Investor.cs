using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
            Portfolio = new List<Stock>();
        }

        public List<Stock> Portfolio { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }

        public int count { get { return Portfolio.Count; } }

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000m && MoneyToInvest >= stock.PricePerShare)
            {
                Portfolio.Add(stock);
                MoneyToInvest -= stock.PricePerShare;
            }
        }

        public string SellStock(string companyName, decimal sellPrice)
        {
            if (!Portfolio.Exists(x => x.CompanyName == companyName))
            {
                return $"{companyName} does not exist.";
            }
            else if (Portfolio.Any(x => x.CompanyName == companyName && x.PricePerShare >= sellPrice))
            {
                return $"Cannot sell {companyName}.";
            }
            else
            {
                var company = Portfolio.FirstOrDefault(x => x.CompanyName == companyName);
                Portfolio.Remove(company);
                MoneyToInvest += sellPrice;
                return $"{companyName} was sold.";
            }

        }

        public Stock FindStock(string companyName)
        {
            Stock findStock = Portfolio.FirstOrDefault(x => x.CompanyName == companyName);
            return findStock;
        }

        public Stock FindBiggestCompany()
        {
            return Portfolio.OrderByDescending(x => x.MarketCapitalization).FirstOrDefault();
        }

        public string InvestorInformation()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"The investor {FullName} with a broker {BrokerName} has stocks:");
            foreach (var stock in Portfolio)
            {
                result.AppendLine(stock.ToString());
            }
            return result.ToString().TrimEnd();
        }
    }
}

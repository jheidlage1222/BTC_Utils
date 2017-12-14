using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ForecastGenerator.Classes
{
    public class BitcoinAPIJson
    {

        public class Bpi
        {
            public EUR EUR { get; set; }
            public GBP GBP { get; set; }
            public USD USD { get; set; }
        }

        public class EUR
        {
            public string code { get; set; }
            public string description { get; set; }
            public string rate { get; set; }
            public float rate_float { get; set; }
            public string symbol { get; set; }
        }

        public class GBP
        {
            public string code { get; set; }
            public string description { get; set; }
            public string rate { get; set; }
            public float rate_float { get; set; }
            public string symbol { get; set; }
        }

        public class Rootobject
        {
            //Should be this -> USD -> rate (or rate_float) idk.
            public Bpi bpi { get; set; }

            public string chartName { get; set; }
            public string disclaimer { get; set; }
            public Time time { get; set; }
        }

        public class Time
        {
            //use this as the day.
            public string updated { get; set; }
            public DateTime updatedISO { get; set; }
            public string updateduk { get; set; }
        }
        public class USD
        {
            public string code { get; set; }
            public string description { get; set; }
            public string rate { get; set; }
            public float rate_float { get; set; }
            public string symbol { get; set; }
        }
    }

    public class ForecastDTO
    {
        //
        public double GetInitialBTCAmount
        {
            get
            {
                return CurrentBTCValue / PrincipalAmount;
            }
        }

        public double AvgDailyChange;

        public double BuyFee;

        //
        public double CurrentBTCValue;

        public double FinishValue;

        public double MinValue;

        //Length, start, finish, min, max, avg daily change.  Num Increase days, num decrease days.  
        //Take in current value of btc, total contribution, buy fee, sell fee.
        public int NumDays = 0;
        public int NumLossDays = 0;
        public int NumPositiveDays = 0;
        public double PrincipalAmount;
        public double SellFee;
        public double StartValue;
        //
        public void AddDataRow(HistoricalDataRow newRow)
        {
            historicalRows.Add(newRow);
        }

        public void AddDataRow(DateTime date, double openAmt, double highAmt, double lowAmt, double closeAmt)
        {
            historicalRows.Add(new HistoricalDataRow(date, openAmt, highAmt, lowAmt, closeAmt));
        }

        public HistoricalDataRow GetHistoricalRow(int rowIndex)
        {
            return historicalRows[rowIndex];
        }

        public HistoricalDataRow GetHistoricalRow(DateTime fromDate)
        {
            return historicalRows.Where(x => x.Date.Year == fromDate.Year && x.Date.Month == fromDate.Month && x.Date.Day == fromDate.Day).FirstOrDefault();
        }

        //
        public ForecastDTO(bool getCurrentBTCPrice)
        {
            if (getCurrentBTCPrice)
            {
                GetBTCValueFromAPI();
            }
        }

        //
        private List<HistoricalDataRow> historicalRows = new List<HistoricalDataRow>();
        private void GetBTCValueFromAPI()
        {
            HttpWebResponse response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://api.coindesk.com/v1/bpi/currentprice.json");

                request.KeepAlive = true;
                //request.Headers.Set(HttpRequestHeader.CacheControl, "max-age=0");
                //request.Headers.Add("Upgrade-Insecure-Requests", @"1");
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.96 Safari/537.36";
                request.Accept = "application/json,text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                //request.Headers.Add("DNT", @"1");
                //request.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, sdch");
                request.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.8");
                //request.Headers.Set(HttpRequestHeader.Cookie, @"__cfduid=d19f257a08148e5917e30ee57bd5f54cd1513215388; optimizelyEndUserId=oeu1513215388691r0.7878062218451718; optimizelySegments=%7B%7D; optimizelyBuckets=%7B%7D; __utmt=1; __utma=204792322.1519129792.1513215389.1513215389.1513215389.1; __utmb=204792322.1.10.1513215389; __utmc=204792322; __utmz=204792322.1513215389.1.1.utmcsr=google|utmccn=(organic)|utmcmd=organic|utmctr=(not%20provided); cX_S=jb5tdevypyj7xy8z; cX_P=jb5tdevz4c85ef64; cX_G=cx%3A3jrupjuharva93qf96psx35g5y%3A2skx34q6wby7e");
                response = (HttpWebResponse)request.GetResponse();
                //
                using (var responseBodyReader = new StreamReader(response.GetResponseStream()))
                {
                    string jsonString = responseBodyReader.ReadToEnd();
                    BitcoinAPIJson.Rootobject apiJsonObj = JsonConvert.DeserializeObject<BitcoinAPIJson.Rootobject>(jsonString);
                    this.CurrentBTCValue = double.Parse(apiJsonObj.bpi.USD.rate);
                }
                //
                response.Close();
            }

            catch (Exception ex)
            {
                Debug.WriteLine("Failed to get current BTC Value from API" + Environment.NewLine + ex.Message + Environment.NewLine + ex.StackTrace);
                throw new Exception("API Current BTC Value failed", ex);
            }

        }
        //
    }
    //
    public class HistoricalDataRow
    {
        //
        public double ChangeAmount
        {
            get { return CloseAmount - OpenAmount; }
        }

        public double CloseAmount;
        public DateTime Date;
        public double HighAmount;
        public double LowAmount;
        public double OpenAmount;
        //
        public HistoricalDataRow(DateTime date, double openAmt, double highAmt, double lowAmt, double closeAmt)
        {
            this.Date = date;
            this.OpenAmount = openAmt;
            this.HighAmount = highAmt;
            this.LowAmount = lowAmt;
            this.CloseAmount = closeAmt;
        }
    }
    //
}

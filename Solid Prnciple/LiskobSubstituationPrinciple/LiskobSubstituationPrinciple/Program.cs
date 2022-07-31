using System;

namespace LiskobSubstituationPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartTv smartTv = new SmartTv();
            smartTv = new Nippon();

            var ListOfOttApplication = smartTv.GetOttApplicationLit();
            var isWifiConnected = smartTv.GetWifiConnectedStatus();
            var displayResolution = smartTv.DisplayResoulation();

            Console.WriteLine("Ott --"+ ListOfOttApplication);
            Console.WriteLine("Wifi Cn --"+ isWifiConnected);
            Console.WriteLine("Dis res --"+ displayResolution);
        }
    }

    class SmartTv
    {
        public virtual string GetOttApplicationLit()
        {
            return "Youtube, Primve Video";
        }

        public virtual string GetWifiConnectedStatus()
        {
            return "Connected";
        }

        public virtual string DisplayResoulation()
        {
            return "HD";
        }
    }

    class LGTV : SmartTv
    {
        public override string GetOttApplicationLit()
        {
            return "Youtube, Prime Viewo, HBO+";
        }

        public override string GetWifiConnectedStatus()
        {
            return "Not Connected";
        }

        public override string DisplayResoulation()
        {
            return "FUll HD with 1920 * 1080";
        }
    }

    class Nippon: SmartTv
    {
        public override string GetOttApplicationLit()
        {
            throw new NotImplementedException();
        }

        public override string GetWifiConnectedStatus()
        {
            throw new NotImplementedException();
        }

        public override string DisplayResoulation()
        {
            return "Standard Quality";
        }
    }

}

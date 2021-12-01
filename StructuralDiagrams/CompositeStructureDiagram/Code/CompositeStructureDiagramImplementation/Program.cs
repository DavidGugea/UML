using System;

namespace CompositeStructureDiagramImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            SatReceiver sat = new SatReceiver();

            Console.WriteLine(sat.scartConnection.GetTvSignal("sender1"));
            Console.WriteLine(sat.scartConnection.GetTvSignal("sender2"));
            Console.WriteLine(sat.scartConnection.GetTvSignal("sender3"));
        }
    }
    public interface TvSignal
    {
        string GetTvSignal(string sender);
    }
    public class SatReceiver
    {
        private string signalSender1;
        private string signalSender2;
        private string GetSignalSender1() => signalSender1;
        private string GetSignalSender2() => signalSender2;

        public class ScartConnection : TvSignal
        {
            private readonly SatReceiver satReceiver;

            public ScartConnection(SatReceiver satReceiver) => this.satReceiver = satReceiver;

            public String GetTvSignal(string sender)
            {
                switch (sender)
                {
                    case "sender1":
                        return this.satReceiver.GetSignalSender1();
                    case "sender2":
                        return this.satReceiver.GetSignalSender2();
                    default:
                        return "Error";
                }
            }
        }

        public ScartConnection scartConnection { get; private set; }
        public SatReceiver()
        {
            signalSender1 = "Tv signal from sender 1";
            signalSender2 = "Tv signal from sender 2";
            scartConnection = new ScartConnection(this);
        }
    }
}

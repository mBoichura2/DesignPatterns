namespace DesignPatterns
{
    public class Memento
    {
        public string[] Time {  get; set; }
        public double[] TempSensor { get; set; }
        public double[] PHMeter { get; set; }
        public double[] TurbiditySensor { get; set; }
        public int Counter { get; set; }
        public Memento(string[] time, double[] tempSensor, double[] pHMeter, double[] turbiditySensor, int counter)
        {
            Time = (string[])time.Clone();
            TempSensor = (double[])tempSensor.Clone();
            PHMeter = (double[])pHMeter.Clone();
            TurbiditySensor = (double[])turbiditySensor.Clone();
            Counter = counter;
        }
    }
}

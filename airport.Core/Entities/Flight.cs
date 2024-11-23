namespace airport.Entities
{
    public class Flight
    {
        public int flightId { get; set; }
        public int airplanId { get; set; }
        public int source { get; set; }
        public int destination { get; set; }
        public int status { get; set; }
        public DateOnly takingOffTime { get; set; }
        public DateOnly landTime { get; set; }
        

        //public Flight(int flightId, int airplanId, int source, int destination, int status, DateOnly takingOffTime, DateOnly landTime)
        //{
        //    this.flightId = flightId;
        //    this.airplanId = airplanId;
        //    this.source = source;
        //    this.destination = destination;
        //    this.status = status;
        //    this.takingOffTime = takingOffTime;
        //    this.landTime = landTime;
        //}

    }
}

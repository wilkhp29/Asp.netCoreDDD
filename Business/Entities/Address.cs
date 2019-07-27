namespace Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string City { get; set; }
        public int Distance { get; set; }
        public string FullAddress { get; set; }
        public bool IsPrimary { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Neighborhood { get; set; }
        public string Number { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
    }
}
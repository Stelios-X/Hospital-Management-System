namespace Hospital.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }
        public DateTime Created { get; set; }
        public DateTime Created { get; set; }
        public string Description { get; set; }
        public ApplicationUser Doctor { get; set; }
        public ApplicationUser Patient { get; set; }
    }
}
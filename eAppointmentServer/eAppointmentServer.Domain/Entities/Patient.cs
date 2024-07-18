namespace eAppointmentServer.Domain.Entities
{
    public sealed class Patient
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string IdentityNumber { get; set; } = string.Empty;
        public string City {  get; set; } = string.Empty;
        public string Town { get; set; } = string.Empty;
        public string FullAdress { get; set; } = string.Empty;
        public Patient() { 
            Id = Guid.NewGuid();
        }

    }
}

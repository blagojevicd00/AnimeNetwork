namespace Domain
{
    public class User
    {
        public int Id { get; set;}
        public string FirstName { get; set;}
        public string LastName {get; set;}
        public bool ActivityStatus { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}

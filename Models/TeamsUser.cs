namespace MSGraph.Models
{
    public class TeamsUserViewModel
    {
        public List<TeamUser> teamsUsers;
        public TeamsUserViewModel() { 
        }
    }


    public class TeamUser
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string JobTitle { get; set; }
        public string GivenName { get; set; }
        public string mail { get; set; }
        public string Availability { get; set; }

    }
}

namespace CreateAndHostEndpoint
{
    public class UserInformation
    {
        public required string SlackName { get; set; }

        public string DayOfWeek { get; set; } = DateTime.UtcNow.ToString("dddd");
        public DateTime CurrentUtcTime { get; set; }
        public required string Track { get; set; }
        public string GithubFileUrl { get; set; } = string.Empty;
        public string GithubRepoUrl { get; set;} = string.Empty;
        public int StatusCode { get; set; }

    }
}

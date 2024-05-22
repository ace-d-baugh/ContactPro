namespace ContactPro.Models
{
    public class MailSettings
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool UseSsl { get; set; } = true;
        public string? DisplayName { get; set; }
        public int Port { get; set; } = 587;
        public string? Host { get; set; }

    }
}

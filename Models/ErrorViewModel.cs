namespace WebAppGitRepo.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public string? Request { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
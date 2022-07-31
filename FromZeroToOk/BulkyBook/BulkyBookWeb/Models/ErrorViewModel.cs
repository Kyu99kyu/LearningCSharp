namespace BulkyBookWeb.Models
{
    //Model represent shapes of the data. The class in c# is use to represent the model
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
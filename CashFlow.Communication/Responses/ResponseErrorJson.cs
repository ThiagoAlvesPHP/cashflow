namespace CashFlow.Communication.Responses;

public class ResponseErrorJson
{
    public string ErrorMessage { get; set; } = string.Empty;
    
    // model new
    // public required string ErrorMessage { get; set; } = string.Empty;

    // model out
    public ResponseErrorJson(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }
}
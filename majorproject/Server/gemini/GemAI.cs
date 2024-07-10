using DotnetGeminiSDK.Client;
using DotnetGeminiSDK.Client.Interfaces;
using DotnetGeminiSDK.Config;
namespace majorproject.Server.gemini;
public class GemAI
{
    private readonly GeminiClient _geminiClient;

    public GemAI()
    {
        _geminiClient = new GeminiClient(new GoogleGeminiConfig()
        {
            ApiKey = "AIzaSyDCzFV6ctNbkOPoBlvegUqebCk42hwTte4",
            ImageBaseUrl = "https://aistudio.google.com/app/prompts/1XTIifcrvQ5ASXg5MmPWjJa40VJk-VITv",
            TextBaseUrl = "https://aistudio.google.com/app/prompts/1XTIifcrvQ5ASXg5MmPWjJa40VJk-VITv"
        });
    }

    public async Task RiskTableGeneration()
    {
        var base64Image = ;
        var response = await _geminiClient.ImagePrompt("Parse this image. Identify the work activities that are done in the picture. Identify the possible hazards the work activity has and the corresponding injury or ill health it might cause. Find any risks controls for the hazards you have found which are implemented in the picture and rate the hazards severity and likelihood with the risk control in place on a scale of 1 to 5, 1 being the least likely/severe and 5 being the most likely/severe. multiply the severity rating and likelihood rating together. Come up with additional risk controls for the hazard along with the severity and likelihood of the hazard with the new control measures in place, on a scale of 1 to 5, 1 being the least likely/severe and 5 being the most likely/severe. Group the response by work activity followed by hazards.",base64Image,"Jpeg");
            
    }
    
}
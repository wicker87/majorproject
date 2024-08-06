using DotnetGeminiSDK.Client;
using DotnetGeminiSDK.Client.Interfaces;
using DotnetGeminiSDK.Config;
using DotnetGeminiSDK.Model;
using majorproject.Shared.Domain;
using System.Diagnostics;
namespace majorproject.Server.gemini;
public class GemAI
{
    private readonly GeminiClient _geminiClient;

    public GemAI()
    {
        _geminiClient = new GeminiClient(new GoogleGeminiConfig()
        {
            ApiKey = "AIzaSyDCzFV6ctNbkOPoBlvegUqebCk42hwTte4",
            ImageBaseUrl = "https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-pro",
            TextBaseUrl = "https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-pro"
        });
    }

    public async Task RiskTableGeneration(ImageSource imageSource)
    {

        Debug.WriteLine("hello world 2");
        int indcom = imageSource.Base64String.IndexOf(",")+1;
        imageSource.Base64String= imageSource.Base64String.Remove(0, indcom);
        Debug.WriteLine(imageSource.Base64String);
        try
        {
            var response = await _geminiClient.ImagePrompt("""
                                                           Parse this image. Identify the work activities that are done in the picture.
                                                           Identify the possible hazards the work activity has and the corresponding injury or ill health it might cause.
                                                           Find any risks controls for the hazards you have found which are implemented in the picture and rate the hazards severity and likelihood with the risk control in place on a scale of 1 to 5, 1 being the least likely/severe and 5 being the most likely/severe.
                                                           multiply the severity rating and likelihood rating together. 
                                                           Come up with additional risk controls for the hazard along with the severity and likelihood of the hazard with the new control measures in place, on a scale of 1 to 5, 1 being the least likely/severe and 5 being the most likely/severe. 
                                                           Group the response by work activity. Reply in JSON.
                                                           follow the format of the following example:
                                                           {
                                                           "work activities":[{
                                                           "work_activity": "Inspection of an oil refinery or chemical plant",
                                                           "hazards_and_risks": [
                                                           {
                                                           "hazard": "Slips, trips, and falls",
                                                           "injury_or_ill_health": "Sprains, strains, fractures, head injuries",
                                                           "existing_risk_controls": "Workers wearing sturdy footwear",
                                                           "severity": 3,
                                                           "likelihood": 2,
                                                           "risk_rating": 6,
                                                           "additional_risk_controls": 
                                                           "Implement a housekeeping program to keep walkways clear of obstacles,
                                                           Provide adequate lighting in all areas"
                                                           ,
                                                           "severity_with_new_controls": 2,
                                                           "likelihood_with_new_controls": 1,
                                                           "risk_rating_with_new_controls": 2
                                                           }
                                                           }]
                                                           }
                                                           """, imageSource.Base64String, ImageMimeType.Jpg);
            Debug.WriteLine(response.Candidates[0].Content.Parts[0].Text);
            imageSource.PromptAnswer=response.Candidates[0].Content.Parts[0].Text;
            Debug.WriteLine("hello world 3");
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"error during RiskTableGeneration:{ex.Message}");
        }
    }
    
}
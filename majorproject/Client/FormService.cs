using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using majorproject.Shared.Domain;

public class FormService
{
    private readonly HttpClient _httpClient;

    public FormService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<bool> AreThereAnyPendingRiskAssessmentsAsync()
    {
        // Adjust the endpoint to your API
        var riskAssessments = await _httpClient.GetFromJsonAsync<RiskAssessment[]>("api/riskassessments");
        if (riskAssessments != null)
        {
            foreach (var assessment in riskAssessments)
            {
                if (assessment.ApprovedStatus == false || assessment.ApprovedStatus == null)
                {
                    return true;
                }
            }
        }
        return false;
    }
}

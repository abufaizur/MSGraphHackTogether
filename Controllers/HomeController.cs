using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph;
using Microsoft.Identity.Web;
using MSGraph.Models;
using System.Diagnostics;
using System.Drawing.Printing;

namespace MSGraph.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GraphServiceClient _graphServiceClient;
        public HomeController(ILogger<HomeController> logger, GraphServiceClient graphServiceClient)
        {
            _logger = logger;
            _graphServiceClient = graphServiceClient;
        }

        [AuthorizeForScopes(ScopeKeySection = "DownstreamApi:Scopes")]
        public async Task<IActionResult> Index()
        {
            var users = await _graphServiceClient
                .Me
                  .Request()
                  .GetAsync()
                  .ConfigureAwait(false);
            var getNameFromGraph = users.GivenName;
           

            @ViewData["LoginUserName"] = getNameFromGraph;

            TeamsUserViewModel teamsUserViewModel = new TeamsUserViewModel();
            teamsUserViewModel.teamsUsers = new List<TeamUser>();

            var userResults = (await _graphServiceClient.Users.Request().Select("id,DisplayName,JobTitle,GivenName,mail,userPrincipalName,presence,id").GetAsync()).ToList();


            foreach (var user in userResults)
            {
                var result = await _graphServiceClient.Users[user.Id].Presence.Request().GetAsync();

                teamsUserViewModel.teamsUsers.Add(new TeamUser
                {

                    Id = user.Id,
                    DisplayName = user.DisplayName,
                    GivenName = user.GivenName,
                    JobTitle = user.JobTitle,
                    mail = user.Mail,
                    Availability = result.Availability
                });
            }                
            return View(teamsUserViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
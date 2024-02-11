using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/baturaykt"),
                Headers =
                {
                     { "X-RapidAPI-Key", "6e34ec937dmsh9356cb92ef98cbap1ab591jsnbbb9a85c3e5f" },
                     { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ResultInstagramFollowersDto resultInstagramFollowersDtos = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.Followers = resultInstagramFollowersDtos.followers;
                ViewBag.Following = resultInstagramFollowersDtos.following;

            }

            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=BtrAykt"),
                Headers =
                 {
                     { "X-RapidAPI-Key", "6e34ec937dmsh9356cb92ef98cbap1ab591jsnbbb9a85c3e5f" },
                       { "X-RapidAPI-Host", "twitter32.p.rapidapi.com" },
                },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                ResultTiwitterFollowersDto.Rootobject resultTivitterFollowersDtos = JsonConvert.DeserializeObject<ResultTiwitterFollowersDto.Rootobject>(body2);
                ViewBag.TwitterFollovers = resultTivitterFollowersDtos.data.user_info.followers_count;
                ViewBag.TwitterFollowing = resultTivitterFollowersDtos.data.user_info.friends_count;
            }

            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://linkedin-data-api.p.rapidapi.com/connection-count?username=baturhanaykut"),
                Headers =
                {
                    { "X-RapidAPI-Key", "6e34ec937dmsh9356cb92ef98cbap1ab591jsnbbb9a85c3e5f" },
                    { "X-RapidAPI-Host", "linkedin-data-api.p.rapidapi.com" },
                },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                ResultLinkedinFollowersDto.Rootobject resultLinkedinFollowersDto = JsonConvert.DeserializeObject<ResultLinkedinFollowersDto.Rootobject>(body3);
                ViewBag.LinkedinFollovers = resultLinkedinFollowersDto.follower;
                ViewBag.LinkedinFollowing = resultLinkedinFollowersDto.connection;
            }

            return View();
        }
    }
}

using HotelProject.WebUI.Dtos.GuestDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardWidgetPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DashboardWidgetPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessageStaff = await client.GetAsync("http://localhost:5155/api/DashboardWidget/StaffCount");
            var responseMessageBooking = await client.GetAsync("http://localhost:5155/api/DashboardWidget/BookingCount");
            var responseMessageUsers = await client.GetAsync("http://localhost:5155/api/DashboardWidget/UsersCount");
            var responseMessageRooms = await client.GetAsync("http://localhost:5155/api/DashboardWidget/RoomsCount");
            if (responseMessageStaff.IsSuccessStatusCode && responseMessageBooking.IsSuccessStatusCode && responseMessageUsers.IsSuccessStatusCode && responseMessageRooms.IsSuccessStatusCode)
            {
                var jsonDataStaff = await responseMessageStaff.Content.ReadAsStringAsync();
                var jsonDataBooking = await responseMessageBooking.Content.ReadAsStringAsync();
                var jsonDataUsers = await responseMessageUsers.Content.ReadAsStringAsync();
                var jsonDataRooms= await responseMessageRooms.Content.ReadAsStringAsync();
                //var values = JsonConvert.DeserializeObject<List<ResultGuestDto>>(jsonData);
                ViewBag.StaffCount = jsonDataStaff;
                ViewBag.BookingCount = jsonDataBooking;
                ViewBag.UsersCount = jsonDataUsers;
                ViewBag.RoomsCount = jsonDataRooms;
                return View();
            }
            return View();
        }
    }
}

using HotelProject.WebUI.Dtos.WorkLocationDto;

namespace HotelProject.WebUI.Dtos.AppUserDto
{
    public class ResultAppUserWithWorkLocationDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ResultWorkLocationDto WorkLocation { get; set; }
        public int WorkLocationId { get; set; }
    }
}

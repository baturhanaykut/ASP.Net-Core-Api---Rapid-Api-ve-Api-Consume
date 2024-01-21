using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.RoomDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.StaffDto;
using HotelProject.WebUI.Dtos.Subscribe;
using HotelProject.WebUI.Dtos.TestimonialDto;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            //Serivce
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            //AppUser
            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto,AppUser>().ReverseMap();

            //About
            CreateMap<ResultAboutDto,About>().ReverseMap();
            CreateMap<UpdateAboutDto,About>().ReverseMap();

            //Room
            CreateMap<ResultRoomDto, Room>().ReverseMap();

            //Service
            CreateMap<ResultServiceDto, Service>().ReverseMap();

            //Testimonail
            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();

            //Staff
            CreateMap<ResultStaffDto, Staff>().ReverseMap();

            //Subscribe
            CreateMap<CreateSubscribeDto,Subscribe>().ReverseMap();

            //Booking
            CreateMap<CreateBookingDto,Booking> ().ReverseMap();
        }
    }
}

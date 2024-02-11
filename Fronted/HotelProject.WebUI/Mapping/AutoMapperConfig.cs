using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.AppUserDto;
using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Dtos.GuestDto;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.MessageCategoryDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.RoomDto;
using HotelProject.WebUI.Dtos.SendMessageDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.StaffDto;
using HotelProject.WebUI.Dtos.Subscribe;
using HotelProject.WebUI.Dtos.TestimonialDto;
using HotelProject.WebUI.Dtos.WorkLocationDto;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            //Serivce
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            //AppUser
            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();
            CreateMap<ResultAppUserDto,AppUser>().ReverseMap();

            //About
            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            //Room
            CreateMap<MessegaCategoryDto, Room>().ReverseMap();
            CreateMap<CreateRoomDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();


            //Service
            CreateMap<ResultServiceDto, Service>().ReverseMap();

            //Testimonail
            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();

            //Staff
            CreateMap<ResultStaffDto, Staff>().ReverseMap();
            CreateMap<ResultLast4Staff, Staff>().ReverseMap();

            //Subscribe
            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();

            //Booking
            CreateMap<CreateBookingDto, Booking>().ReverseMap();
            CreateMap<ResultBookingDto, Booking>().ReverseMap();
            CreateMap<ApprovedReservationDto, Booking>().ReverseMap();
            CreateMap<ResultLast5BookingDto, Booking>().ReverseMap();

            //Contact
            CreateMap<CreateContactDto, Contact>().ReverseMap();

            //Guest
            CreateMap<CreateGuestDto, Guest>().ReverseMap();
            CreateMap<ResultGuestDto, Guest>().ReverseMap();
            CreateMap<UpdateGuestDto, Guest>().ReverseMap();

            //SendMessage
            CreateMap<CreateSendMessageDto, SendMessage>().ReverseMap();
            CreateMap<ResultSendBoxMessageDto, SendMessage>().ReverseMap();
            CreateMap<GetMessageByIdDto, SendMessage>().ReverseMap();

            //MessageCategory
            CreateMap<ResultMessageCategoryDto, MessageCategory>().ReverseMap();

            //WorkLocation
            CreateMap<ResultWorkLocationDto, WorkLocation>().ReverseMap();
            CreateMap<CreateWorkLocationDto, WorkLocation>().ReverseMap();
            CreateMap<UpdateWorkLocationDto, WorkLocation>().ReverseMap();
            CreateMap<ResultAppUserWithWorkLocationDto, WorkLocation>().ReverseMap();


        }
    }
}

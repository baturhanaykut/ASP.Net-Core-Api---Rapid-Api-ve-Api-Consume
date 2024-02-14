using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IBookingService:IGenericService<Booking>
    {
        void TBookingStatusChangeApproved(int id);
        void TBookingStatusChangeCancel(int id);
        void TBookingStatusChangeWait(int id);
        int TGetBookingCount();
        List<Booking> TLast5Bookings();

    }
}

using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IBookingDal : IGenericDal<Booking>
    {
        void BookingStatusChangeApproved(int id);
        void BookingStatusChangeCancel(int id);
        void BookingStatusChangeWait(int id);
        int GetBookingCount();
        List<Booking> Last5Bookings();

       
    }
}

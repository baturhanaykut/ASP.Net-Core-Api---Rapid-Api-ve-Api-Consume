using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IAppUserDal:IGenericDal<AppUser>
    {
        List<AppUser> UserListWithLocation();

        List<AppUser> UsersListWithWorkLocations();

        int GetUserCount();
    }
}

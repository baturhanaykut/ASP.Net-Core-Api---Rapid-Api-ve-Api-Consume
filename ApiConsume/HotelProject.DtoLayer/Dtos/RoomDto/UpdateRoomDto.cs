using System.ComponentModel.DataAnnotations;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RooId { get; set; }
        [Required(ErrorMessage = "Lütfen oda numarasını yazınız")]
        public string? RoomNumber { get; set; }
        [Required(ErrorMessage = "Lütfen oda görseli bilgisi giriniz")]
        public string? RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen fiyat bilgisi giriniz")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen oda başlığı bilgisi giriniz")]
        [StringLength(100,ErrorMessage ="Lütfen en fazla 100 karakter veri girişi yapınız.")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısı bilgisi giriniz")]
        public string? BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen banyo sayısı bilgisi giriniz")]
        public string? BathCount { get; set; }
        [Required(ErrorMessage = "Lütfen Wifi bilgisi giriniz")]
        public string? Wifi { get; set; }
        [Required(ErrorMessage = "Lütfen açıklama bilgisi giriniz")]
        public string? Description { get; set; }
    }
}

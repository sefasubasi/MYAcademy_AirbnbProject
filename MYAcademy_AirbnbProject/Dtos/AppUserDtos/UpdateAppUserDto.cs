namespace MYAcademy_AirbnbProject.Dtos.AppUserDtos
{
    public class UpdateAppUserDto
    {
        public string AppUserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string PhoneNumber { get; set; }

        public string ProfileImageUrl { get; set; }
        public bool IsActive { get; set; }
    }
}

namespace PexelsProject.Application.Interfaces
{
    public interface IPhotoService
    {
        Task<string> SearchPhotosAsync(string query);
    }
}

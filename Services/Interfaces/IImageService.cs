namespace ContactPro.Services.Interfaces
{
    public interface IImageService
    {
        public Task<byte[]> ConvertFileToByteArray(IFormFile file);
        public string ConvertByteArrayToFile(byte[] fileData, string extension);
    }
}

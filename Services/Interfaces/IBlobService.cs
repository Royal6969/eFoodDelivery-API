﻿namespace eFoodDelivery_API.Services.Interfaces
{
    public interface IBlobService
    {
        Task<string> GetBlob(string blobName, string containerName);

        Task<string> UploadBlob(string blobName, string containerName, IFormFile file);
        
        Task<bool> DeleteBlob(string blobName, string containerName);
    }
}

using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using eFoodDelivery_API.Services.Interfaces;

namespace eFoodDelivery_API.Services.Implementations
{
    public class BlobService : IBlobService
    {
        private readonly BlobServiceClient _blobServiceClient;

        public BlobService(BlobServiceClient blobServiceClient)
        {
            _blobServiceClient = blobServiceClient;
        }

        public async Task<string> GetBlob(string blobName, string containerName)
        {
            // we have to get the container client, because in Azure we can have multiple containers for storage images
            BlobContainerClient blobContainerClient = _blobServiceClient.GetBlobContainerClient(containerName);
            // find blob (image) by blobName (imageName)
            BlobClient blobClient = blobContainerClient.GetBlobClient(blobName);

            // return full route for the blob (image)
            return blobClient.Uri.AbsoluteUri;
        }

        public async Task<string> UploadBlob(string blobName, string containerName, IFormFile file)
        {
            // we have to get the container client, because in Azure we can have multiple containers for storage images
            BlobContainerClient blobContainerClient = _blobServiceClient.GetBlobContainerClient(containerName);
            // find blob (image) by blobName (imageName)
            BlobClient blobClient = blobContainerClient.GetBlobClient(blobName);

            // we can also define blob HTTP header and set the content type
            var httpHeaders = new BlobHttpHeaders()
            {
                ContentType = file.ContentType
            };

            // upload the blob (image)
            var result = await blobClient.UploadAsync(file.OpenReadStream(), httpHeaders);

            if (result != null) // to get the blob updated
                return await GetBlob(blobName, containerName);

            // if (result == null)
                return "";
        }

        public async Task<bool> DeleteBlob(string blobName, string containerName)
        {
            // we have to get the container client, because in Azure we can have multiple containers for storage images
            BlobContainerClient blobContainerClient = _blobServiceClient.GetBlobContainerClient(containerName);
            // find blob (image) by blobName (imageName)
            BlobClient blobClient = blobContainerClient.GetBlobClient(blobName);

            return await blobClient.DeleteIfExistsAsync();
        }
    }
}

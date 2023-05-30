using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using eFoodDelivery_API.Services.Interfaces;

namespace eFoodDelivery_API.Services.Implementations
{
    public class BlobService : IBlobService
    {
        // dependencies to inject
        private readonly BlobServiceClient _blobServiceClient;

        // dependency injection
        public BlobService(BlobServiceClient blobServiceClient)
        {
            _blobServiceClient = blobServiceClient;
        }



        /// <summary>
        /// 1º method to get a blob
        /// </summary>
        /// <param name="blobName"></param>
        /// <param name="containerName"></param>
        /// <returns>the URI for this blob</returns>
        public async Task<string> GetBlob(string blobName, string containerName)
        {
            // we have to get the container client, because in Azure we can have multiple containers for storage images
            BlobContainerClient blobContainerClient = _blobServiceClient.GetBlobContainerClient(containerName);
            // find blob (image) by blobName (imageName)
            BlobClient blobClient = blobContainerClient.GetBlobClient(blobName);

            // return full route for the blob (image)
            return blobClient.Uri.AbsoluteUri;
        }



        /// <summary>
        /// 2º method to upload a new blob
        /// </summary>
        /// <param name="blobName"></param>
        /// <param name="containerName"></param>
        /// <param name="file"></param>
        /// <returns>GetBlob or null</returns>
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



        /// <summary>
        /// 3º method to delete a blob
        /// </summary>
        /// <param name="blobName"></param>
        /// <param name="containerName"></param>
        /// <returns>delete blob</returns>
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

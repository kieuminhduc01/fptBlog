﻿using MARShop.Application.Mapper;
using MARShop.Application.Models;
using MARShop.Application.Share;
using MARShop.Core.Entities;
using MARShop.Infastructure.Repositories.MediaRepository;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.MediaHandler.Commands.UpdateMedia
{
    public class FileUpdate
    {
        public string MediaContent { get; set; }
        public string MediaName { get; set; }
        public string ProductLink { get; set; }
    }
    public class UpdateMediaCommand : IRequest<DResult>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public FileUpdate ImageIdentity { get; set; }
        public FileUpdate[] MediaFile { get; set; }
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
        public float ImageIdentityWidth { get; set; }
    }

    public class UpdateMediaCommandHandler : IRequestHandler<UpdateMediaCommand, DResult>
    {
        private readonly IMediaRepository _mediaRepository;
        private readonly IWebHostEnvironment _enviroment;

        public UpdateMediaCommandHandler(IMediaRepository mediaRepository, IWebHostEnvironment enviroment)
        {
            _mediaRepository = mediaRepository;
            _enviroment = enviroment;
        }

        public async Task<DResult> Handle(UpdateMediaCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var media = await _mediaRepository.DGetByIdAsync(request.Id);

                var vWSInfo = await GetVWSAsync(media, request.AccessKey, request.SecretKey);
                if (vWSInfo != "success")
                {
                    return DResult.Failure("Hình ảnh mục tiêu đang trong quá trình phân tích vui lòng thử lại sau vài giây");
                }

                var FolderId = Guid.NewGuid().ToString();
                var UPLOAD_IMAGE_ID_FOLDER = $"\\upload\\imageId\\{FolderId}\\";
                var UPLOAD_IMAGE_ID_FOLDER_Fix = $"upload/imageId/{FolderId}/";
                var UPLOAD_MEDIA_FOLDER = $"\\upload\\media\\{FolderId}\\";
                var UPLOAD_MEDIA_FOLDER_Fix = $"upload/media/{FolderId}/";

                if (request.ImageIdentity != null && request.MediaFile != null)
                {
                    DFile.WriteData(request.ImageIdentity.MediaName, request.ImageIdentity.MediaContent, $"{_enviroment.WebRootPath}{UPLOAD_IMAGE_ID_FOLDER}");

                    var mediaMetaData = new MediaMetaData();
                    mediaMetaData.MediaName = request.Name;
                    for (int i = 0; i < request.MediaFile.Length; i++)
                    {
                        DFile.WriteData(request.MediaFile[i].MediaName, request.MediaFile[i].MediaContent, $"{_enviroment.WebRootPath}{UPLOAD_MEDIA_FOLDER}{i}\\");

                        mediaMetaData.MediaProductInfos.Add(new MediaProductInfo()
                        {
                            MediaLink = $"{UPLOAD_MEDIA_FOLDER}{i}\\{request.MediaFile[i].MediaName}",
                            ProductLink = request.MediaFile[i].ProductLink
                        });
                    }

                    var mediaMetaDataJson = JsonSerializer.Serialize<MediaMetaData>(mediaMetaData);
                    var imageTarget = DConvertor.Bas64Of32bitsTo24bits(request.ImageIdentity.MediaContent.Substring(request.ImageIdentity.MediaContent.LastIndexOf(',') + 1));

                    var vWSUpdate = new VWSUpdate()
                    {
                        IdTarget = media.ImageIdentityIdInVuforia,
                        AccessKey = request.AccessKey,
                        SecretKey = request.SecretKey,
                        Width = request.ImageIdentityWidth,
                        Active_flag = 1,
                        Application_metadata = DConvertor.StringToBase64(mediaMetaDataJson),
                        Image = imageTarget,
                    };

                    var imageIdetityInVuforia = DVuforia.UpdateTarget(vWSUpdate);

                    var entity = MediaMapper.Mapper.Map<Media>(request);
                    entity.ImageIdentityIdInVuforia = media.ImageIdentityIdInVuforia;
                    entity.MediaFile = mediaMetaDataJson;
                    entity.ImageIdentity = UPLOAD_IMAGE_ID_FOLDER_Fix + request.ImageIdentity.MediaName;

                    await _mediaRepository.DUpdateAsync(entity);

                    return DResult.Success();
                }
                else
                {
                    return DResult.Failure();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private async Task<string> GetVWSAsync(Media media, string accessKey, string secretKey)
        {
            var vWSGet = new VWSGet()
            {
                IdTarget = media.ImageIdentityIdInVuforia,
                AccessKey = accessKey,
                SecretKey = secretKey,
            };
            var result = DVuforia.GetTarget(vWSGet);
            return DConvertor.GetJsonValueByKey(result, "status");
        }
    }
}

﻿using MARShop.Application.Common;
using MARShop.Application.Mapper;
using MARShop.Application.Middleware;
using MARShop.Core.Entities;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.BlogPostHandler.Queries.Get
{
    public class GetBlogPostQuery : IRequest<Respond<BlogPostRespond>>
    {
        public string Id { get; set; }
    }
    public class BlogPostRespond
    {
        public string Id { get; set; }
        public DateTime Created { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public string Slug { get; set; }
        public int Views { get; set; }
        public string Summary { get; set; }
        public string Category { get; set; }
        public IList<TagRespond> Tags { get; set; }
    }
    public class TagRespond
    {
        public string Id { get; set; }
        public string Title { get; set; }
    }

    public class GetBlogPostQueryHandle : IRequestHandler<GetBlogPostQuery, Respond<BlogPostRespond>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetBlogPostQueryHandle(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Respond<BlogPostRespond>> Handle(GetBlogPostQuery request, CancellationToken cancellationToken)
        {
            var blogPost = await _unitOfWork.BlogPosts.DFistOrDefaultAsync(a => a.Id == request.Id);

            // check blog post exist
            if (blogPost == null) throw new AppException("Blog post dont exist");

            var blogPostRespond = BlogPostMapper.Mapper.Map<BlogPostRespond>(blogPost);
            var draft = await GetTagResponds(request.Id);
            blogPostRespond.Tags = await GetTagResponds(request.Id);

            return Respond<BlogPostRespond>.Success(blogPostRespond);
        }

        private async Task<IList<TagRespond>> GetTagResponds(string blogPostId)
        {
            var blogPostTags = _unitOfWork.BlogPostTags.DGet(a => a.BlogPostId == blogPostId).ToList();

            var tags = new List<TagRespond>();
            foreach (var blogPostTag in blogPostTags)
            {
                var tagss = _unitOfWork.Tags.DGetDbSet();
                var tag = await _unitOfWork.Tags.DFistOrDefaultAsync(a => a.Id == blogPostTag.TagId);
                tags.Add(new TagRespond()
                {
                    Id = tag.Id,
                    Title = tag.Title,
                });
            }
            return tags;
        }
    }
}
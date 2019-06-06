using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoreApp.Data.Entities.Base;
using CoreApp.Data.Enums;
using CoreApp.Data.Interfaces;

namespace CoreApp.Data.Entities
{
    [Table("Blogs")]
    public class Blog : BaseClass, ISwitchable, IDateTracking, IHasSeoMetaData
    {
        public Blog():base() { }

        public Blog(string name,string thumbnailImage,
           string description, string content, bool? homeFlag, bool? hotFlag,
           string tags, Status status, string seoPageTitle,
           string seoAlias, string seoMetaKeyword,
           string seoMetaDescription)
        {
            Name = name;
            Image = thumbnailImage;
            Description = description;
            Content = content;
            HomeFlag = homeFlag;
            HotFlag = hotFlag;
            Tags = tags;
            Status = status;
            SeoPageTitle = seoPageTitle;
            SeoAlias = seoAlias;
            SeoDescription = seoMetaDescription;
        }
        
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }


        [MaxLength(256)]
        public string Image { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public string Content { set; get; }

        public bool? HomeFlag { set; get; }

        public bool? HotFlag { set; get; }

        public int? ViewCount { set; get; }

        public string Tags { get; set; }

        public List<BlogTag> BlogTags { set; get; }

        public DateTime DateCreated { set; get; }

        public DateTime DateModified { set; get; }

        public Status Status { set; get; }

        [MaxLength(256)]
        public string SeoPageTitle { set; get; }

        [MaxLength(256)]
        public string SeoAlias { set; get; }

        [MaxLength(256)]
        public string SeoKeyWords { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [MaxLength(256)]
        public string SeoDescription { set; get; }
    }
}
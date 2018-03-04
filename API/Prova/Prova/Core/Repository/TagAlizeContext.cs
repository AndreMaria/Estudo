using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Prova.Core.Model;
using Prova.Core.Model.Mapping;


namespace Prova.Core.Repository
{
    public class TagAlizeContext: DbContext
    {
        public TagAlizeContext(): base("TagAlize")
        { }

        public DbSet<Content> Content { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Label> Label { get; set; }

        protected override  void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ContentMapping());
            modelBuilder.Configurations.Add(new LabelMapping());
            modelBuilder.Configurations.Add(new TagMapping());
        }
    }
}
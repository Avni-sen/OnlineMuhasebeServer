using OnlineMuhasebeServer.Domain.Abstract;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMuhasebeServer.Domain.AppEntities
{
    public class AppUserAndCompanyRelationship : BaseEntity
    {
        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set;}

        [ForeignKey("Compan")]

        public string ComponyId { get; set; }
        public Company Company { get; set; }
    }
}

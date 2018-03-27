
using System.ComponentModel.DataAnnotations.Schema;

namespace Sensing.Entities.Infrastructure
{
    public interface IObjectState
    {
        [NotMapped]
        ObjectState ObjectState { get; set; }
    }
}
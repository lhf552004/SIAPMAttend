using System;
using System.ComponentModel.DataAnnotations;

using RS = SIAPM.Entities.Resource;
using Sensing.Entities.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sensing.Entities
{
    public abstract class EntityBase : IObjectState
    {
        [Key]
        [Display(Name = nameof(RS.Id), ResourceType = typeof(RS))]
        public int Id { get; set; }

        [Display(Name = nameof(RS.LastUpdated), ResourceType = typeof(RS))]
        public DateTime? LastUpdated { get; set; }

        [Display(Name = nameof(RS.Updater), ResourceType = typeof(RS))]
        public string Updater { get; set; }

        /// <summary>
        /// the time when item was created.
        /// </summary>
        [Display(Name = nameof(RS.Created), ResourceType = typeof(RS))]
        public DateTime? Created { get; set; } = DateTime.Now;

        [Display(Name = nameof(RS.Creator), ResourceType = typeof(RS))]
        public string Creator { get; set; }

        [Display(Name = nameof(RS.Deleted), ResourceType = typeof(RS))]
        public bool Deleted { get; set; }

        [Display(Name = nameof(RS.Description), ResourceType = typeof(RS))]
        public string Description { get; set; }

        #region Options for extension.
        //gaps for ui display in order.
        [Display(Name = nameof(RS.OrderNumber), ResourceType = typeof(RS))]
        public int OrderNumber { get; set; }

        [Display(Name = nameof(RS.Comments), ResourceType = typeof(RS))]
        public string Comments { get; set; }

        [Display(Name = nameof(RS.Extends), ResourceType = typeof(RS))]
        public string Extends { get; set; }

        #endregion

        public virtual bool IsTransient()
        {
            return this.Id == default(int);
        }

        [NotMapped]
        public ObjectState ObjectState { get; set; }

        public string GetProName(string originProName)
        {
            string value = "";
            if (!string.IsNullOrEmpty(originProName))
            {
                var arrPro = originProName.Split(';');
                foreach (var pro in arrPro)
                {
                    var arrSignlePro = pro.Split(':');
                    if (arrSignlePro.Length >= 2)
                    {
                        int length = arrSignlePro.Length;
                        value += ";" + arrSignlePro[length - 2] + ":" + arrSignlePro[length - 1];
                    }

                }
            }
            if (!string.IsNullOrEmpty(value))
                value = value.Substring(1);
            return value;
        }
    }
}

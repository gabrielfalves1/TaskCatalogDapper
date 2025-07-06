using System.ComponentModel.DataAnnotations;

namespace TaskCatalogDapper.Enums
{
    public enum Priority
    {
        [Display(Name = "Baixa")]
        Low,

        [Display(Name = "Média")]
        Medium,

        [Display(Name = "Alta")]
        High
    }
}
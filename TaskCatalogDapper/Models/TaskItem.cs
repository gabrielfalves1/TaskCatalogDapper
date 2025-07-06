using System.ComponentModel.DataAnnotations;
using TaskCatalogDapper.Enums;

namespace TaskCatalogDapper.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório")]
        [StringLength(100, ErrorMessage = "O título deve ter no máximo 100 caracteres")]
        public string Title { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória")]
        [StringLength(500, ErrorMessage = "A descrição deve ter no máximo 500 caracteres")]
        public string Description { get; set; }

        [Required(ErrorMessage = "A prioridade é obrigatória")]
        public Priority ?Priority { get; set; }
    }
}

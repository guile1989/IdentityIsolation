using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using TT.Infra.CrossCutting.Identity.Model;

namespace TT.Application.ViewModels
{
    public class RegistrarClienteViewModel
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }

        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        [ScaffoldColumn(false)]
        public Task<IdentityResult> Result { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}

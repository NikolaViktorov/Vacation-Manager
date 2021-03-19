﻿namespace VacationManager.Web.ViewModels.Administration
{
    using System.ComponentModel.DataAnnotations;

    public class CEORemoveModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}

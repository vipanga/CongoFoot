using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CongoFoot.Models
{
    public enum Categorie
    {
        [Display(Name = "RDC")]
        RDC,
        [Display(Name = "Linafoot")]
        Linafoot,
        [Display(Name = "Ligue des champions CAF")]
        C1,
        [Display(Name = "Coupe de la confédération")]
        C2,
        [Display(Name = "Afrique")]
        Afrique,
        [Display(Name = "Monde")]
        Monde,
        [Display(Name = "Flash")]
        Flash,
        [Display(Name = "Autre")]
        Autre
    }

    public class MesEnumerations
    {
    }
}
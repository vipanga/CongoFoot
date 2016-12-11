using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CongoFoot.Models
{
    public class Article
    {
        public int ID { get; set; }

        [StringLength(60, ErrorMessage = "Le titre doit comprendre 250 caractères maximum")]
        [Display(Name = "Titre")]
        [Required(ErrorMessage = "Titre requis")]
        public string Titre { get; set; }

        [StringLength(60, ErrorMessage = "Le nom de l'auteur doit comprendre 60 caractères maximum")]
        [Display(Name = "Auteur")]
        [Required(ErrorMessage = "Nom requis")]
        public string Auteur { get; set; }

        [Display(Name = "Date Publication")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DatePublication { get; set; }

        [Display(Name = "Date Modification")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateModification { get; set; }

        [StringLength(150, ErrorMessage = "L'URL ne doit pas comprendre plus de 60 caractères")]
        [Display(Name = "URL Originale")]
        public string UrlImageOriginale { get; set; }

        [StringLength(150, ErrorMessage = "L'URL ne doit pas comprendre plus de 60 caractères")]
        [Display(Name = "URL Miniature")]
        public string UrlImageMiniature { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(5000, ErrorMessage = "Le contenu de l'article ne doit pas depasser 15000 caracteres")]
        public string Contenu { get; set; }

        [Required(ErrorMessage = "Catégorie requise")]
        public Categorie? Categorie { get; set; }
    }
}
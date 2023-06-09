﻿using System.ComponentModel.DataAnnotations;

namespace Mini_Projet.Models
{
    public class ContenuPanier
    {

        public int ContenuPanierId { get; set; }

        public int PanierId { get; set; }
        public virtual Panier Panier { get; set; }

        public int ProduitId { get; set; }
        public virtual Produit Produit { get; set; }

        [Required]
        [Display(Name = "Quantité en unitée")]
        public int Quantite { get; set; }
    }
}

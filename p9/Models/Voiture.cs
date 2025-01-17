﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace p9.Models
{
    public class Voiture
    {
        
        [Key]
        [DisplayName("Code VIN")]
        public int Id { get; set; }
        //[Required]
        //[DisplayName("Idenditifant User")]
        //public int? UtilisateurId { get; set; }
        [Required]
        [Range(1990, int.MaxValue)]
        [DisplayName("Année")]
        public int Annee { get; set; }
        [Required]
        [DisplayName("Marque")]
        public string Marque { get; set; }
        [Required]
        [DisplayName("Modèle")]
        public string Modele { get; set; }
        [Required]
        [DisplayName("Finition")]
        public string Finition { get; set; }
        public string MarqueModeleFinition => $"{Marque} {Modele} {Finition}";
        [DataType(DataType.Date)]
        [DisplayName("Date d'achat")]
        public DateTime DateAchat { get; set; }
        [DataType(DataType.Currency)]
        [DisplayName("Prix d'achat")]
        public float ?PrixAchat { get; set; }
        [DataType(DataType.Currency)]
        [DisplayName("Prix de vente")]
        public float? PrixVente { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Date de vente")]
        public DateTime? DateVente { get; set; }
        [DisplayName("Véhicule disponible")]
        public bool EstDisponible { get; set; }
        public string? Description { get; set; }
      
        public ICollection<Reparation>? Reparations { get; set; }
       

    }
}

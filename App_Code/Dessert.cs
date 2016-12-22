namespace Assignment4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dessert")]
    public partial class Dessert
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RecipeID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string SubmittedBy { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        public int? PrepareC { get; set; }

        public string RecipeDec { get; set; }

        public string Ingredients { get; set; }

        public int? Qauntity { get; set; }

        public int? Units { get; set; }
    }
}

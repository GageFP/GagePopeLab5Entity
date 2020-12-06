using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GagePopeLab5.Models
{
    public class Character
    {
        [Key]
        public int characterID { get; set; }
        public string characterName { get; set; }
        public int characterHealth { get; set; }

        [ForeignKey ("Weapon")]
        public string weaponName { get; set; }
        public Weapon Weapon { get; set; }
    }
}
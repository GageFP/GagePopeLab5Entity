using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GagePopeLab5.Models
{
    public class Weapon
    {
        [Key]
        public string weaponName { get; set; }
        public int weaponDamage { get; set; }
    }
}
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<MachineEngineer>();
    }
    [Required]
    public int EngineerId { get; set; }
    [Required]
    public string Name { get; set; }

    public virtual ICollection<MachineEngineer> JoinEntities { get; }
  }
}
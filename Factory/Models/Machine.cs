using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<MachineEngineer>();
    }
    [Required]
    public int MachineId { get; set; }
    [Required]
    public string Name { get; set; }
    public virtual ICollection<MachineEngineer> JoinEntities { get; set; }
  }
}
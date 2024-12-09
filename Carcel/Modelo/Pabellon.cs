using System;
using System.Collections.Generic;

namespace Carcel.Modelo;

public partial class Pabellon
{
    public int IdPabellon { get; set; }

    public string? Nombre { get; set; }

    public string? NivelSeguridad { get; set; }

    public virtual ICollection<Guia> Guia { get; set; } = new List<Guia>();

    public virtual ICollection<Ppl> Ppls { get; set; } = new List<Ppl>();
}

using System;
using System.Collections.Generic;

namespace Carcel.Modelo;

public partial class Guia
{
    public int IdGuias { get; set; }

    public string? Cedula { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Turno { get; set; }

    public int? IdPabellon { get; set; }

    public virtual Pabellon? IdPabellonNavigation { get; set; }
}

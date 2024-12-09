using System;
using System.Collections.Generic;

namespace Carcel.Modelo;

public partial class Ppl
{
    public int IdPll { get; set; }

    public string? Cedula { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Motivo { get; set; }

    public DateOnly? FechaIngreso { get; set; }

    public DateOnly? FechaSalida { get; set; }

    public string? Estado { get; set; }

    public int? IdPabellon { get; set; }

    public virtual Pabellon? IdPabellonNavigation { get; set; }
}

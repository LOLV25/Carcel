using System;
using System.Collections.Generic;

namespace Carcel.Modelo;

public partial class Administrador
{
    public int IdUsuario { get; set; }

    public string? Usuario { get; set; }

    public string? Contrasena { get; set; }
}

﻿using System;
using System.Collections.Generic;

namespace Fundacion.Models;

public partial class Aula
{
    public int AuId { get; set; }

    public byte[] AuDescripcion { get; set; } = null!;

    public virtual ICollection<Espacio> Espacios { get; set; } = new List<Espacio>();

}
public class hola { }
public class espacio { }




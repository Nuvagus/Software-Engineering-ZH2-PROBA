﻿using System;
using System.Collections.Generic;

namespace excel_prog.Models;

public partial class MennyisegiEgysegek
{
    public int MennyisegiEgysegId { get; set; }

    public string? EgysegNev { get; set; }

    public virtual ICollection<Nyersanyagok> Nyersanyagoks { get; } = new List<Nyersanyagok>();
}

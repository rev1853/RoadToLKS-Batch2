﻿using System;
using System.Collections.Generic;

namespace HeroAPI.Database;

public partial class FightHistory
{
    public int Id { get; set; }

    public int Hero1Id { get; set; }

    public int Hero2Id { get; set; }

    public double Hero1TotalPower { get; set; }

    public double Hero2TotalPower { get; set; }

    public DateTime FightDate { get; set; }
}

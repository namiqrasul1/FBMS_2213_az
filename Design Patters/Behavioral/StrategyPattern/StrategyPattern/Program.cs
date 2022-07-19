using Strategy;
using System;
using System.Collections.Generic;

Unit unit = new(new FireballAttackStrategy(), new MagicDefenceStrategy());


unit.Attack();
unit.Defence();

unit.DefenceStrategy = new ShieldDefencestrategy();
unit.Defence();
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Core.Armas.Armas;
public class VaritaMagica: Arma
{
    public override int BrindarAtaque(Personaje personaje) => 10;
    public override int BrindarVelAtaque(Personaje personaje) => 0;
}
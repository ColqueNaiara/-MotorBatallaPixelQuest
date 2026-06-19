using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelQuest
{
    public class Personaje
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set {
                if (!string.IsNullOrEmpty(value))
                    _nombre = value;
            }
        }
        public virtual string Atacar() 
        {
            return $"{Nombre} realiza un ataque";
        }
    }
    public class Mago : Personaje {
        private int _cantidadMana;
        public int CantidadMana 
        {
            get { return _cantidadMana; }
            set
            {   if (_cantidadMana<100)
                _cantidadMana = value;
            }
        }
        public override string Atacar()
        {
            return $"{Nombre} lanza una bola de fuego | Maná: {CantidadMana}";
        }
    }
    public class Guerrero : Personaje {
        private int _resistencia;
        public int Resistencia
        {
            get { return _resistencia; }
            set
            {
                if (_resistencia < 120)
                _resistencia = value;
            }
        }
        public override string Atacar() 
        {
            return $"{Nombre} golpea con su espada | Resistencia: {Resistencia}";
        }
    }
    public class Arquero : Personaje {
        private int _cantidadFlechas;
        public int CantidadFlechas
        {
            get { return _cantidadFlechas; }
            set
            {
                if (_cantidadFlechas < 130)
                _cantidadFlechas = value;
            }
        }
        public override string Atacar()
        {
            return $"{Nombre} lanza una flecha venenosa | Flechas: {CantidadFlechas}";
        }
    }
}


using UnityEngine;
using System;
using System.IO.Pipes;
namespace PackegesPersona
{
    [Serializable]
    public class Estudiante : Persona
    {
        private string codE;
        private string nameCarrera;

        public Estudiante()
        {
        }

        public Estudiante( string codE,string nameCarrera,string nameP, string mailP, string dirP) 
            : base(nameP, mailP, dirP)
     
        {
            this.codE = codE;
            this.nameCarrera= nameCarrera;
        }

        public string CodE { get => codE; set => codE = value; }
        public string NameCarrera { get => nameCarrera; set => nameCarrera = value; }
    }
        
    }

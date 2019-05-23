using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pruebaExtNuevoCSharp.Dominio
{
    public class Empresa
    {
        private int Id;
        private string Descripcion;
        private string Nif;
        private Char ControlarEjes;
        private int IdTipo;
        private DateTime HoraEnvioMailError;
        private int UsuariosHabilitados;
        private int TerminalesHabilitadas;
        private string EmpCod;
        private DateTime SvrTS;
        private string CodInterfaz;

        public int Id1 { get => Id; set => Id = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public string Nif1 { get => Nif; set => Nif = value; }
        public char ControlarEjes1 { get => ControlarEjes; set => ControlarEjes = value; }
        public int IdTipo1 { get => IdTipo; set => IdTipo = value; }
        public DateTime HoraEnvioMailError1 { get => HoraEnvioMailError; set => HoraEnvioMailError = value; }
        public int UsuariosHabilitados1 { get => UsuariosHabilitados; set => UsuariosHabilitados = value; }
        public int TerminalesHabilitadas1 { get => TerminalesHabilitadas; set => TerminalesHabilitadas = value; }
        public string EmpCod1 { get => EmpCod; set => EmpCod = value; }
        public DateTime SvrTS1 { get => SvrTS; set => SvrTS = value; }
        public string CodInterfaz1 { get => CodInterfaz; set => CodInterfaz = value; }
    }
}
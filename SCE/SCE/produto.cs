//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SCE
{
    using System;
    using System.Collections.Generic;
    
    public partial class produto
    {
        public int ID { get; set; }
        public string codigo { get; set; }
        public string descricao { get; set; }
        public Nullable<int> categoriaID { get; set; }
        public Nullable<int> quantidade { get; set; }
        public Nullable<double> custo { get; set; }
        public Nullable<double> custoMedio { get; set; }
        public string classfiscal { get; set; }
        public Nullable<double> peso { get; set; }
        public Nullable<bool> estrutura { get; set; }
        public Nullable<bool> importado { get; set; }
        public string ativo { get; set; }
    }
}
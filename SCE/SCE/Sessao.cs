using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE
{
    public static class Sessao
    {
        private static String LoginUsuario;

        public static String NomeUsuario
        {
            get { return Sessao.LoginUsuario; }
            set { Sessao.LoginUsuario = value; }
        }

        public static int FornecedorAtivo = 0;
        public static String ProdutoAtivo = "";

        public static string ObtemVersao()
        { 
             if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
             {
                 Version ver;
                 ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
                 return String.Format("{0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision);
             }
             else
                 return "Não Publicado.";
        }
    }
}

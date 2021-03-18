using LUG_PIM3_Ana_Laura_Moyano.DAL.EF;
using System.Linq;

namespace LUG_PIM3_Ana_Laura_Moyano.BLL
{
    public class LoginBLL
    {
        public bool Login(string username, string password)
        {
            PIM3DBEntities ctx = new PIM3DBEntities();
            var usuarios = ctx.Usuarios
                .Where(u => u.usuario.CompareTo(username) == 0)
                .ToList();
            if (usuarios.Count() == 0)
                return false;
            var resultado = usuarios.Any(u => string.Equals(u.password, password, System.StringComparison.InvariantCulture));
            return resultado;
        }
    }
}

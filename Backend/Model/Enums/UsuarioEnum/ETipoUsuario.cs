using System.ComponentModel;

namespace Model.Enums.UsuarioEnum
{
    public enum ETipoUsuario
    {
        [Description("Aluno")]
        Aluno = 1,

        [Description("Professor")]
        Professor = 2,

        [Description("Administrativo")]
        Administrativo = 3
    }
}

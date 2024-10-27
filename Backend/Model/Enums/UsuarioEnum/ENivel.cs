using System.ComponentModel;

namespace Model.Enums.UsuarioEnum
{
    public enum ENivel
    {
        [Description("Técnico")]
        Tecnico = 1,

        [Description("Graduação")]
        Graduacao = 2,

        [Description("Pós-Graduação")]
        PosGraduacao = 3,

        [Description("Mestrado")]
        Mestrado = 4,

        [Description("Doutorado")]
        Doutorado = 5,

        [Description("Concluído")]
        Concluido = 6
    }
}

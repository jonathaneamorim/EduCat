using System.ComponentModel;

namespace Model.Enums.UsuarioEnum
{
    public enum ERaca
    {
        [Description("Prefiro Não Dizer")]
        PrefiroNaoDizer = 0,

        [Description("Branco")]
        Branco = 1,

        [Description("Negro")]
        Negro = 2,

        [Description("Pardo")]
        Pardo = 3,

        [Description("Amarelo")]
        Amarelo = 4,

        [Description("Indígena")]
        Indigena = 5,

        [Description("Outro")]
        Outro = 6
    }
}

using System.ComponentModel;

namespace Model.Enums.UsuarioEnum
{
    public enum EEstadoCivil
    {
        [Description("Prefiro Não Dizer")]
        PrefiroNaoDizer = 0,

        [Description("Solteiro")]
        Solteiro = 1,

        [Description("Casado")]
        Casado = 2,

        [Description("Divorciado")]
        Divorciado = 3,

        [Description("Viúvo")]
        Viuvo = 4,

        [Description("Separado")]
        Separado = 5,

        [Description("União Estável")]
        UniaoEstavel = 6,

        [Description("Outro")]
        Outro = 7
    }
}

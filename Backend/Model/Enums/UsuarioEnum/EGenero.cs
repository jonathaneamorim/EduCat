using System.ComponentModel;

namespace Model.Enums.UsuarioEnum
{
    public enum EGenero
    {
        [Description("Prefiro Não Dizer")]
        PrefiroNaoDizer = 0,

        [Description("Masculino")]
        Masculino = 1,

        [Description("Feminino")]
        Feminino = 2,

        [Description("Não Binário")]
        NaoBinario = 3,

        [Description("Outro")]
        Outro = 4
    }
}

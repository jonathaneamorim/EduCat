using System.ComponentModel;

namespace Model.Enums.UsuarioEnum
{
    public enum ETipoSanguineo
    {
        [Description("Prefiro Não Dizer")]
        PrefiroNaoDizer = 0,

        [Description("A+")]
        APositivo = 1,

        [Description("A-")]
        ANegativo = 2,

        [Description("B+")]
        BPositivo = 3,

        [Description("B-")]
        BNegativo = 4,

        [Description("AB+")]
        ABPositivo = 5,

        [Description("AB-")]
        ABNegativo = 6,

        [Description("O+")]
        OPositivo = 7,

        [Description("O-")]
        ONegativo = 8
    }
}

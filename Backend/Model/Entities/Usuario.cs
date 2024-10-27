using Model.Enums.UsuarioEnum;

namespace Model.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public ETipoUsuario TipoUsuario { get; set; }
        public int Matricula { get; set; }
        public string NomeCivil { get; set; }
        public string? NomeSocial { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string CPF { get; set; }
        public string? RG { get; set; }
        public EGenero? Genero { get; set; }
        public string? Naturalidade { get; set; }
        public ERaca? Raca { get; set; }
        public ETipoSanguineo? TipoSanguineo { get; set; }
        public string? Nacionalidade { get; set; }
        public EEstadoCivil? EstadoCivil { get; set; }
        public DateTime? DataNascimento { get; set; }
        public ENivel? Nivel { get; set; }
        public string? Telefone { get; set; }
        public string? NomePai { get; set; }
        public string? NomeMae { get; set; }
        public Endereco? Endereco { get; set; }
        public Usuario() { }
    }
}

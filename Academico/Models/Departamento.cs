namespace Academico.Models
{
    public class Departamento
    {
        public int Id { get; set; } //DepartamentoId ou Id, se quiser colocar o nome da classe e o Id junto
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int InstituicaoId { get; set; }
        public Instituicao? InstituicaoOrigem { get; set; } //o ponto de interrogação indica que pode ser nulo
    }
}

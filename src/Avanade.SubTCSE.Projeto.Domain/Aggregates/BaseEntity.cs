namespace Avanade.SubTCSE.Projeto.Domain
{
    //<Tid> permite definir o tipo
    //Record garante que as propiedades nao vai ser alteradas
    public record BaseEntity<Tid>
    {
        public Tid Id { get; set; }
    }
}

namespace Interface_18_12.Classes
{
    public interface ICarrinho
    {
         void Cadastrar( Produto produto );

         void Listar();

         void Alterar ( int cod, Produto produto);

         void Deletar ( Produto produto);
    }
}
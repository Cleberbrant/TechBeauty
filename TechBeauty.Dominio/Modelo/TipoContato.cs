namespace TechBeauty.Dominio.Modelo
{
    public class TipoContato
    {
        public int Id { get; private set; }
        public string Valor { get; private set; }      

        public static TipoContato Criar(int id, string valor)
        {
            TipoContato tipo = new TipoContato();
            tipo.Id = id;
            tipo.Valor = valor;

            return tipo;
        }

        public void Alterar(string valor)
        {
            Valor = valor;
        }

    }
}

using Api.Infrastructure;

namespace Infrastructure
{
    public static class ExampleRepository
    {
        //Consulta em Banco
        public static List<ExampleModel> RetornaNomeCorFavorita()
        {
            var ListNomeCorFavoritas = new List<ExampleModel>() {
                new ExampleModel { Nome = "Lucas" , CorFavorita = "Azul"}
                ,new ExampleModel { Nome = "Carol" , CorFavorita = "Verde"}
                ,new ExampleModel { Nome = "Maria" , CorFavorita = "Azul"}
                ,new ExampleModel { Nome = "Wellington" , CorFavorita = "Rosa"}};
            
            return ListNomeCorFavoritas;
        }
    }
}

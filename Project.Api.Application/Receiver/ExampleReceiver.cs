using Api.Infrastructure;
using Infrastructure;

namespace Api.Application
{
    public class ExampleReceiver
    {


        public List<ExampleModel> GetNomes() 
        {
            //Parte logica da Api
            return ExampleRepository.RetornaNomeCorFavorita();
        }
    }
}

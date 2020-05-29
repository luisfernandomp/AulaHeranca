namespace pooCSHARP
{
    public class CPF : Pessoa
    {
        public string cpf;
        public string rg;
        public bool validarCPF(string cpf){
            if(cpf != null){
                return true;
            }else{
                return false;
            }
        }

    }   
}
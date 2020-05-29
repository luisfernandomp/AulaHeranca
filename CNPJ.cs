namespace pooCSHARP
{
    public class CNPJ : Pessoa
    {
        public string cnpj;
        public bool validarCNPJ(string cnpj){
            if(cnpj != null){
                return true;
            }else{
                return false;
            }
        }
    }
}
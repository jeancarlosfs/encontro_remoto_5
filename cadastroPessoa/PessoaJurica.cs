namespace cadastroPessoa

{
    public class PessoaJurica : Pessoa
    {
        public string cnpj { get; set; }

        public string razaoSocial { get; set; }
        public override void pagarImposto(float salario){

        }

        public bool ValidarCNPJ(string cnpj){
            if (cnpj.Length == 14 && cnpj.Substring(cnpj.Length - 6,4) == "0001")
            {
             return true;   
            }
            return false;
        }

    }
}
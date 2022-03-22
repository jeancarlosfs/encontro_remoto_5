namespace cadastroPessoa
{
    public class PessoaFisica : Pessoa
    {
        public string cpf { get; set; }

        public DateTime dataNascimento { get; set; }
        public override void pagarImposto(float salario){

        }
        public bool ValidarDataNascimento(DateTime dateNasc) {
            DateTime dateAtual = DateTime.Today;

            int anos = (dateAtual - dateNasc).TotalDays / 365;

            if (anos >= 18)
            {
                return true;
            }else{
                return false;
            }

        }
        
        
        
        
    }
}
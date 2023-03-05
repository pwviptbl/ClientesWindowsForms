using ClientesApp.Models;

namespace ClientesApp.Controllers
{
    class ClienteController
    {
        public static Response isvalid(Cliente cliente)
        {
            Response response;

            response = validString("Nome", cliente.nome, 5, 255);
            if (!response.Success)
            {
                return response;
            }

            response = IsValidEmail(cliente.email);
            if (!response.Success)
            {
                return response;
            }

            response = validString("CPF", cliente.cpf, 14, 14);
            if (!response.Success)
            {
                return response;
            }

            response = validString("Telefone", cliente.telefone, 14, 15);
            if (!response.Success) {
                return response;
            }
            return response;
        }
        public static Response validString(string campo, string text, int min = 1, int max = 255)
        {
            Response response = new Response();
            response.Success = true;
            if (text.Length < min)
            {
                response.Success = false;
                response.Message = "Campo " + campo + " deve conter pelo menos " + min + " Caracteres!";
            }
            else if (text.Length > max)
            {
                response.Success = false;
                response.Message = "Campo " + campo + " deve conter no maximo " + min + " Caracteres!";
            }
            return response;
        }

        public static Response IsValidEmail(string email) {
            Response response = new Response();
            response.Message = "Email invalido";
            response.Success = false;
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith(".")){
                response.Success = false;
            }
            try{
                var addr = new System.Net.Mail.MailAddress(email);
                if(addr.Address == trimmedEmail)
                    response.Success=true;
            } catch {
                response.Success = false;
            }
            return response;
        }

    }
}

namespace TodoList
{
    public class TodoItem
    {
        public string Titulo;
        public string Nota;

        public TodoItem(string Titulo,string Nota){   // Construtor nao tem tipo de retorno, o construtor instancia uma classe. Deve conter o mesmo nome da classe.
            this.Titulo = Titulo;
            this.Nota = Nota;
        }
    }
}
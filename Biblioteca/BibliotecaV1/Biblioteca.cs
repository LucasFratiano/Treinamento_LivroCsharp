namespace LibraryClass
{
    //principal classe de controle de livros na Biblioteca
    public class Biblioteca
    {

        private string _Titulo; //recebe o titulo do livro
        private string _Autor; //recebe o autor do livro
        private int _Paginas; //recebe qtde paginas do livro
        private bool _Status; //recebe saindo(false) ou entrando(true) na biblioteca

        public Biblioteca()
        {//construtor sem parametros

        }

        public Biblioteca(string Titulo, string Autor, int Paginas, bool Status)
        {
            _Titulo = Titulo;
            _Autor = Autor;
            _Paginas = Paginas;
            _Status = Status;
        }

        public string Titulo
        {   //metodo para acesso a propriedade titulo da classe
            get{return _Titulo;} set{_Titulo = value;}
        }
        
        public string Autor{
            get{return _Autor;} set{_Autor = value;}
        }
        
        public int Paginas{
            get {return _Paginas;} set {_Paginas = value;}
        }

        public bool Status{
            get{return _Status;} set{_Status = value;}
        }

    }
}
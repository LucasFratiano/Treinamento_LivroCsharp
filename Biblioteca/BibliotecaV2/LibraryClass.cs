namespace LibraryClass;

public class Revistas : Biblioteca
{
    //propriedades da classe
    private int _MesPublicacao;
    private int _AnoPublicacao;

    //construtor da classe
    public Revistas(int MesPublicao, int AnoPublicacao)
    {
        _AnoPublicacao = AnoPublicacao;
        _MesPublicacao = MesPublicao;
    }

    public int MesPublicacao //metodo para a proriedade da classe
    {
        get { return _MesPublicacao; }
        set { _MesPublicacao = value; }
    }

    public int AnoPublicacao
    {
        get { return _AnoPublicacao; }
        set { _AnoPublicacao = value; }

    }
}

//principal classe de controle de livros na biblioteca
public class Biblioteca
{

    private string _Titulo; //recebe o titulo do livro
    private string _Autor; //recebe o autor do livro
    private int _Paginas; //recebe qtde paginas do livro
    private bool _Status; //recebe saindo(false) ou entrando(true) na biblioteca

    public Biblioteca()
    { //construtor sem parametros

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
        get { return _Titulo; }
        set { _Titulo = value; }
    }

    public string Autor
    {
        get { return _Autor; }
        set { _Autor = value; }
    }

    public int Paginas
    {
        get { return _Paginas; }
        set { _Paginas = value; }
    }

    public bool Status
    {
        get { return _Status; }
        set { _Status = value; }
    }

}

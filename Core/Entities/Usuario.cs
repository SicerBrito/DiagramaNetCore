namespace Core.Entities;

public class Usuario{
    public int Id { get; set; }
    public string ? PrimerNombre { get; set; }
    public string ? SegundoNombre { get; set; }
    public string ? PrimerApellido { get; set; }
    public string ? SegundoApellido { get; set; }
    public string ? Telefono { get; set; }
    public string ? Direccion { get; set; }
    public string ? Email { get; set; }

    public ICollection<DocumentoUser> ? documentoUsers { get; set; }
}

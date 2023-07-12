namespace Core.Entities;

public class Documento{
    public int IdDocumento { get; set;}
    public string ? NombreDocumento { get; set;}
    public string ? AbreviaturaDocumento { get; set; }
    public ICollection<DocumentoUser> ? documentoUsers { get; set; }
}

public class Word
{
    private string text;
    private bool isHidden;

    // Constructor que inicializa el texto y lo marca como visible (no oculto)
    public Word(string text)
    {
        this.text = text;
        this.isHidden = false;
    }

    // Método para ocultar la palabra
    public void Hide()
    {
        isHidden = true;
    }

    // Método que verifica si la palabra está oculta
    public bool IsHidden()
    {
        return isHidden;
    }

    // Método para obtener el texto a mostrar (____ si está oculta)
    public string GetDisplayText()
    {
        return isHidden ? "____" : text;
    }
}

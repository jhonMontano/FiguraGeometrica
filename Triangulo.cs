
namespace Figura;
class Triangulo : IFigura {
    public int alto {get; set;}
    public int ancho{get; set;}

    public int area()
    {
        return this.alto * ancho/2;
    }
}
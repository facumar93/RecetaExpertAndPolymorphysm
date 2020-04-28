using System;
using Full_GRASP_And_SOLID.Library;

namespace Full_GRASP_And_SOLID
// Respetando el Patrón "Expert" y basandose en el Patrón "Polymorfism"
// se crean dos clases diferentes que realizan una operacion similar( dif tipos de impresión ),
// dando la posibilidad de crear una interface que tenga contrato con ambas clases ( imprimir receta ).

{
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe)
        {
            
        }
    }
}
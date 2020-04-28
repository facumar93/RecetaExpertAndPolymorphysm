using System;
using System.IO;
using Full_GRASP_And_SOLID.Library;

namespace Full_GRASP_And_SOLID
{
    
    
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}
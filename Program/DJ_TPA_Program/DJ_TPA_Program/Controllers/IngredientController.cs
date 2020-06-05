using DJ_TPA_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_TPA_Program.Controllers
{
    class IngredientController
    {

        public static void DoInsertIngredient(String ingredientName, int quantity)
        {

            Ingredient ingredient = new Ingredient();
            ingredient.IngredientName = ingredientName;

            ConnectionController.GetInstance().Ingredients.Add(ingredient);

            HeaderIngredient headerIng = new HeaderIngredient();
            headerIng.Quantity = quantity;
            headerIng.IngredientId = ingredient.Id;
            headerIng.EmployeeId = ActiveUserController.GetActiveEmployee().Id;

            ConnectionController.GetInstance().HeaderIngredients.Add(headerIng);
            ConnectionController.GetInstance().SaveChanges();
        }

    }
}

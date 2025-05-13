class Meal {
    public string? Drink {get; set;}
    public string? MainCourse {get; set;}
    public string? Dessert {get; set;}
    public string? SideDish {get; set;}

    public void ShowMeal () { 
        
        if (string.IsNullOrEmpty (Drink) == false) {
            Console.WriteLine ($"Drink is {this.Drink}");
        }

        if (string.IsNullOrEmpty (MainCourse) == false) {
            Console.WriteLine ($"MainCourse is {this.MainCourse}");
        }

        if (string.IsNullOrEmpty (Dessert) == false) {
            Console.WriteLine ($"Dessert is {this.Dessert}");
        }

        if (string.IsNullOrEmpty (SideDish) == false) {
            Console.WriteLine ($"SideDish is {this.SideDish}");
        }

    }
}


interface IMealBuilder {
    void Reset();
    IMealBuilder SetDrink(string drink);
    IMealBuilder SetMainCourse(string mainCourse);
    IMealBuilder SetDessert(string dessert);
    IMealBuilder SetSideDish(string sideDish);
    Meal GetMeal();

}


class MealBuilder : IMealBuilder {

    private Meal meal = new Meal ();

    public void Reset () {
        meal = new Meal ();
    }

    public IMealBuilder SetDrink(string drink) {
        
        meal.Drink = drink;
        return this;

    }

    public IMealBuilder SetMainCourse(string mainCourse) {

        meal.MainCourse = mainCourse;
        return this;

    }

    public IMealBuilder SetDessert(string dessert) {

        meal.Dessert = dessert;
        return this;

    }

    public IMealBuilder SetSideDish(string sideDish) {

        meal.SideDish = sideDish;
        return this;

    }

    public Meal GetMeal() {
        Meal copymeal = this.meal;
        Reset();
        return copymeal;
    }

}
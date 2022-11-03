using System;
using System.IO;

public class CoffeeShop{
    private double time;

    public double work_time
    {
        get {return time;}
        set {time = value;}
    }
    public void Time()
    {
        if (8.00<=time && time<21.00)
            {
                Console.WriteLine("We are OPEN!");
            }
        else 
            {
                Console.WriteLine("Sorry, We are CLOSED!");
                Environment.Exit(0);
            }
    }
}
public class Character : CoffeeShop{

    private string Name;
    private string role; //barista, cashier, baker

    
    public string name 
    {
        get { return Name; }
        set { Name = value; }
    }
    public string Role{
        get {return role;}
        set {role = value;}

    }
    
    public string mess_Role() 
    {
        role = Console.ReadLine();
         switch(role)

        {   case "customer":
                Console.WriteLine("Welcome!");
                break;
            case "cashier":
                Console.WriteLine("Please, take the customer's order!");
                break;
            case "barista":
                Console.WriteLine("Please, wait for the cashier's instruction");
                break;
            case "baker":
                Console.WriteLine("Bake time!");
                break;
            default:
                Console.WriteLine("No such role!");
                break;
        }
        return role;
    }

    public void mess_Name(){
        switch(name)
        {
            case "Andrew":
                Console.WriteLine("Hello Barista Andrew!");
                role = "barista";
                break;
            case "Roberta":
                Console.WriteLine("Hello Cashier Roberta!");
                role = "cashier";
                break;
            case "Juan":
                Console.WriteLine("Hello Baker Juan");
                role = "baker";
                break;
            default:
                mess_Role();
                break;
        }
    }
}
public class Beverage : CoffeeShop{
    private string beverage_name; //coffee, tea, cold_drinks
    private string type;

    public string beverage 
    {
        get { return beverage_name; }
        set { beverage_name = value; }
    }

    public string type_beverage
    {
        get { return type; }
        set { type = value; }
    }

    public void setBeverage(string beverage)
    {
        type = beverage;
    }
    public void descr()
    {
        switch(type)
        {
            case "tea":
            Console.WriteLine("What kind of tea would you like?");
            break;

            case "coffee":
            Console.WriteLine("What kind of coffee would you like?");
            break;

            case "cold drink":
            Console.WriteLine("What kind of drink would you like?");
            break;

            default: 
            Console.WriteLine("Sorry, we don't have such drink");
            break;
        }
    }
    
}
public class Dessert : CoffeeShop{
    private string dessert_name;
    private int price = 0;
   
    public void setPrice(int n){
        price = n;
    }
    
    public int getPrice(){
        return price;
    }
    
    public string dessert
    {
        get { return dessert_name; }
        set { dessert_name = value; }
    }
    
    public void setDessert(){
        Console.WriteLine("\nChoose a dessert which you would want to get for yourself:\n");
        dessert_name = Console.ReadLine();
        switch(dessert_name){
            case "brownie":
                setPrice(35);
                break;
            case "classic cheesecake":
                setPrice(45);
                break;
            case "cherry cheesecake":
                setPrice(47);
                break;
            case "oreo cake":
                setPrice(40);
                break;
        }
        Console.WriteLine("\n"+dessert_name + " to be!\n");
    }
}
public class Payment : CoffeeShop{
    private double pay;
    private string method;
    
    public double Money_pay
    {
        get {return pay;}
        set {pay = value; }
    }

    public string method_pay
    {
        get {return method;}
        set {method = value;}
    }

    public void pay_bill(int total)
    {
        Console.WriteLine("Which method are you choosing to pay the bill with? Cash or card?");
        method = Console.ReadLine();
        switch(method)
        {
            case "cash":
                Console.WriteLine("Your bill has a total of: "+ total + " lei.");

                break;
            case "card":
                Console.WriteLine("You paid "+total+" lei with your credit card.");
                break;

        }
    }
 }
 public class Coffee : Beverage{
    private string beans_type; //arabica, robusta, mixt
    private string coffee_type;
    private int price = 0;
    private int sugar_doses = 0;
    
    

    public void setPrice(int n){
        price = n;
    }
    
    public void setPrice(int n, int nr_doses_sugar){
        price = n + nr_doses_sugar;
    }

    public int getPrice(){
        return price;
    }
    
    public string beans
    {
        get {return beans_type;}
        set {beans_type = value;}
    }

    public string coffee
    {
        get {return coffee_type;}
        set {coffee_type = value;}
    }
    public void bean(string bean)
    {
        beans_type = bean;
    }
    public void coffee_bean()
    {
        switch(beans_type)
        {
            case "arabica":
                Console.WriteLine("\nSweet taste choice");
                break;
            case "robusta":
                Console.WriteLine("\nBitter taste choice");
                break;
            case "mixt":
                Console.WriteLine("\nBest choice");
                break;
        }
    }

    public void choose_coffee(string choice)
    {
       coffee_type =  choice;
    }
    public void choose()
    {   
        String choice;
        Console.WriteLine("Sugar?");
            choice = Console.ReadLine();
            if(String.Equals("yes",choice)){
                int nr_doses;
                Console.WriteLine("How many sugar doses do you want?");
                nr_doses = Convert.ToInt32(Console.ReadLine());
                    switch(coffee_type)
        {
            case "latte":
                Console.WriteLine("\nEspresso with milk to be!");
                setPrice(26,nr_doses);
                break;
            case "cappuccino":
                Console.WriteLine("\nEspresso with milk and foam to be!");
                setPrice(25,nr_doses);
                break;
            case "americano":
                Console.WriteLine("\nEspresso with water to be!");
                setPrice(23,nr_doses);
                break;
            case "espresso":
                Console.WriteLine("\nEspresso to be!");
                setPrice(20,nr_doses);
                break;
            case "doppio":
                Console.WriteLine("\nDouble espresso to be!");
                setPrice(25,nr_doses);
                break;
            case "mocha":
                Console.WriteLine("\nEspresso with chocolate and milk to be!");
                setPrice(25,nr_doses);
                break;
            case "flat white":
                Console.WriteLine("\nEpresso with milk to be!");
                setPrice(27,nr_doses);
                break;
            case "irish":
                Console.WriteLine("\nCoffee with wiskey, sugar and cream to be!");
                setPrice(32,nr_doses);
                break;
            case "macchiato":
                Console.WriteLine("\nEspresso with foam to be!");
                setPrice(24,nr_doses);
                break;
            default:
                Console.WriteLine("Sorry, we don't serve such coffee");
                Environment.Exit(0);
                break;
        }
            }else{
                switch(coffee_type)
        {
            case "latte":
                Console.WriteLine("\nEspresso with milk to be!");
                setPrice(26);
                break;
            case "cappuccino":
                Console.WriteLine("\nEspresso with milk and foam to be!");
                setPrice(25);
                break;
            case "americano":
                Console.WriteLine("\nEspresso with water to be!");
                setPrice(23);
                break;
            case "espresso":
                Console.WriteLine("\nEspresso to be!");
                setPrice(20);
                break;
            case "doppio":
                Console.WriteLine("\nDouble espresso to be!");
                setPrice(25);
                break;
            case "mocha":
                Console.WriteLine("\nEspresso with chocolate and milk to be!");
                setPrice(25);
                break;
            case "flat white":
                Console.WriteLine("\nEpresso with milk to be!");
                setPrice(27);
                break;
            case "irish":
                Console.WriteLine("\nCoffee with wiskey, sugar and cream to be!");
                setPrice(32);
                break;
            case "macchiato":
                Console.WriteLine("\nEspresso with foam to be!");
                setPrice(24);
                break;
            default:
                Console.WriteLine("Sorry, we don't serve such coffee");
                Environment.Exit(0);
                break;
        }
            }
        

    }
    
}




public class Tea : Beverage{
    private string tea_type;
    private int price = 0;
    
    public void setPrice(int n){
        price = n;
    }
    public void setPrice(int n, int nr_doses_sugar){
        price = n + nr_doses_sugar;
    }
    
    public int getPrice(){
        return price;
    }
    
    public string tea
    {
        get{return tea_type;}
        set{tea_type = value;}
    }

     public void choose_tea(string choice)
    {
       tea_type = choice;
    }
    public void choose()
    {
        tea_type = Console.ReadLine();
        String choice;
        Console.WriteLine("Sugar?");
            choice = Console.ReadLine();
            if(String.Equals("yes",choice)){
                int nr_doses;
                Console.WriteLine("How many sugar doses do you want?");
                nr_doses = Convert.ToInt32(Console.ReadLine());
        switch(tea_type)
        {
            case "black":
                Console.WriteLine("\nBlack tea to be!");
                setPrice(20,nr_doses);
                break;
            case "green":
                Console.WriteLine("\nGreen tea to be!");
                setPrice(20,nr_doses);
                break;
            case "fruitty":
                Console.WriteLine("\nFruitty tea to be!");
                setPrice(25,nr_doses);
                break;
            case "herbal":
                Console.WriteLine("\nHerbal tea to be!");
                setPrice(20,nr_doses);
                break;
            case "ginger":
                Console.WriteLine("\nGinger tea to be!");
                setPrice(25,nr_doses);
                break;
            default: 
                Console.WriteLine("Sorry, we don't serve this tea.");
                Environment.Exit(0);
                break;
        }  
    }else{
        switch(tea_type)
        {
            case "black":
                Console.WriteLine("\nBlack tea to be!");
                setPrice(20);
                break;
            case "green":
                Console.WriteLine("\nGreen tea to be!");
                setPrice(20);
                break;
            case "fruity":
                Console.WriteLine("\nFruity tea to be!");
                setPrice(25);
                break;
            case "herbal":
                Console.WriteLine("\nHerbal tea to be!");
                setPrice(20);
                break;
            case "ginger":
                Console.WriteLine("\nGinger tea to be!");
                setPrice(25);
                break;
            default: 
                Console.WriteLine("Sorry, we don't serve this tea.");
                Environment.Exit(0);
                break;
        }  
    }
    }
}
public class Coldrinks : Beverage{
    private string cold_drink;
    private int price = 0;
    
    public void setPrice(int n){
        price = n;
    }
    
    public int getPrice(){
        return price;
    }
    public string colds 
    {
        get{return cold_drink;}
        set{cold_drink = value;}
    }
    public void dcold(string temp_cold)
    {
        cold_drink = temp_cold;
    }
    public void choose_drink()
    {
        switch(cold_drink)
        {
            case "cola":
                Console.WriteLine("\nCola to be!");
                setPrice(25);
                break;
            case "fanta":
                Console.WriteLine("\nFanta to be!");
                setPrice(25);
                break;
            case "sprite":
                Console.WriteLine("\nSprite to be!");
                setPrice(25);
                break;
            case "water":
                Console.WriteLine("\nWater to be!");
                setPrice(20);
                break;
            case "sparkling water":
                Console.WriteLine("\nSparkling water to be!");
                setPrice(20);
                break;
            case "classic lemonade":
                Console.WriteLine("\nClassic lemonade to be!");
                setPrice(35);
                break;
            default:
                Console.WriteLine("\nSorry, we don't have it!");
                break;
        }
    }

}
public class Tips : Payment{
    private double money;

    public double tip
    {
        get {return money;}
        set{money = value;}
    }

    public void get_tips()
    {
        money = Convert.ToDouble(Console.ReadLine());
    }
 }
 public class Extra{
    private string extras;
    private int price = 0;
    
    public void setPrice(int n){
        price = n;
    }
    
    public int getPrice(){
        return price;
    }
    
    public string extra
    {
        get {return extras;}
        set {extras = value;}
    }
     public void adds(string add)
    {
       extras = add;
    }
    public void extra_beverage()
    {
        switch(extras)
        {
            case "syrup":
                Console.WriteLine("\nWe have caramel, vanilla, hazelnut and creme brulee syrup. Which one do you choose?");
                String type_syrup = Console.ReadLine();
                switch(type_syrup){
                    case "caramel":
                        Console.WriteLine("Caramel Syrup to be!");
                        break;
                    case "vanilla":
                        Console.WriteLine("Vanilla Syrup to be!");
                        break;
                    case "hazelnut":
                        Console.WriteLine("Hazelnut Syrup to be!");
                        break;
                    case "creme brulee":
                        Console.WriteLine("Creme Brulee Syrup to be!");
                        break;
                }
                setPrice(4);
                break;
            case "ice":
                Console.WriteLine("\nIce to be!");
                setPrice(2);
                break;
            case "milk":
                Console.WriteLine("\nWe have cow milk, almond milk, coconut milk and soya milk. Which one do you want to have?");
                String type_milk = Console.ReadLine();
                    switch(type_milk){
                        case "cow":
                            Console.WriteLine("Cow milk to be!");
                            setPrice(4);
                            break;
                        case "almond":
                            Console.WriteLine("Almond milk to be!");
                            setPrice(8);
                            break;
                        case "coconut":
                            Console.WriteLine("Coconut milk to be!");
                            setPrice(8);
                            break;
                        case "soya":
                            Console.WriteLine("Soya milk to be!");
                            setPrice(8);
                            break;
                    }
                break;
            case "sweetener":
                Console.WriteLine("\nSweetener to be!");
                setPrice(2);
                break;
            default: 
                Console.WriteLine("\nSorry, we don't have it!");
                break;
        }
    }
}
//main
class my_coffee_shop
{
    static public void Main()
    {
        Random random = new Random();
        String[] beverage = new String[3];
        beverage[0] = "tea";
        beverage[1] = "coffee";
        beverage[2] = "cold drink";
        String[] types_of_tea = new String[5];
        types_of_tea[0] = "black";
        types_of_tea[1] = "green";
        types_of_tea[2] = "fruity";
        types_of_tea[3] = "herbal";
        types_of_tea[4] = "ginger";
        String[] types_of_coffee = new String[9];
        types_of_coffee[0] = "latte";
        types_of_coffee[1] = "cappuccino";
        types_of_coffee[2] = "americano";
        types_of_coffee[3] = "espresso";
        types_of_coffee[4] = "doppio";
        types_of_coffee[5] = "mocha";
        types_of_coffee[6] = "flat white";
        types_of_coffee[7] = "irish";
        types_of_coffee[8] = "machiato";
        String[] types_of_cold_drinks = new String[6];
        types_of_cold_drinks[0] = "cola";
        types_of_cold_drinks[1] = "fanta";
        types_of_cold_drinks[2] = "sprite";
        types_of_cold_drinks[3] = "water";
        types_of_cold_drinks[4] = "sparkling water";
        types_of_cold_drinks[5] = "classic lemonade";
        String[] types_of_syrup = new String[4];
        types_of_syrup[0] = "caramel";
        types_of_syrup[1] = "vanilla";
        types_of_syrup[2] = "hazelnut";
        types_of_syrup[3] = "creme brulee";
        String[] types_of_milk = new String[4];
        types_of_milk[0] = "coconut";
        types_of_milk[1] = "almond";
        types_of_milk[2] = "soya";
        types_of_milk[3] = "cow";
        String[] types_of_desserts = new String[4];
        types_of_desserts[0] = "brownie";
        types_of_desserts[1] = "classic cheesecake";
        types_of_desserts[2] = "cherry cheesecake";
        types_of_desserts[3] = "oreo cake";
        int[] tea_prices = new int[5]{20,20,25,20,25};
        int[] coffee_prices = new int[9]{26,25,23,20,25,25,27,32,24};
        int[] cold_drink_prices = new int[6]{25,25,25,20,20,35};
        int syrup_prices = 4;
        int[] milk_prices = new int[4]{8,8,8,4};
        int ice_price = 2;
        int[] dessert_prices = new int[4]{35,45,47,40};

        int number_of_people_per_day = random.Next()%30;
        String[] beverages_people_have = new String[number_of_people_per_day];
        String[] type_drink = new String[number_of_people_per_day];
        String[] type_extra = new String[number_of_people_per_day];
        String[] type_dessert = new String[number_of_people_per_day];
        for(int i = 0; i < number_of_people_per_day; i++){
            type_extra[i] = "none";
            type_dessert[i] = "none";
        }

        int total_per_day = 0;
        
        for(int i = 0; i < number_of_people_per_day; i++){
            int total_per_customer = 0;
            beverages_people_have[i] = beverage[random.Next()%3];
            if(String.Equals("tea",beverages_people_have[i])){
                int teatype = random.Next()%5;
                type_drink[i] = types_of_tea[teatype];
                total_per_customer+=tea_prices[teatype];
                int extra_choice = random.Next()%9;
                int dessert_choice = random.Next()%3;
                if(extra_choice == 2){//syrup
                    int extratype = random.Next()%4;
                    type_extra[i] = types_of_syrup[extratype];
                    total_per_customer+=syrup_prices;
                }else if(extra_choice == 4){//ice
                    type_extra[i] = "ice";
                    total_per_customer+=ice_price;
                } else if(extra_choice == 7){//milk
                    int extratype = random.Next()%4;
                    type_extra[i] = types_of_milk[extratype];
                    total_per_customer+=milk_prices[extratype];
                }
                if(dessert_choice == 1 || dessert_choice == 2){
                    int desserttype = random.Next()%4;
                    type_dessert[i] = types_of_desserts[desserttype];
                    total_per_customer+=dessert_prices[desserttype];
                }
            }else if(String.Equals("coffee",beverages_people_have[i])){
                int coffeetype = random.Next()%9;
                type_drink[i] = types_of_coffee[coffeetype]; 
                total_per_customer+=coffee_prices[coffeetype];
                int extra_choice = random.Next()%9;
                int dessert_choice = random.Next()%3;
                 if(extra_choice == 2){//syrup
                 int extratype = random.Next()%4;
                    type_extra[i] = types_of_syrup[extratype];
                    total_per_customer+=syrup_prices;
                }else if(extra_choice == 4){//ice
                    type_extra[i] = "ice";
                    total_per_customer+=ice_price;
                } else if(extra_choice == 7){//milk
                    int extratype = random.Next()%4;
                    type_extra[i] = types_of_milk[extratype];
                    total_per_customer+=milk_prices[extratype];
                    
                }
                if(dessert_choice == 1 || dessert_choice == 2){
                    int desserttype = random.Next()%4;
                    type_dessert[i] = types_of_desserts[desserttype];
                    total_per_customer+=dessert_prices[desserttype];
                }
            }else{
                int colddrinktype = random.Next()%6;
                type_drink[i] = types_of_cold_drinks[colddrinktype];
                total_per_customer+=cold_drink_prices[colddrinktype];
                int extra_choice = random.Next()%4;
                int dessert_choice = random.Next()%3;
                if(extra_choice == 1 || extra_choice == 2 || extra_choice == 3){
                    type_extra[i] = "ice";
                    total_per_customer+=ice_price;
                }
                if(dessert_choice == 1 || dessert_choice == 2){
                    int desserttype = random.Next()%4;
                    type_dessert[i] = types_of_desserts[desserttype];
                    total_per_customer+=dessert_prices[desserttype];
                }
            }
            Console.WriteLine("      "+beverages_people_have[i]+ "/" +type_drink[i]+"/"+type_extra[i]+"/"+type_dessert[i]+"/"+total_per_customer+" lei");
            total_per_day+=total_per_customer;
        }
        Console.WriteLine(total_per_day+" lei made today from "+number_of_people_per_day+" customers.");

        Console.WriteLine("Want to check how much you will do next month? ");
        String choice = Console.ReadLine();
        while(String.Equals("y",choice)){
         
        int total_per_month = 0;
        int number_of_people_per_month = 0;
        for(int k = 0; k < 4; k++){
            int total_per_week = 0;
            int number_of_people_per_week = 0;
        for(int j = 0; j < 7; j++){
         total_per_day = 0;
         number_of_people_per_day = random.Next()%30;
         beverages_people_have = new String[number_of_people_per_day];
        type_drink = new String[number_of_people_per_day];
         type_extra = new String[number_of_people_per_day];
        type_dessert = new String[number_of_people_per_day];
        for(int i = 0; i < number_of_people_per_day; i++){
            type_extra[i] = "none";
            type_dessert[i] = "none";
        }
        for(int i = 0; i < number_of_people_per_day; i++){
            int total_per_customer = 0;
            beverages_people_have[i] = beverage[random.Next()%3];
            if(String.Equals("tea",beverages_people_have[i])){
                int teatype = random.Next()%5;
                type_drink[i] = types_of_tea[teatype];
                total_per_customer+=tea_prices[teatype];
                int extra_choice = random.Next()%9;
                int dessert_choice = random.Next()%3;
                if(extra_choice == 2){//syrup
                    int extratype = random.Next()%4;
                    type_extra[i] = types_of_syrup[extratype];
                    total_per_customer+=syrup_prices;
                }else if(extra_choice == 4){//ice
                    type_extra[i] = "ice";
                    total_per_customer+=ice_price;
                } else if(extra_choice == 7){//milk
                    int extratype = random.Next()%4;
                    type_extra[i] = types_of_milk[extratype];
                    total_per_customer+=milk_prices[extratype];
                }
                if(dessert_choice == 1 || dessert_choice == 2){
                    int desserttype = random.Next()%4;
                    type_dessert[i] = types_of_desserts[desserttype];
                    total_per_customer+=dessert_prices[desserttype];
                }
            }else if(String.Equals("coffee",beverages_people_have[i])){
                int coffeetype = random.Next()%9;
                type_drink[i] = types_of_coffee[coffeetype]; 
                total_per_customer+=coffee_prices[coffeetype];
                int extra_choice = random.Next()%9;
                int dessert_choice = random.Next()%3;
                 if(extra_choice == 2){//syrup
                 int extratype = random.Next()%4;
                    type_extra[i] = types_of_syrup[extratype];
                    total_per_customer+=syrup_prices;
                }else if(extra_choice == 4){//ice
                    type_extra[i] = "ice";
                    total_per_customer+=ice_price;
                } else if(extra_choice == 7){//milk
                    int extratype = random.Next()%4;
                    type_extra[i] = types_of_milk[extratype];
                    total_per_customer+=milk_prices[extratype];
                    
                }
                if(dessert_choice == 1 || dessert_choice == 2){
                    int desserttype = random.Next()%4;
                    type_dessert[i] = types_of_desserts[desserttype];
                    total_per_customer+=dessert_prices[desserttype];
                }
            }else{
                int colddrinktype = random.Next()%6;
                type_drink[i] = types_of_cold_drinks[colddrinktype];
                total_per_customer+=cold_drink_prices[colddrinktype];
                int extra_choice = random.Next()%4;
                int dessert_choice = random.Next()%3;
                if(extra_choice == 1 || extra_choice == 2 || extra_choice == 3){
                    type_extra[i] = "ice";
                    total_per_customer+=ice_price;
                }
                if(dessert_choice == 1 || dessert_choice == 2){
                    int desserttype = random.Next()%4;
                    type_dessert[i] = types_of_desserts[desserttype];
                    total_per_customer+=dessert_prices[desserttype];
                }
            }
            // Console.WriteLine("      "+beverages_people_have[i]+ "/" +type_drink[i]+"/"+type_extra[i]+"/"+type_dessert[i]+"/"+total_per_customer+" lei");
            total_per_day+=total_per_customer;
        }
        Console.WriteLine("    "+total_per_day+" lei made today from "+number_of_people_per_day+" customers.");
        number_of_people_per_week+= number_of_people_per_day;
        total_per_week+=total_per_day;
        }
        Console.WriteLine("  "+total_per_week+" lei made this week from "+number_of_people_per_week+" customers.");
        number_of_people_per_month+= number_of_people_per_week;
        total_per_month+=total_per_week;
        }
        Console.WriteLine(total_per_month+" lei made this month from "+number_of_people_per_month+" customers.");
        Console.WriteLine("Want to check how much you will do next month? ");
        choice = Console.ReadLine();
        }

        
        // for(int i = 0; i < number_of_people_per_day; i++){
        //     Console.WriteLine(beverages_people_have[i]+ "/" +type_drink[i]+"/"+type_extra[i]+"/"+type_dessert[i]);

        // }
        // int total = 0;
        // Payment payment = new Payment();
        // Console.WriteLine("\nTime is: ");
        // CoffeeShop coffeeshop = new CoffeeShop();
        // coffeeshop.work_time = Convert.ToDouble(Console.ReadLine());
        // coffeeshop.Time();

    //     Console.WriteLine("\nCharacters details:");
    //     Character Obj = new Character();
    //     Obj.name = Console.ReadLine();
    //     Obj.mess_Name();
    //     Console.WriteLine("Name: " + Obj.name + "\nOccupation: " + Obj.Role);

    //     string aux;
    //     Beverage drink = new Beverage();
    //     Dessert dessert = new Dessert();
    //     Console.WriteLine("\nWhat would you like to drink?");
    //     aux = Console.ReadLine();
    //     drink.setBeverage(aux);
    //     drink.descr();

    //     string coff_temp, beans_temp;
    //     if (String.Equals("coffee", aux))
    //     {
    //         Coffee new_coffee = new Coffee();
    //         coff_temp = Console.ReadLine();
    //         new_coffee.choose_coffee(coff_temp);
    //         new_coffee.choose();
    //         Console.WriteLine("what beans you prefer for your coffee?");
    //         beans_temp = Console.ReadLine();
    //         new_coffee.bean(beans_temp);
            
    //         new_coffee.coffee_bean();
    //         total+=new_coffee.getPrice();
    //     }else if(String.Equals("tea",aux)){
    //         Tea tea = new Tea();
    //         tea.choose();
    //         total+=tea.getPrice();
    //     }
    //     if (aux == "coffee" || aux == "tea")
    //     {   
    //         string quest;
    //         string extra_temp;
    //         Console.WriteLine("\nWould you like something extra to the beverage?");
    //         quest = Console.ReadLine();
    //         if (quest =="Yes, please")
    //         {
    //             Extra extra_drink = new Extra();
    //             extra_temp = Console.ReadLine();
    //             extra_drink.adds(extra_temp);
    //             extra_drink.extra_beverage();
    //             total+=extra_drink.getPrice();
    //         }
    //     }
    //     Console.WriteLine("\nDo you want a dessert to the beverage?\n");
    //     string choice = Console.ReadLine();
    //     if(String.Equals(choice,"yes")){
    //         dessert.setDessert();
    //         total+=dessert.getPrice();
    //     }
    //         string tipq;
    //         Console.WriteLine("\nTips?");
    //         tipq = Console.ReadLine();
    //         if (tipq == "Yes, sure!")
    //         {
    //             Tips tipm = new Tips();
    //             tipm.tip = Convert.ToDouble(Console.ReadLine());
    //             total+=Convert.ToInt32(tipm.tip);
    //             Console.WriteLine("Thank you very much!");
    //         }
    //         else 
    //             {Console.WriteLine("Okay, sure");}
            
    //         payment.pay_bill(total);
            
    //         Console.WriteLine("Have a nice day, Sir/Ma'am!");
     }
}
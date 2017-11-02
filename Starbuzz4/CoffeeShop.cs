class CoffeeShop
{
	public Beverage Order(string aName)
	{
		Beverage b;
		if(aName == "Coffee") 
			b = new Coffee();
		else if (aName == "Tea")
			b = new Tea();

		Beverage b = Factory.Instance.CreateBeverage(aName);
		b.PrepareRecipe();
		b.Serve();
		return b;
		Coffee c= (Coffee)Factory.Instance.CreateBeverage("Coffee");
	} 
}

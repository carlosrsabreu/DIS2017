public T CreateBeverage<T>()
{
	return Cast<T>(
		CreateBeverage(
			typeof(T).Name));
}
public T Cast<T>(object o)
{
	return (T) 0;
}

//criar um café através da factory:

Coffee c = Factory.Instance.CreateBeverage<Coffee>();

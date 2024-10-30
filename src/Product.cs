using System;

public class Product
{
	public Product()
	{
	}

	public Guid Id { get; set; }

	public string Name { get; set; } = default!;

	public string Category { get; set; }

	public string Description { get; set; }
}

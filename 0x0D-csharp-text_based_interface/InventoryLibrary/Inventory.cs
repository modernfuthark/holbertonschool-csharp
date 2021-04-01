using System;

class Inventory : BaseClass
{
	public int quantity {get; set;}
	public int user_id {get; set;}
	public int item_id {get; set;}

	public Inventory(int quantity = 1, int user_id, int item_id)
	{
		if (quantity <= 0) {
			quantity = 1;
		}
		this.quantity = quantity;
		this.user_id = user_id;
		this.item_id = item_id;
	}
}

using System;

class BaseClass
{
    public string id {get; set;}
    public DateTime date_created {get; set;}
    public DateTime date_updated {get; set;}

    public BaseClass(string id)
    {
        this.id = id;
    }
}

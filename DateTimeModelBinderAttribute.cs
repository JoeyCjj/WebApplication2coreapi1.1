using Microsoft.AspNetCore.Mvc;

public class DateTimeModelBinderAttribute : ModelBinderAttribute
{
    public string DateFormat { get; set; }

    public DateTimeModelBinderAttribute(): base()
    {
    }
}
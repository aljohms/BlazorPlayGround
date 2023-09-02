
using System.Reflection;
using System.Runtime.InteropServices;

namespace BlazorPlayGround.Client;
public class GridColumn<T>
{
    public PropertyInfo Property { get; set; }
    public string Title { get; set; }
//construct
    public GridColumn(PropertyInfo property)
    {
        Property = property;
        Title = property.Name;
    }
    public GridColumn( string title, PropertyInfo property)
    {
        Property = property;
        Title = title;
    }    
    public GridColumn( string title, string propertyName)
    {

        Property = typeof(T).GetProperty(propertyName);
        Title = title;
    }
    public object GetValue(T item)
    {
        return Property.GetValue(item);
    }

}



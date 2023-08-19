
using System.Reflection;

namespace BlazorPlayGround.Client;
public class GridColumn<T>
{
    public PropertyInfo Property { get; set; }
    public string Title { get; set; }
}
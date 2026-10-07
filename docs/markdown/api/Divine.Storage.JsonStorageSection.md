# <a id="Divine_Storage_JsonStorageSection"></a> Class JsonStorageSection

Namespace: [Divine.Storage](Divine.Storage.md)  
Assembly: Divine.Common.dll  

```csharp
public abstract class JsonStorageSection : ObservableObject, INotifyPropertyChanged, INotifyPropertyChanging, IJsonStorageSection<JsonStorageSection>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ObservableObject](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject) ← 
[JsonStorageSection](Divine.Storage.JsonStorageSection.md)

#### Implements

[INotifyPropertyChanged](https://learn.microsoft.com/dotnet/api/system.componentmodel.inotifypropertychanged), 
[INotifyPropertyChanging](https://learn.microsoft.com/dotnet/api/system.componentmodel.inotifypropertychanging), 
[IJsonStorageSection<JsonStorageSection\>](Divine.Storage.IJsonStorageSection\-1.md)

#### Inherited Members

[ObservableObject.OnPropertyChanged\(PropertyChangedEventArgs\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.onpropertychanged\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-onpropertychanged\(system\-componentmodel\-propertychangedeventargs\)), 
[ObservableObject.OnPropertyChanging\(PropertyChangingEventArgs\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.onpropertychanging\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-onpropertychanging\(system\-componentmodel\-propertychangingeventargs\)), 
[ObservableObject.OnPropertyChanged\(string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.onpropertychanged\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-onpropertychanged\(system\-string\)), 
[ObservableObject.OnPropertyChanging\(string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.onpropertychanging\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-onpropertychanging\(system\-string\)), 
[ObservableObject.SetProperty<T\>\(ref T, T, string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.setproperty\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-setproperty\-1\(\-0@\-0\-system\-string\)), 
[ObservableObject.SetProperty<T\>\(ref T, T, IEqualityComparer<T\>, string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.setproperty\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-setproperty\-1\(\-0@\-0\-system\-collections\-generic\-iequalitycomparer\(\(\-0\)\)\-system\-string\)), 
[ObservableObject.SetProperty<T\>\(T, T, Action<T\>, string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.setproperty\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-setproperty\-1\(\-0\-0\-system\-action\(\(\-0\)\)\-system\-string\)), 
[ObservableObject.SetProperty<T\>\(T, T, IEqualityComparer<T\>, Action<T\>, string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.setproperty\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-setproperty\-1\(\-0\-0\-system\-collections\-generic\-iequalitycomparer\(\(\-0\)\)\-system\-action\(\(\-0\)\)\-system\-string\)), 
[ObservableObject.SetProperty<TModel, T\>\(T, T, TModel, Action<TModel, T\>, string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.setproperty\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-setproperty\-2\(\-1\-1\-0\-system\-action\(\(\-0\-1\)\)\-system\-string\)), 
[ObservableObject.SetProperty<TModel, T\>\(T, T, IEqualityComparer<T\>, TModel, Action<TModel, T\>, string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.setproperty\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-setproperty\-2\(\-1\-1\-system\-collections\-generic\-iequalitycomparer\(\(\-1\)\)\-0\-system\-action\(\(\-0\-1\)\)\-system\-string\)), 
[ObservableObject.SetPropertyAndNotifyOnCompletion\(ref ObservableObject.TaskNotifier?, Task?, string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.setpropertyandnotifyoncompletion\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-setpropertyandnotifyoncompletion\(communitytoolkit\-mvvm\-componentmodel\-observableobject\-tasknotifier@\-system\-threading\-tasks\-task\-system\-string\)), 
[ObservableObject.SetPropertyAndNotifyOnCompletion\(ref ObservableObject.TaskNotifier?, Task?, Action<Task?\>, string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.setpropertyandnotifyoncompletion\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-setpropertyandnotifyoncompletion\(communitytoolkit\-mvvm\-componentmodel\-observableobject\-tasknotifier@\-system\-threading\-tasks\-task\-system\-action\(\(system\-threading\-tasks\-task\)\)\-system\-string\)), 
[ObservableObject.SetPropertyAndNotifyOnCompletion<T\>\(ref ObservableObject.TaskNotifier<T\>?, Task<T\>?, string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.setpropertyandnotifyoncompletion\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-setpropertyandnotifyoncompletion\-1\(communitytoolkit\-mvvm\-componentmodel\-observableobject\-tasknotifier\(\(\-0\)\)@\-system\-threading\-tasks\-task\(\(\-0\)\)\-system\-string\)), 
[ObservableObject.SetPropertyAndNotifyOnCompletion<T\>\(ref ObservableObject.TaskNotifier<T\>?, Task<T\>?, Action<Task<T\>?\>, string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.setpropertyandnotifyoncompletion\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-setpropertyandnotifyoncompletion\-1\(communitytoolkit\-mvvm\-componentmodel\-observableobject\-tasknotifier\(\(\-0\)\)@\-system\-threading\-tasks\-task\(\(\-0\)\)\-system\-action\(\(system\-threading\-tasks\-task\(\(\-0\)\)\)\)\-system\-string\)), 
[ObservableObject.PropertyChanged](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.propertychanged), 
[ObservableObject.PropertyChanging](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.propertychanging), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<JsonStorageSection\>\(JsonStorageSection, params JsonStorageSection\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Storage_JsonStorageSection__ctor"></a> JsonStorageSection\(\)

```csharp
protected JsonStorageSection()
```


# <a id="Divine_Storage_IJsonStorageSection_1"></a> Interface IJsonStorageSection<T\>

Namespace: [Divine.Storage](Divine.Storage.md)  
Assembly: Divine.Common.dll  

```csharp
public interface IJsonStorageSection<out T> where T : INotifyPropertyChanged
```

#### Type Parameters

`T` 

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<IJsonStorageSection<T\>\>\(IJsonStorageSection<T\>, params IJsonStorageSection<T\>\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

### <a id="Divine_Storage_IJsonStorageSection_1_PropertyChanged"></a> PropertyChanged

```csharp
event PropertyChangedEventHandler? PropertyChanged
```

#### Event Type

 [PropertyChangedEventHandler](https://learn.microsoft.com/dotnet/api/system.componentmodel.propertychangedeventhandler)?


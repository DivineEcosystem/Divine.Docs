# <a id="System_SyncProgress_1"></a> Class SyncProgress<T\>

Namespace: [System](System.md)  
Assembly: Divine.Common.dll  

```csharp
public class SyncProgress<T> : IProgress<T>
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SyncProgress<T\>](System.SyncProgress\-1.md)

#### Implements

[IProgress<T\>](https://learn.microsoft.com/dotnet/api/system.iprogress\-1)

#### Inherited Members

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
[EnumerableExtensions.In<SyncProgress<T\>\>\(SyncProgress<T\>, params SyncProgress<T\>\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="System_SyncProgress_1__ctor_System_Action__0__"></a> SyncProgress\(Action<T\>\)

```csharp
public SyncProgress(Action<T> handler)
```

#### Parameters

`handler` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

## Methods

### <a id="System_SyncProgress_1_Report__0_"></a> Report\(T\)

```csharp
public void Report(T value)
```

#### Parameters

`value` T


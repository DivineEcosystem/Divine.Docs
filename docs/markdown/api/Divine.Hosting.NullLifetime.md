# <a id="Divine_Hosting_NullLifetime"></a> Class NullLifetime

Namespace: [Divine.Hosting](Divine.Hosting.md)  
Assembly: Divine.Common.dll  

```csharp
public sealed class NullLifetime : IHostLifetime
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[NullLifetime](Divine.Hosting.NullLifetime.md)

#### Implements

[IHostLifetime](https://learn.microsoft.com/dotnet/api/microsoft.extensions.hosting.ihostlifetime)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<NullLifetime\>\(NullLifetime, params NullLifetime\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Hosting_NullLifetime__ctor"></a> NullLifetime\(\)

```csharp
public NullLifetime()
```

## Methods

### <a id="Divine_Hosting_NullLifetime_StopAsync_System_Threading_CancellationToken_"></a> StopAsync\(CancellationToken\)

```csharp
public Task StopAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="Divine_Hosting_NullLifetime_WaitForStartAsync_System_Threading_CancellationToken_"></a> WaitForStartAsync\(CancellationToken\)

```csharp
public Task WaitForStartAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)


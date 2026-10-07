# <a id="Divine_Update_InvokeHandler"></a> Class InvokeHandler

Namespace: [Divine.Update](Divine.Update.md)  
Assembly: Divine.dll  

```csharp
public class InvokeHandler
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InvokeHandler](Divine.Update.InvokeHandler.md)

#### Derived

[TimeoutHandler](Divine.Update.TimeoutHandler.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<InvokeHandler\>\(InvokeHandler, params InvokeHandler\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Update_InvokeHandler_Default"></a> Default

```csharp
public static InvokeHandler Default { get; }
```

#### Property Value

 [InvokeHandler](Divine.Update.InvokeHandler.md)

## Methods

### <a id="Divine_Update_InvokeHandler_Invoke_System_Action_"></a> Invoke\(Action\)

```csharp
public virtual bool Invoke(Action callback)
```

#### Parameters

`callback` [Action](https://learn.microsoft.com/dotnet/api/system.action)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Update_InvokeHandler_Reset"></a> Reset\(\)

```csharp
public virtual void Reset()
```

### <a id="Divine_Update_InvokeHandler_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

